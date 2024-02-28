using MetroSet_UI.Forms;
using OnlineExaminationSystem.Helpers;

namespace OnlineExaminationSystem
{
    public partial class FormHomeStudent : MetroSetForm
    {
        public FormHomeStudent()
        {
            InitializeComponent();
        }

        private void btnShowGrades_Click(object sender, EventArgs e)
        {
            using (FormStudentOwnGrade formStudentOwnGrade = new FormStudentOwnGrade())
            {

                Helper.HideFormSmoothly(this);

                formStudentOwnGrade.ShowDialog();
            }
        }
    }
}
