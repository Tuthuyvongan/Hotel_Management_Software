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
        }
        string username = "";
        public HomeWindow(string Username)
        {
            InitializeComponent();
            username = Username;
        }

        //
        //---- LOAD DATA
        //
        void LoadRoom()
        {
            RoomDAO roomList = new RoomDAO();
            List<RoomDAO> listRoom = roomList.LoadRoomList();
            if (listRoom == null)
            {
                MessageBox.Show("Có lỗi khi lấy thông tin từ DB");
                return;
            }
            foreach (RoomDAO item in listRoom)
            {
                Button btn = new Button() { Width = RoomDAO.RoomWidth, Height = RoomDAO.RoomHeigh };
                //btn.Text = item. + Environment.NewLine + item.editStatus;
                flpRoom.Controls.Add(btn);
            }
        }
        private RoomBUS rmBus;
        private void loadData()
        {
            rmBus = new RoomBUS();
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

            DataGridViewTextBoxColumn Cost = new DataGridViewTextBoxColumn();
            Cost.Name = "cost";
            Cost.HeaderText = "Cost";
            Cost.DataPropertyName = "cost";
            Cost.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvRoom.Columns.Add(Cost);

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dtgvRoom.DataSource];
            myCurrencyManager.Refresh();
        }

        //
        //---- EVENTS
        //
        #region Events
        private void dtgvRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            lbName.Text = dtgvRoom.Rows[numrow].Cells[0].Value.ToString();
            lbStatus.Text = dtgvRoom.Rows[numrow].Cells[1].Value.ToString();
            lbBedsAmount.Text = dtgvRoom.Rows[numrow].Cells[2].Value.ToString();
            lbKind.Text = dtgvRoom.Rows[numrow].Cells[3].Value.ToString();
            lbCost.Text = Convert.ToString(dtgvRoom.Rows[numrow].Cells[4].Value);
            
        }

        private void btLoadRoom_Click(object sender, EventArgs e)
        {
            this.loadData();
            this.LoadRoom();
        }

        private void btCheckInRoom_Click_1(object sender, EventArgs e)
        {
            
           
        CheckInWindow checkIn = new CheckInWindow( lbName.Text, lbKind.Text, lbBedsAmount.Text, lbCost.Text);
            checkIn.Show();
        }

        private void btCheckOut_Click(object sender, EventArgs e)
        {
            CheckOutWindow checkOut = new CheckOutWindow();
            checkOut.Show();
        }

        private void btUseService_Click(object sender, EventArgs e)
        {
            UseServiceWindow useService = new UseServiceWindow(lbName.Text, lbKind.Text, lbBedsAmount.Text);
            useService.Show();
        }

        private void HomeWindow_Load(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
