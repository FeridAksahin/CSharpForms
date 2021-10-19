using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculatorMachine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nmb1;
            int nmb2;
            int plusResult;
            nmb1 = Convert.ToInt32(textBox1.Text); 
            nmb2 = Convert.ToInt32(textBox2.Text); 
            plusResult = nmb1 + nmb2;
            label7.Text = plusResult.ToString();

        }

        private void button3_Click(object sender, EventArgs e) //çarpma
        {
            int nmb1;
            int nmb2;
            int multiplyResult;
            nmb1 = Convert.ToInt32(textBox1.Text);
            nmb2 = Convert.ToInt32(textBox2.Text);
            multiplyResult = nmb1 * nmb2;
            label5.Text = multiplyResult.ToString();
        }

        private void button4_Click(object sender, EventArgs e) //çıkarma
        {
            int nmb1;
            int nmb2;
            int subtractResult;
            nmb1 = Convert.ToInt32(textBox1.Text);
            nmb2 = Convert.ToInt32(textBox2.Text);
            subtractResult = nmb1 - nmb2;
            label4.Text = subtractResult.ToString();
        }

        private void button2_Click(object sender, EventArgs e) //bölme
        {
            int nmb1;
            int nmb2;
            int divideResult;
            nmb1 = Convert.ToInt32(textBox1.Text);
            nmb2 = Convert.ToInt32(textBox2.Text);
            divideResult = nmb1 / nmb2;
            label9.Text = divideResult.ToString();
        } 
    }
}
