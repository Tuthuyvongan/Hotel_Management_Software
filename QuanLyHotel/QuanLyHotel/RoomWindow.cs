using kindRoomBUS;
using kindRoomDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using roomDTO;
using roomBUS;


namespace QuanLyHotel
{
    public partial class RoomWindow : UserControl
    {
        public RoomWindow()
        {
            InitializeComponent();
            this.loadDataKindRoom();
            this.loadDataRoom();
        }
        //Room
        private void loadDataRoom()
        {
            RoomBUS rmBus = new RoomBUS();
            List<RoomDTO> list = rmBus.select();

            if (list == null)
            {
                MessageBox.Show("Fail");
                return;
            }
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = null;

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DataSource = list;

            DataGridViewTextBoxColumn iD = new DataGridViewTextBoxColumn();
            iD.Name = "iDR";
            iD.HeaderText = "ID";
            iD.DataPropertyName = "iDR";
            iD.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns.Add(iD);

            DataGridViewTextBoxColumn iDK = new DataGridViewTextBoxColumn();
            iDK.Name = "iDRK";
            iDK.HeaderText = "IDK";
            iDK.DataPropertyName = "iDRK";
            iDK.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns.Add(iDK);

            DataGridViewTextBoxColumn nAME = new DataGridViewTextBoxColumn();
            nAME.Name = "nAME";
            nAME.HeaderText = "Name:";
            nAME.DataPropertyName = "nAME";
            nAME.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns.Add(nAME);

            DataGridViewTextBoxColumn sTATUS = new DataGridViewTextBoxColumn();
            sTATUS.Name = "sTATUS";
            sTATUS.HeaderText = "Status";
            sTATUS.DataPropertyName = "sTATUS";
            sTATUS.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns.Add(sTATUS);

            DataGridViewTextBoxColumn COST = new DataGridViewTextBoxColumn();
            COST.Name = "cOST";
            COST.HeaderText = "COST";
            COST.DataPropertyName = "cOST";
            COST.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns.Add(COST);

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataGridView1.DataSource];
            myCurrencyManager.Refresh();

        }
        private void btLoadRoom_Click(object sender, EventArgs e)
        {
            this.loadDataRoom();
        }
        private void BtAddRoom_Click(object sender, EventArgs e)
        {
            
            errorProvider1.Clear();
            errorProvider2.Clear();          
            errorProvider3.Clear();
           
           if(txtNameRoom.Text=="")
            {
                errorProvider1.SetError(txtNameRoom, "not null!");
            }
           else if(txtKindRoom.Text=="")
            {
                errorProvider2.SetError(txtKindRoom, "not null!");
            }
          
           else if(txtCostRoom.Text=="")
            {
                errorProvider3.SetError(txtCostRoom, "not null!");
            }
           else
            {
                RoomBUS rmBus = new RoomBUS();
                RoomDTO rm = new RoomDTO();
                rm.IDR = txtNameRoom.Text+"@"+txtKindRoom+"$"+txtCostRoom;
                rm.COST = decimal.Parse(txtCostRoom.Text);
                rm.NAME = txtNameRoom.Text;
                rm.IDRK = txtKindRoom.Text;
                rm.STATUS = "Trống";
                bool kq = rmBus.add(rm);
                if(kq==false)
                    MessageBox.Show("Fail!");
                else
                    MessageBox.Show("Sussces");
                this.loadDataRoom();
            }
            txtCostRoom.Text = "";
            txtNameRoom.Text = "";
            txtKindRoom.Text = "";
        }
        private void BtEditRoom_Click(object sender, EventArgs e)
        {
            RoomBUS rmBus = new RoomBUS();
            RoomDTO rm = new RoomDTO();
            rm.IDR = txtNameRoom.Text + "@" + txtKindRoom + "$" + txtCostRoom;
            rm.COST = decimal.Parse(txtCostRoom.Text);
            rm.NAME = txtNameRoom.Text;
            rm.IDRK = txtKindRoom.Text;
            rm.STATUS = "Trống";

            bool kq = rmBus.edit(rm);
            if (kq == false)
                MessageBox.Show("Fail!");
            else
                MessageBox.Show("Sussces");
            this.loadDataRoom();
        }
        private void btDeleteRoom_Click(object sender, EventArgs e)
        {
            RoomBUS rmBus = new RoomBUS();
            RoomDTO rm = new RoomDTO();
            rm.IDR = txtNameRoom.Text + "@" + txtKindRoom + "$" + txtCostRoom;
            rm.COST = decimal.Parse(txtCostRoom.Text);
            rm.NAME = txtNameRoom.Text;
            rm.IDRK = txtKindRoom.Text;
            rm.STATUS = "Trống";
            bool kq = rmBus.delete(rm);
            if (kq == false)
                MessageBox.Show("Fail!");
            else
                MessageBox.Show("Sussces");
            this.loadDataRoom();

        }

        private void BtRoom_Click(object sender, EventArgs e)
        {

        }


        //Kind Room
        private void loadDataKindRoom()
        {
            RoomBUS rmBus = new RoomBUS();
            List<RoomDTO> list = rmBus.select();

            if (list == null)
            {
                MessageBox.Show("Fail");
                return;
            }
            dataGridView2.Columns.Clear();
            dataGridView2.DataSource = null;

            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.DataSource = list;

            DataGridViewTextBoxColumn iD = new DataGridViewTextBoxColumn();
            iD.Name = "iDKR";
            iD.HeaderText = "ID";
            iD.DataPropertyName = "iDKR";
            iD.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView2.Columns.Add(iD);

            DataGridViewTextBoxColumn nAME = new DataGridViewTextBoxColumn();
            nAME.Name = "nAME";
            nAME.HeaderText = "Name:";
            nAME.DataPropertyName = "nAME";
            nAME.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView2.Columns.Add(nAME);

            DataGridViewTextBoxColumn BedsAMOUNT = new DataGridViewTextBoxColumn();
            BedsAMOUNT.Name = "bedsAMOUNT";
            BedsAMOUNT.HeaderText = "Beds Amout";
            BedsAMOUNT.DataPropertyName = "bedsAMOUNT";
            BedsAMOUNT.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView2.Columns.Add(BedsAMOUNT);

            DataGridViewTextBoxColumn NOTE = new DataGridViewTextBoxColumn();
            NOTE.Name = "nOTE";
            NOTE.HeaderText = "NOTE";
            NOTE.DataPropertyName = "nOTE";
            NOTE.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView2.Columns.Add(NOTE);

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataGridView2.DataSource];
            myCurrencyManager.Refresh();


        }
        private void BtLoadKindRoom_Click(object sender, EventArgs e)
        {
            this.loadDataKindRoom();
        }
        private void BtAddKindRoom_Click(object sender, EventArgs e)
        {

            errorProvider4.Clear();
            errorProvider5.Clear();
            errorProvider6.Clear();

            if (txtNameKindRoom.Text == "")
            {
                errorProvider1.SetError(txtNameKindRoom, "not null!");
            }
            else if (txtBedAmount.Text == "")
            {
                errorProvider2.SetError(txtBedAmount, "not null!");
            }

            else if (txtNote.Text == "")
            {
                errorProvider3.SetError(txtNote, "not null!");
            }
            else
            {
                KindRoomBUS rmBus = new KindRoomBUS();
                KindRoomDTO rm = new KindRoomDTO();
                rm.IDKR = txtNameKindRoom.Text + "$" + txtBedAmount.Text;
                rm.BedsAMOUNT = int.Parse(txtCostRoom.Text);
                rm.NAME = txtNameKindRoom.Text;
                rm.NOTE = txtNote.Text;
                bool kq = rmBus.add(rm);
                if (kq == false)
                    MessageBox.Show("Fail!");
                else
                    MessageBox.Show("Sussces");
                this.loadDataKindRoom();
            }
            txtNameKindRoom.Text = "";
            txtBedAmount.Text = "";
            txtNote.Text = "";
        }
        private void BtEditKindRoom_Click(object sender, EventArgs e)
        {
            KindRoomBUS rmBus = new KindRoomBUS();
            KindRoomDTO rm = new KindRoomDTO();
            rm.IDKR = txtNameKindRoom.Text + "$" + txtBedAmount.Text;
            rm.BedsAMOUNT = int.Parse(txtCostRoom.Text);
            rm.NAME = txtNameKindRoom.Text;
            rm.NOTE = txtNote.Text;

            bool kq = rmBus.edit(rm);
            if (kq == false)
                MessageBox.Show("Fail!");
            else
                MessageBox.Show("Sussces");
            this.loadDataKindRoom();
        }
        private void BtDeleteKindRoom_Click(object sender, EventArgs e)
        {
            KindRoomBUS rmBus = new KindRoomBUS();
            KindRoomDTO rm = new KindRoomDTO();
            rm.IDKR = txtNameKindRoom.Text + "$" + txtBedAmount.Text;
            rm.BedsAMOUNT = int.Parse(txtCostRoom.Text);
            rm.NAME = txtNameKindRoom.Text;
            rm.NOTE = txtNote.Text;
            bool kq = rmBus.delete(rm);
            if (kq == false)
                MessageBox.Show("Fail!");
            else
                MessageBox.Show("Sussces");
            this.loadDataKindRoom();
        }
    }
}
