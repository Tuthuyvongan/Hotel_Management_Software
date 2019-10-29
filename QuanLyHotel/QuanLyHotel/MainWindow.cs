using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHotel
{
    public partial class MainWindow : Form
    {
        private bool dragging = false;
        private Point StartPoint = new Point(0, 0);

        public MainWindow()
        {
            InitializeComponent();
            SlidePanel.Height = btHome.Height;
            SlidePanel.Top = btHome.Top;
            homeWindow1.BringToFront();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MoveBar_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            StartPoint = new Point(e.X, e.Y);
        }

        private void MoveBar_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void MoveBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.StartPoint.X, p.Y - this.StartPoint.Y);
            }
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            SlidePanel.Height = btHome.Height;
            SlidePanel.Top = btHome.Top;
            homeWindow1.BringToFront();
        }

        private void RoomButton_Click(object sender, EventArgs e)
        {
            SlidePanel.Height = btRoom.Height;
            SlidePanel.Top = btRoom.Top;
            roomWindow1.BringToFront();
        }

        private void CustomerButton_Click(object sender, EventArgs e)
        {
            SlidePanel.Height = btCustomer.Height;
            SlidePanel.Top = btCustomer.Top;
            customerWindow1.BringToFront();
        }

        private void CheckInButton_Click(object sender, EventArgs e)
        {
            SlidePanel.Height = btCheckIn.Height;
            SlidePanel.Top = btCheckIn.Top;
            checkInWindow1.BringToFront();
        }

        private void CheckOutButton_Click(object sender, EventArgs e)
        {
            SlidePanel.Height = btCheckOut.Height;
            SlidePanel.Top = btCheckOut.Top;
            checkOutWindow1.BringToFront();
        }

        private void ServiceButton_Click(object sender, EventArgs e)
        {
            SlidePanel.Height = btService.Height;
            SlidePanel.Top = btService.Top;
            serviceWindow1.BringToFront();
        }

        private void SettingButton_Click(object sender, EventArgs e)
        {
            SlidePanel.Height = btSetting.Height;
            SlidePanel.Top = btSetting.Top;
            settingWindow1.BringToFront();
        }
    }
}
