namespace OnlineExaminationSystem
{
    partial class FormHomeInstructor
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
            button1 = new Button();
            ctrlBox = new MetroSet_UI.Controls.MetroSetControlBox();
            btnGenerateExam = new Button();
            btnExamCorrection = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Century Gothic", 13F);
            button1.Location = new Point(15, 297);
            button1.Name = "button1";
            button1.Size = new Size(221, 40);
            button1.TabIndex = 0;
            button1.Text = "Topics for courses";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ctrlBox
            // 
            ctrlBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ctrlBox.CloseHoverBackColor = Color.FromArgb(183, 40, 40);
            ctrlBox.CloseHoverForeColor = Color.White;
            ctrlBox.CloseNormalForeColor = Color.Gray;
            ctrlBox.DisabledForeColor = Color.DimGray;
            ctrlBox.IsDerivedStyle = true;
            ctrlBox.Location = new Point(685, 16);
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
            // btnGenerateExam
            // 
            btnGenerateExam.Font = new Font("Century Gothic", 13F);
            btnGenerateExam.Location = new Point(290, 297);
            btnGenerateExam.Name = "btnGenerateExam";
            btnGenerateExam.Size = new Size(221, 40);
            btnGenerateExam.TabIndex = 23;
            btnGenerateExam.Text = "Generate Exam";
            btnGenerateExam.UseVisualStyleBackColor = true;
            // 
            // btnExamCorrection
            // 
            btnExamCorrection.Font = new Font("Century Gothic", 13F);
            btnExamCorrection.Location = new Point(564, 297);
            btnExamCorrection.Name = "btnExamCorrection";
            btnExamCorrection.Size = new Size(221, 40);
            btnExamCorrection.TabIndex = 24;
            btnExamCorrection.Text = "Exam Correction";
            btnExamCorrection.UseVisualStyleBackColor = true;
            btnExamCorrection.Click += btnExamCorrection_Click;
            // 
            // FormHomeInstructor
            // 
            AutoScaleDimensions = new SizeF(13F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 433);
            Controls.Add(btnExamCorrection);
            Controls.Add(btnGenerateExam);
            Controls.Add(ctrlBox);
            Controls.Add(button1);
            Font = new Font("Century Gothic", 13F);
            Name = "FormHomeInstructor";
            Padding = new Padding(12, 67, 12, 12);
            SmallLineColor1 = Color.FromArgb(186, 32, 38);
            SmallLineColor2 = Color.FromArgb(186, 32, 38);
            Text = "FormHomeInstructor";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private MetroSet_UI.Controls.MetroSetControlBox ctrlBox;
        private Button btnGenerateExam;
        private Button btnExamCorrection;
    }
}