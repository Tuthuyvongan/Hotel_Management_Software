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
using roomBUS;
using roomDTO;
using roomServiceBUS;
using roomserviceDTO;
namespace QuanLyHotel
{
    public partial class CheckOutWindow : Form
    {
        public CheckOutWindow()
        {
            InitializeComponent();
            //this.loadData();
        }
        private BillBUS bllBus;
        private RoomBUS rmBUS;
        private RoomServiceBUS srvBUS;
        string username = "";
        public CheckOutWindow(string Username)
        {
            username = Username;
        }

        //
        //---- LOAD DATA
        //
        #region Load Data
        private void loadData()
        {
            bllBus = new BillBUS();
            List<BillDTO> list = bllBus.select();

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
        private void loadData(List<BillDTO> list)
        {
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
        #endregion
        //
        //---- EVENTS
        //
        #region Events
        private void btLoadCustomer_Click(object sender, EventArgs e)
        {
            if (txtSearchBill.Text == "")
            {
                this.loadData();
            }
            else
            {
                string Key = txtSearchBill.Text.Trim();
                if (Key == null || Key == string.Empty || Key.Length == 0)
                {
                    List<BillDTO> listTimKiem = bllBus.select();
                    this.loadData(listTimKiem);
                }
                else
                {
                    List<BillDTO> listTimKiem = bllBus.search(Key);
                    this.loadData(listTimKiem);
                }
            }
        }

        private void btCheckOut_Click_1(object sender, EventArgs e)
        {
            srvBUS = new RoomServiceBUS();
            RoomServiceDTO srv = new RoomServiceDTO();
            srv.IDR = lbNameRoom.Text;
            lbCostService.Text = srvBUS.GetSumCostRoomServiceBill(srv,DateTime.Parse(lbCheckIn.Text),DateTime.Parse(lbCheckOut.Text)).ToString();
            bllBus = new BillBUS();
            BillDTO bll = new BillDTO();
            bll.IDC = lbNameCustomer.Text;
            bll.IDR = lbNameRoom.Text;
            bll.CheckIn = DateTime.Parse(lbCheckIn.Text);
            bll.CheckOut = DateTime.Parse(lbCheckOut.Text);
            lbCostRoom.Text = bll.COST.ToString();
            bll.COST = Decimal.Parse(lbCostRoom.Text)/*+Decimal.Parse(lbCostService.Text)*/;
            bool kq = bllBus.editCost(bll);
            if (kq == false)
                MessageBox.Show("Fail!");
            else
            {
                rmBUS = new RoomBUS();
                RoomDTO rm = new RoomDTO();
                rm.Idr = lbNameRoom.Text;
                rm.Status = "Trống";
                bool kq1 = rmBUS.editStatus(rm);
                if (kq == false)
                    MessageBox.Show("Fail!");
                else
                    MessageBox.Show("Sussces");
            }
            this.Close();
        }

        private void dtgvBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            lbNameRoom.Text = dtgvBill.Rows[numrow].Cells[0].Value.ToString();
            lbNameCustomer.Text = dtgvBill.Rows[numrow].Cells[1].Value.ToString();
            lbSumCost.Text = Convert.ToString(dtgvBill.Rows[numrow].Cells[2].Value);
            lbCheckIn.Text = Convert.ToString(dtgvBill.Rows[numrow].Cells[3].Value);
            lbCheckIn.Text = Convert.ToString(dtgvBill.Rows[numrow].Cells[4].Value);
        }
        #endregion
    }
}
