using OnlineExaminationSystem.Helpers;
using OnlineExaminationSystem;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MetroSet_UI.Forms;
using Microsoft.EntityFrameworkCore;
using OnlineExaminationSystem.Entities;
using OnlineExaminationSystem.Context;

namespace OnlineExaminationSystem
{
    public partial class FormStudentHome : MetroSetForm
    {

        private Dictionary<int, FormExamAnswers> examForms = new Dictionary<int, FormExamAnswers>();
        int StudentID;
        FormExamAnswers formExamAnswers;
        OnlineExaminationSystemContext _context;

        public FormStudentHome()
        {
            InitializeComponent();

            Helper.FormHomeStudent = this;
        }

        private void FormStudentHome_Load(object sender, EventArgs e)
        {
            _context = new OnlineExaminationSystemContext();

        }

        private void FormStudentHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Dispose of all exam forms when closing the main form
            foreach (var form in examForms.Values)
            {
                form.Dispose();
            }
        }



        private void TakeExamBtn_Click_2(object sender, EventArgs e)
        {
            // Check if an instance for the student ID already exists and is not disposed

            Helper.examId = _context.Database.SqlQuery<int>($"GetExamIdByStudentId {Helper.StudentId}").AsEnumerable().FirstOrDefault();

            if (Helper.examId == -1)
            {
                MessageBox.Show("You Have No Assigned Exam Now");
            }
            else
            {
                if (examForms.ContainsKey(Helper.StudentId) && !examForms[Helper.StudentId].IsDisposed)
                {
                    // If the form exists, reset its state and show it
                    formExamAnswers = examForms[Helper.StudentId];
                    // formExamAnswers.ResetState(); 
                    Helper.HideFormSmoothly(this);
                    formExamAnswers.Show();
                }
                else
                {
                    // If not, create a new instance and store it
                    formExamAnswers = new FormExamAnswers(Helper.StudentId);
                    examForms[Helper.StudentId] = formExamAnswers;
                    Helper.HideFormSmoothly(this);
                    formExamAnswers.Show();
                }

            }
           
            // fs = this;

        }

        private void showGradesBtn_Click(object sender, EventArgs e)
        {
            using (FormStudentOwnGrade formStudentOwnGrade = new FormStudentOwnGrade())
            {

                Helper.HideFormSmoothly(this);

                formStudentOwnGrade.ShowDialog();
            }
        }

        
    }
}































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
//        // private static FormStudentHome fs;
//        private MetroSetForm previousForm;
//        public FormStudentHome()
//        {
//            InitializeComponent();
//           /// fs = this;
//            //StudentID = studentID;
//        }

//        private void FormStudentHome_FormClosing(object sender, FormClosingEventArgs e)
//        {
//            // Dispose of all exam forms when closing the main form
//            foreach (var form in examForms.Values)
//            {
//                form.Dispose();
//            }
//        }

//        //public static FormStudentHome GetForm ()
//        //{
//        //    return fs;
//        //}


//        //private void TakeExamBtn_Click_2(object sender, EventArgs e)
//        //{
//        //    // Check if an instance for the student ID already exists and is not disposed
//        //    if (examForms.ContainsKey(Helper.StudentId) && !examForms[Helper.StudentId].IsDisposed)
//        //    {
//        //        // If the form exists, reset its state and show it
//        //        formExamAnswers = examForms[Helper.StudentId];
//        //        // formExamAnswers.ResetState(); // You need to implement this method
//        //        Helper.HideFormSmoothly(this);
//        //        formExamAnswers.ShowDialog();
//        //    }
//        //    else
//        //    {
//        //        // If not, create a new instance and store it
//        //        formExamAnswers = new FormExamAnswers(Helper.StudentId);
//        //        examForms[Helper.StudentId] = formExamAnswers;
//        //        Helper.HideFormSmoothly(this);
//        //        formExamAnswers.ShowDialog();
//        //    }
//        //   // fs = this;

//        //}

//        private void TakeExamBtn_Click_2(object sender, EventArgs e)
//        {
//            // Pass the reference to the current form to the new form
//            var formExamAnswers = GetExamAnswersForm(this);
//            Helper.HideFormSmoothly(this);
//            formExamAnswers.ShowDialog();

//            //Helper.HideFormSmoothly(this);
//            //Helper.ShowFormSmoothly(formExamAnswers);


//        }

//        private void showGradesBtn_Click(object sender, EventArgs e)
//        {
//            using (FormStudentOwnGrade formStudentOwnGrade = new FormStudentOwnGrade())
//            {

//                Helper.HideFormSmoothly(this);

//                formStudentOwnGrade.ShowDialog();
//            }
//        }


//        private FormExamAnswers GetExamAnswersForm(Form previousForm)
//        {
//            // Check if an instance for the student ID already exists and is not disposed
//            if (examForms.ContainsKey(Helper.StudentId) && !examForms[Helper.StudentId].IsDisposed)
//            {
//                // If the form exists, reset its state and return it
//                var formExamAnswers = examForms[Helper.StudentId];
//                // formExamAnswers.ResetState(); // You need to implement this method
//                return formExamAnswers;
//            }
//            else
//            {
//                // If not, create a new instance and store it
//                var formExamAnswers = new FormExamAnswers(Helper.StudentId, previousForm);
//                examForms[Helper.StudentId] = formExamAnswers;
//                return formExamAnswers;
//            }
//        }
//    }
//}



//using OnlineExaminationSystem.Helpers;
//using OnlineExaminationSystem;
//using System;
//using System.Collections.Generic;
//using System.Windows.Forms;

//namespace OnlineExaminationSystem
//{
//    public partial class FormStudentHome : Form
//    {
//        private Dictionary<int, FormExamAnswers> examForms = new Dictionary<int, FormExamAnswers>();
//        FormExamAnswers formExamAnswers;
//        public FormStudentHome()
//        {
//            InitializeComponent();

//        }

//        private void TakeExamBtn_Click(object sender, EventArgs e)
//        {
//            int studentId;
//            if (int.TryParse(SIDTxt.Text, out studentId))
//            {


//                // Check if an instance for the student ID already exists and is not disposed
//                if (examForms.ContainsKey(studentId) && !examForms[studentId].IsDisposed)
//                {
//                    // If the form exists, reset its state and show it
//                    formExamAnswers = examForms[studentId];
//                    // formExamAnswers.ResetState(); // You need to implement this method
//                    formExamAnswers.Show();
//                }
//                else
//                {
//                    // If not, create a new instance and store it
//                    formExamAnswers = new FormExamAnswers(studentId);
//                    examForms[studentId] = formExamAnswers;
//                    formExamAnswers.Show();
//                }
//            }
//            else
//            {
//                MessageBox.Show("Please enter a valid student ID.");
//            }
//        }

//        private void FormStudentHome_FormClosing(object sender, FormClosingEventArgs e)
//        {
//            // Dispose of all exam forms when closing the main form
//            foreach (var form in examForms.Values)
//            {
//                form.Dispose();
//            }
//        }
//    }
//}




