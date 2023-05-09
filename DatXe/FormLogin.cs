using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using System.Data.SqlClient;

namespace DatXe
{
    public partial class FormLogin : KryptonForm
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-7HFUFSE;Initial Catalog=BanVe;Integrated Security=True");
            String username = TextBoxUser.Text;
            String password = TextBoxPass.Text;
            if (username == null || username.Equals(""))
            {
                MessageBox.Show("Chưa Nhập Tên Đăng Nhập");
                return;
            }
            if (password == null || password.Equals(""))
            {
                MessageBox.Show("Chưa Nhập Mật Khẩu");
                return;
            }
            sqlcon.Open();
            string query = "select * from NguoiDung Where TaiKhoan = '" + username + "' and MatKhau = '" + password + "'";
            SqlCommand cmd = new SqlCommand(query, sqlcon);
            SqlDataReader dt = cmd.ExecuteReader();
            if (dt.Read())
            {
                MessageBox.Show("Đăng Nhập Thành Công");
                FormMain formMain= new FormMain(username);
                formMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Đăng Nhập Thất Bại");
            }
            sqlcon.Close();
        }
    }
}
