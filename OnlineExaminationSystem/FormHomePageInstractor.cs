using MetroSet_UI.Forms;
using Microsoft.EntityFrameworkCore;
using OnlineExaminationSystem.Context;
using OnlineExaminationSystem.Entities;
using OnlineExaminationSystem.Helpers;
using System.Data;

namespace OnlineExaminationSystem
{
    public partial class FormHomePageInstractor : MetroSetForm
    {
        OnlineExaminationSystemContext _context = new OnlineExaminationSystemContext();
        public FormHomePageInstractor()
        {
            InitializeComponent();
            InitilizeShowCoursesTab();
        }



        private void FormHomePageInstractor_Load(object sender, EventArgs e)
        {

            List<Course> courses = _context.Courses.ToList();
            List<Instructor> instructors = _context.Instructors.ToList();
            List<Student> students = _context.Students.ToList();

            List<Department> departments = _context.Departments.ToList();

            /// assign course
            comboCourses.DataSource = courses;
            comboCourses.DisplayMember = "Name";
            comboCourses.ValueMember = "Id";


            comboInstructorC.DataSource = instructors;
            comboInstructorC.DisplayMember = "FullName";
            comboInstructorC.ValueMember = "Id";


            comboStudentC.DataSource = students;
            comboStudentC.DisplayMember = "FullName";
            comboStudentC.ValueMember = "Id";
            ///

            /// assign department
            comboInstructorDep.DataSource = instructors;
            comboInstructorDep.DisplayMember = "FullName";
            comboInstructorDep.ValueMember = "Id";

            comboDepartment.DataSource = departments;
            comboDepartment.DisplayMember = "Name";
            comboDepartment.ValueMember = "Id";

            comboStudentD.DataSource = students;
            comboStudentD.DisplayMember = "FullName";
            comboStudentD.ValueMember = "Id";

            /// 

            ///
            comboCorsesesForTopics.DataSource = courses;
            comboCorsesesForTopics.DisplayMember = "Name";
            comboCorsesesForTopics.ValueMember = "Id";
            ///
        }

        private void btnAssignCourse_Click(object sender, EventArgs e)
        {
            var courseId = Convert.ToInt32(comboCourses.SelectedValue);
            if (!lblStudentC.Visible)
            {
                try
                {

                    var instructorId = Convert.ToInt32(comboInstructorC.SelectedValue);

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
            else
            {
                try
                {

                    var studentId = Convert.ToInt32(comboStudentC.SelectedValue);

                    bool isAssignedCourse = _context.Students
                    .Where(i => i.Id == studentId)
                    .SelectMany(i => i.CIds)
                    .Any(c => c.Id == courseId);

                    if (!isAssignedCourse)
                    {
                        _context.Database.ExecuteSqlInterpolated($"Exec [AddStudentCourse] {studentId}, {courseId}");
                        MessageBox.Show("Course Assigned successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("The Student is already assigned to this course", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
                catch
                {
                    MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void btnAssignDepartment_Click(object sender, EventArgs e)
        {
            int deptId = Convert.ToInt32(comboDepartment.SelectedValue);
            if (!lblStudentD.Visible)
            {
                try
                {

                    int instructorId = Convert.ToInt32(comboInstructorDep.SelectedValue);

                    Instructor instructor = _context.Instructors.Where(i => i.Id == instructorId).FirstOrDefault();

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
            else
            {
                try
                {

                    int studentId = Convert.ToInt32(comboStudentD.SelectedValue);

                    Student student = _context.Students.Where(i => i.Id == studentId).FirstOrDefault();

                    if (student.DeptId != deptId)
                    {
                        student.DeptId = deptId;
                        _context.SaveChanges();
                        MessageBox.Show("Department Assigned successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("The Student is already assigned to this Department", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
                catch
                {
                    MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void lblAssignCourse_Click(object sender, EventArgs e)
        {
            lblStudentC.Visible = !lblStudentC.Visible;
            comboStudentC.Visible = !comboStudentC.Visible;

            lblInstructorC.Visible = !lblInstructorC.Visible;
            comboInstructorC.Visible = !comboInstructorC.Visible;

            if (!lblStudentC.Visible)
                lblAssignCourseStudentQ.Text = "Assign Course for Student?";
            else
                lblAssignCourseStudentQ.Text = "Assign Course for Instructor?";
        }

        private void label2_Click(object sender, EventArgs e)
        {
            lblStudentD.Visible = !lblStudentD.Visible;
            comboStudentD.Visible = !comboStudentD.Visible;

            lblInstructorD.Visible = !lblInstructorD.Visible;
            comboInstructorDep.Visible = !comboInstructorDep.Visible;

            if (!lblStudentD.Visible)
                lblAssignDepartmentStudentQ.Text = "Assign Department for Student?";
            else
                lblAssignDepartmentStudentQ.Text = "Assign Department for Instructor?";
        }

        private void InitilizeShowCoursesTab()
        {
            lstTopics.BackColor = Color.WhiteSmoke;
            lstTopics.Font = new Font("Century Gothic", 13F);
            lstTopics.ForeColor = Color.Gray;
            lstTopics.SelectedItemBackColor = Color.FromArgb(186, 32, 38);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var topics = _context.Topics.FromSql($"CourseWithTopics {comboCourses.SelectedValue}").ToList();

            //grdTopics.DataSource = topics;
            //grdTopics.Columns["CId"].Visible = false;
            //grdTopics.Columns["TId"].Visible = false;
            //grdTopics.Columns["CIdNavigation"].Visible = false;

            lstTopics.Items.Clear();
            lstTopics.Items.AddRange(topics.Select(t => t.Name));

        }

        private void btnNewCourse_Click(object sender, EventArgs e)
        {
            using (FormAddCourseTopics frmAddCorseTopics = new FormAddCourseTopics())
            {
                frmAddCorseTopics.StartPosition = FormStartPosition.CenterScreen;

                Helper.HideFormSmoothly(this);

                frmAddCorseTopics.ShowDialog();
            }
        }
    }
}
