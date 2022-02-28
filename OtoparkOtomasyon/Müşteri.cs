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
    public partial class Müşteri : Form
    {
        public Müşteri()
        {
            InitializeComponent();
        }

        private void Müşteri_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'otoparkDataSet.musteri' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.musteriTableAdapter.Fill(this.otoparkDataSet.musteri);
            verigoster();
        
        }
        void temizle()
        {
            textBox1.Clear();          // textboxların içini temizletiyorum 
            textBox2.Clear();
            textBox3.Clear();              
            textBox4.Clear();
        }
        public void verigoster()
        {
            Müstericlass mc = new Müstericlass();          //verileri çekip göstermesi için verigöster() yapısı oluşturuyorum
            DataTable table = mc.goster();
            dataGridView1.DataSource = table;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Müstericlass mc = new Müstericlass();                                                                         
            mc.musteriekle(Convert.ToInt32(textBox1.Text), textBox2.Text, textBox3.Text, textBox4.Text);        //textboxların yapısına göre ekleme yaptırıyorum
            verigoster();
            temizle();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Müstericlass mc = new Müstericlass();
            mc.musteriguncelle(Convert.ToInt32(textBox1.Text), textBox2.Text, textBox3.Text, textBox4.Text);  //textboxların yapısına göre güncelleme yaptırıyorum
            verigoster();
            temizle();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Müstericlass mc = new Müstericlass();
            mc.musterisil(Convert.ToInt32(textBox1.Text));     //id ye göre silme işlemi yaptırıyorum
            verigoster();
            temizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {  
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();   //  indislere göre veritabanındaki değerlere ulaşmayı sağlıyorum
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
