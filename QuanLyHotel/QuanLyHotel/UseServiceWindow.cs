using roomServiceBUS;
using roomserviceDTO;
using serviceBUS;
using serviceDTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuanLyHotel
{
    public partial class UseServiceWindow : Form
    {
        public UseServiceWindow()
        {
            InitializeComponent();
            //this.loadData();
        }
        public UseServiceWindow(string name, string kind, string bedamount)
        {
            InitializeComponent();
            //this.loadData();
            lbNameRoom.Text = name;
            lbKindRoom.Text = kind;
            lbBedsAmount.Text = bedamount;
        }
        private ServiceBUS srvBus;
        private RoomServiceBUS roomServiceBUS;

        //
        //---- LOAD DATA
        //
        #region Load Data
        private void loadData()
        {
            srvBus = new ServiceBUS();
            List<ServiceDTO> list = srvBus.select();

            if (list == null)
            {
                MessageBox.Show("Fail");
                return;
            }
            dtgvService.Columns.Clear();
            dtgvService.DataSource = null;

            dtgvService.AutoGenerateColumns = false;
            dtgvService.AllowUserToAddRows = false;
            dtgvService.DataSource = list;

            DataGridViewTextBoxColumn NAME = new DataGridViewTextBoxColumn();
            NAME.Name = "name";
            NAME.HeaderText = "Name:";
            NAME.DataPropertyName = "name";
            NAME.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvService.Columns.Add(NAME);

            DataGridViewTextBoxColumn KIND = new DataGridViewTextBoxColumn();
            KIND.Name = "kind";
            KIND.HeaderText = "Kind";
            KIND.DataPropertyName = "kind";
            KIND.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvService.Columns.Add(KIND);

            DataGridViewTextBoxColumn COST = new DataGridViewTextBoxColumn();
            COST.Name = "cost";
            COST.HeaderText = "Cost";
            COST.DataPropertyName = "cost";
            COST.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvService.Columns.Add(COST);


            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dtgvService.DataSource];
            myCurrencyManager.Refresh();


        }
        private void loadData(List<ServiceDTO> list)
        {
            if (list == null)
            {
                MessageBox.Show("Fail");
                return;
            }
            dtgvService.Columns.Clear();
            dtgvService.DataSource = null;

            dtgvService.AutoGenerateColumns = false;
            dtgvService.AllowUserToAddRows = false;
            dtgvService.DataSource = list;

            DataGridViewTextBoxColumn NAME = new DataGridViewTextBoxColumn();
            NAME.Name = "name";
            NAME.HeaderText = "Name:";
            NAME.DataPropertyName = "name";
            NAME.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvService.Columns.Add(NAME);

            DataGridViewTextBoxColumn KIND = new DataGridViewTextBoxColumn();
            KIND.Name = "kind";
            KIND.HeaderText = "Kind";
            KIND.DataPropertyName = "kind";
            KIND.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvService.Columns.Add(KIND);

            DataGridViewTextBoxColumn COST = new DataGridViewTextBoxColumn();
            COST.Name = "cost";
            COST.HeaderText = "Cost";
            COST.DataPropertyName = "cost";
            COST.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvService.Columns.Add(COST);


            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dtgvService.DataSource];
            myCurrencyManager.Refresh();


        }
        #endregion
        //
        //---- EVENTS
        //
        #region Events
        private void TxtNumberService_KeyPress(object sender, KeyPressEventArgs e)
        {
            int keydown = e.KeyChar;
            if (keydown > 57 || (keydown < 48 && keydown > 9 && keydown < 7))
            {
                errorProvider3.SetError(txtNumberService, "Không được nhập chữ");
                e.KeyChar = (char)0;
            }
            else
            {
                errorProvider3.Clear();
            }
        }

        private void btLoadCustomer_Click(object sender, EventArgs e)
        {
            if(txtSearchService.Text=="")
            {
                this.loadData();
            }
            else
            {
                string Key = txtSearchService.Text.Trim();
                if (Key == null || Key == string.Empty || Key.Length == 0)
                {
                    List<ServiceDTO> listTimKiem = srvBus.select();
                    this.loadData(listTimKiem);
                }
                else
                {
                    List<ServiceDTO> listTimKiem = srvBus.search(Key);
                    this.loadData(listTimKiem);
                }
            }
        }

        private void dtgvService_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            lbNameService.Text = dtgvService.Rows[numrow].Cells[0].Value.ToString();
            lbKindRoom.Text = dtgvService.Rows[numrow].Cells[1].Value.ToString();
            lbCost.Text = dtgvService.Rows[numrow].Cells[2].Value.ToString();
        }

        private void btUseService_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            //errorProvider2.Clear();

            if (txtNumberService.Text == "")
            {
                errorProvider1.SetError(txtNumberService, "not null!");
            }
            //else if (txtKindService.Text == "")
            //{
            //    errorProvider2.SetError(txtKindService, "not null!");
            //}

            else
            {
                roomServiceBUS = new RoomServiceBUS();
                RoomServiceDTO roomService = new RoomServiceDTO();
                roomService.IDR_S = lbNameRoom.Text;
                roomService.IDR = lbNameRoom.Text;
                roomService.IDS = lbNameService.Text;
                roomService.TIME = DateTime.Parse(dtDateService.Text);
                roomService.NUMBER = int.Parse(txtNumberService.Text);
                roomService.COST = Decimal.Parse(lbCost.Text) * Decimal.Parse(txtNumberService.Text);
                bool kq = roomServiceBUS.add(roomService);
                if (kq == false)
                    MessageBox.Show("Fail!");
                else
                    MessageBox.Show("Sussces");
                this.loadData();

            }
            this.Close();
        }
        #endregion
        //
    }
}
