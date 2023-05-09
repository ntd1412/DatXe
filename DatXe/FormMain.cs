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
using FontAwesome.Sharp;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DatXe
{
    public partial class FormMain : KryptonForm
    {
        private Panel Doimau;
        private IconButton currentBtn;
        private Form currentChildForm;
        public FormMain(String username)
        {
            InitializeComponent();
            lblUserName.Text = username;
            Doimau= new Panel();
            Doimau.Size = new Size(7,60);
            panelMenu.Controls.Add(Doimau);
        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        #region Đổi màu
        private void ActivateButton (object senderBtn, Color color)
        {
            DisableButton();
            if (senderBtn != null)
            {
                Doimau.BackColor = color;
                Doimau.Location= new Point(0, btnDatVeXe.Location.Y);
                Doimau.Visible = true;
                Doimau.BringToFront();
            }
        }
        private void ActivateButton1(object senderBtn, Color color)
        {
            DisableButton();
            if (senderBtn != null)
            {
                Doimau.BackColor = color;
                Doimau.Location = new Point(0, btnQuanLyChuyenDi.Location.Y);
                Doimau.Visible = true;
                Doimau.BringToFront();
            }
        }
        private void ActivateButton2(object senderBtn, Color color)
        {
            DisableButton();
            if (senderBtn != null)
            {
                Doimau.BackColor = color;
                Doimau.Location = new Point(0, btnQuanLyXe.Location.Y);
                Doimau.Visible = true;
                Doimau.BringToFront();
            }
        }
        private void ActivateButton3(object senderBtn, Color color)
        {
            DisableButton();
            if (senderBtn != null)
            {
                Doimau.BackColor = color;
                Doimau.Location = new Point(0, btnQuanLyKhachHang.Location.Y);
                Doimau.Visible = true;
                Doimau.BringToFront();
            }
        }
        private void ActivateButton4(object senderBtn, Color color)
        {
            DisableButton();
            if (senderBtn != null)
            {
                Doimau.BackColor = color;
                Doimau.Location = new Point(0, btnBaoCaoThongKe.Location.Y);
                Doimau.Visible = true;
                Doimau.BringToFront();
            }
        }
        private void ActivateButton5(object senderBtn, Color color)
        {
            DisableButton();
            if (senderBtn != null)
            {
                Doimau.BackColor = color;
                Doimau.Location = new Point(0, btnLogout.Location.Y);
                Doimau.Visible = true;
                Doimau.BringToFront();
            }
        }
        #endregion
        private void btnDatVeXe_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new FormDatVeXe());
        }

        private void btnQuanLyChuyenDi_Click(object sender, EventArgs e)
        {
            ActivateButton1(sender, RGBColors.color2);
            OpenChildForm(new FormQuanLyChuyenDi());
        }

        private void btnQuanLyXe_Click(object sender, EventArgs e)
        {
            ActivateButton2(sender, RGBColors.color3);
            OpenChildForm(new FormQuanLyXe());
        }

        private void btnQuanLyKhachHang_Click(object sender, EventArgs e)
        {
            ActivateButton3(sender, RGBColors.color4);
            OpenChildForm(new FormQuanLyKhachHang());
        }

        private void btnBaoCaoThongKe_Click(object sender, EventArgs e)
        {
            ActivateButton4(sender, RGBColors.color5);
            OpenChildForm(new FormBaoCaoThongKe());
        }
        private void Reset()
        {
            DisableButton();
            Doimau.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            ActivateButton5(sender, RGBColors.color6);
            DialogResult dialogResult = MessageBox.Show("Bạn Muốn Đăng Xuất?", "Đăng Xuất", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                FormLogin formLogin = new FormLogin();
                formLogin.Show();
                this.Hide();
            }
            else if (dialogResult == DialogResult.No)
            {
              
            }
        }
    }
}
