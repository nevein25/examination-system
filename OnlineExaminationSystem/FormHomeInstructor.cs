using MetroSet_UI.Forms;
using Microsoft.EntityFrameworkCore;
using OnlineExaminationSystem.Context;
using OnlineExaminationSystem.Helpers;

namespace OnlineExaminationSystem
{
    public partial class FormHomeInstructor : MetroSetForm
    {
        OnlineExaminationSystemContext _context = new OnlineExaminationSystemContext();
        public FormHomeInstructor()
        {
            InitializeComponent();
            FormClosed += (sender, e) => _context?.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (FormCourseTopics frmCourseTopic = new FormCourseTopics())
            {
                frmCourseTopic.StartPosition = FormStartPosition.CenterScreen;

                Helper.HideFormSmoothly(this);

                frmCourseTopic.ShowDialog();
            }
        }


        private void btnGenerateExam_Click(object sender, EventArgs e)
        {
            using (FormGenerateExam frmGenerateExam = new FormGenerateExam())
            {
                frmGenerateExam.StartPosition = FormStartPosition.CenterScreen;

                Helper.HideFormSmoothly(this);

                frmGenerateExam.ShowDialog();
            }
        }
        
        private void btnExamCorrection_Click(object sender, EventArgs e)
        {
            // TEMP
            //    @studentIdToCorrect , @examIdToCorrect
            int numRowsAffected = _context.Database.ExecuteSql($"Exec [ExamCorrection] {1},{1}");

        }
    }
}
