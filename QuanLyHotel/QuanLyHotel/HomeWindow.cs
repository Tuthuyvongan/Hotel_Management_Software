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
using roomDAO;

namespace QuanLyHotel
{
    public partial class HomeWindow : UserControl
    {
        public HomeWindow()
        {
            InitializeComponent();
            LoadRoom();
        }
        string username = "";
        public HomeWindow(string Username)
        {
            InitializeComponent();
            username = Username;
        }
        void LoadRoom()
        {
            //RoomDAO roomList = new RoomDAO();
            //List<RoomDAO> listRoom = roomList.LoadRoomList();
            //if (listRoom == null)
            //{
            //    MessageBox.Show("Có lỗi khi lấy thông tin từ DB");
            //    return;
            //}
            //foreach(RoomDAO item in listRoom)
            //{
            //    Button btn = new Button() { Width = RoomDAO.RoomWidth, Height = RoomDAO.RoomHeigh };
            //    panelflr.Controls.Add(btn);
            //}
        }
       
        private void BtCheckOut_Click_1(object sender, EventArgs e)
        {
            CheckOutWindow checkOut = new CheckOutWindow();
            checkOut.Show();
        }

        private void BtUseService_Click_1(object sender, EventArgs e)
        {
            UseServiceWindow useService = new UseServiceWindow(lbName.Text,lbKind.Text,lbBedsAmount.Text);
            useService.Show();
        }

        private void BtCheckInRoom_Click(object sender, EventArgs e)
        {
            CheckInWindow checkIn = new CheckInWindow(username,lbName.Text,lbKind.Text,lbBedsAmount.Text,lbCost.Text);
            checkIn.Show();
        }

        private void dtgvRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            lbName.Text = dtgvRoom.Rows[numrow].Cells[1].Value.ToString();
            lbKind.Text = dtgvRoom.Rows[numrow].Cells[2].Value.ToString();
            lbStatus.Text = dtgvRoom.Rows[numrow].Cells[3].Value.ToString();
            lbBedsAmount.Text = dtgvRoom.Rows[numrow].Cells[4].Value.ToString();
            lbCost.Text = dtgvRoom.Rows[numrow].Cells[4].Value.ToString();
        }
    }
}
