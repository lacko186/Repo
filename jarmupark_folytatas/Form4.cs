using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jarmupark_folytatas
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 teherauto = new Form3();
            teherauto.Show();
            Visible = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form2 Busz = new Form2();
            Busz.Show();
            Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 könyveles = new Form4();
            könyveles.Show();
            Visible = false;
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            
                Form1 kezdolap = new Form1();
                kezdolap.Show();
                Visible = false;
            

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form2 busz = new Form2();
            busz.Show();
            Visible = false;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
           
                Form4 könyvelés = new Form4();
                könyvelés.Show();
                Visible = false;
            }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
