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
    class Hizmetclass
    {
        Veritabani vt = new Veritabani();

        public DataTable goster()
        {
            try
            {
                vt.BaglantiAc();
                vt.komut = new SqlCommand("SELECT * FROM hizmet", vt.baglan); // SQL tablosundaki tüm sütunları ve bu sütunlara ait olan tüm kayıtları sorgulamak için bu komutu kullandım 
                vt.oku = vt.komut.ExecuteReader();
                DataTable tablo = new DataTable();
                tablo.Load(vt.oku);
                vt.BaglantiKapa();
                return tablo;
            }
            catch (Exception)
            {
                MessageBox.Show("Hata oluştu hzmt");
                throw;
            }

        }

        public void hizmetekle(int id, string girissaat, string cikissaat, int ucret, string abonelik, string plaka)
        {
            try
            {
                vt.BaglantiAc();
                vt.komut = new SqlCommand("INSERT INTO  hizmet(hizmet_id,arac_giris_saat,arac_cikis_saat,ucret,abonelik,plaka) values(@hizmet_id,@arac_giris_saat,@arac_cikis_saat,@ucret,@abonelik,@plaka)", vt.baglan); // insert into ile tablomuza ekleme yapıyorum
                vt.komut.Parameters.AddWithValue("@hizmet_id", id);               // değerlere göre atama yapıyorum
                vt.komut.Parameters.AddWithValue("@arac_giris_saat", girissaat);
                vt.komut.Parameters.AddWithValue("@arac_cikis_saat", cikissaat);
                vt.komut.Parameters.AddWithValue("@ucret", ucret);
                vt.komut.Parameters.AddWithValue("@abonelik", abonelik);
                vt.komut.Parameters.AddWithValue("@plaka", plaka);
                vt.komut.ExecuteNonQuery();  //  veritabanının yapısını sorgulamak için ExecuteNonQuery(); kullanıyorum
                vt.BaglantiKapa();  //bağlantıdan çıkıyorum
            }
            catch (Exception)
            {
                MessageBox.Show("Hata oluştu hzmt");
                throw;
            }
            finally
            {
                MessageBox.Show("İşlem başarılı bir şekilde gerçekleşti");
            }
        }
        public void hizmetsil(int id)
        {
            try
            {
                vt.BaglantiAc();
                vt.komut = new SqlCommand("Delete from hizmet where hizmet_id=@hizmet_id", vt.baglan); // delete from ile tabloda silme işlemi yapıyorum
                vt.komut.Parameters.AddWithValue("@hizmet_id", id);  // id ye göre silme yaptırıyorum
                vt.komut.ExecuteNonQuery();  //  veritabanının yapısını sorgulamak için ExecuteNonQuery(); kullanıyorum
                vt.BaglantiKapa();  //bağlantıdan çıkıyorum
            }
            catch (Exception)
            {
                MessageBox.Show("Hata oluştu hzmt");
                throw;
            }
            finally
            {
                MessageBox.Show("İşlem başarılı bir şekilde gerçekleşti");
            }
        }
        public void hizmetguncelle(int id, string girissaat, string cikissaat, int ucret, string abonelik, string plaka)
        {
            try
            {
                vt.BaglantiAc();
                vt.komut = new SqlCommand("UPDATE hizmet SET hizmet_id=@hizmet_id, arac_giris_saat=@arac_giris_saat, arac_cikis_saat=@arac_cikis_saat, ucret=@ucret,abonelik=@abonelik,plaka=@plaka  where hizmet_id=@hizmet_id", vt.baglan); // update ile tabloda güncelleme işlemi yaptırıyorum
                vt.komut.Parameters.AddWithValue("@hizmet_id", id);             // değerlere göre atama yapıyorum
                vt.komut.Parameters.AddWithValue("@arac_giris_saat", girissaat);
                vt.komut.Parameters.AddWithValue("@arac_cikis_saat", cikissaat);
                vt.komut.Parameters.AddWithValue("@ucret", ucret);
                vt.komut.Parameters.AddWithValue("@abonelik", abonelik);
                vt.komut.Parameters.AddWithValue("@plaka", plaka);
                vt.komut.ExecuteNonQuery();   //  veritabanının yapısını sorgulamak için ExecuteNonQuery(); kullanıyorum
                vt.BaglantiKapa();  //bağlantıdan çıkıyorum
            }
            catch (Exception)
            {
                MessageBox.Show("Hata oluştu hzmt");
                throw;
            }
            finally
            {
                MessageBox.Show("İşlem başarılı bir şekilde gerçekleşti");
            }
        }

    }
}
