using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(txtUrl.Text); //navigates to url given in txtUrl text box
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) //addition button
        {
            int num1 = int.Parse(textBoxLHS.Text.ToString());
            int num2 = int.Parse(textBoxRHS.Text.ToString()); //parses each text box and displays the sum of the two numbers
            label2.Text = (num1 + num2).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBoxLHS.Text.ToString());
            int num2 = int.Parse(textBoxRHS.Text.ToString()); //parses text box and multiplies numbers, displaying them in label
            label2.Text = (num1 * num2).ToString();
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBoxLHS.Text.ToString());
            int num2 = int.Parse(textBoxRHS.Text.ToString()); //parse text box, subtract the numbers, display in label
            label2.Text = (num1 - num2).ToString();
        }

        private void divButton_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBoxLHS.Text.ToString());
            int num2 = int.Parse(textBoxRHS.Text.ToString());//parse text box, divide the numbers, display in label
            label2.Text = (num1 / num2).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://google.com"); //homepage is set to google.com on default
        }

        private void txtUrl_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TempService.Service1Client service1 = new TempService.Service1Client();
            int c = int.Parse(textBox1.Text);
            label4.Text = service1.c2f(c).ToString() + " degrees Farenheit";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            TempService.Service1Client service1 = new TempService.Service1Client();
            int f = int.Parse(textBox2.Text);
            label3.Text = service1.f2c(f).ToString() + " degrees Celsius";
        }
    }
}
