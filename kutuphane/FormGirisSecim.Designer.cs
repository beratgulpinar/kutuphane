namespace kutuphane
{
    partial class FormGirisSecim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGirisSecim));
            this.bttnAdmin = new System.Windows.Forms.Button();
            this.bttnUye = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bttnAdmin
            // 
            this.bttnAdmin.Image = ((System.Drawing.Image)(resources.GetObject("bttnAdmin.Image")));
            this.bttnAdmin.Location = new System.Drawing.Point(106, 129);
            this.bttnAdmin.Name = "bttnAdmin";
            this.bttnAdmin.Size = new System.Drawing.Size(100, 100);
            this.bttnAdmin.TabIndex = 0;
            this.bttnAdmin.UseVisualStyleBackColor = true;
            this.bttnAdmin.Click += new System.EventHandler(this.BttnAdmin_Click);
            // 
            // bttnUye
            // 
            this.bttnUye.Image = ((System.Drawing.Image)(resources.GetObject("bttnUye.Image")));
            this.bttnUye.Location = new System.Drawing.Point(376, 129);
            this.bttnUye.Name = "bttnUye";
            this.bttnUye.Size = new System.Drawing.Size(100, 100);
            this.bttnUye.TabIndex = 1;
            this.bttnUye.UseVisualStyleBackColor = true;
            this.bttnUye.Click += new System.EventHandler(this.BttnUye_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(99, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 42);
            this.label2.TabIndex = 4;
            this.label2.Text = "Admin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(385, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 42);
            this.label1.TabIndex = 5;
            this.label1.Text = "Üye";
            // 
            // FormGirisSecim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kutuphane.Properties.Resources._6;
            this.ClientSize = new System.Drawing.Size(584, 341);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bttnUye);
            this.Controls.Add(this.bttnAdmin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormGirisSecim";
            this.Text = "FormGirisSecim";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnAdmin;
        private System.Windows.Forms.Button bttnUye;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}