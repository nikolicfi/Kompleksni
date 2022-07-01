using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kompleksni
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            tbRez.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                KompleksniBr a = new KompleksniBr();
                KompleksniBr b = new KompleksniBr();
                a.Citaj(tbRe1, tbIm1);
                b.Citaj(tbRe2, tbIm2);
                KompleksniBr zbir = a + b;
                tbRez.Text = "Zbir ="+ zbir.ToString();
             
            }
            catch
            {
                MessageBox.Show("Doslo je do greske", "!!!!!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                KompleksniBr a = new KompleksniBr();
                KompleksniBr b = new KompleksniBr();
                a.Citaj(tbRe1, tbIm1);
                b.Citaj(tbRe2, tbIm2);
                KompleksniBr razlika = a - b;
                tbRez.Text = "Razlika =" + razlika.ToString();
            }
            catch
            {
                MessageBox.Show("Doslo je do greske", "!!!!!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                KompleksniBr a = new KompleksniBr();
                KompleksniBr b = new KompleksniBr();
                a.Citaj(tbRe1, tbIm1);
                b.Citaj(tbRe2, tbIm2);
                KompleksniBr proizvod = a * b;
                tbRez.Text = "Proizvod =" + proizvod.ToString();
            }
            catch
            {
                MessageBox.Show("Doslo je do greske", "!!!!!");
            }
        }
    }
    
}
