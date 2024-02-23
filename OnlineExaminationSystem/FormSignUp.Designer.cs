namespace OnlineExaminationSystem
{
    partial class FormSignUp
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
            btnSignUp = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtSsn = new TextBox();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            txtLname = new TextBox();
            txtFname = new TextBox();
            ctrlBox = new MetroSet_UI.Controls.MetroSetControlBox();
            lblgologin = new Label();
            SuspendLayout();
            // 
            // btnSignUp
            // 
            btnSignUp.Location = new Point(381, 334);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(159, 47);
            btnSignUp.TabIndex = 21;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = true;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(265, 287);
            label5.Name = "label5";
            label5.Size = new Size(46, 26);
            label5.TabIndex = 20;
            label5.Text = "ssn";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(261, 228);
            label4.Name = "label4";
            label4.Size = new Size(105, 26);
            label4.TabIndex = 19;
            label4.Text = "password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(261, 178);
            label3.Name = "label3";
            label3.Size = new Size(65, 26);
            label3.TabIndex = 18;
            label3.Text = "email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(265, 124);
            label2.Name = "label2";
            label2.Size = new Size(118, 26);
            label2.TabIndex = 17;
            label2.Text = "Last Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(261, 69);
            label1.Name = "label1";
            label1.Size = new Size(119, 26);
            label1.TabIndex = 16;
            label1.Text = "First Name";
            // 
            // txtSsn
            // 
            txtSsn.Location = new Point(390, 284);
            txtSsn.Name = "txtSsn";
            txtSsn.Size = new Size(125, 32);
            txtSsn.TabIndex = 15;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(390, 225);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(125, 32);
            txtPassword.TabIndex = 14;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(390, 175);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 32);
            txtEmail.TabIndex = 13;
            // 
            // txtLname
            // 
            txtLname.Location = new Point(390, 124);
            txtLname.Name = "txtLname";
            txtLname.Size = new Size(125, 32);
            txtLname.TabIndex = 12;
            // 
            // txtFname
            // 
            txtFname.Location = new Point(390, 69);
            txtFname.Name = "txtFname";
            txtFname.Size = new Size(125, 32);
            txtFname.TabIndex = 11;
            // 
            // ctrlBox
            // 
            ctrlBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ctrlBox.CloseHoverBackColor = Color.FromArgb(183, 40, 40);
            ctrlBox.CloseHoverForeColor = Color.White;
            ctrlBox.CloseNormalForeColor = Color.Gray;
            ctrlBox.DisabledForeColor = Color.DimGray;
            ctrlBox.IsDerivedStyle = true;
            ctrlBox.Location = new Point(685, 12);
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
            // lblgologin
            // 
            lblgologin.AutoSize = true;
            lblgologin.ForeColor = Color.Gray;
            lblgologin.Location = new Point(498, 395);
            lblgologin.Name = "lblgologin";
            lblgologin.Size = new Size(104, 26);
            lblgologin.TabIndex = 23;
            lblgologin.Text = "login now";
            lblgologin.Click += lblgologin_Click;
            // 
            // FormSignUp
            // 
            AutoScaleDimensions = new SizeF(13F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblgologin);
            Controls.Add(ctrlBox);
            Controls.Add(btnSignUp);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSsn);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtLname);
            Controls.Add(txtFname);
            Name = "FormSignUp";
            Text = "FormSignUp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSignUp;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtSsn;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private TextBox txtLname;
        private TextBox txtFname;
        private MetroSet_UI.Controls.MetroSetControlBox ctrlBox;
        private Label lblgologin;
    }
}