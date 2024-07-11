using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace úszóverseny
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          
        }
        private void button1_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            Verseny verseny = new Verseny();
            verseny.Show();
            Visible = false;
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void Eredmény_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            eredmeny ered = new eredmeny();
            ered.Show();
            Visible =false;
        }

        private void megnyitásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Verseny verseny = new Verseny();
            verseny.Show();
            Visible =false;
        }

        private void mentésCrtlSToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Az adatok mentésre kerültek");

        }

        private void bezárásALTF4ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void Névjegy_Click(object sender, EventArgs e)
        {
            nevjegy nevjegy = new nevjegy();
            nevjegy.Show();
            Visible = false;
        }
    }
}
