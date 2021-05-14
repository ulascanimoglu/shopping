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
using System.Data.OleDb;

namespace odev
{
    public partial class admin : Form
    {
        int id;
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-ORFTL34;Initial Catalog=Sqlyazilimyapimi;Integrated Security=True");
       
        public admin()
        {
            InitializeComponent();
            goster_urun();
            goster_para();
        }
        private void goster_urun()
        {
          
            baglan.Open();
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "Select * From Onaylama";
            komut.Connection = baglan;

            SqlDataAdapter adap = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();

            adap.Fill(tablo);

            for (int i = 0; i < tablo.Rows.Count; i++)
            {
                listView1.Items.Add(tablo.Rows[i]["id"].ToString());
                listView1.Items[i].SubItems.Add(tablo.Rows[i]["KAd"].ToString()+" "+ tablo.Rows[i]["KSoyad"].ToString());
                listView1.Items[i].SubItems.Add(tablo.Rows[i]["Adi"].ToString());
                listView1.Items[i].SubItems.Add(tablo.Rows[i]["Fiyat"].ToString());
                listView1.Items[i].SubItems.Add(tablo.Rows[i]["UMiktar"].ToString());
            }
            baglan.Close();
        }

        private void goster_para()
        {
            
            baglan.Open();
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "Select * From OnayPara";
            komut.Connection = baglan;

            SqlDataAdapter adap = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();

            adap.Fill(tablo);

            for (int i = 0; i < tablo.Rows.Count; i++)
            {

                listView2.Items.Add(tablo.Rows[i]["id"].ToString());
                listView2.Items[i].SubItems.Add(tablo.Rows[i]["KAd"].ToString());
                listView2.Items[i].SubItems.Add(tablo.Rows[i]["KPara"].ToString());
            }
            baglan.Close();
        }
      
        private void listView1_DoubleClick_1(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            DialogResult dialogResult = MessageBox.Show("Kabul Ediyor Musunuz?", "Onay", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                SqlCommand com = new SqlCommand("exec adminOnayUrun '" + id + "'", baglan);
                baglan.Open();
                com.ExecuteNonQuery();
                baglan.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                SqlCommand cmd = new SqlCommand("exec urunOnaylamamak '"+id+"'", baglan);
                baglan.Open();
                cmd.ExecuteNonQuery();
                baglan.Close();
            }
            
        }

        private void listView2_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView2.SelectedItems[0].SubItems[0].Text);
            DialogResult dialogResult = MessageBox.Show("Kabul Ediyor Musunuz?", "Onay", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                SqlCommand com = new SqlCommand("exec adminOnayPara '" + id + "'", baglan);
                baglan.Open();
                com.ExecuteNonQuery();
                baglan.Close();

            }
            else if (dialogResult == DialogResult.No)
            {
                SqlCommand cmd = new SqlCommand("exec paraOnaylamamak '" + id + "'", baglan);
                baglan.Open();
                cmd.ExecuteNonQuery();
                baglan.Close();
            }
        }

       
    }
}
