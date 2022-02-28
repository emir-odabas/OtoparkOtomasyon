using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoparkOtomasyon
{
    public partial class Hizmet : Form
    {
        public Hizmet()
        {
            InitializeComponent();
        }

        private void Hizmet_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'otoparkDataSet.musteri' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.musteriTableAdapter.Fill(this.otoparkDataSet.musteri);
            // TODO: Bu kod satırı 'otoparkDataSet.abonelik' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.abonelikTableAdapter.Fill(this.otoparkDataSet.abonelik);
            // TODO: Bu kod satırı 'otoparkDataSet.hizmet' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.hizmetTableAdapter.Fill(this.otoparkDataSet.hizmet);
            verigoster();
            
        }
        void temizle()
        {
            textBox1.Clear();
            textBox2.Clear();       // textboxların içini temizletiyorum 
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }
        public void verigoster()
        {
            Hizmetclass hc = new Hizmetclass();      //verileri çekip göstermesi için verigöster() yapısı oluşturuyorum
            DataTable table = hc.goster();
            dataGridView1.DataSource = table;
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            Hizmetclass hc = new Hizmetclass();
            hc.hizmetekle(Convert.ToInt32(textBox1.Text), textBox2.Text, textBox3.Text, Convert.ToInt32(textBox4.Text),comboBox2.Text, textBox5.Text);   //textboxların yapısına göre ekleme yaptırıyorum
            verigoster();
            temizle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hizmetclass hc = new Hizmetclass();
            hc.hizmetguncelle(Convert.ToInt32(textBox1.Text), textBox2.Text, textBox3.Text, Convert.ToInt32(textBox4.Text), comboBox2.Text, textBox5.Text);      //textboxların yapısına göre güncelleme yaptırıyorum
            verigoster();
            temizle();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hizmetclass hc = new Hizmetclass();
            hc.hizmetsil(Convert.ToInt32(textBox1.Text));       //id ye göre silme işlemi yaptırıyorum
            verigoster();
            temizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();        //  indislere göre veritabanındaki değerlere ulaşmayı sağlıyorum
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            comboBox2.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
