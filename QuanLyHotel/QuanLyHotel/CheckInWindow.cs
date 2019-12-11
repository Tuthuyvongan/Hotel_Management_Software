using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using customerBUS;
using customerDTO;
using roomBUS;
using roomDTO;
using billBUS;
using billDTO;
using userBUS;
using userDTO;

namespace QuanLyHotel
{
    public partial class CheckInWindow : UserControl
    {
        public CheckInWindow()
        {
            InitializeComponent();
            loadDataCustomer();
            loadDataRoom();
            Panel.Hide();
        }
        private void loadDataCustomer()
        {
            CustomerBUS ctmBus = new CustomerBUS();
            List<CustomerDTO> list = ctmBus.select();

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
            iD.Name = "iDC";
            iD.HeaderText = "ID";
            iD.DataPropertyName = "iDC";
            iD.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns.Add(iD);

            DataGridViewTextBoxColumn nAME = new DataGridViewTextBoxColumn();
            nAME.Name = "nAME";
            nAME.HeaderText = "Name:";
            nAME.DataPropertyName = "nAME";
            nAME.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns.Add(nAME);

            DataGridViewTextBoxColumn gENDER = new DataGridViewTextBoxColumn();
            gENDER.Name = "gENDER";
            gENDER.HeaderText = "GENDER";
            gENDER.DataPropertyName = "gENDER";
            gENDER.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns.Add(gENDER);

            DataGridViewTextBoxColumn eMAIL = new DataGridViewTextBoxColumn();
            eMAIL.Name = "eMAIL";
            eMAIL.HeaderText = "EMAIL";
            eMAIL.DataPropertyName = "eMAIL";
            eMAIL.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns.Add(eMAIL);

            DataGridViewTextBoxColumn pHONE = new DataGridViewTextBoxColumn();
            pHONE.Name = "phoneNUMBER";
            pHONE.HeaderText = "PHONE";
            pHONE.DataPropertyName = "phoneNUMBER";
            pHONE.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns.Add(pHONE);

            //DataGridViewTextBoxColumn aDDRESS = new DataGridViewTextBoxColumn();
            //aDDRESS.Name = "aDDRESS";
            //aDDRESS.HeaderText = "ADDRESS";
            //aDDRESS.DataPropertyName = "aDDRESS";
            //aDDRESS.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //dataGridView1.Columns.Add(aDDRESS);

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataGridView1.DataSource];
            myCurrencyManager.Refresh();


        }
        private void loadDataRoom()
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
            iD.Name = "iDR";
            iD.HeaderText = "ID";
            iD.DataPropertyName = "iDR";
            iD.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView2.Columns.Add(iD);

            DataGridViewTextBoxColumn iDK = new DataGridViewTextBoxColumn();
            iDK.Name = "iDRK";
            iDK.HeaderText = "IDK";
            iDK.DataPropertyName = "iDRK";
            iDK.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView2.Columns.Add(iDK);

            DataGridViewTextBoxColumn nAME = new DataGridViewTextBoxColumn();
            nAME.Name = "nAME";
            nAME.HeaderText = "Name:";
            nAME.DataPropertyName = "nAME";
            nAME.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView2.Columns.Add(nAME);

            DataGridViewTextBoxColumn sTATUS = new DataGridViewTextBoxColumn();
            sTATUS.Name = "sTATUS";
            sTATUS.HeaderText = "Status";
            sTATUS.DataPropertyName = "sTATUS";
            sTATUS.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView2.Columns.Add(sTATUS);

            DataGridViewTextBoxColumn COST = new DataGridViewTextBoxColumn();
            COST.Name = "cOST";
            COST.HeaderText = "COST";
            COST.DataPropertyName = "cOST";
            COST.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView2.Columns.Add(COST);

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataGridView2.DataSource];
            myCurrencyManager.Refresh();

        }

        private void BtCheckIn_Click(object sender, EventArgs e)
        {
            //Thêm dữ liệu vào bill
            BillBUS bllBUS = new BillBUS();
            BillDTO bll = new BillDTO();
            bll.IDB = dtCheckIn.Text+"@"+ dtCheckOut.Text+"$"+txtIDR.Text;                                            
            bll.IDR = txtIDR.Text;
            bll.IDC = txtIDC.Text;
            bll.CheckIn = DateTime.Parse(dtCheckIn.Text);
            bll.CheckOut = DateTime.Parse(dtCheckOut.Text);
            bll.COST = 0;
            bll.IDM = "";                                           //Lấy dữ liệu ID của User đang dùng


            //Thay đổi trạng thái phòng "Đặt"
            dataGridView1.Rows[int.Parse(txtRow.Text)].Cells[1].Value="Đầy";
        }

        private void DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            txtRow.Text = numrow.ToString();
            txtIDR.Text = dataGridView1.Rows[numrow].Cells[1].Value.ToString();
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            txtIDC.Text= dataGridView1.Rows[numrow].Cells[1].Value.ToString();
        }
    }
}
