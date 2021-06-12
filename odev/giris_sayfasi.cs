using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;


namespace odev
{

    public partial class giris_sayfasi : MetroFramework.Forms.MetroForm
    {
        SqlConnection con;
        SqlCommand com;
        SqlDataReader rd;

        public giris_sayfasi()
        {
            InitializeComponent();
        }

        private void btn_kayit_Click(object sender, EventArgs e)
        {
            Kayit_ol kyt = new Kayit_ol();
            kyt.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            con = new SqlConnection("Data Source=DESKTOP-ORFTL34;Initial Catalog=Sqlyazilimyapimi;Integrated Security=True");
            com = new SqlCommand();
            con.Open();
            com.Connection = con;
            com.CommandText = "Select * From bilgiler Where  KullaniciAdi='" + textBox1.Text + "' AND Sifre='" + textBox2.Text + "'";
            rd = com.ExecuteReader();

            if (textBox1.Text != "" && textBox2.Text != "")
            {
                if (rd.Read())
                {
                    if (Convert.ToInt32(rd["YetkiiD"]) == 1)
                    {
                        admin admn = new admin();
                        textBox1.Clear();
                        textBox2.Clear();
                        admn.Show();
                    }
                    else if((Convert.ToInt32(rd["YetkiiD"]) == 2))
                    {
                        Kullanici kllnc = new Kullanici(Convert.ToInt32(rd["UseriD"]));
                        textBox1.Clear();
                        textBox2.Clear();
                        kllnc.Show();

                    }
                    else
                    {
                        muhasebe mhsb = new muhasebe(Convert.ToInt32(rd["UseriD"]));
                        textBox1.Clear();
                        textBox2.Clear();
                        mhsb.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Hatalı Giriş Yaptınız!!");
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı Adını veya Şifreyi Girmediniz..");
            }

            con.Close();
        }
    }
}
    

    

