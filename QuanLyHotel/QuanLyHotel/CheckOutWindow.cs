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
            this.loadData();
        }
        string username = "";
        public CheckOutWindow(string Username)
        {
            username = Username;
        }
        private void loadData()
        {
            BillBUS ctmBus = new BillBUS();
            List<BillDTO> list = ctmBus.select();

            if (list == null)
            {
                MessageBox.Show("Fail");
                return;
            }
            dtgvBill.Columns.Clear();
            dtgvBill.DataSource = null;

            dtgvBill.AutoGenerateColumns = false;
            dtgvBill.AllowUserToAddRows = false;
            dtgvBill.DataSource = list;

            DataGridViewTextBoxColumn IDR = new DataGridViewTextBoxColumn();
            IDR.Name = "idr";
            IDR.HeaderText = "Room";
            IDR.DataPropertyName = "idr";
            IDR.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvBill.Columns.Add(IDR);

            DataGridViewTextBoxColumn IDC = new DataGridViewTextBoxColumn();
            IDC.Name = "idc";
            IDC.HeaderText = "Customer";
            IDC.DataPropertyName = "idc";
            IDC.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvBill.Columns.Add(IDC);

            DataGridViewTextBoxColumn IDM = new DataGridViewTextBoxColumn();
            IDM.Name = "idm";
            IDM.HeaderText = "Manager";
            IDM.DataPropertyName = "idm";
            IDM.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvBill.Columns.Add(IDM);

            DataGridViewTextBoxColumn Cost = new DataGridViewTextBoxColumn();
            Cost.Name = "cost";
            Cost.HeaderText = "Cost";
            Cost.DataPropertyName = "cost";
            Cost.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvBill.Columns.Add(Cost);

            DataGridViewTextBoxColumn CheckIn = new DataGridViewTextBoxColumn();
            CheckIn.Name = "checkin";
            CheckIn.HeaderText = "Check In";
            CheckIn.DataPropertyName = "checkin";
            CheckIn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvBill.Columns.Add(CheckIn);

            DataGridViewTextBoxColumn CheckOut = new DataGridViewTextBoxColumn();
            CheckOut.Name = "checkout";
            CheckOut.HeaderText = "Check Out";
            CheckOut.DataPropertyName = "checkout";
            CheckOut.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvBill.Columns.Add(CheckOut);


            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dtgvBill.DataSource];
            myCurrencyManager.Refresh();


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
            bll.COST = Decimal.Parse(lbCostRoom.Text);/**Decimal.Parse((dtCheckOut-dtCheckIn).Tostring())*/
            bool kq = bllBUS.edit(bll);
            if (kq == false)
                MessageBox.Show("Fail!");
            else
                MessageBox.Show("Sussces");
            this.Close();
        }
    }
}
