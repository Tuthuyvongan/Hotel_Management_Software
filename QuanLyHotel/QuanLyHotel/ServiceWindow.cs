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


namespace QuanLyHotel
{
    public partial class ServiceWindow : UserControl
    {
        public ServiceWindow()
        {
            InitializeComponent();
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

        
    }
}
