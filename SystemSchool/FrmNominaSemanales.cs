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
    public partial class FrmNominaSemanales : Form
    {
        public FrmNominaSemanales()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int L, MA, MI, JU, VI, S, D, SAL, HE, HN, CANT;

            L=int.Parse(textBox1.Text);
            MA=int.Parse(textBox2.Text);
            MI=int.Parse(textBox3.Text);
            JU=int.Parse(textBox4.Text);
            VI=int.Parse(textBox5.Text);
            S=int.Parse(textBox6.Text);
            D = int.Parse(textBox7.Text);

            CANT = L+MA+MI+JU+VI+S+D;

            if (CANT < 41)
            {
                HN = CANT * 220;
                HE = 0;
            }
            else
            {
                HN = 40 * 220;
                HE = (CANT - 40) * 300;
            }

            SAL = HE + HN;

            textBox8.Text = SAL.ToString();


         }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmNominaSemanales_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
