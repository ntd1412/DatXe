using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatXe
{
    public partial class FormQuanLyChuyenDi : Form
    {
        public FormQuanLyChuyenDi()
        {
            InitializeComponent();
        }
        DataSet GetAllChuyenDi()
        {
            DataSet data = new DataSet();
            string query = "select * from ChuyenDi";
            using (SqlConnection connection = new SqlConnection(KetNoiSQL.KetNoiSQLServer))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }
        private void FormQuanLyChuyenDi_Load(object sender, EventArgs e)
        {
            dgvQuanLyChuyenDi.DataSource = GetAllChuyenDi().Tables[0];
        }
    }
}
