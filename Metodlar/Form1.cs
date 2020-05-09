using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metodlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32("1");
            int[] sayilar = new int[2];
            sayilar[0] = 55;
            sayilar[1] = 4;
            Array.Sort(sayilar);
            Array.Reverse(sayilar);
            MessageBox.Show("Merhaba");
        }

        string[] dizi = new string[3];
        private void button1_Click(object sender, EventArgs e)
        {
            dizi[0] = "Negan";
            dizi[1] = "Rick";
            dizi[2] = "Daryl";
            DiziyiDoldur(); // Method çağırılır.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dizi[0] = "Rosita";
            dizi[1] = "Morgan";
            dizi[2] = "Alicia";
            DiziyiDoldur();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dizi[0] = "Murphy";
            dizi[1] = "Doctor";
            dizi[2] = "10K"; // Eğer bu olmazsa ilk buton 3'e basılırsa hata olur.
            DiziyiDoldur();
        }

        void DiziyiDoldur() // Method tanımlaması.
        {
            // Method gövdesi: İşlemin yapılacağı kodlar.
            listBox1.Items.Clear();
            foreach (string liste in dizi)
            {
                listBox1.Items.Add(liste);
            }
        }
    }
}
// Method => Yazılım içerisindeki program parçacıklarıdır. Modül modül programlamayı     sağlar. Kodlar daha düzenli ve okunabilir olur. Kodların tek bir yerden yönetilmesini sağlar. Tekrar edilen kod bloklarını en aza indirir. Yani bir kere yazıp istenilen    her yerde kullanma mantığıdır. Array, MessageBox, Convert sınıf iken; Reverse, Show,  Show, ToString, ToInt32 ilgili sınıfların içerisinde bulunan metodlardır.