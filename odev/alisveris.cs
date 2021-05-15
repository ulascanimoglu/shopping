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
    public partial class alisveris : Form
    {
        ListView lvw;
        int uid;
        int id;
        decimal para;
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-ORFTL34;Initial Catalog=Sqlyazilimyapimi;Integrated Security=True");
        SqlCommand komut = new SqlCommand();

        public alisveris(int uid, int id,ListView lvw)
        {
            InitializeComponent();
            this.uid = uid;
            this.id = id;
            this.lvw = lvw;
            goster();
            
        }
        private void listeGoster(ListView lvw)
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
                label2.Text = rd["Urun"].ToString();
                label5.Text = rd["Stok"].ToString();
                para = Convert.ToDecimal(rd["Deger"]);
            }
            rd.Close();
            baglan.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal toplamPara=0;
            int stok = Convert.ToInt32(label5.Text.ToString());
            int istek = Convert.ToInt32(textBox1.Text.ToString());
            baglan.Open();
            komut = new SqlCommand("Select * From bilgiler Where UseriD='" + id + "'", baglan);
            SqlDataReader rd;
            rd = komut.ExecuteReader();
            while (rd.Read())
            {
                 toplamPara = Convert.ToDecimal(rd["Para"]);
               
            }
            baglan.Close();
            
                if (textBox1.Text != "")
              {

                if (istek <= stok && toplamPara>=(para*istek))
                {
                    baglan.Open();
                    komut = new SqlCommand("exec StokAzaltma '"+istek+"','" + uid+"','"+id +"'",baglan);
                    komut.ExecuteNonQuery();
                    baglan.Close();
                    listeGoster(lvw);
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
            textBox1.Clear();
        }
    }
}
