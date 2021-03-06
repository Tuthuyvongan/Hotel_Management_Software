namespace QuanLyHotel
{
    partial class RoomWindow
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
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtgvRoom = new System.Windows.Forms.DataGridView();
            this.txtNameRoom = new System.Windows.Forms.TextBox();
            this.txtKindRoom = new System.Windows.Forms.ComboBox();
            this.txtBedsAmount = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.btAddRoom = new System.Windows.Forms.Button();
            this.btEditRoom = new System.Windows.Forms.Button();
            this.btDeleteRoom = new System.Windows.Forms.Button();
            this.txtSearchRoom = new System.Windows.Forms.TextBox();
            this.btLoadRoom = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider6 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btLoadRoom1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 354);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 26);
            this.label5.TabIndex = 136;
            this.label5.Text = "Search";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(15, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(291, 38);
            this.label3.TabIndex = 135;
            this.label3.Text = "Room Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(17, 177);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 26);
            this.label2.TabIndex = 152;
            this.label2.Text = "Beds Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(17, 89);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 26);
            this.label4.TabIndex = 147;
            this.label4.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(17, 132);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 26);
            this.label6.TabIndex = 145;
            this.label6.Text = "Kind";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(17, 220);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 26);
            this.label7.TabIndex = 146;
            this.label7.Text = "Cost";
            // 
            // dtgvRoom
            // 
            this.dtgvRoom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvRoom.Location = new System.Drawing.Point(23, 393);
            this.dtgvRoom.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvRoom.Name = "dtgvRoom";
            this.dtgvRoom.ReadOnly = true;
            this.dtgvRoom.RowHeadersWidth = 51;
            this.dtgvRoom.Size = new System.Drawing.Size(1262, 337);
            this.dtgvRoom.TabIndex = 154;
            this.dtgvRoom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvRoom_CellClick);
            // 
            // txtNameRoom
            // 
            this.txtNameRoom.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameRoom.Location = new System.Drawing.Point(179, 82);
            this.txtNameRoom.Margin = new System.Windows.Forms.Padding(4);
            this.txtNameRoom.MaximumSize = new System.Drawing.Size(599, 29);
            this.txtNameRoom.MaxLength = 40;
            this.txtNameRoom.Name = "txtNameRoom";
            this.txtNameRoom.Size = new System.Drawing.Size(599, 29);
            this.txtNameRoom.TabIndex = 186;
            // 
            // txtKindRoom
            // 
            this.txtKindRoom.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtKindRoom.FormattingEnabled = true;
            this.txtKindRoom.Items.AddRange(new object[] {
            "Vip",
            "Thường"});
            this.txtKindRoom.Location = new System.Drawing.Point(179, 126);
            this.txtKindRoom.Margin = new System.Windows.Forms.Padding(4);
            this.txtKindRoom.MaximumSize = new System.Drawing.Size(599, 0);
            this.txtKindRoom.MaxLength = 40;
            this.txtKindRoom.Name = "txtKindRoom";
            this.txtKindRoom.Size = new System.Drawing.Size(599, 34);
            this.txtKindRoom.TabIndex = 187;
            // 
            // txtBedsAmount
            // 
            this.txtBedsAmount.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBedsAmount.Location = new System.Drawing.Point(179, 174);
            this.txtBedsAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtBedsAmount.MaximumSize = new System.Drawing.Size(599, 29);
            this.txtBedsAmount.MaxLength = 40;
            this.txtBedsAmount.Name = "txtBedsAmount";
            this.txtBedsAmount.Size = new System.Drawing.Size(599, 29);
            this.txtBedsAmount.TabIndex = 188;
            this.txtBedsAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBedsAmount_KeyPress);
            // 
            // txtCost
            // 
            this.txtCost.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCost.Location = new System.Drawing.Point(179, 217);
            this.txtCost.Margin = new System.Windows.Forms.Padding(4);
            this.txtCost.MaximumSize = new System.Drawing.Size(599, 29);
            this.txtCost.MaxLength = 40;
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(599, 29);
            this.txtCost.TabIndex = 189;
            this.txtCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCost_KeyPress);
            // 
            // btAddRoom
            // 
            this.btAddRoom.BackColor = System.Drawing.Color.Firebrick;
            this.btAddRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddRoom.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddRoom.ForeColor = System.Drawing.Color.White;
            this.btAddRoom.Location = new System.Drawing.Point(96, 269);
            this.btAddRoom.Margin = new System.Windows.Forms.Padding(4);
            this.btAddRoom.Name = "btAddRoom";
            this.btAddRoom.Size = new System.Drawing.Size(99, 38);
            this.btAddRoom.TabIndex = 190;
            this.btAddRoom.Text = "Add";
            this.btAddRoom.UseVisualStyleBackColor = false;
            this.btAddRoom.Click += new System.EventHandler(this.btAddRoom_Click_1);
            // 
            // btEditRoom
            // 
            this.btEditRoom.BackColor = System.Drawing.Color.Firebrick;
            this.btEditRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEditRoom.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditRoom.ForeColor = System.Drawing.Color.White;
            this.btEditRoom.Location = new System.Drawing.Point(216, 269);
            this.btEditRoom.Margin = new System.Windows.Forms.Padding(4);
            this.btEditRoom.Name = "btEditRoom";
            this.btEditRoom.Size = new System.Drawing.Size(99, 38);
            this.btEditRoom.TabIndex = 191;
            this.btEditRoom.Text = "Edit";
            this.btEditRoom.UseVisualStyleBackColor = false;
            this.btEditRoom.Click += new System.EventHandler(this.btEditRoom_Click_1);
            // 
            // btDeleteRoom
            // 
            this.btDeleteRoom.BackColor = System.Drawing.Color.Firebrick;
            this.btDeleteRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDeleteRoom.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeleteRoom.ForeColor = System.Drawing.Color.White;
            this.btDeleteRoom.Location = new System.Drawing.Point(338, 269);
            this.btDeleteRoom.Margin = new System.Windows.Forms.Padding(4);
            this.btDeleteRoom.Name = "btDeleteRoom";
            this.btDeleteRoom.Size = new System.Drawing.Size(99, 38);
            this.btDeleteRoom.TabIndex = 192;
            this.btDeleteRoom.Text = "Delete";
            this.btDeleteRoom.UseVisualStyleBackColor = false;
            this.btDeleteRoom.Click += new System.EventHandler(this.btDeleteRoom_Click_1);
            // 
            // txtSearchRoom
            // 
            this.txtSearchRoom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchRoom.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchRoom.Location = new System.Drawing.Point(115, 349);
            this.txtSearchRoom.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchRoom.MaxLength = 40;
            this.txtSearchRoom.Name = "txtSearchRoom";
            this.txtSearchRoom.Size = new System.Drawing.Size(585, 35);
            this.txtSearchRoom.TabIndex = 193;
            // 
            // btLoadRoom
            // 
            this.btLoadRoom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btLoadRoom.BackColor = System.Drawing.Color.Firebrick;
            this.btLoadRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLoadRoom.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLoadRoom.ForeColor = System.Drawing.Color.White;
            this.btLoadRoom.Location = new System.Drawing.Point(1080, 348);
            this.btLoadRoom.Margin = new System.Windows.Forms.Padding(4);
            this.btLoadRoom.Name = "btLoadRoom";
            this.btLoadRoom.Size = new System.Drawing.Size(0, 38);
            this.btLoadRoom.TabIndex = 194;
            this.btLoadRoom.Text = "Load";
            this.btLoadRoom.UseVisualStyleBackColor = false;
            this.btLoadRoom.Click += new System.EventHandler(this.btLoadRoom_Click);
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
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // errorProvider5
            // 
            this.errorProvider5.ContainerControl = this;
            // 
            // errorProvider6
            // 
            this.errorProvider6.ContainerControl = this;
            // 
            // btLoadRoom1
            // 
            this.btLoadRoom1.BackColor = System.Drawing.Color.Firebrick;
            this.btLoadRoom1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLoadRoom1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLoadRoom1.ForeColor = System.Drawing.Color.White;
            this.btLoadRoom1.Location = new System.Drawing.Point(717, 348);
            this.btLoadRoom1.Margin = new System.Windows.Forms.Padding(4);
            this.btLoadRoom1.Name = "btLoadRoom1";
            this.btLoadRoom1.Size = new System.Drawing.Size(99, 38);
            this.btLoadRoom1.TabIndex = 195;
            this.btLoadRoom1.Text = "Load";
            this.btLoadRoom1.UseVisualStyleBackColor = false;
            this.btLoadRoom1.Click += new System.EventHandler(this.btLoadRoom1_Click);
            // 
            // RoomWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btLoadRoom1);
            this.Controls.Add(this.btLoadRoom);
            this.Controls.Add(this.txtSearchRoom);
            this.Controls.Add(this.btDeleteRoom);
            this.Controls.Add(this.btEditRoom);
            this.Controls.Add(this.btAddRoom);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.txtBedsAmount);
            this.Controls.Add(this.txtKindRoom);
            this.Controls.Add(this.txtNameRoom);
            this.Controls.Add(this.dtgvRoom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RoomWindow";
            this.Size = new System.Drawing.Size(1325, 745);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dtgvRoom;
        private System.Windows.Forms.TextBox txtNameRoom;
        private System.Windows.Forms.ComboBox txtKindRoom;
        private System.Windows.Forms.TextBox txtBedsAmount;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Button btAddRoom;
        private System.Windows.Forms.Button btEditRoom;
        private System.Windows.Forms.Button btDeleteRoom;
        private System.Windows.Forms.TextBox txtSearchRoom;
        private System.Windows.Forms.Button btLoadRoom;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.ErrorProvider errorProvider6;
        private System.Windows.Forms.Button btLoadRoom1;
    }
}
