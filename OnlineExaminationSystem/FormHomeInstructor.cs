using MetroSet_UI.Forms;
using OnlineExaminationSystem.Helpers;

namespace OnlineExaminationSystem
{
    public partial class FormHomeInstructor : MetroSetForm
    {
        public FormHomeInstructor()
        {
            InitializeComponent();
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
    }
}
