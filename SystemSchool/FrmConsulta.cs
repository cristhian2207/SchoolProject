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
    public partial class FrmConsulta : Form
    {
        public FrmConsulta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgwConsulta.DataSource = llenar_grid();
        }

        private object llenar_grid()
        {
            DataTable dt = new DataTable();
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                SqlConnection conexion = new SqlConnection(cnn);

                conexion.Open();
                using (SqlCommand cmd = new SqlCommand("select Nombre, Apellido, Sexo, 'Estudiante' as Condicion from estudiantes where Nombre ='"+ textBox.Text +"'"+" union "+"select Nombre, Apellido, Sexo, 'Profesor' as Condicion from profesores where Nombre ='"+textBox.Text+"'"+ " order by Apellido asc", conexion))
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
