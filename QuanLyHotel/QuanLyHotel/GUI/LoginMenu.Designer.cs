namespace QuanLyHotel
{
    partial class LoginMenu
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
            this.labellogin = new System.Windows.Forms.Label();
            this.textBoxlogin = new System.Windows.Forms.TextBox();
            this.textBoxpassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonlogin = new System.Windows.Forms.Button();
            this.buttonexitlogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labellogin
            // 
            this.labellogin.AutoSize = true;
            this.labellogin.Location = new System.Drawing.Point(30, 25);
            this.labellogin.Name = "labellogin";
            this.labellogin.Size = new System.Drawing.Size(109, 17);
            this.labellogin.TabIndex = 0;
            this.labellogin.Text = "Tên đăng nhập:";
            // 
            // textBoxlogin
            // 
            this.textBoxlogin.Location = new System.Drawing.Point(190, 24);
            this.textBoxlogin.Name = "textBoxlogin";
            this.textBoxlogin.Size = new System.Drawing.Size(155, 22);
            this.textBoxlogin.TabIndex = 1;
            // 
            // textBoxpassword
            // 
            this.textBoxpassword.Location = new System.Drawing.Point(190, 65);
            this.textBoxpassword.Name = "textBoxpassword";
            this.textBoxpassword.Size = new System.Drawing.Size(155, 22);
            this.textBoxpassword.TabIndex = 3;
            this.textBoxpassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mật khẩu:";
            // 
            // buttonlogin
            // 
            this.buttonlogin.Location = new System.Drawing.Point(128, 113);
            this.buttonlogin.Name = "buttonlogin";
            this.buttonlogin.Size = new System.Drawing.Size(94, 28);
            this.buttonlogin.TabIndex = 4;
            this.buttonlogin.Text = "Đăng nhập";
            this.buttonlogin.UseVisualStyleBackColor = true;
            this.buttonlogin.Click += new System.EventHandler(this.Buttonlogin_Click);
            // 
            // buttonexitlogin
            // 
            this.buttonexitlogin.Location = new System.Drawing.Point(250, 112);
            this.buttonexitlogin.Name = "buttonexitlogin";
            this.buttonexitlogin.Size = new System.Drawing.Size(95, 28);
            this.buttonexitlogin.TabIndex = 5;
            this.buttonexitlogin.Text = "Thoát";
            this.buttonexitlogin.UseVisualStyleBackColor = true;
            this.buttonexitlogin.Click += new System.EventHandler(this.Buttonexitlogin_Click);
            // 
            // LoginMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 170);
            this.Controls.Add(this.buttonexitlogin);
            this.Controls.Add(this.buttonlogin);
            this.Controls.Add(this.textBoxpassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxlogin);
            this.Controls.Add(this.labellogin);
            this.Name = "LoginMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginMenu_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labellogin;
        private System.Windows.Forms.TextBox textBoxlogin;
        private System.Windows.Forms.TextBox textBoxpassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonlogin;
        private System.Windows.Forms.Button buttonexitlogin;
    }
}

