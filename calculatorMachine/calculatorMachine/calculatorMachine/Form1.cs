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
            /* Program textboxta yazılan sayıyı string olarak algılıyo şuan o yüzden onu integer olarak tanıması için
             * convert işlemi yapmalıyız*/
            nmb1 = Convert.ToInt32(textBox1.Text); /*Dediikki nmb1 değişkenini convert et Integera nerede convert edeyimi parantez
            içinde belirttik yani textBox1 id li textboxa ne zaman nbm1 int ini girersek o textbox1in texti olur bizde o texti
            integera convert ettik 
            nmb1 textBox1.Text'in değeri ama sen onu string olarak sayma integer olarak say diye convert ettik. Int32 aralığı
            int'in 64'te yapabilirdik*/
            nmb2 = Convert.ToInt32(textBox2.Text); /*nmb2 değişkenini textBox2'ye girilen texte eşitledik ve bu değer sayı olcak
            çünkü hesap makinesidir. Sonra bu girilen değeri program string olarak algılar textBox oldugundan o yüzden int e
            convert ettik */

            plusResult = nmb1 + nmb2;
            // label7.Text = plusResult;  Bu hata verir çünkü plusResult int label7.Text stringti string ifadeyi inte eşitleyemezsin
            //Bu yüzden tip çevirme yaparız plusResultu bu yüzde ToString() metodu ile int'i stringe çeviririz.
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
        } /*bir blogun içinde tanımlanan değişkenler o blokta geçerlidir o yüzden bütün buton metotlarda aynı isimde 
        nmb1, nmb2 gibi integer açabildik. Metod blogunun dışında o değişkenler geçersiz yani yok gibidir sanki hiç 
        tanımlanmamış gibi. */ 
    }
}
