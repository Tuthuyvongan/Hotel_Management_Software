namespace QuanLyHotel
{
    partial class UseServiceWindow
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
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dtgvService = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbBedsAmount = new System.Windows.Forms.Label();
            this.lbKindRoom = new System.Windows.Forms.Label();
            this.lbNameRoom = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtDateService = new System.Windows.Forms.DateTimePicker();
            this.txtNumberService = new System.Windows.Forms.TextBox();
            this.txtSearchService = new System.Windows.Forms.TextBox();
            this.btLoadCustomer = new System.Windows.Forms.Button();
            this.btUseService = new System.Windows.Forms.Button();
            this.lbKindService = new System.Windows.Forms.Label();
            this.lbNameService = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbCost = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(77, 299);
            this.label14.Margin = new System.Windows.Forms.Padding(4);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 23);
            this.label14.TabIndex = 124;
            this.label14.Text = "Number";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(77, 261);
            this.label12.Margin = new System.Windows.Forms.Padding(4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 23);
            this.label12.TabIndex = 122;
            this.label12.Text = "Date";
            // 
            // dtgvService
            // 
            this.dtgvService.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvService.Location = new System.Drawing.Point(25, 508);
            this.dtgvService.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvService.Name = "dtgvService";
            this.dtgvService.ReadOnly = true;
            this.dtgvService.RowHeadersWidth = 51;
            this.dtgvService.Size = new System.Drawing.Size(503, 151);
            this.dtgvService.TabIndex = 121;
            this.dtgvService.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvService_CellClick);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(19, 469);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 26);
            this.label10.TabIndex = 119;
            this.label10.Text = "Search";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(45, 207);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(167, 38);
            this.label11.TabIndex = 118;
            this.label11.Text = "SERVICE";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(45, 75);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 38);
            this.label8.TabIndex = 114;
            this.label8.Text = "ROOM";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(16, 11);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(310, 51);
            this.label7.TabIndex = 113;
            this.label7.Text = "USE SERVICE";
            // 
            // lbBedsAmount
            // 
            this.lbBedsAmount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbBedsAmount.AutoSize = true;
            this.lbBedsAmount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lbBedsAmount.Location = new System.Drawing.Point(227, 172);
            this.lbBedsAmount.Margin = new System.Windows.Forms.Padding(4);
            this.lbBedsAmount.Name = "lbBedsAmount";
            this.lbBedsAmount.Size = new System.Drawing.Size(59, 23);
            this.lbBedsAmount.TabIndex = 233;
            this.lbBedsAmount.Text = "Name";
            // 
            // lbKindRoom
            // 
            this.lbKindRoom.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbKindRoom.AutoSize = true;
            this.lbKindRoom.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lbKindRoom.Location = new System.Drawing.Point(227, 145);
            this.lbKindRoom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbKindRoom.Name = "lbKindRoom";
            this.lbKindRoom.Size = new System.Drawing.Size(59, 23);
            this.lbKindRoom.TabIndex = 232;
            this.lbKindRoom.Text = "Name";
            // 
            // lbNameRoom
            // 
            this.lbNameRoom.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbNameRoom.AutoSize = true;
            this.lbNameRoom.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lbNameRoom.Location = new System.Drawing.Point(227, 118);
            this.lbNameRoom.Margin = new System.Windows.Forms.Padding(4);
            this.lbNameRoom.Name = "lbNameRoom";
            this.lbNameRoom.Size = new System.Drawing.Size(59, 23);
            this.lbNameRoom.TabIndex = 231;
            this.lbNameRoom.Text = "Name";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(77, 172);
            this.label4.Margin = new System.Windows.Forms.Padding(4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 23);
            this.label4.TabIndex = 230;
            this.label4.Text = "Beds Amount:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(77, 118);
            this.label1.Margin = new System.Windows.Forms.Padding(4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 23);
            this.label1.TabIndex = 229;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(77, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 23);
            this.label2.TabIndex = 228;
            this.label2.Text = "Kind:";
            // 
            // dtDateService
            // 
            this.dtDateService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtDateService.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDateService.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDateService.Location = new System.Drawing.Point(169, 254);
            this.dtDateService.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtDateService.Name = "dtDateService";
            this.dtDateService.Size = new System.Drawing.Size(207, 30);
            this.dtDateService.TabIndex = 236;
            this.dtDateService.Value = new System.DateTime(2019, 10, 24, 0, 0, 0, 0);
            // 
            // txtNumberService
            // 
            this.txtNumberService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumberService.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberService.Location = new System.Drawing.Point(169, 295);
            this.txtNumberService.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumberService.MaxLength = 40;
            this.txtNumberService.Name = "txtNumberService";
            this.txtNumberService.Size = new System.Drawing.Size(207, 30);
            this.txtNumberService.TabIndex = 237;
            this.txtNumberService.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumberService_KeyPress);
            // 
            // txtSearchService
            // 
            this.txtSearchService.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchService.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchService.Location = new System.Drawing.Point(116, 465);
            this.txtSearchService.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchService.MaxLength = 40;
            this.txtSearchService.Name = "txtSearchService";
            this.txtSearchService.Size = new System.Drawing.Size(260, 35);
            this.txtSearchService.TabIndex = 238;
            // 
            // btLoadCustomer
            // 
            this.btLoadCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btLoadCustomer.BackColor = System.Drawing.Color.Firebrick;
            this.btLoadCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLoadCustomer.Font = new System.Drawing.Font("Times New Roman", 12.25F, System.Drawing.FontStyle.Bold);
            this.btLoadCustomer.ForeColor = System.Drawing.Color.White;
            this.btLoadCustomer.Location = new System.Drawing.Point(385, 464);
            this.btLoadCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.btLoadCustomer.MaximumSize = new System.Drawing.Size(143, 37);
            this.btLoadCustomer.Name = "btLoadCustomer";
            this.btLoadCustomer.Size = new System.Drawing.Size(143, 37);
            this.btLoadCustomer.TabIndex = 239;
            this.btLoadCustomer.Text = "Load";
            this.btLoadCustomer.UseVisualStyleBackColor = false;
            this.btLoadCustomer.Click += new System.EventHandler(this.btLoadCustomer_Click);
            // 
            // btUseService
            // 
            this.btUseService.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btUseService.BackColor = System.Drawing.Color.Firebrick;
            this.btUseService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUseService.Font = new System.Drawing.Font("Times New Roman", 12.25F, System.Drawing.FontStyle.Bold);
            this.btUseService.ForeColor = System.Drawing.Color.White;
            this.btUseService.Location = new System.Drawing.Point(183, 667);
            this.btUseService.Margin = new System.Windows.Forms.Padding(4);
            this.btUseService.Name = "btUseService";
            this.btUseService.Size = new System.Drawing.Size(176, 52);
            this.btUseService.TabIndex = 240;
            this.btUseService.Text = "Use Service";
            this.btUseService.UseVisualStyleBackColor = false;
            this.btUseService.Click += new System.EventHandler(this.btUseService_Click);
            // 
            // lbKindService
            // 
            this.lbKindService.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbKindService.AutoSize = true;
            this.lbKindService.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lbKindService.Location = new System.Drawing.Point(227, 374);
            this.lbKindService.Margin = new System.Windows.Forms.Padding(4);
            this.lbKindService.Name = "lbKindService";
            this.lbKindService.Size = new System.Drawing.Size(59, 23);
            this.lbKindService.TabIndex = 244;
            this.lbKindService.Text = "Name";
            // 
            // lbNameService
            // 
            this.lbNameService.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbNameService.AutoSize = true;
            this.lbNameService.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lbNameService.Location = new System.Drawing.Point(227, 343);
            this.lbNameService.Margin = new System.Windows.Forms.Padding(4);
            this.lbNameService.Name = "lbNameService";
            this.lbNameService.Size = new System.Drawing.Size(59, 23);
            this.lbNameService.TabIndex = 243;
            this.lbNameService.Text = "Name";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(77, 343);
            this.label6.Margin = new System.Windows.Forms.Padding(4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 23);
            this.label6.TabIndex = 242;
            this.label6.Text = "Name:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(77, 374);
            this.label9.Margin = new System.Windows.Forms.Padding(4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 23);
            this.label9.TabIndex = 241;
            this.label9.Text = "Kind:";
            // 
            // lbCost
            // 
            this.lbCost.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbCost.AutoSize = true;
            this.lbCost.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lbCost.Location = new System.Drawing.Point(227, 405);
            this.lbCost.Margin = new System.Windows.Forms.Padding(4);
            this.lbCost.Name = "lbCost";
            this.lbCost.Size = new System.Drawing.Size(59, 23);
            this.lbCost.TabIndex = 246;
            this.lbCost.Text = "Name";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(77, 405);
            this.label15.Margin = new System.Windows.Forms.Padding(4);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 23);
            this.label15.TabIndex = 245;
            this.label15.Text = "Cost:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // UseServiceWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 724);
            this.Controls.Add(this.lbCost);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lbKindService);
            this.Controls.Add(this.lbNameService);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btUseService);
            this.Controls.Add(this.btLoadCustomer);
            this.Controls.Add(this.txtSearchService);
            this.Controls.Add(this.txtNumberService);
            this.Controls.Add(this.dtDateService);
            this.Controls.Add(this.lbBedsAmount);
            this.Controls.Add(this.lbKindRoom);
            this.Controls.Add(this.lbNameRoom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dtgvService);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(573, 761);
            this.Name = "UseServiceWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dtgvService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dtgvService;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbBedsAmount;
        private System.Windows.Forms.Label lbKindRoom;
        private System.Windows.Forms.Label lbNameRoom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DateTimePicker dtDateService;
        private System.Windows.Forms.TextBox txtNumberService;
        private System.Windows.Forms.TextBox txtSearchService;
        private System.Windows.Forms.Button btLoadCustomer;
        private System.Windows.Forms.Button btUseService;
        private System.Windows.Forms.Label lbKindService;
        private System.Windows.Forms.Label lbNameService;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbCost;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
    }
}