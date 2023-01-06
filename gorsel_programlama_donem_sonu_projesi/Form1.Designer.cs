namespace gorsel_programlama_donem_sonu_projesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.kulYetki_lab4 = new System.Windows.Forms.Label();
            this.kulPerm_tBox = new System.Windows.Forms.TextBox();
            this.kulID_lab = new System.Windows.Forms.Label();
            this.kulID_tBox = new System.Windows.Forms.TextBox();
            this.kulSifre_lab = new System.Windows.Forms.Label();
            this.kulAd_lab = new System.Windows.Forms.Label();
            this.kulPass_tBox = new System.Windows.Forms.TextBox();
            this.kulUsername_tBox = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btn_cikisyap = new System.Windows.Forms.Button();
            this.btn_girisyap = new System.Windows.Forms.Button();
            this.btn_kayit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kullanici_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kulYetki_lab4
            // 
            this.kulYetki_lab4.AutoSize = true;
            this.kulYetki_lab4.BackColor = System.Drawing.Color.Transparent;
            this.kulYetki_lab4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kulYetki_lab4.Location = new System.Drawing.Point(7, 106);
            this.kulYetki_lab4.Name = "kulYetki_lab4";
            this.kulYetki_lab4.Size = new System.Drawing.Size(98, 15);
            this.kulYetki_lab4.TabIndex = 21;
            this.kulYetki_lab4.Text = "Kullanıcı Yetki";
            // 
            // kulPerm_tBox
            // 
            this.kulPerm_tBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kulPerm_tBox.Location = new System.Drawing.Point(111, 106);
            this.kulPerm_tBox.Multiline = true;
            this.kulPerm_tBox.Name = "kulPerm_tBox";
            this.kulPerm_tBox.Size = new System.Drawing.Size(183, 20);
            this.kulPerm_tBox.TabIndex = 20;
            // 
            // kulID_lab
            // 
            this.kulID_lab.AutoSize = true;
            this.kulID_lab.BackColor = System.Drawing.Color.Transparent;
            this.kulID_lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kulID_lab.ForeColor = System.Drawing.Color.Black;
            this.kulID_lab.Location = new System.Drawing.Point(7, 28);
            this.kulID_lab.Name = "kulID_lab";
            this.kulID_lab.Size = new System.Drawing.Size(81, 15);
            this.kulID_lab.TabIndex = 19;
            this.kulID_lab.Text = "Kullanıcı ID";
            // 
            // kulID_tBox
            // 
            this.kulID_tBox.BackColor = System.Drawing.SystemColors.Control;
            this.kulID_tBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kulID_tBox.Location = new System.Drawing.Point(111, 28);
            this.kulID_tBox.Multiline = true;
            this.kulID_tBox.Name = "kulID_tBox";
            this.kulID_tBox.Size = new System.Drawing.Size(183, 20);
            this.kulID_tBox.TabIndex = 18;
            // 
            // kulSifre_lab
            // 
            this.kulSifre_lab.AutoSize = true;
            this.kulSifre_lab.BackColor = System.Drawing.Color.Transparent;
            this.kulSifre_lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kulSifre_lab.Location = new System.Drawing.Point(7, 80);
            this.kulSifre_lab.Name = "kulSifre_lab";
            this.kulSifre_lab.Size = new System.Drawing.Size(97, 15);
            this.kulSifre_lab.TabIndex = 17;
            this.kulSifre_lab.Text = "Kullanıcı Şifre";
            // 
            // kulAd_lab
            // 
            this.kulAd_lab.AutoSize = true;
            this.kulAd_lab.BackColor = System.Drawing.Color.Transparent;
            this.kulAd_lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kulAd_lab.Location = new System.Drawing.Point(7, 54);
            this.kulAd_lab.Name = "kulAd_lab";
            this.kulAd_lab.Size = new System.Drawing.Size(87, 15);
            this.kulAd_lab.TabIndex = 16;
            this.kulAd_lab.Text = "Kullanıcı Adı";
            // 
            // kulPass_tBox
            // 
            this.kulPass_tBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kulPass_tBox.Location = new System.Drawing.Point(111, 80);
            this.kulPass_tBox.Multiline = true;
            this.kulPass_tBox.Name = "kulPass_tBox";
            this.kulPass_tBox.Size = new System.Drawing.Size(183, 20);
            this.kulPass_tBox.TabIndex = 15;
            this.kulPass_tBox.UseSystemPasswordChar = true;
            // 
            // kulUsername_tBox
            // 
            this.kulUsername_tBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kulUsername_tBox.Location = new System.Drawing.Point(111, 54);
            this.kulUsername_tBox.Multiline = true;
            this.kulUsername_tBox.Name = "kulUsername_tBox";
            this.kulUsername_tBox.Size = new System.Drawing.Size(183, 20);
            this.kulUsername_tBox.TabIndex = 14;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(67, 146);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(21, 24);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 27;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(318, 147);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(156, 146);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(21, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            // 
            // btn_cikisyap
            // 
            this.btn_cikisyap.BackColor = System.Drawing.Color.Firebrick;
            this.btn_cikisyap.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btn_cikisyap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cikisyap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_cikisyap.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_cikisyap.Location = new System.Drawing.Point(270, 148);
            this.btn_cikisyap.Name = "btn_cikisyap";
            this.btn_cikisyap.Size = new System.Drawing.Size(79, 23);
            this.btn_cikisyap.TabIndex = 24;
            this.btn_cikisyap.Text = "Çıkış";
            this.btn_cikisyap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cikisyap.UseVisualStyleBackColor = false;
            this.btn_cikisyap.Click += new System.EventHandler(this.btn_cikisyap_Click);
            // 
            // btn_girisyap
            // 
            this.btn_girisyap.BackColor = System.Drawing.Color.OliveDrab;
            this.btn_girisyap.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btn_girisyap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_girisyap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_girisyap.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_girisyap.Location = new System.Drawing.Point(94, 146);
            this.btn_girisyap.Name = "btn_girisyap";
            this.btn_girisyap.Size = new System.Drawing.Size(75, 23);
            this.btn_girisyap.TabIndex = 23;
            this.btn_girisyap.Text = "Admin Giriş";
            this.btn_girisyap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_girisyap.UseVisualStyleBackColor = false;
            this.btn_girisyap.Click += new System.EventHandler(this.btn_girisyap_Click);
            // 
            // btn_kayit
            // 
            this.btn_kayit.BackColor = System.Drawing.Color.OliveDrab;
            this.btn_kayit.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btn_kayit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_kayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kayit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_kayit.Location = new System.Drawing.Point(13, 146);
            this.btn_kayit.Name = "btn_kayit";
            this.btn_kayit.Size = new System.Drawing.Size(75, 23);
            this.btn_kayit.TabIndex = 22;
            this.btn_kayit.Text = "Kayıt";
            this.btn_kayit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kayit.UseVisualStyleBackColor = false;
            this.btn_kayit.Click += new System.EventHandler(this.btn_kayit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(244, 147);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // kullanici_btn
            // 
            this.kullanici_btn.BackColor = System.Drawing.Color.OliveDrab;
            this.kullanici_btn.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.kullanici_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.kullanici_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullanici_btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.kullanici_btn.Location = new System.Drawing.Point(182, 147);
            this.kullanici_btn.Name = "kullanici_btn";
            this.kullanici_btn.Size = new System.Drawing.Size(75, 23);
            this.kullanici_btn.TabIndex = 28;
            this.kullanici_btn.Text = "Kullanıcı";
            this.kullanici_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kullanici_btn.UseVisualStyleBackColor = false;
            this.kullanici_btn.Click += new System.EventHandler(this.kullanici_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(365, 192);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.kullanici_btn);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btn_cikisyap);
            this.Controls.Add(this.btn_girisyap);
            this.Controls.Add(this.btn_kayit);
            this.Controls.Add(this.kulYetki_lab4);
            this.Controls.Add(this.kulPerm_tBox);
            this.Controls.Add(this.kulID_lab);
            this.Controls.Add(this.kulID_tBox);
            this.Controls.Add(this.kulSifre_lab);
            this.Controls.Add(this.kulAd_lab);
            this.Controls.Add(this.kulPass_tBox);
            this.Controls.Add(this.kulUsername_tBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label kulYetki_lab4;
        private System.Windows.Forms.TextBox kulPerm_tBox;
        private System.Windows.Forms.Label kulID_lab;
        private System.Windows.Forms.TextBox kulID_tBox;
        private System.Windows.Forms.Label kulSifre_lab;
        private System.Windows.Forms.Label kulAd_lab;
        private System.Windows.Forms.TextBox kulPass_tBox;
        private System.Windows.Forms.TextBox kulUsername_tBox;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btn_cikisyap;
        private System.Windows.Forms.Button btn_girisyap;
        private System.Windows.Forms.Button btn_kayit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button kullanici_btn;
    }
}

