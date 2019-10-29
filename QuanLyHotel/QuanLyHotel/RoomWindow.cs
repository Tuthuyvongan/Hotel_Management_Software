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

namespace QuanLyHotel
{
    public partial class RoomWindow : UserControl
    {
        public RoomWindow()
        {
            InitializeComponent();
           
        }
        private KindRoomBUS krBus;
        private void loadData_Vao_GridView()
        {
            List<KindRoomDTO> listPhuTung = krBus.select();

            if (listPhuTung == null)
            {
                MessageBox.Show("Có lỗi khi lấy thông tin từ DB");
                return;
            }
            dtKindRoom.Columns.Clear();
            dtKindRoom.DataSource = null;

            dtKindRoom.AutoGenerateColumns = false;
            dtKindRoom.AllowUserToAddRows = false;
            dtKindRoom.DataSource = listPhuTung;

            DataGridViewTextBoxColumn clid = new DataGridViewTextBoxColumn();
            clid.Name = "iDKR";
            clid.HeaderText = "ID";
            clid.DataPropertyName = "iDKR";
            clid.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtKindRoom.Columns.Add(clid);

            DataGridViewTextBoxColumn clPhuTung = new DataGridViewTextBoxColumn();
            clPhuTung.Name = "nAME";
            clPhuTung.HeaderText = "Kind";
            clPhuTung.DataPropertyName = "nAME";
            clPhuTung.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtKindRoom.Columns.Add(clPhuTung);

            DataGridViewTextBoxColumn clDongia = new DataGridViewTextBoxColumn();
            clDongia.Name = "numberOFBED";
            clDongia.HeaderText = "Number Of Bed";
            clDongia.DataPropertyName = "numberOFBED";
            clDongia.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtKindRoom.Columns.Add(clDongia);

            DataGridViewTextBoxColumn clTondau = new DataGridViewTextBoxColumn();
            clTondau.Name = "nOTE";
            clTondau.HeaderText = "Note";
            clTondau.DataPropertyName = "nOTE";
            clTondau.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtKindRoom.Columns.Add(clTondau);

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dtKindRoom.DataSource];
            myCurrencyManager.Refresh();


        }

        private void BtAddRoom_Click(object sender, EventArgs e)
        {
           
        }

        private void BtEditRoom_Click(object sender, EventArgs e)
        {
            
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
            errorProvider4.Clear();
            errorProvider5.Clear();
            if(txtNameKindRoom.Text=="") errorProvider4.SetError(txtNameKindRoom, "Tên loại phòng không được để trống!");
            else if(txtNBOBedKindRoom.Text=="") errorProvider5.SetError(txtNBOBedKindRoom, "Số giường không được để trống!");
            else
            {
                KindRoomDTO pt = new KindRoomDTO();
                pt.NAME = txtNameKindRoom.Text;
                pt.NumberOFBED = int.Parse(txtNBOBedKindRoom.Text);
                pt.NOTE = txtNoteKindRoom.Text;
                bool kq = krBus.them(pt);
                if (kq == false)
                    MessageBox.Show("Thêm thông tin thất bại. Vui lòng kiểm tra lại dữ liệu");
                else
                    MessageBox.Show("Thêm thông tin thành công");
                this.loadData_Vao_GridView();
                txtNameKindRoom.Text = "";
                txtNBOBedKindRoom.Text = "";
                txtNoteKindRoom.Text = "";
            }
        }
    }
}
