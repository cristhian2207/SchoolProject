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
    public partial class Estudiantes : Form
    {
        public Estudiantes()
        {
            InitializeComponent();
        }

        private void Estudiantes_Load(object sender, EventArgs e)
        {
            dgwEstudiantes.DataSource = llenar_grid();
        }

        public DataTable llenar_grid()
        {
            DataTable dt = new DataTable();
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                SqlConnection conexion = new SqlConnection(cnn);
                
                conexion.Open();
                using (SqlCommand cmd = new SqlCommand("select Nombre, Apellido, Sexo, 'Estudiante' as Condicion from estudiantes order by Apellido asc", conexion))
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
