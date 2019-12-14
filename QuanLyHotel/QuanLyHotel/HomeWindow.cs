using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHotel
{
    public partial class HomeWindow : UserControl
    {
        public HomeWindow()
        {
            InitializeComponent();
        }

        private void BtCheckInRoom_Click(object sender, EventArgs e)
        {
            CheckInWindow checkIn = new CheckInWindow(lbName.Text,lbKind.Text,lbBedsAmount.Text,lbCost.Text);
            checkIn.Show();
        }

        private void BtCheckOut_Click(object sender, EventArgs e)
        {
            CheckOutWindow checkOut = new CheckOutWindow();
            checkOut.Show();
        }

        private void BtUseService_Click(object sender, EventArgs e)
        {
            UseServiceWindow useService = new UseServiceWindow();
            useService.Show();
        }
    }
}
