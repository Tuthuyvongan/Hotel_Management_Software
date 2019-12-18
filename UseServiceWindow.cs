using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using roomserviceDTO;
using roomServiceBUS;
using serviceBUS;
using serviceDTO;

namespace QuanLyHotel
{
    public partial class UseServiceWindow : Form
    {
        public UseServiceWindow()
        {
            InitializeComponent();
            this.loadData();
        }
        public UseServiceWindow(string name, string kind, string bedamount)
        {
            InitializeComponent();
            this.loadData();
            lbNameRoom.Text = name;
            lbKindRoom.Text = kind;
            lbBedsAmount.Text = bedamount;
        }
        private void loadData()
        {
            ServiceBUS ctmBus = new ServiceBUS();
            List<ServiceDTO> list = ctmBus.select();

            if (list == null)
            {
                MessageBox.Show("Fail");
                return;
            }
            dtgvService.Columns.Clear();
            dtgvService.DataSource = null;

            dtgvService.AutoGenerateColumns = false;
            dtgvService.AllowUserToAddRows = false;
            dtgvService.DataSource = list;

            DataGridViewTextBoxColumn NAME = new DataGridViewTextBoxColumn();
            NAME.Name = "name";
            NAME.HeaderText = "Name:";
            NAME.DataPropertyName = "name";
            NAME.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvService.Columns.Add(NAME);

            DataGridViewTextBoxColumn KIND = new DataGridViewTextBoxColumn();
            KIND.Name = "kind";
            KIND.HeaderText = "Kind";
            KIND.DataPropertyName = "kind";
            KIND.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvService.Columns.Add(KIND);

            DataGridViewTextBoxColumn COST = new DataGridViewTextBoxColumn();
            COST.Name = "cost";
            COST.HeaderText = "Cost";
            COST.DataPropertyName = "cost";
            COST.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvService.Columns.Add(COST);


            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dtgvService.DataSource];
            myCurrencyManager.Refresh();


        }
        

        private void Button1_Click(object sender, EventArgs e)
        {
            RoomServiceBUS roomServiceBUS = new RoomServiceBUS();
            RoomServiceDTO roomService = new RoomServiceDTO();
            roomService.IDR_S = lbNameRoom.Text;
            roomService.IDR = lbNameRoom.Text;
            roomService.IDS = lbNameService.Text;
            roomService.TIME = DateTime.Parse(dtDateService.Text);
            roomService.NUMBER = int.Parse(txtNumberService.Text);
            roomService.COST = Decimal.Parse(lbCost.Text)*Decimal.Parse(txtNumberService.Text);
            bool kq = roomServiceBUS.add(roomService);
            if (kq == false)
                MessageBox.Show("Fail!");
            else
                MessageBox.Show("Sussces");
            this.loadData();
            this.Close();
        }
    }
}
