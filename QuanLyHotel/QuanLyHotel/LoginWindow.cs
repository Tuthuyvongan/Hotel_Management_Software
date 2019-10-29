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


    public partial class LoginWindow : Form
    {
        private bool dragging = false;
        private Point StartPoint = new Point(0, 0);

        public LoginWindow()
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

        private void Button3_Click(object sender, EventArgs e)
        {

        }

        private void CloseButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainWindow A = new MainWindow();
            A.Show();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SighUpWindow B = new SighUpWindow();
            B.Show();
        }
    }
}
