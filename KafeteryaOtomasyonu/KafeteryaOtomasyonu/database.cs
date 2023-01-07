using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using System.Collections;
using System.Windows.Forms;
using System.Security.Policy;

namespace KafeteryaOtomasyonu
{
    internal class database
    {
        
        SqlConnection connection = new SqlConnection(@"Data Source=server;Initial Catalog= Otomasyon;Integrated Security=True");
        SqlDataReader reader;
        SqlCommand command;
        
        public List<SiparisDetayi> siparisler()
        {
            var siparisList = new List<SiparisDetayi>();
            connection.Open();
            command = new SqlCommand("SELECT * FROM Siparisler",connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                siparisList.Add(new SiparisDetayi{ siparisZamani = reader.GetValue(1).ToString(), siparisUcret = reader.GetValue(2).ToString(),siparisPersoneli = reader.GetValue(3).ToString(), sipariKodu = reader.GetValue(5).ToString(), siparisMasa = reader.GetValue(6).ToString()});
            }
            connection.Close();
            return siparisList;

        }
        public List<MasaVeri> getMasalar()
        {
            var masalarList = new List<MasaVeri>();
            connection.Open();
            command = new SqlCommand($"SELECT * FROM Masalar", connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                masalarList.Add(new MasaVeri{ MasaIsmi= reader.GetValue(1).ToString(), MasaAciklama = reader.GetValue(2).ToString(), Durum = reader.GetValue(3).ToString()});
            }
            connection.Close();
            return masalarList;
        }
        public void SatisiBitir(string siparisKodu, string masaIsmi, string toplamFiyat)
        {
            connection.Open();
            command = new SqlCommand("INSERT INTO GerceklesmisSiparis(siparisKodu, MasaIsmi,ToplamFiyat) values(@siparisKodu, @MasaIsmi, @ToplamFiyat)",connection);
            command.Parameters.AddWithValue("@siparisKodu",siparisKodu);
            command.Parameters.AddWithValue("@MasaIsmi",masaIsmi);
            command.Parameters.AddWithValue("@ToplamFiyat",toplamFiyat);
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            command = new SqlCommand("UPDATE Masalar SET MasaDurum = '1' WHERE MasaNO = @MasaNO",connection);
            command.Parameters.AddWithValue("@MasaNO",masaIsmi);
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            command = new SqlCommand($"DELETE FROM SiparisUrun WHERE UrunID = '{siparisKodu}'",connection);
            command.ExecuteNonQuery();
            command = new SqlCommand($"DELETE FROM Siparisler WHERE SiparisKodu = '{siparisKodu}'",connection);
            command.ExecuteNonQuery();
            MessageBox.Show("ODEME BASARI ILE GERCEKLESTI!");
            connection.Close();
        }
        public List<UrunDegeri> GetUruns(string kategori)
        {
                var list = new List<UrunDegeri>(); 
                connection.Open();
                command = new SqlCommand($"SELECT * FROM Urunler WHERE Kategori='{kategori}'", connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new UrunDegeri { UrunIsmi = reader.GetValue(1).ToString(), Fiyat = reader.GetValue(2).ToString(), Adet = reader.GetValue(3).ToString(), SatilanAdet = reader.GetValue(5).ToString(), Kategori = reader.GetValue(6).ToString() });
                }
            connection.Close();
                return list;
        }
        
        public void InsertSiparisDetayı(string time, int urunKodu, int ucret, string siparisMasa, string siparisPersonel, List<SiparisOlustur.Urunler> urunlers)
        {
            connection.Open();
            command = new SqlCommand($"INSERT INTO Siparisler(SiparisZamani,SiparisUcret,SiparisPersoneli,SiparisKodu,SiparisMasa) values(@Sipariszamani, @SiparisUcreti, @SiparisPersoneli, @SiparisKodu, @SiparisMasa)",connection);
            command.Parameters.AddWithValue("@SiparisZamani",time);
            command.Parameters.AddWithValue("@SiparisUcreti",ucret);
            command.Parameters.AddWithValue("@SiparisPersoneli", siparisPersonel);
            command.Parameters.AddWithValue("SiparisKodu", urunKodu);
            command.Parameters.AddWithValue("@SiparisMasa",siparisMasa);
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            command = new SqlCommand("INSERT INTO SiparisUrun(UrunID,UrunIsmi, UrunAdet, UrunFiyat) values(@UrunID,@UrunIsmi, @UrunAdet, @UrunFiyat)",connection);
            for (int i = 0; i < urunlers.Count; i++)
            {
                command.Parameters.AddWithValue("@UrunID", urunlers[i].urunKodu);
                command.Parameters.AddWithValue("@UrunIsmi", urunlers[i].urunIsmi);
                command.Parameters.AddWithValue("@UrunAdet", urunlers[i].urunAdet);
                command.Parameters.AddWithValue("@UrunFiyat", urunlers[i].urunFiyat);
                command.ExecuteNonQuery();
                command.Parameters.Clear();
            }
            command.Parameters.Clear();
            command = new SqlCommand("UPDATE Masalar SET MasaDurum = '2' WHERE MasaNO = @MasaNO",connection);
            command.Parameters.AddWithValue("@MasaNO",siparisMasa);
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            command = new SqlCommand("UPDATE Personeller SET CalismaSayisi = CalismaSayisi + 1 WHERE PersonelIsmi = @PersonelIsmi",connection);
            command.Parameters.AddWithValue("@PersonelIsmi",siparisPersonel);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public List<OdemeUrun> siparisUrunleri(string urunid)
        {
            var list = new List<OdemeUrun>();
            connection.Open();
            command = new SqlCommand($"SELECT * From SiparisUrun WHERE UrunID = '{urunid}'", connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new OdemeUrun { UrunID = reader.GetValue(0).ToString(), UrunName = reader.GetValue(1).ToString(), UrunAdet = reader.GetValue(2).ToString(),UrunFiyat = reader.GetValue(3).ToString() });
            }
            connection.Close();
            return list;
        }

        public List<OdemeMasa> siparisMasaDetay(string masaismi)
        {
            var list = new List<OdemeMasa>();
            connection.Open();
            command = new SqlCommand($"SELECT * From Siparisler WHERE SiparisMasa = '{masaismi}'", connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new OdemeMasa { SiparisID = reader.GetValue(5).ToString(), SiparisUcret = reader.GetValue(2).ToString()});
            }
            connection.Close();
            return list;
        } 
        public class OdemeUrun
        {
            public string UrunID { get; set; }
            public string UrunName { get; set; }
            public string UrunAdet { get; set; }
            public string UrunFiyat { get; set; }
        }
        public class OdemeMasa
        {
            public string SiparisID { get; set; }
            public string SiparisUcret { get; set; }
        }
        public class SiparisDetayi
        {
            public string sipariKodu { get; set; }
            public string siparisZamani { get; set; }
            public string siparisUcret { get; set; }
            public string siparisPersoneli { get; set; }
            public string siparisMasa { get; set; }

        }
        public List<Personel> GetPersonels()
        {
            var personellist = new List<Personel>();
            connection.Open();
            command = new SqlCommand("SELECT * From Personeller",connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                personellist.Add(new Personel { PersonelIsmi = reader.GetValue(1).ToString(), Soyadi = reader.GetValue(2).ToString() , CalismaSayisi = reader.GetValue(3).ToString(), Aktif = reader.GetValue(4).ToString()});
            }
            connection.Close();
            return personellist;
        }
        public class UrunDegeri
        {
            public string UrunIsmi { get; set; }
            public string Fiyat { get; set; }
            public string Adet { get; set; }
            public string SatilanAdet { get; set; }
            public string Kategori { get; set; }

        }
        public class MasaVeri
        {
            public string MasaIsmi { get; set; }
            public string MasaAciklama { get; set; }
            public string Durum { get; set; }
            public string SiparisKodu { get; set; }
        }

        public class Personel
        {
            public string PersonelIsmi { get; set; }
            public string Soyadi { get; set; }
            public string CalismaSayisi { get; set; }
            public string Aktif { get; set; }
        }
       
    }
}
