using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kayıtDefteri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = textBox1.Text; 
            label4.Text = textBox2.Text;

            comboBox2.Items.Add("İstanbul"); 
            comboBox2.Items.Add("Diyarbakır");
            label8.Text = comboBox1.Text; 
            label11.Text = textBox3.Text;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
