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
using System.Drawing.Printing;

namespace úszóverseny
{
    public partial class eredmeny : Form
    {
        public eredmeny()
        {
            InitializeComponent();
        }
        class Versenyzo
        {
            public string nev;
            public string rajtszam;
            public string orszag;
            public string ido;

            public Versenyzo(string sor)
            {
                string[] r = sor.Split(';');
                this.nev = r[0];
                this.rajtszam = r[1];
                this.orszag = r[2];
               this.ido = r[3];
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            List<Versenyzo> list = new List<Versenyzo>();
            StreamReader sr = new StreamReader("d:\\versenyzok.txt");
            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine();
                Versenyzo versenyzo = new Versenyzo(sor);
                list.Add(versenyzo);
            }
            sr.Close();
            for (int i = 0; i < list.Count(); i++)
            {
                if (listBox1.SelectedItem.ToString() == list[i].nev)
                {
                    rajszam.Text = list[i].rajtszam.ToString();

                   ország.Text = list[i].orszag.ToString();

                 ido.Text = list[i].ido.ToString();

                    
                }
            }
            if (nevsorrb.Checked)
            {
                  
               
                
                
               
            }   
        }

        private void eredmeny_Load(object sender, EventArgs e)
        {

        }

        private void bezár_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void résztvevő_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            Visible = false;
        }
    }
}
