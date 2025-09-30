namespace Cafe_Management
{
    partial class RegisterForm
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
            this.registerBtn = new System.Windows.Forms.Button();
            this.registerShowPass = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.registerPassword = new System.Windows.Forms.TextBox();
            this.registerUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CloseLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.RegisterSignIn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.registerConfirmPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // registerBtn
            // 
            this.registerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.registerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerBtn.ForeColor = System.Drawing.Color.White;
            this.registerBtn.Location = new System.Drawing.Point(478, 432);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(222, 41);
            this.registerBtn.TabIndex = 17;
            this.registerBtn.Text = "Signup";
            this.registerBtn.UseVisualStyleBackColor = false;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // registerShowPass
            // 
            this.registerShowPass.AutoSize = true;
            this.registerShowPass.Location = new System.Drawing.Point(478, 374);
            this.registerShowPass.Name = "registerShowPass";
            this.registerShowPass.Size = new System.Drawing.Size(129, 20);
            this.registerShowPass.TabIndex = 16;
            this.registerShowPass.Text = "Show Passwoed";
            this.registerShowPass.UseVisualStyleBackColor = true;
            this.registerShowPass.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(474, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Password:";
            // 
            // registerPassword
            // 
            this.registerPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerPassword.Location = new System.Drawing.Point(475, 260);
            this.registerPassword.Name = "registerPassword";
            this.registerPassword.PasswordChar = '*';
            this.registerPassword.Size = new System.Drawing.Size(225, 30);
            this.registerPassword.TabIndex = 14;
            // 
            // registerUsername
            // 
            this.registerUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerUsername.Location = new System.Drawing.Point(475, 177);
            this.registerUsername.Name = "registerUsername";
            this.registerUsername.Size = new System.Drawing.Size(225, 30);
            this.registerUsername.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(474, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Username:";
            // 
            // CloseLabel
            // 
            this.CloseLabel.AutoSize = true;
            this.CloseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseLabel.Location = new System.Drawing.Point(795, 9);
            this.CloseLabel.Name = "CloseLabel";
            this.CloseLabel.Size = new System.Drawing.Size(26, 25);
            this.CloseLabel.TabIndex = 10;
            this.CloseLabel.Text = "X";
            this.CloseLabel.Click += new System.EventHandler(this.CloseLabel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.RegisterSignIn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 528);
            this.panel1.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(73, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(255, 37);
            this.label6.TabIndex = 9;
            this.label6.Text = "Cafe Management";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cafe_Management.Properties.Resources.Cafe_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(99, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 150);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(84, 395);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Already have an account?";
            // 
            // RegisterSignIn
            // 
            this.RegisterSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.RegisterSignIn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterSignIn.ForeColor = System.Drawing.Color.White;
            this.RegisterSignIn.Location = new System.Drawing.Point(46, 432);
            this.RegisterSignIn.Name = "RegisterSignIn";
            this.RegisterSignIn.Size = new System.Drawing.Size(291, 41);
            this.RegisterSignIn.TabIndex = 9;
            this.RegisterSignIn.Text = "SIGN IN";
            this.RegisterSignIn.UseVisualStyleBackColor = false;
            this.RegisterSignIn.Click += new System.EventHandler(this.RegisterSignIn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(472, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 34);
            this.label7.TabIndex = 18;
            this.label7.Text = "Register";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // registerConfirmPassword
            // 
            this.registerConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerConfirmPassword.Location = new System.Drawing.Point(478, 338);
            this.registerConfirmPassword.Name = "registerConfirmPassword";
            this.registerConfirmPassword.PasswordChar = '*';
            this.registerConfirmPassword.Size = new System.Drawing.Size(225, 30);
            this.registerConfirmPassword.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(477, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Password:";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 528);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.registerShowPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.registerConfirmPassword);
            this.Controls.Add(this.registerPassword);
            this.Controls.Add(this.registerUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CloseLabel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.CheckBox registerShowPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox registerPassword;
        private System.Windows.Forms.TextBox registerUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label CloseLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button RegisterSignIn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox registerConfirmPassword;
        private System.Windows.Forms.Label label2;
    }
}