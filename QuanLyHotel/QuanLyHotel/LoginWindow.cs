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


    public partial class LoginWindow : Form
    {
       

        public LoginWindow()
        {
            InitializeComponent();
        }
        public LoginWindow(string a, string b)
        {
            InitializeComponent();
            txtUsername.Text = a;
            txtPassword.Text = b;
        }


        //Move
        private bool dragging = false;
        private Point StartPoint = new Point(0, 0);
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


        //Click event
        #region Events
        private void LoginWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo!", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            errorProvider2.Clear();
            UserBUS ndBUS = new UserBUS();

            UserDTO tn = new UserDTO();
            tn.Idm = txtUsername.Text;
            string IDU = txtUsername.Text;
            string PASSWORD = txtPassword.Text;
            if (txtUsername.Text == "")
            {
                errorProvider1.SetError(txtUsername, "Không được để trống!");
            }
            if (txtPassword.Text == "")
            {
                errorProvider1.SetError(txtPassword, "Không được để trống!");
            }
            else
            {

                if (ndBUS.kiemtra(tn, IDU, PASSWORD))
                {
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    MainWindow f = new MainWindow(ndBUS.GetLevel(tn));
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
                }
            }

        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            this.Hide();
            SighUpWindow B = new SighUpWindow();
            B.Show();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if ( e.KeyCode == Keys.Enter)
            {
                errorProvider1.Clear();
                errorProvider2.Clear();
                UserBUS ndBUS = new UserBUS();

                UserDTO tn = new UserDTO();
                string IDU = txtUsername.Text;
                string PASSWORD = txtPassword.Text;
                if (txtUsername.Text == "")
                {
                    errorProvider1.SetError(txtUsername, "Không được để trống!");
                }
                if (txtPassword.Text == "")
                {
                    errorProvider1.SetError(txtPassword, "Không được để trống!");
                }
                else
                {

                    if (ndBUS.kiemtra(tn, IDU, PASSWORD))
                    {
                        txtUsername.Text = "";
                        txtPassword.Text = "";
                        MainWindow f = new MainWindow();
                        this.Hide();
                        f.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
                    }
                }
            }
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                errorProvider1.Clear();
                errorProvider2.Clear();
                UserBUS ndBUS = new UserBUS();

                UserDTO tn = new UserDTO();
                string IDU = txtUsername.Text;
                string PASSWORD = txtPassword.Text;
                if (txtUsername.Text == "")
                {
                    errorProvider1.SetError(txtUsername, "Không được để trống!");
                }
                if (txtPassword.Text == "")
                {
                    errorProvider1.SetError(txtPassword, "Không được để trống!");
                }
                else
                {

                    if (ndBUS.kiemtra(tn, IDU, PASSWORD))
                    {
                        txtUsername.Text = "";
                        txtPassword.Text = "";
                        MainWindow f = new MainWindow();
                        this.Hide();
                        f.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
                    }
                }
            }
        }
        #endregion
    }
}
