using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemSchool
{
    public partial class Suplidores : Form
    {
        public Suplidores()
        {
            InitializeComponent();
        }

        private void Suplidores_Load(object sender, EventArgs e)
        {
            dgwSuplidores.DataSource = llenar_grid();
        }

        private object llenar_grid()
        {
            DataTable dt = new DataTable();
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                SqlConnection conexion = new SqlConnection(cnn);

                conexion.Open();
                using (SqlCommand cmd = new SqlCommand("select ID, Nombre_Producto as Productos, Cantidad from suplidores", conexion))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }
    }
}
