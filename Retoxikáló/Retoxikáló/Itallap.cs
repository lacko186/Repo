using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Retoxikáló
{
    public partial class Itallap : Form
    {
        public Itallap()
        {
            InitializeComponent();
            MessageBox.Show("Az adatok megadásánál figyelj arra hogy ne maradjanak bemeneti adatok!!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            Itallap itallap = new Itallap();
            itallap.Show();
            Visible = false;
        }

        private void Galéria_Click(object sender, EventArgs e)
        {

            Form1 form = new Form1();
            Galéria galéria = new Galéria();
            galéria.Show();
            Visible = false;
        }




        private void sÚGÓ_Click_1(object sender, EventArgs e)
        {

            Form1 form = new Form1();
            Súgó súgó = new Súgó();
            súgó.Show();
            Visible = false;
        }

        private void Fájl_Click(object sender, EventArgs e)
        {

            Form1 form = new Form1();
            Form1 fájl = new Form1();
            fájl.Show();
            Visible = false;
        }

        private void Névjegy_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            Névjegy névjegy = new Névjegy();
            névjegy.Show();
            Visible = false;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("d:\\italokar.txt");


            List<string> list = new List<string>();
            if (checkBox1.Checked && textBox1.Text != "")
            {
                int a = Int32.Parse(textBox1.Text) * 200;
                textBox1.Text = a.ToString();

                list.Add(a.ToString());
            }




            if (checkBox2.Checked && textBox2.Text != "")
            {
                int b = Int32.Parse(textBox2.Text) * 250;
                textBox2.Text = b.ToString();
                list.Add(b.ToString() );
            }


            if (checkBox3.Checked && textBox3.Text != "")
            {
                int c = Int32.Parse(textBox3.Text) * 180;
                textBox3.Text = c.ToString();
                list.Add(c.ToString() );
            }
            if (checkBox4.Checked && textBox4.Text != "")
            {
                int d = Int32.Parse(textBox4.Text) * 150;
                textBox4.Text = d.ToString();
                list.Add(d.ToString());
            }
            if (checkBox5.Checked && textBox5.Text != "")
            {
                int h = Int32.Parse(textBox5.Text) * 120;
                textBox5.Text = h.ToString();
                list.Add(h.ToString() );
            }
            if (checkBox6.Checked && textBox6.Text != "")
            {
                int i = Int32.Parse(textBox6.Text) * 100;
                textBox6.Text = i.ToString();
                list.Add(i.ToString() );
            }
            if (checkBox7.Checked && textBox7.Text != "")
            {
                int j = Int32.Parse(textBox7.Text) * 120;
                textBox7.Text = j.ToString();
                list.Add(j.ToString() );
            }

            for (int i = 0; i < list.Count; i++)
            {

                sw.WriteLine(list[i].ToString());
            }
            sw.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            Számla számla = new Számla();
            számla.Show();
            Visible = true;
        }
    }
}
