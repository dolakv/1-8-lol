using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using matematika;

namespace P03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double u;
            double obsah = Class1.Obsah(a, out u);
            MessageBox.Show("obsah ctverce je " + obsah + " a uhlopricka je " + u);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double u;
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double obsah = Class1.Obsah(a, b, out u);
            
            MessageBox.Show("obsah obdelniku je " + obsah + " a uhlopricka je " + u);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double u;
            double objem = Class1.Objem(a, out u);
            MessageBox.Show("objem krychle je " + objem + " a uhlopricka je " + u);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c = Convert.ToDouble(textBox3.Text);
            double u;
            double objem = Class1.Objem(a, b, c, out u);
            MessageBox.Show("objem kvadru je " + objem + " a uhlopricka je " + u);
        }
    }
}
