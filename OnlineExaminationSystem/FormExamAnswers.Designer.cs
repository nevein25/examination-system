namespace OnlineExaminationSystem
{
    partial class FormExamAnswers
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
            CrsName = new MetroSet_UI.Controls.MetroSetLabel();
            CourseName = new MetroSet_UI.Controls.MetroSetLabel();
            metroSetLabel4 = new MetroSet_UI.Controls.MetroSetLabel();
            Marks = new MetroSet_UI.Controls.MetroSetLabel();
            QuestionNumber = new MetroSet_UI.Controls.MetroSetLabel();
            QuesText = new MetroSet_UI.Controls.MetroSetLabel();
            Ch1 = new MetroSet_UI.Controls.MetroSetRadioButton();
            Ch2 = new MetroSet_UI.Controls.MetroSetRadioButton();
            Ch3 = new MetroSet_UI.Controls.MetroSetRadioButton();
            PrevBtn = new MetroSet_UI.Controls.MetroSetButton();
            NextBtn = new MetroSet_UI.Controls.MetroSetButton();
            time = new MetroSet_UI.Controls.MetroSetLabel();
            drt = new MetroSet_UI.Controls.MetroSetLabel();
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
            ctrlBox.Location = new Point(436, 9);
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
            ctrlBox.Click += ctrlBox_Click;
            // 
            // CrsName
            // 
            CrsName.Font = new Font("Century Gothic", 10F);
            CrsName.IsDerivedStyle = true;
            CrsName.Location = new Point(29, 86);
            CrsName.Name = "CrsName";
            CrsName.Size = new Size(111, 30);
            CrsName.Style = MetroSet_UI.Enums.Style.Light;
            CrsName.StyleManager = null;
            CrsName.TabIndex = 36;
            CrsName.Text = "Course Name:";
            CrsName.ThemeAuthor = "Narwin";
            CrsName.ThemeName = "MetroLite";
            // 
            // CourseName
            // 
            CourseName.Font = new Font("Century Gothic", 10F);
            CourseName.IsDerivedStyle = true;
            CourseName.Location = new Point(137, 86);
            CourseName.Name = "CourseName";
            CourseName.Size = new Size(54, 20);
            CourseName.Style = MetroSet_UI.Enums.Style.Light;
            CourseName.StyleManager = null;
            CourseName.TabIndex = 37;
            CourseName.Text = "Label1";
            CourseName.ThemeAuthor = "Narwin";
            CourseName.ThemeName = "MetroLite";
            // 
            // metroSetLabel4
            // 
            metroSetLabel4.Font = new Font("Century Gothic", 10F);
            metroSetLabel4.IsDerivedStyle = true;
            metroSetLabel4.Location = new Point(376, 86);
            metroSetLabel4.Name = "metroSetLabel4";
            metroSetLabel4.Size = new Size(61, 30);
            metroSetLabel4.Style = MetroSet_UI.Enums.Style.Light;
            metroSetLabel4.StyleManager = null;
            metroSetLabel4.TabIndex = 40;
            metroSetLabel4.Text = "Marks:";
            metroSetLabel4.ThemeAuthor = "Narwin";
            metroSetLabel4.ThemeName = "MetroLite";
            // 
            // Marks
            // 
            Marks.Font = new Font("Century Gothic", 10F);
            Marks.IsDerivedStyle = true;
            Marks.Location = new Point(436, 86);
            Marks.Name = "Marks";
            Marks.Size = new Size(61, 20);
            Marks.Style = MetroSet_UI.Enums.Style.Light;
            Marks.StyleManager = null;
            Marks.TabIndex = 41;
            Marks.Text = "Label";
            Marks.ThemeAuthor = "Narwin";
            Marks.ThemeName = "MetroLite";
            // 
            // QuestionNumber
            // 
            QuestionNumber.Font = new Font("Century Gothic", 10F);
            QuestionNumber.IsDerivedStyle = true;
            QuestionNumber.Location = new Point(29, 167);
            QuestionNumber.Name = "QuestionNumber";
            QuestionNumber.Size = new Size(42, 23);
            QuestionNumber.Style = MetroSet_UI.Enums.Style.Light;
            QuestionNumber.StyleManager = null;
            QuestionNumber.TabIndex = 42;
            QuestionNumber.Text = "Q.";
            QuestionNumber.ThemeAuthor = "Narwin";
            QuestionNumber.ThemeName = "MetroLite";
            // 
            // QuesText
            // 
            QuesText.Font = new Font("Century Gothic", 10F);
            QuesText.IsDerivedStyle = true;
            QuesText.Location = new Point(77, 167);
            QuesText.Name = "QuesText";
            QuesText.Size = new Size(424, 44);
            QuesText.Style = MetroSet_UI.Enums.Style.Light;
            QuesText.StyleManager = null;
            QuesText.TabIndex = 43;
            QuesText.Text = "Q.";
            QuesText.ThemeAuthor = "Narwin";
            QuesText.ThemeName = "MetroLite";
            // 
            // Ch1
            // 
            Ch1.BackgroundColor = Color.White;
            Ch1.BorderColor = Color.FromArgb(155, 155, 155);
            Ch1.Checked = false;
            Ch1.CheckSignColor = Color.FromArgb(65, 177, 225);
            Ch1.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            Ch1.DisabledBorderColor = Color.FromArgb(205, 205, 205);
            Ch1.Font = new Font("Microsoft Sans Serif", 10F);
            Ch1.Group = 0;
            Ch1.IsDerivedStyle = true;
            Ch1.Location = new Point(42, 235);
            Ch1.Name = "Ch1";
            Ch1.Size = new Size(117, 17);
            Ch1.Style = MetroSet_UI.Enums.Style.Light;
            Ch1.StyleManager = null;
            Ch1.TabIndex = 44;
            Ch1.Text = "metroSetRadioButton1";
            Ch1.ThemeAuthor = "Narwin";
            Ch1.ThemeName = "MetroLite";
            // 
            // Ch2
            // 
            Ch2.BackgroundColor = Color.White;
            Ch2.BorderColor = Color.FromArgb(155, 155, 155);
            Ch2.Checked = false;
            Ch2.CheckSignColor = Color.FromArgb(65, 177, 225);
            Ch2.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            Ch2.DisabledBorderColor = Color.FromArgb(205, 205, 205);
            Ch2.Font = new Font("Microsoft Sans Serif", 10F);
            Ch2.Group = 0;
            Ch2.IsDerivedStyle = true;
            Ch2.Location = new Point(194, 235);
            Ch2.Name = "Ch2";
            Ch2.Size = new Size(117, 17);
            Ch2.Style = MetroSet_UI.Enums.Style.Light;
            Ch2.StyleManager = null;
            Ch2.TabIndex = 45;
            Ch2.Text = "metroSetRadioButton2";
            Ch2.ThemeAuthor = "Narwin";
            Ch2.ThemeName = "MetroLite";
            // 
            // Ch3
            // 
            Ch3.BackgroundColor = Color.White;
            Ch3.BorderColor = Color.FromArgb(155, 155, 155);
            Ch3.Checked = false;
            Ch3.CheckSignColor = Color.FromArgb(65, 177, 225);
            Ch3.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            Ch3.DisabledBorderColor = Color.FromArgb(205, 205, 205);
            Ch3.Font = new Font("Microsoft Sans Serif", 10F);
            Ch3.Group = 0;
            Ch3.IsDerivedStyle = true;
            Ch3.Location = new Point(360, 235);
            Ch3.Name = "Ch3";
            Ch3.Size = new Size(117, 17);
            Ch3.Style = MetroSet_UI.Enums.Style.Light;
            Ch3.StyleManager = null;
            Ch3.TabIndex = 46;
            Ch3.Text = "metroSetRadioButton3";
            Ch3.ThemeAuthor = "Narwin";
            Ch3.ThemeName = "MetroLite";
            // 
            // PrevBtn
            // 
            PrevBtn.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            PrevBtn.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            PrevBtn.DisabledForeColor = Color.Gray;
            PrevBtn.Font = new Font("Microsoft Sans Serif", 10F);
            PrevBtn.HoverBorderColor = Color.FromArgb(95, 207, 255);
            PrevBtn.HoverColor = Color.FromArgb(95, 207, 255);
            PrevBtn.HoverTextColor = Color.White;
            PrevBtn.IsDerivedStyle = true;
            PrevBtn.Location = new Point(156, 306);
            PrevBtn.Name = "PrevBtn";
            PrevBtn.NormalBorderColor = Color.FromArgb(65, 177, 225);
            PrevBtn.NormalColor = Color.FromArgb(65, 177, 225);
            PrevBtn.NormalTextColor = Color.White;
            PrevBtn.PressBorderColor = Color.FromArgb(35, 147, 195);
            PrevBtn.PressColor = Color.FromArgb(35, 147, 195);
            PrevBtn.PressTextColor = Color.White;
            PrevBtn.Size = new Size(70, 41);
            PrevBtn.Style = MetroSet_UI.Enums.Style.Light;
            PrevBtn.StyleManager = null;
            PrevBtn.TabIndex = 48;
            PrevBtn.Text = "Previous";
            PrevBtn.ThemeAuthor = "Narwin";
            PrevBtn.ThemeName = "MetroLite";
            PrevBtn.Click += PrevBtn_Click_1;
            // 
            // NextBtn
            // 
            NextBtn.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            NextBtn.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            NextBtn.DisabledForeColor = Color.Gray;
            NextBtn.Font = new Font("Microsoft Sans Serif", 10F);
            NextBtn.HoverBorderColor = Color.FromArgb(95, 207, 255);
            NextBtn.HoverColor = Color.FromArgb(95, 207, 255);
            NextBtn.HoverTextColor = Color.White;
            NextBtn.IsDerivedStyle = true;
            NextBtn.Location = new Point(314, 306);
            NextBtn.Name = "NextBtn";
            NextBtn.NormalBorderColor = Color.FromArgb(65, 177, 225);
            NextBtn.NormalColor = Color.FromArgb(65, 177, 225);
            NextBtn.NormalTextColor = Color.White;
            NextBtn.PressBorderColor = Color.FromArgb(35, 147, 195);
            NextBtn.PressColor = Color.FromArgb(35, 147, 195);
            NextBtn.PressTextColor = Color.White;
            NextBtn.Size = new Size(68, 41);
            NextBtn.Style = MetroSet_UI.Enums.Style.Light;
            NextBtn.StyleManager = null;
            NextBtn.TabIndex = 49;
            NextBtn.Text = "Next";
            NextBtn.ThemeAuthor = "Narwin";
            NextBtn.ThemeName = "MetroLite";
            NextBtn.Click += NextBtn_Click_1;
            // 
            // time
            // 
            time.Font = new Font("Century Gothic", 10F);
            time.IsDerivedStyle = true;
            time.Location = new Point(212, 86);
            time.Name = "time";
            time.Size = new Size(73, 20);
            time.Style = MetroSet_UI.Enums.Style.Light;
            time.StyleManager = null;
            time.TabIndex = 50;
            time.Text = "Duration:";
            time.ThemeAuthor = "Narwin";
            time.ThemeName = "MetroLite";
            // 
            // drt
            // 
            drt.Font = new Font("Century Gothic", 10F);
            drt.IsDerivedStyle = true;
            drt.Location = new Point(291, 86);
            drt.Name = "drt";
            drt.Size = new Size(59, 20);
            drt.Style = MetroSet_UI.Enums.Style.Light;
            drt.StyleManager = null;
            drt.TabIndex = 51;
            drt.Text = "Label";
            drt.ThemeAuthor = "Narwin";
            drt.ThemeName = "MetroLite";
            // 
            // FormExamAnswers
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(551, 455);
            Controls.Add(drt);
            Controls.Add(time);
            Controls.Add(NextBtn);
            Controls.Add(PrevBtn);
            Controls.Add(Ch3);
            Controls.Add(Ch2);
            Controls.Add(Ch1);
            Controls.Add(QuesText);
            Controls.Add(QuestionNumber);
            Controls.Add(Marks);
            Controls.Add(metroSetLabel4);
            Controls.Add(CourseName);
            Controls.Add(CrsName);
            Controls.Add(ctrlBox);
            Font = new Font("Century Gothic", 13F);
            Name = "FormExamAnswers";
            Padding = new Padding(12, 74, 12, 13);
            Text = "ITI";
            FormClosed += FormExamAnswers_FormClosed;
            Load += FormExamAnswers_Load;
            ResumeLayout(false);
        }

        #endregion

        private MetroSet_UI.Controls.MetroSetControlBox ctrlBox;
        private Label Duration;
        private Label drtaion;
        private MetroSet_UI.Controls.MetroSetLabel CourseName;
        private MetroSet_UI.Controls.MetroSetLabel C;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel2;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel3;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel4;
        private MetroSet_UI.Controls.MetroSetLabel Marks;
        private MetroSet_UI.Controls.MetroSetLabel QuestionNumber;
        private MetroSet_UI.Controls.MetroSetLabel QuesText;
        private MetroSet_UI.Controls.MetroSetRadioButton Ch1;
        private MetroSet_UI.Controls.MetroSetRadioButton Ch2;
        private MetroSet_UI.Controls.MetroSetRadioButton Ch3;
        private MetroSet_UI.Controls.MetroSetButton PrevBtn;
        private MetroSet_UI.Controls.MetroSetButton NextBtn;
        private MetroSet_UI.Controls.MetroSetLabel time;
        private MetroSet_UI.Controls.MetroSetLabel drt;
        private MetroSet_UI.Controls.MetroSetLabel CrsName;
    }
}