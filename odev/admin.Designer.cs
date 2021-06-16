
namespace odev
{
    partial class admin
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
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lV_urun_onay = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lV_para_onay = new System.Windows.Forms.ListView();
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbl_onay_urun = new System.Windows.Forms.Label();
            this.lbl_onay_para = new System.Windows.Forms.Label();
            this.lbl_info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // columnHeader6
            // 
            this.columnHeader6.DisplayIndex = 0;
            this.columnHeader6.Text = "iD";
            this.columnHeader6.Width = 35;
            // 
            // columnHeader7
            // 
            this.columnHeader7.DisplayIndex = 1;
            this.columnHeader7.Text = "Kullanıcı Adı";
            this.columnHeader7.Width = 110;
            // 
            // columnHeader8
            // 
            this.columnHeader8.DisplayIndex = 2;
            this.columnHeader8.Text = "Para Miktarı";
            this.columnHeader8.Width = 110;
            // 
            // columnHeader1
            // 
            this.columnHeader1.DisplayIndex = 0;
            this.columnHeader1.Text = "iD";
            this.columnHeader1.Width = 35;
            // 
            // columnHeader2
            // 
            this.columnHeader2.DisplayIndex = 1;
            this.columnHeader2.Text = "Satıcı Adı";
            this.columnHeader2.Width = 95;
            // 
            // columnHeader3
            // 
            this.columnHeader3.DisplayIndex = 2;
            this.columnHeader3.Text = "Ürün Adı";
            this.columnHeader3.Width = 95;
            // 
            // columnHeader4
            // 
            this.columnHeader4.DisplayIndex = 3;
            this.columnHeader4.Text = "Birim Fiyat";
            this.columnHeader4.Width = 105;
            // 
            // columnHeader5
            // 
            this.columnHeader5.DisplayIndex = 4;
            this.columnHeader5.Text = "Toplam Adet";
            this.columnHeader5.Width = 115;
            // 
            // lV_urun_onay
            // 
            this.lV_urun_onay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lV_urun_onay.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader18,
            this.columnHeader10,
            this.columnHeader16,
            this.columnHeader11,
            this.columnHeader12});
            this.lV_urun_onay.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lV_urun_onay.HideSelection = false;
            this.lV_urun_onay.Location = new System.Drawing.Point(17, 61);
            this.lV_urun_onay.Margin = new System.Windows.Forms.Padding(2);
            this.lV_urun_onay.Name = "lV_urun_onay";
            this.lV_urun_onay.Size = new System.Drawing.Size(450, 299);
            this.lV_urun_onay.TabIndex = 0;
            this.lV_urun_onay.UseCompatibleStateImageBehavior = false;
            this.lV_urun_onay.View = System.Windows.Forms.View.Details;
            this.lV_urun_onay.DoubleClick += new System.EventHandler(this.listView1_DoubleClick_1);
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "id";
            this.columnHeader9.Width = 35;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Kullanıcı İd";
            this.columnHeader18.Width = 110;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Kullanıcı Adı";
            this.columnHeader10.Width = 110;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Ürün Adı";
            this.columnHeader16.Width = 90;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Birim Fiyat";
            this.columnHeader11.Width = 110;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Stok";
            this.columnHeader12.Width = 85;
            // 
            // lV_para_onay
            // 
            this.lV_para_onay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lV_para_onay.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader17});
            this.lV_para_onay.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lV_para_onay.HideSelection = false;
            this.lV_para_onay.Location = new System.Drawing.Point(500, 61);
            this.lV_para_onay.Margin = new System.Windows.Forms.Padding(2);
            this.lV_para_onay.Name = "lV_para_onay";
            this.lV_para_onay.Size = new System.Drawing.Size(380, 299);
            this.lV_para_onay.TabIndex = 1;
            this.lV_para_onay.UseCompatibleStateImageBehavior = false;
            this.lV_para_onay.View = System.Windows.Forms.View.Details;
            this.lV_para_onay.DoubleClick += new System.EventHandler(this.listView2_DoubleClick);
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "id";
            this.columnHeader13.Width = 50;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Kullanıcı Adı";
            this.columnHeader14.Width = 120;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Para Birimi";
            this.columnHeader15.Width = 115;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Para";
            this.columnHeader17.Width = 80;
            // 
            // lbl_onay_urun
            // 
            this.lbl_onay_urun.AutoSize = true;
            this.lbl_onay_urun.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_onay_urun.Location = new System.Drawing.Point(134, 37);
            this.lbl_onay_urun.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_onay_urun.Name = "lbl_onay_urun";
            this.lbl_onay_urun.Size = new System.Drawing.Size(110, 14);
            this.lbl_onay_urun.TabIndex = 2;
            this.lbl_onay_urun.Text = "Ürün Onaylama";
            // 
            // lbl_onay_para
            // 
            this.lbl_onay_para.AutoSize = true;
            this.lbl_onay_para.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_onay_para.Location = new System.Drawing.Point(649, 35);
            this.lbl_onay_para.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_onay_para.Name = "lbl_onay_para";
            this.lbl_onay_para.Size = new System.Drawing.Size(109, 14);
            this.lbl_onay_para.TabIndex = 3;
            this.lbl_onay_para.Text = "Para Onaylama";
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.BackColor = System.Drawing.Color.Transparent;
            this.lbl_info.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_info.Location = new System.Drawing.Point(14, 7);
            this.lbl_info.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(408, 17);
            this.lbl_info.TabIndex = 4;
            this.lbl_info.Text = "* İşlem Yapmak İstediğiniz Sıranın id\'sine Tıklayınız";
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(888, 377);
            this.Controls.Add(this.lbl_info);
            this.Controls.Add(this.lbl_onay_para);
            this.Controls.Add(this.lbl_onay_urun);
            this.Controls.Add(this.lV_para_onay);
            this.Controls.Add(this.lV_urun_onay);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "admin";
            this.Text = "admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ListView lV_urun_onay;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ListView lV_para_onay;
        private System.Windows.Forms.Label lbl_onay_urun;
        private System.Windows.Forms.Label lbl_onay_para;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
    }
}