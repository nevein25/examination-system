namespace OnlineExaminationSystem
{
    partial class FormAddQuestion
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
            lb_Course = new Label();
            cmbCourses = new ComboBox();
            cmbType = new ComboBox();
            lb_Type = new Label();
            cmbComplexity = new ComboBox();
            lb_Complexity = new Label();
            numMark = new NumericUpDown();
            lb_Mark = new Label();
            lb_QuestionText = new Label();
            Rh_QuestionText = new RichTextBox();
            btn_Save = new Button();
            btn_Back = new Button();
            cmb_ModelAnswer = new ComboBox();
            lb_ModelAnswer = new Label();
            txt_MCQ_Answer2 = new TextBox();
            txt_MCQ_Answer3 = new TextBox();
            txt_MCQ_Answer1 = new TextBox();
            lb_Answer1 = new Label();
            lb_Answer2 = new Label();
            lb_Answer3 = new Label();
            ((System.ComponentModel.ISupportInitialize)numMark).BeginInit();
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
            ctrlBox.Location = new Point(1046, 37);
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
            // lb_Course
            // 
            lb_Course.AutoSize = true;
            lb_Course.BackColor = SystemColors.ButtonHighlight;
            lb_Course.Font = new Font("Century Gothic", 13F);
            lb_Course.ForeColor = Color.Gray;
            lb_Course.Location = new Point(88, 118);
            lb_Course.Name = "lb_Course";
            lb_Course.Size = new Size(87, 25);
            lb_Course.TabIndex = 25;
            lb_Course.Text = "Course";
            // 
            // cmbCourses
            // 
            cmbCourses.FormattingEnabled = true;
            cmbCourses.Location = new Point(331, 118);
            cmbCourses.Name = "cmbCourses";
            cmbCourses.Size = new Size(151, 33);
            cmbCourses.TabIndex = 26;
            // 
            // cmbType
            // 
            cmbType.FormattingEnabled = true;
            cmbType.Location = new Point(331, 194);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(151, 33);
            cmbType.TabIndex = 28;
            cmbType.SelectedIndexChanged += cmbType_SelectedIndexChanged;
            // 
            // lb_Type
            // 
            lb_Type.AutoSize = true;
            lb_Type.BackColor = SystemColors.ButtonHighlight;
            lb_Type.Font = new Font("Century Gothic", 13F);
            lb_Type.ForeColor = Color.Gray;
            lb_Type.Location = new Point(88, 197);
            lb_Type.Name = "lb_Type";
            lb_Type.Size = new Size(165, 25);
            lb_Type.TabIndex = 27;
            lb_Type.Text = "Question Type";
            // 
            // cmbComplexity
            // 
            cmbComplexity.FormattingEnabled = true;
            cmbComplexity.Location = new Point(331, 276);
            cmbComplexity.Name = "cmbComplexity";
            cmbComplexity.Size = new Size(151, 33);
            cmbComplexity.TabIndex = 30;
            // 
            // lb_Complexity
            // 
            lb_Complexity.AutoSize = true;
            lb_Complexity.BackColor = SystemColors.ButtonHighlight;
            lb_Complexity.Font = new Font("Century Gothic", 13F);
            lb_Complexity.ForeColor = Color.Gray;
            lb_Complexity.Location = new Point(88, 279);
            lb_Complexity.Name = "lb_Complexity";
            lb_Complexity.Size = new Size(237, 25);
            lb_Complexity.TabIndex = 29;
            lb_Complexity.Text = "Question Complexity";
            // 
            // numMark
            // 
            numMark.Location = new Point(332, 347);
            numMark.Name = "numMark";
            numMark.Size = new Size(150, 34);
            numMark.TabIndex = 31;
            // 
            // lb_Mark
            // 
            lb_Mark.AutoSize = true;
            lb_Mark.BackColor = SystemColors.ButtonHighlight;
            lb_Mark.Font = new Font("Century Gothic", 13F);
            lb_Mark.ForeColor = Color.Gray;
            lb_Mark.Location = new Point(88, 354);
            lb_Mark.Name = "lb_Mark";
            lb_Mark.Size = new Size(168, 25);
            lb_Mark.TabIndex = 32;
            lb_Mark.Text = "Question Mark";
            // 
            // lb_QuestionText
            // 
            lb_QuestionText.AutoSize = true;
            lb_QuestionText.BackColor = SystemColors.ButtonHighlight;
            lb_QuestionText.Font = new Font("Century Gothic", 13F);
            lb_QuestionText.ForeColor = Color.Gray;
            lb_QuestionText.Location = new Point(558, 118);
            lb_QuestionText.Name = "lb_QuestionText";
            lb_QuestionText.Size = new Size(156, 25);
            lb_QuestionText.TabIndex = 33;
            lb_QuestionText.Text = "Question Text";
            // 
            // Rh_QuestionText
            // 
            Rh_QuestionText.Location = new Point(558, 163);
            Rh_QuestionText.Name = "Rh_QuestionText";
            Rh_QuestionText.Size = new Size(529, 215);
            Rh_QuestionText.TabIndex = 35;
            Rh_QuestionText.Text = "";
            // 
            // btn_Save
            // 
            btn_Save.BackColor = Color.FromArgb(186, 32, 38);
            btn_Save.ForeColor = Color.White;
            btn_Save.Location = new Point(859, 631);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(228, 59);
            btn_Save.TabIndex = 36;
            btn_Save.Text = "Save";
            btn_Save.UseVisualStyleBackColor = false;
            btn_Save.Click += btn_Save_Click;
            // 
            // btn_Back
            // 
            btn_Back.BackColor = Color.FromArgb(37, 37, 37);
            btn_Back.ForeColor = Color.White;
            btn_Back.Location = new Point(88, 631);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(228, 59);
            btn_Back.TabIndex = 37;
            btn_Back.Text = "Back";
            btn_Back.UseVisualStyleBackColor = false;
            // 
            // cmb_ModelAnswer
            // 
            cmb_ModelAnswer.FormattingEnabled = true;
            cmb_ModelAnswer.Location = new Point(459, 554);
            cmb_ModelAnswer.Name = "cmb_ModelAnswer";
            cmb_ModelAnswer.Size = new Size(363, 33);
            cmb_ModelAnswer.TabIndex = 38;
            // 
            // lb_ModelAnswer
            // 
            lb_ModelAnswer.AutoSize = true;
            lb_ModelAnswer.BackColor = SystemColors.ButtonHighlight;
            lb_ModelAnswer.Font = new Font("Century Gothic", 13F);
            lb_ModelAnswer.ForeColor = Color.Gray;
            lb_ModelAnswer.Location = new Point(264, 557);
            lb_ModelAnswer.Name = "lb_ModelAnswer";
            lb_ModelAnswer.Size = new Size(170, 25);
            lb_ModelAnswer.TabIndex = 39;
            lb_ModelAnswer.Text = "Model Answer";
            // 
            // txt_MCQ_Answer2
            // 
            txt_MCQ_Answer2.Location = new Point(435, 471);
            txt_MCQ_Answer2.Name = "txt_MCQ_Answer2";
            txt_MCQ_Answer2.Size = new Size(252, 34);
            txt_MCQ_Answer2.TabIndex = 40;
            // 
            // txt_MCQ_Answer3
            // 
            txt_MCQ_Answer3.Location = new Point(835, 471);
            txt_MCQ_Answer3.Name = "txt_MCQ_Answer3";
            txt_MCQ_Answer3.Size = new Size(252, 34);
            txt_MCQ_Answer3.TabIndex = 41;
            // 
            // txt_MCQ_Answer1
            // 
            txt_MCQ_Answer1.Location = new Point(88, 471);
            txt_MCQ_Answer1.Name = "txt_MCQ_Answer1";
            txt_MCQ_Answer1.Size = new Size(252, 34);
            txt_MCQ_Answer1.TabIndex = 42;
            // 
            // lb_Answer1
            // 
            lb_Answer1.AutoSize = true;
            lb_Answer1.BackColor = SystemColors.ButtonHighlight;
            lb_Answer1.Font = new Font("Century Gothic", 13F);
            lb_Answer1.ForeColor = Color.Gray;
            lb_Answer1.Location = new Point(129, 430);
            lb_Answer1.Name = "lb_Answer1";
            lb_Answer1.Size = new Size(176, 25);
            lb_Answer1.TabIndex = 43;
            lb_Answer1.Text = "MCQ Answer 1";
            // 
            // lb_Answer2
            // 
            lb_Answer2.AutoSize = true;
            lb_Answer2.BackColor = SystemColors.ButtonHighlight;
            lb_Answer2.Font = new Font("Century Gothic", 13F);
            lb_Answer2.ForeColor = Color.Gray;
            lb_Answer2.Location = new Point(476, 430);
            lb_Answer2.Name = "lb_Answer2";
            lb_Answer2.Size = new Size(176, 25);
            lb_Answer2.TabIndex = 44;
            lb_Answer2.Text = "MCQ Answer 2";
            // 
            // lb_Answer3
            // 
            lb_Answer3.AutoSize = true;
            lb_Answer3.BackColor = SystemColors.ButtonHighlight;
            lb_Answer3.Font = new Font("Century Gothic", 13F);
            lb_Answer3.ForeColor = Color.Gray;
            lb_Answer3.Location = new Point(859, 430);
            lb_Answer3.Name = "lb_Answer3";
            lb_Answer3.Size = new Size(176, 25);
            lb_Answer3.TabIndex = 45;
            lb_Answer3.Text = "MCQ Answer 3";
            // 
            // FormAddQuestion
            // 
            AutoScaleDimensions = new SizeF(13F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1193, 727);
            Controls.Add(lb_Answer3);
            Controls.Add(lb_Answer2);
            Controls.Add(lb_Answer1);
            Controls.Add(txt_MCQ_Answer1);
            Controls.Add(txt_MCQ_Answer3);
            Controls.Add(txt_MCQ_Answer2);
            Controls.Add(lb_ModelAnswer);
            Controls.Add(cmb_ModelAnswer);
            Controls.Add(btn_Back);
            Controls.Add(btn_Save);
            Controls.Add(Rh_QuestionText);
            Controls.Add(lb_QuestionText);
            Controls.Add(lb_Mark);
            Controls.Add(numMark);
            Controls.Add(cmbComplexity);
            Controls.Add(lb_Complexity);
            Controls.Add(cmbType);
            Controls.Add(lb_Type);
            Controls.Add(cmbCourses);
            Controls.Add(lb_Course);
            Controls.Add(ctrlBox);
            Font = new Font("Century Gothic", 13F);
            Name = "FormAddQuestion";
            Padding = new Padding(12, 67, 12, 12);
            SmallLineColor1 = Color.FromArgb(186, 32, 38);
            SmallLineColor2 = Color.FromArgb(186, 32, 38);
            Text = "Add Question";
            Load += FormAddQuestion_Load;
            ((System.ComponentModel.ISupportInitialize)numMark).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MetroSet_UI.Controls.MetroSetControlBox ctrlBox;
        private Label lb_Course;
        private ComboBox cmbCourses;
        private ComboBox cmbType;
        private Label lb_Type;
        private ComboBox cmbComplexity;
        private Label lb_Complexity;
        private NumericUpDown numMark;
        private Label lb_Mark;
        private Label lb_QuestionText;
        private RichTextBox Rh_QuestionText;
        private Button btn_Save;
        private Button btn_Back;
        private ComboBox cmb_ModelAnswer;
        private Label lb_ModelAnswer;
        private TextBox txt_MCQ_Answer2;
        private TextBox txt_MCQ_Answer3;
        private TextBox txt_MCQ_Answer1;
        private Label lb_Answer1;
        private Label lb_Answer2;
        private Label lb_Answer3;
    }
}