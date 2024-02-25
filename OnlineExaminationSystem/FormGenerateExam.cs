using MetroSet_UI.Forms;
using Microsoft.EntityFrameworkCore;
using OnlineExaminationSystem.Context;
using OnlineExaminationSystem.Entities;
using OnlineExaminationSystem.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineExaminationSystem
{
    public partial class FormGenerateExam : MetroSetForm
    {
        OnlineExaminationSystemContext _context = new OnlineExaminationSystemContext();
        BindingSource CoursePindingSource;
        string CourseName;
        int NumOfTFQuestions, NumOfMCQ_Questions;
        public FormGenerateExam()
        {
            InitializeComponent();
            this.FormClosed += (sender, e) => _context?.Dispose();


        }

        private void FormGenerateExam_Load(object sender, EventArgs e)
        {
            _context.Courses.Load();

            CoursePindingSource = new BindingSource(_context.Courses.Local.ToBindingList(), "");


            List<Course> courses = _context.Courses.ToList();
            cmb_Courses.DataSource = courses;
            cmb_Courses.DisplayMember = "Name";
            cmb_Courses.ValueMember = "Name";






            /*this.cmb_Courses.DataSource = _context.Courses.ToList();
            this.cmb_Courses.DisplayMember = "Name";
            this.cmb_Courses.ValueMember = "Name";
            this.cmb_Courses.DataBindings.Add("SelectedValue", CoursePindingSource, "Name");*/



        }


        private void btn_generateExam_Click(object sender, EventArgs e)
        {
            try
            {
                string CourseNamee = cmb_Courses.SelectedValue.ToString();
                NumOfTFQuestions = (int)numeric_TFQuestions.Value;
                NumOfMCQ_Questions = (int)numeric_MCQ_Questions.Value;
                int day = DateTimeForExam.SelectionStart.Day;
                int month = DateTimeForExam.SelectionStart.Month;
                int year = DateTimeForExam.SelectionStart.Year;
                int duration = (int)numeric_Duration.Value;
                bool flag = true;
                string errorMessage = "";

                if (NumOfTFQuestions == 0 || NumOfMCQ_Questions == 0)
                {
                    errorMessage = "num of questions must not be zero";
                    flag = false;
                }

                if (NumOfTFQuestions > 3)
                {
                    errorMessage = "num of TF questions must not exceed 3";
                    flag = false;
                }
                if (NumOfMCQ_Questions > 7)
                {
                    flag = false;
                    errorMessage = "num of MCQ questions must not exceed 7";
                }

                if (DateTime.Now.Date > DateTimeForExam.SelectionStart.Date)
                {
                    flag = false;
                    errorMessage = "Please choose sufficient date";
                }
                if (duration==0)
                {
                    errorMessage = "Duration must not be zero";
                    flag = false;
                }


                var result = _context.Database.ExecuteSql($"SP_GenerateExam {CourseNamee},{NumOfTFQuestions},{NumOfMCQ_Questions},{year},{month},{day},{duration}");

                if (result > 0 && flag == true)
                {
                    MessageBox.Show("Exam is generated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (flag == false)
                {
                    MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    errorMessage = string.Empty;
                }
                else
                {
                    MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    errorMessage = string.Empty;
                }

            }

            catch (Exception ex)
            {
                
                MessageBox.Show("Something Went Wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            this.cmb_Courses.Refresh();



        }

        private void btn_back_Click(object sender, EventArgs e)
        {

            using (FormHomeInstructor frmHomeInstructor = new FormHomeInstructor())
            {
                frmHomeInstructor.StartPosition = FormStartPosition.CenterScreen;

                Helper.HideFormSmoothly(this);

                frmHomeInstructor.ShowDialog();
            }
        }

        
    }
}
