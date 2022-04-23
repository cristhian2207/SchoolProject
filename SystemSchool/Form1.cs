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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int N = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            N++;
            label1.Text ="Cargando" + N.ToString() + "%";
            progressBar1.Value = N;
            if (N==100)
            {
                timer1.Stop();
                this.Hide();
                FrmLogin lg = new FrmLogin(); 
                lg.ShowDialog();
            }
        }
    }
}
