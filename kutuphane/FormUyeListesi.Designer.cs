namespace kutuphane
{
    partial class FormUyeListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUyeListesi));
            this.bttnAnasayfa = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bttnUyeleriGoster = new System.Windows.Forms.Button();
            this.bttnUyeSil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUyeSil = new System.Windows.Forms.TextBox();
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(560, 212);
            this.dataGridView1.TabIndex = 2;
            // 
            // bttnUyeleriGoster
            // 
            this.bttnUyeleriGoster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bttnUyeleriGoster.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttnUyeleriGoster.Location = new System.Drawing.Point(12, 12);
            this.bttnUyeleriGoster.Name = "bttnUyeleriGoster";
            this.bttnUyeleriGoster.Size = new System.Drawing.Size(138, 32);
            this.bttnUyeleriGoster.TabIndex = 3;
            this.bttnUyeleriGoster.Text = "Üyeleri Göster";
            this.bttnUyeleriGoster.UseVisualStyleBackColor = false;
            this.bttnUyeleriGoster.Click += new System.EventHandler(this.BttnUyeleriGoster_Click);
            // 
            // bttnUyeSil
            // 
            this.bttnUyeSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bttnUyeSil.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttnUyeSil.Location = new System.Drawing.Point(418, 289);
            this.bttnUyeSil.Name = "bttnUyeSil";
            this.bttnUyeSil.Size = new System.Drawing.Size(89, 32);
            this.bttnUyeSil.TabIndex = 9;
            this.bttnUyeSil.Text = "Üyeyi Sil";
            this.bttnUyeSil.UseVisualStyleBackColor = false;
            this.bttnUyeSil.Click += new System.EventHandler(this.BttnKitapSil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(72, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Silinecek Üye Tc:";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // txtUyeSil
            // 
            this.txtUyeSil.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUyeSil.Location = new System.Drawing.Point(212, 290);
            this.txtUyeSil.Name = "txtUyeSil";
            this.txtUyeSil.Size = new System.Drawing.Size(200, 27);
            this.txtUyeSil.TabIndex = 10;
            // 
            // FormUyeListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kutuphane.Properties.Resources._6;
            this.ClientSize = new System.Drawing.Size(584, 341);
            this.Controls.Add(this.txtUyeSil);
            this.Controls.Add(this.bttnUyeSil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttnUyeleriGoster);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bttnAnasayfa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormUyeListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Üye Listesi";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnAnasayfa;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bttnUyeleriGoster;
        private System.Windows.Forms.Button bttnUyeSil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUyeSil;
    }
}