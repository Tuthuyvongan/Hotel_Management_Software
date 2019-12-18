namespace QuanLyHotel
{
    partial class AccountWindow
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btLoadAccount = new System.Windows.Forms.Button();
            this.txtSearchRoom = new System.Windows.Forms.TextBox();
            this.dtgvAccount = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.btDeleteAcount = new System.Windows.Forms.Button();
            this.btEditAccount = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbGender = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbCmnd = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // btLoadAccount
            // 
            this.btLoadAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btLoadAccount.BackColor = System.Drawing.Color.Firebrick;
            this.btLoadAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLoadAccount.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLoadAccount.ForeColor = System.Drawing.Color.White;
            this.btLoadAccount.Location = new System.Drawing.Point(406, 297);
            this.btLoadAccount.Name = "btLoadAccount";
            this.btLoadAccount.Size = new System.Drawing.Size(74, 31);
            this.btLoadAccount.TabIndex = 198;
            this.btLoadAccount.Text = "Load";
            this.btLoadAccount.UseVisualStyleBackColor = false;
            this.btLoadAccount.Click += new System.EventHandler(this.BtLoadAccount_Click);
            // 
            // txtSearchRoom
            // 
            this.txtSearchRoom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchRoom.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchRoom.Location = new System.Drawing.Point(86, 297);
            this.txtSearchRoom.MaxLength = 40;
            this.txtSearchRoom.Name = "txtSearchRoom";
            this.txtSearchRoom.Size = new System.Drawing.Size(314, 29);
            this.txtSearchRoom.TabIndex = 197;
            // 
            // dtgvAccount
            // 
            this.dtgvAccount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAccount.Location = new System.Drawing.Point(13, 334);
            this.dtgvAccount.Name = "dtgvAccount";
            this.dtgvAccount.Size = new System.Drawing.Size(793, 302);
            this.dtgvAccount.TabIndex = 196;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 22);
            this.label5.TabIndex = 195;
            this.label5.Text = "Search";
            // 
            // btDeleteAcount
            // 
            this.btDeleteAcount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btDeleteAcount.BackColor = System.Drawing.Color.Firebrick;
            this.btDeleteAcount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDeleteAcount.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeleteAcount.ForeColor = System.Drawing.Color.White;
            this.btDeleteAcount.Location = new System.Drawing.Point(108, 260);
            this.btDeleteAcount.Name = "btDeleteAcount";
            this.btDeleteAcount.Size = new System.Drawing.Size(74, 31);
            this.btDeleteAcount.TabIndex = 203;
            this.btDeleteAcount.Text = "Delete";
            this.btDeleteAcount.UseVisualStyleBackColor = false;
            this.btDeleteAcount.Click += new System.EventHandler(this.BtDeleteAcount_Click);
            // 
            // btEditAccount
            // 
            this.btEditAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btEditAccount.BackColor = System.Drawing.Color.Firebrick;
            this.btEditAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEditAccount.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditAccount.ForeColor = System.Drawing.Color.White;
            this.btEditAccount.Location = new System.Drawing.Point(16, 260);
            this.btEditAccount.Name = "btEditAccount";
            this.btEditAccount.Size = new System.Drawing.Size(74, 31);
            this.btEditAccount.TabIndex = 202;
            this.btEditAccount.Text = "Edit";
            this.btEditAccount.UseVisualStyleBackColor = false;
            this.btEditAccount.Click += new System.EventHandler(this.BtEditAccount_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(10, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 31);
            this.label3.TabIndex = 199;
            this.label3.Text = "Account Information";
            // 
            // label
            // 
            this.label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label.Location = new System.Drawing.Point(13, 120);
            this.label.Margin = new System.Windows.Forms.Padding(3);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(63, 22);
            this.label.TabIndex = 212;
            this.label.Text = "Name:";
            // 
            // lbName
            // 
            this.lbName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.lbName.Location = new System.Drawing.Point(152, 120);
            this.lbName.Margin = new System.Windows.Forms.Padding(3);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(58, 22);
            this.lbName.TabIndex = 213;
            this.lbName.Text = "Name";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label18.Location = new System.Drawing.Point(14, 148);
            this.label18.Margin = new System.Windows.Forms.Padding(3);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(76, 22);
            this.label18.TabIndex = 204;
            this.label18.Text = "Gender:";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(13, 232);
            this.label15.Margin = new System.Windows.Forms.Padding(3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(119, 22);
            this.label15.TabIndex = 205;
            this.label15.Text = "Identify card:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(13, 176);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 22);
            this.label1.TabIndex = 206;
            this.label1.Text = "Phone:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(13, 204);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 22);
            this.label2.TabIndex = 207;
            this.label2.Text = "Email:";
            // 
            // lbGender
            // 
            this.lbGender.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbGender.AutoSize = true;
            this.lbGender.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.lbGender.Location = new System.Drawing.Point(153, 148);
            this.lbGender.Margin = new System.Windows.Forms.Padding(3);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(71, 22);
            this.lbGender.TabIndex = 208;
            this.lbGender.Text = "Gender";
            // 
            // lbPhone
            // 
            this.lbPhone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.lbPhone.Location = new System.Drawing.Point(152, 176);
            this.lbPhone.Margin = new System.Windows.Forms.Padding(3);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(61, 22);
            this.lbPhone.TabIndex = 209;
            this.lbPhone.Text = "Phone";
            // 
            // lbCmnd
            // 
            this.lbCmnd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbCmnd.AutoSize = true;
            this.lbCmnd.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.lbCmnd.Location = new System.Drawing.Point(152, 232);
            this.lbCmnd.Margin = new System.Windows.Forms.Padding(3);
            this.lbCmnd.Name = "lbCmnd";
            this.lbCmnd.Size = new System.Drawing.Size(114, 22);
            this.lbCmnd.TabIndex = 211;
            this.lbCmnd.Text = "Identify card";
            // 
            // lbEmail
            // 
            this.lbEmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.lbEmail.Location = new System.Drawing.Point(153, 204);
            this.lbEmail.Margin = new System.Windows.Forms.Padding(3);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(58, 22);
            this.lbEmail.TabIndex = 210;
            this.lbEmail.Text = "Email";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(14, 64);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 22);
            this.label4.TabIndex = 216;
            this.label4.Text = "Username:";
            // 
            // lbUsername
            // 
            this.lbUsername.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.lbUsername.Location = new System.Drawing.Point(152, 64);
            this.lbUsername.Margin = new System.Windows.Forms.Padding(3);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(58, 22);
            this.lbUsername.TabIndex = 217;
            this.lbUsername.Text = "Name";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(14, 92);
            this.label7.Margin = new System.Windows.Forms.Padding(3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 22);
            this.label7.TabIndex = 214;
            this.label7.Text = "Password:";
            // 
            // lbPassword
            // 
            this.lbPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.lbPassword.Location = new System.Drawing.Point(153, 92);
            this.lbPassword.Margin = new System.Windows.Forms.Padding(3);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(88, 22);
            this.lbPassword.TabIndex = 215;
            this.lbPassword.Text = "password";
            // 
            // AccountWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.label);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbGender);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.lbCmnd);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.btDeleteAcount);
            this.Controls.Add(this.btEditAccount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btLoadAccount);
            this.Controls.Add(this.txtSearchRoom);
            this.Controls.Add(this.dtgvAccount);
            this.Controls.Add(this.label5);
            this.MinimumSize = new System.Drawing.Size(821, 652);
            this.Name = "AccountWindow";
            this.Size = new System.Drawing.Size(821, 652);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btLoadAccount;
        private System.Windows.Forms.TextBox txtSearchRoom;
        private System.Windows.Forms.DataGridView dtgvAccount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btDeleteAcount;
        private System.Windows.Forms.Button btEditAccount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbCmnd;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbPassword;
    }
}
