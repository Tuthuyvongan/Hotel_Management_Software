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
using managerBUS;
using managerDTO;

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
            errorProvider1.Clear();
            errorProvider2.Clear();
            errorProvider3.Clear();
            errorProvider4.Clear();
            errorProvider5.Clear();
            errorProvider6.Clear();
            errorProvider7.Clear();
            errorProvider8.Clear();

            UserBUS UsBus = new UserBUS();
            UserDTO Us = new UserDTO();
            ManagerBUS mngBus = new ManagerBUS();
            ManagerDTO mng = new ManagerDTO();
            if (txtUsername.Text == "")
            {
                errorProvider1.SetError(txtUsername, "Không được để trống!");
            }
            if (txtPassword.Text == "")
            {
                errorProvider2.SetError(txtPassword, "Không được để trống!");
            }
            if (txtRePassword.Text=="" & txtRePassword.Text != txtPassword.Text)
            {
                errorProvider3.SetError(txtUsername, "Không khớp");
            }
            if (txtPhone.Text == "")
            {
                errorProvider6.SetError(txtPhone, "Không được để trống!");
            }
            if (txtName.Text == "")
            {
                errorProvider4.SetError(txtName, "Không được để trống!");
            }
            if (txtEmail.Text == "")
            {
                errorProvider7.SetError(txtEmail, "Không được để trống!");
            }
            if (txtGender.Text == "")
            {
                errorProvider5.SetError(txtGender, "Không được để trống!");
            }
            if (textBoxidc.Text == "")
            {
                errorProvider8.SetError(textBoxidc, "Không được để trống!");
            }
            else
            {
                Us.Idm = txtUsername.Text;
                Us.Name = txtName.Text;
                Us.Password = txtPassword.Text;
                Us.Phone = txtPhone.Text;
                Us.Email = txtEmail.Text;
                Us.Gender = txtGender.Text;
                Us.Cmnd = textBoxidc.Text;
                bool kq = UsBus.add(Us);
                if (kq == false)
                    MessageBox.Show("Tài khoản đã tồn tại. Vui lòng kiểm tra lại dữ liệu");
                else
                {
                    MessageBox.Show("Thêm tài khoản thành công");
                    LoginWindow C = new LoginWindow(txtEmail.Text, txtPassword.Text);
                    this.Hide();
                    C.StartPosition = this.StartPosition;
                    C.ShowDialog();
                }

                txtEmail.Text = "";
                txtName.Text = "";
                txtPassword.Text = "";
                txtGender.Text = "";
                txtPhone.Text = "";
                txtRePassword.Text = "";
                textBoxidc.Text = "";
            }
        }

        private void SighUpWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
