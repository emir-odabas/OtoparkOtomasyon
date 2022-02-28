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
    public partial class Abonelik : Form
    {
        public Abonelik()
        {
            InitializeComponent();
        }

        private void Abonelik_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'otoparkDataSet.abonelik' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.abonelikTableAdapter.Fill(this.otoparkDataSet.abonelik);
            verigoster();

        }
        void temizle()
        {
            textBox1.Clear();      // textboxların içini temizletiyorum 
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }
        public void verigoster()
        {
            Abonelikclass ac = new Abonelikclass();           //verileri çekip göstermesi için verigöster() yapısı oluşturuyorum
            DataTable table = ac.goster(); 
            dataGridView1.DataSource = table;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Abonelikclass ac = new Abonelikclass();      
            ac.aboneekle(Convert.ToInt32(textBox1.Text), comboBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, Convert.ToInt32(textBox5.Text));   //textboxların yapısına göre ekleme yaptırıyorum
            verigoster();
            temizle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Abonelikclass ac = new Abonelikclass();
            ac.aboneguncelle(Convert.ToInt32(textBox1.Text), comboBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, Convert.ToInt32(textBox5.Text));    //textboxların yapısına göre güncelleme yaptırıyorum
            verigoster();
            temizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            comboBox1.Text= dataGridView1.CurrentRow.Cells[1].Value.ToString();             //  indislere göre veritabanındaki değerlere ulaşmayı sağlıyorum
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Abonelikclass ac = new Abonelikclass();
            ac.abonesil(Convert.ToInt32(textBox1.Text));       //id ye göre silme işlemi yaptırıyorum
            verigoster();
            temizle();
        }
    }
}
