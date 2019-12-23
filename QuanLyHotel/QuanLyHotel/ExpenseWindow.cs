using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using expenseBUS;
using expenseDTO;

namespace QuanLyHotel
{
    public partial class ExpenseWindow : UserControl
    {
        public ExpenseWindow()
        {
            InitializeComponent();
        }
        private ExpenseBUS expenseBUS;
        //
        // LOAD DATA
        //
        #region Load Data
        private void loadData()
        {
            expenseBUS = new ExpenseBUS();
            List<ExpenseDTO> list = expenseBUS.select();

            if (list == null)
            {
                MessageBox.Show("Fail");
                return;
            }
            dtgvExpense.Columns.Clear();
            dtgvExpense.DataSource = null;

            dtgvExpense.AutoGenerateColumns = false;
            dtgvExpense.AllowUserToAddRows = false;
            dtgvExpense.DataSource = list;

            DataGridViewTextBoxColumn NAME = new DataGridViewTextBoxColumn();
            NAME.Name = "name";
            NAME.HeaderText = "Name:";
            NAME.DataPropertyName = "name";
            NAME.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvExpense.Columns.Add(NAME);

            DataGridViewTextBoxColumn KIND = new DataGridViewTextBoxColumn();
            KIND.Name = "kind";
            KIND.HeaderText = "Kind";
            KIND.DataPropertyName = "kind";
            KIND.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvExpense.Columns.Add(KIND);

            DataGridViewTextBoxColumn DATE = new DataGridViewTextBoxColumn();
            DATE.Name = "date";
            DATE.HeaderText = "Date";
            DATE.DataPropertyName = "date";
            DATE.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvExpense.Columns.Add(DATE);

            DataGridViewTextBoxColumn COST = new DataGridViewTextBoxColumn();
            COST.Name = "cost";
            COST.HeaderText = "Cost";
            COST.DataPropertyName = "cost";
            COST.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvExpense.Columns.Add(COST);


            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dtgvExpense.DataSource];
            myCurrencyManager.Refresh();


        }
        private void loadData(List<ExpenseDTO> list)
        {

            if (list == null)
            {
                MessageBox.Show("Fail");
                return;
            }
            dtgvExpense.Columns.Clear();
            dtgvExpense.DataSource = null;

            dtgvExpense.AutoGenerateColumns = false;
            dtgvExpense.AllowUserToAddRows = false;
            dtgvExpense.DataSource = list;

            DataGridViewTextBoxColumn NAME = new DataGridViewTextBoxColumn();
            NAME.Name = "name";
            NAME.HeaderText = "Name:";
            NAME.DataPropertyName = "name";
            NAME.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvExpense.Columns.Add(NAME);

            DataGridViewTextBoxColumn KIND = new DataGridViewTextBoxColumn();
            KIND.Name = "kind";
            KIND.HeaderText = "Kind";
            KIND.DataPropertyName = "kind";
            KIND.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvExpense.Columns.Add(KIND);

            DataGridViewTextBoxColumn DATE = new DataGridViewTextBoxColumn();
            DATE.Name = "date";
            DATE.HeaderText = "Date";
            DATE.DataPropertyName = "date";
            DATE.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvExpense.Columns.Add(DATE);

            DataGridViewTextBoxColumn COST = new DataGridViewTextBoxColumn();
            COST.Name = "cost";
            COST.HeaderText = "Cost";
            COST.DataPropertyName = "cost";
            COST.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvExpense.Columns.Add(COST);


            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dtgvExpense.DataSource];
            myCurrencyManager.Refresh();
        }
        #endregion
        //
        // EVENT
        //
        #region Event
        private void TxtCostExpense_KeyPress(object sender, KeyPressEventArgs e)
        {
            int keydown = e.KeyChar;
            if (keydown > 57 || (keydown < 48 && keydown > 9 && keydown < 7))
            {
                errorProvider4.SetError(txtCostExpense, "Không được nhập chữ");
                e.KeyChar = (char)0;
            }
            else
            {
                errorProvider4.Clear();
            }
        }

        private void BtLoadExpense_Click(object sender, EventArgs e)
        {
            if (txtSearchExpense.Text == "")
            {
                this.loadData();
            }
            else
            {
                string Key = txtSearchExpense.Text.Trim();
                if (Key == null || Key == string.Empty || Key.Length == 0)
                {
                    List<ExpenseDTO> listTimKiem = expenseBUS.select();
                    this.loadData(listTimKiem);
                }
                else
                {
                    List<ExpenseDTO> listTimKiem = expenseBUS.search(Key);
                    this.loadData(listTimKiem);
                }
            }
        }

        private void BtAddExpense_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            errorProvider2.Clear();
            errorProvider3.Clear();


            if (txtNameExpense.Text == "")
            {
                errorProvider1.SetError(txtNameExpense, "not null!");
            }
            else if (txtKindExpense.Text == "")
            {
                errorProvider2.SetError(txtKindExpense, "not null!");
            }
            else if (txtCostExpense.Text == "")
            {
                errorProvider3.SetError(txtCostExpense, "not null!");
            }


            else
            {
                expenseBUS = new ExpenseBUS();

                ExpenseDTO srv = new ExpenseDTO();
                srv.IDE = txtNameExpense.Text;
                srv.NAME = txtNameExpense.Text;
                srv.KIND = txtKindExpense.Text;
                srv.DATE = DateTime.Parse(dtDateExpense.Text);
                srv.COST = Decimal.Parse(txtCostExpense.Text);
                bool kq = expenseBUS.add(srv);
                if (kq == false)
                    MessageBox.Show("Fail!");
                else
                    MessageBox.Show("Sussces");
                this.loadData();
            }
        }

        private void BtEditExpense_Click(object sender, EventArgs e)
        {
            expenseBUS = new ExpenseBUS();

            ExpenseDTO srv = new ExpenseDTO();
            srv.IDE = txtNameExpense.Text;
            srv.NAME = txtNameExpense.Text;
            srv.KIND = txtKindExpense.Text;
            srv.DATE = DateTime.Parse(dtDateExpense.Text);
            srv.COST = Decimal.Parse(txtCostExpense.Text);
            bool kq = expenseBUS.edit(srv);
            if (kq == false)
                MessageBox.Show("Fail!");
            else
                MessageBox.Show("Sussces");
            this.loadData();
        }

        private void BtDeleteExpense_Click(object sender, EventArgs e)
        {
            expenseBUS = new ExpenseBUS();

            ExpenseDTO srv = new ExpenseDTO();
            srv.IDE = txtNameExpense.Text;
            srv.NAME = txtNameExpense.Text;
            srv.KIND = txtKindExpense.Text;
            srv.DATE = DateTime.Parse(dtDateExpense.Text);
            srv.COST = Decimal.Parse(txtCostExpense.Text);
            bool kq = expenseBUS.delete(srv);
            if (kq == false)
                MessageBox.Show("Fail!");
            else
                MessageBox.Show("Sussces");
            this.loadData();
        }
        #endregion


    }
}
