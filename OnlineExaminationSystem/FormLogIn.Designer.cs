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
            SuspendLayout();
            // 
            // btnLogIn
            // 
            btnLogIn.ForeColor = Color.Gray;
            btnLogIn.Location = new Point(374, 259);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(159, 47);
            btnLogIn.TabIndex = 20;
            btnLogIn.Text = "Login";
            btnLogIn.UseVisualStyleBackColor = true;
            btnLogIn.Click += btnLogIn_Click_1;
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.ForeColor = Color.Gray;
            Email.Location = new Point(272, 148);
            Email.Name = "Email";
            Email.Size = new Size(65, 26);
            Email.TabIndex = 19;
            Email.Text = "email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(268, 199);
            label4.Name = "label4";
            label4.Size = new Size(105, 26);
            label4.TabIndex = 18;
            label4.Text = "password";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(397, 145);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 32);
            txtEmail.TabIndex = 17;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(397, 196);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(125, 32);
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
            ctrlBox.Location = new Point(685, 18);
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
            // 
            // FormLogIn
            // 
            AutoScaleDimensions = new SizeF(13F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ctrlBox);
            Controls.Add(btnLogIn);
            Controls.Add(Email);
            Controls.Add(label4);
            Controls.Add(txtEmail);
            Controls.Add(txtPassword);
            Name = "FormLogIn";
            Text = "Form1";
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
    }
}
