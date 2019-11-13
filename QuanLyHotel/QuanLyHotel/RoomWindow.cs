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

        
        public RoomBUS rBus;
        //private void loadData_Vao_GridView()
        //{
        //    List<KindRoomDTO> listPhuTung = krBus.select();

        //    if (listPhuTung == null)
        //    {
        //        MessageBox.Show("Có lỗi khi lấy thông tin từ DB");
        //        return;
        //    }
        //    dtKindRoom.Columns.Clear();
        //    dtKindRoom.DataSource = null;

        //    dtKindRoom.AutoGenerateColumns = false;
        //    dtKindRoom.AllowUserToAddRows = false;
        //    dtKindRoom.DataSource = listPhuTung;

        //    DataGridViewTextBoxColumn clid = new DataGridViewTextBoxColumn();
        //    clid.Name = "iDKR";
        //    clid.HeaderText = "ID";
        //    clid.DataPropertyName = "iDKR";
        //    clid.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        //    dtKindRoom.Columns.Add(clid);

        //    DataGridViewTextBoxColumn clPhuTung = new DataGridViewTextBoxColumn();
        //    clPhuTung.Name = "nAME";
        //    clPhuTung.HeaderText = "Kind";
        //    clPhuTung.DataPropertyName = "nAME";
        //    clPhuTung.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        //    dtKindRoom.Columns.Add(clPhuTung);

        //    DataGridViewTextBoxColumn clDongia = new DataGridViewTextBoxColumn();
        //    clDongia.Name = "numberOFBED";
        //    clDongia.HeaderText = "Number Of Bed";
        //    clDongia.DataPropertyName = "numberOFBED";
        //    clDongia.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        //    dtKindRoom.Columns.Add(clDongia);

        //    DataGridViewTextBoxColumn clTondau = new DataGridViewTextBoxColumn();
        //    clTondau.Name = "nOTE";
        //    clTondau.HeaderText = "Note";
        //    clTondau.DataPropertyName = "nOTE";
        //    clTondau.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        //    dtKindRoom.Columns.Add(clTondau);

        //    CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dtKindRoom.DataSource];
        //    myCurrencyManager.Refresh();


        //}

        private void loadData()
        {
            rBus = new RoomBUS();
            List<RoomDTO> list = rBus.select();

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

            DataGridViewTextBoxColumn clid = new DataGridViewTextBoxColumn();
            clid.Name = "iDR";
            clid.HeaderText = "ID";
            clid.DataPropertyName = "iDR";
            clid.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns.Add(clid);

            DataGridViewTextBoxColumn clht = new DataGridViewTextBoxColumn();
            clht.Name = "nAME";
            clht.HeaderText = "Name:";
            clht.DataPropertyName = "nAME";
            clht.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns.Add(clht);

            DataGridViewTextBoxColumn clbienso = new DataGridViewTextBoxColumn();
            clbienso.Name = "sTATUS";
            clbienso.HeaderText = "Status";
            clbienso.DataPropertyName = "sTATUS";
            clbienso.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns.Add(clbienso);

            DataGridViewTextBoxColumn cldiachi = new DataGridViewTextBoxColumn();
            cldiachi.Name = "nBED";
            cldiachi.HeaderText = "Number of Bed";
            cldiachi.DataPropertyName = "nBED";
            cldiachi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns.Add(cldiachi);
          

            DataGridViewTextBoxColumn clhieuxe = new DataGridViewTextBoxColumn();
            clhieuxe.Name = "nOTE";
            clhieuxe.HeaderText = "Note";
            clhieuxe.DataPropertyName = "nOTE";
            clhieuxe.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns.Add(clhieuxe);

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataGridView1.DataSource];
            myCurrencyManager.Refresh();


        }
        private void btLoadRoom_Click(object sender, EventArgs e)
        {
            this.loadData();
        }

        private void BtAddRoom_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            errorProvider2.Clear();
            errorProvider3.Clear();          
            errorProvider5.Clear();
           if(txtIDRoom.Text=="")
            {
                errorProvider1.SetError(txtIDRoom, "not null!");
            }
           else if(txtStatusRoom.Text=="")
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
                RoomDTO room = new RoomDTO();
                room.IDR = int.Parse(txtCostRoom.Text);
                room.COST = decimal.Parse(txtCostRoom.Text);
                room.NAME = txtNameRoom.Text;
                room.NBED = int.Parse(txtNbedRoom.Text);
                room.NOTE = txtNoteKindRoom.Text;
                room.STATUS = txtStatusRoom.Text;
                bool kq = rBus.add(room);
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
            RoomDTO room = new RoomDTO();
            room.IDR = int.Parse(txtIDRoom.Text);
            room.COST = decimal.Parse(txtCostRoom.Text);
            room.NAME = txtNameRoom.Text;
            room.NBED = int.Parse(txtNbedRoom.Text);
            room.NOTE = txtNoteKindRoom.Text;
            room.STATUS = txtStatusRoom.Text;
            bool kq = rBus.edit(room);
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
            //errorProvider4.Clear();
            //errorProvider5.Clear();
            //if (txtNameKindRoom.Text == "") errorProvider4.SetError(txtNameKindRoom, "Tên loại phòng không được để trống!");
            //else if (txtNBOBedKindRoom.Text == "") errorProvider5.SetError(txtNBOBedKindRoom, "Số giường không được để trống!");
            //else
            //{
            //    KindRoomDTO pt = new KindRoomDTO();
            //    pt.NAME = txtNameKindRoom.Text;
            //    pt.NumberOFBED = int.Parse(txtNBOBedKindRoom.Text);
            //    pt.NOTE = txtNoteKindRoom.Text;
            //    bool kq = krBus.them(pt);
            //    if (kq == false)
            //        MessageBox.Show("Thêm thông tin thất bại. Vui lòng kiểm tra lại dữ liệu");
            //    else
            //        MessageBox.Show("Thêm thông tin thành công");
            //    this.loadData_Vao_GridView();
            //    txtNameKindRoom.Text = "";
            //    txtNBOBedKindRoom.Text = "";
            //    txtNoteKindRoom.Text = "";
            //}
        }

       
        private void btDeleteRoom_Click(object sender, EventArgs e)
        {
            
                RoomDTO room = new RoomDTO();
                room.IDR = int.Parse(txtIDRoom.Text);
                room.COST = decimal.Parse(txtCostRoom.Text);
                room.NAME = txtNameRoom.Text;
                room.NBED = int.Parse(txtNbedRoom.Text);
                room.NOTE = txtNoteKindRoom.Text;
                room.STATUS = txtStatusRoom.Text;
                bool kq = rBus.delete(room);
                if (kq == false)
                    MessageBox.Show("Fail!");
                else
                    MessageBox.Show("Sussces");
                this.loadData();
            
        }
    }
}
