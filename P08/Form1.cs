using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static private string Smaz(string text)
        {
            int i = 0;
            int i2 = 0;
            foreach (char pismeno in text)
            {

                if (pismeno >= '0' && pismeno <= '9')
                {

                    i2 = i;
                }

                i++;
            }
            return text.Remove(i2, 1);

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            string text2 = string.Empty;
            textBox2.Text = Smaz(text);
        }
    }
}
