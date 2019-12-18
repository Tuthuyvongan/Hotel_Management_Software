using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using customerBUS;
using customerDTO;

namespace QuanLyHotel
{
    public partial class CustomerWindow : UserControl
    {
     
        public CustomerWindow()
        {
            InitializeComponent();
            
        }

        private void loadData()
        {
            CustomerBUS ctmBus = new CustomerBUS();
            List<CustomerDTO> list = ctmBus.select();

            if (list == null)
            {
                MessageBox.Show("Fail");
                return;
            }
            dtgvCustomer.Columns.Clear();
            dtgvCustomer.DataSource = null;

            dtgvCustomer.AutoGenerateColumns = false;
            dtgvCustomer.AllowUserToAddRows = false;
            dtgvCustomer.DataSource = list;

            DataGridViewTextBoxColumn ID = new DataGridViewTextBoxColumn();
            ID.Name = "idc";
            ID.HeaderText = "ID";
            ID.DataPropertyName = "idc";
            ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvCustomer.Columns.Add(ID);

            DataGridViewTextBoxColumn NAME = new DataGridViewTextBoxColumn();
            NAME.Name = "name";
            NAME.HeaderText = "Name:";
            NAME.DataPropertyName = "name";
            NAME.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvCustomer.Columns.Add(NAME);

            DataGridViewTextBoxColumn DATE = new DataGridViewTextBoxColumn();
            DATE.Name = "date";
            DATE.HeaderText = "Date";
            DATE.DataPropertyName = "date";
            DATE.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvCustomer.Columns.Add(DATE);

            DataGridViewTextBoxColumn CMND = new DataGridViewTextBoxColumn();
            CMND.Name = "cmnd";
            CMND.HeaderText = "Identify card";
            CMND.DataPropertyName = "cmnd";
            CMND.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvCustomer.Columns.Add(CMND);

            DataGridViewTextBoxColumn pHONE = new DataGridViewTextBoxColumn();
            pHONE.Name = "phone";
            pHONE.HeaderText = "Phone";
            pHONE.DataPropertyName = "phone";
            pHONE.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvCustomer.Columns.Add(pHONE);

            

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dtgvCustomer.DataSource];
            myCurrencyManager.Refresh();


        }

        private void BtAddCustomer_Click(object sender, EventArgs e)
        {
            //errorProvider1.Clear();
            //errorProvider2.Clear();
            //errorProvider3.Clear();
            //errorProvider4.Clear();
            //errorProvider5.Clear();
            //errorProvider6.Clear();
            //errorProvider7.Clear();
            //errorProvider8.Clear();
            //if (txtIDCustomer.Text == "")
            //{
            //    errorProvider1.SetError(txtIDCustomer, "not null!");
            //}
            //else if (txtNameCustomer.Text == "")
            //{
            //    errorProvider2.SetError(txtNameCustomer, "not null!");
            //}
            //else if (txtGenderCustomer.Text == "")
            //{
            //    errorProvider3.SetError(txtGenderCustomer, "not null!");
            //}
            //else if (dtBirthday.Text >=)
            //{
            //    errorProvider4.SetError(txtGenderCustomer, "not null!");
            //}
            //else if (txtIdentifyCardCustomer.Text == "")
            //{
            //    errorProvider5.SetError(txtIdentifyCardCustomer, "not null!");
            //}
            //else if (txtAddressCustomer.Text == "")
            //{
            //    errorProvider6.SetError(txtAddressCustomer, "not null!");
            //}
            //else if (txtPhoneCustomer.Text == "")
            //{
            //    errorProvider7.SetError(txtPhoneCustomer, "not null!");
            //}
            //else if (txtEmailCustomer.Text == "")
            //{
            //    errorProvider8.SetError(txtEmailCustomer, "not null!");
            //}
            //else
            //{
            CustomerBUS ctmBUS = new CustomerBUS();
            CustomerDTO ctm = new CustomerDTO();
            ctm.IDC = txtNameCustomer.Text;
            ctm.NAME = txtNameCustomer.Text;
            ctm.PHONE = txtPhoneCustomer.Text;
            ctm.DATE = DateTime.Parse(dtBirthday.Text);
            ctm.CMND = txtIdentifyCardCustomer.Text;
            
            bool kq = ctmBUS.add(ctm);
            if (kq == false)
                MessageBox.Show("Fail!");
            else
                MessageBox.Show("Sussces");
            this.loadData();
            //}
        }

        private void BtEditCustomer_Click(object sender, EventArgs e)
        {
            CustomerBUS ctmBUS = new CustomerBUS();
            CustomerDTO ctm = new CustomerDTO();
            ctm.IDC = txtNameCustomer.Text;
            ctm.NAME = txtNameCustomer.Text;
            ctm.PHONE = txtPhoneCustomer.Text;
            ctm.DATE = DateTime.Parse(dtBirthday.Text);
            ctm.CMND = txtIdentifyCardCustomer.Text;
            bool kq = ctmBUS.edit(ctm);
            if (kq == false)
                MessageBox.Show("Fail!");
            else
                MessageBox.Show("Sussces");
            this.loadData();
        }

        private void BtLoadCustomer_Click(object sender, EventArgs e)
        {
            this.loadData();

        }

        private void BtDeleteCustomer_Click(object sender, EventArgs e)
        {
            CustomerBUS ctmBUS = new CustomerBUS();
            CustomerDTO ctm = new CustomerDTO();
            ctm.IDC = txtNameCustomer.Text;
            ctm.NAME = txtNameCustomer.Text;
            ctm.PHONE = txtPhoneCustomer.Text;
            ctm.DATE = DateTime.Parse(dtBirthday.Text);
            ctm.CMND = txtIdentifyCardCustomer.Text;
            bool kq = ctmBUS.delete(ctm);
            if (kq == false)
                MessageBox.Show("Fail!");
            else
                MessageBox.Show("Sussces");
            this.loadData();
        }

        private void dtgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            txtNameCustomer.Text = dtgvCustomer.Rows[numrow].Cells[1].Value.ToString();
            txtIdentifyCardCustomer.Text = dtgvCustomer.Rows[numrow].Cells[2].Value.ToString();
            txtPhoneCustomer.Text = dtgvCustomer.Rows[numrow].Cells[3].Value.ToString();
            dtBirthday.Text = dtgvCustomer.Rows[numrow].Cells[4].Value.ToString();
        }
    }
}
