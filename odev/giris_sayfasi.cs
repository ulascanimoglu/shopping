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

        private void btn_giris_Click(object sender, EventArgs e)
        {

            con = new SqlConnection("Data Source=DESKTOP-ORFTL34;Initial Catalog=Sqlyazilimyapimi;Integrated Security=True");
            com = new SqlCommand();
            con.Open();
            com.Connection = con;
            com.CommandText = "Select * From bilgiler Where  KullaniciAdi='" + txtb_giris_id.Text + "' AND Sifre='" + txtb_giris_pw.Text + "'";
            rd = com.ExecuteReader();

            if (txtb_giris_id.Text != "" && txtb_giris_pw.Text != "")
            {
                if (rd.Read())
                {
                    if (Convert.ToInt32(rd["YetkiiD"]) == 1)
                    {
                        admin admn = new admin();
                        txtb_giris_id.Clear();
                        txtb_giris_pw.Clear();
                        admn.Show();
                    }
                    else if((Convert.ToInt32(rd["YetkiiD"]) == 2))
                    {
                        Kullanici kllnc = new Kullanici(Convert.ToInt32(rd["UseriD"]));
                        txtb_giris_id.Clear();
                        txtb_giris_pw.Clear();
                        kllnc.Show();

                    }
                    else
                    {
                        muhasebe mhsb = new muhasebe(Convert.ToInt32(rd["UseriD"]));
                        txtb_giris_id.Clear();
                        txtb_giris_pw.Clear();
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
    

    

