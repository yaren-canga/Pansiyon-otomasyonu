using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace pansiyonOtomasyonu
{
    public partial class frmMusteriKayit : Form
    {
        public frmMusteriKayit()
        {
            InitializeComponent();
        }
        protected override void WndProc(ref Message m)

        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                    {
                        m.Result = (IntPtr)0x2;
                    }
                    return;
            }
            base.WndProc(ref m);
        }
        ArrayList odalar = new ArrayList();
        void koltukYazdır()
        {
            string oda = "";
            for (int i = 0; i < odalar.Count; i++)
            {
                oda += odalar[i].ToString() + " ,";
            }
            if(odalar.Count >= 1)
            {
                oda = oda.Remove(oda.Length - 1, 1);
            }
            txtOda.Text = oda;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmMusteriKayit_Load(object sender, EventArgs e)
        {
            tmrKontrol.Start();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void odaTikla(object sender, EventArgs e)
        {
            if(((Button)sender).BackColor == Color.Lime)
            {
                ((Button)sender).BackColor = Color.Yellow;
                if (!odalar.Contains(((Button)sender).Text))
                {
                    odalar.Add(((Button)sender).Text);
                }
                koltukYazdır();
            }
            else if (((Button)sender).BackColor == Color.Yellow)
            {
                ((Button)sender).BackColor = Color.Lime;
                if(odalar.Contains(((Button)sender).Text))
                {
                    odalar.Remove(((Button)sender).Text);
                }
                koltukYazdır();
            }
        }


        public DateTime girisTarihi { get; set; }
        public DateTime cikisTarihi { get; set; }
        private void button1_Click(object sender, EventArgs e)
        {
            girisTarihi = Convert.ToDateTime(dateTimePicker1.Value);
            cikisTarihi = Convert.ToDateTime(dateTimePicker2.Value);
            musteriKayit kayit = new musteriKayit();
            for(int i=0;i<odalar.Count; i++)
            {
                string oda = odalar[i].ToString();
                kayit.kayitAl(txtAdi.Text, txtSoyadi.Text, cmbCinsiyet.Text, txtTelefon.Text, txtMail.Text, txtTc.Text, txtUcret.Text, girisTarihi, cikisTarihi);
               
            }
            tmrKontrol.Start();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void tmrKontrol_Tick(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            if (db.baglanti.State == ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try
            {
                db.baglanti.Open();
                SqlCommand donustur = new SqlCommand("select * from odalar where durumu=@durum", db.baglanti);
                donustur.Parameters.AddWithValue("@durum", "Dolu");
                SqlDataReader donustur_Oku = donustur.ExecuteReader();
                while (donustur_Oku.Read())
                {
                    string butonAdi = donustur_Oku["butonAdi"].ToString();
                    string durumu = donustur_Oku["durumu"].ToString();
                    if(butonAdi == "oda1" && durumu == "Dolu")
                    {
                        oda1.BackColor = Color.Red;
                    }
                    if (butonAdi == "oda2" && durumu == "Dolu")
                    {
                        oda2.BackColor = Color.Red;
                    }
                    if (butonAdi == "oda3" && durumu == "Dolu")
                    {
                        oda3.BackColor = Color.Red;
                    }
                    if (butonAdi == "oda4" && durumu == "Dolu")
                    {
                        oda4.BackColor = Color.Red;
                    }
                    if (butonAdi == "oda5" && durumu == "Dolu")
                    {
                        oda5.BackColor = Color.Red;
                    }
                    if (butonAdi == "oda6" && durumu == "Dolu")
                    {
                        oda6.BackColor = Color.Red;
                    }
                    if (butonAdi == "oda7" && durumu == "Dolu")
                    {
                        oda7.BackColor = Color.Red;
                    }
                    if (butonAdi == "oda8" && durumu == "Dolu")
                    {
                        oda8.BackColor = Color.Red;
                    }
                    if (butonAdi == "oda9" && durumu == "Dolu")
                    {
                        oda9.BackColor = Color.Red;
                    }
                    if (butonAdi == "oda10" && durumu == "Dolu")
                    {
                        oda10.BackColor = Color.Red;
                    }
                    if (butonAdi == "oda11" && durumu == "Dolu")
                    {
                        oda11.BackColor = Color.Red;
                    }
                    if (butonAdi == "oda12" && durumu == "Dolu")
                    {
                        oda12.BackColor = Color.Red;
                    }
                    if (butonAdi == "oda13" && durumu == "Dolu")
                    {
                        oda13.BackColor = Color.Red;
                    }
                    if (butonAdi == "oda14" && durumu == "Dolu")
                    {
                        oda14.BackColor = Color.Red;
                    }
                    if (butonAdi == "oda15" && durumu == "Dolu")
                    {
                        oda15.BackColor = Color.Red;
                    }
                    if (butonAdi == "oda16" && durumu == "Dolu")
                    {
                        oda16.BackColor = Color.Red;
                    }
                    if (butonAdi == "oda17" && durumu == "Dolu")
                    {
                        oda17.BackColor = Color.Red;
                    }
                    if (butonAdi == "oda18" && durumu == "Dolu")
                    {
                        oda18.BackColor = Color.Red;
                    }
                    if (butonAdi == "oda19" && durumu == "Dolu")
                    {
                        oda19.BackColor = Color.Red;
                    }
                    if (butonAdi == "oda20" && durumu == "Dolu")
                    {
                        oda20.BackColor = Color.Red;
                    }
                }
                donustur.Dispose();
                donustur_Oku.Close();
                db.baglanti.Close();
                tmrKontrol.Stop();

            }
            catch { }
            finally
            {
                db.baglanti.Close();
            }
        }
    }
}
