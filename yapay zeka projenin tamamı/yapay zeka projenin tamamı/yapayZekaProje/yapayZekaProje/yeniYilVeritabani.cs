using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace yapayZekaProje
{
    public class yeniYilVeritabani
    {
        SqlConnection eskiYilBaglanti, yeniYilBaglanti;
        SqlCommand eskiYilKomut, yeniYilKomut;
        private void eskiYilBaglan()
        {
            eskiYilBaglanti = new SqlConnection("Data Source=SERAPPC;Initial Catalog=gecenYil;Integrated Security=True");
            eskiYilBaglanti.Open();
            eskiYilKomut = new SqlCommand();
            eskiYilKomut.Connection = eskiYilBaglanti;
        }
        private void yeniYilBaglan()
        {
            yeniYilBaglanti = new SqlConnection("Data Source=SERAPPC;Initial Catalog=yeniYil;Integrated Security=True");
            yeniYilBaglanti.Open();
            yeniYilKomut = new SqlCommand();
            yeniYilKomut.Connection = yeniYilBaglanti;
        }
         private void yeniYilTemizle()
        {
            yeniYilBaglan();
            yeniYilKomut.CommandText = "delete from ocak";
            yeniYilKomut.ExecuteNonQuery();
            yeniYilBaglanti.Close();
        }
        public void yeniYilDoldur(string saatDakika,string tarih)
        {
            yeniYilTemizle();
            DateTime saatdk = Convert.ToDateTime(saatDakika);
            DateTime mevcutGun = Convert.ToDateTime(tarih);
            doldur(mevcutGun, saatdk);
            DateTime sonTarih = new DateTime(2017, 02, 01);

            while (mevcutGun !=sonTarih)
            {
                hesapla(mevcutGun, saatdk);
                mevcutGun = mevcutGun.AddDays(1);

            }

        }
        private void hesapla(DateTime tarih, DateTime stDk)
        {
            double mevcutOrt = ortalamaOnDkAralikliYolcuSayisiBul(tarih, stDk);
            DateTime birGunOnce = tarih.AddDays(-1);
            double birGunOnceOrt = ortalamaOnDkAralikliYolcuSayisiBul(birGunOnce, stDk);
            DateTime birGunSonra = tarih.AddDays(1);
            double birGunSonraOrt = ortalamaOnDkAralikliYolcuSayisiBul(birGunSonra, stDk);
            double genelOrt = (mevcutOrt * 2 + birGunOnceOrt + birGunSonraOrt) / 4;
           
                if (genelOrt <= 9)
                {
                doldur(tarih, (stDk.AddMinutes(30)));
                if (stDk < Convert.ToDateTime("20:20"))
                hesapla(tarih, (stDk.AddMinutes(30)));
                }
                else if (genelOrt <= 19)
                {
                doldur(tarih, (stDk.AddMinutes(20)));
                if (stDk < Convert.ToDateTime("20:20"))
                    hesapla(tarih,(stDk.AddMinutes(20)));
                }
                else
                {
                doldur(tarih, (stDk.AddMinutes(10)));
                if (stDk < Convert.ToDateTime("20:30"))
                    hesapla(tarih,(stDk.AddMinutes(10)));
                }
        }
        private void doldur(DateTime tarih,DateTime saatdk)
        {
            tarih = tarih.AddYears(1);
            string tarihS = tarih.ToString("yyyy-MM-dd");
            string saatS = saatdk.ToString("HH:mm");
            yeniYilBaglan();
            yeniYilKomut.CommandText = "INSERT INTO ocak(tarih,kalkisSaati) VALUES(@trh, @klksSt)";
            yeniYilKomut.Parameters.AddWithValue("@trh", tarihS);
            yeniYilKomut.Parameters.AddWithValue("@klksSt", saatS);
            yeniYilKomut.ExecuteNonQuery();
            yeniYilBaglanti.Close();
        }
        private double ortalamaOnDkAralikliYolcuSayisiBul(DateTime tarih,DateTime stDk)
        {
            string stDkS = stDk.ToString("HH:mm");
            string stDkS10 = (stDk.AddMinutes(10)).ToString("HH:mm");
            string stDkS20 = (stDk.AddMinutes(20)).ToString("HH:mm");

            string tarihS = tarih.ToString("yyyy-MM-dd");
            eskiYilBaglan();

            eskiYilKomut.CommandText = "select yolcuSayisi from ocak where tarih=@trh and saat=@st1 ";
            eskiYilKomut.Parameters.AddWithValue("@trh", tarihS);
            eskiYilKomut.Parameters.AddWithValue("@st1", stDkS);
            SqlDataReader dr1 = eskiYilKomut.ExecuteReader();
            dr1.Read();
            double y1= Convert.ToDouble(dr1["yolcuSayisi"]);
            dr1.Close();

            eskiYilKomut.CommandText = "select yolcuSayisi from ocak where tarih=@trh and saat=@st2 ";
            eskiYilKomut.Parameters.AddWithValue("@st2", stDkS10);
            SqlDataReader dr2 = eskiYilKomut.ExecuteReader();
            dr2.Read();
            double y2 = Convert.ToDouble(dr2["yolcuSayisi"]);
            dr2.Close();

            eskiYilKomut.CommandText = "select yolcuSayisi from ocak where tarih=@trh and saat=@st3 ";
            eskiYilKomut.Parameters.AddWithValue("@st3", stDkS20);
            SqlDataReader dr3 = eskiYilKomut.ExecuteReader();
            dr3.Read();
            double y3 = Convert.ToDouble(dr3["yolcuSayisi"]);
            dr3.Close();

            /* SqlDataReader dr = eskiYilKomut.ExecuteReader();
             dr.Read();
             double ort=  Convert.ToDouble(dr["ort"]);*/
            double ort = (y1 + y2 + y3) / 3;
            eskiYilBaglanti.Close();
            return ort;
        }

    }
}
