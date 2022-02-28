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
    class Abonelikclass
    {
        Veritabani vt = new Veritabani();

        public DataTable goster()
        {
            try
            {
                vt.BaglantiAc();
                vt.komut = new SqlCommand("SELECT * FROM abonelik", vt.baglan);   // SQL tablosundaki tüm sütunları ve bu sütunlara ait olan tüm kayıtları sorgulamak için bu komutu kullandım 
                vt.oku = vt.komut.ExecuteReader();
                DataTable tablo = new DataTable();
                tablo.Load(vt.oku);
                vt.BaglantiKapa();
                return tablo;
            }
            catch (Exception)
            {
                MessageBox.Show("Hata oluştu abn");
                throw;
            }

        }

        public void aboneekle(int id, string tip, string sure, string bastarih, string bittarih, int ucret)
        {
            try
            {
                vt.BaglantiAc();
                vt.komut = new SqlCommand("INSERT INTO  abonelik(abonelik_id,abonelik_tipi,abonelik_sure,abonelik_bas_tarihi,abonelik_bit_tarihi,ucret) values(@abonelik_id,@abonelik_tipi,@abonelik_sure,@abonelik_bas_tarihi,@abonelik_bit_tarihi,@ucret)", vt.baglan); // insert into ile tablomuza ekleme yapıyorum
                vt.komut.Parameters.AddWithValue("@abonelik_id", id);
                vt.komut.Parameters.AddWithValue("@abonelik_tipi", tip);      // değerlere göre atama yapıyorum
                vt.komut.Parameters.AddWithValue("@abonelik_sure", sure);
                vt.komut.Parameters.AddWithValue("@abonelik_bas_tarihi", bastarih);
                vt.komut.Parameters.AddWithValue("@abonelik_bit_tarihi", bittarih);
                vt.komut.Parameters.AddWithValue("@ucret", ucret);
                vt.komut.ExecuteNonQuery(); //  veritabanının yapısını sorgulamak için ExecuteNonQuery(); kullanıyorum
                vt.BaglantiKapa(); //bağlantıdan çıkıyorum
            } 
            catch (Exception)
            {
                MessageBox.Show("Hata oluştu abn");
                throw;
            }
            finally
            {
                MessageBox.Show("İşlem başarılı bir şekilde gerçekleşti");
            }
        }
        public void abonesil(int id)
        {
            try
            {
                vt.BaglantiAc();
                vt.komut = new SqlCommand("Delete from abonelik where abonelik_id=@abonelik_id", vt.baglan); // delete from ile tabloda silme işlemi yapıyorum
                vt.komut.Parameters.AddWithValue("@abonelik_id", id);      // id ye göre silme yaptırıyorum
                vt.komut.ExecuteNonQuery();  //  veritabanının yapısını sorgulamak için ExecuteNonQuery(); kullanıyorum
                vt.BaglantiKapa();   //bağlantıdan çıkıyorum
            }
            catch (Exception)
            {
                MessageBox.Show("Hata oluştu abn");
                throw;
            }
            finally
            {
                MessageBox.Show("İşlem başarılı bir şekilde gerçekleşti");
            }
        }
        public void aboneguncelle(int id, string tip, string sure, string bastarih, string bittarih, int ucret)
        {
            try
            {
                vt.BaglantiAc();
                vt.komut = new SqlCommand("UPDATE abonelik SET abonelik_id=@abonelik_id, abonelik_tipi=@abonelik_tipi, abonelik_sure=@abonelik_sure, abonelik_bas_tarihi=@abonelik_bas_tarihi,abonelik_bit_tarihi=@abonelik_bit_tarihi,ucret=@ucret  where abonelik_id=@abonelik_id", vt.baglan); // update ile tabloda güncelleme işlemi yaptırıyorum
                vt.komut.Parameters.AddWithValue("@abonelik_id", id);
                vt.komut.Parameters.AddWithValue("@abonelik_tipi", tip);     // değerlere göre atama yapıyorum
                vt.komut.Parameters.AddWithValue("@abonelik_sure", sure);
                vt.komut.Parameters.AddWithValue("@abonelik_bas_tarihi", bastarih);
                vt.komut.Parameters.AddWithValue("@abonelik_bit_tarihi", bittarih);
                vt.komut.Parameters.AddWithValue("@ucret", ucret);
                vt.komut.ExecuteNonQuery(); //  veritabanının yapısını sorgulamak için ExecuteNonQuery(); kullanıyorum
                vt.BaglantiKapa();  //bağlantıdan çıkıyorum
            }
            catch (Exception)
            {
                MessageBox.Show("Hata oluştu abn");
                throw;
            }
            finally
            {
                MessageBox.Show("İşlem başarılı bir şekilde gerçekleşti");
            }
        }

    }
}
