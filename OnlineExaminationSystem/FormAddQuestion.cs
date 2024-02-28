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
using static System.Net.Mime.MediaTypeNames;

namespace OnlineExaminationSystem
{
    public partial class FormAddQuestion : MetroSetForm
    {
        OnlineExaminationSystemContext _context = new OnlineExaminationSystemContext();

        public FormAddQuestion()
        {
            InitializeComponent();
            this.FormClosed += (sender, e) => _context?.Dispose();

        }

        private void FormAddQuestion_Load(object sender, EventArgs e)
        {
            _context.Courses.Load();

            List<Course> courses = _context.Courses.ToList();
            cmbCourses.DataSource = courses;
            cmbCourses.DisplayMember = "Name";
            cmbCourses.ValueMember = "Id";

            List<string> Types = new List<string>() { "MCQ", "TF" };
            cmbType.DataSource = Types;

            List<string> Complexity = new List<string>() { "E", "M", "H" };
            cmbComplexity.DataSource = Complexity;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {

            try
            {
                bool flag = true;
                string msg = "";
                List<string> QuestionAnswers = new List<string>();
                int courseId = (int)cmbCourses.SelectedValue;
                string type = cmbType.SelectedValue.ToString();
                string complexity = cmbComplexity.SelectedValue.ToString();
                int mark = (int)numMark.Value;
                string questionText = Rh_QuestionText.Text;
                int IndexModelAnsr = cmb_ModelAnswer.SelectedIndex;
                if (mark == 0)
                {
                    msg = "Mark must not be Zero";
                    flag = false;
                }
                if (questionText.Length == 0)
                {
                    msg = "Please Insert Question To Continue the process";
                    flag = false;
                }
                if (type == "TF")
                {
                    QuestionAnswers = new() { "T", "F" };

                }
                else if (type == "MCQ")
                {
                    if (txt_MCQ_Answer1.Text.Length == 0 || txt_MCQ_Answer2.Text.Length == 0 || txt_MCQ_Answer3.Text.Length == 0)
                    {
                        flag = false;
                        msg = "You must Enter 3 Answers";
                    }
                    else
                    {
                        string ModelAsr1 = txt_MCQ_Answer1.Text;
                        string ModelAsr2 = txt_MCQ_Answer2.Text;
                        string ModelAsr3 = txt_MCQ_Answer3.Text;
                        QuestionAnswers = new() { ModelAsr1, ModelAsr2, ModelAsr3 };
                    }
                }
                if (flag == true)
                {
                    var result = _context.Database.ExecuteSql($"InsertQuestion {questionText},{type},{complexity},{mark},{courseId}");
                    if (result > 0)
                    {
                        MessageBox.Show("Question is added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Rh_QuestionText.Text = string.Empty;
                        int QuestionIDRes = _context.Questions.OrderBy(P => P.Id).Select(P => P.Id).Last();
                        for (int i = 0; i < QuestionAnswers.Count; i++)
                        {
                            int ModelAnswerRes = 0;
                            if (i == IndexModelAnsr)
                            {
                                ModelAnswerRes = 1;
                            }
                            else
                            {
                                ModelAnswerRes = 0;
                            }
                            var QuestionAnswerresult = _context.Database.ExecuteSql($"SP_InsertIntoQuestionAnswer {QuestionAnswers[i]},{ModelAnswerRes},{QuestionIDRes}");

                        }
                    }
                    else
                    {
                        msg = "Question Insertion has a problem";
                    }
                }
                if (msg.Length > 0)
                {
                    MessageBox.Show($"{msg}", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something Went Wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> TFModelAnswer = new List<string>() { "True", "False" };
            List<string> MCQModelAnswer = new List<string> { "MCQ Answer 1", "MCQ Answer 2", "MCQ Answer 3" };
            if (cmbType.SelectedValue.ToString() == "TF")
            {
                lb_Answer1.Visible = false;
                lb_Answer2.Visible = false;
                lb_Answer3.Visible = false;
                txt_MCQ_Answer1.Visible = false;
                txt_MCQ_Answer2.Visible = false;
                txt_MCQ_Answer3.Visible = false;
                cmb_ModelAnswer.DataSource = TFModelAnswer;
            }
            else
            {
                lb_Answer1.Visible = true;
                lb_Answer2.Visible = true;
                lb_Answer3.Visible = true;
                txt_MCQ_Answer1.Visible = true;
                txt_MCQ_Answer2.Visible = true;
                txt_MCQ_Answer3.Visible = true;
                cmb_ModelAnswer.DataSource = MCQModelAnswer;
            }
        }
    }
}
