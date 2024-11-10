using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gorselprogramlama2_3.hafta_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        int hesapla(int v, int f) 
        {
            int x = Convert.ToInt32((v * 0.4 + f * 0.6));
            return x;
        }
        int hesapla(int v, int f, int o) 
        {
            int x = Convert.ToInt32((v * 0.3 + f * 0.5 + o * 0.2));
            return x;
        }
        int hesapla(int v, int f, int o, int y)
        {
            int x = Convert.ToInt32((v * 0.2 + f * 0.5 + o * 0.3));
            return x;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int vize, final, odev1;
            vize = Convert.ToInt32(textBox1.Text);
            final = Convert.ToInt32(textBox2.Text);
            listBox1.Items.Add(hesapla(vize, final));

            if (radioButton1.Checked) 
            {
                odev1 = Convert.ToInt32(textBox3.Text);
                listBox1.Items.Add(hesapla(vize, final, odev1));
            }
            if (radioButton2.Checked)
            {
                odev1 = Convert.ToInt32(textBox3.Text);
                listBox1.Items.Add(hesapla(vize, final, odev1, x));
            }
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox3.Enabled = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                textBox3.Enabled = true;
            }

        }
    }
}
