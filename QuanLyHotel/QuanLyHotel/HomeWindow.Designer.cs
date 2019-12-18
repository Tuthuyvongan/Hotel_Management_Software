namespace QuanLyHotel
{
    partial class HomeWindow
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
            this.label3 = new System.Windows.Forms.Label();
            this.btUseService = new System.Windows.Forms.Button();
            this.btCheckInRoom = new System.Windows.Forms.Button();
            this.btCheckOut = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbKind = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.lbCost = new System.Windows.Forms.Label();
            this.lbBedsAmount = new System.Windows.Forms.Label();
            this.dtgvRoom = new System.Windows.Forms.DataGridView();
            this.label = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(748, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(291, 38);
            this.label3.TabIndex = 110;
            this.label3.Text = "Room Information";
            // 
            // btUseService
            // 
            this.btUseService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btUseService.BackColor = System.Drawing.Color.Firebrick;
            this.btUseService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUseService.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUseService.ForeColor = System.Drawing.Color.White;
            this.btUseService.Location = new System.Drawing.Point(728, 532);
            this.btUseService.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btUseService.MaximumSize = new System.Drawing.Size(151, 74);
            this.btUseService.MinimumSize = new System.Drawing.Size(151, 49);
            this.btUseService.Name = "btUseService";
            this.btUseService.Size = new System.Drawing.Size(151, 49);
            this.btUseService.TabIndex = 162;
            this.btUseService.Text = "Add ";
            this.btUseService.UseVisualStyleBackColor = false;
            this.btUseService.Click += new System.EventHandler(this.BtUseService_Click_1);
            // 
            // btCheckInRoom
            // 
            this.btCheckInRoom.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btCheckInRoom.BackColor = System.Drawing.Color.Firebrick;
            this.btCheckInRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCheckInRoom.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCheckInRoom.ForeColor = System.Drawing.Color.White;
            this.btCheckInRoom.Location = new System.Drawing.Point(728, 286);
            this.btCheckInRoom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btCheckInRoom.MaximumSize = new System.Drawing.Size(151, 74);
            this.btCheckInRoom.MinimumSize = new System.Drawing.Size(151, 49);
            this.btCheckInRoom.Name = "btCheckInRoom";
            this.btCheckInRoom.Size = new System.Drawing.Size(151, 74);
            this.btCheckInRoom.TabIndex = 163;
            this.btCheckInRoom.Text = "Check In";
            this.btCheckInRoom.UseVisualStyleBackColor = false;
            this.btCheckInRoom.Click += new System.EventHandler(this.BtCheckInRoom_Click);
            // 
            // btCheckOut
            // 
            this.btCheckOut.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btCheckOut.BackColor = System.Drawing.Color.Firebrick;
            this.btCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCheckOut.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCheckOut.ForeColor = System.Drawing.Color.White;
            this.btCheckOut.Location = new System.Drawing.Point(897, 286);
            this.btCheckOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btCheckOut.MaximumSize = new System.Drawing.Size(151, 74);
            this.btCheckOut.MinimumSize = new System.Drawing.Size(151, 49);
            this.btCheckOut.Name = "btCheckOut";
            this.btCheckOut.Size = new System.Drawing.Size(151, 74);
            this.btCheckOut.TabIndex = 164;
            this.btCheckOut.Text = "Check Out";
            this.btCheckOut.UseVisualStyleBackColor = false;
            this.btCheckOut.Click += new System.EventHandler(this.BtCheckOut_Click_1);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(9, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 38);
            this.label4.TabIndex = 166;
            this.label4.Text = "Room List";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(720, 464);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 38);
            this.label5.TabIndex = 169;
            this.label5.Text = "Add Service";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label18.Location = new System.Drawing.Point(752, 116);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(72, 26);
            this.label18.TabIndex = 170;
            this.label18.Text = "Kind:";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(751, 219);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 26);
            this.label15.TabIndex = 171;
            this.label15.Text = "Cost:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(751, 150);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 26);
            this.label1.TabIndex = 172;
            this.label1.Text = "Status:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(751, 185);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 26);
            this.label2.TabIndex = 173;
            this.label2.Text = "Beds Amount:";
            // 
            // lbKind
            // 
            this.lbKind.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbKind.AutoSize = true;
            this.lbKind.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.lbKind.Location = new System.Drawing.Point(937, 116);
            this.lbKind.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbKind.Name = "lbKind";
            this.lbKind.Size = new System.Drawing.Size(64, 26);
            this.lbKind.TabIndex = 174;
            this.lbKind.Text = "Kind";
            // 
            // lbStatus
            // 
            this.lbStatus.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.lbStatus.Location = new System.Drawing.Point(936, 150);
            this.lbStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(75, 26);
            this.lbStatus.TabIndex = 175;
            this.lbStatus.Text = "Status";
            // 
            // lbCost
            // 
            this.lbCost.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbCost.AutoSize = true;
            this.lbCost.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.lbCost.Location = new System.Drawing.Point(936, 219);
            this.lbCost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbCost.Name = "lbCost";
            this.lbCost.Size = new System.Drawing.Size(58, 26);
            this.lbCost.TabIndex = 177;
            this.lbCost.Text = "Cost";
            // 
            // lbBedsAmount
            // 
            this.lbBedsAmount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbBedsAmount.AutoSize = true;
            this.lbBedsAmount.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.lbBedsAmount.Location = new System.Drawing.Point(937, 185);
            this.lbBedsAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbBedsAmount.Name = "lbBedsAmount";
            this.lbBedsAmount.Size = new System.Drawing.Size(61, 26);
            this.lbBedsAmount.TabIndex = 176;
            this.lbBedsAmount.Text = "Beds";
            // 
            // dtgvRoom
            // 
            this.dtgvRoom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvRoom.Location = new System.Drawing.Point(17, 81);
            this.dtgvRoom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgvRoom.Name = "dtgvRoom";
            this.dtgvRoom.RowHeadersWidth = 51;
            this.dtgvRoom.Size = new System.Drawing.Size(667, 672);
            this.dtgvRoom.TabIndex = 178;
            this.dtgvRoom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvRoom_CellClick);
            // 
            // label
            // 
            this.label.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label.Location = new System.Drawing.Point(751, 81);
            this.label.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(79, 26);
            this.label.TabIndex = 179;
            this.label.Text = "Name:";
            // 
            // lbName
            // 
            this.lbName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.lbName.Location = new System.Drawing.Point(936, 81);
            this.lbName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(71, 26);
            this.lbName.TabIndex = 180;
            this.lbName.Text = "Name";
            // 
            // HomeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.dtgvRoom);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbKind);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.lbCost);
            this.Controls.Add(this.lbBedsAmount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btCheckOut);
            this.Controls.Add(this.btCheckInRoom);
            this.Controls.Add(this.btUseService);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumSize = new System.Drawing.Size(1095, 802);
            this.Name = "HomeWindow";
            this.Size = new System.Drawing.Size(1095, 802);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btUseService;
        private System.Windows.Forms.Button btCheckInRoom;
        private System.Windows.Forms.Button btCheckOut;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbKind;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label lbCost;
        private System.Windows.Forms.Label lbBedsAmount;
        private System.Windows.Forms.DataGridView dtgvRoom;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label lbName;
    }
}
