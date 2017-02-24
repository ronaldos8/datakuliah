using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace partTambahan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void jenis_SelectedIndexChanged(object sender, EventArgs e)
        {
            hitung();
        }

        private void hitung()
        {
            DateTime msk;
            DateTime klr;
            TimeSpan rentang;
            int lamaa;
            Decimal hargaa;

            String jns = jenis.Text;

            msk = DateTime.Parse(masuk.Text).Date;
            klr = DateTime.Parse(keluar.Text).Date;

            rentang = klr - msk;
            lamaa = rentang.Hours;
            MessageBox.Show(""+lamaa,"aww");
            hargaa = 0;

            /*switch (jns)
            {
                case "Motor": hargaa = lamaa * 2000;
                    break;
                case "Mobil": hargaa = lamaa * 3000;
                    break;
            }*/
            if (jns == "Motor")
            {
                hargaa = lamaa * 2000;
            }
            else
            {
                hargaa = lamaa * 3000;
            }

            lama.Text = Convert.ToString(lamaa);
            harga.Text = Convert.ToString(hargaa);
        }

        private void masuk_ValueChanged(object sender, EventArgs e)
        {
            hitung();
        }

        private void keluar_ValueChanged(object sender, EventArgs e)
        {
            hitung();
        }
    }
}
