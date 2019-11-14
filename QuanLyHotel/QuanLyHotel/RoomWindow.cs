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

            DataGridViewTextBoxColumn nBED = new DataGridViewTextBoxColumn();
            nBED.Name = "nBED";
            nBED.HeaderText = "Number of Bed";
            nBED.DataPropertyName = "nBED";
            nBED.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns.Add(nBED);
          

            DataGridViewTextBoxColumn nOTE = new DataGridViewTextBoxColumn();
            nOTE.Name = "nOTE";
            nOTE.HeaderText = "Note";
            nOTE.DataPropertyName = "nOTE";
            nOTE.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns.Add(nOTE);

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataGridView1.DataSource];
            myCurrencyManager.Refresh();


        }
        private void btLoadRoom_Click(object sender, EventArgs e)
        {
            this.loadData();
        }

        private void BtAddRoom_Click(object sender, EventArgs e)
        {
            
            errorProvider2.Clear();
            errorProvider3.Clear();          
            errorProvider5.Clear();
           
           if(txtStatusRoom.Text=="")
            {
                errorProvider2.SetError(txtStatusRoom, "not null!");
            }
           else if(txtCostRoom.Text=="")
            {
                errorProvider3.SetError(txtCostRoom, "not null!");
            }
          
           else if(txtNbedRoom.Text=="")
            {
                errorProvider5.SetError(txtNbedRoom, "not null!");
            }
           else
            {
                RoomBUS rmBus = new RoomBUS();
                RoomDTO rm = new RoomDTO();
                rm.IDR = int.Parse(txtIDRoom.Text);
                rm.COST = decimal.Parse(txtCostRoom.Text);
                rm.NAME = txtNameRoom.Text;
                rm.NBED = int.Parse(txtNbedRoom.Text);
                rm.NOTE = txtNoteKindRoom.Text;
                rm.STATUS = txtStatusRoom.Text;
                bool kq = rmBus.add(rm);
                if(kq==false)
                    MessageBox.Show("Fail!");
                else
                    MessageBox.Show("Sussces");
                this.loadData();
            }
            txtCostRoom.Text = "";
            txtIDRoom.Text = "";
            txtNameRoom.Text = "";
            txtNbedRoom.Text = "";
            txtNoteKindRoom.Text = "";
            txtStatusRoom.Text = "";

        }

        private void BtEditRoom_Click(object sender, EventArgs e)
        {
            RoomBUS rmBus = new RoomBUS();
            RoomDTO rm = new RoomDTO();
            rm.IDR = int.Parse(txtIDRoom.Text);
            rm.COST = decimal.Parse(txtCostRoom.Text);
            rm.NAME = txtNameRoom.Text;
            rm.NBED = int.Parse(txtNbedRoom.Text);
            rm.NOTE = txtNoteKindRoom.Text;
            rm.STATUS = txtStatusRoom.Text;
            bool kq = rmBus.edit(rm);
            if (kq == false)
                MessageBox.Show("Fail!");
            else
                MessageBox.Show("Sussces");
            this.loadData();
        }

        private void BtRoom_Click(object sender, EventArgs e)
        {

        }

        private void BtAddKindRoom_Click(object sender, EventArgs e)
        {
            
        }

        private void BtEditKindRoom_Click(object sender, EventArgs e)
        {
            
        }

        private void BtKindRoom_Click(object sender, EventArgs e)
        {
            
        }

       
        private void btDeleteRoom_Click(object sender, EventArgs e)
        {
                RoomBUS rmBus = new RoomBUS();
                RoomDTO rm = new RoomDTO();
                rm.IDR = int.Parse(txtIDRoom.Text);
                rm.COST = decimal.Parse(txtCostRoom.Text);
                rm.NAME = txtNameRoom.Text;
                rm.NBED = int.Parse(txtNbedRoom.Text);
                rm.NOTE = txtNoteKindRoom.Text;
                rm.STATUS = txtStatusRoom.Text;
                bool kq = rmBus.delete(rm);
                if (kq == false)
                    MessageBox.Show("Fail!");
                else
                    MessageBox.Show("Sussces");
                this.loadData();
            
        }
    }
}
