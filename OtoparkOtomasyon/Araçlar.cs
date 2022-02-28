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
    public partial class Araçlar : Form
    {
        public Araçlar()
        {
            InitializeComponent();
        }

        private void Araçlar_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'otoparkDataSet.arac' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.aracTableAdapter.Fill(this.otoparkDataSet.arac);
            

        }
        void temizle()
        {
            textBox1.Clear();     // textboxların içini temizletiyorum 
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }
        public void verigoster()
        {
            Araclarclass ac = new Araclarclass();             //verileri çekip göstermesi için verigöster() yapısı oluşturuyorum
            DataTable table = ac.goster();
            dataGridView1.DataSource = table;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Araclarclass ac = new Araclarclass();
            ac.aracekle(Convert.ToInt32(textBox1.Text), textBox2.Text, textBox3.Text, textBox4.Text, Convert.ToInt32(textBox5.Text));     //textboxların yapısına göre ekleme yaptırıyorum
            verigoster();
            temizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();            //  indislere göre veritabanındaki değerlere ulaşmayı sağlıyorum
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Araclarclass ac = new Araclarclass();
            ac.aracguncelle(Convert.ToInt32(textBox1.Text), textBox2.Text, textBox3.Text, textBox4.Text, Convert.ToInt32(textBox5.Text));   //textboxların yapısına göre güncelleme yaptırıyorum
            verigoster();
            temizle();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Araclarclass ac = new Araclarclass();
            ac.aracsil(Convert.ToInt32(textBox1.Text));     //id ye göre silme işlemi yaptırıyorum
            verigoster();
            temizle();
        }
    }
}
