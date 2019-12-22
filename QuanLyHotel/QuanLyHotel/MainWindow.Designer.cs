namespace QuanLyHotel
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.MenuBar = new System.Windows.Forms.Panel();
            this.btMenu = new System.Windows.Forms.Button();
            this.btCustomer = new System.Windows.Forms.Button();
            this.btSetting = new System.Windows.Forms.Button();
            this.btAccount = new System.Windows.Forms.Button();
            this.btRoom = new System.Windows.Forms.Button();
            this.btHome = new System.Windows.Forms.Button();
            this.btService = new System.Windows.Forms.Button();
            this.accountWindow1 = new QuanLyHotel.AccountWindow();
            this.customerWindow1 = new QuanLyHotel.CustomerWindow();
            this.roomWindow1 = new QuanLyHotel.RoomWindow();
            this.serviceWindow1 = new QuanLyHotel.ServiceWindow();
            this.homeWindow1 = new QuanLyHotel.HomeWindow();
            this.MenuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuBar
            // 
            this.MenuBar.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.MenuBar.Controls.Add(this.btMenu);
            this.MenuBar.Controls.Add(this.btCustomer);
            this.MenuBar.Controls.Add(this.btSetting);
            this.MenuBar.Controls.Add(this.btAccount);
            this.MenuBar.Controls.Add(this.btRoom);
            this.MenuBar.Controls.Add(this.btHome);
            this.MenuBar.Controls.Add(this.btService);
            this.MenuBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuBar.Location = new System.Drawing.Point(0, 0);
            this.MenuBar.Margin = new System.Windows.Forms.Padding(0);
            this.MenuBar.MaximumSize = new System.Drawing.Size(200, 0);
            this.MenuBar.MinimumSize = new System.Drawing.Size(57, 0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Size = new System.Drawing.Size(200, 891);
            this.MenuBar.TabIndex = 4;
            // 
            // btMenu
            // 
            this.btMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btMenu.FlatAppearance.BorderSize = 0;
            this.btMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btMenu.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMenu.ForeColor = System.Drawing.Color.White;
            this.btMenu.Image = global::QuanLyHotel.Properties.Resources.Menu_Icon23px;
            this.btMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btMenu.Location = new System.Drawing.Point(7, 26);
            this.btMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btMenu.Name = "btMenu";
            this.btMenu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btMenu.Size = new System.Drawing.Size(51, 53);
            this.btMenu.TabIndex = 7;
            this.btMenu.UseCompatibleTextRendering = true;
            this.btMenu.UseVisualStyleBackColor = true;
            this.btMenu.Click += new System.EventHandler(this.BtMenu_Click);
            // 
            // btCustomer
            // 
            this.btCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btCustomer.FlatAppearance.BorderSize = 0;
            this.btCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCustomer.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCustomer.ForeColor = System.Drawing.Color.White;
            this.btCustomer.Image = global::QuanLyHotel.Properties.Resources.customericon;
            this.btCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCustomer.Location = new System.Drawing.Point(7, 203);
            this.btCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.btCustomer.Name = "btCustomer";
            this.btCustomer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btCustomer.Size = new System.Drawing.Size(193, 53);
            this.btCustomer.TabIndex = 6;
            this.btCustomer.Text = "Customer";
            this.btCustomer.UseCompatibleTextRendering = true;
            this.btCustomer.UseVisualStyleBackColor = true;
            this.btCustomer.Click += new System.EventHandler(this.BtCustomer_Click);
            // 
            // btSetting
            // 
            this.btSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btSetting.FlatAppearance.BorderSize = 0;
            this.btSetting.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSetting.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSetting.ForeColor = System.Drawing.Color.White;
            this.btSetting.Image = global::QuanLyHotel.Properties.Resources.settingicon;
            this.btSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSetting.Location = new System.Drawing.Point(7, 385);
            this.btSetting.Margin = new System.Windows.Forms.Padding(4);
            this.btSetting.Name = "btSetting";
            this.btSetting.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btSetting.Size = new System.Drawing.Size(193, 53);
            this.btSetting.TabIndex = 5;
            this.btSetting.Text = "Setting";
            this.btSetting.UseCompatibleTextRendering = true;
            this.btSetting.UseVisualStyleBackColor = true;
            // 
            // btAccount
            // 
            this.btAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btAccount.FlatAppearance.BorderSize = 0;
            this.btAccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAccount.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAccount.ForeColor = System.Drawing.Color.White;
            this.btAccount.Image = global::QuanLyHotel.Properties.Resources.checkinicon;
            this.btAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAccount.Location = new System.Drawing.Point(7, 324);
            this.btAccount.Margin = new System.Windows.Forms.Padding(4);
            this.btAccount.Name = "btAccount";
            this.btAccount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btAccount.Size = new System.Drawing.Size(193, 53);
            this.btAccount.TabIndex = 2;
            this.btAccount.Text = "Account";
            this.btAccount.UseCompatibleTextRendering = true;
            this.btAccount.UseVisualStyleBackColor = true;
            this.btAccount.Click += new System.EventHandler(this.BtAccount_Click);
            // 
            // btRoom
            // 
            this.btRoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btRoom.FlatAppearance.BorderSize = 0;
            this.btRoom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btRoom.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRoom.ForeColor = System.Drawing.Color.White;
            this.btRoom.Image = global::QuanLyHotel.Properties.Resources.roomicon;
            this.btRoom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btRoom.Location = new System.Drawing.Point(7, 143);
            this.btRoom.Margin = new System.Windows.Forms.Padding(4);
            this.btRoom.Name = "btRoom";
            this.btRoom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btRoom.Size = new System.Drawing.Size(193, 53);
            this.btRoom.TabIndex = 1;
            this.btRoom.Text = "Room";
            this.btRoom.UseCompatibleTextRendering = true;
            this.btRoom.UseVisualStyleBackColor = true;
            this.btRoom.Click += new System.EventHandler(this.BtRoom_Click);
            // 
            // btHome
            // 
            this.btHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btHome.FlatAppearance.BorderSize = 0;
            this.btHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btHome.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHome.ForeColor = System.Drawing.Color.White;
            this.btHome.Image = global::QuanLyHotel.Properties.Resources.homeicon;
            this.btHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btHome.Location = new System.Drawing.Point(7, 86);
            this.btHome.Margin = new System.Windows.Forms.Padding(4);
            this.btHome.Name = "btHome";
            this.btHome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btHome.Size = new System.Drawing.Size(193, 53);
            this.btHome.TabIndex = 0;
            this.btHome.Text = "Home";
            this.btHome.UseCompatibleTextRendering = true;
            this.btHome.UseVisualStyleBackColor = true;
            this.btHome.Click += new System.EventHandler(this.BtHome_Click);
            // 
            // btService
            // 
            this.btService.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btService.FlatAppearance.BorderSize = 0;
            this.btService.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btService.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btService.ForeColor = System.Drawing.Color.White;
            this.btService.Image = global::QuanLyHotel.Properties.Resources.serviceicon;
            this.btService.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btService.Location = new System.Drawing.Point(7, 263);
            this.btService.Margin = new System.Windows.Forms.Padding(4);
            this.btService.Name = "btService";
            this.btService.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btService.Size = new System.Drawing.Size(193, 53);
            this.btService.TabIndex = 4;
            this.btService.Text = "Service";
            this.btService.UseCompatibleTextRendering = true;
            this.btService.UseVisualStyleBackColor = true;
            this.btService.Click += new System.EventHandler(this.BtService_Click);
            // 
            // accountWindow1
            // 
            this.accountWindow1.Location = new System.Drawing.Point(414, 71);
            this.accountWindow1.Margin = new System.Windows.Forms.Padding(4);
            this.accountWindow1.Name = "accountWindow1";
            this.accountWindow1.Size = new System.Drawing.Size(50, 50);
            this.accountWindow1.TabIndex = 5;
            // 
            // customerWindow1
            // 
            this.customerWindow1.Location = new System.Drawing.Point(459, 85);
            this.customerWindow1.Margin = new System.Windows.Forms.Padding(4);
            this.customerWindow1.Name = "customerWindow1";
            this.customerWindow1.Size = new System.Drawing.Size(50, 50);
            this.customerWindow1.TabIndex = 6;
            // 
            // roomWindow1
            // 
            this.roomWindow1.Location = new System.Drawing.Point(482, 69);
            this.roomWindow1.Margin = new System.Windows.Forms.Padding(4);
            this.roomWindow1.Name = "roomWindow1";
            this.roomWindow1.Size = new System.Drawing.Size(50, 50);
            this.roomWindow1.TabIndex = 8;
            // 
            // serviceWindow1
            // 
            this.serviceWindow1.Location = new System.Drawing.Point(488, 103);
            this.serviceWindow1.Margin = new System.Windows.Forms.Padding(4);
            this.serviceWindow1.Name = "serviceWindow1";
            this.serviceWindow1.Size = new System.Drawing.Size(50, 50);
            this.serviceWindow1.TabIndex = 9;
            // 
            // homeWindow1
            // 
            this.homeWindow1.Location = new System.Drawing.Point(488, 157);
            this.homeWindow1.Margin = new System.Windows.Forms.Padding(0);
            this.homeWindow1.Name = "homeWindow1";
            this.homeWindow1.Size = new System.Drawing.Size(50, 50);
            this.homeWindow1.TabIndex = 10;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 891);
            this.Controls.Add(this.homeWindow1);
            this.Controls.Add(this.serviceWindow1);
            this.Controls.Add(this.roomWindow1);
            this.Controls.Add(this.customerWindow1);
            this.Controls.Add(this.accountWindow1);
            this.Controls.Add(this.MenuBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MenuBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuBar;
        private System.Windows.Forms.Button btCustomer;
        private System.Windows.Forms.Button btSetting;
        private System.Windows.Forms.Button btAccount;
        private System.Windows.Forms.Button btRoom;
        private System.Windows.Forms.Button btHome;
        private System.Windows.Forms.Button btService;
        private System.Windows.Forms.Button btMenu;
        private AccountWindow accountWindow1;
        private CustomerWindow customerWindow1;
        private RoomWindow roomWindow1;
        private ServiceWindow serviceWindow1;
        private HomeWindow homeWindow1;
    }
}