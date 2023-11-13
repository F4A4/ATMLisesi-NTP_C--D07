using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MetotlarTekrar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int MetotIsmi()
        {
            return 3;
        }

        int YilGoster()
        {
            return DateTime.Now.Year;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int yakalayanDegisken = MetotIsmi();
            //metot çağrılırken return ile dönen değeri 
            //yakalayacak bir değişken tanımlanması gerekir
            //aksi taktirde dönen değer kullanılamaz
            //programda hata vermez.

            int yil = YilGoster();
            label1.Text = yil.ToString();
        }

        int AlanBul(int kisaKenar, int uzunKenar)
        {
            int alan = kisaKenar * uzunKenar;
            return alan;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sonuc = AlanBul(3, 5);
            label2.Text = sonuc.ToString();
        }

        int UcgenAlaniBul(int taban, int yukseklik)
        {
            return (taban * yukseklik) / 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int tbn = Convert.ToInt32(textBox1.Text);
            int yuk = Convert.ToInt32(textBox2.Text);
            int alan = UcgenAlaniBul(tbn, yuk);
            label6.Text = alan.ToString();
        }

        public int EnBuyuk(int sayi1, int sayi2)
        {
            int eb = 0;
            if (sayi1<=sayi2)
            {
                eb = sayi2;
            }
            else if (sayi1 > sayi2)
            {
                eb = sayi1;
            }
            return eb;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            int s1 = Convert.ToInt32(textBox3.Text);
            int s2 = Convert.ToInt32(textBox4.Text);
            int enBuyukSayi = EnBuyuk(s1, s2);
            label10.Text = enBuyukSayi.ToString();
        }

        //3,5 false --- 5,3 true --- 5,5 true

        private bool Buyukmu(int sayi1, int sayi2)
        {
            bool durum;
            if (sayi1>=sayi2)
                durum = true;
            else
                durum = false;
            return durum;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            int s1 = Int32.Parse(textBox5.Text);
            int s2 = Int32.Parse(textBox6.Text);
            bool sonuc = Buyukmu(s1, s2);
            label14.Text = sonuc.ToString();
            //if (Buyukmu(s1,s2))
            //{
            //    MessageBox.Show("s1, s2 den büyük");
            //}
            //else
            //{
            //    MessageBox.Show("s2, s1 den büyük");
            //}
        }

        //metot tanımlama :
        public int FaktoryelBul(int sayi)
        {
            int carpim = 1;
            //i 1den başlamalı
            //sayi dahil olmalı
            //carpim 0 olursa sonuc 0 çıkar yani 1 olmalı
            for (int i = 1; i <= sayi; i++)
            {
                carpim = carpim * i;
            }
            return carpim;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int fkt = Int32.Parse(textBox7.Text);
            int sonuc = FaktoryelBul(fkt); //metot çağırma
            label17.Text = sonuc.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
    }
}
