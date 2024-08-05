using Microsoft.EntityFrameworkCore;
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
    public partial class AlbumEkleGuncelle : Form
    {
        private readonly AppDbContext db;

        public AlbumEkleGuncelle()
        {
            InitializeComponent();
            db = new AppDbContext();
        }

        private void btnAlbumler_Click(object sender, EventArgs e)
        {
            Albumler albumler = new Albumler();
            albumler.Show();
            this.Close();
        }

        private void btnAlbumEkle_Click(object sender, EventArgs e)
        {
            decimal indirimliFiyat =Convert.ToDecimal( txtfiyat.Text) * Convert.ToDecimal(txtIndirimOrani.Text);
          ( txtIndirimliFiyat.Text) = indirimliFiyat.ToString("C2");
            var Album = new Album
            {
                AlbumAdi = txtAlbumAdi.Text,
                SanatciAdi = txtSanatciAdi.Text,
                SanatciSoyadi = txtSanatciSoyadi.Text,
                CikisTarihi = dtpCikisTarihi.Value,
                Fiyat = Convert.ToDecimal(txtfiyat.Text),
                IndirimOrani = Convert.ToDecimal(txtIndirimOrani.Text),
                IndirimliFiyat = Convert.ToDecimal(txtIndirimliFiyat.Text),
                SatisiDevamEdiyorMu = cmbSatisDurumu.SelectedIndex == 0 ? SatisDurumu.SatisDurmus : SatisDurumu.SatisDevamEdiyor,

            };
            db.Albumler.Add(Album);
            db.SaveChanges();
            dgvAlbumler.DataSource = db.Albumler.ToList();

        }

       

        private void AlbumEkleGuncelle_Load(object sender, EventArgs e)
        {
            cmbSatisDurumu.DataSource = Enum.GetValues(typeof(SatisDurumu)).Cast<SatisDurumu>().ToList();
            dgvAlbumler.DataSource=db.Albumler.ToList();
        }

        private void btnAlbumGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvAlbumler.SelectedRows.Count > 0)
            {
                // Seçilen albümü al
                var selectedRow = dgvAlbumler.SelectedRows[0];
                var seciliAlbum = (Album)selectedRow.DataBoundItem;

                // TextBox'lardan ve diğer kontrollerden alınan verilerle albümü güncelle
                seciliAlbum.AlbumAdi = txtAlbumAdi.Text;
                seciliAlbum.SanatciAdi = txtSanatciAdi.Text;
                seciliAlbum.SanatciSoyadi = txtSanatciSoyadi.Text;
                seciliAlbum.CikisTarihi = dtpCikisTarihi.Value;
                seciliAlbum.Fiyat = Convert.ToDecimal(txtfiyat.Text);
                seciliAlbum.IndirimOrani = Convert.ToDecimal(txtIndirimOrani.Text);
                seciliAlbum.IndirimliFiyat= Convert.ToDecimal(txtIndirimliFiyat.Text);
                seciliAlbum.SatisiDevamEdiyorMu = cmbSatisDurumu.SelectedIndex==0 ? SatisDurumu.SatisDurmus : SatisDurumu.SatisDevamEdiyor;

                // Veritabanına değişiklikleri kaydet
                db.SaveChanges();

                // Güncelleme başarılı mesajı
                MessageBox.Show("Albüm başarıyla güncellendi.");

                // DataGridView'i güncelle
                dgvAlbumler.DataSource = db.Albumler.ToList();
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek için bir albüm seçin.");
            }
        }
    

        private void dgvAlbumler_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow selectedRow = dgvAlbumler.Rows[e.RowIndex];
            txtAlbumAdi.Text = selectedRow.Cells[1].Value.ToString();
            txtSanatciAdi.Text = selectedRow.Cells[2].Value.ToString();
            txtSanatciSoyadi.Text = selectedRow.Cells[3].Value.ToString();
            dtpCikisTarihi.Text = selectedRow.Cells[4].Value.ToString();
            txtfiyat.Text = selectedRow.Cells[5].Value.ToString();
            txtIndirimOrani.Text = selectedRow.Cells[6].Value.ToString();
            txtIndirimliFiyat.Text = selectedRow.Cells[7].Value.ToString();
            cmbSatisDurumu.Text = selectedRow.Cells[8].Value.ToString();



        }
    }
}
