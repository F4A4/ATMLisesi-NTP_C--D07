using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace metot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //-------------------------------------------------------

        public int YilGoster()
        {
            return DateTime.Now.Year;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int Goster = YilGoster();
            MessageBox.Show(Goster.ToString());
        }
        
        //-------------------------------------------------------

        public int Alan(int kısakenar, int uzunkenar)
        {
            return kısakenar * uzunkenar;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sonuc = Alan(3, 4);
            Göster.Text = sonuc.ToString();
        }

        //-----------------------------------------------------

        public int UcgenAlan(int taban, int yukseklık)
        {
            return taban * yukseklık / 2;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int taban = Convert.ToInt32(textBox1.Text);
            int yukseklık = Convert.ToInt32(textBox2.Text);
            int sonuc = UcgenAlan(taban, yukseklık);
            textBox3.Text = sonuc.ToString();
        }

        //-----------------------------------------------------

        private void button4_Click(object sender, EventArgs e)
        {
            int s1 = Convert.ToInt32(textBox4.Text);
            int s2 = Convert.ToInt32(textBox6.Text);

            int sonuc2 = BuyukSayı(s1, s2);
            label4.Text = sonuc2.ToString();


        }
        public int BuyukSayı(int sayi1, int sayi2)
        {
            int sonuc = 0;
            if (sayi1 > sayi2)
            {
                sonuc = sayi1;

            }
            else if (sayi1 < sayi2)
            {
                sonuc = sayi2;
            }

            return sonuc;

        }

        //------------------------------------------------------

        private void button5_Click(object sender, EventArgs e)
        {
            int s3 = Convert.ToInt32(textBox5.Text);
            int s4 = Convert.ToInt32(textBox7.Text);

            bool sonuc4 = DogruYanlıs(s3, s4);
            label5.Text = sonuc4.ToString();
            
        }
        public bool DogruYanlıs(int sy1, int sy2)
        {
            bool sonuc3;
            if (sy1 > sy2)
            {
                sonuc3 = true;

            }
            else if (sy1 < sy2)
            {
                sonuc3 = false;
            }
            else
            {
                sonuc3 = true;                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     
            }

            return sonuc3;
        }

        //---------------------------------------------------------

        private void button6_Click(object sender, EventArgs e)
        {
            int fkt=Int32.Parse(textBox8.Text);
            int sonuc6 = Faktorıyel(fkt);//metot çağırma
            label6.Text = sonuc6.ToString();
        }

        //metot tanımlama :
        public int Faktorıyel(int sayılar)
        {
            int sonuc5 = 1;
            //i 1den başlamalı
            //sayi dahil olmalı
            //carpim 0 olursa sonuc 0 çıkar yani 1 olmalı
            for (int i =1; i <=sayılar; i++)
			{
            
                sonuc5 = sonuc5 * i;
			 
			}
                return sonuc5;

        }



    }
}
