using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using userBUS;
//using userDTO;
//using managerBUS;
//using managerDTO;

namespace QuanLyHotel
{
    public partial class SighUpWindow : Form
    {
        private bool dragging = false;
        private Point StartPoint = new Point(0, 0);

        public SighUpWindow()
        {
            InitializeComponent();

        }

        private void MoveBar_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            StartPoint = new Point(e.X, e.Y);
        }

        private void MoveBar_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void MoveBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.StartPoint.X, p.Y - this.StartPoint.Y);
            }
        }

        private void LoginLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginWindow C = new LoginWindow();
            C.ShowDialog();
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            //UserBUS UsBus = new UserBUS();
            //UserDTO Us = new UserDTO();
            ////ManagerBUS mngBus = new ManagerBUS();
            ////ManagerDTO mng = new ManagerDTO();
            //Us.IDU = txtUsername.Text;
            //Us.NAME = txtName.Text;
            //Us.PASSWORD = txtPassword.Text;
            //Us.LEVEL = 0;
            //bool kq = UsBus.add(Us);
            //if (kq == false)
            //    MessageBox.Show("Tài khoản đã tồn tại. Vui lòng kiểm tra lại dữ liệu");
            //else
            //{
                MessageBox.Show("Thêm tài khoản thành công");              
                LoginWindow C = new LoginWindow(txtEmail.Text,txtPassword.Text);   
                this.Hide();
                C.StartPosition = this.StartPosition;
                C.ShowDialog();
            //}
                
            txtEmail.Text = "";
            txtName.Text = "";
            txtPassword.Text = "";
           
        }

        private void SighUpWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
