using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OtoparkOtomasyon
{
    class Müstericlass
    {
        Veritabani vt = new Veritabani();

        public DataTable goster()
        {
            try
            {
                vt.BaglantiAc();
                vt.komut = new SqlCommand("SELECT * FROM musteri", vt.baglan);  // SQL tablosundaki tüm sütunları ve bu sütunlara ait olan tüm kayıtları sorgulamak için bu komutu kullandım
                vt.oku = vt.komut.ExecuteReader(); 
               DataTable tablo = new DataTable(); 
                tablo.Load(vt.oku);
                vt.BaglantiKapa();
                return tablo;
            }
            catch (Exception)
            {
                MessageBox.Show(" hata oluştu mst");
                throw;
            }
        }

        public void musteriekle(int id , string adsoyad,string adres,string tel)
        {
            try
            {
                vt.BaglantiAc(); // bağlantıyı açıyorum
                vt.komut = new SqlCommand("insert into musteri(musteri_id,musteri_ad_soyad,adres,tel_no) values(@musteri_id,@musteri_ad_soyad,@adres,@tel_no)",vt.baglan); // insert into ile tablomuza ekleme yapıyorum
                vt.komut.Parameters.AddWithValue("@musteri_id",id);        // değerlere göre atama yapıyorum
                vt.komut.Parameters.AddWithValue("@musteri_ad_soyad", adsoyad);
                vt.komut.Parameters.AddWithValue("@adres", adres);
                vt.komut.Parameters.AddWithValue("@tel_no", tel);
                vt.komut.ExecuteNonQuery(); //  veritabanının yapısını sorgulamak için ExecuteNonQuery(); kullanıyorum
                vt.BaglantiKapa(); //bağlantıdan çıkıyorum
            }
            catch (Exception)
            {
                MessageBox.Show(" hata oluştu mst");
                throw;
            }
            finally
            {
                MessageBox.Show(" İşlem başarılı bir şekilde gerçekleşti ");
            }
        }
        public void musterisil(int id)
        {
            try
            {
                vt.BaglantiAc(); // bağlantıyı açıyorum
                vt.komut = new SqlCommand("Delete from  musteri where musteri_id=@musteri_id",vt.baglan); // delete from ile tabloda silme işlemi yapıyorum
                vt.komut.Parameters.AddWithValue("@musteri_id", id);   // id ye göre silme yaptırıyorum
                vt.komut.ExecuteNonQuery();  //  veritabanının yapısını sorgulamak için ExecuteNonQuery(); kullanıyorum
                vt.BaglantiKapa();  //bağlantıdan çıkıyorum

            }
            catch (Exception)
            {
                MessageBox.Show(" hata oluştu mst");
                throw;
            }
            finally
            {
                MessageBox.Show(" İşlem başarılı bir şekilde gerçekleşti ");
            }
        }

        public void musteriguncelle(int id, string adsoyad, string adres, string tel)
        {
            try
            {
                vt.BaglantiAc();
                vt.komut = new SqlCommand("UPDATE  musteri SET musteri_id=@musteri_id, musteri_ad_soyad=@musteri_ad_soyad, adres=@musteri_adres,tel_no=@musteri_tel where musteri_id=@musteri_id", vt.baglan); // update ile tabloda güncelleme işlemi yaptırıyorum
                vt.komut.Parameters.AddWithValue("@musteri_id", id);         // // değerlere göre atama yapıyorum
                vt.komut.Parameters.AddWithValue("@musteri_ad_soyad", adsoyad);
                vt.komut.Parameters.AddWithValue("@musteri_adres", adres);
                vt.komut.Parameters.AddWithValue("@musteri_tel", tel);
                vt.komut.ExecuteNonQuery(); //  veritabanının yapısını sorgulamak için ExecuteNonQuery(); kullanıyorum
                vt.BaglantiKapa(); //bağlantıdan çıkıyorum
            }
            catch (Exception)
            {
                MessageBox.Show(" hata oluştu mst");
                throw;
            }
            finally
            {
                MessageBox.Show(" İşlem başarılı bir şekilde gerçekleşti ");
            }
        }
    }
}
