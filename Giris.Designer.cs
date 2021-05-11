namespace Altın_Toplama_Oyunu
{
    partial class Giris
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            this.cikis = new System.Windows.Forms.Panel();
            this.yukseklik = new System.Windows.Forms.TextBox();
            this.genislik = new System.Windows.Forms.TextBox();
            this.aHamle = new System.Windows.Forms.TextBox();
            this.bHamle = new System.Windows.Forms.TextBox();
            this.cHamle = new System.Windows.Forms.TextBox();
            this.dHamle = new System.Windows.Forms.TextBox();
            this.dHedef = new System.Windows.Forms.TextBox();
            this.cHedef = new System.Windows.Forms.TextBox();
            this.bHedef = new System.Windows.Forms.TextBox();
            this.aHedef = new System.Windows.Forms.TextBox();
            this.cEk = new System.Windows.Forms.TextBox();
            this.basla = new System.Windows.Forms.Panel();
            this.altinOrani = new System.Windows.Forms.TextBox();
            this.gizliOrani = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.altin = new System.Windows.Forms.TextBox();
            this.hamleSayisi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cikis
            // 
            this.cikis.BackColor = System.Drawing.Color.Transparent;
            this.cikis.Location = new System.Drawing.Point(543, -1);
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(42, 39);
            this.cikis.TabIndex = 0;
            this.cikis.Click += new System.EventHandler(this.cikis_Click);
            // 
            // yukseklik
            // 
            this.yukseklik.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yukseklik.Location = new System.Drawing.Point(308, 121);
            this.yukseklik.Name = "yukseklik";
            this.yukseklik.Size = new System.Drawing.Size(41, 34);
            this.yukseklik.TabIndex = 1;
            this.yukseklik.Text = "20";
            this.yukseklik.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.yukseklik.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.harfEngelleme);
            this.yukseklik.Leave += new System.EventHandler(this.yukseklikSinir);
            // 
            // genislik
            // 
            this.genislik.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.genislik.Location = new System.Drawing.Point(374, 121);
            this.genislik.Name = "genislik";
            this.genislik.Size = new System.Drawing.Size(41, 34);
            this.genislik.TabIndex = 2;
            this.genislik.Text = "20";
            this.genislik.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.genislik.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.harfEngelleme);
            this.genislik.Leave += new System.EventHandler(this.genislikSinir);
            // 
            // aHamle
            // 
            this.aHamle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aHamle.Location = new System.Drawing.Point(232, 247);
            this.aHamle.Name = "aHamle";
            this.aHamle.Size = new System.Drawing.Size(41, 30);
            this.aHamle.TabIndex = 3;
            this.aHamle.Text = "5";
            this.aHamle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.aHamle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.harfEngelleme);
            this.aHamle.Leave += new System.EventHandler(this.hamleHedefSinirlayici);
            // 
            // bHamle
            // 
            this.bHamle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bHamle.Location = new System.Drawing.Point(232, 278);
            this.bHamle.Name = "bHamle";
            this.bHamle.Size = new System.Drawing.Size(41, 30);
            this.bHamle.TabIndex = 4;
            this.bHamle.Text = "5";
            this.bHamle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bHamle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.harfEngelleme);
            this.bHamle.Leave += new System.EventHandler(this.hamleHedefSinirlayici);
            // 
            // cHamle
            // 
            this.cHamle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cHamle.Location = new System.Drawing.Point(232, 309);
            this.cHamle.Name = "cHamle";
            this.cHamle.Size = new System.Drawing.Size(41, 30);
            this.cHamle.TabIndex = 5;
            this.cHamle.Text = "5";
            this.cHamle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cHamle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.harfEngelleme);
            this.cHamle.Leave += new System.EventHandler(this.hamleHedefSinirlayici);
            // 
            // dHamle
            // 
            this.dHamle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dHamle.Location = new System.Drawing.Point(232, 340);
            this.dHamle.Name = "dHamle";
            this.dHamle.Size = new System.Drawing.Size(41, 30);
            this.dHamle.TabIndex = 6;
            this.dHamle.Text = "5";
            this.dHamle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dHamle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.harfEngelleme);
            this.dHamle.Leave += new System.EventHandler(this.hamleHedefSinirlayici);
            // 
            // dHedef
            // 
            this.dHedef.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dHedef.Location = new System.Drawing.Point(309, 340);
            this.dHedef.Name = "dHedef";
            this.dHedef.Size = new System.Drawing.Size(41, 30);
            this.dHedef.TabIndex = 10;
            this.dHedef.Text = "20";
            this.dHedef.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dHedef.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.harfEngelleme);
            this.dHedef.Leave += new System.EventHandler(this.hamleHedefSinirlayici);
            // 
            // cHedef
            // 
            this.cHedef.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cHedef.Location = new System.Drawing.Point(309, 309);
            this.cHedef.Name = "cHedef";
            this.cHedef.Size = new System.Drawing.Size(41, 30);
            this.cHedef.TabIndex = 9;
            this.cHedef.Text = "15";
            this.cHedef.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cHedef.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.harfEngelleme);
            this.cHedef.Leave += new System.EventHandler(this.hamleHedefSinirlayici);
            // 
            // bHedef
            // 
            this.bHedef.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bHedef.Location = new System.Drawing.Point(309, 278);
            this.bHedef.Name = "bHedef";
            this.bHedef.Size = new System.Drawing.Size(41, 30);
            this.bHedef.TabIndex = 8;
            this.bHedef.Text = "10";
            this.bHedef.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bHedef.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.harfEngelleme);
            this.bHedef.Leave += new System.EventHandler(this.hamleHedefSinirlayici);
            // 
            // aHedef
            // 
            this.aHedef.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aHedef.Location = new System.Drawing.Point(309, 247);
            this.aHedef.Name = "aHedef";
            this.aHedef.Size = new System.Drawing.Size(41, 30);
            this.aHedef.TabIndex = 7;
            this.aHedef.Text = "5";
            this.aHedef.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.aHedef.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.harfEngelleme);
            this.aHedef.Leave += new System.EventHandler(this.hamleHedefSinirlayici);
            // 
            // cEk
            // 
            this.cEk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cEk.Location = new System.Drawing.Point(381, 309);
            this.cEk.Name = "cEk";
            this.cEk.Size = new System.Drawing.Size(41, 30);
            this.cEk.TabIndex = 11;
            this.cEk.Text = "2";
            this.cEk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cEk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.harfEngelleme);
            this.cEk.Leave += new System.EventHandler(this.cEk_Leave);
            // 
            // basla
            // 
            this.basla.BackColor = System.Drawing.Color.Transparent;
            this.basla.Location = new System.Drawing.Point(283, 385);
            this.basla.Name = "basla";
            this.basla.Size = new System.Drawing.Size(162, 83);
            this.basla.TabIndex = 1;
            this.basla.Click += new System.EventHandler(this.basla_Click);
            // 
            // altinOrani
            // 
            this.altinOrani.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(131)))), ((int)(((byte)(237)))));
            this.altinOrani.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.altinOrani.Location = new System.Drawing.Point(441, 125);
            this.altinOrani.Name = "altinOrani";
            this.altinOrani.Size = new System.Drawing.Size(32, 30);
            this.altinOrani.TabIndex = 12;
            this.altinOrani.Text = "20";
            this.altinOrani.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.altinOrani.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.harfEngelleme);
            // 
            // gizliOrani
            // 
            this.gizliOrani.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(131)))), ((int)(((byte)(237)))));
            this.gizliOrani.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gizliOrani.Location = new System.Drawing.Point(495, 125);
            this.gizliOrani.Name = "gizliOrani";
            this.gizliOrani.Size = new System.Drawing.Size(32, 30);
            this.gizliOrani.TabIndex = 13;
            this.gizliOrani.Text = "10";
            this.gizliOrani.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gizliOrani.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.harfEngelleme);
            // 
            // textBox12
            // 
            this.textBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox12.Location = new System.Drawing.Point(608, 170);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(41, 34);
            this.textBox12.TabIndex = 0;
            this.textBox12.Text = "20";
            this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // altin
            // 
            this.altin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.altin.Location = new System.Drawing.Point(62, 309);
            this.altin.Name = "altin";
            this.altin.Size = new System.Drawing.Size(60, 30);
            this.altin.TabIndex = 14;
            this.altin.Text = "200";
            this.altin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.altin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.harfEngelleme);
            this.altin.Leave += new System.EventHandler(this.altinSinir);
            // 
            // hamleSayisi
            // 
            this.hamleSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.hamleSayisi.Location = new System.Drawing.Point(488, 319);
            this.hamleSayisi.Name = "hamleSayisi";
            this.hamleSayisi.Size = new System.Drawing.Size(60, 30);
            this.hamleSayisi.TabIndex = 15;
            this.hamleSayisi.Text = "3";
            this.hamleSayisi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hamleSayisi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.harfEngelleme);
            this.hamleSayisi.Leave += new System.EventHandler(this.hareketSayisi_Leave);
            // 
            // Giris
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(582, 573);
            this.Controls.Add(this.hamleSayisi);
            this.Controls.Add(this.altin);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.gizliOrani);
            this.Controls.Add(this.altinOrani);
            this.Controls.Add(this.basla);
            this.Controls.Add(this.cEk);
            this.Controls.Add(this.dHedef);
            this.Controls.Add(this.cHedef);
            this.Controls.Add(this.bHedef);
            this.Controls.Add(this.aHedef);
            this.Controls.Add(this.dHamle);
            this.Controls.Add(this.cHamle);
            this.Controls.Add(this.bHamle);
            this.Controls.Add(this.aHamle);
            this.Controls.Add(this.genislik);
            this.Controls.Add(this.yukseklik);
            this.Controls.Add(this.cikis);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Altın Toplama Oyunu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel cikis;
        private System.Windows.Forms.TextBox yukseklik;
        private System.Windows.Forms.TextBox genislik;
        private System.Windows.Forms.TextBox aHamle;
        private System.Windows.Forms.TextBox bHamle;
        private System.Windows.Forms.TextBox cHamle;
        private System.Windows.Forms.TextBox dHamle;
        private System.Windows.Forms.TextBox dHedef;
        private System.Windows.Forms.TextBox cHedef;
        private System.Windows.Forms.TextBox bHedef;
        private System.Windows.Forms.TextBox aHedef;
        private System.Windows.Forms.TextBox cEk;
        private System.Windows.Forms.Panel basla;
        private System.Windows.Forms.TextBox altinOrani;
        private System.Windows.Forms.TextBox gizliOrani;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox altin;
        private System.Windows.Forms.TextBox hamleSayisi;
    }
}

