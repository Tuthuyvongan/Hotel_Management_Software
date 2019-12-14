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
    public partial class CheckInWindow : Form
    {
        public CheckInWindow()
        {
            InitializeComponent();
        }
        public CheckInWindow(string _name, string _kind, string _bedamount, string _cost)
        {
            InitializeComponent();
            lbName.Text = _name;
            lbKind.Text = _kind;
            lbBedsAmount.Text = _bedamount;
            lbCost.Text = _cost;
        }

        private void CheckInWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void BtCheckIn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
