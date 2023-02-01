using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormlarıcalısma5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sayi = 0, tahmin_sayisi = 0, puan =1000;

        private void button1_Click(object sender, EventArgs e)
        {
            int tahmin;
            tahmin_sayisi++; //tahmin sayısı her click te artıcak
            if (tahmin_sayisi <= 10) // eğer tahmin sayısı 10 dan küçükse
            {
                tahmin = int.Parse(textBox1.Text); // textboxda girilen yazıyı tahmin değişkeninde tut
                label6.Text = tahmin_sayisi.ToString(); // tahmin sayısını label6 yani "Tahmin sayısı:" yazan yerin yan kısmına yazdır

                if (sayi < tahmin)// eğer girilen sayı(tahmin) random sayımızdan büyükse
                {
                    label5.Text = "Lütfen sayıyı azaltınız!";
                    puan = puan - 100;
                    label7.Text = puan.ToString();
                }
                else if (sayi > tahmin)// eğer girilen sayı (tahmin) random sayımızdan küçükse
                {
                    label5.Text = "Lütfen sayıyı arttırınız!";
                    puan = puan - 100;
                    label7.Text = puan.ToString();
                }

                else // eğer girilen sayı (tahmin) random sayımıza eşitse
                {
                    label5.Text = "Tebrikler! " + label6.Text + " defada bilip, " + label7.Text + " puan aldınız.";
                    button1.Enabled = true;
                    button2.Enabled = false;
                    textBox1.Enabled = false;
                }
                textBox1.Text = "";
            }

            else  // geri kalan tüm durumlar ( örn: tahmin hakkı bitmişse) 
            {
                textBox1.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;

       
                label7.Text = puan.ToString();
                label5.Text = "Puanınız: " + label7.Text + " Tahmin Hakkınız: " + label6.Text + " Kaybettiniz";
               

  
          }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            button1.Enabled = true; // başla butonuna basınca tamam butonunu aktif hale getir
            button2.Enabled = false; // başla butonuna basınca başla butonunu pasif hale getir

            Random x = new Random(); //random sayı atama fonksiyonu
            sayi = x.Next(100); // bu randomu(x), 0 ile 100 arasından seçip sayi değişkenine atama olayı


            label5.Text = ""; // başta gözükecek durumlar
            label6.Text = "0";
            label7.Text = "1000";

        }
    }
}
