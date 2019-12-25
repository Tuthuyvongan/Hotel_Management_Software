namespace QuanLyHotel
{
    partial class CheckOutWindow
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
            this.btCheckOut = new System.Windows.Forms.Button();
            this.label30 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.lbSumCost = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.lbCostService = new System.Windows.Forms.Label();
            this.lbCheckOut = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lbCostRoom = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lbCheckIn = new System.Windows.Forms.Label();
            this.lbNameCustomer = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbNameRoom = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgvBill = new System.Windows.Forms.DataGridView();
            this.btLoadCustomer = new System.Windows.Forms.Button();
            this.txtSearchBill = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).BeginInit();
            this.SuspendLayout();
            // 
            // btCheckOut
            // 
            this.btCheckOut.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btCheckOut.BackColor = System.Drawing.Color.Firebrick;
            this.btCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCheckOut.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCheckOut.ForeColor = System.Drawing.Color.White;
            this.btCheckOut.Location = new System.Drawing.Point(325, 464);
            this.btCheckOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btCheckOut.MaximumSize = new System.Drawing.Size(289, 42);
            this.btCheckOut.Name = "btCheckOut";
            this.btCheckOut.Size = new System.Drawing.Size(289, 42);
            this.btCheckOut.TabIndex = 273;
            this.btCheckOut.Text = "Check Out";
            this.btCheckOut.UseVisualStyleBackColor = false;
            this.btCheckOut.Click += new System.EventHandler(this.btCheckOut_Click_1);
            // 
            // label30
            // 
            this.label30.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold);
            this.label30.ForeColor = System.Drawing.Color.Black;
            this.label30.Location = new System.Drawing.Point(20, 267);
            this.label30.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(269, 38);
            this.label30.TabIndex = 272;
            this.label30.Text = "Cost Information";
            // 
            // label27
            // 
            this.label27.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold);
            this.label27.ForeColor = System.Drawing.Color.Black;
            this.label27.Location = new System.Drawing.Point(16, 11);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(253, 38);
            this.label27.TabIndex = 271;
            this.label27.Text = "Bill Information";
            // 
            // lbSumCost
            // 
            this.lbSumCost.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbSumCost.AutoSize = true;
            this.lbSumCost.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lbSumCost.Location = new System.Drawing.Point(172, 386);
            this.lbSumCost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbSumCost.Name = "lbSumCost";
            this.lbSumCost.Size = new System.Drawing.Size(0, 23);
            this.lbSumCost.TabIndex = 270;
            // 
            // label25
            // 
            this.label25.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label25.Location = new System.Drawing.Point(23, 386);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(97, 23);
            this.label25.TabIndex = 269;
            this.label25.Text = "Sum Cost:";
            // 
            // lbCostService
            // 
            this.lbCostService.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbCostService.AutoSize = true;
            this.lbCostService.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lbCostService.Location = new System.Drawing.Point(172, 336);
            this.lbCostService.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbCostService.Name = "lbCostService";
            this.lbCostService.Size = new System.Drawing.Size(0, 23);
            this.lbCostService.TabIndex = 268;
            this.lbCostService.Visible = false;
            // 
            // lbCheckOut
            // 
            this.lbCheckOut.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbCheckOut.AutoSize = true;
            this.lbCheckOut.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lbCheckOut.Location = new System.Drawing.Point(172, 84);
            this.lbCheckOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbCheckOut.Name = "lbCheckOut";
            this.lbCheckOut.Size = new System.Drawing.Size(0, 23);
            this.lbCheckOut.TabIndex = 267;
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label21.Location = new System.Drawing.Point(23, 84);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(109, 23);
            this.label21.TabIndex = 266;
            this.label21.Text = "Check Out:";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(23, 336);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(124, 23);
            this.label16.TabIndex = 265;
            this.label16.Text = "Cost Service:";
            this.label16.Visible = false;
            // 
            // lbCostRoom
            // 
            this.lbCostRoom.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbCostRoom.AutoSize = true;
            this.lbCostRoom.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lbCostRoom.Location = new System.Drawing.Point(172, 309);
            this.lbCostRoom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbCostRoom.Name = "lbCostRoom";
            this.lbCostRoom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbCostRoom.Size = new System.Drawing.Size(0, 23);
            this.lbCostRoom.TabIndex = 264;
            this.lbCostRoom.Visible = false;
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label18.Location = new System.Drawing.Point(23, 309);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(110, 23);
            this.label18.TabIndex = 263;
            this.label18.Text = "Cost Room:";
            this.label18.Visible = false;
            // 
            // lbCheckIn
            // 
            this.lbCheckIn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbCheckIn.AutoSize = true;
            this.lbCheckIn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lbCheckIn.Location = new System.Drawing.Point(172, 53);
            this.lbCheckIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbCheckIn.Name = "lbCheckIn";
            this.lbCheckIn.Size = new System.Drawing.Size(0, 23);
            this.lbCheckIn.TabIndex = 262;
            // 
            // lbNameCustomer
            // 
            this.lbNameCustomer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbNameCustomer.AutoSize = true;
            this.lbNameCustomer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lbNameCustomer.Location = new System.Drawing.Point(172, 229);
            this.lbNameCustomer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbNameCustomer.Name = "lbNameCustomer";
            this.lbNameCustomer.Size = new System.Drawing.Size(0, 23);
            this.lbNameCustomer.TabIndex = 261;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(23, 53);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 23);
            this.label9.TabIndex = 260;
            this.label9.Text = "Check In:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(23, 229);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 23);
            this.label6.TabIndex = 259;
            this.label6.Text = "Name:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(16, 187);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(346, 38);
            this.label3.TabIndex = 258;
            this.label3.Text = "Customer Information";
            // 
            // lbNameRoom
            // 
            this.lbNameRoom.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbNameRoom.AutoSize = true;
            this.lbNameRoom.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lbNameRoom.Location = new System.Drawing.Point(172, 149);
            this.lbNameRoom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbNameRoom.Name = "lbNameRoom";
            this.lbNameRoom.Size = new System.Drawing.Size(0, 23);
            this.lbNameRoom.TabIndex = 257;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(23, 149);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 23);
            this.label10.TabIndex = 256;
            this.label10.Text = "Name:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(16, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 38);
            this.label2.TabIndex = 255;
            this.label2.Text = "Room Information";
            // 
            // dtgvBill
            // 
            this.dtgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBill.Location = new System.Drawing.Point(395, 84);
            this.dtgvBill.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgvBill.Name = "dtgvBill";
            this.dtgvBill.ReadOnly = true;
            this.dtgvBill.RowHeadersWidth = 51;
            this.dtgvBill.Size = new System.Drawing.Size(604, 326);
            this.dtgvBill.TabIndex = 274;
            this.dtgvBill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvBill_CellClick);
            // 
            // btLoadCustomer
            // 
            this.btLoadCustomer.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btLoadCustomer.BackColor = System.Drawing.Color.Firebrick;
            this.btLoadCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLoadCustomer.Font = new System.Drawing.Font("Times New Roman", 12.25F, System.Drawing.FontStyle.Bold);
            this.btLoadCustomer.ForeColor = System.Drawing.Color.White;
            this.btLoadCustomer.Location = new System.Drawing.Point(856, 43);
            this.btLoadCustomer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btLoadCustomer.Name = "btLoadCustomer";
            this.btLoadCustomer.Size = new System.Drawing.Size(143, 32);
            this.btLoadCustomer.TabIndex = 277;
            this.btLoadCustomer.Text = "Load";
            this.btLoadCustomer.UseVisualStyleBackColor = false;
            this.btLoadCustomer.Click += new System.EventHandler(this.btLoadCustomer_Click);
            // 
            // txtSearchBill
            // 
            this.txtSearchBill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchBill.Font = new System.Drawing.Font("Times New Roman", 12.25F, System.Drawing.FontStyle.Bold);
            this.txtSearchBill.Location = new System.Drawing.Point(483, 44);
            this.txtSearchBill.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearchBill.MaxLength = 40;
            this.txtSearchBill.Name = "txtSearchBill";
            this.txtSearchBill.Size = new System.Drawing.Size(364, 31);
            this.txtSearchBill.TabIndex = 276;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(396, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 24);
            this.label1.TabIndex = 275;
            this.label1.Text = "Search";
            // 
            // CheckOutWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 529);
            this.Controls.Add(this.btLoadCustomer);
            this.Controls.Add(this.txtSearchBill);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvBill);
            this.Controls.Add(this.btCheckOut);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.lbSumCost);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.lbCostService);
            this.Controls.Add(this.lbCheckOut);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lbCostRoom);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.lbCheckIn);
            this.Controls.Add(this.lbNameCustomer);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbNameRoom);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CheckOutWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCheckOut;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label lbSumCost;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label lbCostService;
        private System.Windows.Forms.Label lbCheckOut;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lbCostRoom;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lbCheckIn;
        private System.Windows.Forms.Label lbNameCustomer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbNameRoom;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgvBill;
        private System.Windows.Forms.Button btLoadCustomer;
        private System.Windows.Forms.TextBox txtSearchBill;
        private System.Windows.Forms.Label label1;
    }
}