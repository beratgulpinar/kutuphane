namespace kutuphane
{
    partial class FormKitapListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKitapListesi));
            this.bttnAnasayfa = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bttnKitaplariGoster = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKitapSil = new System.Windows.Forms.TextBox();
            this.bttnKitapSil = new System.Windows.Forms.Button();
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(560, 208);
            this.dataGridView1.TabIndex = 2;
            // 
            // bttnKitaplariGoster
            // 
            this.bttnKitaplariGoster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bttnKitaplariGoster.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttnKitaplariGoster.Location = new System.Drawing.Point(12, 12);
            this.bttnKitaplariGoster.Name = "bttnKitaplariGoster";
            this.bttnKitaplariGoster.Size = new System.Drawing.Size(138, 32);
            this.bttnKitaplariGoster.TabIndex = 3;
            this.bttnKitaplariGoster.Text = "Kitapları Göster";
            this.bttnKitaplariGoster.UseVisualStyleBackColor = false;
            this.bttnKitaplariGoster.Click += new System.EventHandler(this.BttnKitaplariGoster_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(53, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Silinecek Kitap No:";
            // 
            // txtKitapSil
            // 
            this.txtKitapSil.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKitapSil.Location = new System.Drawing.Point(209, 291);
            this.txtKitapSil.Name = "txtKitapSil";
            this.txtKitapSil.Size = new System.Drawing.Size(200, 27);
            this.txtKitapSil.TabIndex = 5;
            // 
            // bttnKitapSil
            // 
            this.bttnKitapSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bttnKitapSil.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttnKitapSil.Location = new System.Drawing.Point(415, 290);
            this.bttnKitapSil.Name = "bttnKitapSil";
            this.bttnKitapSil.Size = new System.Drawing.Size(89, 32);
            this.bttnKitapSil.TabIndex = 6;
            this.bttnKitapSil.Text = "Kitabı Sil";
            this.bttnKitapSil.UseVisualStyleBackColor = false;
            this.bttnKitapSil.Click += new System.EventHandler(this.BttnKitapSil_Click);
            // 
            // FormKitapListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kutuphane.Properties.Resources._6;
            this.ClientSize = new System.Drawing.Size(584, 341);
            this.Controls.Add(this.bttnKitapSil);
            this.Controls.Add(this.txtKitapSil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttnKitaplariGoster);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bttnAnasayfa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormKitapListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Listesi";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnAnasayfa;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bttnKitaplariGoster;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKitapSil;
        private System.Windows.Forms.Button bttnKitapSil;
    }
}