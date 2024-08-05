using PlakDukkaniApp;
using PlakDukkaniApp.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlakDukkaniAppUI
{
    public partial class Albumler : Form
    {
        private readonly AppDbContext db;
        public Albumler()
        {
            InitializeComponent();
            db = new AppDbContext();
        }

        private void btnAlbumEkleveyaGuncelle_Click(object sender, EventArgs e)
        {
            AlbumEkleGuncelle albumEkleGuncelle = new AlbumEkleGuncelle();
            albumEkleGuncelle.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
          
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

       private void LoadAlbumler() { dgvAlbumler.DataSource = db.Albumler.ToList(); }
        private void Albumler_Load(object sender, EventArgs e)
        {
            dgvAlbumler.DataSource = db.Albumler.ToList();
        }

        // Albumler secilenAlbum;
        private void btnAlbumSil_Click(object sender, EventArgs e)
        {
            if (dgvAlbumler.SelectedRows.Count > 0)
            {
                int selectedAlbumId = Convert.ToInt32(dgvAlbumler.SelectedRows[0].Cells[0].Value);
                var album = db.Albumler.Find(selectedAlbumId);

                if (album != null)
                {
                    db.Albumler.Remove(album);
                    db.SaveChanges();
                    LoadAlbumler();
                    MessageBox.Show("Albüm başarıyla silindi.");
                }
                else
                {
                    MessageBox.Show("Albüm bulunamadı.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz albümü seçin.");
            }

        }

        private void btnSatisiDurmusAlbum_Click(object sender, EventArgs e)
        {
            dgvAlbumler.DataSource = db.Albumler.Where(album => album.SatisiDevamEdiyorMu == SatisDurumu.SatisDurmus).Select(a => new { a.AlbumAdi, Sanatci = a.SanatciAdi + " " + a.SanatciSoyadi }).ToList();
        }

        private void btnSatisiDevamEdenAlbum_Click(object sender, EventArgs e)
        {
            dgvAlbumler.DataSource = db.Albumler.Where(album => album.SatisiDevamEdiyorMu == SatisDurumu.SatisDevamEdiyor).Select(a => new { a.AlbumAdi, Sanatci = a.SanatciAdi + " " + a.SanatciSoyadi }).ToList();
        }

        private void btnSistemeSonEklenenAlbum_Click(object sender, EventArgs e)
        {
            dgvAlbumler.DataSource = db.Albumler.OrderByDescending(x => x.Id).Take(10).Select(a => new { a.AlbumAdi, Sanatci = a.SanatciAdi + " " + a.SanatciSoyadi }).ToList();
        }

        private void btnIndirimdekiAlbumler_Click(object sender, EventArgs e)
        {

            dgvAlbumler.DataSource = db.Albumler.Where(a => a.IndirimOrani.HasValue && a.IndirimOrani > 0).OrderByDescending(a => a.IndirimOrani).Select(a => new { a.AlbumAdi, Sanatci = a.SanatciAdi + " " + a.SanatciSoyadi }).ToList();

        }
    }
}
