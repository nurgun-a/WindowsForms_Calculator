using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonClick(object sender, EventArgs e)
        {
            Button currentButton = sender as Button;
            textBox1.Text += currentButton.Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable d = new DataTable();
                textBox1.Text = d.Compute(textBox1.Text, "").ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }           
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                string str = "";
                for (int i = 0; i < textBox1.Text.Length - 1; i++)
                {
                    str += textBox1.Text[i];
                }
                textBox1.Text = str;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }

    }
}
