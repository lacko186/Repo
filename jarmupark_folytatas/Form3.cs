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
    public partial class Form3 : Form
    {

        public Form3()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label4.Text = $"{Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox2.Text)} Ft";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form2 Busz = new Form2();
            Busz.Show();
            Visible = false;


        }

        private void button8_Click(object sender, EventArgs e)
        {

            Form3 teherauto = new Form3();
            teherauto.Show();
            Visible = false;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form4 könyveles = new Form4();
            könyveles.Show();
            Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form4 könyveles = new Form4();
            könyveles.Show();
            Visible = false;

        }
   
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label4.Text = $"{Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox2.Text)} Ft";

        } 
    }
}
    
