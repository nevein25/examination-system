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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSignUp));
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
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnSignUp
            // 
            btnSignUp.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSignUp.Font = new Font("Century Gothic", 13F);
            btnSignUp.Location = new Point(519, 364);
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
            label5.BackColor = SystemColors.ButtonHighlight;
            label5.Font = new Font("Century Gothic", 13F);
            label5.Location = new Point(310, 319);
            label5.Name = "label5";
            label5.Size = new Size(50, 25);
            label5.TabIndex = 20;
            label5.Text = "SSN";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonHighlight;
            label4.Font = new Font("Century Gothic", 13F);
            label4.Location = new Point(310, 266);
            label4.Name = "label4";
            label4.Size = new Size(114, 25);
            label4.TabIndex = 19;
            label4.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.Font = new Font("Century Gothic", 13F);
            label3.Location = new Point(310, 213);
            label3.Name = "label3";
            label3.Size = new Size(71, 25);
            label3.TabIndex = 18;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Font = new Font("Century Gothic", 13F);
            label2.Location = new Point(310, 160);
            label2.Name = "label2";
            label2.Size = new Size(127, 25);
            label2.TabIndex = 17;
            label2.Text = "Last Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Century Gothic", 13F);
            label1.Location = new Point(310, 107);
            label1.Name = "label1";
            label1.Size = new Size(124, 25);
            label1.TabIndex = 16;
            label1.Text = "First Name";
            // 
            // txtSsn
            // 
            txtSsn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtSsn.Location = new Point(496, 312);
            txtSsn.Name = "txtSsn";
            txtSsn.Size = new Size(207, 32);
            txtSsn.TabIndex = 15;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtPassword.Location = new Point(496, 259);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(207, 32);
            txtPassword.TabIndex = 14;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtEmail.Location = new Point(496, 206);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(207, 32);
            txtEmail.TabIndex = 13;
            // 
            // txtLname
            // 
            txtLname.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtLname.Location = new Point(496, 153);
            txtLname.Name = "txtLname";
            txtLname.Size = new Size(207, 32);
            txtLname.TabIndex = 12;
            // 
            // txtFname
            // 
            txtFname.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtFname.Location = new Point(496, 100);
            txtFname.Name = "txtFname";
            txtFname.Size = new Size(207, 32);
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
            ctrlBox.Location = new Point(680, 12);
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
            lblgologin.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblgologin.AutoSize = true;
            lblgologin.BackColor = SystemColors.ButtonHighlight;
            lblgologin.Font = new Font("Century Gothic", 11F);
            lblgologin.ForeColor = Color.Gray;
            lblgologin.Location = new Point(417, 470);
            lblgologin.Name = "lblgologin";
            lblgologin.Size = new Size(363, 22);
            lblgologin.TabIndex = 23;
            lblgologin.Text = "Already Registered? Click here to login";
            lblgologin.Click += lblgologin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(15, 111);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(287, 180);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // FormSignUp
            // 
            AutoScaleDimensions = new SizeF(13F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 504);
            Controls.Add(pictureBox1);
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
            SmallLineColor1 = Color.FromArgb(186, 32, 38);
            SmallLineColor2 = Color.FromArgb(186, 32, 38);
            Text = "SignUp";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
    }
}