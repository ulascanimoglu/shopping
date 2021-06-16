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
using System.Globalization;

namespace odev
{
    public partial class alisveris : MetroFramework.Forms.MetroForm
    {
        ListView lvw;
        int uid;
        int id;
        decimal para;
        Label lbl8;
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-ORFTL34;Initial Catalog=Sqlyazilimyapimi;Integrated Security=True");
        SqlCommand komut = new SqlCommand();

        public alisveris(int uid, int id,ListView lvw, Label lbl8)
        {
            InitializeComponent();
            this.uid = uid;
            this.id = id;
            this.lvw = lvw;
            this.lbl8 = lbl8;
            goster();  
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
        private void goster()
        {
            baglan.Open();
            komut = new SqlCommand("Select * From Satis Where SatisiD='" + uid + "'", baglan);
            SqlDataReader rd;
            rd = komut.ExecuteReader();
            while (rd.Read())
            {
                lbl1_al_urun.Text = rd["Urun"].ToString();
                lbl1_al_miktar.Text = rd["Stok"].ToString();
                para = Convert.ToDecimal(rd["Deger"]);
            }
            rd.Close();
            baglan.Close();
        }

        private void btn_onayla_Click(object sender, EventArgs e)
        {
            decimal toplamPara=0;
            int stok = Convert.ToInt32(lbl1_al_miktar.Text.ToString());
            
            baglan.Open();
            komut = new SqlCommand("Select * From bilgiler Where UseriD='" + id + "'", baglan);
            SqlDataReader rd;
            rd = komut.ExecuteReader();
            while (rd.Read())
            {
                 toplamPara = Convert.ToDecimal(rd["Para"]);
               
            }
            baglan.Close();

            if (txtb_al_miktar.Text != "")
            {
                int istek = Convert.ToInt32(txtb_al_miktar.Text.ToString());

                if (istek <= stok && toplamPara>=(para*istek))
                {
              
                    baglan.Open();
                    komut = new SqlCommand("exec StokAzaltma '"+istek+"','" + uid+"','"+id +"'",baglan);
                    komut.ExecuteNonQuery();
                    baglan.Close();
                    listeGoster(lvw,lbl8);
                }
                else
                {
                    MessageBox.Show("Stok Yetersiz");
                }
            }
            else
            {
                MessageBox.Show("Boş Değer Girdiniz");
            }
            txtb_al_miktar.Clear();
        }
    }
}
