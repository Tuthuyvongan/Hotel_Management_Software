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
            this.label3.Location = new System.Drawing.Point(561, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 31);
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
            this.btUseService.Location = new System.Drawing.Point(546, 432);
            this.btUseService.MaximumSize = new System.Drawing.Size(113, 60);
            this.btUseService.MinimumSize = new System.Drawing.Size(113, 40);
            this.btUseService.Name = "btUseService";
            this.btUseService.Size = new System.Drawing.Size(113, 40);
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
            this.btCheckInRoom.Location = new System.Drawing.Point(546, 232);
            this.btCheckInRoom.MaximumSize = new System.Drawing.Size(113, 60);
            this.btCheckInRoom.MinimumSize = new System.Drawing.Size(113, 40);
            this.btCheckInRoom.Name = "btCheckInRoom";
            this.btCheckInRoom.Size = new System.Drawing.Size(113, 60);
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
            this.btCheckOut.Location = new System.Drawing.Point(673, 232);
            this.btCheckOut.MaximumSize = new System.Drawing.Size(113, 60);
            this.btCheckOut.MinimumSize = new System.Drawing.Size(113, 40);
            this.btCheckOut.Name = "btCheckOut";
            this.btCheckOut.Size = new System.Drawing.Size(113, 60);
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
            this.label4.Location = new System.Drawing.Point(7, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 31);
            this.label4.TabIndex = 166;
            this.label4.Text = "Room List";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(540, 377);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 31);
            this.label5.TabIndex = 169;
            this.label5.Text = "Add Service";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label18.Location = new System.Drawing.Point(564, 94);
            this.label18.Margin = new System.Windows.Forms.Padding(3);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(54, 22);
            this.label18.TabIndex = 170;
            this.label18.Text = "Kind:";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(563, 178);
            this.label15.Margin = new System.Windows.Forms.Padding(3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 22);
            this.label15.TabIndex = 171;
            this.label15.Text = "Cost:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(563, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 22);
            this.label1.TabIndex = 172;
            this.label1.Text = "Status:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(563, 150);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 22);
            this.label2.TabIndex = 173;
            this.label2.Text = "Beds Amount:";
            // 
            // lbKind
            // 
            this.lbKind.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbKind.AutoSize = true;
            this.lbKind.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.lbKind.Location = new System.Drawing.Point(703, 94);
            this.lbKind.Margin = new System.Windows.Forms.Padding(3);
            this.lbKind.Name = "lbKind";
            this.lbKind.Size = new System.Drawing.Size(49, 22);
            this.lbKind.TabIndex = 174;
            this.lbKind.Text = "Kind";
            // 
            // lbStatus
            // 
            this.lbStatus.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.lbStatus.Location = new System.Drawing.Point(702, 122);
            this.lbStatus.Margin = new System.Windows.Forms.Padding(3);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(61, 22);
            this.lbStatus.TabIndex = 175;
            this.lbStatus.Text = "Status";
            // 
            // lbCost
            // 
            this.lbCost.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbCost.AutoSize = true;
            this.lbCost.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.lbCost.Location = new System.Drawing.Point(702, 178);
            this.lbCost.Margin = new System.Windows.Forms.Padding(3);
            this.lbCost.Name = "lbCost";
            this.lbCost.Size = new System.Drawing.Size(48, 22);
            this.lbCost.TabIndex = 177;
            this.lbCost.Text = "Cost";
            // 
            // lbBedsAmount
            // 
            this.lbBedsAmount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbBedsAmount.AutoSize = true;
            this.lbBedsAmount.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.lbBedsAmount.Location = new System.Drawing.Point(703, 150);
            this.lbBedsAmount.Margin = new System.Windows.Forms.Padding(3);
            this.lbBedsAmount.Name = "lbBedsAmount";
            this.lbBedsAmount.Size = new System.Drawing.Size(50, 22);
            this.lbBedsAmount.TabIndex = 176;
            this.lbBedsAmount.Text = "Beds";
            // 
            // dtgvRoom
            // 
            this.dtgvRoom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvRoom.Location = new System.Drawing.Point(13, 66);
            this.dtgvRoom.Name = "dtgvRoom";
            this.dtgvRoom.Size = new System.Drawing.Size(500, 546);
            this.dtgvRoom.TabIndex = 178;
            // 
            // label
            // 
            this.label.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label.Location = new System.Drawing.Point(563, 66);
            this.label.Margin = new System.Windows.Forms.Padding(3);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(63, 22);
            this.label.TabIndex = 179;
            this.label.Text = "Name:";
            // 
            // lbName
            // 
            this.lbName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.lbName.Location = new System.Drawing.Point(702, 66);
            this.lbName.Margin = new System.Windows.Forms.Padding(3);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(58, 22);
            this.lbName.TabIndex = 180;
            this.lbName.Text = "Name";
            // 
            // HomeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
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
            this.MinimumSize = new System.Drawing.Size(821, 652);
            this.Name = "HomeWindow";
            this.Size = new System.Drawing.Size(821, 652);
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
