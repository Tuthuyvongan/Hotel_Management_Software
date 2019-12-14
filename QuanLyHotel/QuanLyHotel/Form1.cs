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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void HomeButton_Click(object sender, EventArgs e)
        {
            SlidePanel.Height = btHome.Height;
            SlidePanel.Top = btHome.Top;
            //homeWindow1.BringToFront();
        }

        private void RoomButton_Click(object sender, EventArgs e)
        {
            SlidePanel.Height = btRoom.Height;
            SlidePanel.Top = btRoom.Top;
            //roomWindow1.BringToFront();
        }

        //private void CustomerButton_Click(object sender, EventArgs e)
        //{
        //    SlidePanel.Height = btCustomer.Height;
        //    SlidePanel.Top = btCustomer.Top;
        //    customerWindow1.BringToFront();
        //}

        //private void CheckInButton_Click(object sender, EventArgs e)
        //{
        //    SlidePanel.Height = btCheckIn.Height;
        //    SlidePanel.Top = btCheckIn.Top;
        //    checkInWindow1.BringToFront();
        //}

        //private void CheckOutButton_Click(object sender, EventArgs e)
        //{
        //    SlidePanel.Height = btCheckOut.Height;
        //    SlidePanel.Top = btCheckOut.Top;
        //    checkOutWindow1.BringToFront();
        //}

        //private void ServiceButton_Click(object sender, EventArgs e)
        //{
        //    SlidePanel.Height = btService.Height;
        //    SlidePanel.Top = btService.Top;
        //    serviceWindow1.BringToFront();
        //}

        //private void SettingButton_Click(object sender, EventArgs e)
        //{
        //    SlidePanel.Height = btSetting.Height;
        //    SlidePanel.Top = btSetting.Top;
        //    settingWindow1.BringToFront();
        //}
    }
}
