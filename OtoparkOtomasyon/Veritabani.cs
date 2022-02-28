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
    class Veritabani
    {
        public SqlConnection baglan = new SqlConnection("Data Source=EMIR\\SQLEXPRESS;Initial Catalog=otopark;Integrated Security=True");  // Projeye Databasemizdeki verileri çektik
        public SqlCommand komut;
        public SqlDataReader oku;

        public void BaglantiAc()  // try catch ile bağlantımız kapalıysa açmasını istedik hernangi bir hata durumu için geri dönüş yaptırdık
        {
            try
            {
                if (baglan.State == ConnectionState.Closed) // bağlantı kapalıysa 
                {
                    baglan.Open();  // açmasını sağlıyorum
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bağlantı açılırken bir hata oluştu"); 
                throw;
            }
        }

        public void BaglantiKapa() // try cath ile bağlantımız açıksa kapamasını istedik hernangi bir hata durumu için geri dönüş yaptırdık
        {
            try
            {
                if(baglan.State == ConnectionState.Open) // bağlantı açıksa
                {
                    baglan.Close();  // kapamasını sağlıyorum
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bağlantıyı kaparken bir hata oluştu");
                throw;
            }
        }
    }
}
