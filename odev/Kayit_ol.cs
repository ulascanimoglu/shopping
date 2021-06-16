using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace odev 
{
    public partial class Kayit_ol : Form
    {
        public Kayit_ol()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-ORFTL34;Initial Catalog=Sqlyazilimyapimi;Integrated Security=True");

        private void btn_kayitol_Click(object sender, EventArgs e)
        {
            if (txtb_kyt_ad.Text != "" && txtb_kyt_soyad.Text != "" && txtb_kyt_id.Text != "" && txtb_kyt_pw.Text != "" && txtb_kyt_tck.Text != "" && txtb_kyt_phoneN.Text != "" && txtb_kyt_mail.Text != "" && txtb_kyt_adress.Text != "")
            {
                bool deger = false;
                try
                {
                    baglan.Open();
                    SqlCommand komut = new SqlCommand("insert into bilgiler (Ad,Soyad,KullaniciAdi,Sifre,TcKimlik,Telefon,Email,Adres,Para,YetkiiD) values( '" + txtb_kyt_ad.Text.ToString() + "','" + txtb_kyt_soyad.Text.ToString() + "','" + txtb_kyt_id.Text.ToString() + "','" + txtb_kyt_pw.Text.ToString() + "','" + txtb_kyt_tck.Text.ToString() + "','" + txtb_kyt_phoneN.Text.ToString() + "','" + txtb_kyt_mail.Text.ToString() + "','" + txtb_kyt_adress.Text.ToString() + "' ,'" + 0.0000 + "','"+ 2 +"')", baglan);
                    komut.ExecuteNonQuery();
                    baglan.Close();
                }
                catch (Exception)
                {
                    deger = true;
                    throw;
                }
                
                if (!deger)
                {
                    MessageBox.Show("Başarıyla Kayıt Oldunuz");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Boş Alan Bırakamazsınız Tüm Bilgileri Giriniz.");
            }
            
        }
    }
}
