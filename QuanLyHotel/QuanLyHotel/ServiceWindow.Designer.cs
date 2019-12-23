namespace QuanLyHotel
{
    partial class ServiceWindow
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label16 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dtgvService = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvUseService = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNameService = new System.Windows.Forms.TextBox();
            this.txtKindService = new System.Windows.Forms.ComboBox();
            this.txtCostService = new System.Windows.Forms.TextBox();
            this.btAddService = new System.Windows.Forms.Button();
            this.btEditService = new System.Windows.Forms.Button();
            this.btDeleteService = new System.Windows.Forms.Button();
            this.btLoadService = new System.Windows.Forms.Button();
            this.txtSearchService1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSearchRoomService = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUseService)).BeginInit();
            this.SuspendLayout();
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
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(10, 8);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(248, 31);
            this.label16.TabIndex = 71;
            this.label16.Text = "Service Information";
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label19.Location = new System.Drawing.Point(12, 69);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(58, 22);
            this.label19.TabIndex = 78;
            this.label19.Text = "Name";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label18.Location = new System.Drawing.Point(210, 104);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(48, 22);
            this.label18.TabIndex = 76;
            this.label18.Text = "Cost";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(12, 104);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 22);
            this.label13.TabIndex = 73;
            this.label13.Text = "Kind";
            // 
            // dtgvService
            // 
            this.dtgvService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtgvService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvService.Location = new System.Drawing.Point(10, 285);
            this.dtgvService.Name = "dtgvService";
            this.dtgvService.RowHeadersWidth = 51;
            this.dtgvService.Size = new System.Drawing.Size(566, 339);
            this.dtgvService.TabIndex = 70;
            this.dtgvService.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvService_CellClick);
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(10, 254);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 22);
            this.label15.TabIndex = 74;
            this.label15.Text = "Search";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(605, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 31);
            this.label1.TabIndex = 87;
            this.label1.Text = "Use Service Information";
            // 
            // dtgvUseService
            // 
            this.dtgvUseService.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvUseService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvUseService.Location = new System.Drawing.Point(611, 145);
            this.dtgvUseService.Name = "dtgvUseService";
            this.dtgvUseService.RowHeadersWidth = 51;
            this.dtgvUseService.Size = new System.Drawing.Size(374, 479);
            this.dtgvUseService.TabIndex = 88;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(616, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 22);
            this.label2.TabIndex = 171;
            this.label2.Text = "Search";
            // 
            // txtNameService
            // 
            this.txtNameService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNameService.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.txtNameService.Location = new System.Drawing.Point(76, 66);
            this.txtNameService.MaximumSize = new System.Drawing.Size(450, 29);
            this.txtNameService.MaxLength = 40;
            this.txtNameService.Name = "txtNameService";
            this.txtNameService.Size = new System.Drawing.Size(450, 29);
            this.txtNameService.TabIndex = 180;
            // 
            // txtKindService
            // 
            this.txtKindService.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtKindService.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtKindService.FormattingEnabled = true;
            this.txtKindService.Location = new System.Drawing.Point(76, 100);
            this.txtKindService.MaxLength = 40;
            this.txtKindService.Name = "txtKindService";
            this.txtKindService.Size = new System.Drawing.Size(117, 30);
            this.txtKindService.TabIndex = 181;
            // 
            // txtCostService
            // 
            this.txtCostService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCostService.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.txtCostService.Location = new System.Drawing.Point(271, 101);
            this.txtCostService.MaximumSize = new System.Drawing.Size(255, 29);
            this.txtCostService.MaxLength = 40;
            this.txtCostService.Name = "txtCostService";
            this.txtCostService.Size = new System.Drawing.Size(255, 29);
            this.txtCostService.TabIndex = 182;
            this.txtCostService.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCostService_KeyPress);
            // 
            // btAddService
            // 
            this.btAddService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btAddService.BackColor = System.Drawing.Color.Firebrick;
            this.btAddService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddService.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddService.ForeColor = System.Drawing.Color.White;
            this.btAddService.Location = new System.Drawing.Point(14, 145);
            this.btAddService.Name = "btAddService";
            this.btAddService.Size = new System.Drawing.Size(74, 31);
            this.btAddService.TabIndex = 185;
            this.btAddService.Text = "Add";
            this.btAddService.UseVisualStyleBackColor = false;
            this.btAddService.Click += new System.EventHandler(this.btAddService_Click_1);
            // 
            // btEditService
            // 
            this.btEditService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btEditService.BackColor = System.Drawing.Color.Firebrick;
            this.btEditService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEditService.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditService.ForeColor = System.Drawing.Color.White;
            this.btEditService.Location = new System.Drawing.Point(93, 145);
            this.btEditService.Name = "btEditService";
            this.btEditService.Size = new System.Drawing.Size(74, 31);
            this.btEditService.TabIndex = 187;
            this.btEditService.Text = "Edit";
            this.btEditService.UseVisualStyleBackColor = false;
            this.btEditService.Click += new System.EventHandler(this.btEditService_Click_1);
            // 
            // btDeleteService
            // 
            this.btDeleteService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btDeleteService.BackColor = System.Drawing.Color.Firebrick;
            this.btDeleteService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDeleteService.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeleteService.ForeColor = System.Drawing.Color.White;
            this.btDeleteService.Location = new System.Drawing.Point(173, 145);
            this.btDeleteService.Name = "btDeleteService";
            this.btDeleteService.Size = new System.Drawing.Size(74, 31);
            this.btDeleteService.TabIndex = 188;
            this.btDeleteService.Text = "Delete";
            this.btDeleteService.UseVisualStyleBackColor = false;
            this.btDeleteService.Click += new System.EventHandler(this.btDeleteService_Click_1);
            // 
            // btLoadService
            // 
            this.btLoadService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btLoadService.BackColor = System.Drawing.Color.Firebrick;
            this.btLoadService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLoadService.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLoadService.ForeColor = System.Drawing.Color.White;
            this.btLoadService.Location = new System.Drawing.Point(253, 145);
            this.btLoadService.Name = "btLoadService";
            this.btLoadService.Size = new System.Drawing.Size(74, 31);
            this.btLoadService.TabIndex = 189;
            this.btLoadService.Text = "Load";
            this.btLoadService.UseVisualStyleBackColor = false;
            this.btLoadService.Click += new System.EventHandler(this.btLoadService_Click_1);
            // 
            // txtSearchService1
            // 
            this.txtSearchService1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSearchService1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchService1.Location = new System.Drawing.Point(83, 250);
            this.txtSearchService1.MaxLength = 40;
            this.txtSearchService1.Name = "txtSearchService1";
            this.txtSearchService1.Size = new System.Drawing.Size(493, 29);
            this.txtSearchService1.TabIndex = 190;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.BackColor = System.Drawing.Color.Firebrick;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(619, 60);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 31);
            this.button2.TabIndex = 196;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(699, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 31);
            this.button1.TabIndex = 197;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSearchRoomService
            // 
            this.txtSearchRoomService.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchRoomService.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchRoomService.Location = new System.Drawing.Point(689, 102);
            this.txtSearchRoomService.MaxLength = 40;
            this.txtSearchRoomService.Name = "txtSearchRoomService";
            this.txtSearchRoomService.Size = new System.Drawing.Size(297, 29);
            this.txtSearchRoomService.TabIndex = 198;
            // 
            // ServiceWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtSearchRoomService);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtSearchService1);
            this.Controls.Add(this.btLoadService);
            this.Controls.Add(this.btDeleteService);
            this.Controls.Add(this.btEditService);
            this.Controls.Add(this.btAddService);
            this.Controls.Add(this.txtCostService);
            this.Controls.Add(this.txtKindService);
            this.Controls.Add(this.txtNameService);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgvUseService);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dtgvService);
            this.Controls.Add(this.label15);
            this.Name = "ServiceWindow";
            this.Size = new System.Drawing.Size(1151, 645);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUseService)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dtgvService;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dtgvUseService;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearchRoomService;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtSearchService1;
        private System.Windows.Forms.Button btLoadService;
        private System.Windows.Forms.Button btDeleteService;
        private System.Windows.Forms.Button btEditService;
        private System.Windows.Forms.Button btAddService;
        private System.Windows.Forms.TextBox txtCostService;
        private System.Windows.Forms.ComboBox txtKindService;
        private System.Windows.Forms.TextBox txtNameService;
    }
}
