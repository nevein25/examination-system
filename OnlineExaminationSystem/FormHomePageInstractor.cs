using MetroSet_UI.Forms;
using Microsoft.EntityFrameworkCore;
using OnlineExaminationSystem.Context;
using OnlineExaminationSystem.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineExaminationSystem
{
    public partial class FormHomePageInstractor : MetroSetForm
    {
        OnlineExaminationSystemContext _context = new OnlineExaminationSystemContext();
        public FormHomePageInstractor()
        {
            InitializeComponent();
        }



        private void FormHomePageInstractor_Load(object sender, EventArgs e)
        {

            List<Course> courses = _context.Courses.ToList();
            List<Instructor> instructors = _context.Instructors.ToList();
            List<Department> departments = _context.Departments.ToList();

            /// assign course
            comboCourses.DataSource = courses;
            comboCourses.DisplayMember = "Name";
            comboCourses.ValueMember = "Id";


            comboInstructor.DataSource = instructors;
            comboInstructor.DisplayMember = "FullName";
            comboInstructor.ValueMember = "Id";
            ///

            /// assign department
            comboInstructorDep.DataSource = instructors;
            comboInstructorDep.DisplayMember = "FullName";
            comboInstructorDep.ValueMember = "Id";

            comboDepartment.DataSource = departments;
            comboDepartment.DisplayMember = "Name";
            comboDepartment.ValueMember = "Id";

            /// 
        }

        private void btnAssignCourse_Click(object sender, EventArgs e)
        {
            try
            {

                var instructorId = Convert.ToInt32(comboInstructor.SelectedValue);
                var courseId = Convert.ToInt32(comboCourses.SelectedValue);

                bool isAssignedCourse = _context.Instructors
                .Where(i => i.Id == instructorId)
                .SelectMany(i => i.CIds)
                .Any(c => c.Id == courseId);

                if (!isAssignedCourse)
                {
                    _context.Database.ExecuteSqlInterpolated($"Exec [AddInstructorCrs] {instructorId}, {courseId}");
                    MessageBox.Show("Course Assigned successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("The Instructor is already assigned to this course", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            catch
            {
                MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnAssignDepartment_Click(object sender, EventArgs e)
        {
            try
            {

                int instructorId = Convert.ToInt32(comboInstructorDep.SelectedValue);
                int deptId = Convert.ToInt32(comboDepartment.SelectedValue);

                Instructor instructor = _context.Instructors.Where(i => i.Id == instructorId).FirstOrDefault();

                //bool isAssignedDept = _context.Instructors
                //.Any(i => i.Id == instructorId && i.DeptId == deptId);

                if (instructor.DeptId != deptId)
                {
                    instructor.DeptId = deptId;
                    _context.SaveChanges();
                    MessageBox.Show("Department Assigned successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("The Instructor is already assigned to this Department", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            catch
            {
                MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
