using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sikidomok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kerulet.Value = (aoldal.Value + boldal.Value) * 2;
            terulet.Value = aoldal.Value * boldal.Value;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal r = korr.Value;

            decimal k = 2 * r * (decimal)Math.PI;
            decimal t = r * r * (decimal)Math.PI;

            kork.Value = k;
            kort.Value = t;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            haromk.Value = haroma.Value + haromb.Value + haromc.Value;
            decimal s = haromk.Value / 2;
            haromt.Value = s * (decimal)Math.Sqrt((double)(s * (s - haroma.Value) * (s - haromb.Value) * (s * haromc.Value)));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            negyk.Value = 4 * negya.Value;
            negyt.Value = (decimal)Math.Pow((double)negya.Value, 2);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            hatk.Value = 6 * hata.Value;
            hatt.Value = (decimal)((2 / 3) * Math.Pow((double)hata.Value, 2) * Math.Sqrt(3));
        }
    }
}
