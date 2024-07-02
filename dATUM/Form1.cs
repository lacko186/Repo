using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dATUM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.label8.Text = DateTime.Now.ToLongTimeString();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy.MM.dd. HH:mm:ss";


         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

            textBox2.Clear();

            textBox3.Clear();

            textBox4.Clear();

            textBox5.Clear();
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DateTime.TryParse(maskedTextBox1.Text, out DateTime felhasználodatum))
            {
                TimeSpan életkor = DateTime.Now - felhasználodatum;
                int  években= (int)(életkor.TotalDays / 365.25);

                textBox1.Text = években.ToString();

                
                
              
            }
            else
            {
                MessageBox.Show("Érvénytelen dátum formátum!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }


            textBox5.Text = felhasználodatum.DayOfWeek.ToString();
            if (textBox5.Text == "Monday")
            {
                textBox5.Text = "hétfő";
            }
            if (textBox5.Text == "Tuesday")
            {
                textBox5.Text = "Kedd";
            }
            if (textBox5.Text == "Wednesday")
            {
                textBox5.Text = "Szerda";
            }
            if (textBox5.Text == "Thursday")
            {
                textBox5.Text = "Csütörtök";
            }
            if (textBox5.Text == "Friday")
            {
                textBox5.Text = "Péntek";
            }
            if (textBox5.Text == "Saturday")
            {
                textBox5.Text = "Szombat";

            }
            if (textBox5.Text == "Sunday")
            {
                textBox5.Text = "Vasárnap";

            }

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label8.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text == dateTimePicker1.Text)
            {
                Console.WriteLine("isten éltessen");
            }
        }
    }
}
