namespace PlakDukkaniAppUI
{
    partial class Kayit
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtKullaniciAdi = new TextBox();
            txtSifre = new TextBox();
            txtTekrarSifre = new TextBox();
            btnKayitOl = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(49, 91);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(49, 150);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 1;
            label2.Text = "Şifre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(49, 202);
            label3.Name = "label3";
            label3.Size = new Size(93, 20);
            label3.TabIndex = 2;
            label3.Text = "Tekrar Şifre:";
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(229, 91);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(125, 27);
            txtKullaniciAdi.TabIndex = 3;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(229, 143);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(125, 27);
            txtSifre.TabIndex = 3;
            // 
            // txtTekrarSifre
            // 
            txtTekrarSifre.Location = new Point(229, 195);
            txtTekrarSifre.Name = "txtTekrarSifre";
            txtTekrarSifre.Size = new Size(125, 27);
            txtTekrarSifre.TabIndex = 3;
            // 
            // btnKayitOl
            // 
            btnKayitOl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnKayitOl.Location = new Point(180, 296);
            btnKayitOl.Name = "btnKayitOl";
            btnKayitOl.Size = new Size(94, 29);
            btnKayitOl.TabIndex = 4;
            btnKayitOl.Text = "KAYIT OL";
            btnKayitOl.UseVisualStyleBackColor = true;
            btnKayitOl.Click += btnKayitOl_Click;
            // 
            // Kayit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(487, 449);
            Controls.Add(btnKayitOl);
            Controls.Add(txtTekrarSifre);
            Controls.Add(txtSifre);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Kayit";
            Text = "Kayit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtKullaniciAdi;
        private TextBox txtSifre;
        private TextBox txtTekrarSifre;
        private Button btnKayitOl;
    }
}