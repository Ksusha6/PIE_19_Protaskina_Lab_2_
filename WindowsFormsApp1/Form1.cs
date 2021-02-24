using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int c;
            c = a + b;
            textBox3.Text = Convert.ToString(c);
            label5.Text = "Сложение";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int c;
            c = a - b;
            textBox3.Text = Convert.ToString(c);
            label5.Text = "Вычитание";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int c;
            c = a * b;
            textBox3.Text = Convert.ToString(c);
            label5.Text = "Умножение";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int c;
            c = a / b;
            textBox3.Text = Convert.ToString(c);
            label5.Text = "Деление";
        }
    }
}
