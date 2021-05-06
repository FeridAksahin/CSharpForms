using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizzaHouse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox2.Text); //listBox1'e textBox2nin textini ekledik 
            listBox2.Items.Add(textBox1.Text); //comboBoxta ne seçilirse yani comboBox textini listbox2 ye atadık orada gözkr
            listBox3.Items.Add(comboBox1.Text);
            listBox4.Items.Add(textBox3.Text);
            listBox5.Items.Add();
            listBox6.Items.Add(comboBox2.Text);
        }
    }
}

/*
 groupBox üzerine eklenen checkboxları taşır groupu nereye taşırsak checkBoxlar oraya gider
pictureBox içine resim konur .*/