
namespace odev
{
    partial class giris_sayfasi
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
            this.lbl_giris_id = new System.Windows.Forms.Label();
            this.lbl_giris_pw = new System.Windows.Forms.Label();
            this.txtb_giris_id = new System.Windows.Forms.TextBox();
            this.txtb_giris_pw = new System.Windows.Forms.TextBox();
            this.btn_kayit = new System.Windows.Forms.Button();
            this.btn_giris = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_giris_id
            // 
            this.lbl_giris_id.AutoSize = true;
            this.lbl_giris_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(0)))), ((int)(((byte)(89)))));
            this.lbl_giris_id.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_giris_id.ForeColor = System.Drawing.Color.White;
            this.lbl_giris_id.Location = new System.Drawing.Point(62, 194);
            this.lbl_giris_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_giris_id.Name = "lbl_giris_id";
            this.lbl_giris_id.Size = new System.Drawing.Size(130, 22);
            this.lbl_giris_id.TabIndex = 0;
            this.lbl_giris_id.Text = "Kullanıcı Adı : ";
            // 
            // lbl_giris_pw
            // 
            this.lbl_giris_pw.AutoSize = true;
            this.lbl_giris_pw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(0)))), ((int)(((byte)(89)))));
            this.lbl_giris_pw.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_giris_pw.ForeColor = System.Drawing.Color.White;
            this.lbl_giris_pw.Location = new System.Drawing.Point(129, 263);
            this.lbl_giris_pw.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_giris_pw.Name = "lbl_giris_pw";
            this.lbl_giris_pw.Size = new System.Drawing.Size(64, 22);
            this.lbl_giris_pw.TabIndex = 1;
            this.lbl_giris_pw.Text = "Şifre : ";
            // 
            // txtb_giris_id
            // 
            this.txtb_giris_id.Location = new System.Drawing.Point(239, 195);
            this.txtb_giris_id.Margin = new System.Windows.Forms.Padding(4);
            this.txtb_giris_id.Name = "txtb_giris_id";
            this.txtb_giris_id.Size = new System.Drawing.Size(158, 23);
            this.txtb_giris_id.TabIndex = 3;
            // 
            // txtb_giris_pw
            // 
            this.txtb_giris_pw.Location = new System.Drawing.Point(239, 263);
            this.txtb_giris_pw.Margin = new System.Windows.Forms.Padding(4);
            this.txtb_giris_pw.Name = "txtb_giris_pw";
            this.txtb_giris_pw.Size = new System.Drawing.Size(158, 23);
            this.txtb_giris_pw.TabIndex = 4;
            this.txtb_giris_pw.UseSystemPasswordChar = true;
            // 
            // btn_kayit
            // 
            this.btn_kayit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(0)))), ((int)(((byte)(89)))));
            this.btn_kayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kayit.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kayit.ForeColor = System.Drawing.Color.White;
            this.btn_kayit.Location = new System.Drawing.Point(92, 325);
            this.btn_kayit.Name = "btn_kayit";
            this.btn_kayit.Size = new System.Drawing.Size(119, 62);
            this.btn_kayit.TabIndex = 6;
            this.btn_kayit.Text = "Kayıt Ol";
            this.btn_kayit.UseVisualStyleBackColor = false;
            this.btn_kayit.Click += new System.EventHandler(this.btn_kayit_Click);
            // 
            // btn_giris
            // 
            this.btn_giris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(0)))), ((int)(((byte)(89)))));
            this.btn_giris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_giris.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_giris.ForeColor = System.Drawing.Color.White;
            this.btn_giris.Location = new System.Drawing.Point(277, 325);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(121, 62);
            this.btn_giris.TabIndex = 7;
            this.btn_giris.Text = "Giriş";
            this.btn_giris.UseVisualStyleBackColor = false;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::odev.Properties.Resources.En_IyIsIne_guven_1;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 481);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // giris_sayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(498, 507);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.btn_kayit);
            this.Controls.Add(this.txtb_giris_pw);
            this.Controls.Add(this.txtb_giris_id);
            this.Controls.Add(this.lbl_giris_pw);
            this.Controls.Add(this.lbl_giris_id);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "giris_sayfasi";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_giris_id;
        private System.Windows.Forms.Label lbl_giris_pw;
        private System.Windows.Forms.TextBox txtb_giris_id;
        private System.Windows.Forms.TextBox txtb_giris_pw;
        private System.Windows.Forms.Button btn_kayit;
        private System.Windows.Forms.Button btn_giris;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

