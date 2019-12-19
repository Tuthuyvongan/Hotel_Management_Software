using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHotel
{
    public partial class MainWindow : Form
    {
        
        public MainWindow()
        {
            InitializeComponent();
            homeWindow1.Dock = DockStyle.Fill;
            homeWindow1.BringToFront();
        }
        string username = "";
        int level = 0;
        public MainWindow(string Username, int Level)
        {
            InitializeComponent();
            homeWindow1.Dock = DockStyle.Fill;
            homeWindow1.BringToFront();
            
            username = Username;
            level = Level;
            if (level == 1)
            {
                btAccount.Show();
            }
            else btAccount.Hide();
        }
        
        public void ChangeDock(Control a)
        {
            a.Dock = DockStyle.None;
        }

        private void BtMenu_Click(object sender, EventArgs e)
        {
            if(MenuBar.Width == 150)
            {
                MenuBar.Width = 43;
            }
            else MenuBar.Width = 150;
        }

        private void BtHome_Click(object sender, EventArgs e)
        {
            homeWindow1.BringToFront();
            homeWindow1.Dock = DockStyle.Fill;
        }

        private void BtRoom_Click(object sender, EventArgs e)
        {
            roomWindow1.BringToFront();
            roomWindow1.Dock = DockStyle.Fill;


        }

        private void BtCustomer_Click(object sender, EventArgs e)
        {
            customerWindow1.BringToFront();
            customerWindow1.Dock = DockStyle.Fill;
        }

        private void BtService_Click(object sender, EventArgs e)
        {
            serviceWindow1.BringToFront();
            serviceWindow1.Dock = DockStyle.Fill;
        }

        private void BtAccount_Click(object sender, EventArgs e)
        {
            accountWindow1.BringToFront();
            accountWindow1.Dock = DockStyle.Fill;
        }
    }
}
