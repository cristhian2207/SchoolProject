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
    public partial class FrmCalculadora : Form
    {
        public FrmCalculadora()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n1, n2, tl;
            n1 = Convert.ToDouble(textBox1.Text);
            n2 = Convert.ToDouble(textBox2.Text);

            tl = n1 + n2;
            textBox3.Text = tl.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double n1, n2, tl;
            n1 = Convert.ToDouble(textBox1.Text);
            n2 = Convert.ToDouble(textBox2.Text);

            tl = n1 - n2;
            textBox3.Text = tl.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double n1, n2, tl;
            n1 = Convert.ToDouble(textBox1.Text);
            n2 = Convert.ToDouble(textBox2.Text);

            tl = n1 * n2;
            textBox3.Text = tl.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double n1, n2, tl;
            n1 = Convert.ToDouble(textBox1.Text);
            n2 = Convert.ToDouble(textBox2.Text);

            tl = n1 / n2;
            textBox3.Text = tl.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Focus();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
