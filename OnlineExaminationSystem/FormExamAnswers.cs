
//using MetroSet_UI.Forms;
//using Microsoft.Data.SqlClient;
//using Microsoft.EntityFrameworkCore;
//using OnlineExaminationSystem.Context;
//using OnlineExaminationSystem.Entities;

//namespace OnlineExaminationSystem
//{
//    public partial class FormExamAnswers : MetroSetForm
//    {
//        private int count = 0; // Initialize count here
//        List<Question> questionsInExam = new List<Question>();
//        List<String> StudentAnswers = new List<String>();
//        List<bool> IsChecked = new List<bool>();
//        private Question currentQuestion;
//        private OnlineExaminationSystemContext context;

//        public FormExamAnswers()
//        {
//            InitializeComponent();
//        }

//        private void FormExamAnswers_Load(object sender, EventArgs e)
//        {
//            context = new OnlineExaminationSystemContext();

//            //context.Exams.Load();
//            //context.Questions.Load();
//            //context.QuestionAnswers.Load();

//            int CrsID = context.Exams?.FirstOrDefault(e => e.Id == 1)?.CId ?? 0;
//            CourseName.Text = context.Courses.FirstOrDefault(c => c.Id == CrsID)?.Name;
//            drt.Text = context.Exams.FirstOrDefault(e => e.Id == 1)?.Duration?.ToString() + " Hours" ?? "N/A";


//            var exam = context.Exams.Include(e => e.QIds).ThenInclude(q => q.QuestionAnswers).FirstOrDefault(e => e.Id == 1);

//            int totalMarks = exam.QIds.Sum(q => q.Mark);
//            Marks.Text = totalMarks.ToString();
//            questionsInExam = exam.QIds.ToList();

//            for (int i = 0; i < questionsInExam.Count; i++)
//            {
//                StudentAnswers.Add(" ");
//                IsChecked.Add(false);
//            }

//            LoadQuestionAndAnswers();


//        }

//        private void LoadQuestionAndAnswers()
//        {

//           //MessageBox.Show(count.ToString());
//            currentQuestion = questionsInExam[count];
//            int Qnum = count + 1;
//            QuestionNumber.Text = "Q" + Qnum + ".";
//            QuesText.Text = currentQuestion.QuestionText.ToString();
//            var answersInQuestion = currentQuestion.QuestionAnswers.ToList();
//            if (count == 0)
//            {
//                PrevBtn.Enabled = false;
//            }
//            else
//            {
//                PrevBtn.Enabled = true;
//            }
//            //if (count == questionsInExam.Count - 1)
//            //{

//            //    NextBtn.Text = "Submit";

//            //}
//            //else if (count < questionsInExam.Count - 1)
//            //{
//            //    NextBtn.Text = "Next";
//            //}

//            if (currentQuestion.Type == "MCQ")
//            {
//                Ch1.Text = answersInQuestion[0].AnswerText;
//                Ch2.Text = answersInQuestion[1].AnswerText;
//                Ch3.Text = answersInQuestion[2].AnswerText;
//                Ch2.Visible = true;
//            }
//            else if (currentQuestion.Type == "TF")
//            {
//                Ch1.Text = answersInQuestion[0].AnswerText;
//                Ch2.Visible = false;
//                Ch3.Text = answersInQuestion[1].AnswerText;
//            }

//            Ch1.Checked = IsChecked[count] && Ch1.Text == StudentAnswers[count];
//            Ch2.Checked = IsChecked[count] && Ch2.Text == StudentAnswers[count];
//            Ch3.Checked = IsChecked[count] && Ch3.Text == StudentAnswers[count];

//            this.Refresh();
//        }
//        private void NextBtn_Click_1(object sender, EventArgs e)
//        {
//            if (NextBtn.Text == "Next" && count < 10)
//            {
//                if (Ch1.Checked) StudentAnswers[count] = Ch1.Text;
//                else if (Ch2.Checked) StudentAnswers[count] = Ch2.Text;
//                else if (Ch3.Checked) StudentAnswers[count] = Ch3.Text;

//                // Mark the question as answered
//                IsChecked[count] = true;

//                // Move to the next question
//                if (count < questionsInExam.Count - 1)
//                {
//                    count++;
//                    LoadQuestionAndAnswers();
//                }
//            }

//            //bool allQuestionsAnswered = StudentAnswers.All(answer => answer != " ");

//            //if (count == questionsInExam.Count - 1)
//            //{
//            //    if (allQuestionsAnswered)
//            //    {
//            //        NextBtn.Text = "Submit";
//            //        NextBtn.Enabled = true;
//            //        SaveStudentAnswers();
//            //    }
//            //    else
//            //    {
//            //        NextBtn.Text = "Submit";
//            //        NextBtn.Enabled = false;
//            //    }
//            //}
//            //else
//            //{
//            //    NextBtn.Text = "Next";
//            //    NextBtn.Enabled = true;
//            //}
//            else
//            {
//                SaveStudentAnswers();
//            }
//        }
//        private void PrevBtn_Click_1(object sender, EventArgs e)
//        {
//            NextBtn.Text = "Next";
//            NextBtn.Enabled = true;
//            if (count > 0)
//            {
//               // Store the selected answer
//                if (Ch1.Checked) StudentAnswers[count] = Ch1.Text;
//                else if (Ch2.Checked) StudentAnswers[count] = Ch2.Text;
//                else if (Ch3.Checked) StudentAnswers[count] = Ch3.Text;

//               // Mark the question as answered
//                        IsChecked[count] = true;

//               // Move to the previous question
//               count--;
//                LoadQuestionAndAnswers();
//            }
//        }

//        private void SaveStudentAnswers()
//        {
//            int studentId = 1; // Assuming student ID is 1 for now.
//            string studentFname = context.People.FirstOrDefault(s => s.Id == studentId)?.Fname;
//            string studentLName = context.People.FirstOrDefault(s => s.Id == studentId)?.Lname;
//            string fullName = studentFname + " " + studentLName;
//            var Result = context.Database.ExecuteSqlRaw("EXEC GetStudentExamAnswers {0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10} , {11}",
//                studentId, fullName, StudentAnswers[0], StudentAnswers[1], StudentAnswers[2],
//                StudentAnswers[3], StudentAnswers[4], StudentAnswers[5], StudentAnswers[6],
//                StudentAnswers[7], StudentAnswers[8], StudentAnswers[9]);


//            // Save changes to the database.
//            context.SaveChanges();
//            MessageBox.Show(Result.ToString());

//        }

//        private void ctrlBox_Click(object sender, EventArgs e)
//        {

//        }

//        private void FormExamAnswers_FormClosed(object sender, FormClosedEventArgs e)
//        {
//            context.Dispose();
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
        List<String> StudentAnswers = new List<String>();
        List<bool> IsChecked = new List<bool>();
        private Question currentQuestion;
        private OnlineExaminationSystemContext context;

        public FormExamAnswers()
        {
            InitializeComponent();
        }

        private void FormExamAnswers_Load(object sender, EventArgs e)
        {
            context = new OnlineExaminationSystemContext();

            //context.Exams.Load();
            //context.Questions.Load();
            //context.QuestionAnswers.Load();

            int CrsID = context.Exams?.FirstOrDefault(e => e.Id == 1)?.CId ?? 0;
            CourseName.Text = context.Courses.FirstOrDefault(c => c.Id == CrsID)?.Name;
            drt.Text = context.Exams.FirstOrDefault(e => e.Id == 1)?.Duration?.ToString() + " Hours" ?? "N/A";


            var exam = context.Exams.Include(e => e.QIds).ThenInclude(q => q.QuestionAnswers).FirstOrDefault(e => e.Id == 1);

            int totalMarks = exam.QIds.Sum(q => q.Mark);
            Marks.Text = totalMarks.ToString();
            questionsInExam = exam.QIds.ToList();

            for (int i = 0; i < questionsInExam.Count; i++)
            {
                StudentAnswers.Add(" ");
                IsChecked.Add(false);
            }

            LoadQuestionAndAnswers();

        }

        private void LoadQuestionAndAnswers()
        {

            //MessageBox.Show(count.ToString());
            currentQuestion = questionsInExam[count];
            int Qnum = count + 1;
            QuestionNumber.Text = "Q" + Qnum + ".";
            QuesText.Text = currentQuestion.QuestionText.ToString();
            var answersInQuestion = currentQuestion.QuestionAnswers.ToList();
            if (count == 0)
            {
                PrevBtn.Enabled = false;
            }
            else
            {
                PrevBtn.Enabled = true;
            }
            if (count == questionsInExam.Count - 1)
            {

                NextBtn.Text = "Submit";


                //if (StudentAnswers.Count < 10)
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

            // Set the state of radio buttons based on whether the question is answered
            Ch1.Checked = IsChecked[count] && Ch1.Text == StudentAnswers[count];
            Ch2.Checked = IsChecked[count] && Ch2.Text == StudentAnswers[count];
            Ch3.Checked = IsChecked[count] && Ch3.Text == StudentAnswers[count];
            this.Refresh();

        }
        private void NextBtn_Click_1(object sender, EventArgs e)
        {
            if (Ch1.Checked) StudentAnswers[count] = Ch1.Text;
            else if (Ch2.Checked) StudentAnswers[count] = Ch2.Text;
            else if (Ch3.Checked) StudentAnswers[count] = Ch3.Text;

            // Mark the question as answered
            IsChecked[count] = true;

            // Move to the next question
            if (count < questionsInExam.Count - 1)
            {
                count++;
                LoadQuestionAndAnswers();
            }
            else
            {
                SaveStudentAnswers();
            }
        }

        private void PrevBtn_Click_1(object sender, EventArgs e)
        {
            if (count > 0)
            {
                // Store the selected answer
                if (Ch1.Checked) StudentAnswers[count] = Ch1.Text;
                else if (Ch2.Checked) StudentAnswers[count] = Ch2.Text;
                else if (Ch3.Checked) StudentAnswers[count] = Ch3.Text;

                // Mark the question as answered
                IsChecked[count] = true;

                // Move to the previous question
                count--;
                LoadQuestionAndAnswers();
            }
        }


        private void SaveStudentAnswers()
        {
            int studentId = 1; // Assuming student ID is 1 for now.
            string studentFname = context.People.FirstOrDefault(s => s.Id == studentId)?.Fname;
            string studentLName = context.People.FirstOrDefault(s => s.Id == studentId)?.Lname;
            string fullName = studentFname + " " + studentLName;
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




