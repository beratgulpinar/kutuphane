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
            // FormUyeListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kutuphane.Properties.Resources._6;
            this.ClientSize = new System.Drawing.Size(584, 341);
            this.Controls.Add(this.bttnAnasayfa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormUyeListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Üye Listesi";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttnAnasayfa;
    }
}