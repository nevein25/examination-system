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
            SIDTxt = new MetroSet_UI.Controls.MetroSetTextBox();
            TakeExamBtn = new Button();
            SuspendLayout();
            // 
            // SIDTxt
            // 
            SIDTxt.AutoCompleteCustomSource = null;
            SIDTxt.AutoCompleteMode = AutoCompleteMode.None;
            SIDTxt.AutoCompleteSource = AutoCompleteSource.None;
            SIDTxt.BorderColor = Color.FromArgb(155, 155, 155);
            SIDTxt.DisabledBackColor = Color.FromArgb(204, 204, 204);
            SIDTxt.DisabledBorderColor = Color.FromArgb(155, 155, 155);
            SIDTxt.DisabledForeColor = Color.FromArgb(136, 136, 136);
            SIDTxt.Font = new Font("Microsoft Sans Serif", 10F);
            SIDTxt.HoverColor = Color.FromArgb(102, 102, 102);
            SIDTxt.Image = null;
            SIDTxt.IsDerivedStyle = true;
            SIDTxt.Lines = null;
            SIDTxt.Location = new Point(351, 94);
            SIDTxt.MaxLength = 32767;
            SIDTxt.Multiline = false;
            SIDTxt.Name = "SIDTxt";
            SIDTxt.ReadOnly = false;
            SIDTxt.Size = new Size(135, 30);
            SIDTxt.Style = MetroSet_UI.Enums.Style.Light;
            SIDTxt.StyleManager = null;
            SIDTxt.TabIndex = 1;
            SIDTxt.Text = "metroSetTextBox1";
            SIDTxt.TextAlign = HorizontalAlignment.Left;
            SIDTxt.ThemeAuthor = "Narwin";
            SIDTxt.ThemeName = "MetroLite";
            SIDTxt.UseSystemPasswordChar = false;
            SIDTxt.WatermarkText = "";
            // 
            // TakeExamBtn
            // 
            TakeExamBtn.Font = new Font("Century Gothic", 13F);
            TakeExamBtn.Location = new Point(280, 190);
            TakeExamBtn.Name = "TakeExamBtn";
            TakeExamBtn.Size = new Size(221, 40);
            TakeExamBtn.TabIndex = 25;
            TakeExamBtn.Text = "Take Exam";
            TakeExamBtn.UseVisualStyleBackColor = true;
            TakeExamBtn.Click += TakeExamBtn_Click;
            // 
            // FormStudentHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TakeExamBtn);
            Controls.Add(SIDTxt);
            Name = "FormStudentHome";
            Text = "FormStudentHome";
            ResumeLayout(false);
        }

        #endregion
        private MetroSet_UI.Controls.MetroSetTextBox SIDTxt;
        private Button TakeExamBtn;
    }
}