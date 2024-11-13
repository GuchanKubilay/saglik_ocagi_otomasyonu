namespace saglik_ocagi_otomasyon
{
    partial class hastaGiris
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
            this.txtHastaSifre = new System.Windows.Forms.TextBox();
            this.txtHastaTC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.giris = new System.Windows.Forms.Button();
            this.cikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtHastaSifre
            // 
            this.txtHastaSifre.Location = new System.Drawing.Point(154, 86);
            this.txtHastaSifre.Name = "txtHastaSifre";
            this.txtHastaSifre.PasswordChar = '*';
            this.txtHastaSifre.Size = new System.Drawing.Size(148, 20);
            this.txtHastaSifre.TabIndex = 7;
            // 
            // txtHastaTC
            // 
            this.txtHastaTC.Location = new System.Drawing.Point(154, 55);
            this.txtHastaTC.Name = "txtHastaTC";
            this.txtHastaTC.Size = new System.Drawing.Size(148, 20);
            this.txtHastaTC.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Şifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Hasta TC no";
            // 
            // giris
            // 
            this.giris.Location = new System.Drawing.Point(154, 149);
            this.giris.Name = "giris";
            this.giris.Size = new System.Drawing.Size(56, 23);
            this.giris.TabIndex = 3;
            this.giris.Text = "Giriş";
            this.giris.UseVisualStyleBackColor = true;
            this.giris.Click += new System.EventHandler(this.giris_Click);
            // 
            // cikis
            // 
            this.cikis.Location = new System.Drawing.Point(246, 149);
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(56, 23);
            this.cikis.TabIndex = 4;
            this.cikis.Text = "Çıkış";
            this.cikis.UseVisualStyleBackColor = true;
            this.cikis.Click += new System.EventHandler(this.cikis_Click);
            // 
            // hastaGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 266);
            this.Controls.Add(this.txtHastaSifre);
            this.Controls.Add(this.txtHastaTC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.giris);
            this.Controls.Add(this.cikis);
            this.Name = "hastaGiris";
            this.Text = "Hasta Girişi";
            this.Load += new System.EventHandler(this.hastaGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHastaSifre;
        private System.Windows.Forms.TextBox txtHastaTC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button giris;
        private System.Windows.Forms.Button cikis;
    }
}