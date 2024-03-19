using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sozluk
{
    public partial class Form1 : Form
    {
        Dictionary<string,string> kelimeler = new Dictionary<string,string>();

        
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            foreach (var kelime in kelimeler)
            {
                if (kelime.Key == textBox1.Text)
                {
                    textBox2.Text = kelime.Value;
                    break;
                }
                else
                {
                    textBox2.Text = "Kelime Bulunamadı";
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            {
                kelimeler.Add("cat","Kedi");
                kelimeler.Add("car","araba");
                kelimeler.Add("dog","bedirhan");
                kelimeler.Add("cut", "kesmek");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kelimeler.Add(textBox1.Text, textBox2.Text);
        }
    }
}
