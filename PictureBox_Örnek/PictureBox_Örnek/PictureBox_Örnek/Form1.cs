using PictureBox_Örnek.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBox_Örnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"C:\Users\cuney\OneDrive\Masaüstü\henry.jpg");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.zidane;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "https://s.hs-data.com/bilder/spieler/gross/1159.jpg?fallback=png";
        }
    }
}
