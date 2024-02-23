using MetroSet_UI.Forms;
using Microsoft.EntityFrameworkCore;
using OnlineExaminationSystem.Context;
using OnlineExaminationSystem.Helpers;

namespace OnlineExaminationSystem
{
    public partial class FormLogIn : MetroSetForm
    {
        OnlineExaminationSystemContext _context = new OnlineExaminationSystemContext();

        public FormLogIn()
        {
            InitializeComponent();
            this.FormClosed += (sender, e) => _context?.Dispose();

        }


        private void btnLogIn_Click_1(object sender, EventArgs e)
        {
            var user = _context.People.Where(p => p.Email == txtEmail.Text && p.Password == Helper.Encrypt(txtPassword.Text)).FirstOrDefault();
            if (user != null)
            {
                var isStudent = _context.Students.Where(s => s.Id == user.Id).FirstOrDefault();
                if (isStudent != null)
                {
                    using (FormHomeStudent formHomeStudent = new FormHomeStudent())
                    {

                        Helper.HideFormSmoothly(this);

                        formHomeStudent.ShowDialog();
                    }
                }
                else
                {
                    using (FormHomeInstructor formHomeInstructor = new FormHomeInstructor())
                    {

                        Helper.HideFormSmoothly(this);

                        formHomeInstructor.ShowDialog();
                    }
                }

            }
            else
            {
                MessageBox.Show("Wrong username or password");
            }
        }
    }
}
