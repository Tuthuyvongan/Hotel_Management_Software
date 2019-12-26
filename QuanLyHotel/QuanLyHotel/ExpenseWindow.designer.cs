namespace QuanLyHotel
{
    partial class ExpenseWindow
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
            this.txtSearchExpense = new System.Windows.Forms.TextBox();
            this.btLoadExpense = new System.Windows.Forms.Button();
            this.btDeleteExpense = new System.Windows.Forms.Button();
            this.btEditExpense = new System.Windows.Forms.Button();
            this.btAddExpense = new System.Windows.Forms.Button();
            this.txtKindExpense = new System.Windows.Forms.ComboBox();
            this.txtNameExpense = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dtgvExpense = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.dtDateExpense = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtCostExpense = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvExpense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearchExpense
            // 
            this.txtSearchExpense.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchExpense.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchExpense.Location = new System.Drawing.Point(120, 284);
            this.txtSearchExpense.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchExpense.MaxLength = 40;
            this.txtSearchExpense.Name = "txtSearchExpense";
            this.txtSearchExpense.Size = new System.Drawing.Size(520, 35);
            this.txtSearchExpense.TabIndex = 204;
            // 
            // btLoadExpense
            // 
            this.btLoadExpense.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btLoadExpense.BackColor = System.Drawing.Color.Firebrick;
            this.btLoadExpense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLoadExpense.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLoadExpense.ForeColor = System.Drawing.Color.White;
            this.btLoadExpense.Location = new System.Drawing.Point(649, 283);
            this.btLoadExpense.Margin = new System.Windows.Forms.Padding(4);
            this.btLoadExpense.Name = "btLoadExpense";
            this.btLoadExpense.Size = new System.Drawing.Size(99, 38);
            this.btLoadExpense.TabIndex = 203;
            this.btLoadExpense.Text = "Load";
            this.btLoadExpense.UseVisualStyleBackColor = false;
            this.btLoadExpense.Click += new System.EventHandler(this.BtLoadExpense_Click);
            // 
            // btDeleteExpense
            // 
            this.btDeleteExpense.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btDeleteExpense.BackColor = System.Drawing.Color.Firebrick;
            this.btDeleteExpense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDeleteExpense.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeleteExpense.ForeColor = System.Drawing.Color.White;
            this.btDeleteExpense.Location = new System.Drawing.Point(236, 239);
            this.btDeleteExpense.Margin = new System.Windows.Forms.Padding(4);
            this.btDeleteExpense.Name = "btDeleteExpense";
            this.btDeleteExpense.Size = new System.Drawing.Size(99, 38);
            this.btDeleteExpense.TabIndex = 202;
            this.btDeleteExpense.Text = "Delete";
            this.btDeleteExpense.UseVisualStyleBackColor = false;
            this.btDeleteExpense.Click += new System.EventHandler(this.BtDeleteExpense_Click);
            // 
            // btEditExpense
            // 
            this.btEditExpense.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btEditExpense.BackColor = System.Drawing.Color.Firebrick;
            this.btEditExpense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEditExpense.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditExpense.ForeColor = System.Drawing.Color.White;
            this.btEditExpense.Location = new System.Drawing.Point(129, 239);
            this.btEditExpense.Margin = new System.Windows.Forms.Padding(4);
            this.btEditExpense.Name = "btEditExpense";
            this.btEditExpense.Size = new System.Drawing.Size(99, 38);
            this.btEditExpense.TabIndex = 201;
            this.btEditExpense.Text = "Edit";
            this.btEditExpense.UseVisualStyleBackColor = false;
            this.btEditExpense.Click += new System.EventHandler(this.BtEditExpense_Click);
            // 
            // btAddExpense
            // 
            this.btAddExpense.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btAddExpense.BackColor = System.Drawing.Color.Firebrick;
            this.btAddExpense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddExpense.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddExpense.ForeColor = System.Drawing.Color.White;
            this.btAddExpense.Location = new System.Drawing.Point(24, 239);
            this.btAddExpense.Margin = new System.Windows.Forms.Padding(4);
            this.btAddExpense.Name = "btAddExpense";
            this.btAddExpense.Size = new System.Drawing.Size(99, 38);
            this.btAddExpense.TabIndex = 200;
            this.btAddExpense.Text = "Add";
            this.btAddExpense.UseVisualStyleBackColor = false;
            this.btAddExpense.Click += new System.EventHandler(this.BtAddExpense_Click);
            // 
            // txtKindExpense
            // 
            this.txtKindExpense.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtKindExpense.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtKindExpense.FormattingEnabled = true;
            this.txtKindExpense.Location = new System.Drawing.Point(148, 126);
            this.txtKindExpense.Margin = new System.Windows.Forms.Padding(4);
            this.txtKindExpense.MaxLength = 40;
            this.txtKindExpense.Name = "txtKindExpense";
            this.txtKindExpense.Size = new System.Drawing.Size(219, 34);
            this.txtKindExpense.TabIndex = 198;
            // 
            // txtNameExpense
            // 
            this.txtNameExpense.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNameExpense.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.txtNameExpense.Location = new System.Drawing.Point(148, 84);
            this.txtNameExpense.Margin = new System.Windows.Forms.Padding(4);
            this.txtNameExpense.MaximumSize = new System.Drawing.Size(599, 29);
            this.txtNameExpense.MaxLength = 40;
            this.txtNameExpense.Name = "txtNameExpense";
            this.txtNameExpense.Size = new System.Drawing.Size(599, 34);
            this.txtNameExpense.TabIndex = 197;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(20, 12);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(323, 38);
            this.label16.TabIndex = 192;
            this.label16.Text = "Expense Information";
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label19.Location = new System.Drawing.Point(23, 87);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(71, 26);
            this.label19.TabIndex = 196;
            this.label19.Text = "Name";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label18.Location = new System.Drawing.Point(376, 129);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(60, 26);
            this.label18.TabIndex = 195;
            this.label18.Text = "Date";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(23, 130);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 26);
            this.label13.TabIndex = 193;
            this.label13.Text = "Kind";
            // 
            // dtgvExpense
            // 
            this.dtgvExpense.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvExpense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvExpense.Location = new System.Drawing.Point(28, 327);
            this.dtgvExpense.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvExpense.Name = "dtgvExpense";
            this.dtgvExpense.ReadOnly = true;
            this.dtgvExpense.RowHeadersWidth = 51;
            this.dtgvExpense.Size = new System.Drawing.Size(720, 331);
            this.dtgvExpense.TabIndex = 191;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(23, 289);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 26);
            this.label15.TabIndex = 194;
            this.label15.Text = "Search";
            // 
            // dtDateExpense
            // 
            this.dtDateExpense.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtDateExpense.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.dtDateExpense.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDateExpense.Location = new System.Drawing.Point(463, 127);
            this.dtDateExpense.Margin = new System.Windows.Forms.Padding(4);
            this.dtDateExpense.Name = "dtDateExpense";
            this.dtDateExpense.Size = new System.Drawing.Size(284, 35);
            this.dtDateExpense.TabIndex = 212;
            this.dtDateExpense.Value = new System.DateTime(2019, 10, 24, 0, 0, 0, 0);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(23, 176);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 26);
            this.label12.TabIndex = 211;
            this.label12.Text = "Cost";
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
            // txtCostExpense
            // 
            this.txtCostExpense.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCostExpense.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.txtCostExpense.Location = new System.Drawing.Point(149, 174);
            this.txtCostExpense.Margin = new System.Windows.Forms.Padding(4);
            this.txtCostExpense.MaximumSize = new System.Drawing.Size(599, 29);
            this.txtCostExpense.MaxLength = 40;
            this.txtCostExpense.Name = "txtCostExpense";
            this.txtCostExpense.Size = new System.Drawing.Size(599, 29);
            this.txtCostExpense.TabIndex = 213;
            // 
            // ExpenseWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtCostExpense);
            this.Controls.Add(this.dtDateExpense);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtSearchExpense);
            this.Controls.Add(this.btLoadExpense);
            this.Controls.Add(this.btDeleteExpense);
            this.Controls.Add(this.btEditExpense);
            this.Controls.Add(this.btAddExpense);
            this.Controls.Add(this.txtKindExpense);
            this.Controls.Add(this.txtNameExpense);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dtgvExpense);
            this.Controls.Add(this.label15);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ExpenseWindow";
            this.Size = new System.Drawing.Size(1283, 682);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvExpense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearchExpense;
        private System.Windows.Forms.Button btLoadExpense;
        private System.Windows.Forms.Button btDeleteExpense;
        private System.Windows.Forms.Button btEditExpense;
        private System.Windows.Forms.Button btAddExpense;
        private System.Windows.Forms.ComboBox txtKindExpense;
        private System.Windows.Forms.TextBox txtNameExpense;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dtgvExpense;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.DateTimePicker dtDateExpense;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.TextBox txtCostExpense;
    }
}
