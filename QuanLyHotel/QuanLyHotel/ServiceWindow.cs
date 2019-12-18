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
            this.loadData();
            this.loadDataRoomService();
        }


        private void loadData()
        {
            ServiceBUS ctmBus = new ServiceBUS();
            List<ServiceDTO> list = ctmBus.select();

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
        private void BtAddService_Click(object sender, EventArgs e)
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
                ServiceBUS srvBUS = new ServiceBUS();
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

        private void BtEditService_Click(object sender, EventArgs e)
        {
            ServiceBUS srvBUS = new ServiceBUS();
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

        private void BtDeleteService_Click(object sender, EventArgs e)
        {
            ServiceBUS srvBUS = new ServiceBUS();
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

        private void BtLoadService_Click(object sender, EventArgs e)
        {
            this.loadData();
        }

        private void loadDataRoomService()
        {
            RoomServiceBUS ctmBus = new RoomServiceBUS();
            List<RoomServiceDTO> list = ctmBus.select();

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
    }
}
