using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgVeriGuv
{
    public partial class Form1 : Form
    {
        public Sonuc snc;
        public Form1()
        {
            snc = new Sonuc();
            InitializeComponent();
            snc.frm1 = this; 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private Bitmap griYap(Bitmap bmp)
        {
            for (int i = 0; i < bmp.Height-1; i++)
            {
                for (int j = 0; j < bmp.Width-1; j++)
                {
                    int deger = (bmp.GetPixel(j, i).R + bmp.GetPixel(j, i).G + bmp.GetPixel(j,i).B) / 3;
                    Color renk;
                    renk = Color.FromArgb(deger, deger, deger);
                    bmp.SetPixel(j,i,renk);
                }
            }
        }
       
        public void button1_Click(object sender, EventArgs e)
        {   
           /* openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName.ToString(); */

            Bitmap image = new Bitmap("C:\\Users\\Alaaddin\\Desktop\\pep.png");

            pictureBox1.Image = Image.FromFile("C:\\Users\\Alaaddin\\Desktop\\pep.png");

            Bitmap gri = griYap(image);
            pictureBox2.Image = gri;

             }

        private Bitmap x2ymod5(Bitmap image)
        {
            Bitmap gri3 = griYap(image);

            int x=0, y=0, z=0;
            int temp=0,temp1=0;
            int mod5=5;
            Color renk;
            Bitmap image61 = new Bitmap("C:\\Users\\Alaaddin\\Desktop\\cicek.jpg");

            pictureBox3.Image = Image.FromFile("C:\\Users\\Alaaddin\\Desktop\\cicek.jpg");

            Bitmap gri61 = griYap(image61);

            pictureBox4.Image = gri61;
            for (int i = 0; i < gri61.Height - 1; i++)
            {
                for (int j = 0; j < gri61.Width - 1; j++)
                {
                    temp1 = gri61.GetPixel(j, i).R % mod5;
                }
            }

            for (int i = 0; i < gri3.Height-1; i++)
            {
                for (int j = 0; j < gri3.Width-1; j++)
                {
                  Buraya:
                    x = gri3.GetPixel(j, i).R;
                    y = gri3.GetPixel(j + 1, i).R;
                    temp = x + (2 * y);
                    z = temp % mod5 ;
                    if (z == temp1)
                    {
                        renk = Color.FromArgb(z,z,z);
                        gri3.SetPixel(j, i, renk);
                    }
                    else
                    {
                        x = x - 1;
                        goto Buraya;
                    }
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
           

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        public void SRbutton_Click(object sender, EventArgs e)
        {

           
            Bitmap image2 = new Bitmap("C:\\Users\\Alaaddin\\Desktop\\cicek.jpg");

            pictureBox3.Image = Image.FromFile("C:\\Users\\Alaaddin\\Desktop\\cicek.jpg");

            Bitmap gri2 = griYap(image2);

            pictureBox4.Image = gri2;

        }
        public void SonucButon_Click(object sender, EventArgs e)
        {

            Bitmap imagesonuc = new Bitmap("C:\\Users\\Alaaddin\\Desktop\\pep.png");
            pictureBox1.Image = Image.FromFile("C:\\Users\\Alaaddin\\Desktop\\pep.png");
            Bitmap grisonuc = x2ymod5(imagesonuc);
            pictureBox2.Image = grisonuc;

            Sonuc snc = new Sonuc();
            snc.Resimdegistir(pictureBox2.Image);
            snc.Show();
          
          
        }
    }
}
