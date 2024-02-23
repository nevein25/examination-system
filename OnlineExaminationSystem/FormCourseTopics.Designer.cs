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
            button1 = new Button();
            ctrlBox = new MetroSet_UI.Controls.MetroSetControlBox();
            grdTopics = new DataGridView();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)grdTopics).BeginInit();
            SuspendLayout();
            // 
            // comboCourses
            // 
            comboCourses.FormattingEnabled = true;
            comboCourses.Location = new Point(211, 104);
            comboCourses.Name = "comboCourses";
            comboCourses.Size = new Size(151, 33);
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
            // button1
            // 
            button1.Location = new Point(59, 175);
            button1.Name = "button1";
            button1.Size = new Size(200, 42);
            button1.TabIndex = 2;
            button1.Text = "Show topics";
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
            ctrlBox.Location = new Point(685, 24);
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
            // grdTopics
            // 
            grdTopics.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdTopics.Location = new Point(59, 237);
            grdTopics.Name = "grdTopics";
            grdTopics.RowHeadersWidth = 51;
            grdTopics.Size = new Size(300, 181);
            grdTopics.TabIndex = 23;
            // 
            // button2
            // 
            button2.Location = new Point(568, 87);
            button2.Name = "button2";
            button2.Size = new Size(206, 42);
            button2.TabIndex = 24;
            button2.Text = "Add New Course";
            button2.UseVisualStyleBackColor = true;
            // 
            // FormCourseTopics
            // 
            AutoScaleDimensions = new SizeF(13F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 433);
            Controls.Add(button2);
            Controls.Add(grdTopics);
            Controls.Add(ctrlBox);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(comboCourses);
            Font = new Font("Century Gothic", 13F);
            Name = "FormCourseTopics";
            Padding = new Padding(12, 67, 12, 12);
            SmallLineColor1 = Color.FromArgb(186, 32, 38);
            SmallLineColor2 = Color.FromArgb(186, 32, 38);
            Text = "FormCourseTopics";
            Load += FormCourseTopics_Load;
            ((System.ComponentModel.ISupportInitialize)grdTopics).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboCourses;
        private Label label1;
        private Button button1;
        private MetroSet_UI.Controls.MetroSetControlBox ctrlBox;
        private DataGridView grdTopics;
        private Button button2;
    }
}