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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            label4.Text = $"{Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox2.Text)} Ft";

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form1 kezdolap = new Form1();
            kezdolap.Show();
            Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 könyveles = new Form4();
            könyveles.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 busz = new Form2();
            busz.Show();
            Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
                Form3 tehera = new Form3();
                tehera.Show();
                Visible = false;
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            listBox2.Items.Add(listBox1.Text);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            label4.Text = $"{Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox2.Text)} Ft";

        }
    }
}
