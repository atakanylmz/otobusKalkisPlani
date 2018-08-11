using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace yolcuDoldur
{
    public class veriTabani
    {
        SqlConnection baglanti;
        SqlCommand komut;
        private void baglan()
        {
            baglanti = new SqlConnection("Data Source=SERAPPC;Initial Catalog=gecenYil;Integrated Security=True");
            baglanti.Open();
            komut = new SqlCommand();
            komut.Connection = baglanti;
        }
        public void yolcuEkle()
        {
            string tarihS;
            Random rastgele = new Random();
            DateTime tarih = new DateTime(2016,12,31);
            DateTime sonTarih = new DateTime(2017, 02, 02);
            int maxSaat=21, maxDakika=50, minSaat=6,yolcuSayisi;
            
            while ((DateTime.Compare(tarih,sonTarih))!=0)
            {
                tarihS = tarih.ToString("yyyy-MM-dd");

                for (int saat = minSaat; saat <= maxSaat; saat++)
                {
                    for (int dakika = 0; dakika <= maxDakika; dakika += 10)
                    {
                        if (saat >= 7 && saat <= 9)
                            yolcuSayisi = rastgele.Next(15, 25);
                        else if (saat >= 16 && saat <= 18)
                            yolcuSayisi = rastgele.Next(10, 20);
                        else if (saat > 18)
                            yolcuSayisi = rastgele.Next(1, 10);
                        else
                            yolcuSayisi = rastgele.Next(5, 15);
                        baglan();
                        DateTime saatdk = Convert.ToDateTime(saat.ToString()+":"+ dakika.ToString());
                        komut.CommandText = "INSERT INTO ocak(tarih,saat,yolcuSayisi) VALUES(@trh,@st,@ylcSys)";
                        komut.Parameters.AddWithValue("@trh", tarihS);
                        komut.Parameters.AddWithValue("@st", saatdk);
                        komut.Parameters.AddWithValue("@ylcSys", yolcuSayisi);
                        komut.ExecuteNonQuery();
                        baglanti.Close();
                    }
                }
                tarih = tarih.AddDays(1);

            }

        }

    }
    
}
