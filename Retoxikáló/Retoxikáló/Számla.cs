using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Retoxikáló
{
    public partial class Számla : Form
    {
        public Számla()
        {
            InitializeComponent();
        }

        private void Itallap_Click(object sender, EventArgs e)
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

        private void sÚGÓ_Click(object sender, EventArgs e)
        {

            Form1 form = new Form1();
            Súgó súgó = new Súgó();
            súgó.Show();
            Visible = false;
        }

        private void Névjegy_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            Névjegy névjegy = new Névjegy();
            névjegy.Show();
            Visible = false;
        }
            private void Fájl_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Random r = new Random();
             r.Next(5000,20000);
            List<string> list = new List<string>();
            StreamReader sr = new StreamReader("d:\\italokar.txt");

            while (!sr.EndOfStream) 
            {

                string sor = sr.ReadLine();
                list.Add(sor);
            }
            sr.Close();

            int a = r.Next();
            

            for (int i = 0; i < list.Count; i++) 
            {
                richTextBox1.Text = $"Fizetendő {list[i]} ft\n Fizetve: {a}" ;
            
            }
        }
    }
}
