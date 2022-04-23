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
    public partial class FrmTasaDeCambio : Form
    {
        public FrmTasaDeCambio()
        {
            InitializeComponent();
        }

        private void FrmTasaDeCambio_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            double eu, t;
            const double rd = 56.86;
            eu = double.Parse(textBox1.Text);
            t = eu * rd;
            textBox2.Text = t.ToString();   

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            double eur, t;
            const double rd = 67.78;
            eur = double.Parse(textBox1.Text);
            t = eur * rd;
            textBox2.Text = t.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
 