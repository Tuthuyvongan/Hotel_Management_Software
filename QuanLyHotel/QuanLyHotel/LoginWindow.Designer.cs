namespace QuanLyHotel
{
    partial class LoginWindow
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
            this.components = new System.ComponentModel.Container();
            this.MoveBar = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btLogin = new System.Windows.Forms.Button();
            this.btSignUp = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.MoveBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // MoveBar
            // 
            this.MoveBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MoveBar.BackColor = System.Drawing.Color.Firebrick;
            this.MoveBar.Controls.Add(this.panel1);
            this.MoveBar.Controls.Add(this.MinimizeButton);
            this.MoveBar.Controls.Add(this.CloseButton);
            this.MoveBar.Controls.Add(this.button1);
            this.MoveBar.Location = new System.Drawing.Point(0, 0);
            this.MoveBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MoveBar.Name = "MoveBar";
            this.MoveBar.Size = new System.Drawing.Size(173, 320);
            this.MoveBar.TabIndex = 4;
            this.MoveBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveBar_MouseDown);
            this.MoveBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveBar_MouseMove);
            this.MoveBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MoveBar_MouseUp);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.BackgroundImage = global::QuanLyHotel.Properties.Resources.icons8_user_male_50px;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(55, 122);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(65, 58);
            this.panel1.TabIndex = 10;
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Image = global::QuanLyHotel.Properties.Resources.MinimizeButtonIcon;
            this.MinimizeButton.Location = new System.Drawing.Point(1197, 4);
            this.MinimizeButton.Margin = new System.Windows.Forms.Padding(0, 4, 4, 4);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(24, 30);
            this.MinimizeButton.TabIndex = 9;
            this.MinimizeButton.UseVisualStyleBackColor = true;
            // 
            // CloseButton
            // 
            this.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Image = global::QuanLyHotel.Properties.Resources.CloseButtonIcon;
            this.CloseButton.Location = new System.Drawing.Point(1225, 4);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(0, 4, 4, 4);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(24, 30);
            this.CloseButton.TabIndex = 8;
            this.CloseButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1433, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 33);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(311, 100);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(317, 35);
            this.txtUsername.TabIndex = 6;
            // 
            // btLogin
            // 
            this.btLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btLogin.BackColor = System.Drawing.Color.Firebrick;
            this.btLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogin.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogin.ForeColor = System.Drawing.Color.White;
            this.btLogin.Location = new System.Drawing.Point(255, 240);
            this.btLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(375, 38);
            this.btLogin.TabIndex = 12;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = false;
            this.btLogin.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // btSignUp
            // 
            this.btSignUp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btSignUp.BackColor = System.Drawing.Color.White;
            this.btSignUp.FlatAppearance.BorderSize = 0;
            this.btSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSignUp.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSignUp.ForeColor = System.Drawing.Color.Black;
            this.btSignUp.Location = new System.Drawing.Point(371, 282);
            this.btSignUp.Margin = new System.Windows.Forms.Padding(0);
            this.btSignUp.Name = "btSignUp";
            this.btSignUp.Size = new System.Drawing.Size(145, 38);
            this.btSignUp.TabIndex = 13;
            this.btSignUp.Text = "Sign Up";
            this.btSignUp.UseVisualStyleBackColor = false;
            this.btSignUp.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(311, 165);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(317, 35);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(361, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 51);
            this.label1.TabIndex = 5;
            this.label1.Text = "LOGIN";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel3.BackgroundImage = global::QuanLyHotel.Properties.Resources.PasswordIcon;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(255, 165);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(47, 35);
            this.panel3.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel2.BackgroundImage = global::QuanLyHotel.Properties.Resources.UserNameIcon;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(255, 100);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(47, 35);
            this.panel2.TabIndex = 8;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // LoginWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(712, 325);
            this.Controls.Add(this.btSignUp);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MoveBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(727, 362);
            this.Name = "LoginWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginWindow_FormClosing);
            this.MoveBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

      
        private System.Windows.Forms.Panel MoveBar;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Button btSignUp;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}