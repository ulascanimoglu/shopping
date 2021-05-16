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

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "")
            {
                bool deger = false;
                try
                {
                    baglan.Open();
                    SqlCommand komut = new SqlCommand("insert into bilgiler (Ad,Soyad,KullaniciAdi,Sifre,TcKimlik,Telefon,Email,Adres,Para,YetkiiD) values( '" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + textBox4.Text.ToString() + "','" + textBox5.Text.ToString() + "','" + textBox6.Text.ToString() + "','" + textBox7.Text.ToString() + "','" + textBox8.Text.ToString() + "' ,'" + 0.0000 + "','"+ 2 +"')", baglan);
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
