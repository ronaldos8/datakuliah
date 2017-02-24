using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace part3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void hitung()
        {
            DateTime tglPinjam;
            DateTime tglKembali;
            TimeSpan rentang;
            int lamaa;
            Decimal dendaa;

            tglPinjam = DateTime.Parse(pinjam.Text).Date;
            tglKembali = DateTime.Parse(kembali.Text).Date;

            rentang = tglKembali - tglPinjam;
            lamaa = rentang.Days;

            dendaa = 0;
            if (lamaa > 7)
            {
                dendaa = (lamaa - 7) * 5000;
            }

            lama.Text = Convert.ToString(lamaa);
            denda.Text = Convert.ToString(dendaa);
        }

        private void pinjam_ValueChanged(object sender, EventArgs e)
        {
            hitung();
        }

        private void kembali_ValueChanged(object sender, EventArgs e)
        {
            hitung();
        }
    }
}
