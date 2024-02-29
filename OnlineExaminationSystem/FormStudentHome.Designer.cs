namespace OnlineExaminationSystem
{
    partial class FormStudentHome
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
            showGradesBtn = new Button();
            TakeExamBtn = new Button();
            ctrlBox = new MetroSet_UI.Controls.MetroSetControlBox();
            SuspendLayout();
            // 
            // showGradesBtn
            // 
            showGradesBtn.BackColor = Color.FromArgb(186, 32, 38);
            showGradesBtn.FlatStyle = FlatStyle.Flat;
            showGradesBtn.Font = new Font("Century Gothic", 15F);
            showGradesBtn.ForeColor = Color.White;
            showGradesBtn.Location = new Point(93, 122);
            showGradesBtn.Name = "showGradesBtn";
            showGradesBtn.Size = new Size(268, 44);
            showGradesBtn.TabIndex = 54;
            showGradesBtn.Text = "Show Grades";
            showGradesBtn.UseVisualStyleBackColor = false;
            showGradesBtn.Click += showGradesBtn_Click;
            // 
            // TakeExamBtn
            // 
            TakeExamBtn.BackColor = Color.FromArgb(186, 32, 38);
            TakeExamBtn.FlatStyle = FlatStyle.Flat;
            TakeExamBtn.Font = new Font("Century Gothic", 15F);
            TakeExamBtn.ForeColor = Color.White;
            TakeExamBtn.Location = new Point(93, 231);
            TakeExamBtn.Name = "TakeExamBtn";
            TakeExamBtn.Size = new Size(268, 43);
            TakeExamBtn.TabIndex = 55;
            TakeExamBtn.Text = "Take Exam";
            TakeExamBtn.UseVisualStyleBackColor = false;
            TakeExamBtn.Click += TakeExamBtn_Click_2;
            // 
            // ctrlBox
            // 
            ctrlBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ctrlBox.CloseHoverBackColor = Color.FromArgb(183, 40, 40);
            ctrlBox.CloseHoverForeColor = Color.White;
            ctrlBox.CloseNormalForeColor = Color.Gray;
            ctrlBox.DisabledForeColor = Color.DimGray;
            ctrlBox.IsDerivedStyle = true;
            ctrlBox.Location = new Point(343, 15);
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
            ctrlBox.TabIndex = 56;
            ctrlBox.Text = "metroSetControlBox1";
            ctrlBox.ThemeAuthor = "Narwin";
            ctrlBox.ThemeName = "MetroLite";
            // 
            // FormStudentHome
            // 
            AutoScaleDimensions = new SizeF(13F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderColor = Color.FromArgb(186, 32, 38);
            ClientSize = new Size(458, 353);
            Controls.Add(ctrlBox);
            Controls.Add(TakeExamBtn);
            Controls.Add(showGradesBtn);
            Name = "FormStudentHome";
            SmallLineColor1 = Color.FromArgb(186, 32, 38);
            SmallLineColor2 = Color.FromArgb(186, 32, 38);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ITI";
            Load += FormStudentHome_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button showGradesBtn;
        private Button TakeExamBtn;
        private MetroSet_UI.Controls.MetroSetControlBox ctrlBox;
    }
}