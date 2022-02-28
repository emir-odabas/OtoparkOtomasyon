using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace OtoparkOtomasyon
{
    class Araclarclass
    {
        Veritabani vt = new Veritabani();

        public DataTable goster()
        {
            try
            {
                vt.BaglantiAc();
                vt.komut = new SqlCommand("SELECT * FROM arac", vt.baglan); // SQL tablosundaki tüm sütunları ve bu sütunlara ait olan tüm kayıtları sorgulamak için bu komutu kullandım 
                vt.oku = vt.komut.ExecuteReader();
                DataTable tablo = new DataTable();
                tablo.Load(vt.oku);
                vt.BaglantiKapa();
                return tablo;
            }
            catch (Exception)
            {
                MessageBox.Show("Hata oluştu arc");
                throw;
            }

        }

        public void aracekle(int id, string plaka, string renk, string model, int yil)
        {
            try
            {
                vt.BaglantiAc();
                vt.komut = new SqlCommand("INSERT INTO  arac(arac_id,arac_plaka,renk,model,yil) values(@arac_id,@arac_plaka,@renk,@model,@yil)", vt.baglan); // insert into ile tablomuza ekleme yapıyorum 
                vt.komut.Parameters.AddWithValue("@arac_id", id);
                vt.komut.Parameters.AddWithValue("@arac_plaka", plaka);      // değerlere göre atama yapıyorum
                vt.komut.Parameters.AddWithValue("@renk", renk);
                vt.komut.Parameters.AddWithValue("@model", model);
                vt.komut.Parameters.AddWithValue("@yil", yil);
                vt.komut.ExecuteNonQuery();     //  veritabanının yapısını sorgulamak için ExecuteNonQuery(); kullanıyorum
                vt.BaglantiKapa();  //bağlantıdan çıkıyorum
            }
            catch (Exception)
            {
                MessageBox.Show("Hata oluştu arc");
                throw;
            }
            finally
            {
                MessageBox.Show("İşlem başarılı bir şekilde gerçekleşti");
            }
        }
        public void aracsil(int id)
        {
            try
            {
                vt.BaglantiAc();
                vt.komut = new SqlCommand("Delete from arac where arac_id=@arac_id", vt.baglan);  // delete from ile tabloda silme işlemi yapıyorum
                vt.komut.Parameters.AddWithValue("@arac_id", id); // id ye göre silme yaptırıyorum
                vt.komut.ExecuteNonQuery();  //  veritabanının yapısını sorgulamak için ExecuteNonQuery(); kullanıyorum
                vt.BaglantiKapa();  //bağlantıdan çıkıyorum
            } 
            catch (Exception)
            {
                MessageBox.Show("Hata oluştu arc");
                throw;
            }
            finally
            {
                MessageBox.Show("İşlem başarılı bir şekilde gerçekleşti");
            }
        }
        public void aracguncelle(int id, string plaka, string renk, string model, int yil)
        {
            try
            {
                vt.BaglantiAc();
                vt.komut = new SqlCommand("UPDATE arac SET arac_id=@arac_id, arac_plaka=@arac_plaka, renk=@renk, model=@model,yil=@yil  where arac_id=@arac_id", vt.baglan);  // update ile tabloda güncelleme işlemi yaptırıyorum
                vt.komut.Parameters.AddWithValue("@arac_id", id);          // değerlere göre atama yapıyorum
                vt.komut.Parameters.AddWithValue("@arac_plaka", plaka);
                vt.komut.Parameters.AddWithValue("@renk", renk);
                vt.komut.Parameters.AddWithValue("@model", model);
                vt.komut.Parameters.AddWithValue("@yil", yil);
                vt.komut.ExecuteNonQuery(); //  veritabanının yapısını sorgulamak için ExecuteNonQuery(); kullanıyorum
                vt.BaglantiKapa();   //bağlantıdan çıkıyorum
            }
            catch (Exception)
            {
                MessageBox.Show("Hata oluştu arc");
                throw;
            }
            finally
            {
                MessageBox.Show("İşlem başarılı bir şekilde gerçekleşti");
            }
        }
    }
}
