using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Altın_Toplama_Oyunu
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void harfEngelleme(object sender, KeyPressEventArgs e)
        {
            TextBox alinanTB = (TextBox)sender;
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
                e.Handled = true;
            else
                e.Handled = false;
        }

        private void hamleHedefSinirlayici(object sender, EventArgs e)
        {
            TextBox alinanTB = (TextBox)sender;

            if (alinanTB.Text.Length != 0)
            {
                double girdi = Convert.ToDouble(alinanTB.Text);
                if (girdi < 0)
                    alinanTB.Text = "5";
                else if (girdi > 30)
                    alinanTB.Text = "30";
            }
        }

        private void altinSinir(object sender, EventArgs e)
        {
            TextBox alinanTB = (TextBox)sender;

            if (alinanTB.Text.Length != 0)
            {
                double girdi = Convert.ToDouble(alinanTB.Text);
                if (girdi < 200)
                    alinanTB.Text = "200";
                else if (girdi > 1000)
                    alinanTB.Text = "1000";
            }
        }

        private void basla_Click(object sender, EventArgs e)
        {
            textBox12.Focus();

            Oyun oyun = new Oyun();
            oyun.yukseklik = Convert.ToInt32(yukseklik.Text);
            oyun.genislik = Convert.ToInt32(genislik.Text);
            oyun.altinOrani = Convert.ToInt32(altinOrani.Text);
            oyun.gizliOrani = Convert.ToInt32(gizliOrani.Text);
            oyun.altin = Convert.ToInt32(altin.Text);
            oyun.hamleSayisi = Convert.ToInt32(hamleSayisi.Text);
            oyun.aHamle = Convert.ToInt32(aHamle.Text);
            oyun.bHamle = Convert.ToInt32(bHamle.Text);
            oyun.cHamle = Convert.ToInt32(cHamle.Text);
            oyun.dHamle = Convert.ToInt32(dHamle.Text);
            oyun.aHedef = Convert.ToInt32(aHedef.Text);
            oyun.bHedef = Convert.ToInt32(bHedef.Text);
            oyun.cHedef = Convert.ToInt32(cHedef.Text);
            oyun.dHedef = Convert.ToInt32(dHedef.Text);
            oyun.cEk = Convert.ToInt32(cEk.Text);

            oyun.Show();
            this.Hide();
        }

        private void yukseklikSinir(object sender, EventArgs e)
        {
            TextBox alinanTB = (TextBox)sender;

            if (alinanTB.Text.Length != 0)
            {
                double girdi = Convert.ToDouble(alinanTB.Text);
                if (girdi < 10)
                    alinanTB.Text = "10";
                else if (girdi > 20)
                    alinanTB.Text = "20";
            }
        }

        private void genislikSinir(object sender, EventArgs e)
        {
            TextBox alinanTB = (TextBox)sender;

            if (alinanTB.Text.Length != 0)
            {
                double girdi = Convert.ToDouble(alinanTB.Text);
                if (girdi < 10)
                    alinanTB.Text = "10";
                else if (girdi > 30)
                    alinanTB.Text = "30";
            }
        }

        private void hareketSayisi_Leave(object sender, EventArgs e)
        {
            TextBox alinanTB = (TextBox)sender;

            if (alinanTB.Text.Length != 0)
            {
                double girdi = Convert.ToDouble(alinanTB.Text);
                if (girdi < 1)
                    alinanTB.Text = "1";
                else if (girdi > 5)
                    alinanTB.Text = "5";
            }
        }

        private void cEk_Leave(object sender, EventArgs e)
        {
            TextBox alinanTB = (TextBox)sender;

            if (alinanTB.Text.Length != 0)
            {
                double girdi = Convert.ToDouble(alinanTB.Text);
                if (girdi < 1)
                    alinanTB.Text = "1";
                else if (girdi > 3)
                    alinanTB.Text = "3";
            }
        }
    }
}
