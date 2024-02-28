namespace OnlineExaminationSystem
{
    partial class FormCourseTopics
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
            comboCourses = new ComboBox();
            label1 = new Label();
            btnShowTopics = new Button();
            ctrlBox = new MetroSet_UI.Controls.MetroSetControlBox();
            btnNewCourse = new Button();
            lstTopics = new MetroSet_UI.Controls.MetroSetListBox();
            SuspendLayout();
            // 
            // comboCourses
            // 
            comboCourses.FormattingEnabled = true;
            comboCourses.Location = new Point(33, 169);
            comboCourses.Name = "comboCourses";
            comboCourses.Size = new Size(197, 33);
            comboCourses.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(33, 104);
            label1.Name = "label1";
            label1.Size = new Size(160, 25);
            label1.TabIndex = 1;
            label1.Text = "Select Course";
            // 
            // btnShowTopics
            // 
            btnShowTopics.BackColor = Color.FromArgb(186, 32, 38);
            btnShowTopics.FlatStyle = FlatStyle.Flat;
            btnShowTopics.ForeColor = Color.White;
            btnShowTopics.Location = new Point(30, 251);
            btnShowTopics.Name = "btnShowTopics";
            btnShowTopics.Size = new Size(200, 42);
            btnShowTopics.TabIndex = 2;
            btnShowTopics.Text = "Show topics";
            btnShowTopics.UseVisualStyleBackColor = false;
            btnShowTopics.Click += btnShowTopics_Click;
            // 
            // ctrlBox
            // 
            ctrlBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ctrlBox.CloseHoverBackColor = Color.FromArgb(183, 40, 40);
            ctrlBox.CloseHoverForeColor = Color.White;
            ctrlBox.CloseNormalForeColor = Color.Gray;
            ctrlBox.DisabledForeColor = Color.DimGray;
            ctrlBox.IsDerivedStyle = true;
            ctrlBox.Location = new Point(440, 24);
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
            // btnNewCourse
            // 
            btnNewCourse.BackColor = Color.FromArgb(186, 32, 38);
            btnNewCourse.FlatStyle = FlatStyle.Flat;
            btnNewCourse.ForeColor = Color.White;
            btnNewCourse.Location = new Point(303, 251);
            btnNewCourse.Name = "btnNewCourse";
            btnNewCourse.Size = new Size(206, 42);
            btnNewCourse.TabIndex = 24;
            btnNewCourse.Text = "Add New Course";
            btnNewCourse.UseVisualStyleBackColor = false;
            btnNewCourse.Click += btnNewCourse_Click;
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
            lstTopics.Location = new Point(303, 104);
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
            lstTopics.TabIndex = 25;
            lstTopics.ThemeAuthor = "Narwin";
            lstTopics.ThemeName = "MetroLite";
            // 
            // FormCourseTopics
            // 
            AutoScaleDimensions = new SizeF(13F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 337);
            Controls.Add(lstTopics);
            Controls.Add(btnNewCourse);
            Controls.Add(ctrlBox);
            Controls.Add(btnShowTopics);
            Controls.Add(label1);
            Controls.Add(comboCourses);
            Font = new Font("Century Gothic", 13F);
            Name = "FormCourseTopics";
            Padding = new Padding(12, 67, 12, 12);
            SmallLineColor1 = Color.FromArgb(186, 32, 38);
            SmallLineColor2 = Color.FromArgb(186, 32, 38);
            Text = "FormCourseTopics";
            Load += FormCourseTopics_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboCourses;
        private Label label1;
        private Button btnShowTopics;
        private MetroSet_UI.Controls.MetroSetControlBox ctrlBox;
        private Button btnNewCourse;
        private MetroSet_UI.Controls.MetroSetListBox lstTopics;
        private DataGridView grdTopics;
    }
}