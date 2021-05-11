using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Altın_Toplama_Oyunu
{
    public partial class Oyun : Form
    {
        //Harita elemanları
        Button[,] buttons;
        int[,] degerler;

        // Gelen veriler
        public int genislik, yukseklik, altin, hamleSayisi, altinOrani, gizliOrani, aHamle, bHamle, cHamle, dHamle, aHedef, bHedef, cHedef, dHedef, cEk;

        // Form değişkenleri
        int kalanAltin, aHedefi = 0, bHedefi = 0, cHedefi = 0, dHedefi = 0,
            aKonum, bKonum, cKonum, dKonum,
            aAltin, bAltin, cAltin, dAltin, dTur = 0;

        // Diğer
        int gecikme = 50;
        int kontrolDegiskeni = 0;
        int duraklat = 0;


        private void dosyayaYaz()
        {
            string dosya_yolu;
            FileStream fs;
            StreamWriter sw;

            // A için
            dosya_yolu = @"A.txt";
            fs = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.Write);
            sw = new StreamWriter(fs);

            foreach (var satir in listBox1.Items)
            {
                sw.WriteLine(satir.ToString());
            }

            sw.Flush();
            sw.Close();
            fs.Close();

            // B için
            dosya_yolu = @"B.txt";
            fs = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.Write);
            sw = new StreamWriter(fs);

            foreach (var satir in listBox2.Items)
            {
                sw.WriteLine(satir.ToString());
            }

            sw.Flush();
            sw.Close();
            fs.Close();

            // C için
            dosya_yolu = @"C.txt";
            fs = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.Write);
            sw = new StreamWriter(fs);

            foreach (var satir in listBox3.Items)
            {
                sw.WriteLine(satir.ToString());
            }

            sw.Flush();
            sw.Close();
            fs.Close();

            // D için
            dosya_yolu = @"D.txt";
            fs = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.Write);
            sw = new StreamWriter(fs);

            foreach (var satir in listBox4.Items)
            {
                sw.WriteLine(satir.ToString());
            }

            sw.Flush();
            sw.Close();
            fs.Close();

        }

        private void dur_Click(object sender, EventArgs e)
        {
            duraklat = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (kalanAltin != 0)
            {
                if (aHedefi == 0)
                    aHedefSec();
                if (bHedefi == 0)
                    bHedefSec();
                if (cHedefi == 0)
                    cHedefSec();
                if (dHedefi == 0)
                    dHedefSec();

                if (aHedefi != 0)
                    Hareket(1, ref aKonum, ref aAltin, ref aHedefi);
                if (bHedefi != 0)
                    Hareket(2, ref bKonum, ref bAltin, ref bHedefi);
                if (cHedefi != 0)
                    Hareket(3, ref cKonum, ref cAltin, ref cHedefi);
                if (dHedefi != 0)
                    Hareket(4, ref dKonum, ref dAltin, ref dHedefi);
            }
            else
                dosyayaYaz();
            
        }

        public void wait(int milliseconds)
        {
            var timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            // sayaç başladı
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
                // sayaç bitti
            };

            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }

        private void baslat_Click(object sender, EventArgs e)
        {
            
            for (; kalanAltin != 0;)
            {
                if (aHedefi == 0)
                    aHedefSec();
                if (bHedefi == 0)
                    bHedefSec();
                if (cHedefi == 0)
                    cHedefSec();
                if (dHedefi == 0)
                    dHedefSec();

                //MessageBox.Show("Hedef bulma işlemi tamamlandı. Kalan Altın : " + kalanAltin.ToString());

                if (aHedefi != 0)
                    Hareket(1, ref aKonum, ref aAltin, ref aHedefi);
                if (bHedefi != 0)
                    Hareket(2, ref bKonum, ref bAltin, ref bHedefi);
                if (cHedefi != 0)
                    Hareket(3, ref cKonum, ref cAltin, ref cHedefi);
                if (dHedefi != 0)
                    Hareket(4, ref dKonum, ref dAltin, ref dHedefi);

                if (duraklat == 1)
                {
                    duraklat = 0;
                    break;
                }
            }
            dosyayaYaz();
            MessageBox.Show("Oyun Bitti");
        }

        private int Kontrol(int girdi, ref int konum, ref int altinMiktari, ref int hedef, TextBox altinTutucu, TextBox hedefTutucu)
        {
            int kYukseklik = konum / 100;
            int kGenislik = konum % 100;

            if (konum == hedef)
            {
                //MessageBox.Show("hedefteyiz " + hedef.ToString());
                if (hedef == aHedefi)
                    aHedefi = 0;
                if (hedef == bHedefi)
                    bHedefi = 0;
                if (hedef == cHedefi)
                    cHedefi = 0;
                if (hedef == dHedefi)
                    dHedefi = 0;

                hedef = 0;
                if (degerler[kYukseklik, kGenislik] != 0)
                    kalanAltin--;
                altinMiktari += degerler[kYukseklik, kGenislik];
                altinTutucu.Text = altinMiktari.ToString();
                degerler[kYukseklik, kGenislik] = 0;
                buttons[kYukseklik, kGenislik].BackgroundImage = null;
                hedefTutucu.Text = "";
                
                return 0;
            }
            else
            {
                if (degerler[kYukseklik, kGenislik] < 0)
                {
                    degerler[kYukseklik, kGenislik] *= -1;
                    buttons[kYukseklik, kGenislik].BackColor = Color.White;

                    int i = kYukseklik, j = kGenislik;

                    if (degerler[i, j] == 5)
                        buttons[i, j].BackgroundImage = Properties.Resources.altin5;
                    else if (degerler[i, j] == 10)
                        buttons[i, j].BackgroundImage = Properties.Resources.altin10;
                    else if (degerler[i, j] == 15)
                        buttons[i, j].BackgroundImage = Properties.Resources.altin15;
                    else if (degerler[i, j] == 20)
                        buttons[i, j].BackgroundImage = Properties.Resources.altin20;
                }
                else if (degerler[kYukseklik, kGenislik] > 0)
                {
                    kalanAltin--;
                    altinMiktari += degerler[kYukseklik, kGenislik];
                    altinTutucu.Text = altinMiktari.ToString();
                    degerler[kYukseklik, kGenislik] = 0;
                    buttons[kYukseklik, kGenislik].BackgroundImage = null;
                }
                return 1;
            }
        }

        private void Hareket(int girdi, ref int konum, ref int altinMiktari, ref int hedef)
        {
            Random random = new Random();
            int yon, gGenislik, gYukseklik, dikey, yatay, hamleSonuGider;
            string karakter = "";
            ListBox hamleListesi;
            TextBox altinTutucu, hedefTutucu;

            if (girdi == 1)
            {
                karakter = "A";
                hamleListesi = listBox1;
                altinTutucu = a_ninAltini;
                hedefTutucu = a_ninHedefi;
                hamleSonuGider = aHamle;
            }
            else if (girdi == 2)
            {
                karakter = "B";
                hamleListesi = listBox2;
                altinTutucu = b_ninAltini;
                hedefTutucu = b_ninHedefi;
                hamleSonuGider = bHamle;
            }
            else if (girdi == 3)
            {
                karakter = "C";
                hamleListesi = listBox3;
                altinTutucu = c_ninAltini;
                hedefTutucu = c_ninHedefi;
                hamleSonuGider = cHamle;
            }
            else
            {
                karakter = "D";
                hamleListesi = listBox4;
                altinTutucu = d_ninAltini;
                hedefTutucu = d_ninHedefi;
                hamleSonuGider = dHamle;
            }

            if (kontrolDegiskeni == 1)
                MessageBox.Show(karakter);

            for (int i = 0; i < hamleSayisi && hedef != 0; i++)
            {
                gGenislik = konum % 100;
                gYukseklik = konum / 100;
                dikey = konum / 100 - hedef / 100;
                yatay = konum % 100 - hedef % 100;

                if (dikey != 0 && yatay != 0)
                    yon = random.Next(1);
                else if (dikey == 0 && yatay != 0)
                    yon = 0;
                else if (dikey != 0 && yatay == 0)
                    yon = 1;
                else
                    yon = -1;

                buttons[gYukseklik, gGenislik].Text = "";

                if (yon == 0)
                {
                    if (yatay > 0)
                    {   // sola
                        buttons[gYukseklik, gGenislik - 1].Text = karakter;
                        konum = (gYukseklik) * 100 + gGenislik - 1;
                    }
                    else if (yatay < 0)
                    {   // sağa
                        buttons[gYukseklik, gGenislik + 1].Text = karakter;
                        konum = (gYukseklik) * 100 + gGenislik + 1;
                    }
                }
                else if (yon == 1)
                {
                    if (dikey > 0)
                    {   // yukarı
                        buttons[gYukseklik - 1, gGenislik].Text = karakter;
                        konum = (gYukseklik - 1) * 100 + gGenislik;
                    }
                    else if (dikey < 0)
                    {   // aşağı
                        buttons[gYukseklik + 1, gGenislik].Text = karakter;
                        konum = (gYukseklik + 1) * 100 + gGenislik;
                    }
                }

                string text = "";
                if (konum < 10)
                    text += "000";
                else if (konum < 100)
                    text += "00";
                else if (konum < 1000)
                    text += "0";
                text += konum.ToString();
                hamleListesi.Items.Add(text);

                wait(gecikme);

                int durum = Kontrol(girdi, ref konum, ref altinMiktari, ref hedef, altinTutucu, hedefTutucu);
                if (durum == 0)
                    break;
            }

            if (hedef != 0)
            {
                altinMiktari -= hamleSonuGider;
                altinTutucu.Text = altinMiktari.ToString();
            }

        }

        private void aHedefSec()
        {
            int gGenislik = aKonum % 100;
            int gYukseklik = aKonum / 100;
            int uzaklik = genislik + yukseklik;

            for (int i = 0; i < yukseklik && uzaklik != 1; i++)
                for (int j = 0; j < genislik && uzaklik != 1; j++)
                    if (degerler[i, j] > 0)
                        if (Math.Abs(gGenislik - j) + Math.Abs(gYukseklik - i) < uzaklik)
                        {
                            uzaklik = Math.Abs(gGenislik - j) + Math.Abs(gYukseklik - i);
                            aHedefi = i * 100 + j;
                        }

            string text = "";
            if (aHedefi < 10)
                text += "000";
            else if (aHedefi < 100)
                text += "00";
            else if (aHedefi < 1000)
                text += "0";
            text += aHedefi.ToString();
            a_ninHedefi.Text = text;
            aAltin -= aHamle;
            a_ninAltini.Text = aAltin.ToString();
        }

        private void bHedefSec()
        {
            int bGenislik = bKonum % 100;
            int bYukseklik = bKonum / 100;
            int kar = -(genislik + yukseklik);

            for (int i = 0; i < yukseklik; i++)
                for (int j = 0; j < genislik; j++)
                    if (degerler[i, j] > 0)
                    {
                        int uzaklik = Math.Abs(bGenislik - j) + Math.Abs(bYukseklik - i);

                        if (kar < degerler[i, j] - (uzaklik + (hamleSayisi - 1)) / hamleSayisi * bHamle)
                        {
                            kar = degerler[i, j] - (uzaklik + (hamleSayisi - 1)) / hamleSayisi * bHamle;
                            bHedefi = i * 100 + j;
                        }
                    }

            string text = "";
            if (bHedefi < 10)
                text += "000";
            else if (bHedefi < 100)
                text += "00";
            else if (bHedefi < 1000)
                text += "0";
            text += bHedefi.ToString();
            b_ninHedefi.Text = text;
            bAltin -= bHamle;
            b_ninAltini.Text = bAltin.ToString();
        }

        private void cGizliyiAc()
        {
            int cGenislik = cKonum % 100;
            int cYukseklik = cKonum / 100;
            int minUzaklik = genislik + yukseklik;
            int acilacak = 0;

            for (int i = 0; i < yukseklik; i++)
                for (int j = 0; j < genislik; j++)
                    if (degerler[i, j] < 0)
                    {
                        int uzaklik = Math.Abs(cGenislik - j) + Math.Abs(cYukseklik - i);

                        if (minUzaklik > uzaklik)
                        {
                            minUzaklik = uzaklik;
                            acilacak = i * 100 + j;
                        }
                    }

            if (acilacak != 0)
            {
                int acilacak_i = acilacak / 100;
                int acilacak_j = acilacak % 100;
                degerler[acilacak_i, acilacak_j] *= -1;
                buttons[acilacak_i, acilacak_j].BackColor = Color.White;

                if (degerler[acilacak_i, acilacak_j] == 5)
                    buttons[acilacak_i, acilacak_j].BackgroundImage = Properties.Resources.altin5;
                else if (degerler[acilacak_i, acilacak_j] == 10)
                    buttons[acilacak_i, acilacak_j].BackgroundImage = Properties.Resources.altin10;
                else if (degerler[acilacak_i, acilacak_j] == 15)
                    buttons[acilacak_i, acilacak_j].BackgroundImage = Properties.Resources.altin15;
                else if (degerler[acilacak_i, acilacak_j] == 20)
                    buttons[acilacak_i, acilacak_j].BackgroundImage = Properties.Resources.altin20;
            }
        }

        private void cHedefSec()
        {
            int gizliSayisi = genislik * yukseklik * altinOrani / 100 * gizliOrani / 100;

            if (gizliSayisi <= cEk)
                for (int i = 0; i < gizliSayisi; i++)
                    cGizliyiAc();
            else
                for (int i = 0; i < cEk; i++)
                    cGizliyiAc();

            int cGenislik = cKonum % 100;
            int cYukseklik = cKonum / 100;
            int kar = -(genislik + yukseklik);

            for (int i = 0; i < yukseklik; i++)
                for (int j = 0; j < genislik; j++)
                    if (degerler[i, j] > 0)
                    {
                        int uzaklik = Math.Abs(cGenislik - j) + Math.Abs(cYukseklik - i);

                        if (kar < degerler[i, j] - (uzaklik + (hamleSayisi - 1)) / hamleSayisi * cHamle)
                        {
                            kar = degerler[i, j] - (uzaklik + (hamleSayisi - 1)) / hamleSayisi * cHamle;
                            cHedefi = i * 100 + j;
                        }
                    }

            string text = "";
            if (cHedefi < 10)
                text += "000";
            else if (cHedefi < 100)
                text += "00";
            else if (cHedefi < 1000)
                text += "0";
            text += cHedefi.ToString();
            c_ninHedefi.Text = text;
            cAltin -= cHamle;
            c_ninAltini.Text = cAltin.ToString();
        }

        private void dHedefSec()
        {
            int dGenislik = dKonum % 100;
            int dYukseklik = dKonum / 100;
            int kar = -(genislik + yukseklik);

            for (int i = 0; i < yukseklik; i++)
                for (int j = 0; j < genislik; j++)
                    if (degerler[i, j] > 0)
                    {
                        int uzaklik = Math.Abs(dGenislik - j) + Math.Abs(dYukseklik - i);

                        if (kar < degerler[i, j] - (uzaklik + (hamleSayisi - 1)) / hamleSayisi * dHamle)
                        {
                            kar = degerler[i, j] - (uzaklik + (hamleSayisi - 1)) / hamleSayisi * dHamle;
                            dHedefi = i * 100 + j;
                        }
                    }

            /*
            if (dTur == 0)
                if (dHedefi == aHedefi || dHedefi == bHedefi || dHedefi == cHedefi)
                {
                    int aUzaklik = Math.Abs(aKonum % 100 - aHedefi % 100) + Math.Abs(aKonum / 100 - aHedefi / 100);
                    int bUzaklik = Math.Abs(bKonum % 100 - bHedefi % 100) + Math.Abs(bKonum / 100 - bHedefi / 100);
                    int cUzaklik = Math.Abs(cKonum % 100 - cHedefi % 100) + Math.Abs(cKonum / 100 - cHedefi / 100);

                    int dUzaklik = Math.Abs(dGenislik - dHedefi % 100) + Math.Abs(dYukseklik - dHedefi / 100);

                    if (dUzaklik >= aUzaklik || dUzaklik >= bUzaklik || dUzaklik >= cUzaklik)
                    {
                        dHedefSec();
                        dTur++;
                    }
                }
            */
            string text = "";
            if (dHedefi < 10)
                text += "000";
            else if (dHedefi < 100)
                text += "00";
            else if (dHedefi < 1000)
                text += "0";
            text += dHedefi.ToString();
            d_ninHedefi.Text = text;
            dAltin -= dHamle;
            d_ninAltini.Text = dAltin.ToString();

            dTur = 0;
        }

        private void kapanirken(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public Oyun()
        {
            InitializeComponent();
        }
        public void haritaOlusturucu()
        {
            for (int i = 0; i < yukseklik; i++)
                for (int j = 0; j < genislik; j++)
                    degerler[i, j] = 0;


            string maxGenislik = "";
            if (genislik - 1 < 10)
                maxGenislik += "0";
            maxGenislik += (genislik - 1).ToString();

            string maxYukseklik = "";
            if (yukseklik - 1 < 10)
                maxYukseklik += "0";
            maxYukseklik += (yukseklik - 1).ToString();

            listBox1.Items.Add("0000");
            listBox2.Items.Add("00" + maxGenislik);
            listBox3.Items.Add(maxYukseklik + "00");
            listBox4.Items.Add(maxYukseklik + maxGenislik);

            Random random = new Random();

            kalanAltin = (yukseklik * genislik * altinOrani / 100);
            int gizliSayisi = kalanAltin * gizliOrani / 100;
            int isaretlenen = 0;

            for (int i = 0; i < kalanAltin; i++)
            {
                int r1 = random.Next(0, yukseklik),
                    r2 = random.Next(0, genislik);

                aKonum = 0 * 100 + 0;
                bKonum = 0 * 100 + genislik - 1;
                cKonum = (yukseklik - 1) * 100 + 0;
                dKonum = (yukseklik - 1) * 100 + genislik - 1;

                // Köşe noktalarının seçilmesini engelledik
                if (r1 == 0)
                {
                    if (r2 == 0)
                    {
                        i--;
                        continue;
                    }
                    else if (r2 == genislik - 1)
                    {
                        i--;
                        continue;
                    }
                }
                else if (r1 == yukseklik - 1)
                {
                    if (r2 == 0)
                    {
                        i--;
                        continue;
                    }
                    else if (r2 == genislik - 1)
                    {
                        i--;
                        continue;
                    }
                }

                // Rastgele üretilen koordinata daha önceden atama yapılmış mı kontrolü
                if (degerler[r1, r2] == 0)
                {
                    degerler[r1, r2] = random.Next(1, 5) * 5;
                    if (isaretlenen < gizliSayisi)
                    {
                        degerler[r1, r2] *= -1;
                        isaretlenen++;
                    }
                }
                else
                {
                    i--;
                    continue;
                }
            }
        }
        private void Oyun_Load(object sender, EventArgs e)
        {
            buttons = new Button[yukseklik, genislik];
            degerler = new int[yukseklik, genislik];

            int top = oyunAlani.Height / 2 - (yukseklik / 2) * 30,
                sabitLeft = oyunAlani.Width / 2 - (genislik / 2) * 30,
                left = sabitLeft;

            aAltin = altin;
            bAltin = altin;
            cAltin = altin;
            dAltin = altin;

            a_ninAltini.Text = aAltin.ToString();
            b_ninAltini.Text = bAltin.ToString();
            c_ninAltini.Text = cAltin.ToString();
            d_ninAltini.Text = dAltin.ToString();

            // Harita oluşturalım
            haritaOlusturucu();

            for (int i = 0; i < yukseklik; i++)
            {
                for (int j = 0; j < genislik; j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Width = 30;
                    buttons[i, j].Height = 30;
                    buttons[i, j].Left = left;
                    buttons[i, j].Top = top;
                    buttons[i, j].BackColor = Color.White;
                    buttons[i, j].BackgroundImageLayout = ImageLayout.Stretch;

                    if (degerler[i, j] < 0)
                    {
                        //degerler[i, j] *= -1;
                        buttons[i, j].BackColor = Color.Black;
                    }

                    if (degerler[i, j] == 5)
                        buttons[i, j].BackgroundImage = Properties.Resources.altin5;
                    else if (degerler[i, j] == 10)
                        buttons[i, j].BackgroundImage = Properties.Resources.altin10;
                    else if (degerler[i, j] == 15)
                        buttons[i, j].BackgroundImage = Properties.Resources.altin15;
                    else if (degerler[i, j] == 20)
                        buttons[i, j].BackgroundImage = Properties.Resources.altin20;
                    left += 30;
                    oyunAlani.Controls.Add(buttons[i, j]);
                }
                top += 30;
                left = sabitLeft;
            }

            for (int i = 0; i < yukseklik; i++)
            {
                Button button = new Button();
                button.Width = 40;
                button.Height = 30;
                button.Left = buttons[i, 0].Location.X - 40;
                button.Top = buttons[i, 0].Location.Y;
                button.Text = i.ToString();
                oyunAlani.Controls.Add(button);
            }

            for (int i = 0; i < genislik; i++)
            {
                Button button = new Button();
                button.Width = 32;
                button.Height = 30;
                button.Left = buttons[0, i].Location.X;
                button.Top = buttons[0, i].Location.Y - 30;
                button.Text = i.ToString();
                oyunAlani.Controls.Add(button);
            }

            buttons[0, 0].Text = "A";
            buttons[0, genislik - 1].Text = "B";
            buttons[yukseklik - 1, 0].Text = "C";
            buttons[yukseklik - 1, genislik - 1].Text = "D";
        }
    }
}
