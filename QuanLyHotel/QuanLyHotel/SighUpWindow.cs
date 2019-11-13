using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using userBUS;
using userDTO;

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

        private void CloseButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginWindow C = new LoginWindow();
            C.ShowDialog();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            UserBUS tcBus = new UserBUS();
            UserDTO tc = new UserDTO();
            tc.IDU = UsernameTB.Text;
            tc.NAME = textBox1.Text;
            tc.PASSWORD = textBox6.Text;
            bool kq = tcBus.add(tc);
            if (kq == false)
                MessageBox.Show("Tài khoản đã tồn tại. Vui lòng kiểm tra lại dữ liệu");
            else
            {
                MessageBox.Show("Thêm tài khoản thành công");              
                LoginWindow C = new LoginWindow();
                this.Hide();
                C.ShowDialog();
            }
                
            UsernameTB.Text = "";
            textBox1.Text = "";
            textBox6.Text = "";
           
        }
    }
}
