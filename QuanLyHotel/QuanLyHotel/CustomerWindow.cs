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
            //loadData();
        }
        private CustomerBUS ctmBUS;

        //
        //---- LOAD DATA
        //
        #region Load Data
        private void loadData()
        {
            ctmBUS = new CustomerBUS();
            List<CustomerDTO> list = ctmBUS.select();

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

            //DataGridViewTextBoxColumn ID = new DataGridViewTextBoxColumn();
            //ID.Name = "idc";
            //ID.HeaderText = "ID";
            //ID.DataPropertyName = "idc";
            //ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //dtgvCustomer.Columns.Add(ID);

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
        private void loadData(List<CustomerDTO> list)
        {
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

            //DataGridViewTextBoxColumn ID = new DataGridViewTextBoxColumn();
            //ID.Name = "idc";
            //ID.HeaderText = "ID";
            //ID.DataPropertyName = "idc";
            //ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //dtgvCustomer.Columns.Add(ID);

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
        #endregion
        //
        //---- EVENTS
        //
        #region Events
        private void BtLoadCustomer_Click(object sender, EventArgs e)
        {
            this.loadData();

        }
        private void dtgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            txtNameCustomer.Text = dtgvCustomer.Rows[numrow].Cells[0].Value.ToString();
            txtIdentifyCardCustomer.Text = dtgvCustomer.Rows[numrow].Cells[2].Value.ToString();
            txtPhoneCustomer.Text = dtgvCustomer.Rows[numrow].Cells[3].Value.ToString();
            dtBirthday.Text = Convert.ToString(dtgvCustomer.Rows[numrow].Cells[1].Value);
        }

        private void TxtPhoneCustomer_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            int keydown = e.KeyChar;
            if (keydown > 57 || (keydown < 48 && keydown > 9 && keydown < 7))
            {
                errorProvider5.SetError(txtPhoneCustomer, "Không được nhập chữ");
                e.KeyChar = (char)0;
            }
            else
            {
                errorProvider5.Clear();
            }
        }

        private void btLoadCustomer_Click_1(object sender, EventArgs e)
        {
            if (txtSearchCustomer.Text == "")
            {
                this.loadData();
            }
            else
            {
                string Key = txtSearchCustomer.Text.Trim();
                if (Key == null || Key == string.Empty || Key.Length == 0)
                {
                    List<CustomerDTO> listTimKiem = ctmBUS.select();
                    this.loadData(listTimKiem);
                }
                else
                {
                    List<CustomerDTO> listTimKiem = ctmBUS.search(Key);
                    this.loadData(listTimKiem);
                }
            }
        }

        private void btAddCustomer_Click_1(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            errorProvider2.Clear();
            errorProvider3.Clear();
            //errorProvider4.Clear();

            if (txtNameCustomer.Text == "")
            {
                errorProvider1.SetError(txtNameCustomer, "not null!");
            }
            else if (txtIdentifyCardCustomer.Text == "")
            {
                errorProvider2.SetError(txtIdentifyCardCustomer, "not null!");
            }
            else if (txtPhoneCustomer.Text == "")
            {
                errorProvider3.SetError(txtPhoneCustomer, "not null!");
            }
            //else if (dtBirthday)
            //{
            //    errorProvider4.SetError(txtGenderCustomer, "not null!");
            //}

            else
            {
                ctmBUS = new CustomerBUS();
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
            }
        }

        private void btEditCustomer_Click_1(object sender, EventArgs e)
        {
            ctmBUS = new CustomerBUS();
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

        private void btDeleteCustomer_Click_1(object sender, EventArgs e)
        {
            ctmBUS = new CustomerBUS();
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
        #endregion
    }
}
