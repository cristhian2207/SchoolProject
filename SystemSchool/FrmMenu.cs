using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemSchool
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCalculadora Cld = new FrmCalculadora();
            Cld.Show();
        }

        private void tasaDeCambioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTasaDeCambio Tdc = new FrmTasaDeCambio();
            Tdc.Show();
        }

        private void nominaSemanalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNominaSemanales Nms = new FrmNominaSemanales();
            Nms.Show();
        }

        private void consultaDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsulta Cst = new FrmConsulta();
            Cst.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Conexion.Conexiones().Close();
        }

        private void estudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estudiantes estudiante = new Estudiantes();
            estudiante.Show();
        }

        private void docentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Docentes docente = new Docentes();
            docente.Show();
        }

        private void suplidoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Suplidores suplidores = new Suplidores();
            suplidores.Show();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frmCreditos = new Form2();
            frmCreditos.Show();
        }
    }
}
