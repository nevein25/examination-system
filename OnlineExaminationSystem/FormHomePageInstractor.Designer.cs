namespace OnlineExaminationSystem
{
    partial class FormHomePageInstractor
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
            lblAssignCourseStudentD = new TabControl();
            tabPage1 = new TabPage();
            lblAssignCourseStudentQ = new Label();
            lblStudentC = new Label();
            comboStudentC = new ComboBox();
            lblInstructorC = new Label();
            comboInstructorC = new ComboBox();
            btnAssignCourse = new Button();
            label1 = new Label();
            comboCourses = new ComboBox();
            tabPage2 = new TabPage();
            lblAssignDepartmentStudentQ = new Label();
            lblStudentD = new Label();
            comboStudentD = new ComboBox();
            lblInstructorD = new Label();
            comboInstructorDep = new ComboBox();
            btnAssignDepartment = new Button();
            label4 = new Label();
            comboDepartment = new ComboBox();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            lstTopics = new MetroSet_UI.Controls.MetroSetListBox();
            btnNewCourse = new Button();
            button1 = new Button();
            label2 = new Label();
            comboCorsesesForTopics = new ComboBox();
            ctrlBox = new MetroSet_UI.Controls.MetroSetControlBox();
            lblAssignCourseStudentD.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage5.SuspendLayout();
            SuspendLayout();
            // 
            // lblAssignCourseStudentD
            // 
            lblAssignCourseStudentD.Controls.Add(tabPage1);
            lblAssignCourseStudentD.Controls.Add(tabPage2);
            lblAssignCourseStudentD.Controls.Add(tabPage3);
            lblAssignCourseStudentD.Controls.Add(tabPage4);
            lblAssignCourseStudentD.Controls.Add(tabPage5);
            lblAssignCourseStudentD.Location = new Point(15, 37);
            lblAssignCourseStudentD.Name = "lblAssignCourseStudentD";
            lblAssignCourseStudentD.SelectedIndex = 0;
            lblAssignCourseStudentD.Size = new Size(948, 382);
            lblAssignCourseStudentD.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(lblAssignCourseStudentQ);
            tabPage1.Controls.Add(lblStudentC);
            tabPage1.Controls.Add(comboStudentC);
            tabPage1.Controls.Add(lblInstructorC);
            tabPage1.Controls.Add(comboInstructorC);
            tabPage1.Controls.Add(btnAssignCourse);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(comboCourses);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(940, 344);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Assign Course";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblAssignCourseStudentQ
            // 
            lblAssignCourseStudentQ.AutoSize = true;
            lblAssignCourseStudentQ.BackColor = SystemColors.ButtonHighlight;
            lblAssignCourseStudentQ.ForeColor = Color.Gray;
            lblAssignCourseStudentQ.Location = new Point(499, 311);
            lblAssignCourseStudentQ.Name = "lblAssignCourseStudentQ";
            lblAssignCourseStudentQ.Size = new Size(295, 25);
            lblAssignCourseStudentQ.TabIndex = 10;
            lblAssignCourseStudentQ.Text = "Assign Course for Student?";
            lblAssignCourseStudentQ.Click += lblAssignCourse_Click;
            // 
            // lblStudentC
            // 
            lblStudentC.AutoSize = true;
            lblStudentC.BackColor = SystemColors.ButtonHighlight;
            lblStudentC.ForeColor = Color.Gray;
            lblStudentC.Location = new Point(543, 74);
            lblStudentC.Name = "lblStudentC";
            lblStudentC.Size = new Size(167, 25);
            lblStudentC.TabIndex = 9;
            lblStudentC.Text = "Select Student";
            lblStudentC.Visible = false;
            // 
            // comboStudentC
            // 
            comboStudentC.FormattingEnabled = true;
            comboStudentC.Location = new Point(504, 127);
            comboStudentC.Name = "comboStudentC";
            comboStudentC.Size = new Size(246, 33);
            comboStudentC.TabIndex = 8;
            comboStudentC.Visible = false;
            // 
            // lblInstructorC
            // 
            lblInstructorC.AutoSize = true;
            lblInstructorC.BackColor = SystemColors.ButtonHighlight;
            lblInstructorC.ForeColor = Color.Gray;
            lblInstructorC.Location = new Point(543, 74);
            lblInstructorC.Name = "lblInstructorC";
            lblInstructorC.Size = new Size(184, 25);
            lblInstructorC.TabIndex = 7;
            lblInstructorC.Text = "Select Instructor";
            // 
            // comboInstructorC
            // 
            comboInstructorC.FormattingEnabled = true;
            comboInstructorC.Location = new Point(504, 127);
            comboInstructorC.Name = "comboInstructorC";
            comboInstructorC.Size = new Size(246, 33);
            comboInstructorC.TabIndex = 6;
            // 
            // btnAssignCourse
            // 
            btnAssignCourse.BackColor = Color.FromArgb(186, 32, 38);
            btnAssignCourse.FlatStyle = FlatStyle.Flat;
            btnAssignCourse.ForeColor = Color.White;
            btnAssignCourse.Location = new Point(355, 221);
            btnAssignCourse.Name = "btnAssignCourse";
            btnAssignCourse.Size = new Size(200, 40);
            btnAssignCourse.TabIndex = 5;
            btnAssignCourse.Text = "Assign Course";
            btnAssignCourse.UseVisualStyleBackColor = false;
            btnAssignCourse.Click += btnAssignCourse_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(206, 74);
            label1.Name = "label1";
            label1.Size = new Size(160, 25);
            label1.TabIndex = 4;
            label1.Text = "Select Course";
            // 
            // comboCourses
            // 
            comboCourses.FormattingEnabled = true;
            comboCourses.Location = new Point(192, 127);
            comboCourses.Name = "comboCourses";
            comboCourses.Size = new Size(246, 33);
            comboCourses.TabIndex = 3;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(lblAssignDepartmentStudentQ);
            tabPage2.Controls.Add(lblStudentD);
            tabPage2.Controls.Add(comboStudentD);
            tabPage2.Controls.Add(lblInstructorD);
            tabPage2.Controls.Add(comboInstructorDep);
            tabPage2.Controls.Add(btnAssignDepartment);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(comboDepartment);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(940, 344);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Assign Department";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblAssignDepartmentStudentQ
            // 
            lblAssignDepartmentStudentQ.AutoSize = true;
            lblAssignDepartmentStudentQ.BackColor = SystemColors.ButtonHighlight;
            lblAssignDepartmentStudentQ.ForeColor = Color.Gray;
            lblAssignDepartmentStudentQ.Location = new Point(434, 316);
            lblAssignDepartmentStudentQ.Name = "lblAssignDepartmentStudentQ";
            lblAssignDepartmentStudentQ.Size = new Size(352, 25);
            lblAssignDepartmentStudentQ.TabIndex = 15;
            lblAssignDepartmentStudentQ.Text = "Assign Department for Student?";
            lblAssignDepartmentStudentQ.Click += label2_Click;
            // 
            // lblStudentD
            // 
            lblStudentD.AutoSize = true;
            lblStudentD.BackColor = SystemColors.ButtonHighlight;
            lblStudentD.ForeColor = Color.Gray;
            lblStudentD.Location = new Point(548, 79);
            lblStudentD.Name = "lblStudentD";
            lblStudentD.Size = new Size(167, 25);
            lblStudentD.TabIndex = 14;
            lblStudentD.Text = "Select Student";
            lblStudentD.Visible = false;
            // 
            // comboStudentD
            // 
            comboStudentD.FormattingEnabled = true;
            comboStudentD.Location = new Point(504, 132);
            comboStudentD.Name = "comboStudentD";
            comboStudentD.Size = new Size(246, 33);
            comboStudentD.TabIndex = 13;
            comboStudentD.Visible = false;
            // 
            // lblInstructorD
            // 
            lblInstructorD.AutoSize = true;
            lblInstructorD.BackColor = SystemColors.ButtonHighlight;
            lblInstructorD.ForeColor = Color.Gray;
            lblInstructorD.Location = new Point(543, 79);
            lblInstructorD.Name = "lblInstructorD";
            lblInstructorD.Size = new Size(184, 25);
            lblInstructorD.TabIndex = 12;
            lblInstructorD.Text = "Select Instructor";
            // 
            // comboInstructorDep
            // 
            comboInstructorDep.FormattingEnabled = true;
            comboInstructorDep.Location = new Point(504, 132);
            comboInstructorDep.Name = "comboInstructorDep";
            comboInstructorDep.Size = new Size(246, 33);
            comboInstructorDep.TabIndex = 11;
            // 
            // btnAssignDepartment
            // 
            btnAssignDepartment.BackColor = Color.FromArgb(186, 32, 38);
            btnAssignDepartment.FlatStyle = FlatStyle.Flat;
            btnAssignDepartment.ForeColor = Color.White;
            btnAssignDepartment.Location = new Point(355, 226);
            btnAssignDepartment.Name = "btnAssignDepartment";
            btnAssignDepartment.Size = new Size(236, 40);
            btnAssignDepartment.TabIndex = 10;
            btnAssignDepartment.Text = "Assign Department";
            btnAssignDepartment.UseVisualStyleBackColor = false;
            btnAssignDepartment.Click += btnAssignDepartment_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonHighlight;
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(206, 79);
            label4.Name = "label4";
            label4.Size = new Size(217, 25);
            label4.TabIndex = 9;
            label4.Text = "Select Department";
            // 
            // comboDepartment
            // 
            comboDepartment.FormattingEnabled = true;
            comboDepartment.Location = new Point(192, 132);
            comboDepartment.Name = "comboDepartment";
            comboDepartment.Size = new Size(246, 33);
            comboDepartment.TabIndex = 8;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 34);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(940, 344);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Add Questions";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 34);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(940, 344);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Generate Exam";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(lstTopics);
            tabPage5.Controls.Add(btnNewCourse);
            tabPage5.Controls.Add(button1);
            tabPage5.Controls.Add(label2);
            tabPage5.Controls.Add(comboCorsesesForTopics);
            tabPage5.Location = new Point(4, 34);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(940, 344);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Show Courses";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // lstTopics
            // 
            lstTopics.BackColor = Color.White;
            lstTopics.BorderColor = Color.LightGray;
            lstTopics.DisabledBackColor = Color.FromArgb(204, 204, 204);
            lstTopics.DisabledForeColor = Color.FromArgb(136, 136, 136);
            lstTopics.Font = new Font("Microsoft Sans Serif", 10F);
            lstTopics.HoveredItemBackColor = Color.LightGray;
            lstTopics.HoveredItemColor = Color.DimGray;
            lstTopics.IsDerivedStyle = true;
            lstTopics.ItemHeight = 30;
            lstTopics.Location = new Point(475, 103);
            lstTopics.MultiSelect = false;
            lstTopics.Name = "lstTopics";
            lstTopics.SelectedIndex = -1;
            lstTopics.SelectedItem = null;
            lstTopics.SelectedItemBackColor = Color.FromArgb(65, 177, 225);
            lstTopics.SelectedItemColor = Color.White;
            lstTopics.SelectedText = null;
            lstTopics.SelectedValue = null;
            lstTopics.ShowBorder = false;
            lstTopics.ShowScrollBar = false;
            lstTopics.Size = new Size(206, 98);
            lstTopics.Style = MetroSet_UI.Enums.Style.Light;
            lstTopics.StyleManager = null;
            lstTopics.TabIndex = 30;
            lstTopics.ThemeAuthor = "Narwin";
            lstTopics.ThemeName = "MetroLite";
            // 
            // btnNewCourse
            // 
            btnNewCourse.BackColor = Color.FromArgb(186, 32, 38);
            btnNewCourse.FlatStyle = FlatStyle.Flat;
            btnNewCourse.ForeColor = Color.White;
            btnNewCourse.Location = new Point(475, 250);
            btnNewCourse.Name = "btnNewCourse";
            btnNewCourse.Size = new Size(206, 42);
            btnNewCourse.TabIndex = 29;
            btnNewCourse.Text = "Add New Course";
            btnNewCourse.UseVisualStyleBackColor = false;
            btnNewCourse.Click += btnNewCourse_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(186, 32, 38);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(202, 250);
            button1.Name = "button1";
            button1.Size = new Size(200, 42);
            button1.TabIndex = 28;
            button1.Text = "Show topics";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(205, 103);
            label2.Name = "label2";
            label2.Size = new Size(160, 25);
            label2.TabIndex = 27;
            label2.Text = "Select Course";
            // 
            // comboCorsesesForTopics
            // 
            comboCorsesesForTopics.FormattingEnabled = true;
            comboCorsesesForTopics.Location = new Point(205, 168);
            comboCorsesesForTopics.Name = "comboCorsesesForTopics";
            comboCorsesesForTopics.Size = new Size(197, 33);
            comboCorsesesForTopics.TabIndex = 26;
            // 
            // ctrlBox
            // 
            ctrlBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ctrlBox.CloseHoverBackColor = Color.FromArgb(183, 40, 40);
            ctrlBox.CloseHoverForeColor = Color.White;
            ctrlBox.CloseNormalForeColor = Color.Gray;
            ctrlBox.DisabledForeColor = Color.DimGray;
            ctrlBox.IsDerivedStyle = true;
            ctrlBox.Location = new Point(868, 7);
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
            ctrlBox.TabIndex = 22;
            ctrlBox.Text = "metroSetControlBox1";
            ctrlBox.ThemeAuthor = "Narwin";
            ctrlBox.ThemeName = "MetroLite";
            // 
            // FormHomePageInstractor
            // 
            AutoScaleDimensions = new SizeF(13F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(983, 433);
            Controls.Add(ctrlBox);
            Controls.Add(lblAssignCourseStudentD);
            Font = new Font("Century Gothic", 13F);
            Name = "FormHomePageInstractor";
            Padding = new Padding(12, 67, 12, 12);
            SmallLineColor1 = Color.FromArgb(186, 32, 38);
            SmallLineColor2 = Color.FromArgb(186, 32, 38);
            Load += FormHomePageInstractor_Load;
            lblAssignCourseStudentD.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl lblAssignCourseStudentD;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label lblInstructorC;
        private ComboBox comboInstructorC;
        private Button btnAssignCourse;
        private Label label1;
        private ComboBox comboCourses;
        private MetroSet_UI.Controls.MetroSetControlBox ctrlBox;
        private Label lblInstructorD;
        private ComboBox comboInstructorDep;
        private Button btnAssignDepartment;
        private Label label4;
        private ComboBox comboDepartment;
        private Label lblStudentC;
        private ComboBox comboStudentC;
        private Label lblAssignCourseStudentQ;
        private Label lblAssignDepartmentStudentQ;
        private Label lblStudentD;
        private ComboBox comboStudentD;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private MetroSet_UI.Controls.MetroSetListBox lstTopics;
        private Button btnNewCourse;
        private Button button1;
        private Label label2;
        private ComboBox comboCorsesesForTopics;
    }
}