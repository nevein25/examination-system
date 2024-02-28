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
    public partial class FormInstructorGrade : MetroSetForm
    {
        OnlineExaminationSystemContext _context = new OnlineExaminationSystemContext();
        public FormInstructorGrade()
        {
            InitializeComponent();
        }

        private void FormInstructorGrade_Load(object sender, EventArgs e)
        {

            List<Course> courses = _context.Courses.ToList();
            cmb_Courses.DataSource = courses;
            cmb_Courses.DisplayMember = "Name";
            cmb_Courses.ValueMember = "Id";

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            int courseId = (int)cmb_Courses.SelectedValue;

            var query = (from se in _context.StudentExams
                         join s in _context.Students on se.StId equals s.Id
                         join E in _context.Exams on se.EId equals E.Id
                         join C in _context.Courses on E.CId equals C.Id
                         where E.CId == courseId && se.ExamGrade != null && se.IsTaken == 1 // Filter for course ID 1
                         select new
                         {
                             StudentFName = s.Fname,
                             StudentLName = s.Lname,
                             StudentEmail = s.Email,
                             Grade = se.ExamGrade,
                             CourseName = C.Name
                         }).ToList();
            if (query.Count == 0)
            {
                MessageBox.Show("There is no Students Assigned to this course yet", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            grd_StudentsGrades.DataSource = query;
            grd_StudentsGrades.AutoResizeColumns();

        }
    }
}