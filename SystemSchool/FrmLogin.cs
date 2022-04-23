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
using System.Configuration;

namespace SystemSchool
{
    public partial class FrmLogin : Form
    {

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                SqlConnection conexion = new SqlConnection(cnn);
                conexion.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT username, pass FROM usuario WHERE username = '" + txtUsuario.Text.ToLower() + "' AND pass = '" + txtContraseña.Text.ToLower() + "'", conexion))
                    {
                        SqlDataReader dr = cmd.ExecuteReader();
                        if(dr.Read())
                        {
                            MessageBox.Show("Bienvenido al sistema.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            FrmMenu mn = new FrmMenu();
                            mn.Show();
                    }
                        else
                        {
                            MessageBox.Show("Usuario o contraseña incorrectos.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            conexion.Close();
                        }
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro de que quieres salir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}



