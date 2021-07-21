using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace karlstad
{
    public partial class startaLottaButton : Form
    {
        static Random rand = new Random();
        public startaLottaButton()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = rand.Next(1, 35);
            int b = rand.Next(1, 35);
            int c = rand.Next(1, 35);
            int d = rand.Next(1, 35);
            int r = rand.Next(1, 35);
            int f = rand.Next(1, 35);
            int g = rand.Next(1, 35);

            textBox1.Text = a.ToString();
            textBox11.Text = b.ToString();
            textBox10.Text = c.ToString();
            textBox9.Text = d.ToString();
            textBox8.Text = r.ToString();
            textBox7.Text = f.ToString();
            textBox6.Text = g.ToString();

        }
    }
}
