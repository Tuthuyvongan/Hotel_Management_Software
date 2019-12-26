using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using serviceBUS;
using serviceDTO;
using roomserviceDTO;
using roomServiceBUS;


namespace QuanLyHotel
{
    public partial class ServiceWindow : UserControl
    {
        public ServiceWindow()
        {
            InitializeComponent();
            //loadData();
            //this.loadDataRoomService();
        }

        private ServiceBUS srvBUS;
        private RoomServiceBUS rsrvBus;

        //
        //---- LOAD DATA
        //
        #region Load Data
        private void loadData()
        {
            srvBUS = new ServiceBUS();
            List<ServiceDTO> list = srvBUS.select();

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
        private void loadDataRoomService()
        {
            rsrvBus = new RoomServiceBUS();
            List<RoomServiceDTO> list = rsrvBus.select();

            if (list == null)
            {
                MessageBox.Show("Fail");
                return;
            }
            dtgvUseService.Columns.Clear();
            dtgvUseService.DataSource = null;

            dtgvUseService.AutoGenerateColumns = false;
            dtgvUseService.AllowUserToAddRows = false;
            dtgvUseService.DataSource = list;

            DataGridViewTextBoxColumn IDS = new DataGridViewTextBoxColumn();
            IDS.Name = "ids";
            IDS.HeaderText = "Service:";
            IDS.DataPropertyName = "ids";
            IDS.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvUseService.Columns.Add(IDS);

            DataGridViewTextBoxColumn IDR = new DataGridViewTextBoxColumn();
            IDR.Name = "idr";
            IDR.HeaderText = "Room";
            IDR.DataPropertyName = "idr";
            IDR.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvUseService.Columns.Add(IDR);

            DataGridViewTextBoxColumn Time = new DataGridViewTextBoxColumn();
            Time.Name = "time";
            Time.HeaderText = "Time";
            Time.DataPropertyName = "time";
            Time.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvUseService.Columns.Add(Time);

            DataGridViewTextBoxColumn NUMBER = new DataGridViewTextBoxColumn();
            NUMBER.Name = "number";
            NUMBER.HeaderText = "Number";
            NUMBER.DataPropertyName = "number";
            NUMBER.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvUseService.Columns.Add(NUMBER);

            DataGridViewTextBoxColumn COST = new DataGridViewTextBoxColumn();
            COST.Name = "cost";
            COST.HeaderText = "Cost";
            COST.DataPropertyName = "cost";
            COST.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvUseService.Columns.Add(COST);


            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dtgvUseService.DataSource];
            myCurrencyManager.Refresh();


        }
        private void loadDataRoomService(List<RoomServiceDTO> list)
        {

            if (list == null)
            {
                MessageBox.Show("Fail");
                return;
            }
            dtgvUseService.Columns.Clear();
            dtgvUseService.DataSource = null;

            dtgvUseService.AutoGenerateColumns = false;
            dtgvUseService.AllowUserToAddRows = false;
            dtgvUseService.DataSource = list;

            DataGridViewTextBoxColumn IDS = new DataGridViewTextBoxColumn();
            IDS.Name = "ids";
            IDS.HeaderText = "Service:";
            IDS.DataPropertyName = "ids";
            IDS.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvUseService.Columns.Add(IDS);

            DataGridViewTextBoxColumn IDR = new DataGridViewTextBoxColumn();
            IDR.Name = "idr";
            IDR.HeaderText = "Room";
            IDR.DataPropertyName = "idr";
            IDR.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvUseService.Columns.Add(IDR);

            DataGridViewTextBoxColumn Time = new DataGridViewTextBoxColumn();
            Time.Name = "time";
            Time.HeaderText = "Time";
            Time.DataPropertyName = "time";
            Time.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvUseService.Columns.Add(Time);

            DataGridViewTextBoxColumn NUMBER = new DataGridViewTextBoxColumn();
            NUMBER.Name = "number";
            NUMBER.HeaderText = "Number";
            NUMBER.DataPropertyName = "number";
            NUMBER.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvUseService.Columns.Add(NUMBER);

            DataGridViewTextBoxColumn COST = new DataGridViewTextBoxColumn();
            COST.Name = "cost";
            COST.HeaderText = "Cost";
            COST.DataPropertyName = "cost";
            COST.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvUseService.Columns.Add(COST);


            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dtgvUseService.DataSource];
            myCurrencyManager.Refresh();


        }
        #endregion
        //
        //---- EVENTS
        //
        #region Events
        private void TxtCostService_KeyPress(object sender, KeyPressEventArgs e)
        {
            int keydown = e.KeyChar;
            if (keydown > 57 || (keydown < 48 && keydown > 9 && keydown < 7))
            {
                errorProvider4.SetError(txtCostService, "Không được nhập chữ");
                e.KeyChar = (char)0;
            }
            else
            {
                errorProvider4.Clear();
            }
        }

        private void btLoadService_Click_1(object sender, EventArgs e)
        {
            if (txtSearchService1.Text == "")
            {
                this.loadData();
            }
            else
            {
                string Key = txtSearchService1.Text.Trim();
                if (Key == null || Key == string.Empty || Key.Length == 0)
                {
                    List<ServiceDTO> listTimKiem = srvBUS.select();
                    this.loadData(listTimKiem);
                }
                else
                {
                    List<ServiceDTO> listTimKiem = srvBUS.search(Key);
                    this.loadData(listTimKiem);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtSearchRoomService.Text == "")
            {
                this.loadDataRoomService();
            }
            else
            {
                string Key = txtSearchRoomService.Text.Trim();
                if (Key == null || Key == string.Empty || Key.Length == 0)
                {
                    List<RoomServiceDTO> listTimKiem = rsrvBus.select();
                    this.loadDataRoomService(listTimKiem);
                }
                else
                {
                    List<RoomServiceDTO> listTimKiem = rsrvBus.search(Key);
                    this.loadDataRoomService(listTimKiem);
                }
            }
        }

        private void btAddService_Click_1(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            errorProvider2.Clear();
            errorProvider3.Clear();


            if (txtNameService.Text == "")
            {
                errorProvider1.SetError(txtNameService, "not null!");
            }
            else if (txtKindService.Text == "")
            {
                errorProvider2.SetError(txtKindService, "not null!");
            }
            else if (txtCostService.Text == "")
            {
                errorProvider3.SetError(txtCostService, "not null!");
            }


            else
            {
                srvBUS = new ServiceBUS();

                ServiceDTO srv = new ServiceDTO();
                srv.IDS = txtNameService.Text;
                srv.NAME = txtNameService.Text;
                srv.KIND = txtKindService.Text;
                srv.COST = Decimal.Parse(txtCostService.Text);
                bool kq = srvBUS.add(srv);
                if (kq == false)
                    MessageBox.Show("Fail!");
                else
                    MessageBox.Show("Sussces");
                this.loadData();
            }
        }

        private void btEditService_Click_1(object sender, EventArgs e)
        {
            srvBUS = new ServiceBUS();

            ServiceDTO srv = new ServiceDTO();
            srv.IDS = txtNameService.Text;
            srv.NAME = txtNameService.Text;
            srv.KIND = txtKindService.Text;
            srv.COST = Decimal.Parse(txtCostService.Text);
            bool kq = srvBUS.edit(srv);
            if (kq == false)
                MessageBox.Show("Fail!");
            else
                MessageBox.Show("Sussces");
            this.loadData();
        }

        private void btDeleteService_Click_1(object sender, EventArgs e)
        {
            srvBUS = new ServiceBUS();

            ServiceDTO srv = new ServiceDTO();
            srv.IDS = txtNameService.Text;
            srv.NAME = txtNameService.Text;
            srv.KIND = txtKindService.Text;
            srv.COST = Decimal.Parse(txtCostService.Text);
            bool kq = srvBUS.delete(srv);
            if (kq == false)
                MessageBox.Show("Fail!");
            else
                MessageBox.Show("Sussces");
            this.loadData();
        }
       

        private void dtgvService_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            txtNameService.Text = dtgvService.Rows[numrow].Cells[0].Value.ToString();
            txtKindService.Text = dtgvService.Rows[numrow].Cells[1].Value.ToString();
            txtCostService.Text = Convert.ToString(dtgvService.Rows[numrow].Cells[2].Value);
        }
        #endregion

        private void btAddService_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            errorProvider2.Clear();
            errorProvider3.Clear();


            if (txtNameService.Text == "")
            {
                errorProvider1.SetError(txtNameService, "not null!");
            }
            else if (txtKindService.Text == "")
            {
                errorProvider2.SetError(txtKindService, "not null!");
            }
            else if (txtCostService.Text == "")
            {
                errorProvider3.SetError(txtCostService, "not null!");
            }


            else
            {
                srvBUS = new ServiceBUS();

                ServiceDTO srv = new ServiceDTO();
                srv.IDS = txtNameService.Text;
                srv.NAME = txtNameService.Text;
                srv.KIND = txtKindService.Text;
                srv.COST = Decimal.Parse(txtCostService.Text);
                bool kq = srvBUS.add(srv);
                if (kq == false)
                    MessageBox.Show("Fail!");
                else
                    MessageBox.Show("Sussces");
                this.loadData();
            }
        }

        private void btEditService_Click(object sender, EventArgs e)
        {
            srvBUS = new ServiceBUS();

            ServiceDTO srv = new ServiceDTO();
            srv.IDS = txtNameService.Text;
            srv.NAME = txtNameService.Text;
            srv.KIND = txtKindService.Text;
            srv.COST = Decimal.Parse(txtCostService.Text);
            bool kq = srvBUS.edit(srv);
            if (kq == false)
                MessageBox.Show("Fail!");
            else
                MessageBox.Show("Sussces");
            this.loadData();
        }

        private void btDeleteService_Click(object sender, EventArgs e)
        {
            srvBUS = new ServiceBUS();

            ServiceDTO srv = new ServiceDTO();
            srv.IDS = txtNameService.Text;
            srv.NAME = txtNameService.Text;
            srv.KIND = txtKindService.Text;
            srv.COST = Decimal.Parse(txtCostService.Text);
            bool kq = srvBUS.delete(srv);
            if (kq == false)
                MessageBox.Show("Fail!");
            else
                MessageBox.Show("Sussces");
            this.loadData();
        }

        private void btLoadService_Click(object sender, EventArgs e)
        {
            if (txtSearchService1.Text == "")
            {
                this.loadData();
            }
            else
            {
                string Key = txtSearchService1.Text.Trim();
                if (Key == null || Key == string.Empty || Key.Length == 0)
                {
                    List<ServiceDTO> listTimKiem = srvBUS.select();
                    this.loadData(listTimKiem);
                }
                else
                {
                    List<ServiceDTO> listTimKiem = srvBUS.search(Key);
                    this.loadData(listTimKiem);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txtSearchRoomService.Text == "")
            {
                this.loadDataRoomService();
            }
            else
            {
                string Key = txtSearchRoomService.Text.Trim();
                if (Key == null || Key == string.Empty || Key.Length == 0)
                {
                    List<RoomServiceDTO> listTimKiem = rsrvBus.select();
                    this.loadDataRoomService(listTimKiem);
                }
                else
                {
                    List<RoomServiceDTO> listTimKiem = rsrvBus.search(Key);
                    this.loadDataRoomService(listTimKiem);
                }
            }
        }
    }
}
