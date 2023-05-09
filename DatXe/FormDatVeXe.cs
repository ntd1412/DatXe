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
    public partial class FormDatVeXe : Form
    {
        public FormDatVeXe()
        {
            InitializeComponent();
        }
        private void FormDatVeXe_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-7HFUFSE;Initial Catalog=BanVe;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "SELECT * FROM ChuyenDi";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                comboBoxGioDi.Items.Add(reader["GioXuatPhat"].ToString());
                comboBoxDiemDi.Items.Add(reader["NoiDi"].ToString());
                comboBoxNoiDen.Items.Add(reader["NoiDen"].ToString());
            }

            reader.Close();
            connection.Close();

        }
    }
}
