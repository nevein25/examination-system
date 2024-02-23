using MetroSet_UI.Forms;
using Microsoft.EntityFrameworkCore;
using OnlineExaminationSystem.Context;
using OnlineExaminationSystem.Entities;

namespace OnlineExaminationSystem
{
    public partial class FormCourseTopics : MetroSetForm
    {
        OnlineExaminationSystemContext _context = new OnlineExaminationSystemContext();

        public FormCourseTopics()
        {
            InitializeComponent();
            this.FormClosed += (sender, e) => _context?.Dispose();
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

            grdTopics.DataSource = topics;
            grdTopics.Columns["CId"].Visible = false;
            grdTopics.Columns["TId"].Visible = false;
            grdTopics.Columns["CIdNavigation"].Visible = false;
        }
    }
}
