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
        string username = "";
        //int level = 0;
        
        public string idm = "";
        
        public CheckInWindow(string Username,/*, int Level*/string name, string kind, string bedamount, string cost)
        {
            InitializeComponent();
            username = Username;
            //level = Level;
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
            bll.IDM = username;
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

        private void dtgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            lbNameCustomer.Text = dtgvCustomer.Rows[numrow].Cells[1].Value.ToString();
            lbIdentifyCard.Text = dtgvCustomer.Rows[numrow].Cells[2].Value.ToString();
            lbPhone.Text = dtgvCustomer.Rows[numrow].Cells[3].Value.ToString();
            lbNameRoom.Text = dtgvCustomer.Rows[numrow].Cells[4].Value.ToString();
            lbKind.Text = dtgvCustomer.Rows[numrow].Cells[5].Value.ToString();
            lbBedsAmount.Text = dtgvCustomer.Rows[numrow].Cells[6].Value.ToString();
            lbCost.Text = dtgvCustomer.Rows[numrow].Cells[7].Value.ToString();
        }
    }
}
