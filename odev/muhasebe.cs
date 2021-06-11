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
    public partial class muhasebe : Form
    {
        int id;
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-ORFTL34;Initial Catalog=Sqlyazilimyapimi;Integrated Security=True");
        public muhasebe(int id)
        {
            InitializeComponent();
            this.id = id;

            SqlCommand komut = new SqlCommand();
            baglan.Open();

            komut = new SqlCommand("Select Para From bilgiler Where UseriD='" + id + "'", baglan);
            SqlDataReader rd;
            rd = komut.ExecuteReader();
            while (rd.Read())
            {
                lblkazancpara.Text = rd["Para"].ToString() + " TL";
            }
            baglan.Close();
        }

        
    }
}
