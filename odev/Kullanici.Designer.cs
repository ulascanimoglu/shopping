
namespace odev
{
    partial class Kullanici
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
            this.components = new System.ComponentModel.Container();
            this.tabC_kullanici = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbl_info2 = new System.Windows.Forms.Label();
            this.btn_aramayap = new System.Windows.Forms.Button();
            this.lbl_info = new System.Windows.Forms.Label();
            this.lbl_para = new System.Windows.Forms.Label();
            this.lbl_bakiye = new System.Windows.Forms.Label();
            this.lV_kullanici_alisveris = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbl_bakiye_parabirim = new System.Windows.Forms.Label();
            this.cmb_parabirim = new System.Windows.Forms.ComboBox();
            this.btn_bakiye_onayiste = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lbl_bakiye_miktar = new System.Windows.Forms.Label();
            this.lbl_ekle_bakiye = new System.Windows.Forms.Label();
            this.btn_urun_onayiste = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbl_urun_brmfiyat = new System.Windows.Forms.Label();
            this.lbl_ekle_urun = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_urun_miktar = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbl_urun_ad = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_goster = new System.Windows.Forms.Button();
            this.dataGV_rapor = new System.Windows.Forms.DataGridView();
            this.tarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miktarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.değerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ürünDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarihViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appData = new odev.appData();
            this.btn_yazdir = new System.Windows.Forms.Button();
            this.dateTP_bitis = new System.Windows.Forms.DateTimePicker();
            this.dateTP_baslangic = new System.Windows.Forms.DateTimePicker();
            this.lbl_tarih_bitis = new System.Windows.Forms.Label();
            this.lbl_tarih_baslangic = new System.Windows.Forms.Label();
            this.tarihViewTableAdapter = new odev.appDataTableAdapters.TarihViewTableAdapter();
            this.tabC_kullanici.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_rapor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarihViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            this.SuspendLayout();
            // 
            // tabC_kullanici
            // 
            this.tabC_kullanici.Controls.Add(this.tabPage1);
            this.tabC_kullanici.Controls.Add(this.tabPage2);
            this.tabC_kullanici.Controls.Add(this.tabPage3);
            this.tabC_kullanici.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabC_kullanici.Location = new System.Drawing.Point(10, 3);
            this.tabC_kullanici.Margin = new System.Windows.Forms.Padding(2);
            this.tabC_kullanici.Name = "tabC_kullanici";
            this.tabC_kullanici.SelectedIndex = 0;
            this.tabC_kullanici.Size = new System.Drawing.Size(626, 393);
            this.tabC_kullanici.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tabPage1.Controls.Add(this.lbl_info2);
            this.tabPage1.Controls.Add(this.btn_aramayap);
            this.tabPage1.Controls.Add(this.lbl_info);
            this.tabPage1.Controls.Add(this.lbl_para);
            this.tabPage1.Controls.Add(this.lbl_bakiye);
            this.tabPage1.Controls.Add(this.lV_kullanici_alisveris);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(618, 368);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Alışveriş";
            // 
            // lbl_info2
            // 
            this.lbl_info2.AutoSize = true;
            this.lbl_info2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_info2.Location = new System.Drawing.Point(12, 232);
            this.lbl_info2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_info2.Name = "lbl_info2";
            this.lbl_info2.Size = new System.Drawing.Size(607, 17);
            this.lbl_info2.TabIndex = 6;
            this.lbl_info2.Text = "İsterseniz Arama Yapabilirsiniz. Aramanız Sonuçsuz Olursa Talep Oluşturulur.";
            // 
            // btn_aramayap
            // 
            this.btn_aramayap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_aramayap.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_aramayap.Location = new System.Drawing.Point(215, 279);
            this.btn_aramayap.Margin = new System.Windows.Forms.Padding(2);
            this.btn_aramayap.Name = "btn_aramayap";
            this.btn_aramayap.Size = new System.Drawing.Size(117, 44);
            this.btn_aramayap.TabIndex = 5;
            this.btn_aramayap.Text = "Arama Yap";
            this.btn_aramayap.UseVisualStyleBackColor = true;
            this.btn_aramayap.Click += new System.EventHandler(this.button3_Click);
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_info.Location = new System.Drawing.Point(4, 11);
            this.lbl_info.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(412, 17);
            this.lbl_info.TabIndex = 3;
            this.lbl_info.Text = "* İşlem Yapmak İstediğiniz Ürünün id\'sine Tıklayınız";
            // 
            // lbl_para
            // 
            this.lbl_para.AutoSize = true;
            this.lbl_para.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_para.Location = new System.Drawing.Point(470, 102);
            this.lbl_para.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_para.Name = "lbl_para";
            this.lbl_para.Size = new System.Drawing.Size(54, 17);
            this.lbl_para.TabIndex = 2;
            this.lbl_para.Text = "label8";
            // 
            // lbl_bakiye
            // 
            this.lbl_bakiye.AutoSize = true;
            this.lbl_bakiye.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_bakiye.Location = new System.Drawing.Point(470, 40);
            this.lbl_bakiye.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_bakiye.Name = "lbl_bakiye";
            this.lbl_bakiye.Size = new System.Drawing.Size(81, 17);
            this.lbl_bakiye.TabIndex = 1;
            this.lbl_bakiye.Text = "Bakiyeniz";
            // 
            // lV_kullanici_alisveris
            // 
            this.lV_kullanici_alisveris.BackColor = System.Drawing.Color.White;
            this.lV_kullanici_alisveris.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lV_kullanici_alisveris.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lV_kullanici_alisveris.HideSelection = false;
            this.lV_kullanici_alisveris.Location = new System.Drawing.Point(4, 40);
            this.lV_kullanici_alisveris.Margin = new System.Windows.Forms.Padding(2);
            this.lV_kullanici_alisveris.Name = "lV_kullanici_alisveris";
            this.lV_kullanici_alisveris.Size = new System.Drawing.Size(413, 175);
            this.lV_kullanici_alisveris.TabIndex = 0;
            this.lV_kullanici_alisveris.UseCompatibleStateImageBehavior = false;
            this.lV_kullanici_alisveris.View = System.Windows.Forms.View.Details;
            this.lV_kullanici_alisveris.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "id";
            this.columnHeader4.Width = 35;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ürün Adı";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Birim Fiyat";
            this.columnHeader2.Width = 110;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Toplam Stok";
            this.columnHeader3.Width = 120;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tabPage2.Controls.Add(this.lbl_bakiye_parabirim);
            this.tabPage2.Controls.Add(this.cmb_parabirim);
            this.tabPage2.Controls.Add(this.btn_bakiye_onayiste);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.lbl_bakiye_miktar);
            this.tabPage2.Controls.Add(this.lbl_ekle_bakiye);
            this.tabPage2.Controls.Add(this.btn_urun_onayiste);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.lbl_urun_brmfiyat);
            this.tabPage2.Controls.Add(this.lbl_ekle_urun);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.lbl_urun_miktar);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.lbl_urun_ad);
            this.tabPage2.Location = new System.Drawing.Point(4, 21);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(618, 368);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ürün ve Bakiye Ekleme";
            // 
            // lbl_bakiye_parabirim
            // 
            this.lbl_bakiye_parabirim.AutoSize = true;
            this.lbl_bakiye_parabirim.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_bakiye_parabirim.Location = new System.Drawing.Point(289, 63);
            this.lbl_bakiye_parabirim.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_bakiye_parabirim.Name = "lbl_bakiye_parabirim";
            this.lbl_bakiye_parabirim.Size = new System.Drawing.Size(113, 18);
            this.lbl_bakiye_parabirim.TabIndex = 13;
            this.lbl_bakiye_parabirim.Text = "Para Birimi : ";
            // 
            // cmb_parabirim
            // 
            this.cmb_parabirim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_parabirim.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_parabirim.FormattingEnabled = true;
            this.cmb_parabirim.Items.AddRange(new object[] {
            "Türk Lirası",
            "ABD Doları",
            "İngiliz Sterlini",
            "Euro"});
            this.cmb_parabirim.Location = new System.Drawing.Point(407, 63);
            this.cmb_parabirim.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_parabirim.Name = "cmb_parabirim";
            this.cmb_parabirim.Size = new System.Drawing.Size(117, 22);
            this.cmb_parabirim.TabIndex = 12;
            // 
            // btn_bakiye_onayiste
            // 
            this.btn_bakiye_onayiste.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_bakiye_onayiste.Location = new System.Drawing.Point(381, 166);
            this.btn_bakiye_onayiste.Margin = new System.Windows.Forms.Padding(2);
            this.btn_bakiye_onayiste.Name = "btn_bakiye_onayiste";
            this.btn_bakiye_onayiste.Size = new System.Drawing.Size(98, 36);
            this.btn_bakiye_onayiste.TabIndex = 11;
            this.btn_bakiye_onayiste.Text = "Onay İste";
            this.btn_bakiye_onayiste.UseVisualStyleBackColor = true;
            this.btn_bakiye_onayiste.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox3.Location = new System.Drawing.Point(407, 93);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(117, 22);
            this.textBox3.TabIndex = 10;
            // 
            // lbl_bakiye_miktar
            // 
            this.lbl_bakiye_miktar.AutoSize = true;
            this.lbl_bakiye_miktar.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_bakiye_miktar.Location = new System.Drawing.Point(289, 94);
            this.lbl_bakiye_miktar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_bakiye_miktar.Name = "lbl_bakiye_miktar";
            this.lbl_bakiye_miktar.Size = new System.Drawing.Size(79, 18);
            this.lbl_bakiye_miktar.TabIndex = 9;
            this.lbl_bakiye_miktar.Text = "Bakiye : ";
            // 
            // lbl_ekle_bakiye
            // 
            this.lbl_ekle_bakiye.AutoSize = true;
            this.lbl_ekle_bakiye.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ekle_bakiye.Location = new System.Drawing.Point(347, 24);
            this.lbl_ekle_bakiye.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ekle_bakiye.Name = "lbl_ekle_bakiye";
            this.lbl_ekle_bakiye.Size = new System.Drawing.Size(102, 18);
            this.lbl_ekle_bakiye.TabIndex = 8;
            this.lbl_ekle_bakiye.Text = "Bakiye Ekle";
            // 
            // btn_urun_onayiste
            // 
            this.btn_urun_onayiste.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_urun_onayiste.Location = new System.Drawing.Point(166, 166);
            this.btn_urun_onayiste.Margin = new System.Windows.Forms.Padding(2);
            this.btn_urun_onayiste.Name = "btn_urun_onayiste";
            this.btn_urun_onayiste.Size = new System.Drawing.Size(98, 36);
            this.btn_urun_onayiste.TabIndex = 7;
            this.btn_urun_onayiste.Text = "Onay İste";
            this.btn_urun_onayiste.UseVisualStyleBackColor = true;
            this.btn_urun_onayiste.Click += new System.EventHandler(this.btn_aramayap_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(173, 121);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(92, 22);
            this.textBox2.TabIndex = 6;
            // 
            // lbl_urun_brmfiyat
            // 
            this.lbl_urun_brmfiyat.AutoSize = true;
            this.lbl_urun_brmfiyat.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_urun_brmfiyat.Location = new System.Drawing.Point(21, 124);
            this.lbl_urun_brmfiyat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_urun_brmfiyat.Name = "lbl_urun_brmfiyat";
            this.lbl_urun_brmfiyat.Size = new System.Drawing.Size(158, 18);
            this.lbl_urun_brmfiyat.TabIndex = 5;
            this.lbl_urun_brmfiyat.Text = "Ürün Birim-Fiyat : ";
            // 
            // lbl_ekle_urun
            // 
            this.lbl_ekle_urun.AutoSize = true;
            this.lbl_ekle_urun.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ekle_urun.Location = new System.Drawing.Point(92, 24);
            this.lbl_ekle_urun.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ekle_urun.Name = "lbl_ekle_urun";
            this.lbl_ekle_urun.Size = new System.Drawing.Size(86, 18);
            this.lbl_ekle_urun.TabIndex = 4;
            this.lbl_ekle_urun.Text = "Ürün Ekle";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(173, 91);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(92, 22);
            this.textBox1.TabIndex = 3;
            // 
            // lbl_urun_miktar
            // 
            this.lbl_urun_miktar.AutoSize = true;
            this.lbl_urun_miktar.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_urun_miktar.Location = new System.Drawing.Point(21, 94);
            this.lbl_urun_miktar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_urun_miktar.Name = "lbl_urun_miktar";
            this.lbl_urun_miktar.Size = new System.Drawing.Size(124, 18);
            this.lbl_urun_miktar.TabIndex = 2;
            this.lbl_urun_miktar.Text = "Ürün Miktarı : ";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Arpa",
            "Buğday",
            "Bulgur",
            "Ekmek",
            "Pamuk",
            "Petrol",
            "Pirinç",
            "Su",
            "Yulaf"});
            this.comboBox1.Location = new System.Drawing.Point(173, 59);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(92, 22);
            this.comboBox1.TabIndex = 1;
            // 
            // lbl_urun_ad
            // 
            this.lbl_urun_ad.AutoSize = true;
            this.lbl_urun_ad.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_urun_ad.Location = new System.Drawing.Point(21, 63);
            this.lbl_urun_ad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_urun_ad.Name = "lbl_urun_ad";
            this.lbl_urun_ad.Size = new System.Drawing.Size(94, 18);
            this.lbl_urun_ad.TabIndex = 0;
            this.lbl_urun_ad.Text = "Ürün Adı : ";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tabPage3.Controls.Add(this.btn_goster);
            this.tabPage3.Controls.Add(this.dataGV_rapor);
            this.tabPage3.Controls.Add(this.btn_yazdir);
            this.tabPage3.Controls.Add(this.dateTP_bitis);
            this.tabPage3.Controls.Add(this.dateTP_baslangic);
            this.tabPage3.Controls.Add(this.lbl_tarih_bitis);
            this.tabPage3.Controls.Add(this.lbl_tarih_baslangic);
            this.tabPage3.Location = new System.Drawing.Point(4, 21);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(618, 368);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "İşlem Geçmişi";
            // 
            // btn_goster
            // 
            this.btn_goster.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_goster.Location = new System.Drawing.Point(342, 104);
            this.btn_goster.Margin = new System.Windows.Forms.Padding(2);
            this.btn_goster.Name = "btn_goster";
            this.btn_goster.Size = new System.Drawing.Size(88, 32);
            this.btn_goster.TabIndex = 6;
            this.btn_goster.Text = "Göster";
            this.btn_goster.UseVisualStyleBackColor = true;
            this.btn_goster.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGV_rapor
            // 
            this.dataGV_rapor.AllowUserToAddRows = false;
            this.dataGV_rapor.AllowUserToDeleteRows = false;
            this.dataGV_rapor.AutoGenerateColumns = false;
            this.dataGV_rapor.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGV_rapor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_rapor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tarihDataGridViewTextBoxColumn,
            this.miktarDataGridViewTextBoxColumn,
            this.değerDataGridViewTextBoxColumn,
            this.ürünDataGridViewTextBoxColumn});
            this.dataGV_rapor.DataSource = this.tarihViewBindingSource;
            this.dataGV_rapor.Location = new System.Drawing.Point(4, 151);
            this.dataGV_rapor.Margin = new System.Windows.Forms.Padding(2);
            this.dataGV_rapor.Name = "dataGV_rapor";
            this.dataGV_rapor.ReadOnly = true;
            this.dataGV_rapor.RowHeadersWidth = 51;
            this.dataGV_rapor.RowTemplate.Height = 24;
            this.dataGV_rapor.Size = new System.Drawing.Size(607, 216);
            this.dataGV_rapor.TabIndex = 5;
            // 
            // tarihDataGridViewTextBoxColumn
            // 
            this.tarihDataGridViewTextBoxColumn.DataPropertyName = "Tarih";
            this.tarihDataGridViewTextBoxColumn.HeaderText = "Tarih";
            this.tarihDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tarihDataGridViewTextBoxColumn.Name = "tarihDataGridViewTextBoxColumn";
            this.tarihDataGridViewTextBoxColumn.ReadOnly = true;
            this.tarihDataGridViewTextBoxColumn.Width = 125;
            // 
            // miktarDataGridViewTextBoxColumn
            // 
            this.miktarDataGridViewTextBoxColumn.DataPropertyName = "Miktar";
            this.miktarDataGridViewTextBoxColumn.HeaderText = "Miktar";
            this.miktarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.miktarDataGridViewTextBoxColumn.Name = "miktarDataGridViewTextBoxColumn";
            this.miktarDataGridViewTextBoxColumn.ReadOnly = true;
            this.miktarDataGridViewTextBoxColumn.Width = 125;
            // 
            // değerDataGridViewTextBoxColumn
            // 
            this.değerDataGridViewTextBoxColumn.DataPropertyName = "Değer";
            this.değerDataGridViewTextBoxColumn.HeaderText = "Değer";
            this.değerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.değerDataGridViewTextBoxColumn.Name = "değerDataGridViewTextBoxColumn";
            this.değerDataGridViewTextBoxColumn.ReadOnly = true;
            this.değerDataGridViewTextBoxColumn.Width = 125;
            // 
            // ürünDataGridViewTextBoxColumn
            // 
            this.ürünDataGridViewTextBoxColumn.DataPropertyName = "Ürün";
            this.ürünDataGridViewTextBoxColumn.HeaderText = "Ürün";
            this.ürünDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ürünDataGridViewTextBoxColumn.Name = "ürünDataGridViewTextBoxColumn";
            this.ürünDataGridViewTextBoxColumn.ReadOnly = true;
            this.ürünDataGridViewTextBoxColumn.Width = 125;
            // 
            // tarihViewBindingSource
            // 
            this.tarihViewBindingSource.DataMember = "TarihView";
            this.tarihViewBindingSource.DataSource = this.appData;
            // 
            // appData
            // 
            this.appData.DataSetName = "appData";
            this.appData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_yazdir
            // 
            this.btn_yazdir.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_yazdir.Location = new System.Drawing.Point(208, 104);
            this.btn_yazdir.Margin = new System.Windows.Forms.Padding(2);
            this.btn_yazdir.Name = "btn_yazdir";
            this.btn_yazdir.Size = new System.Drawing.Size(88, 32);
            this.btn_yazdir.TabIndex = 4;
            this.btn_yazdir.Text = "Yazdır";
            this.btn_yazdir.UseVisualStyleBackColor = true;
            this.btn_yazdir.Click += new System.EventHandler(this.button4_Click);
            // 
            // dateTP_bitis
            // 
            this.dateTP_bitis.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTP_bitis.Location = new System.Drawing.Point(208, 60);
            this.dateTP_bitis.Margin = new System.Windows.Forms.Padding(2);
            this.dateTP_bitis.Name = "dateTP_bitis";
            this.dateTP_bitis.Size = new System.Drawing.Size(223, 22);
            this.dateTP_bitis.TabIndex = 3;
            // 
            // dateTP_baslangic
            // 
            this.dateTP_baslangic.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTP_baslangic.Location = new System.Drawing.Point(208, 20);
            this.dateTP_baslangic.Margin = new System.Windows.Forms.Padding(2);
            this.dateTP_baslangic.Name = "dateTP_baslangic";
            this.dateTP_baslangic.Size = new System.Drawing.Size(223, 22);
            this.dateTP_baslangic.TabIndex = 2;
            // 
            // lbl_tarih_bitis
            // 
            this.lbl_tarih_bitis.AutoSize = true;
            this.lbl_tarih_bitis.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_tarih_bitis.Location = new System.Drawing.Point(55, 60);
            this.lbl_tarih_bitis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_tarih_bitis.Name = "lbl_tarih_bitis";
            this.lbl_tarih_bitis.Size = new System.Drawing.Size(78, 14);
            this.lbl_tarih_bitis.TabIndex = 1;
            this.lbl_tarih_bitis.Text = "Bitiş Tarihi";
            // 
            // lbl_tarih_baslangic
            // 
            this.lbl_tarih_baslangic.AutoSize = true;
            this.lbl_tarih_baslangic.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_tarih_baslangic.Location = new System.Drawing.Point(55, 20);
            this.lbl_tarih_baslangic.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_tarih_baslangic.Name = "lbl_tarih_baslangic";
            this.lbl_tarih_baslangic.Size = new System.Drawing.Size(112, 14);
            this.lbl_tarih_baslangic.TabIndex = 0;
            this.lbl_tarih_baslangic.Text = "Başlangıç Tarihi";
            // 
            // tarihViewTableAdapter
            // 
            this.tarihViewTableAdapter.ClearBeforeFill = true;
            // 
            // Kullanici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(645, 406);
            this.Controls.Add(this.tabC_kullanici);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Kullanici";
            this.Text = "Kullanici";
            this.Load += new System.EventHandler(this.Kullanici_Load);
            this.tabC_kullanici.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_rapor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarihViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabC_kullanici;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView lV_kullanici_alisveris;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_urun_onayiste;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbl_urun_brmfiyat;
        private System.Windows.Forms.Label lbl_ekle_urun;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_urun_miktar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbl_urun_ad;
        private System.Windows.Forms.Button btn_bakiye_onayiste;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lbl_bakiye_miktar;
        private System.Windows.Forms.Label lbl_ekle_bakiye;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label lbl_para;
        private System.Windows.Forms.Label lbl_bakiye;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.Label lbl_bakiye_parabirim;
        private System.Windows.Forms.ComboBox cmb_parabirim;
        private System.Windows.Forms.Button btn_aramayap;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DateTimePicker dateTP_bitis;
        private System.Windows.Forms.DateTimePicker dateTP_baslangic;
        private System.Windows.Forms.Label lbl_tarih_bitis;
        private System.Windows.Forms.Label lbl_tarih_baslangic;
        private System.Windows.Forms.DataGridView dataGV_rapor;
        private System.Windows.Forms.Button btn_yazdir;
        private System.Windows.Forms.Button btn_goster;
        private appData appData;
        private System.Windows.Forms.BindingSource tarihViewBindingSource;
        private appDataTableAdapters.TarihViewTableAdapter tarihViewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn miktarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn değerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ürünDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lbl_info2;
    }
}