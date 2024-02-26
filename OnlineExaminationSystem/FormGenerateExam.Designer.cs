namespace OnlineExaminationSystem
{
    partial class FormGenerateExam
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
            btn_generateExam = new Button();
            lbCourses = new Label();
            cmb_Courses = new ComboBox();
            ctrlBox = new MetroSet_UI.Controls.MetroSetControlBox();
            lb_numOfTFQuestions = new Label();
            numeric_TFQuestions = new NumericUpDown();
            label1 = new Label();
            numeric_MCQ_Questions = new NumericUpDown();
            DateTimeForExam = new MonthCalendar();
            numeric_Duration = new NumericUpDown();
            lb_Duration = new Label();
            lb_date = new Label();
            btn_back = new Button();
            ((System.ComponentModel.ISupportInitialize)numeric_TFQuestions).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numeric_MCQ_Questions).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numeric_Duration).BeginInit();
            SuspendLayout();
            // 
            // btn_generateExam
            // 
            btn_generateExam.BackColor = Color.FromArgb(186, 32, 38);
            btn_generateExam.ForeColor = Color.White;
            btn_generateExam.Location = new Point(627, 594);
            btn_generateExam.Name = "btn_generateExam";
            btn_generateExam.Size = new Size(228, 59);
            btn_generateExam.TabIndex = 0;
            btn_generateExam.Text = "Generate";
            btn_generateExam.UseVisualStyleBackColor = false;
            btn_generateExam.Click += btn_generateExam_Click;
            // 
            // lbCourses
            // 
            lbCourses.AutoSize = true;
            lbCourses.Location = new Point(89, 108);
            lbCourses.Name = "lbCourses";
            lbCourses.Size = new Size(248, 25);
            lbCourses.TabIndex = 2;
            lbCourses.Text = "Choose Course Name";
            // 
            // cmb_Courses
            // 
            cmb_Courses.FormattingEnabled = true;
            cmb_Courses.Location = new Point(704, 100);
            cmb_Courses.Name = "cmb_Courses";
            cmb_Courses.Size = new Size(151, 33);
            cmb_Courses.TabIndex = 3;
            // 
            // ctrlBox
            // 
            ctrlBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ctrlBox.CloseHoverBackColor = Color.FromArgb(183, 40, 40);
            ctrlBox.CloseHoverForeColor = Color.White;
            ctrlBox.CloseNormalForeColor = Color.Gray;
            ctrlBox.DisabledForeColor = Color.DimGray;
            ctrlBox.IsDerivedStyle = true;
            ctrlBox.Location = new Point(828, 21);
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
            ctrlBox.TabIndex = 23;
            ctrlBox.Text = "metroSetControlBox1";
            ctrlBox.ThemeAuthor = "Narwin";
            ctrlBox.ThemeName = "MetroLite";
            // 
            // lb_numOfTFQuestions
            // 
            lb_numOfTFQuestions.AutoSize = true;
            lb_numOfTFQuestions.Location = new Point(89, 171);
            lb_numOfTFQuestions.Name = "lb_numOfTFQuestions";
            lb_numOfTFQuestions.Size = new Size(560, 25);
            lb_numOfTFQuestions.TabIndex = 24;
            lb_numOfTFQuestions.Text = "Choose Number of T/F Questions (3 Questions Max)";
            // 
            // numeric_TFQuestions
            // 
            numeric_TFQuestions.Location = new Point(705, 171);
            numeric_TFQuestions.Name = "numeric_TFQuestions";
            numeric_TFQuestions.Size = new Size(150, 34);
            numeric_TFQuestions.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 237);
            label1.Name = "label1";
            label1.Size = new Size(588, 25);
            label1.TabIndex = 26;
            label1.Text = "Choose Number of MCQ Questions (7 Questions Max)";
            // 
            // numeric_MCQ_Questions
            // 
            numeric_MCQ_Questions.Location = new Point(705, 237);
            numeric_MCQ_Questions.Name = "numeric_MCQ_Questions";
            numeric_MCQ_Questions.Size = new Size(150, 34);
            numeric_MCQ_Questions.TabIndex = 27;
            // 
            // DateTimeForExam
            // 
            DateTimeForExam.Location = new Point(593, 364);
            DateTimeForExam.Name = "DateTimeForExam";
            DateTimeForExam.TabIndex = 28;
            // 
            // numeric_Duration
            // 
            numeric_Duration.Location = new Point(705, 297);
            numeric_Duration.Name = "numeric_Duration";
            numeric_Duration.Size = new Size(150, 34);
            numeric_Duration.TabIndex = 29;
            // 
            // lb_Duration
            // 
            lb_Duration.AutoSize = true;
            lb_Duration.Location = new Point(89, 303);
            lb_Duration.Name = "lb_Duration";
            lb_Duration.Size = new Size(256, 25);
            lb_Duration.TabIndex = 30;
            lb_Duration.Text = "Choose Exam Duration";
            // 
            // lb_date
            // 
            lb_date.AutoSize = true;
            lb_date.Location = new Point(89, 364);
            lb_date.Name = "lb_date";
            lb_date.Size = new Size(219, 25);
            lb_date.TabIndex = 31;
            lb_date.Text = "Choose Exam Date";
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.FromArgb(37, 37, 37);
            btn_back.ForeColor = Color.White;
            btn_back.Location = new Point(75, 594);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(228, 59);
            btn_back.TabIndex = 32;
            btn_back.Text = "Back";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // FormGenerateExam
            // 
            AutoScaleDimensions = new SizeF(13F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(963, 708);
            Controls.Add(btn_back);
            Controls.Add(lb_date);
            Controls.Add(lb_Duration);
            Controls.Add(numeric_Duration);
            Controls.Add(DateTimeForExam);
            Controls.Add(numeric_MCQ_Questions);
            Controls.Add(label1);
            Controls.Add(numeric_TFQuestions);
            Controls.Add(lb_numOfTFQuestions);
            Controls.Add(ctrlBox);
            Controls.Add(cmb_Courses);
            Controls.Add(lbCourses);
            Controls.Add(btn_generateExam);
            Font = new Font("Century Gothic", 13F);
            Margin = new Padding(5, 4, 5, 4);
            Name = "FormGenerateExam";
            Padding = new Padding(12, 67, 12, 12);
            SmallLineColor1 = Color.FromArgb(186, 32, 38);
            SmallLineColor2 = Color.FromArgb(186, 32, 38);
            Text = "GenerateExam";
            Load += FormGenerateExam_Load;
            ((System.ComponentModel.ISupportInitialize)numeric_TFQuestions).EndInit();
            ((System.ComponentModel.ISupportInitialize)numeric_MCQ_Questions).EndInit();
            ((System.ComponentModel.ISupportInitialize)numeric_Duration).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_generateExam;
        private Label lbCourses;
        private ComboBox cmb_Courses;
        private MetroSet_UI.Controls.MetroSetControlBox ctrlBox;
        private Label lb_numOfTFQuestions;
        private NumericUpDown numeric_TFQuestions;
        private Label label1;
        private NumericUpDown numeric_MCQ_Questions;
        private MonthCalendar DateTimeForExam;
        private NumericUpDown numeric_Duration;
        private Label lb_Duration;
        private Label lb_date;
        private Button btn_back;
    }
}