using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace String_Metodlari_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            string[] kelime = new string[listBox1.Items.Count]; //dizi tanımladık.

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                kelime[i]=listBox1.Items[i].ToString(); // listbox içindeki kelimeleri kelime dizisi içine attık.
            }

            string cümle = string.Join("*", kelime); // kelime dizisi içindeki kelimeleri sırası ile belirtilen * karakteri ile birleştirdik.

            textBox1.Text = cümle; // textbox a yazdırdık.

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string kelime2 = textBox5.Text; 

            string metin1 = textBox4.Text;

            if (metin1.IndexOf(kelime2)==0) // metin1 içinde kelime 2 yi aradık. Değerin 0 döndürülmesi demek aranacak bir kelime bulunamamsı demektir.
            {
                label6.Text = "Aranacak metin girilmedi";
            }

            else if (metin1.IndexOf(kelime2)==-1) // değerin -1 döndürülmesi aranan kelimenin metin içinde olmadığını gösterir.
            {
                label6.Text = "Aradığınız Kelime Yoktur.";
            }

            else /* yukarıdaki iki durumun dışındaki durum demektirki kelime aranan metin içinde vardır.
                  * ve aranan kelimenin bulunduğu metin içinde başlangıç değeri döndürülür. 
                  * Ve saymaya sıfırdan başlandığı unutulmamalıdır. */
            {
                label6.Text = metin1.IndexOf(kelime2).ToString(); 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string kelime3 = textBox3.Text;

            int a;

            a = kelime3.IndexOfAny(new char[] { ':', '\\', '.' }); /* burada dikkatimizi çeken en önemli şey görmüş olduğunuz gibi 
                                                                    * bir dizi tanımlamasıda yapabiliyor olmamızdır. */

            if (a == -1)
            {
                label3.Text = "Karakterler mevcut değildir.";
            }

            else
                label3.Text = a.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string kelime4 = textBox7.Text;

            string metin2= textBox6.Text;

            if (metin2.LastIndexOf(kelime4) == 0)
            {
                label11.Text = "Aranacak metin girilmedi";
            }

            else if (metin2.LastIndexOf(kelime4) == -1)
            {
                label11.Text = "Aradığınız Kelime Yoktur.";
            }

            else
            {
                label11.Text = metin2.IndexOf(kelime4).ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string kelime5 = textBox9.Text;

            int b;

            b= kelime5.LastIndexOfAny(new char[] { ':', '\\', '.' });

            if (b == -1)
            {
                label15.Text = "Karakterler mevcut değildir.";
            }

            else
                label15.Text = b.ToString();
        }
    }
}
