using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using roomBUS;
using roomDAO;
using roomDTO;

namespace QuanLyHotel
{
    public partial class RoomWindow : UserControl
    {
        public RoomWindow()
        {
            InitializeComponent();
            this.loadData();
        }

        
        private void loadData()
        {
            RoomBUS rmBus = new RoomBUS();
            List<RoomDTO> list = rmBus.select();

            if (list == null)
            {
                MessageBox.Show("Fail");
                return;
            }
            dtgvRoom.Columns.Clear();
            dtgvRoom.DataSource = null;

            dtgvRoom.AutoGenerateColumns = false;
            dtgvRoom.AllowUserToAddRows = false;
            dtgvRoom.DataSource = list;


            DataGridViewTextBoxColumn nAME = new DataGridViewTextBoxColumn();
            nAME.Name = "name";
            nAME.HeaderText = "Name:";
            nAME.DataPropertyName = "name";
            nAME.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvRoom.Columns.Add(nAME);

            DataGridViewTextBoxColumn gENDER = new DataGridViewTextBoxColumn();
            gENDER.Name = "status";
            gENDER.HeaderText = "Status";
            gENDER.DataPropertyName = "status";
            gENDER.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvRoom.Columns.Add(gENDER);

            DataGridViewTextBoxColumn eMAIL = new DataGridViewTextBoxColumn();
            eMAIL.Name = "bedamount";
            eMAIL.HeaderText = "Bed Amount";
            eMAIL.DataPropertyName = "bedamount";
            eMAIL.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvRoom.Columns.Add(eMAIL);

            DataGridViewTextBoxColumn pHONE = new DataGridViewTextBoxColumn();
            pHONE.Name = "roomkind";
            pHONE.HeaderText = "Room Kind";
            pHONE.DataPropertyName = "roomkind";
            pHONE.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvRoom.Columns.Add(pHONE);

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dtgvRoom.DataSource];
            myCurrencyManager.Refresh();
        }

        private void BtAddRoom_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            errorProvider2.Clear();
            errorProvider3.Clear();
            errorProvider4.Clear();

            if (txtNameRoom.Text == "")
            {
                errorProvider1.SetError(txtNameRoom, "not null!");
            }
            else if (txtKindRoom.Text == "")
            {
                errorProvider2.SetError(txtKindRoom, "not null!");
            }
            else if (txtBedsAmount.Text == "")
            {
                errorProvider3.SetError(txtBedsAmount, "not null!");
            }
            else if (txtCost.Text=="")
            {
                errorProvider4.SetError(txtCost, "not null!");
            }

            else
            {
                RoomBUS rmBUS = new RoomBUS();
                RoomDTO rm = new RoomDTO();
                rm.Name = txtNameRoom.Text;
                rm.Roomkind = txtKindRoom.Text;
                rm.Status = "Empty";
                rm.Bedamount = int.Parse(txtBedsAmount.Text);
                rm.Cost = Decimal.Parse(txtCost.Text);
                bool kq = rmBUS.add(rm);
                if (kq == false)
                    MessageBox.Show("Fail!");
                else
                    MessageBox.Show("Sussces");
                this.loadData();
            }
        }

        private void BtEditRoom_Click(object sender, EventArgs e)
        {
            RoomBUS rmBUS = new RoomBUS();
            RoomDTO rm = new RoomDTO();
            rm.Name = txtNameRoom.Text;
            rm.Roomkind = txtKindRoom.Text;
            rm.Status = "Trống";
            rm.Bedamount = int.Parse(txtBedsAmount.Text);
            rm.Cost = Decimal.Parse(txtCost.Text);
            bool kq = rmBUS.edit(rm);
            if (kq == false)
                MessageBox.Show("Fail!");
            else
                MessageBox.Show("Sussces");
            this.loadData();
        }

        private void BtDeleteRoom_Click(object sender, EventArgs e)
        {
            RoomBUS rmBUS = new RoomBUS();
            RoomDTO rm = new RoomDTO();
            rm.Name = txtNameRoom.Text;
            rm.Roomkind = txtKindRoom.Text;
            rm.Status = "Trống";
            rm.Bedamount = int.Parse(txtBedsAmount.Text);
            rm.Cost = Decimal.Parse(txtCost.Text);
            bool kq = rmBUS.delete(rm);
            if (kq == false)
                MessageBox.Show("Fail!");
            else
                MessageBox.Show("Sussces");
            this.loadData();
        }

        private void dtgvRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            txtNameRoom.Text = dtgvRoom.Rows[numrow].Cells[1].Value.ToString();
            txtKindRoom.Text = dtgvRoom.Rows[numrow].Cells[2].Value.ToString();
            txtBedsAmount.Text = dtgvRoom.Rows[numrow].Cells[3].Value.ToString();
            txtCost.Text = dtgvRoom.Rows[numrow].Cells[4].Value.ToString();
        }

        private void TxtBedsAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            int keydown = e.KeyChar;
            if (keydown > 57 || (keydown < 48 && keydown > 9 && keydown < 7))
            {
                errorProvider5.SetError(txtBedsAmount, "Không được nhập chữ");
                e.KeyChar = (char)0;
            }
            else
            {
                errorProvider5.Clear();
            }
        }

        private void TxtCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            int keydown = e.KeyChar;
            if (keydown > 57 || (keydown < 48 && keydown > 9 && keydown < 7))
            {
                errorProvider6.SetError(txtBedsAmount, "Không được nhập chữ");
                e.KeyChar = (char)0;
            }
            else
            {
                errorProvider6.Clear();
            }
        }
    }
}
