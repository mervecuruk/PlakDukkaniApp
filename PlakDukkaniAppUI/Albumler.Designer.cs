namespace PlakDukkaniAppUI
{
    partial class Albumler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAlbumEkleveyaGuncelle = new Button();
            btnAlbumSil = new Button();
            btnSatisiDurmusAlbum = new Button();
            btnSatisiDevamEdenAlbum = new Button();
            btnSistemeSonEklenenAlbum = new Button();
            btnIndirimdekiAlbumler = new Button();
            btnCikis = new Button();
            dgvAlbumler = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvAlbumler).BeginInit();
            SuspendLayout();
            // 
            // btnAlbumEkleveyaGuncelle
            // 
            btnAlbumEkleveyaGuncelle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAlbumEkleveyaGuncelle.Location = new Point(32, 44);
            btnAlbumEkleveyaGuncelle.Name = "btnAlbumEkleveyaGuncelle";
            btnAlbumEkleveyaGuncelle.Size = new Size(233, 30);
            btnAlbumEkleveyaGuncelle.TabIndex = 0;
            btnAlbumEkleveyaGuncelle.Text = "Album Ekle veya Güncelle";
            btnAlbumEkleveyaGuncelle.UseVisualStyleBackColor = true;
            btnAlbumEkleveyaGuncelle.Click += btnAlbumEkleveyaGuncelle_Click;
            // 
            // btnAlbumSil
            // 
            btnAlbumSil.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAlbumSil.Location = new Point(32, 91);
            btnAlbumSil.Name = "btnAlbumSil";
            btnAlbumSil.Size = new Size(233, 29);
            btnAlbumSil.TabIndex = 1;
            btnAlbumSil.Text = "Album Sil";
            btnAlbumSil.UseVisualStyleBackColor = true;
            btnAlbumSil.Click += btnAlbumSil_Click;
            // 
            // btnSatisiDurmusAlbum
            // 
            btnSatisiDurmusAlbum.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSatisiDurmusAlbum.Location = new Point(32, 142);
            btnSatisiDurmusAlbum.Name = "btnSatisiDurmusAlbum";
            btnSatisiDurmusAlbum.Size = new Size(233, 35);
            btnSatisiDurmusAlbum.TabIndex = 1;
            btnSatisiDurmusAlbum.Text = "Satışı Durmuş Albümler";
            btnSatisiDurmusAlbum.UseVisualStyleBackColor = true;
            btnSatisiDurmusAlbum.Click += btnSatisiDurmusAlbum_Click;
            // 
            // btnSatisiDevamEdenAlbum
            // 
            btnSatisiDevamEdenAlbum.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSatisiDevamEdenAlbum.Location = new Point(32, 196);
            btnSatisiDevamEdenAlbum.Name = "btnSatisiDevamEdenAlbum";
            btnSatisiDevamEdenAlbum.Size = new Size(245, 33);
            btnSatisiDevamEdenAlbum.TabIndex = 1;
            btnSatisiDevamEdenAlbum.Text = "Satışı Devam Eden Albümler";
            btnSatisiDevamEdenAlbum.UseVisualStyleBackColor = true;
            btnSatisiDevamEdenAlbum.Click += btnSatisiDevamEdenAlbum_Click;
            // 
            // btnSistemeSonEklenenAlbum
            // 
            btnSistemeSonEklenenAlbum.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSistemeSonEklenenAlbum.Location = new Point(32, 245);
            btnSistemeSonEklenenAlbum.Name = "btnSistemeSonEklenenAlbum";
            btnSistemeSonEklenenAlbum.Size = new Size(245, 29);
            btnSistemeSonEklenenAlbum.TabIndex = 1;
            btnSistemeSonEklenenAlbum.Text = "Sisteme Son Eklenen 10 Albüm";
            btnSistemeSonEklenenAlbum.UseVisualStyleBackColor = true;
            btnSistemeSonEklenenAlbum.Click += btnSistemeSonEklenenAlbum_Click;
            // 
            // btnIndirimdekiAlbumler
            // 
            btnIndirimdekiAlbumler.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnIndirimdekiAlbumler.Location = new Point(32, 289);
            btnIndirimdekiAlbumler.Name = "btnIndirimdekiAlbumler";
            btnIndirimdekiAlbumler.Size = new Size(245, 28);
            btnIndirimdekiAlbumler.TabIndex = 1;
            btnIndirimdekiAlbumler.Text = "İndirimdeki Albümler";
            btnIndirimdekiAlbumler.UseVisualStyleBackColor = true;
            btnIndirimdekiAlbumler.Click += btnIndirimdekiAlbumler_Click;
            // 
            // btnCikis
            // 
            btnCikis.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCikis.Location = new Point(23, 406);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(104, 43);
            btnCikis.TabIndex = 1;
            btnCikis.Text = "Çıkış Yap";
            btnCikis.UseVisualStyleBackColor = true;
            btnCikis.Click += btnCikis_Click;
            // 
            // dgvAlbumler
            // 
            dgvAlbumler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlbumler.Location = new Point(401, 66);
            dgvAlbumler.Name = "dgvAlbumler";
            dgvAlbumler.RowHeadersWidth = 51;
            dgvAlbumler.RowTemplate.Height = 29;
            dgvAlbumler.Size = new Size(958, 297);
            dgvAlbumler.TabIndex = 2;
            // 
            // Albumler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1405, 461);
            Controls.Add(dgvAlbumler);
            Controls.Add(btnCikis);
            Controls.Add(btnIndirimdekiAlbumler);
            Controls.Add(btnSistemeSonEklenenAlbum);
            Controls.Add(btnSatisiDevamEdenAlbum);
            Controls.Add(btnSatisiDurmusAlbum);
            Controls.Add(btnAlbumSil);
            Controls.Add(btnAlbumEkleveyaGuncelle);
            Name = "Albumler";
            Text = "Albumler";
            Load += Albumler_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAlbumler).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAlbumEkleveyaGuncelle;
        private Button btnAlbumSil;
        private Button btnSatisiDurmusAlbum;
        private Button btnSatisiDevamEdenAlbum;
        private Button btnSistemeSonEklenenAlbum;
        private Button btnIndirimdekiAlbumler;
        private Button btnCikis;
        private DataGridView dgvAlbumler;
    }
}