using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace DatXe
{
    public partial class FormQuanLyKhachHang : Form
    {
        public FormQuanLyKhachHang()
        {
            InitializeComponent();
        }
         
        private void dataGridView1_RowPrePaint_1(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            //DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            //row.DefaultCellStyle.BackColor = Color.Yellow;
        }
        private void FormQuanLyKhachHang_Load(object sender, EventArgs e)
        {
            dgvQuanLyKhachHang.DataSource = GetAllKhachHang().Tables[0];
        }
        DataSet GetAllKhachHang()
        {
            DataSet data = new DataSet();
            string query = "select * from KhachHang";
            using (SqlConnection connection = new SqlConnection(KetNoiSQL.KetNoiSQLServer))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            dgvQuanLyKhachHang.DataSource = GetAllKhachHang().Tables[0];
        }
    }
}
