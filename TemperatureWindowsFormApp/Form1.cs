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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client service1 = new ServiceReference1.Service1Client();
            int c = int.Parse(textBox1.Text);
            label1.Text = service1.c2f(c).ToString() + " degrees Farenheit";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client service1 = new ServiceReference1.Service1Client();
            int f = int.Parse(textBox2.Text);
            label2.Text = service1.f2c(f).ToString() + " degrees Celsius";
        }
    }
}
