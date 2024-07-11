using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace úszóverseny
{
    public partial class Verseny : Form
    {
        public Verseny()
        {
            InitializeComponent();
            numericUpDown1.Minimum = 200;
            numericUpDown1.Maximum = 500;

            comboBox1.Items.Add("Hosszú Katinka");
            comboBox1.Items.Add("Jakabos Zsuzsanna");
            comboBox1.Items.Add("Snildal Ingvild");
            comboBox1.Items.Add("gyorsúszás");
            comboBox1.Items.Add("Martina Granstrom");



            comboBox2.Items.Add("Mellúszás");
            comboBox2.Items.Add("Hátúszás");
            comboBox2.Items.Add("Pillangó úszás");
            comboBox2.Items.Add("Aljand Triin");
            comboBox2.Items.Add("vegyes");
        }
            class Beolvas
            {
                public string nev;
                public string rajtszam;
                public string orszag;
                public DateTime ido;
                public string kor;

                public Beolvas(string sor)
                {
                    string[] r = sor.Split(';');
                    this.nev = r[0];
                    this.rajtszam = r[1];
                    this.orszag = r[2];
                    this.ido = DateTime.Parse(r[3]);
                    this.kor = r[4];
                }
            }

            private void beolvas_Click(object sender, EventArgs e)
            {


               

                }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("d:\\asd.txt");
            
            sw.WriteLine(comboBox1.Text);
            sw.WriteLine(comboBox2.Text);
            sw.WriteLine(numericUpDown1.Text);
            sw.WriteLine(Text);
            sw.Close();
        }

        private void megnyitásToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            eredmeny eredmeny = new eredmeny();
            eredmeny.Show();
            Visible = false;
        }
    }


    }
