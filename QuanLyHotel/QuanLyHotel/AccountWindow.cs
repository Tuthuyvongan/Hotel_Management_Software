using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using userBUS;
using userDTO;

namespace QuanLyHotel
{
    public partial class AccountWindow : UserControl
    {
        public AccountWindow()
        {
            InitializeComponent();
            this.loadData();
        }
        private void loadData()
        {
            UserBUS ctmBus = new UserBUS();
            List<UserDTO> list = ctmBus.select();

            if (list == null)
            {
                MessageBox.Show("Fail");
                return;
            }
            dtgvAccount.Columns.Clear();
            dtgvAccount.DataSource = null;

            dtgvAccount.AutoGenerateColumns = false;
            dtgvAccount.AllowUserToAddRows = false;
            dtgvAccount.DataSource = list;

            DataGridViewTextBoxColumn ID = new DataGridViewTextBoxColumn();
            ID.Name = "idm";
            ID.HeaderText = "Username";
            ID.DataPropertyName = "idm";
            ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvAccount.Columns.Add(ID);

            DataGridViewTextBoxColumn PassWord = new DataGridViewTextBoxColumn();
            PassWord.Name = "pasword";
            PassWord.HeaderText = "PassWord";
            PassWord.DataPropertyName = "password";
            PassWord.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvAccount.Columns.Add(PassWord);

            DataGridViewTextBoxColumn NAME = new DataGridViewTextBoxColumn();
            NAME.Name = "name";
            NAME.HeaderText = "Name:";
            NAME.DataPropertyName = "name";
            NAME.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvAccount.Columns.Add(NAME);

            DataGridViewTextBoxColumn Gender = new DataGridViewTextBoxColumn();
            Gender.Name = "gender";
            Gender.HeaderText = "Gender";
            Gender.DataPropertyName = "gender";
            Gender.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvAccount.Columns.Add(Gender);

            DataGridViewTextBoxColumn CMND = new DataGridViewTextBoxColumn();
            CMND.Name = "cmnd";
            CMND.HeaderText = "Identify card";
            CMND.DataPropertyName = "cmnd";
            CMND.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvAccount.Columns.Add(CMND);

            DataGridViewTextBoxColumn pHONE = new DataGridViewTextBoxColumn();
            pHONE.Name = "phone";
            pHONE.HeaderText = "PHONE";
            pHONE.DataPropertyName = "phone";
            pHONE.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvAccount.Columns.Add(pHONE);

            DataGridViewTextBoxColumn Email = new DataGridViewTextBoxColumn();
            Email.Name = "email";
            Email.HeaderText = "Email";
            Email.DataPropertyName = "email";
            Email.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvAccount.Columns.Add(Email);

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dtgvAccount.DataSource];
            myCurrencyManager.Refresh();


        }

        private void BtLoadAccount_Click(object sender, EventArgs e)
        {
            
            this.loadData();
            
        }

        private void BtEditAccount_Click(object sender, EventArgs e)
        {
            UserBUS ctmBUS = new UserBUS();
            UserDTO ctm = new UserDTO();
            ctm.Idm = ctm.Idm;
            ctm.Password = ctm.Password;
            ctm.Name = lbName.Text;
            ctm.Phone = lbPhone.Text;
            ctm.Email = lbEmail.Text;
            ctm.Cmnd = lbCmnd.Text;
            ctm.Level = ctm.Level;
            ctm.Gender = lbGender.Text;
            bool kq = ctmBUS.edit(ctm);
            if (kq == false)
                MessageBox.Show("Fail!");
            else
                MessageBox.Show("Sussces");
            this.loadData();
        }

        private void BtDeleteAcount_Click(object sender, EventArgs e)
        {
            UserBUS ctmBUS = new UserBUS();
            UserDTO ctm = new UserDTO();
            ctm.Idm = ctm.Idm;
            ctm.Password = ctm.Password;
            ctm.Name = lbName.Text;
            ctm.Phone = lbPhone.Text;
            ctm.Email = lbEmail.Text;
            ctm.Cmnd = lbCmnd.Text;
            ctm.Level = ctm.Level;
            ctm.Gender = lbGender.Text;
            bool kq = ctmBUS.delete(ctm);
            if (kq == false)
                MessageBox.Show("Fail!");
            else
                MessageBox.Show("Sussces");
            this.loadData();
        }
    }
}
