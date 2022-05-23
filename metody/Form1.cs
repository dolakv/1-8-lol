using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PoleUtil;

namespace metody
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
            listBox1.Items.Clear();
            int soucetsudych;
            int pocetlichych;
           
            int pocetprvku = Convert.ToInt32(textBox1.Text);
            int[] pole;
            int max;
            if (textBox2.Text == "" && textBox3.Text == "")
            {
                pole = Pole.Generuj(pocetprvku);
                max = 0;
            }
            else
            {
                int horni = Convert.ToInt32(textBox3.Text);
                int dolni = Convert.ToInt32(textBox2.Text);
                pole = Pole.Generuj(pocetprvku, dolni, horni);
                max = dolni - 1;
            }
            Pole.Vypis(listBox1, pole);
            Pole.Sudaalichacisla(pole, out soucetsudych, out pocetlichych);
            MessageBox.Show("soucet sudych cisel je " + soucetsudych + " a pocet lichych je " + pocetlichych);
            
            if (!Pole.Rostouci(pole))
            {
                MessageBox.Show("pole neni rostouci posloupnost");

            }
            else
            {
                MessageBox.Show("pole je rostouci posloupnost");
            }
            int[] pole2 = Pole.Vymena(pole, max);
            Pole.Vypis(listBox2, pole2);






        }
    }
}
