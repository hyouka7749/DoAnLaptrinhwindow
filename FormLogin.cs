using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;
using Microsoft.SqlServer.Server;

namespace FormDangNhap
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            txtPass.PasswordChar = '*'; // Mặc định ẩn mật khẩu
        }

        private void EmptyBox()
        {
            txtUsername.Clear();
            txtPass.Clear();
        }
        private bool isPasswordHidden = true;
        private void TogglePasswordVisibility()
        {
            isPasswordHidden = !isPasswordHidden;

            if (isPasswordHidden)
            {
                txtPass.PasswordChar = '*'; // Ẩn mật khẩu
            }
            else
            {
                txtPass.PasswordChar = '\0'; // Hiển thị mật khẩu
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlToolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        private void picHidepass_Click(object sender, EventArgs e)
        {
            
        }



        private void lblMisspass_Click(object sender, EventArgs e)
        {

        }

        private void picShowpass_Click_1(object sender, EventArgs e)
        {
            TogglePasswordVisibility();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            string input = txtUsername.Text;

            // Kiểm tra nếu có kí tự đặc biệt hoặc dấu cách
            if (input.Any(c => !char.IsLetterOrDigit(c)))
            {
                MessageBox.Show("Tên người dùng không được chứa kí tự đặc biệt hoặc dấu cách.");
                txtUsername.Text = ""; // Xóa nội dung không hợp lệ
                return;
            }

            // Kiểm tra nếu trường để trống
            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Tên người dùng không được để trống.");
                txtUsername.Text = ""; // Xóa nội dung không hợp lệ
                return;
            }
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            string password = txtPass.Text;

            // Kiểm tra nếu có dấu cách
            if (password.Contains(" "))
            {
                MessageBox.Show("Mật khẩu không được chứa dấu cách.");
                txtPass.Text = ""; // Xóa nội dung không hợp lệ
                return;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Kiểm tra thông tin đăng nhập ở đây
            string username = txtUsername.Text;
            string password = txtPass.Text;

            // Thực hiện kiểm tra đăng nhập, ví dụ:
            if (username == "admin" && password == "123")
            {
                // Đăng nhập thành công, hiển thị FormQL
                FormMain formQL = new FormMain();
                formQL.Show();

                // Đóng FormLogin (nếu cần)
                this.Hide();
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công. Vui lòng kiểm tra tên đăng nhập và mật khẩu.");
            }
        }
    }
}
