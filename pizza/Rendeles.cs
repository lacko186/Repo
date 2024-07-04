using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizza
{
    public partial class Rendeles : Form
    {
        public Rendeles()
        {
            InitializeComponent();
        }

        private void bezár_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Menüválaszték_Click(object sender, EventArgs e)
        {

        }

        private void Rendeles_Load(object sender, EventArgs e)
        {

        }

        private void szamolbt_Click(object sender, EventArgs e)
        {
           
            if (Vegetariánus.Checked && radioButton1.Checked)
                {
                int db = Convert.ToInt32(Db1.Text);
                int ar = Convert.ToInt32(radioButton1.Text);
               int  össze = db * ar;
                összeglb.Text = össze.ToString();
            }

            if (Vegetariánus.Checked && radioButton2.Checked)
            {
                int db = Convert.ToInt32(Db1.Text);
                int ar = Convert.ToInt32(radioButton2.Text);
                int össze = db * ar;
                összeglb.Text = össze.ToString();
              
            }
            

            if (Magyaros.Checked && radioButton3.Checked)
            {
                int db = Convert.ToInt32(Db2.Text);
                int ar = Convert.ToInt32(radioButton3.Text);
                int össze = db * ar;
                összeglb.Text = össze.ToString();
              
            }

            if (Magyaros.Checked && radioButton4.Checked)
            {
                int db = Convert.ToInt32(Db2.Text);
                int ar = Convert.ToInt32(radioButton4.Text);
                int össze = db * ar;
                összeglb.Text = össze.ToString();
                
            }

            if (Vesuvio.Checked && radioButton5.Checked)
            {
                int db = Convert.ToInt32(Db3.Text);
                int ar = Convert.ToInt32(radioButton5.Text);
                int össze = db * ar;
                összeglb.Text = össze.ToString();
                
            }

            if (Vesuvio.Checked && radioButton6.Checked)
            {
                int db = Convert.ToInt32(Db3.Text);
                int ar = Convert.ToInt32(radioButton6.Text);
                int össze = db * ar;
                összeglb.Text = össze.ToString();

                
            }

            if (Negysajtos.Checked && radioButton7.Checked)
            {
                int db = Convert.ToInt32(Db4.Text);
                int ar = Convert.ToInt32(radioButton7.Text);
                int össze = db * ar;
                összeglb.Text = össze.ToString();
               
            }

            if (Negysajtos.Checked && radioButton8.Checked)
            {
                int db = Convert.ToInt32(Db4.Text);
                int ar = Convert.ToInt32(radioButton8.Text);
                int össze = db * ar;
                összeglb.Text = össze.ToString();
               
            }

            if (Vegetariánus.Checked && radioButton9.Checked)
            {
                int db = Convert.ToInt32(Db5.Text);
                int ar = Convert.ToInt32(radioButton9.Text);
                int össze = db * ar;
                összeglb.Text = össze.ToString();

            }

            if (Vegetariánus.Checked && radioButton10.Checked)
            {
                int db = Convert.ToInt32(Db5.Text);
                int ar = Convert.ToInt32(radioButton10.Text);
                int össze = db * ar;
                összeglb.Text = össze.ToString();
                
            }

            if (Vegetariánus.Checked && radioButton1.Checked)
            {
                int db = Convert.ToInt32(Db1.Text);
                int ar = Convert.ToInt32(radioButton1.Text);
                int össze = db * ar;
                összeglb.Text = össze.ToString();
                összeglb.Text = Db1.Text + radioButton1.Text;
            }

            if (Vegetariánus.Checked && radioButton2.Checked)
            {
                int db = Convert.ToInt32(Db1.Text);
                int ar = Convert.ToInt32(radioButton1.Text);
                int össze = db * ar;
                összeglb.Text = össze.ToString();
                összeglb.Text = Db1.Text + radioButton2.Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void töröl_Click(object sender, EventArgs e)
        {
            Db1.Clear();

            Db2.Clear();

            Db3.Clear();

            Db4.Clear();

            Db5.Clear();

            összeglb.Text = "";
            groupBox1.Visible = false;
        }
    }
}
