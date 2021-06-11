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
    public partial class Kullanici : Form
    {
        int id;
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-ORFTL34;Initial Catalog=Sqlyazilimyapimi;Integrated Security=True");
        
        public Kullanici(int id)
        {
            InitializeComponent();
            this.id=id;
        }

        private void Kullanici_Load(object sender, EventArgs e)
        {
            listeGoster();
        }

        private void listeGoster()
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "Select * From Satis where Stok>0";
            komut.Connection = baglan;

            SqlDataAdapter adap = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();

            adap.Fill(tablo);
            
            for (int i = 0; i < tablo.Rows.Count; i++)
            {
                listView1.Items.Add(tablo.Rows[i]["SatisiD"].ToString());
                listView1.Items[i].SubItems.Add(tablo.Rows[i]["Urun"].ToString());
                listView1.Items[i].SubItems.Add(tablo.Rows[i]["Deger"].ToString());
                listView1.Items[i].SubItems.Add(tablo.Rows[i]["Stok"].ToString());
            }
            komut = new SqlCommand("Select Para From bilgiler Where UseriD='"+id+"'",baglan);
            SqlDataReader rd;
            rd = komut.ExecuteReader();
            while (rd.Read())
            {
                label8.Text = rd["Para"].ToString()+" TL";
            }
            baglan.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "" && textBox1.Text != "" && textBox2.Text != "")
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("insert into AdminOnay (UrunAd,Miktar,BirimFiyat,UseriD,Onay)values('" + comboBox1.Text.ToString() + "','" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + id + "','" + 0 + "')", baglan);
                komut.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("İsteğiniz Başarıyla Admine İletilmiştir. En Kısa Zamanda Cevap Verilecektir");
                textBox1.Clear();
                textBox2.Clear();
            }
            else
            {
                MessageBox.Show("Ürün Onayı Alanlarını Bırakamazsınız");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("insert into AdminOnay (OPara,UseriD,Onay,ParaBirimi)values('" + textBox3.Text.ToString() + "','" + id + "','" + 0 + "','" + cmb_parabirim.Text.ToString()+"')", baglan);
                komut.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("İsteğiniz Başarıyla Admine İletilmiştir. En Kısa Zamanda Cevap Verilecektir");
                textBox3.Clear();
            }
            else
            {
                MessageBox.Show("Para Onayı Alanlarını Boş Bırakamazsınız ");
            }
        }
        
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            int uid;
            uid = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            alisveris alsvrs = new alisveris(uid,id,listView1,label8);
            alsvrs.Show();
        }

    }
}
