using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using customerBUS;
//using customerDTO;

namespace QuanLyHotel
{
    public partial class CustomerWindow : UserControl
    {
     
        public CustomerWindow()
        {
            InitializeComponent();
            
        }

        //private void loadData()
        //{
        //    CustomerBUS ctmBus = new CustomerBUS();
        //    List<CustomerDTO> list = ctmBus.select();

        //    if (list == null)
        //    {
        //        MessageBox.Show("Fail");
        //        return;
        //    }
        //    dataGridView1.Columns.Clear();
        //    dataGridView1.DataSource = null;

        //    dataGridView1.AutoGenerateColumns = false;
        //    dataGridView1.AllowUserToAddRows = false;
        //    dataGridView1.DataSource = list;

        //    DataGridViewTextBoxColumn iD = new DataGridViewTextBoxColumn();
        //    iD.Name = "iDC";
        //    iD.HeaderText = "ID";
        //    iD.DataPropertyName = "iDC";
        //    iD.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        //    dataGridView1.Columns.Add(iD);

        //    DataGridViewTextBoxColumn nAME = new DataGridViewTextBoxColumn();
        //    nAME.Name = "nAME";
        //    nAME.HeaderText = "Name:";
        //    nAME.DataPropertyName = "nAME";
        //    nAME.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        //    dataGridView1.Columns.Add(nAME);

        //    DataGridViewTextBoxColumn gENDER = new DataGridViewTextBoxColumn();
        //    gENDER.Name = "gENDER";
        //    gENDER.HeaderText = "GENDER";
        //    gENDER.DataPropertyName = "gENDER";
        //    gENDER.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        //    dataGridView1.Columns.Add(gENDER);

        //    DataGridViewTextBoxColumn eMAIL = new DataGridViewTextBoxColumn();
        //    eMAIL.Name = "eMAIL";
        //    eMAIL.HeaderText = "EMAIL";
        //    eMAIL.DataPropertyName = "eMAIL";
        //    eMAIL.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        //    dataGridView1.Columns.Add(eMAIL);

        //    DataGridViewTextBoxColumn pHONE = new DataGridViewTextBoxColumn();
        //    pHONE.Name = "phoneNUMBER";
        //    pHONE.HeaderText = "PHONE";
        //    pHONE.DataPropertyName = "phoneNUMBER";
        //    pHONE.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        //    dataGridView1.Columns.Add(pHONE);

        //    //DataGridViewTextBoxColumn aDDRESS = new DataGridViewTextBoxColumn();
        //    //aDDRESS.Name = "aDDRESS";
        //    //aDDRESS.HeaderText = "ADDRESS";
        //    //aDDRESS.DataPropertyName = "aDDRESS";
        //    //aDDRESS.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        //    //dataGridView1.Columns.Add(aDDRESS);

        //    CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataGridView1.DataSource];
        //    myCurrencyManager.Refresh();


        //}

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
            //    CustomerBUS ctmBUS = new CustomerBUS();
            //    CustomerDTO ctm = new CustomerDTO();
            //    ctm.IDC = txtIdentifyCardCustomer+"@"+ txtEmailCustomer+"$"+ txtPhoneCustomer;
            //    ctm.NAME = txtNameCustomer.Text;
            //    ctm.GENDER = txtNameCustomer.Text;
            //    ctm.BIRTHDAY = DateTime.Parse(dtBirthday.Text);
            //    ctm.ADDRESS = txtAddressCustomer.Text;
            //    ctm.IdentifyCARD = txtIdentifyCardCustomer.Text;
            //    ctm.EMAIL = txtEmailCustomer.Text;
            //    ctm.PhoneNUMBER = txtPhoneCustomer.Text;
            //    bool kq = ctmBUS.add(ctm);
            //    if (kq == false)
            //        MessageBox.Show("Fail!");
            //    else
            //        MessageBox.Show("Sussces");
            //    this.loadData();
            //}
        }

        private void BtEditCustomer_Click(object sender, EventArgs e)
        {
            //CustomerBUS ctmBUS = new CustomerBUS();
            //CustomerDTO ctm = new CustomerDTO();
            //ctm.IDC = txtIdentifyCardCustomer + "@" + txtEmailCustomer + "$" + txtPhoneCustomer;
            //ctm.NAME = txtNameCustomer.Text;
            //ctm.GENDER = txtNameCustomer.Text;
            //ctm.BIRTHDAY = DateTime.Parse(dtBirthday.Text);
            //ctm.ADDRESS = txtAddressCustomer.Text;
            //ctm.IdentifyCARD = txtIdentifyCardCustomer.Text;
            //ctm.EMAIL = txtEmailCustomer.Text;
            //ctm.PhoneNUMBER = txtPhoneCustomer.Text;
            //bool kq = ctmBUS.edit(ctm);
            //if (kq == false)
            //    MessageBox.Show("Fail!");
            //else
            //    MessageBox.Show("Sussces");
            //this.loadData();
        }

        private void BtLoadCustomer_Click(object sender, EventArgs e)
        {
            //this.loadData();
            
        }

        private void BtDeleteCustomer_Click(object sender, EventArgs e)
        {
            //CustomerBUS ctmBUS = new CustomerBUS();
            //CustomerDTO ctm = new CustomerDTO();
            //ctm.IDC = txtIdentifyCardCustomer + "@" + txtEmailCustomer + "$" + txtPhoneCustomer;
            //ctm.NAME = txtNameCustomer.Text;
            //ctm.GENDER = txtNameCustomer.Text;
            //ctm.BIRTHDAY = DateTime.Parse(dtBirthday.Text);
            //ctm.ADDRESS = txtAddressCustomer.Text;
            //ctm.IdentifyCARD = txtIdentifyCardCustomer.Text;
            //ctm.EMAIL = txtEmailCustomer.Text;
            //ctm.PhoneNUMBER = txtPhoneCustomer.Text;
            //bool kq = ctmBUS.delete(ctm);
            //if (kq == false)
            //    MessageBox.Show("Fail!");
            //else
            //    MessageBox.Show("Sussces");
            //this.loadData();
        }
       
    }
}
