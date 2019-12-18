namespace QuanLyHotel
{
    partial class CustomerWindow
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
            this.components = new System.ComponentModel.Container();
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dtgvCustomer = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtBirthday = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPhoneCustomer = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIdentifyCardCustomer = new System.Windows.Forms.TextBox();
            this.txtNameCustomer = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btAddCustomer = new System.Windows.Forms.Button();
            this.btEditCustomer = new System.Windows.Forms.Button();
            this.btDeleteCustomer = new System.Windows.Forms.Button();
            this.btLoadCustomer = new System.Windows.Forms.Button();
            this.txtSearchCustomer = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider5
            // 
            this.errorProvider5.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // dtgvCustomer
            // 
            this.dtgvCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCustomer.Location = new System.Drawing.Point(18, 315);
            this.dtgvCustomer.Name = "dtgvCustomer";
            this.dtgvCustomer.RowHeadersWidth = 51;
            this.dtgvCustomer.Size = new System.Drawing.Size(785, 318);
            this.dtgvCustomer.TabIndex = 79;
            this.dtgvCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvCustomer_CellClick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(16, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 77;
            this.label1.Text = "Search";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(10, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(278, 31);
            this.label3.TabIndex = 72;
            this.label3.Text = "Customer Information";
            // 
            // dtBirthday
            // 
            this.dtBirthday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtBirthday.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.dtBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtBirthday.Location = new System.Drawing.Point(157, 156);
            this.dtBirthday.MaximumSize = new System.Drawing.Size(450, 29);
            this.dtBirthday.Name = "dtBirthday";
            this.dtBirthday.Size = new System.Drawing.Size(269, 29);
            this.dtBirthday.TabIndex = 87;
            this.dtBirthday.Value = new System.DateTime(2019, 10, 24, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(17, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 22);
            this.label7.TabIndex = 86;
            this.label7.Text = "Identify Card";
            // 
            // txtPhoneCustomer
            // 
            this.txtPhoneCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhoneCustomer.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.txtPhoneCustomer.Location = new System.Drawing.Point(157, 121);
            this.txtPhoneCustomer.MaximumSize = new System.Drawing.Size(450, 29);
            this.txtPhoneCustomer.MaxLength = 40;
            this.txtPhoneCustomer.Name = "txtPhoneCustomer";
            this.txtPhoneCustomer.Size = new System.Drawing.Size(269, 29);
            this.txtPhoneCustomer.TabIndex = 85;
            this.txtPhoneCustomer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPhoneCustomer_KeyPress);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(17, 161);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 22);
            this.label12.TabIndex = 84;
            this.label12.Text = "Date";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(17, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 22);
            this.label8.TabIndex = 83;
            this.label8.Text = "Phone";
            // 
            // txtIdentifyCardCustomer
            // 
            this.txtIdentifyCardCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIdentifyCardCustomer.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.txtIdentifyCardCustomer.Location = new System.Drawing.Point(157, 86);
            this.txtIdentifyCardCustomer.MaximumSize = new System.Drawing.Size(450, 29);
            this.txtIdentifyCardCustomer.MaxLength = 40;
            this.txtIdentifyCardCustomer.Name = "txtIdentifyCardCustomer";
            this.txtIdentifyCardCustomer.Size = new System.Drawing.Size(269, 29);
            this.txtIdentifyCardCustomer.TabIndex = 82;
            // 
            // txtNameCustomer
            // 
            this.txtNameCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNameCustomer.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.txtNameCustomer.Location = new System.Drawing.Point(157, 52);
            this.txtNameCustomer.MaximumSize = new System.Drawing.Size(450, 29);
            this.txtNameCustomer.MaxLength = 40;
            this.txtNameCustomer.Name = "txtNameCustomer";
            this.txtNameCustomer.Size = new System.Drawing.Size(269, 29);
            this.txtNameCustomer.TabIndex = 81;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(17, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 22);
            this.label6.TabIndex = 80;
            this.label6.Text = "Name";
            // 
            // btAddCustomer
            // 
            this.btAddCustomer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btAddCustomer.BackColor = System.Drawing.Color.Firebrick;
            this.btAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddCustomer.Font = new System.Drawing.Font("Times New Roman", 16.25F, System.Drawing.FontStyle.Bold);
            this.btAddCustomer.ForeColor = System.Drawing.Color.White;
            this.btAddCustomer.Location = new System.Drawing.Point(21, 204);
            this.btAddCustomer.MinimumSize = new System.Drawing.Size(83, 32);
            this.btAddCustomer.Name = "btAddCustomer";
            this.btAddCustomer.Size = new System.Drawing.Size(83, 32);
            this.btAddCustomer.TabIndex = 88;
            this.btAddCustomer.Text = "Add";
            this.btAddCustomer.UseVisualStyleBackColor = false;
            // 
            // btEditCustomer
            // 
            this.btEditCustomer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btEditCustomer.BackColor = System.Drawing.Color.Firebrick;
            this.btEditCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEditCustomer.Font = new System.Drawing.Font("Times New Roman", 16.25F, System.Drawing.FontStyle.Bold);
            this.btEditCustomer.ForeColor = System.Drawing.Color.White;
            this.btEditCustomer.Location = new System.Drawing.Point(120, 204);
            this.btEditCustomer.MinimumSize = new System.Drawing.Size(83, 32);
            this.btEditCustomer.Name = "btEditCustomer";
            this.btEditCustomer.Size = new System.Drawing.Size(83, 32);
            this.btEditCustomer.TabIndex = 89;
            this.btEditCustomer.Text = "Edit";
            this.btEditCustomer.UseVisualStyleBackColor = false;
            // 
            // btDeleteCustomer
            // 
            this.btDeleteCustomer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btDeleteCustomer.BackColor = System.Drawing.Color.Firebrick;
            this.btDeleteCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDeleteCustomer.Font = new System.Drawing.Font("Times New Roman", 16.25F, System.Drawing.FontStyle.Bold);
            this.btDeleteCustomer.ForeColor = System.Drawing.Color.White;
            this.btDeleteCustomer.Location = new System.Drawing.Point(218, 204);
            this.btDeleteCustomer.MinimumSize = new System.Drawing.Size(83, 32);
            this.btDeleteCustomer.Name = "btDeleteCustomer";
            this.btDeleteCustomer.Size = new System.Drawing.Size(83, 32);
            this.btDeleteCustomer.TabIndex = 90;
            this.btDeleteCustomer.Text = "Delete";
            this.btDeleteCustomer.UseVisualStyleBackColor = false;
            // 
            // btLoadCustomer
            // 
            this.btLoadCustomer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btLoadCustomer.BackColor = System.Drawing.Color.Firebrick;
            this.btLoadCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLoadCustomer.Font = new System.Drawing.Font("Times New Roman", 16.25F, System.Drawing.FontStyle.Bold);
            this.btLoadCustomer.ForeColor = System.Drawing.Color.White;
            this.btLoadCustomer.Location = new System.Drawing.Point(320, 204);
            this.btLoadCustomer.MinimumSize = new System.Drawing.Size(83, 32);
            this.btLoadCustomer.Name = "btLoadCustomer";
            this.btLoadCustomer.Size = new System.Drawing.Size(83, 32);
            this.btLoadCustomer.TabIndex = 91;
            this.btLoadCustomer.Text = "Load";
            this.btLoadCustomer.UseVisualStyleBackColor = false;
            // 
            // txtSearchCustomer
            // 
            this.txtSearchCustomer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSearchCustomer.Font = new System.Drawing.Font("Times New Roman", 16.25F, System.Drawing.FontStyle.Bold);
            this.txtSearchCustomer.Location = new System.Drawing.Point(95, 277);
            this.txtSearchCustomer.MaxLength = 40;
            this.txtSearchCustomer.Name = "txtSearchCustomer";
            this.txtSearchCustomer.Size = new System.Drawing.Size(308, 32);
            this.txtSearchCustomer.TabIndex = 92;
            // 
            // CustomerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtSearchCustomer);
            this.Controls.Add(this.btLoadCustomer);
            this.Controls.Add(this.btDeleteCustomer);
            this.Controls.Add(this.btEditCustomer);
            this.Controls.Add(this.btAddCustomer);
            this.Controls.Add(this.dtBirthday);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPhoneCustomer);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtIdentifyCardCustomer);
            this.Controls.Add(this.txtNameCustomer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtgvCustomer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.MinimumSize = new System.Drawing.Size(821, 652);
            this.Name = "CustomerWindow";
            this.Size = new System.Drawing.Size(821, 652);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.DataGridView dtgvCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DateTimePicker dtBirthday;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPhoneCustomer;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIdentifyCardCustomer;
        private System.Windows.Forms.TextBox txtNameCustomer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSearchCustomer;
        private System.Windows.Forms.Button btLoadCustomer;
        private System.Windows.Forms.Button btDeleteCustomer;
        private System.Windows.Forms.Button btEditCustomer;
        private System.Windows.Forms.Button btAddCustomer;
    }
}
