using PlakDukkaniApp.Context;

namespace PlakDukkaniAppUI
{
    public partial class Form1 : Form
    {
        private readonly AppDbContext db;
        public Form1()
        {
            InitializeComponent();
            db = new AppDbContext();
        }

        private void linkKayitOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Kayit KayitOl = new Kayit();
            KayitOl.Show();
           
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            var kullaniciAdi=txtKullaniciAdi.Text;
            var sifre=txtSifre.Text;
            
            var Yonetici=db.Yoneticiler.FirstOrDefault(y=>y.KullaniciAdi==kullaniciAdi && y.Sifre==sifre);
            if (Yonetici is not null)
            {
            MessageBox.Show("Kullan�c� Ad� veya Sifre Hatal�d�r");

            }
            else
                MessageBox.Show("Giri� Ba�ar�l�");
            Albumler albumler = new Albumler();
            albumler.Show();
        }
    }
}
