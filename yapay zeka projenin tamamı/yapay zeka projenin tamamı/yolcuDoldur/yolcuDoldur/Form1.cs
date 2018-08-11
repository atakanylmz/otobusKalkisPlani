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

namespace yolcuDoldur
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        veriTabani vt;
        private void doldurBtn_Click(object sender, EventArgs e)
        {
            
            vt = new veriTabani();
            vt.yolcuEkle();
            doldurBtn.Visible = false;
        }

        private void bosalBtn_Click(object sender, EventArgs e)
        {
            doldurBtn.Visible = true;
            SqlConnection baglanti;
            SqlCommand komut;
            baglanti = new SqlConnection("Data Source=SERAPPC;Initial Catalog=gecenYil;Integrated Security=True");
            baglanti.Open();
            komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "DELETE FROM ocak";
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void testBtn_Click(object sender, EventArgs e)
        {
            DateTime sonTarih = new DateTime(2016, 12, 31);
            for (int i = 0; i < 5; i++)
            {

                sonTarih = sonTarih.AddDays(1);
                                MessageBox.Show(sonTarih.ToString());

            }
        }
    }
}
