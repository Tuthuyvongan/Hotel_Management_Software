using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using billBUS;
using billDTO;

namespace QuanLyHotel
{
    public partial class CheckInWindow : Form
    {
        public CheckInWindow()
        {
            InitializeComponent();
        }
        public string idm = "";
        public CheckInWindow(string id)
        {
            idm = id;
        }
        public CheckInWindow(string name, string kind, string bedamount, string cost)
        {
            InitializeComponent();
            lbNameRoom.Text = name;
            lbKind.Text = kind;
            lbBedsAmount.Text = bedamount;
            lbCost.Text = cost;
        }

        

        private void BtCheckIn_Click(object sender, EventArgs e)
        {
            BillBUS bllBUS = new BillBUS();
            BillDTO bll = new BillDTO();
            bll.IDB = lbNameCustomer.Text+"/"+dtCheckIn.Text+"/"+dtCheckOut.Text+"@"+lbNameCustomer.Text;
            bll.IDC = lbNameCustomer.Text;
            bll.IDM =idm;
            bll.IDR = lbNameRoom.Text;
            
            bll.CheckIn =DateTime.Parse(dtCheckIn.Text);
            bll.CheckOut =DateTime.Parse(dtCheckOut.Text);
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
