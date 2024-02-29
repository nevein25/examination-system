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
            SuspendLayout();
            // 
            // showGradesBtn
            // 
            showGradesBtn.BackColor = Color.FromArgb(186, 32, 38);
            showGradesBtn.FlatStyle = FlatStyle.Flat;
            showGradesBtn.Font = new Font("Century Gothic", 15F);
            showGradesBtn.ForeColor = Color.White;
            showGradesBtn.Location = new Point(93, 101);
            showGradesBtn.Name = "showGradesBtn";
            showGradesBtn.Size = new Size(169, 32);
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
            TakeExamBtn.Location = new Point(93, 167);
            TakeExamBtn.Name = "TakeExamBtn";
            TakeExamBtn.Size = new Size(169, 32);
            TakeExamBtn.TabIndex = 55;
            TakeExamBtn.Text = "Take Exam";
            TakeExamBtn.UseVisualStyleBackColor = false;
            TakeExamBtn.Click += TakeExamBtn_Click_2;
            // 
            // FormStudentHome
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderColor = Color.FromArgb(186, 32, 38);
            ClientSize = new Size(372, 293);
            Controls.Add(TakeExamBtn);
            Controls.Add(showGradesBtn);
            Name = "FormStudentHome";
            SmallLineColor1 = Color.FromArgb(186, 32, 38);
            SmallLineColor2 = Color.FromArgb(186, 32, 38);
            Text = "ITI";
            Load += FormStudentHome_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button showGradesBtn;
        private Button TakeExamBtn;
    }
}