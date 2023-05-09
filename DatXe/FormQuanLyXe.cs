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
    public partial class FormQuanLyXe : Form
    {
        public FormQuanLyXe()
        {
            InitializeComponent();
        }
        private void FormQuanLyXe_Load(object sender, EventArgs e)
        {
            dgvQuanLyXe.DataSource = GetAllXe().Tables[0];
        }

        DataSet GetAllXe()
        {
            DataSet data = new DataSet();
            string query = "select * from Xe";
            using (SqlConnection connection = new SqlConnection(KetNoiSQL.KetNoiSQLServer))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }

       
    }
}
