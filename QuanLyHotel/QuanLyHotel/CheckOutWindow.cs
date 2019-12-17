using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using billDTO;
using billBUS;

namespace QuanLyHotel
{
    public partial class CheckOutWindow : Form
    {
        public CheckOutWindow()
        {
            InitializeComponent();
        }
        string username = "";
        public CheckOutWindow(string Username)
        {
            username = Username;
        }
        private void BtCheckOut_Click(object sender, EventArgs e)
        {
            BillBUS bllBUS = new BillBUS();
            BillDTO bll = new BillDTO();
            bll.IDB = lbNameCustomer.Text + "/" + lbCheckIn.Text + "/" + lbCheckOut.Text + "@" + lbNameCustomer.Text;
            bll.IDC = lbNameCustomer.Text;
            bll.IDM = username;
            bll.IDR = lbNameRoom.Text;

            bll.CheckIn = DateTime.Parse(lbCheckIn.Text);
            bll.CheckOut = DateTime.Parse(lbCheckOut.Text);
            lbCostRoom.Text = bll.COST.ToString();
            bll.COST = Decimal.Parse(lbCost.Text);/**Decimal.Parse((dtCheckOut-dtCheckIn).Tostring())*/
            bool kq = bllBUS.add(bll);
            if (kq == false)
                MessageBox.Show("Fail!");
            else
                MessageBox.Show("Sussces");
            this.Close();
        }
    }
}
