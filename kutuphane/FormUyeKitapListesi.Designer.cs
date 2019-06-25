namespace kutuphane
{
    partial class FormUyeKitapListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUyeKitapListesi));
            this.bttnKitaplariGoster = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bttnOduncGoster = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bttnKitaplariGoster
            // 
            this.bttnKitaplariGoster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bttnKitaplariGoster.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttnKitaplariGoster.Location = new System.Drawing.Point(12, 12);
            this.bttnKitaplariGoster.Name = "bttnKitaplariGoster";
            this.bttnKitaplariGoster.Size = new System.Drawing.Size(138, 32);
            this.bttnKitaplariGoster.TabIndex = 9;
            this.bttnKitaplariGoster.Text = "Kitapları Göster";
            this.bttnKitaplariGoster.UseVisualStyleBackColor = false;
            this.bttnKitaplariGoster.Click += new System.EventHandler(this.BttnKitaplariGoster_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(560, 265);
            this.dataGridView1.TabIndex = 8;
            // 
            // bttnOduncGoster
            // 
            this.bttnOduncGoster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bttnOduncGoster.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttnOduncGoster.Location = new System.Drawing.Point(425, 12);
            this.bttnOduncGoster.Name = "bttnOduncGoster";
            this.bttnOduncGoster.Size = new System.Drawing.Size(147, 32);
            this.bttnOduncGoster.TabIndex = 10;
            this.bttnOduncGoster.Text = "Ödünç Kitap Göster";
            this.bttnOduncGoster.UseVisualStyleBackColor = false;
            this.bttnOduncGoster.Click += new System.EventHandler(this.BttnOduncGoster_Click);
            // 
            // FormUyeKitapListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kutuphane.Properties.Resources._6;
            this.ClientSize = new System.Drawing.Size(584, 341);
            this.Controls.Add(this.bttnOduncGoster);
            this.Controls.Add(this.bttnKitaplariGoster);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormUyeKitapListesi";
            this.Text = "FormUyeKitapListesi";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bttnKitaplariGoster;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bttnOduncGoster;
    }
}