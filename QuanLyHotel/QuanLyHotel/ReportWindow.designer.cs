namespace QuanLyHotel
{
    partial class ReportWindow
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
            this.txtSearchService1 = new System.Windows.Forms.TextBox();
            this.btLoadService = new System.Windows.Forms.Button();
            this.btDeleteService = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.dtgvService = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvService)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearchService1
            // 
            this.txtSearchService1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSearchService1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchService1.Location = new System.Drawing.Point(123, 116);
            this.txtSearchService1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearchService1.MaxLength = 40;
            this.txtSearchService1.Name = "txtSearchService1";
            this.txtSearchService1.Size = new System.Drawing.Size(656, 35);
            this.txtSearchService1.TabIndex = 226;
            // 
            // btLoadService
            // 
            this.btLoadService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btLoadService.BackColor = System.Drawing.Color.Firebrick;
            this.btLoadService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLoadService.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLoadService.ForeColor = System.Drawing.Color.White;
            this.btLoadService.Location = new System.Drawing.Point(137, 71);
            this.btLoadService.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btLoadService.Name = "btLoadService";
            this.btLoadService.Size = new System.Drawing.Size(99, 38);
            this.btLoadService.TabIndex = 225;
            this.btLoadService.Text = "Load";
            this.btLoadService.UseVisualStyleBackColor = false;
            // 
            // btDeleteService
            // 
            this.btDeleteService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btDeleteService.BackColor = System.Drawing.Color.Firebrick;
            this.btDeleteService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDeleteService.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeleteService.ForeColor = System.Drawing.Color.White;
            this.btDeleteService.Location = new System.Drawing.Point(31, 71);
            this.btDeleteService.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btDeleteService.Name = "btDeleteService";
            this.btDeleteService.Size = new System.Drawing.Size(99, 38);
            this.btDeleteService.TabIndex = 224;
            this.btDeleteService.Text = "Delete";
            this.btDeleteService.UseVisualStyleBackColor = false;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(24, 12);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(305, 38);
            this.label16.TabIndex = 214;
            this.label16.Text = "Report Information";
            // 
            // dtgvService
            // 
            this.dtgvService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtgvService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvService.Location = new System.Drawing.Point(31, 159);
            this.dtgvService.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgvService.Name = "dtgvService";
            this.dtgvService.ReadOnly = true;
            this.dtgvService.RowHeadersWidth = 51;
            this.dtgvService.Size = new System.Drawing.Size(755, 331);
            this.dtgvService.TabIndex = 213;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(25, 121);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 26);
            this.label15.TabIndex = 216;
            this.label15.Text = "Search";
            // 
            // ReportWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtSearchService1);
            this.Controls.Add(this.btLoadService);
            this.Controls.Add(this.btDeleteService);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.dtgvService);
            this.Controls.Add(this.label15);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ReportWindow";
            this.Size = new System.Drawing.Size(1283, 682);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvService)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSearchService1;
        private System.Windows.Forms.Button btLoadService;
        private System.Windows.Forms.Button btDeleteService;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dtgvService;
        private System.Windows.Forms.Label label15;
    }
}
