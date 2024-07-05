using System;
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
    public partial class Form1 : Form
    {
        public Form1()
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
            Visible =false;
        }
    }
}
