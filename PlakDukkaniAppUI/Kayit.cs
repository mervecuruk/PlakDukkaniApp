using PlakDukkaniApp;
using PlakDukkaniApp.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlakDukkaniAppUI
{
    public partial class Kayit : Form
    {
        private readonly AppDbContext db;
        public Kayit()
        {
            InitializeComponent();
            db = new AppDbContext();
        }


        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            //var kullaniciAdi = txtKullaniciAdi.Text;
            //var sifre = txtSifre.Text;
            //var tekrarSifre = txtTekrarSifre.Text;

            //var yonetici = new Yonetici
            //{
            //    KullaniciAdi = kullaniciAdi,
            //    Sifre = sha256_hash(sifre)

            //};        
            //if (SifreKontrol(sifre) == true && !YoneticiAdiKontrol(kullaniciAdi))
            //{
            //    db.Yoneticiler.Add(yonetici);
            //    db.SaveChanges();
            //}
            //else
            //    MessageBox.Show("Yanlış Kullanıcı Adı veya Şifre Girdiniz");

            //this.Close();
            var kullaniciAdi = txtKullaniciAdi.Text;
            var sifre = txtSifre.Text;

            // Şifre ve kullanıcı adı kontrolü
            if (!SifreKontrol(sifre))
            {
                MessageBox.Show("Şifre kriterlerine uymuyor! Lütfen geçerli bir şifre girin.");
                return;
            }

            if (YoneticiAdiKontrol(kullaniciAdi))
            {
                MessageBox.Show("Bu kullanıcı adı zaten kullanılıyor! Lütfen farklı bir kullanıcı adı seçin.");
                return;
            }

            // Yönetici nesnesini oluştur ve veritabanına kaydet
            var yonetici = new Yonetici()
            {
                KullaniciAdi = kullaniciAdi,
                Sifre = sha256_hash(sifre),
            };

            db.Yoneticiler.Add(yonetici);
            db.SaveChanges();

            MessageBox.Show("Yönetici başarıyla kaydedildi!");

            // Albumler formunu göster, kayıt formunu gizle
            Albumler albumler = new Albumler();
            albumler.Show();
            this.Hide();

        }
        private string sha256_hash(string sifre)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(sifre)).Select(l => l.ToString("X2")));
            }
        }
        private bool YoneticiAdiKontrol(string kullaniciAdi)
        {
            return db.Yoneticiler.Any(x=>x.KullaniciAdi==kullaniciAdi);
            
        }
        private bool SifreKontrol(string sifre)
        {
            //int buyukHarfKontrol = sifre.Count(char.IsUpper);
            //int kucukHarfKontrol = sifre.Count(char.IsLower);
            //string icerik = "!,:,+,*";
            //int ozelKarakter=sifre.Count(x=>icerik.Contains(x));

            //if (sifre.Length < 8)
            //{ 
            //    return false;
            //}
            // if (buyukHarfKontrol < 2)
            //{
            //    return false;
            //}
            // if (kucukHarfKontrol < 3)
            //{
            //    return false;
            //}
            //if (ozelKarakter < 2)
            //{
            //    return false;
            //}

            //return true;

            // Şifre uzunluğu en az 8 karakter olmalı
            if (sifre.Length < 8)
            {
                return false;
            }

            // En az 2 büyük harf kontrolü
            int buyukHarfSayisi = sifre.Count(char.IsUpper);
            if (buyukHarfSayisi < 2)
            {
                return false;
            }

            // En az 3 küçük harf kontrolü
            int kucukHarfSayisi = sifre.Count(char.IsLower);
            if (kucukHarfSayisi < 3)
            {
                return false;
            }

            // Özel karakterler kontrolü
            string ozelKarakterler = "!:;+*";
            int ozelKarakterSayisi = sifre.Count(c => ozelKarakterler.Contains(c));
            if (ozelKarakterSayisi < 2)
            {
                return false;
            }
            return true;
           


        }
    }
}
