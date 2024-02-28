
//using OnlineExaminationSystem.Helpers;
//using OnlineExaminationSystem;
//using System;
//using System.Collections.Generic;
//using System.Windows.Forms;
//using MetroSet_UI.Forms;

//namespace OnlineExaminationSystem
//{
//    public partial class FormStudentHome : MetroSetForm
//    {
//        private Dictionary<int, FormExamAnswers> examForms = new Dictionary<int, FormExamAnswers>();
//        int StudentID;
//        FormExamAnswers formExamAnswers;
//        public FormStudentHome(int studentID)
//        {
//            InitializeComponent();
//            StudentID = studentID;
//        }


//        private void TakeExamBtn_Click(object sender, EventArgs e)
//        {

           
//        }


//        private void FormStudentHome_FormClosing(object sender, FormClosingEventArgs e)
//        {
//            // Dispose of all exam forms when closing the main form
//            foreach (var form in examForms.Values)
//            {
//                form.Dispose();
//            }
//        }

//        private void TakeExamBtn_Click_1(object sender, EventArgs e)
//        {

//            if ()
//            // Check if an instance for the student ID already exists and is not disposed
//            if (examForms.ContainsKey(StudentID) && !examForms[StudentID].IsDisposed)
//            {
//                // If the form exists, reset its state and show it
//                formExamAnswers = examForms[StudentID];
//                // formExamAnswers.ResetState(); // You need to implement this method
//                formExamAnswers.Show();
//            }
//            else
//            {
//                // If not, create a new instance and store it
//                formExamAnswers = new FormExamAnswers(StudentID);
//                examForms[StudentID] = formExamAnswers;
//                formExamAnswers.Show();
//            }

//        }

//        
//    }
//}



using OnlineExaminationSystem.Helpers;
using OnlineExaminationSystem;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OnlineExaminationSystem
{
    public partial class FormStudentHome : Form
    {
        private Dictionary<int, FormExamAnswers> examForms = new Dictionary<int, FormExamAnswers>();
        FormExamAnswers formExamAnswers;
        public FormStudentHome()
        {
            InitializeComponent();

        }

        private void TakeExamBtn_Click(object sender, EventArgs e)
        {
            int studentId;
            if (int.TryParse(SIDTxt.Text, out studentId))
            {


                // Check if an instance for the student ID already exists and is not disposed
                if (examForms.ContainsKey(studentId) && !examForms[studentId].IsDisposed)
                {
                    // If the form exists, reset its state and show it
                    formExamAnswers = examForms[studentId];
                    // formExamAnswers.ResetState(); // You need to implement this method
                    formExamAnswers.Show();
                }
                else
                {
                    // If not, create a new instance and store it
                    formExamAnswers = new FormExamAnswers(studentId);
                    examForms[studentId] = formExamAnswers;
                    formExamAnswers.Show();
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid student ID.");
            }
        }

        private void FormStudentHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Dispose of all exam forms when closing the main form
            foreach (var form in examForms.Values)
            {
                form.Dispose();
            }
        }
    }
}




