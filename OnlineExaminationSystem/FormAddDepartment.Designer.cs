namespace OnlineExaminationSystem
{
    partial class FormAddDepartment
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
            lb_DeptName = new Label();
            txt_DeptName = new TextBox();
            cmb_Mgr = new ComboBox();
            lb_Type = new Label();
            btn_Save = new Button();
            btn_Back = new Button();
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
            ctrlBox.Location = new Point(576, 46);
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
            ctrlBox.TabIndex = 25;
            ctrlBox.Text = "metroSetControlBox1";
            ctrlBox.ThemeAuthor = "Narwin";
            ctrlBox.ThemeName = "MetroLite";
            // 
            // lb_DeptName
            // 
            lb_DeptName.AutoSize = true;
            lb_DeptName.BackColor = SystemColors.ButtonHighlight;
            lb_DeptName.Font = new Font("Century Gothic", 13F);
            lb_DeptName.ForeColor = Color.Gray;
            lb_DeptName.Location = new Point(49, 128);
            lb_DeptName.Name = "lb_DeptName";
            lb_DeptName.Size = new Size(217, 25);
            lb_DeptName.TabIndex = 45;
            lb_DeptName.Text = "Department Name";
            // 
            // txt_DeptName
            // 
            txt_DeptName.Location = new Point(314, 125);
            txt_DeptName.Name = "txt_DeptName";
            txt_DeptName.Size = new Size(363, 34);
            txt_DeptName.TabIndex = 44;
            // 
            // cmb_Mgr
            // 
            cmb_Mgr.FormattingEnabled = true;
            cmb_Mgr.Location = new Point(314, 200);
            cmb_Mgr.Name = "cmb_Mgr";
            cmb_Mgr.Size = new Size(363, 33);
            cmb_Mgr.TabIndex = 47;
            // 
            // lb_Type
            // 
            lb_Type.AutoSize = true;
            lb_Type.BackColor = SystemColors.ButtonHighlight;
            lb_Type.Font = new Font("Century Gothic", 13F);
            lb_Type.ForeColor = Color.Gray;
            lb_Type.Location = new Point(49, 203);
            lb_Type.Name = "lb_Type";
            lb_Type.Size = new Size(252, 25);
            lb_Type.TabIndex = 46;
            lb_Type.Text = "Department Manager";
            // 
            // btn_Save
            // 
            btn_Save.BackColor = Color.FromArgb(186, 32, 38);
            btn_Save.ForeColor = Color.White;
            btn_Save.Location = new Point(449, 288);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(228, 59);
            btn_Save.TabIndex = 48;
            btn_Save.Text = "Save";
            btn_Save.UseVisualStyleBackColor = false;
            btn_Save.Click += btn_Save_Click;
            // 
            // btn_Back
            // 
            btn_Back.BackColor = Color.FromArgb(37, 37, 37);
            btn_Back.ForeColor = Color.White;
            btn_Back.Location = new Point(49, 288);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(228, 59);
            btn_Back.TabIndex = 49;
            btn_Back.Text = "Back";
            btn_Back.UseVisualStyleBackColor = false;
            // 
            // FormAddDepartment
            // 
            AutoScaleDimensions = new SizeF(13F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(733, 390);
            Controls.Add(btn_Back);
            Controls.Add(btn_Save);
            Controls.Add(cmb_Mgr);
            Controls.Add(lb_Type);
            Controls.Add(lb_DeptName);
            Controls.Add(txt_DeptName);
            Controls.Add(ctrlBox);
            Font = new Font("Century Gothic", 13F);
            Name = "FormAddDepartment";
            Padding = new Padding(12, 67, 12, 12);
            SmallLineColor1 = Color.FromArgb(186, 32, 38);
            SmallLineColor2 = Color.FromArgb(186, 32, 38);
            Text = "Add New Department";
            Load += FormAddDepartment_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MetroSet_UI.Controls.MetroSetControlBox ctrlBox;
        private Label lb_DeptName;
        private TextBox txt_DeptName;
        private ComboBox cmb_Mgr;
        private Label lb_Type;
        private Button btn_Save;
        private Button btn_Back;
    }
}