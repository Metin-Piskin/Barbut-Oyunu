namespace Barbut_Oyunu
{
    partial class Barbut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Barbut));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1puan = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1oyuncu = new System.Windows.Forms.Button();
            this.button2oyuncu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3oyuncu1 = new System.Windows.Forms.Label();
            this.label4oyuncu2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tekrarbuton = new System.Windows.Forms.Button();
            this.başlat = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(59, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Oyun Kaç Puanda Bitsin ?";
            // 
            // textBox1puan
            // 
            this.textBox1puan.Location = new System.Drawing.Point(312, 12);
            this.textBox1puan.Name = "textBox1puan";
            this.textBox1puan.Size = new System.Drawing.Size(217, 32);
            this.textBox1puan.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(63, 104);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 181);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(340, 104);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(189, 181);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // button1oyuncu
            // 
            this.button1oyuncu.Location = new System.Drawing.Point(63, 337);
            this.button1oyuncu.Name = "button1oyuncu";
            this.button1oyuncu.Size = new System.Drawing.Size(189, 63);
            this.button1oyuncu.TabIndex = 4;
            this.button1oyuncu.Text = "Oyuncu 1";
            this.button1oyuncu.UseVisualStyleBackColor = true;
            this.button1oyuncu.Visible = false;
            this.button1oyuncu.Click += new System.EventHandler(this.button1oyuncu_Click);
            // 
            // button2oyuncu
            // 
            this.button2oyuncu.Location = new System.Drawing.Point(340, 337);
            this.button2oyuncu.Name = "button2oyuncu";
            this.button2oyuncu.Size = new System.Drawing.Size(189, 63);
            this.button2oyuncu.TabIndex = 5;
            this.button2oyuncu.Text = "Oyuncu 2";
            this.button2oyuncu.UseVisualStyleBackColor = true;
            this.button2oyuncu.Visible = false;
            this.button2oyuncu.Click += new System.EventHandler(this.button2oyuncu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(59, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Oyuncu 1:";
            this.label2.Visible = false;
            // 
            // label3oyuncu1
            // 
            this.label3oyuncu1.AutoSize = true;
            this.label3oyuncu1.ForeColor = System.Drawing.Color.White;
            this.label3oyuncu1.Location = new System.Drawing.Point(189, 310);
            this.label3oyuncu1.Name = "label3oyuncu1";
            this.label3oyuncu1.Size = new System.Drawing.Size(21, 24);
            this.label3oyuncu1.TabIndex = 7;
            this.label3oyuncu1.Text = "0";
            this.label3oyuncu1.Visible = false;
            // 
            // label4oyuncu2
            // 
            this.label4oyuncu2.AutoSize = true;
            this.label4oyuncu2.ForeColor = System.Drawing.Color.White;
            this.label4oyuncu2.Location = new System.Drawing.Point(466, 310);
            this.label4oyuncu2.Name = "label4oyuncu2";
            this.label4oyuncu2.Size = new System.Drawing.Size(21, 24);
            this.label4oyuncu2.TabIndex = 9;
            this.label4oyuncu2.Text = "0";
            this.label4oyuncu2.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(336, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Oyuncu 2:";
            this.label5.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(161, 426);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Kazanan";
            this.label3.Visible = false;
            // 
            // tekrarbuton
            // 
            this.tekrarbuton.Location = new System.Drawing.Point(63, 467);
            this.tekrarbuton.Name = "tekrarbuton";
            this.tekrarbuton.Size = new System.Drawing.Size(466, 63);
            this.tekrarbuton.TabIndex = 11;
            this.tekrarbuton.Text = "Oyunu Tekrar Başlat";
            this.tekrarbuton.UseVisualStyleBackColor = true;
            this.tekrarbuton.Visible = false;
            this.tekrarbuton.Click += new System.EventHandler(this.tekrarbuton_Click);
            // 
            // başlat
            // 
            this.başlat.Location = new System.Drawing.Point(63, 56);
            this.başlat.Name = "başlat";
            this.başlat.Size = new System.Drawing.Size(466, 42);
            this.başlat.TabIndex = 12;
            this.başlat.Text = "Başlat";
            this.başlat.UseVisualStyleBackColor = true;
            this.başlat.Click += new System.EventHandler(this.başlat_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(549, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // Barbut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(60)))), ((int)(((byte)(117)))));
            this.ClientSize = new System.Drawing.Size(601, 542);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.başlat);
            this.Controls.Add(this.tekrarbuton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4oyuncu2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3oyuncu1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2oyuncu);
            this.Controls.Add(this.button1oyuncu);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1puan);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Barbut";
            this.Text = "Barbut";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1puan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1oyuncu;
        private System.Windows.Forms.Button button2oyuncu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3oyuncu1;
        private System.Windows.Forms.Label label4oyuncu2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button tekrarbuton;
        private System.Windows.Forms.Button başlat;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

