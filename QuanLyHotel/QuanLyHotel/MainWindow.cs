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
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            
        }

        private void RoomButton_Click(object sender, EventArgs e)
        {
            
        }
        //Click event
        private void BtMenu_Click(object sender, EventArgs e)
        {
            if(MenuBar.Width == 150)
            {
                MenuBar.Width = 43;
            }
            else MenuBar.Width = 150;
        }

        private void BtHome_AutoSizeChanged(object sender, EventArgs e)
        {
            //this.Width = ControlPanel.Width;
        }

        private void BtHome_Click(object sender, EventArgs e)
        {
            homeWindow1.BringToFront();
        }

        private void BtRoom_Click(object sender, EventArgs e)
        {
            roomWindow1.BringToFront();
        }

        private void BtCustomer_Click(object sender, EventArgs e)
        {
            customerWindow1.BringToFront();
        }
    }
}
