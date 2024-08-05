namespace PlakDukkaniAppUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtKullaniciAdi = new TextBox();
            txtSifre = new TextBox();
            btnGiris = new Button();
            linkKayitOl = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(104, 113);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(104, 182);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 1;
            label2.Text = "Şifre:";
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(257, 110);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(125, 27);
            txtKullaniciAdi.TabIndex = 2;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(257, 175);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(125, 27);
            txtSifre.TabIndex = 3;
            // 
            // btnGiris
            // 
            btnGiris.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGiris.Location = new Point(161, 251);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(94, 29);
            btnGiris.TabIndex = 4;
            btnGiris.Text = "GİRİŞ YAP";
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            // 
            // linkKayitOl
            // 
            linkKayitOl.AutoSize = true;
            linkKayitOl.Location = new Point(324, 260);
            linkKayitOl.Name = "linkKayitOl";
            linkKayitOl.Size = new Size(61, 20);
            linkKayitOl.TabIndex = 6;
            linkKayitOl.TabStop = true;
            linkKayitOl.Text = "Kayıt Ol";
            linkKayitOl.LinkClicked += linkKayitOl_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(535, 442);
            Controls.Add(linkKayitOl);
            Controls.Add(btnGiris);
            Controls.Add(txtSifre);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtKullaniciAdi;
        private TextBox txtSifre;
        private Button btnGiris;
        private LinkLabel linkKayitOl;
    }
}
