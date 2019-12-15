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
            this.MenuBar = new System.Windows.Forms.Panel();
            this.btMenu = new System.Windows.Forms.Button();
            this.btCustomer = new System.Windows.Forms.Button();
            this.btSetting = new System.Windows.Forms.Button();
            this.btCheckOut = new System.Windows.Forms.Button();
            this.btCheckIn = new System.Windows.Forms.Button();
            this.btRoom = new System.Windows.Forms.Button();
            this.btHome = new System.Windows.Forms.Button();
            this.btService = new System.Windows.Forms.Button();
            this.homeWindow1 = new QuanLyHotel.HomeWindow();
            this.customerWindow1 = new QuanLyHotel.CustomerWindow();
            this.roomWindow1 = new QuanLyHotel.RoomWindow();
            this.serviceWindow1 = new QuanLyHotel.ServiceWindow();
            this.MenuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuBar
            // 
            this.MenuBar.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.MenuBar.Controls.Add(this.btMenu);
            this.MenuBar.Controls.Add(this.btCustomer);
            this.MenuBar.Controls.Add(this.btSetting);
            this.MenuBar.Controls.Add(this.btCheckOut);
            this.MenuBar.Controls.Add(this.btCheckIn);
            this.MenuBar.Controls.Add(this.btRoom);
            this.MenuBar.Controls.Add(this.btHome);
            this.MenuBar.Controls.Add(this.btService);
            this.MenuBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuBar.Location = new System.Drawing.Point(0, 0);
            this.MenuBar.Margin = new System.Windows.Forms.Padding(0);
            this.MenuBar.MaximumSize = new System.Drawing.Size(150, 0);
            this.MenuBar.MinimumSize = new System.Drawing.Size(43, 0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Size = new System.Drawing.Size(150, 724);
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
            this.btMenu.Location = new System.Drawing.Point(5, 21);
            this.btMenu.Name = "btMenu";
            this.btMenu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btMenu.Size = new System.Drawing.Size(38, 43);
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
            this.btCustomer.Location = new System.Drawing.Point(5, 165);
            this.btCustomer.Name = "btCustomer";
            this.btCustomer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btCustomer.Size = new System.Drawing.Size(145, 43);
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
            this.btSetting.Location = new System.Drawing.Point(5, 263);
            this.btSetting.Name = "btSetting";
            this.btSetting.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btSetting.Size = new System.Drawing.Size(145, 43);
            this.btSetting.TabIndex = 5;
            this.btSetting.Text = "Setting";
            this.btSetting.UseCompatibleTextRendering = true;
            this.btSetting.UseVisualStyleBackColor = true;
            // 
            // btCheckOut
            // 
            this.btCheckOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btCheckOut.FlatAppearance.BorderSize = 0;
            this.btCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCheckOut.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCheckOut.ForeColor = System.Drawing.Color.White;
            this.btCheckOut.Image = global::QuanLyHotel.Properties.Resources.checkouticon;
            this.btCheckOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCheckOut.Location = new System.Drawing.Point(5, 361);
            this.btCheckOut.Name = "btCheckOut";
            this.btCheckOut.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btCheckOut.Size = new System.Drawing.Size(145, 43);
            this.btCheckOut.TabIndex = 3;
            this.btCheckOut.Text = "Check out";
            this.btCheckOut.UseCompatibleTextRendering = true;
            this.btCheckOut.UseVisualStyleBackColor = true;
            // 
            // btCheckIn
            // 
            this.btCheckIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btCheckIn.FlatAppearance.BorderSize = 0;
            this.btCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCheckIn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCheckIn.ForeColor = System.Drawing.Color.White;
            this.btCheckIn.Image = global::QuanLyHotel.Properties.Resources.checkinicon;
            this.btCheckIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCheckIn.Location = new System.Drawing.Point(5, 312);
            this.btCheckIn.Name = "btCheckIn";
            this.btCheckIn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btCheckIn.Size = new System.Drawing.Size(145, 43);
            this.btCheckIn.TabIndex = 2;
            this.btCheckIn.Text = "Check in";
            this.btCheckIn.UseCompatibleTextRendering = true;
            this.btCheckIn.UseVisualStyleBackColor = true;
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
            this.btRoom.Location = new System.Drawing.Point(5, 116);
            this.btRoom.Name = "btRoom";
            this.btRoom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btRoom.Size = new System.Drawing.Size(145, 43);
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
            this.btHome.Location = new System.Drawing.Point(5, 70);
            this.btHome.Name = "btHome";
            this.btHome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btHome.Size = new System.Drawing.Size(145, 43);
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
            this.btService.Location = new System.Drawing.Point(5, 214);
            this.btService.Name = "btService";
            this.btService.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btService.Size = new System.Drawing.Size(145, 43);
            this.btService.TabIndex = 4;
            this.btService.Text = "Service";
            this.btService.UseCompatibleTextRendering = true;
            this.btService.UseVisualStyleBackColor = true;
            this.btService.Click += new System.EventHandler(this.BtService_Click);
            // 
            // homeWindow1
            // 
            this.homeWindow1.Location = new System.Drawing.Point(150, 0);
            this.homeWindow1.Margin = new System.Windows.Forms.Padding(0);
            this.homeWindow1.MinimumSize = new System.Drawing.Size(821, 652);
            this.homeWindow1.Name = "homeWindow1";
            this.homeWindow1.Size = new System.Drawing.Size(821, 652);
            this.homeWindow1.TabIndex = 5;
            // 
            // customerWindow1
            // 
            this.customerWindow1.Location = new System.Drawing.Point(150, 0);
            this.customerWindow1.MinimumSize = new System.Drawing.Size(821, 652);
            this.customerWindow1.Name = "customerWindow1";
            this.customerWindow1.Size = new System.Drawing.Size(821, 652);
            this.customerWindow1.TabIndex = 6;
            // 
            // roomWindow1
            // 
            this.roomWindow1.Location = new System.Drawing.Point(150, 0);
            this.roomWindow1.MinimumSize = new System.Drawing.Size(821, 652);
            this.roomWindow1.Name = "roomWindow1";
            this.roomWindow1.Size = new System.Drawing.Size(821, 652);
            this.roomWindow1.TabIndex = 7;
            // 
            // serviceWindow1
            // 
            this.serviceWindow1.Location = new System.Drawing.Point(150, 0);
            this.serviceWindow1.MinimumSize = new System.Drawing.Size(821, 652);
            this.serviceWindow1.Name = "serviceWindow1";
            this.serviceWindow1.Size = new System.Drawing.Size(821, 652);
            this.serviceWindow1.TabIndex = 8;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 724);
            this.Controls.Add(this.serviceWindow1);
            this.Controls.Add(this.roomWindow1);
            this.Controls.Add(this.customerWindow1);
            this.Controls.Add(this.homeWindow1);
            this.Controls.Add(this.MenuBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MenuBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuBar;
        private System.Windows.Forms.Button btCustomer;
        private System.Windows.Forms.Button btSetting;
        private System.Windows.Forms.Button btCheckOut;
        private System.Windows.Forms.Button btCheckIn;
        private System.Windows.Forms.Button btRoom;
        private System.Windows.Forms.Button btHome;
        private System.Windows.Forms.Button btService;
        private System.Windows.Forms.Button btMenu;
        private HomeWindow homeWindow1;
        private CustomerWindow customerWindow1;
        private RoomWindow roomWindow1;
        private ServiceWindow serviceWindow1;
    }
}