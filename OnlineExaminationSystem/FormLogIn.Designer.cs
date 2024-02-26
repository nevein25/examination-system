namespace OnlineExaminationSystem
{
    partial class FormLogIn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLogIn = new Button();
            Email = new Label();
            label4 = new Label();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            ctrlBox = new MetroSet_UI.Controls.MetroSetControlBox();
            lblGoSignUp = new Label();
            SuspendLayout();
            // 
            // btnLogIn
            // 
            btnLogIn.Font = new Font("Century Gothic", 13F);
            btnLogIn.ForeColor = Color.Gray;
            btnLogIn.Location = new Point(196, 285);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(146, 38);
            btnLogIn.TabIndex = 20;
            btnLogIn.Text = "Login";
            btnLogIn.UseVisualStyleBackColor = true;
            btnLogIn.Click += btnLogIn_Click_1;
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.BackColor = SystemColors.ButtonHighlight;
            Email.Font = new Font("Century Gothic", 13F);
            Email.ForeColor = Color.Gray;
            Email.Location = new Point(147, 85);
            Email.Name = "Email";
            Email.Size = new Size(55, 21);
            Email.TabIndex = 19;
            Email.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonHighlight;
            label4.Font = new Font("Century Gothic", 13F);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(147, 186);
            label4.Name = "label4";
            label4.Size = new Size(90, 21);
            label4.TabIndex = 18;
            label4.Text = "Password";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(147, 120);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(254, 29);
            txtEmail.TabIndex = 17;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(147, 222);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(254, 29);
            txtPassword.TabIndex = 16;
            // 
            // ctrlBox
            // 
            ctrlBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ctrlBox.CloseHoverBackColor = Color.FromArgb(183, 40, 40);
            ctrlBox.CloseHoverForeColor = Color.White;
            ctrlBox.CloseNormalForeColor = Color.Gray;
            ctrlBox.DisabledForeColor = Color.DimGray;
            ctrlBox.IsDerivedStyle = true;
            ctrlBox.Location = new Point(436, 17);
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
            ctrlBox.TabIndex = 21;
            ctrlBox.Text = "metroSetControlBox1";
            ctrlBox.ThemeAuthor = "Narwin";
            ctrlBox.ThemeName = "MetroLite";
            ctrlBox.Click += ctrlBox_Click;
            // 
            // lblGoSignUp
            // 
            lblGoSignUp.AutoSize = true;
            lblGoSignUp.BackColor = SystemColors.ButtonHighlight;
            lblGoSignUp.Font = new Font("Century Gothic", 11F);
            lblGoSignUp.ForeColor = Color.Gray;
            lblGoSignUp.Location = new Point(106, 381);
            lblGoSignUp.Name = "lblGoSignUp";
            lblGoSignUp.Size = new Size(278, 20);
            lblGoSignUp.TabIndex = 24;
            lblGoSignUp.Text = "Don't have an account yet?  Sign Up";
            lblGoSignUp.Click += lblGoSignUp_Click;
            // 
            // FormLogIn
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(551, 433);
            Controls.Add(lblGoSignUp);
            Controls.Add(ctrlBox);
            Controls.Add(btnLogIn);
            Controls.Add(Email);
            Controls.Add(label4);
            Controls.Add(txtEmail);
            Controls.Add(txtPassword);
            Font = new Font("Century Gothic", 13F);
            Name = "FormLogIn";
            Padding = new Padding(12, 67, 12, 12);
            SmallLineColor1 = Color.FromArgb(186, 32, 38);
            SmallLineColor2 = Color.FromArgb(186, 32, 38);
            Text = "ITI";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogIn;
        private Label Email;
        private Label label4;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private MetroSet_UI.Controls.MetroSetControlBox ctrlBox;
        private Label lblGoSignUp;
    }
}
