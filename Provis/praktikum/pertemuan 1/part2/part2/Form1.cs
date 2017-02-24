using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace part2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            hitung_Click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //bersihkan semua text box
            nomor.Clear();
            kepada.Clear();
            alamat.Clear();
            jenis.Text = "";
            ongkos.Clear();
            berat.Clear();

            //arahkan fokus ke nomor
            nomor.Focus();
        }

        private void hitung_Click(object sender, EventArgs e)
        {
            //ambil data jenis
            string jns;
            jns = jenis.Text;

            //ambil data asuransi
            Boolean asur;
            asur = asuransi.Checked;

            

            //hitung ongkos
            decimal oks = 0;
            if (berat.Text != "")
            {
                //ambil data berat
                decimal brt;
                brt = Convert.ToDecimal(berat.Text);

                /*if (jns == "Reguler")
                {
                    oks = 1000;
                }
                else if (jns == "Kilat")
                {
                    oks = 2000;
                }
                else if (jns == "ONS")
                {
                    oks = 3000;
                }*/
                switch (jns)
                {
                    case "Reguler": oks = 1000;
                        break;
                    case "Kilat": oks = 2000;
                        break;
                    case "ONS": oks = 3000;
                        break;
                }
                oks = oks * brt;
            }

            

            if (asur)
            {
                //setiap asuransi dikenai biaya tambahan 5%
                oks = oks * 105 / 100;
            }

            //tampilkan ongkos
            ongkos.Text = Convert.ToString(oks);
        }

        private void berat_TextChanged(object sender, EventArgs e)
        {
            hitung_Click(sender, e);
        }

        private void asuransi_CheckedChanged(object sender, EventArgs e)
        {
            hitung_Click(sender, e);
        }

        private void berat_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            //hitung_Click(sender, e);
        }

        private void berat_TextChanged_1(object sender, EventArgs e)
        {
            hitung_Click(sender, e);
        }
    }
}
