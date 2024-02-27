using MetroSet_UI.Forms;
using Microsoft.EntityFrameworkCore;
using OnlineExaminationSystem.Context;
using OnlineExaminationSystem.Entities;
using OnlineExaminationSystem.Helpers;

namespace OnlineExaminationSystem
{
    public partial class FormCourseTopics : MetroSetForm
    {
        OnlineExaminationSystemContext _context = new OnlineExaminationSystemContext();

        public FormCourseTopics()
        {
            InitializeComponent();
            this.FormClosed += (sender, e) => _context?.Dispose();

            lstTopics.BackColor = Color.WhiteSmoke;
            lstTopics.Font = new Font("Century Gothic", 13F);
            lstTopics.ForeColor = Color.Gray;
            lstTopics.SelectedItemBackColor= Color.FromArgb(186, 32, 38);
        }

        private void FormCourseTopics_Load(object sender, EventArgs e)
        {
            List<Course> courses = _context.Courses.ToList();
            comboCourses.DataSource = courses;
            comboCourses.DisplayMember = "Name";
            comboCourses.ValueMember = "Id";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var topics = _context.Topics.FromSql($"CourseWithTopics {comboCourses.SelectedValue}").ToList();

            //grdTopics.DataSource = topics;
            //grdTopics.Columns["CId"].Visible = false;
            //grdTopics.Columns["TId"].Visible = false;
            //grdTopics.Columns["CIdNavigation"].Visible = false;

            lstTopics.Items.Clear();
            lstTopics.Items.AddRange(topics.Select(t => t.Name));

        }

        private void btnNewCourse_Click(object sender, EventArgs e)
        {
            using (FormAddCourseTopics frmAddCorseTopics = new FormAddCourseTopics())
            {
                frmAddCorseTopics.StartPosition = FormStartPosition.CenterScreen;

                Helper.HideFormSmoothly(this);

                frmAddCorseTopics.ShowDialog();
            }
        }
    }
}
