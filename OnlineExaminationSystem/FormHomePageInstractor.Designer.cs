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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label2 = new Label();
            comboInstructor = new ComboBox();
            btnAssignCourse = new Button();
            label1 = new Label();
            comboCourses = new ComboBox();
            tabPage2 = new TabPage();
            ctrlBox = new MetroSet_UI.Controls.MetroSetControlBox();
            label3 = new Label();
            comboInstructorDep = new ComboBox();
            btnAssignDepartment = new Button();
            label4 = new Label();
            comboDepartment = new ComboBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(15, 37);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(727, 382);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(comboInstructor);
            tabPage1.Controls.Add(btnAssignCourse);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(comboCourses);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(719, 344);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Assign Course";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(415, 88);
            label2.Name = "label2";
            label2.Size = new Size(184, 25);
            label2.TabIndex = 7;
            label2.Text = "Select Instructor";
            // 
            // comboInstructor
            // 
            comboInstructor.FormattingEnabled = true;
            comboInstructor.Location = new Point(376, 141);
            comboInstructor.Name = "comboInstructor";
            comboInstructor.Size = new Size(246, 33);
            comboInstructor.TabIndex = 6;
            // 
            // btnAssignCourse
            // 
            btnAssignCourse.BackColor = Color.FromArgb(186, 32, 38);
            btnAssignCourse.FlatStyle = FlatStyle.Flat;
            btnAssignCourse.ForeColor = Color.White;
            btnAssignCourse.Location = new Point(248, 235);
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
            label1.Location = new Point(112, 88);
            label1.Name = "label1";
            label1.Size = new Size(160, 25);
            label1.TabIndex = 4;
            label1.Text = "Select Course";
            // 
            // comboCourses
            // 
            comboCourses.FormattingEnabled = true;
            comboCourses.Location = new Point(64, 141);
            comboCourses.Name = "comboCourses";
            comboCourses.Size = new Size(246, 33);
            comboCourses.TabIndex = 3;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(comboInstructorDep);
            tabPage2.Controls.Add(btnAssignDepartment);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(comboDepartment);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(719, 344);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Assign Department";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // ctrlBox
            // 
            ctrlBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ctrlBox.CloseHoverBackColor = Color.FromArgb(183, 40, 40);
            ctrlBox.CloseHoverForeColor = Color.White;
            ctrlBox.CloseNormalForeColor = Color.Gray;
            ctrlBox.DisabledForeColor = Color.DimGray;
            ctrlBox.IsDerivedStyle = true;
            ctrlBox.Location = new Point(642, 7);
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
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(431, 79);
            label3.Name = "label3";
            label3.Size = new Size(184, 25);
            label3.TabIndex = 12;
            label3.Text = "Select Instructor";
            // 
            // comboInstructorDep
            // 
            comboInstructorDep.FormattingEnabled = true;
            comboInstructorDep.Location = new Point(392, 132);
            comboInstructorDep.Name = "comboInstructorDep";
            comboInstructorDep.Size = new Size(246, 33);
            comboInstructorDep.TabIndex = 11;
            // 
            // btnAssignDepartment
            // 
            btnAssignDepartment.BackColor = Color.FromArgb(186, 32, 38);
            btnAssignDepartment.FlatStyle = FlatStyle.Flat;
            btnAssignDepartment.ForeColor = Color.White;
            btnAssignDepartment.Location = new Point(243, 226);
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
            label4.Location = new Point(94, 79);
            label4.Name = "label4";
            label4.Size = new Size(217, 25);
            label4.TabIndex = 9;
            label4.Text = "Select Department";
            // 
            // comboDepartment
            // 
            comboDepartment.FormattingEnabled = true;
            comboDepartment.Location = new Point(80, 132);
            comboDepartment.Name = "comboDepartment";
            comboDepartment.Size = new Size(246, 33);
            comboDepartment.TabIndex = 8;
            // 
            // FormHomePageInstractor
            // 
            AutoScaleDimensions = new SizeF(13F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(757, 433);
            Controls.Add(ctrlBox);
            Controls.Add(tabControl1);
            Font = new Font("Century Gothic", 13F);
            Name = "FormHomePageInstractor";
            Padding = new Padding(12, 67, 12, 12);
            SmallLineColor1 = Color.FromArgb(186, 32, 38);
            SmallLineColor2 = Color.FromArgb(186, 32, 38);
            Load += FormHomePageInstractor_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label2;
        private ComboBox comboInstructor;
        private Button btnAssignCourse;
        private Label label1;
        private ComboBox comboCourses;
        private MetroSet_UI.Controls.MetroSetControlBox ctrlBox;
        private Label label3;
        private ComboBox comboInstructorDep;
        private Button btnAssignDepartment;
        private Label label4;
        private ComboBox comboDepartment;
    }
}