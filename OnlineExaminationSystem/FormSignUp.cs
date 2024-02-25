using MetroSet_UI.Forms;
using OnlineExaminationSystem.Context;
using OnlineExaminationSystem.Entities;
using OnlineExaminationSystem.Helpers;

namespace OnlineExaminationSystem
{
    public partial class FormSignUp : MetroSetForm
    {
        OnlineExaminationSystemContext _context = new OnlineExaminationSystemContext();

        public FormSignUp()
        {
            InitializeComponent();
            this.FormClosed += (sender, e) => _context?.Dispose();

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                Student student = new Student()
                {
                    Fname = txtFname.Text,
                    Lname = txtLname.Text,
                    Email = txtEmail.Text,
                    Password = Helper.Encrypt(txtPassword.Text),
                    AccountState = "Active",
                    Ssn = txtSsn.Text
                };
                _context.Students.Add(student);
                _context.SaveChanges();


                MessageBox.Show("Account created successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something Went Wrong");
            }
        }

        private void lblgologin_Click(object sender, EventArgs e)
        {

            RedirectToLogIn();
        }

        private void RedirectToLogIn()
        {
            using (FormLogIn frmLogin = new FormLogIn())
            {
                frmLogin.StartPosition = FormStartPosition.CenterScreen;

                Helper.HideFormSmoothly(this);

                frmLogin.ShowDialog();
            }
        }

       
    }
}
