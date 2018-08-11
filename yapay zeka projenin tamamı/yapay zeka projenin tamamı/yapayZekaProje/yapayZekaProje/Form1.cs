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

namespace yapayZekaProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        yeniYilVeritabani veriIslem;
        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime dt = new DateTime(2018, 01, 01);
            for (int i = 0; i < 31; i++)
            {
                tarihCmb.Items.Add(dt);
                dt=dt.AddDays(1);
            }
            dataGridView1.Columns["tarih"].HeaderText = "TARİH";
            dataGridView1.Columns["kalkisSaati"].HeaderText = "KALKIŞ SAATİ";
            dol();
        }
        SqlDataAdapter da;
        DataTable dt;
        private void dol()
        {
            veriIslem = new yeniYilVeritabani();
            veriIslem.yeniYilDoldur("06:00", "2017-01-01");
        }
        private void gosterBtn_Click(object sender, EventArgs e)
        {
            if(tarihCmb.SelectedItem==null|| tarihCmb.SelectedItem.ToString() == "")
            {
                MessageBox.Show("tarih seçiniz!");
            }
            else
            {
                DateTime tarih = (DateTime)tarihCmb.SelectedItem;
                string tarihS = tarih.ToString("yyyy-MM-dd");
                SqlConnection baglanti = new SqlConnection("Data Source=SERAPPC; Initial Catalog=yeniYil; Integrated Security=true");
                baglanti.Open();
                SqlCommand komut = new SqlCommand();
                string vakit1, vakit2;
                DateTime vakit;
                if (sabahRBtn.Checked)
                {
                    vakit = Convert.ToDateTime("05:59");
                    vakit1 = vakit.ToString("HH:mm");
                    vakit = Convert.ToDateTime("11:01");
                    vakit2 = vakit.ToString("HH:mm");
                }
                else if (ogleRBtn.Checked)
                {
                    vakit = Convert.ToDateTime("11:09");
                    vakit1 = vakit.ToString("HH:mm");
                    vakit = Convert.ToDateTime("16:01");
                    vakit2 = vakit.ToString("HH:mm");
                }
                else if (aksamRBtn.Checked)
                {
                    vakit = Convert.ToDateTime("16:09");
                    vakit1 = vakit.ToString("HH:mm");
                    vakit = Convert.ToDateTime("21:01");
                    vakit2 = vakit.ToString("HH:mm");
                }
                else
                {
                    vakit = Convert.ToDateTime("05:50");
                    vakit1 = vakit.ToString("HH:mm");
                    vakit = Convert.ToDateTime("21:10");
                    vakit2 = vakit.ToString("HH:mm");
                }

                komut.CommandText = "select * from ocak where tarih=@trh and kalkisSaati between @v1 and @v2";
                komut.Connection = baglanti;
                komut.Parameters.AddWithValue("@trh", tarihS);
                komut.Parameters.AddWithValue("@v1", vakit1);
                komut.Parameters.AddWithValue("@v2", vakit2);
                da = new SqlDataAdapter(komut);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                baglanti.Close();
            }
            
        }
    }
}
