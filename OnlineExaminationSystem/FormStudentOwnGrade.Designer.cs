namespace OnlineExaminationSystem
{
    partial class FormStudentOwnGrade
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
            lstCourses = new MetroSet_UI.Controls.MetroSetListBox();
            label1 = new Label();
            btn_back = new Button();
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
            ctrlBox.Location = new Point(243, 15);
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
            ctrlBox.TabIndex = 29;
            ctrlBox.Text = "metroSetControlBox1";
            ctrlBox.ThemeAuthor = "Narwin";
            ctrlBox.ThemeName = "MetroLite";
            // 
            // lstCourses
            // 
            lstCourses.BackColor = Color.White;
            lstCourses.BorderColor = Color.LightGray;
            lstCourses.DisabledBackColor = Color.FromArgb(204, 204, 204);
            lstCourses.DisabledForeColor = Color.FromArgb(136, 136, 136);
            lstCourses.Font = new Font("Microsoft Sans Serif", 10F);
            lstCourses.HoveredItemBackColor = Color.LightGray;
            lstCourses.HoveredItemColor = Color.DimGray;
            lstCourses.IsDerivedStyle = true;
            lstCourses.ItemHeight = 30;
            lstCourses.Location = new Point(54, 155);
            lstCourses.MultiSelect = false;
            lstCourses.Name = "lstCourses";
            lstCourses.SelectedIndex = -1;
            lstCourses.SelectedItem = null;
            lstCourses.SelectedItemBackColor = Color.FromArgb(65, 177, 225);
            lstCourses.SelectedItemColor = Color.White;
            lstCourses.SelectedText = null;
            lstCourses.SelectedValue = null;
            lstCourses.ShowBorder = false;
            lstCourses.ShowScrollBar = false;
            lstCourses.Size = new Size(206, 98);
            lstCourses.Style = MetroSet_UI.Enums.Style.Light;
            lstCourses.StyleManager = null;
            lstCourses.TabIndex = 30;
            lstCourses.ThemeAuthor = "Narwin";
            lstCourses.ThemeName = "MetroLite";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Century Gothic", 13F);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(129, 102);
            label1.Name = "label1";
            label1.Size = new Size(72, 21);
            label1.TabIndex = 35;
            label1.Text = "Course";
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.FromArgb(37, 37, 37);
            btn_back.ForeColor = Color.White;
            btn_back.Location = new Point(97, 260);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(125, 39);
            btn_back.TabIndex = 36;
            btn_back.Text = "Back";
            btn_back.UseVisualStyleBackColor = false;
            // 
            // FormStudentOwnGrade
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 318);
            Controls.Add(btn_back);
            Controls.Add(label1);
            Controls.Add(lstCourses);
            Controls.Add(ctrlBox);
            Name = "FormStudentOwnGrade";
            SmallLineColor1 = Color.FromArgb(186, 32, 38);
            SmallLineColor2 = Color.FromArgb(186, 32, 38);
            Text = "My Grades";
            Load += FormStudentOwnGrade_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MetroSet_UI.Controls.MetroSetControlBox ctrlBox;
        private MetroSet_UI.Controls.MetroSetListBox lstCourses;
        private Label label1;
        private Button btn_back;
    }
}