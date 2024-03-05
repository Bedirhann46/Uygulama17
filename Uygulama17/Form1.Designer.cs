namespace Uygulama17
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNumara = new System.Windows.Forms.TextBox();
            this.textBoxAdSoyad = new System.Windows.Forms.TextBox();
            this.textBoxDersNotu = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numara";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ders Notu";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxNumara
            // 
            this.textBoxNumara.Location = new System.Drawing.Point(91, 12);
            this.textBoxNumara.Name = "textBoxNumara";
            this.textBoxNumara.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumara.TabIndex = 3;
            this.textBoxNumara.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNumara_Validating);
            // 
            // textBoxAdSoyad
            // 
            this.textBoxAdSoyad.Location = new System.Drawing.Point(91, 39);
            this.textBoxAdSoyad.Name = "textBoxAdSoyad";
            this.textBoxAdSoyad.Size = new System.Drawing.Size(152, 20);
            this.textBoxAdSoyad.TabIndex = 4;
            this.textBoxAdSoyad.TextChanged += new System.EventHandler(this.textBoxAdSoyad_TextChanged);
            this.textBoxAdSoyad.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxAdSoyad_Validating);
            // 
            // textBoxDersNotu
            // 
            this.textBoxDersNotu.Location = new System.Drawing.Point(91, 66);
            this.textBoxDersNotu.Name = "textBoxDersNotu";
            this.textBoxDersNotu.Size = new System.Drawing.Size(100, 20);
            this.textBoxDersNotu.TabIndex = 5;
            this.textBoxDersNotu.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxDersNotu_Validating);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(116, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxDersNotu);
            this.Controls.Add(this.textBoxAdSoyad);
            this.Controls.Add(this.textBoxNumara);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNumara;
        private System.Windows.Forms.TextBox textBoxAdSoyad;
        private System.Windows.Forms.TextBox textBoxDersNotu;
        private System.Windows.Forms.Button button1;
    }
}

