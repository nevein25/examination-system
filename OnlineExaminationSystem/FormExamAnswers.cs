//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using MetroSet_UI.Forms;
//using Microsoft.EntityFrameworkCore;
//using OnlineExaminationSystem.Context;
//using OnlineExaminationSystem.Entities;


//namespace OnlineExaminationSystem
//{
//    public partial class FormExamAnswers : MetroSetForm
//    {
//        OnlineExaminationSystemContext context = new();
//        BindingSource bindingSource;

//        public FormExamAnswers()
//        {
//            InitializeComponent();


//            this.FormClosing += (sender, e) => context?.Dispose();

//        }

//        private void FormExamAnswers_Load(object sender, EventArgs e)
//        {
//            context.Exams.Load();
//            context.Questions.Load();
//            context.QuestionAnswers.Load();
//            int count = 0;
//            int CrsID = context.Exams?.FirstOrDefault(e => e.Id == 1)?.CId ?? 0;
//            CourseName.Text = context.Courses.FirstOrDefault(c => c.Id == CrsID)?.Name;
//            drt.Text = context.Exams.FirstOrDefault(e => e.Id == 1)?.Duration?.ToString() + " Hours" ?? "N/A";
//            var exam = context.Exams.FirstOrDefault(e => e.Id == 1);
//            List<Question> questionsInExam = new List<Question>();


//            if (exam != null)
//            {
//                questionsInExam = exam.QIds.ToList();

//                // Now you can proceed with your logic

//                if (count == 0)
//                {
//                    PrevBtn.Enabled = false;
//                }

//                else if (count == questionsInExam.Count - 1)
//                {
//                    NextBtn.Text = "Submit";
//                }
//                List<QuestionAnswer> answersInExam;

//                if (count >=0 && count < questionsInExam.Count)
//                {
//                    QuesText.Text = questionsInExam[count].QuestionText.ToString();
//                    answersInExam = questionsInExam[count].QuestionAnswers.ToList();
//                    if (questionsInExam[count].Type == "MCQ")
//                    {
//                        Ch1.Text = answersInExam[0].AnswerText;
//                        Ch2.Text = answersInExam[1].AnswerText;
//                        Ch3.Text = answersInExam[2].AnswerText;

//                    }
//                    else
//                    {
//                        Ch1.Text = "True";
//                        Ch2.Visible = false;
//                        Ch3.Text = "False";
//                    }
//                }


//            }



//            // Marks.Text=context.
//        }

//        private void metroSetLabel1_Click(object sender, EventArgs e)
//        {

//        }

//        private void metroSetLabel1_Click_1(object sender, EventArgs e)
//        {

//        }

//        private void metroSetButton2_Click(object sender, EventArgs e)
//        {

//        }

//        private void drt_Click(object sender, EventArgs e)
//        {

//        }

//        private void CourseName_Click(object sender, EventArgs e)
//        {

//        }

//        private void Marks_Click(object sender, EventArgs e)
//        {

//        }

//        private void metroSetRadioButton3_CheckedChanged(object sender)
//        {

//        }
//    }
//}



using MetroSet_UI.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using OnlineExaminationSystem.Context;
using OnlineExaminationSystem.Entities;

namespace OnlineExaminationSystem
{
    public partial class FormExamAnswers : MetroSetForm
    {
        private int count = 0; // Initialize count here
        List<Question> questionsInExam = new List<Question>();
        List<String> StudentAnswers = new List<String>(10);
        List<bool> IsChecked = new List<bool>(10);
        private Question currentQuestion;
        private OnlineExaminationSystemContext context;

        public FormExamAnswers()
        {
            InitializeComponent();
        }

        private void FormExamAnswers_Load(object sender, EventArgs e)
        {
            context = new OnlineExaminationSystemContext();

            context.Exams.Load();
            context.Questions.Load();
            context.QuestionAnswers.Load();
            
            int CrsID = context.Exams?.FirstOrDefault(e => e.Id == 1)?.CId ?? 0;
            CourseName.Text = context.Courses.FirstOrDefault(c => c.Id == CrsID)?.Name;
            drt.Text = context.Exams.FirstOrDefault(e => e.Id == 1)?.Duration?.ToString() + " Hours" ?? "N/A";


            var exam = context.Exams.Include(e => e.QIds).ThenInclude(q => q.QuestionAnswers).FirstOrDefault(e => e.Id == 1);

            int totalMarks = exam.QIds.Sum(q => q.Mark);
            Marks.Text = totalMarks.ToString();
            questionsInExam = exam.QIds.ToList();
            LoadQuestionAndAnswers();


        }

        private void LoadQuestionAndAnswers()
        {

            //MessageBox.Show("Count: " + count);
            if (count == 0)
            {
                PrevBtn.Enabled = false;
            }
            else
            {
                PrevBtn.Enabled = true;
            }

            if (count == questionsInExam.Count)
            {

                NextBtn.Text = "Submit";
                //if (StudentAnswers.Count<10)
                //{
                //    NextBtn.Enabled = false;
                //}
                //else
                //{
                //    NextBtn.Enabled = true;

                //}

            }
            else
            {
                NextBtn.Text = "Next";
            }

            if (count >= 0 && count < questionsInExam.Count)
            {
                currentQuestion = questionsInExam[count];

                int Qnum = count + 1;
                QuestionNumber.Text = "Q" + Qnum + ".";
                QuesText.Text = currentQuestion.QuestionText.ToString();
                var answersInQuestion = currentQuestion.QuestionAnswers.ToList();

                if (currentQuestion.Type == "MCQ")
                {
                    Ch1.Text = answersInQuestion[0].AnswerText;
                    Ch2.Text = answersInQuestion[1].AnswerText;
                    Ch3.Text = answersInQuestion[2].AnswerText;
                    Ch2.Visible = true;
                }
                else if (currentQuestion.Type == "TF")
                {
                    Ch1.Text = answersInQuestion[0].AnswerText;
                    Ch2.Visible = false;
                    Ch3.Text = answersInQuestion[1].AnswerText;
                }
            }
            this.Refresh();
        }

        private void NextBtn_Click_1(object sender, EventArgs e)
        {
            bool flag = false;
            if (NextBtn.Text == "Next")
            {

                NextBtn.Enabled = true;
               
                if (currentQuestion.Type == "MCQ")
                {
                    if (count >= 0 && count < 10)
                    {

                        if (Ch1.Checked)
                            {
                            StudentAnswers.Insert(count, Ch1.Text);
                            IsChecked.Insert(count, true);
                            }
                            else if (Ch2.Checked)
                            {
                            StudentAnswers.Insert(count, Ch2.Text);
                            IsChecked.Insert(count, true);

                            }
                        else if (Ch3.Checked)
                            {
                            StudentAnswers.Insert(count, Ch3.Text);
                            IsChecked.Insert(count, true);


                        }
                        else
                        {
                            StudentAnswers.Insert(count, " ");
                            IsChecked.Insert(count, false);

                        }



                    }
                }


                else if (currentQuestion.Type == "TF")
                {

                    if (count >= 0 && count < 10)
                    {



                        if (Ch1.Checked)
                            {
                            StudentAnswers.Insert(count, Ch1.Text);
                            IsChecked.Insert(count, true);


                        }

                        else if (Ch3.Checked)
                            {
                            StudentAnswers.Insert(count, Ch3.Text);
                            IsChecked.Insert(count, true);


                        }
                        else
                        {
                            StudentAnswers.Insert(count, " ");
                            IsChecked.Insert(count, false);


                        }

                    }
                    
                }
                for (int i = 0; i < StudentAnswers.Count; i++)
                {
                    if (StudentAnswers[i]== " ")
                    {
                        flag = true;
                    }
                }


                if (IsChecked[count]) { 
                    if (Ch1.Checked) { Ch1.Checked = true; } 
                    else if (Ch2.Checked) { Ch2.Checked = true; } 
                    else if (Ch3.Checked) { Ch3.Checked = true; } }
                else
                {        
                    Ch1.Checked = false;        
                    Ch2.Checked = false;         
                    Ch3.Checked = false;    
                }

                    count++;


                LoadQuestionAndAnswers();
            }

            else if (NextBtn.Text == "Submit" && flag == true)
            {
                MessageBox.Show(StudentAnswers.Count.ToString());
                NextBtn.Enabled = false;

            }
            else if (NextBtn.Text == "Submit" && flag == false)

            {
                MessageBox.Show(StudentAnswers.Count.ToString());
                SaveStudentAnswers();
            }
            MessageBox.Show(StudentAnswers.Count.ToString());

        }
        private void PrevBtn_Click_1(object sender, EventArgs e)
        {
            count--;
            if (count >= 0 && count < IsChecked.Count)
            {
                if (IsChecked[count])
                {
                    Ch1.Checked = true;
                    Ch2.Checked = true;
                    Ch3.Checked = true;
                }
                else
                {
                    Ch1.Checked = false;
                    Ch2.Checked = false;
                    Ch3.Checked = false;
                }
            }
            LoadQuestionAndAnswers();
        }

        private void SaveStudentAnswers()
        {
            int studentId = 1; // Assuming student ID is 1 for now.
            string studentFname = context.People.FirstOrDefault(s => s.Id == studentId)?.Fname;
            string studentLName = context.People.FirstOrDefault(s => s.Id == studentId)?.Lname;
            string fullName = studentFname + " " + studentLName;

            // Call the stored procedure to insert student answers.
            // Replace "InsertStudentExamAnswers" with the actual name of your stored procedure.
            // Adjust the parameters according to your stored procedure's signature.
            var Result = context.Database.ExecuteSqlRaw("EXEC GetStudentExamAnswers {0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10} , {11}",
                studentId, fullName, StudentAnswers[0], StudentAnswers[1], StudentAnswers[2],
                StudentAnswers[3], StudentAnswers[4], StudentAnswers[5], StudentAnswers[6],
                StudentAnswers[7], StudentAnswers[8], StudentAnswers[9]);


            // Save changes to the database.
            context.SaveChanges();
            MessageBox.Show(Result.ToString());

        }

        private void ctrlBox_Click(object sender, EventArgs e)
        {

        }

        private void FormExamAnswers_FormClosed(object sender, FormClosedEventArgs e)
        {
            context.Dispose();
        }
       
    }
}