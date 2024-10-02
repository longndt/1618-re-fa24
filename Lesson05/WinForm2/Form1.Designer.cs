namespace WinForm2
{
    partial class Form1
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
            groupBox1 = new GroupBox();
            btnLogin = new Button();
            tbPassword = new TextBox();
            tbUsername = new TextBox();
            lblPassword = new Label();
            lblUsername = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLogin);
            groupBox1.Controls.Add(tbPassword);
            groupBox1.Controls.Add(tbUsername);
            groupBox1.Controls.Add(lblPassword);
            groupBox1.Controls.Add(lblUsername);
            groupBox1.Font = new Font("JetBrains Mono", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Red;
            groupBox1.Location = new Point(37, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(534, 305);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "User Login";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Salmon;
            btnLogin.ForeColor = Color.Lime;
            btnLogin.Location = new Point(279, 238);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(112, 43);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(197, 168);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(286, 39);
            tbPassword.TabIndex = 3;
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(197, 79);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(286, 39);
            tbUsername.TabIndex = 2;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.ForeColor = Color.Blue;
            lblPassword.Location = new Point(38, 176);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(126, 31);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.ForeColor = Color.Blue;
            lblUsername.Location = new Point(38, 82);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(126, 31);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(612, 361);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User Login";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnLogin;
        private TextBox tbPassword;
        private TextBox tbUsername;
        private Label lblPassword;
        private Label lblUsername;
    }
}
