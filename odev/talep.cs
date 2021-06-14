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
    public partial class talep : Form
    {
        int uid;
        int id;
        int para;
        ListView lvw;
        Label lbl8;

        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-ORFTL34;Initial Catalog=Sqlyazilimyapimi;Integrated Security=True");
        public talep(int id,int para, ListView lvw, Label lbl8)
        {
            InitializeComponent();
            this.id = id;
            this.para = para;
            label1.Text= para.ToString();
            this.lvw = lvw;
            this.lbl8 = lbl8;
            
        }
        private void listeGoster(ListView lvw, Label lbl8)
        {
            lvw.Items.Clear();
            baglan.Open();
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "Select * From Satis where Stok>0";
            komut.Connection = baglan;

            SqlDataAdapter adap = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();

            adap.Fill(tablo);

            for (int i = 0; i < tablo.Rows.Count; i++)
            {
                lvw.Items.Add(tablo.Rows[i]["SatisiD"].ToString());
                lvw.Items[i].SubItems.Add(tablo.Rows[i]["Urun"].ToString());
                lvw.Items[i].SubItems.Add(tablo.Rows[i]["Deger"].ToString());
                lvw.Items[i].SubItems.Add(tablo.Rows[i]["Stok"].ToString());
            }
            komut = new SqlCommand("Select Para From bilgiler Where UseriD='" + id + "'", baglan);
            SqlDataReader rd;
            rd = komut.ExecuteReader();
            while (rd.Read())
            {
                lbl8.Text = rd["Para"].ToString() + " TL";
            }
            baglan.Close();
        }
     

        private void btntalep_Click(object sender, EventArgs e)
        {
           
            SqlDataReader rd;
            SqlCommand com = new SqlCommand();
            baglan.Open();
            com.Connection = baglan;
            com.CommandText = "Select * From Satis Where Urun='"+cmbisturun.Text+"' AND Deger='"+txtboxistfiyat.Text+"' AND Stok>='"+txtboxistmiktar.Text+"'";
            rd = com.ExecuteReader();
           
            if (cmbisturun.Text != "" && txtboxistfiyat.Text != "" && txtboxistmiktar.Text != "") {

                int miktar = Convert.ToInt32(txtboxistmiktar.Text);
                int fiyat = Convert.ToInt32(txtboxistfiyat.Text);

                if (rd.Read()) {
                    uid = Convert.ToInt32(rd["SatisiD"]);
                    baglan.Close();
                    if (para >= (miktar * fiyat))
                    {
                        baglan.Open();
                        com = new SqlCommand("exec StokAzaltma '" +miktar + "','" + uid + "','" + id + "'", baglan);
                        com.ExecuteNonQuery();
                        rd.Close();
                        baglan.Close();
                        MessageBox.Show("İstediğiniz Ürün Başarıyla Alınmıştır.");
                        listeGoster(lvw, lbl8);
                        txtboxistfiyat.Clear();
                        txtboxistmiktar.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Yeterli Bakiyeniz Yoktur.");
                    }
                    
                }
                else
                {
                    baglan.Close();
                    baglan.Open();
                    SqlCommand komut = new SqlCommand("insert into Talep (UseriD,UrunAd,Fiyat,Miktar,kontrol)values('" + id + "','" + cmbisturun.Text.ToString() + "','" + Convert.ToDecimal(txtboxistfiyat.Text) + "','" + Convert.ToInt32(txtboxistmiktar.Text) +"','"+0+ "')", baglan);
                    komut.ExecuteNonQuery();
                    baglan.Close();
                    MessageBox.Show("Uygun Ürün Bulunamadı. Talep Oluşturuldu.");
                    txtboxistfiyat.Clear();
                    txtboxistmiktar.Clear();
                }
            }
            else
            {
                MessageBox.Show("Talep Oluşturmak İçin Alanları Doldurunuz.");
               
            }
    
        }

        
    }
}
