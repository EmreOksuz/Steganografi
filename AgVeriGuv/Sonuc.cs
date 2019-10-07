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
    public partial class Sonuc : Form
    {
        public void Resimdegistir(Image resim)
        {
            pictureBox1.Image = resim;
        }

        public Form1 frm1;
        public Sonuc()
        {
            InitializeComponent();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Sonuc_Load(object sender, EventArgs e)
        {
         
        }

       
    }
}
