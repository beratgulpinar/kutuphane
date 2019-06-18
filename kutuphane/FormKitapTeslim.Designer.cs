namespace kutuphane
{
    partial class FormKitapTeslim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKitapTeslim));
            this.bttnAnasayfa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKitapNo = new System.Windows.Forms.TextBox();
            this.bttnTeslim = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bttnListele = new System.Windows.Forms.Button();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kitap Teslim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kitap No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(238, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kitap Ödünç Listesi";
            // 
            // txtKitapNo
            // 
            this.txtKitapNo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKitapNo.Location = new System.Drawing.Point(113, 63);
            this.txtKitapNo.Name = "txtKitapNo";
            this.txtKitapNo.Size = new System.Drawing.Size(126, 27);
            this.txtKitapNo.TabIndex = 5;
            // 
            // bttnTeslim
            // 
            this.bttnTeslim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bttnTeslim.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttnTeslim.Location = new System.Drawing.Point(257, 60);
            this.bttnTeslim.Name = "bttnTeslim";
            this.bttnTeslim.Size = new System.Drawing.Size(101, 33);
            this.bttnTeslim.TabIndex = 6;
            this.bttnTeslim.Text = "Teslim Al";
            this.bttnTeslim.UseVisualStyleBackColor = false;
            this.bttnTeslim.Click += new System.EventHandler(this.BttnTeslim_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 178);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(560, 143);
            this.dataGridView1.TabIndex = 7;
            // 
            // bttnListele
            // 
            this.bttnListele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bttnListele.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttnListele.Location = new System.Drawing.Point(269, 141);
            this.bttnListele.Name = "bttnListele";
            this.bttnListele.Size = new System.Drawing.Size(89, 32);
            this.bttnListele.TabIndex = 8;
            this.bttnListele.Text = "Listele";
            this.bttnListele.UseVisualStyleBackColor = false;
            this.bttnListele.Click += new System.EventHandler(this.BttnListele_Click);
            // 
            // FormKitapTeslim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kutuphane.Properties.Resources._6;
            this.ClientSize = new System.Drawing.Size(584, 341);
            this.Controls.Add(this.bttnListele);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bttnTeslim);
            this.Controls.Add(this.txtKitapNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttnAnasayfa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormKitapTeslim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Teslim";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnAnasayfa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKitapNo;
        private System.Windows.Forms.Button bttnTeslim;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bttnListele;
    }
}