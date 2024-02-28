namespace OnlineExaminationSystem
{
    partial class FormInstructorGrade
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ctrlBox = new MetroSet_UI.Controls.MetroSetControlBox();
            cmb_Courses = new ComboBox();
            lbCourses = new Label();
            grd_StudentsGrades = new DataGridView();
            btn_Search = new Button();
            btn_back = new Button();
            ((System.ComponentModel.ISupportInitialize)grd_StudentsGrades).BeginInit();
            SuspendLayout();
            // 
            // ctrlBox
            // 
            ctrlBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ctrlBox.CloseHoverBackColor = Color.FromArgb(183, 40, 40);
            ctrlBox.CloseHoverForeColor = Color.White;
            ctrlBox.CloseNormalForeColor = Color.Gray;
            ctrlBox.DisabledForeColor = Color.DimGray;
            ctrlBox.IsDerivedStyle = true;
            ctrlBox.Location = new Point(1077, 48);
            ctrlBox.MaximizeBox = true;
            ctrlBox.MaximizeHoverBackColor = Color.FromArgb(238, 238, 238);
            ctrlBox.MaximizeHoverForeColor = Color.Gray;
            ctrlBox.MaximizeNormalForeColor = Color.Gray;
            ctrlBox.MinimizeBox = true;
            ctrlBox.MinimizeHoverBackColor = Color.FromArgb(238, 238, 238);
            ctrlBox.MinimizeHoverForeColor = Color.Gray;
            ctrlBox.MinimizeNormalForeColor = Color.Gray;
            ctrlBox.Name = "ctrlBox";
            ctrlBox.Size = new Size(100, 25);
            ctrlBox.Style = MetroSet_UI.Enums.Style.Light;
            ctrlBox.StyleManager = null;
            ctrlBox.TabIndex = 24;
            ctrlBox.Text = "metroSetControlBox1";
            ctrlBox.ThemeAuthor = "Narwin";
            ctrlBox.ThemeName = "MetroLite";
            // 
            // cmb_Courses
            // 
            cmb_Courses.FormattingEnabled = true;
            cmb_Courses.Location = new Point(585, 117);
            cmb_Courses.Name = "cmb_Courses";
            cmb_Courses.Size = new Size(334, 33);
            cmb_Courses.TabIndex = 26;
            // 
            // lbCourses
            // 
            lbCourses.AutoSize = true;
            lbCourses.BackColor = Color.White;
            lbCourses.Location = new Point(67, 117);
            lbCourses.Name = "lbCourses";
            lbCourses.Size = new Size(248, 25);
            lbCourses.TabIndex = 25;
            lbCourses.Text = "Choose Course Name";
            // 
            // grd_StudentsGrades
            // 
            grd_StudentsGrades.AllowUserToAddRows = false;
            grd_StudentsGrades.AllowUserToDeleteRows = false;
            grd_StudentsGrades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grd_StudentsGrades.Location = new Point(67, 176);
            grd_StudentsGrades.Name = "grd_StudentsGrades";
            grd_StudentsGrades.ReadOnly = true;
            grd_StudentsGrades.RowHeadersWidth = 51;
            grd_StudentsGrades.Size = new Size(1097, 469);
            grd_StudentsGrades.TabIndex = 27;
            // 
            // btn_Search
            // 
            btn_Search.BackColor = Color.FromArgb(186, 32, 38);
            btn_Search.ForeColor = Color.White;
            btn_Search.Location = new Point(936, 664);
            btn_Search.Name = "btn_Search";
            btn_Search.Size = new Size(228, 59);
            btn_Search.TabIndex = 28;
            btn_Search.Text = "Search";
            btn_Search.UseVisualStyleBackColor = false;
            btn_Search.Click += btn_Search_Click;
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.FromArgb(37, 37, 37);
            btn_back.ForeColor = Color.White;
            btn_back.Location = new Point(67, 664);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(228, 59);
            btn_back.TabIndex = 33;
            btn_back.Text = "Back";
            btn_back.UseVisualStyleBackColor = false;
            // 
            // FormInstructorGrade
            // 
            AutoScaleDimensions = new SizeF(13F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1225, 738);
            Controls.Add(btn_back);
            Controls.Add(btn_Search);
            Controls.Add(grd_StudentsGrades);
            Controls.Add(cmb_Courses);
            Controls.Add(lbCourses);
            Controls.Add(ctrlBox);
            Font = new Font("Century Gothic", 13F);
            Name = "FormInstructorGrade";
            Padding = new Padding(12, 67, 12, 12);
            SmallLineColor1 = Color.FromArgb(186, 32, 38);
            SmallLineColor2 = Color.FromArgb(186, 32, 38);
            Text = "Student Grades";
            Load += FormInstructorGrade_Load;
            ((System.ComponentModel.ISupportInitialize)grd_StudentsGrades).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MetroSet_UI.Controls.MetroSetControlBox ctrlBox;
        private ComboBox cmb_Courses;
        private Label lbCourses;
        private DataGridView grd_StudentsGrades;
        private Button btn_Search;
        private Button btn_back;
    }
}