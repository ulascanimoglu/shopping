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
using System.Timers;
using ClosedXML.Excel;

namespace odev
{
    public partial class Kullanici : Form
    {
        int id;
        int para;
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-ORFTL34;Initial Catalog=Sqlyazilimyapimi;Integrated Security=True");

        public Kullanici(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void Kullanici_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'appData.TarihView' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tarihViewTableAdapter.Fill(this.appData.TarihView);
            // TODO: Bu kod satırı 'appData.Tarih' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.

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
            komut = new SqlCommand("Select Para From bilgiler Where UseriD='" + id + "'", baglan);
            SqlDataReader rd;
            rd = komut.ExecuteReader();
            while (rd.Read())
            {
                label8.Text = rd["Para"].ToString() + " TL";
                para = Convert.ToInt32(rd["Para"]);
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
                MessageBox.Show("Ürün Onayı Alanlarını Boş Bırakamazsınız");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("insert into AdminOnay (OPara,UseriD,Onay,ParaBirimi)values('" + textBox3.Text.ToString() + "','" + id + "','" + 0 + "','" + cmb_parabirim.Text.ToString() + "')", baglan);
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
            alisveris alsvrs = new alisveris(uid, id, listView1, label8);
            alsvrs.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            talep tlp = new talep(id, para, listView1, label8);
            tlp.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Creating DataTable.
            DataTable dt = new DataTable();

            //Adding the Columns.
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                dt.Columns.Add(column.HeaderText, column.ValueType);
            }

            //Adding the Rows.
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                dt.Rows.Add();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dt.Rows[dt.Rows.Count - 1][cell.ColumnIndex] = cell.Value.ToString();
                }
            }

            //Exporting to Excel.
            string folderPath = "C:\\Excel\\";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(dt, "Customers");

                //Set the color of Header Row.
                //A resembles First Column while C resembles Third column.
                wb.Worksheet(1).Cells("A1:C1").Style.Fill.BackgroundColor = XLColor.DarkGreen;
                for (int i = 1; i <= dt.Rows.Count; i++)
                {
                    //A resembles First Column while C resembles Third column.
                    //Header row is at Position 1 and hence First row starts from Index 2.
                    string cellRange = string.Format("A{0}:C{0}", i + 1);
                    if (i % 2 != 0)
                    {
                        wb.Worksheet(1).Cells(cellRange).Style.Fill.BackgroundColor = XLColor.GreenYellow;
                    }
                    else
                    {
                        wb.Worksheet(1).Cells(cellRange).Style.Fill.BackgroundColor = XLColor.Yellow;
                    }

                }
                //Adjust widths of Columns.
                wb.Worksheet(1).Columns().AdjustToContents();

                //Save the Excel file.
                wb.SaveAs(folderPath + "DataGridViewExport.xlsx");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("exec Tarihproc @p1,@p2", baglan);
            adapter.SelectCommand.Parameters.Add("@p1", SqlDbType.Date).Value = dateTimePicker1.Value.Date;
            adapter.SelectCommand.Parameters.Add("@p2", SqlDbType.Date).Value = dateTimePicker2.Value.Date;
            DataSet data = new DataSet();
            baglan.Open();
            adapter.Fill(data, "bilgiler");
            dataGridView1.DataSource = data.Tables["bilgiler"];
            baglan.Close();
        }
    }
}
