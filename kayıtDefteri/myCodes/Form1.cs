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
            label3.Text = textBox1.Text; //label3',n texti textboxa yazdıgımız text olur. button1'e bastıgımızda
            label4.Text = textBox2.Text;

            comboBox2.Items.Add("İstanbul"); 
            comboBox2.Items.Add("Diyarbakır");
            /*combobox'ımıza bir normal kod yazmadan eleman ekledik 1. combobox'ımıza direk combox tıklayıp |> tuşuna basıp
             * edit diyerek ekledik elemanları ilçeleri yani. Combobox'ları il.e eklemek için kullandık. comboBox2 mizi ise
             * kod yazarak eleman ekledik. Fakat uygulama başlatıldığında comboBox2 boştur kaydet butonuna yani button1'e
             * basınca comboBox2'deki elemanlar gelir çünkü button1_click metodunun içine yazdık yani button1 click
             * oldugunda yapılmasını istediğimiz metodun içi */

            label8.Text = comboBox1.Text; //ComboBox1'de seçilen Texti label8 e eşitledik
            label11.Text = textBox3.Text;
            /*
             label11'deki texti textBox3'te yazılan texte atadık. Yani textBox3'te ne yazarsak label11  de o yazar adres yani
            adres textBox'ını uzattık textboxa basıp |> butonuna tıklayıp multiLine özelliğini aktif ettik çünkü bu aktif
            değil iken textBox enterlanmıyor yazınca yani aşağı geçmiyor tek satır oluyor.
             */

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
