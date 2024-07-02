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
using System.Reflection;

namespace uszoverseny
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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


            bool a = true;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {

            }
            if (nev.Text != "" && rajszam.Text != "" && ország.Text != "" && ido.Text != "" && kor.Text != "")
            {
                listBox1.Items.Add($"{nev.Text},{rajszam.Text},{ország.Text},{ido.Text},{kor.Text}");

                
            }
        }

        private void győztes_Click(object sender, EventArgs e)
        {
           
            
                nev.Enabled = false;

                rajszam.Enabled = false;

                ország.Enabled = false;

                ido.Enabled = false;


                kor.Enabled = false;

                gyöztestb.Text = $"{nev.Text},{rajszam.Text},{ország.Text},{ido.Text},{kor.Text},";

            
                   
            }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Beolvas> beolvas = new List<Beolvas>();
            StreamWriter sw = new StreamWriter("d:\\uszo.txt");

            sw.WriteLine("úszóverseny");

            MessageBox.Show("A file be lett olvasva d:\\uszo.txt állományba");
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                sw.WriteLine($"{ listBox1.Items[i]}");
            }
                sw.Close();
        }

        private void bezár_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }
