namespace kutuphane
{
    partial class FormKitapOdunc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKitapOdunc));
            this.bttnAnasayfa = new System.Windows.Forms.Button();
            this.bttnKaydet = new System.Windows.Forms.Button();
            this.txtTeslimTarihi = new System.Windows.Forms.TextBox();
            this.txtKitapAra = new System.Windows.Forms.TextBox();
            this.txtKiralamaTarihi = new System.Windows.Forms.TextBox();
            this.txtKiralayanTcNo = new System.Windows.Forms.TextBox();
            this.txtKitapNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bttnAra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bttnAnasayfa
            // 
            this.bttnAnasayfa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bttnAnasayfa.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttnAnasayfa.Location = new System.Drawing.Point(483, 12);
            this.bttnAnasayfa.Name = "bttnAnasayfa";
            this.bttnAnasayfa.Size = new System.Drawing.Size(89, 32);
            this.bttnAnasayfa.TabIndex = 1;
            this.bttnAnasayfa.Text = "Anasayfa";
            this.bttnAnasayfa.UseVisualStyleBackColor = false;
            this.bttnAnasayfa.Click += new System.EventHandler(this.BttnAnasayfa_Click);
            // 
            // bttnKaydet
            // 
            this.bttnKaydet.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttnKaydet.Location = new System.Drawing.Point(283, 158);
            this.bttnKaydet.Name = "bttnKaydet";
            this.bttnKaydet.Size = new System.Drawing.Size(91, 28);
            this.bttnKaydet.TabIndex = 28;
            this.bttnKaydet.Text = "Kaydet";
            this.bttnKaydet.UseVisualStyleBackColor = true;
            this.bttnKaydet.Click += new System.EventHandler(this.BttnKaydet_Click);
            // 
            // txtTeslimTarihi
            // 
            this.txtTeslimTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTeslimTarihi.Location = new System.Drawing.Point(223, 127);
            this.txtTeslimTarihi.Name = "txtTeslimTarihi";
            this.txtTeslimTarihi.Size = new System.Drawing.Size(151, 26);
            this.txtTeslimTarihi.TabIndex = 27;
            // 
            // txtKitapAra
            // 
            this.txtKitapAra.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKitapAra.ForeColor = System.Drawing.Color.DimGray;
            this.txtKitapAra.Location = new System.Drawing.Point(12, 250);
            this.txtKitapAra.Name = "txtKitapAra";
            this.txtKitapAra.Size = new System.Drawing.Size(140, 27);
            this.txtKitapAra.TabIndex = 25;
            this.txtKitapAra.Text = "--Kitap Adı Giriniz--";
            this.txtKitapAra.Enter += new System.EventHandler(this.TxtKitapAra_Enter);
            this.txtKitapAra.Leave += new System.EventHandler(this.TxtKitapAra_Leave);
            // 
            // txtKiralamaTarihi
            // 
            this.txtKiralamaTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKiralamaTarihi.Location = new System.Drawing.Point(223, 92);
            this.txtKiralamaTarihi.Name = "txtKiralamaTarihi";
            this.txtKiralamaTarihi.Size = new System.Drawing.Size(151, 26);
            this.txtKiralamaTarihi.TabIndex = 24;
            // 
            // txtKiralayanTcNo
            // 
            this.txtKiralayanTcNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKiralayanTcNo.ForeColor = System.Drawing.Color.DimGray;
            this.txtKiralayanTcNo.Location = new System.Drawing.Point(223, 56);
            this.txtKiralayanTcNo.Name = "txtKiralayanTcNo";
            this.txtKiralayanTcNo.Size = new System.Drawing.Size(151, 26);
            this.txtKiralayanTcNo.TabIndex = 23;
            this.txtKiralayanTcNo.Text = "--Tc No Giriniz--";
            this.txtKiralayanTcNo.Enter += new System.EventHandler(this.TxtKiralayanTcNo_Enter);
            this.txtKiralayanTcNo.Leave += new System.EventHandler(this.TxtKiralayanTcNo_Leave);
            // 
            // txtKitapNo
            // 
            this.txtKitapNo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKitapNo.ForeColor = System.Drawing.Color.DimGray;
            this.txtKitapNo.Location = new System.Drawing.Point(223, 17);
            this.txtKitapNo.Name = "txtKitapNo";
            this.txtKitapNo.Size = new System.Drawing.Size(151, 27);
            this.txtKitapNo.TabIndex = 22;
            this.txtKitapNo.Text = "--Kitap No Giriniz--";
            this.txtKitapNo.Enter += new System.EventHandler(this.TxtKitapNo_Enter);
            this.txtKitapNo.Leave += new System.EventHandler(this.TxtKitapNo_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(20, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 22);
            this.label5.TabIndex = 20;
            this.label5.Text = "Kitap Arama";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(92, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 21);
            this.label4.TabIndex = 19;
            this.label4.Text = "Teslim Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(92, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 21);
            this.label3.TabIndex = 18;
            this.label3.Text = "Kiralama Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(92, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 21);
            this.label2.TabIndex = 17;
            this.label2.Text = "Tc No";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(92, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 21);
            this.label1.TabIndex = 16;
            this.label1.Text = "Kitap No";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(223, 201);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(343, 128);
            this.dataGridView1.TabIndex = 30;
            // 
            // bttnAra
            // 
            this.bttnAra.BackColor = System.Drawing.Color.Lime;
            this.bttnAra.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttnAra.Location = new System.Drawing.Point(159, 249);
            this.bttnAra.Name = "bttnAra";
            this.bttnAra.Size = new System.Drawing.Size(58, 28);
            this.bttnAra.TabIndex = 31;
            this.bttnAra.Text = "Ara";
            this.bttnAra.UseVisualStyleBackColor = false;
            this.bttnAra.Click += new System.EventHandler(this.BttnAra_Click);
            // 
            // FormKitapOdunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kutuphane.Properties.Resources._6;
            this.ClientSize = new System.Drawing.Size(584, 341);
            this.Controls.Add(this.bttnAra);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bttnKaydet);
            this.Controls.Add(this.txtTeslimTarihi);
            this.Controls.Add(this.txtKitapAra);
            this.Controls.Add(this.txtKiralamaTarihi);
            this.Controls.Add(this.txtKiralayanTcNo);
            this.Controls.Add(this.txtKitapNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttnAnasayfa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormKitapOdunc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Ödünç";
            this.Load += new System.EventHandler(this.FormKitapOdunc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnAnasayfa;
        private System.Windows.Forms.Button bttnKaydet;
        private System.Windows.Forms.TextBox txtTeslimTarihi;
        private System.Windows.Forms.TextBox txtKitapAra;
        private System.Windows.Forms.TextBox txtKiralamaTarihi;
        private System.Windows.Forms.TextBox txtKiralayanTcNo;
        private System.Windows.Forms.TextBox txtKitapNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bttnAra;
    }
}