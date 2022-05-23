using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static private bool JeAlfanum(string text, out int pocetmalych, out int pocetcifer, out int pocetostatnich)
        {
            foreach (char pismeno in text)
            {
                pocetmalych = 0;
                pocetcifer = 0;
                pocetostatnich = 0;
               
                if (pismeno >= 'A' && pismeno <= 'Z')
                {

                }
                else if (pismeno >= 'a' && pismeno <= 'z')
                {
                    pocetmalych++;

                }
                else if (pismeno >= '1' && pismeno <= '9')
                {
                    pocetcifer++;
                }
                else
                {
                    pocetostatnich++;
                    
                }
            }

            return true;
           

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            
            bool x = JeAlfanum(text, out int pocetmalych, out int pocetcifer, out int pocetostatnich);
            MessageBox.Show("pocet malych pismen je " + pocetmalych);
            MessageBox.Show("pocet cifer je " + pocetcifer);
            MessageBox.Show("pocet ostatnich znaku je " + pocetostatnich);
            if (x)
            {
                MessageBox.Show("cislo je alfanumericke");

            }
            else
            {
                MessageBox.Show("cislo neni alfanumericke");
            }
        }
    }
}