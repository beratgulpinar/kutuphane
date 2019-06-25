namespace kutuphane
{
    partial class FormKitapKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKitapKayit));
            this.bttnAnasayfa = new System.Windows.Forms.Button();
            this.bttnKaydet = new System.Windows.Forms.Button();
            this.txtBasimTarih = new System.Windows.Forms.TextBox();
            this.txtSayfa = new System.Windows.Forms.TextBox();
            this.txtYazar = new System.Windows.Forms.TextBox();
            this.txtKitapTuru = new System.Windows.Forms.TextBox();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.txtKitapNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtYayinEvi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bttnAnasayfa
            // 
            this.bttnAnasayfa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bttnAnasayfa.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttnAnasayfa.Location = new System.Drawing.Point(483, 12);
            this.bttnAnasayfa.Name = "bttnAnasayfa";
            this.bttnAnasayfa.Size = new System.Drawing.Size(89, 32);
            this.bttnAnasayfa.TabIndex = 0;
            this.bttnAnasayfa.Text = "Anasayfa";
            this.bttnAnasayfa.UseVisualStyleBackColor = false;
            this.bttnAnasayfa.Click += new System.EventHandler(this.BttnAnasayfa_Click);
            // 
            // bttnKaydet
            // 
            this.bttnKaydet.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttnKaydet.Location = new System.Drawing.Point(293, 304);
            this.bttnKaydet.Name = "bttnKaydet";
            this.bttnKaydet.Size = new System.Drawing.Size(91, 29);
            this.bttnKaydet.TabIndex = 28;
            this.bttnKaydet.Text = "Kaydet";
            this.bttnKaydet.UseVisualStyleBackColor = true;
            this.bttnKaydet.Click += new System.EventHandler(this.BttnKaydet_Click_1);
            // 
            // txtBasimTarih
            // 
            this.txtBasimTarih.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBasimTarih.ForeColor = System.Drawing.Color.DimGray;
            this.txtBasimTarih.Location = new System.Drawing.Point(233, 126);
            this.txtBasimTarih.Name = "txtBasimTarih";
            this.txtBasimTarih.Size = new System.Drawing.Size(151, 27);
            this.txtBasimTarih.TabIndex = 27;
            this.txtBasimTarih.Text = "--Basım Tarihi Giriniz--";
            this.txtBasimTarih.Enter += new System.EventHandler(this.TxtBasimTarih_Enter);
            this.txtBasimTarih.Leave += new System.EventHandler(this.TxtBasimTarih_Leave);
            // 
            // txtSayfa
            // 
            this.txtSayfa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSayfa.ForeColor = System.Drawing.Color.DimGray;
            this.txtSayfa.Location = new System.Drawing.Point(233, 197);
            this.txtSayfa.Name = "txtSayfa";
            this.txtSayfa.Size = new System.Drawing.Size(151, 27);
            this.txtSayfa.TabIndex = 26;
            this.txtSayfa.Text = "--Sayfa Sayısı Giriniz--";
            this.txtSayfa.Enter += new System.EventHandler(this.TxtSayfa_Enter);
            this.txtSayfa.Leave += new System.EventHandler(this.TxtSayfa_Leave);
            // 
            // txtYazar
            // 
            this.txtYazar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYazar.ForeColor = System.Drawing.Color.DimGray;
            this.txtYazar.Location = new System.Drawing.Point(233, 161);
            this.txtYazar.Name = "txtYazar";
            this.txtYazar.Size = new System.Drawing.Size(151, 27);
            this.txtYazar.TabIndex = 25;
            this.txtYazar.Text = "--Yazar Giriniz--";
            this.txtYazar.Enter += new System.EventHandler(this.TxtYazar_Enter);
            this.txtYazar.Leave += new System.EventHandler(this.TxtYazar_Leave);
            // 
            // txtKitapTuru
            // 
            this.txtKitapTuru.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKitapTuru.ForeColor = System.Drawing.Color.DimGray;
            this.txtKitapTuru.Location = new System.Drawing.Point(233, 91);
            this.txtKitapTuru.Name = "txtKitapTuru";
            this.txtKitapTuru.Size = new System.Drawing.Size(151, 27);
            this.txtKitapTuru.TabIndex = 24;
            this.txtKitapTuru.Text = "--Kitap Türü Giriniz--";
            this.txtKitapTuru.Enter += new System.EventHandler(this.TxtKitapTuru_Enter);
            this.txtKitapTuru.Leave += new System.EventHandler(this.TxtKitapTuru_Leave);
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKitapAdi.ForeColor = System.Drawing.Color.DimGray;
            this.txtKitapAdi.Location = new System.Drawing.Point(233, 55);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(151, 27);
            this.txtKitapAdi.TabIndex = 23;
            this.txtKitapAdi.Text = "--Kitap Adı Giriniz--";
            this.txtKitapAdi.Enter += new System.EventHandler(this.TxtKitapAdi_Enter);
            this.txtKitapAdi.Leave += new System.EventHandler(this.TxtKitapAdi_Leave);
            // 
            // txtKitapNo
            // 
            this.txtKitapNo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKitapNo.ForeColor = System.Drawing.Color.DimGray;
            this.txtKitapNo.Location = new System.Drawing.Point(233, 17);
            this.txtKitapNo.Name = "txtKitapNo";
            this.txtKitapNo.Size = new System.Drawing.Size(151, 27);
            this.txtKitapNo.TabIndex = 22;
            this.txtKitapNo.Text = "--Kitap No Giriniz--";
            this.txtKitapNo.Enter += new System.EventHandler(this.TxtKitapNo_Enter);
            this.txtKitapNo.Leave += new System.EventHandler(this.TxtKitapNo_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(94, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 21);
            this.label6.TabIndex = 21;
            this.label6.Text = "Sayfa Sayısı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(95, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 21);
            this.label5.TabIndex = 20;
            this.label5.Text = "Yazarı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(95, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 21);
            this.label4.TabIndex = 19;
            this.label4.Text = "Basım tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(95, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 21);
            this.label3.TabIndex = 18;
            this.label3.Text = "Kitap Türü";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(95, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 21);
            this.label2.TabIndex = 17;
            this.label2.Text = "Kitap Adı";
            // 
            // txtYayinEvi
            // 
            this.txtYayinEvi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYayinEvi.ForeColor = System.Drawing.Color.DimGray;
            this.txtYayinEvi.Location = new System.Drawing.Point(233, 234);
            this.txtYayinEvi.Name = "txtYayinEvi";
            this.txtYayinEvi.Size = new System.Drawing.Size(151, 27);
            this.txtYayinEvi.TabIndex = 30;
            this.txtYayinEvi.Text = "--Yayın Evi Giriniz--";
            this.txtYayinEvi.Enter += new System.EventHandler(this.TxtYayinEvi_Enter);
            this.txtYayinEvi.Leave += new System.EventHandler(this.TxtYayinEvi_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(94, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 21);
            this.label7.TabIndex = 29;
            this.label7.Text = "Yayın Evi";
            // 
            // txtStok
            // 
            this.txtStok.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtStok.ForeColor = System.Drawing.Color.DimGray;
            this.txtStok.Location = new System.Drawing.Point(233, 271);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(151, 27);
            this.txtStok.TabIndex = 32;
            this.txtStok.Text = "--Stok Giriniz--";
            this.txtStok.Enter += new System.EventHandler(this.TxtStok_Enter);
            this.txtStok.Leave += new System.EventHandler(this.TxtStok_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(94, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 21);
            this.label8.TabIndex = 31;
            this.label8.Text = "Stok";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(95, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 21);
            this.label1.TabIndex = 33;
            this.label1.Text = "Kitap No";
            // 
            // FormKitapKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kutuphane.Properties.Resources._6;
            this.ClientSize = new System.Drawing.Size(584, 341);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStok);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtYayinEvi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bttnKaydet);
            this.Controls.Add(this.txtBasimTarih);
            this.Controls.Add(this.txtSayfa);
            this.Controls.Add(this.txtYazar);
            this.Controls.Add(this.txtKitapTuru);
            this.Controls.Add(this.txtKitapAdi);
            this.Controls.Add(this.txtKitapNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bttnAnasayfa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormKitapKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Kayıt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnAnasayfa;
        private System.Windows.Forms.Button bttnKaydet;
        private System.Windows.Forms.TextBox txtBasimTarih;
        private System.Windows.Forms.TextBox txtSayfa;
        private System.Windows.Forms.TextBox txtYazar;
        private System.Windows.Forms.TextBox txtKitapTuru;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.TextBox txtKitapNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtYayinEvi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
    }
}