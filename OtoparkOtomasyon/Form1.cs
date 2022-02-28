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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) 
        {
            Müşteri müsteri = new Müşteri(); //Müsteri nesnesini oluşturuyorum
            müsteri.Show(); // Müşteri formunu göstermesini sağlıyorum
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Abonelik abone = new Abonelik(); //Abone nesnesini oluşturuyorum
            abone.Show(); // Abonelik formunu göstermesini sağlıyorum
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Araçlar arac = new Araçlar(); //Arac nesnesini oluşturuyorum
            arac.Show(); // Araçlar formunu göstermesini sağlıyorum
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hizmet hizmet = new Hizmet(); //Hizmet nesnesini oluşturuyorum
            hizmet.Show(); // Hizmet formunu göstermesini sağlıyorum
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
