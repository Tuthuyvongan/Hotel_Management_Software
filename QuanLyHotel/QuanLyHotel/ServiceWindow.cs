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
            dataGridView3.Columns.Clear();
            dataGridView3.DataSource = null;

            dataGridView3.AutoGenerateColumns = false;
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.DataSource = list;

            DataGridViewTextBoxColumn iD = new DataGridViewTextBoxColumn();
            iD.Name = "iDS";
            iD.HeaderText = "ID";
            iD.DataPropertyName = "iDS";
            iD.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView3.Columns.Add(iD);

            DataGridViewTextBoxColumn nAME = new DataGridViewTextBoxColumn();
            nAME.Name = "nAME";
            nAME.HeaderText = "Name:";
            nAME.DataPropertyName = "nAME";
            nAME.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView3.Columns.Add(nAME);

            DataGridViewTextBoxColumn kIND = new DataGridViewTextBoxColumn();
            kIND.Name = "kINd";
            kIND.HeaderText = "KIND";
            kIND.DataPropertyName = "kINd";
            kIND.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView3.Columns.Add(kIND);

            DataGridViewTextBoxColumn cOST = new DataGridViewTextBoxColumn();
            cOST.Name = "cOST";
            cOST.HeaderText = "COST";
            cOST.DataPropertyName = "cOST";
            cOST.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView3.Columns.Add(cOST);

            DataGridViewTextBoxColumn nOTE = new DataGridViewTextBoxColumn();
            nOTE.Name = "nOTE";
            nOTE.HeaderText = "NOTE";
            nOTE.DataPropertyName = "nOTE";
            nOTE.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView3.Columns.Add(nOTE);

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataGridView3.DataSource];
            myCurrencyManager.Refresh();


        }
        private void BtAddService_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            errorProvider2.Clear();
            errorProvider3.Clear();
            errorProvider4.Clear();
            errorProvider5.Clear();
            if (txtIDService.Text == "")
            {
                errorProvider1.SetError(txtIDService, "not null!");
            }
            else if (txtNameService.Text == "")
            {
                errorProvider2.SetError(txtNameService, "not null!");
            }
            else if (txtKindService.Text == "")
            {
                errorProvider3.SetError(txtKindService, "not null!");
            }
            else if (txtCostService.Text == "")
            {
                errorProvider4.SetError(txtCostService, "not null!");
            }
            else if (txtNoteService.Text == "")
            {
                errorProvider5.SetError(txtNoteService, "not null!");
            }
            else
            {
                ServiceBUS srvBUS = new ServiceBUS();
                ServiceDTO srv = new ServiceDTO();
                srv.IDS = int.Parse(txtIDService.Text);
                srv.NAME = txtNameService.Text;
                srv.KIND = txtKindService.Text;
                srv.COST = Decimal.Parse(txtCostService.Text);
                srv.NOTE = txtNoteService.Text;
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
            srv.IDS = int.Parse(txtIDService.Text);
            srv.NAME = txtNameService.Text;
            srv.KIND = txtKindService.Text;
            srv.COST = Decimal.Parse(txtCostService.Text);
            srv.NOTE = txtNoteService.Text;
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
            srv.IDS = int.Parse(txtIDService.Text);
            srv.NAME = txtNameService.Text;
            srv.KIND = txtKindService.Text;
            srv.COST = Decimal.Parse(txtCostService.Text);
            srv.NOTE = txtNoteService.Text;
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
