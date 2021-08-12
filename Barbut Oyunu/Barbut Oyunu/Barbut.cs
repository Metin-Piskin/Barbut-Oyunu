using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barbut_Oyunu
{
    public partial class Barbut : Form
    {
        public Barbut()
        {
            InitializeComponent();
        }
        Random r = new Random();
        int oyuncu1t=0 , oyuncu2t = 0;
        int x, y;

        private void zarla()
        {
            x = r.Next(1, 7);
            y = r.Next(1, 7);


            if (x == 1)
            {
                pictureBox1.ImageLocation = "image\\1.bmp";
            }
            if (x == 2)
            {
                pictureBox1.ImageLocation = "image\\2.bmp";
            }
            if (x == 3)
            {
                pictureBox1.ImageLocation = "image\\3.bmp";
            }
            if (x == 4)
            {
                pictureBox1.ImageLocation = "image\\4.bmp";
            }
            if (x == 5)
            {
                pictureBox1.ImageLocation = "image\\5.bmp";
            }
            if (x == 6)
            {
                pictureBox1.ImageLocation = "image\\6.bmp";
            }

            if (y == 1)
            {
                pictureBox2.ImageLocation = "image\\1.bmp";
            }
            if (y == 2)
            {
                pictureBox2.ImageLocation = "image\\2.bmp";
            }
            if (y == 3)
            {
                pictureBox2.ImageLocation = "image\\3.bmp";
            }
            if (y == 4)
            {
                pictureBox2.ImageLocation = "image\\4.bmp";
            }
            if (y == 5)
            {
                pictureBox2.ImageLocation = "image\\5.bmp";
            }
            if (y == 6)
            {
                pictureBox2.ImageLocation = "image\\6.bmp";
            }

        }

        public void oyuncuskor()
        {
            
            if (oyuncu1t >= Convert.ToInt32(this.textBox1puan.Text))
            {
                label3.Visible = true;
                label3.Text = "***Oyuncu 1 Kazandı***";
                tekrarbuton.Visible = true;
                button2oyuncu.Enabled = false;
            }
            if (oyuncu2t >= Convert.ToInt32(this.textBox1puan.Text))
            {
                label3.Visible = true;
                label3.Text = "***Oyuncu 2 Kazandı***";
                tekrarbuton.Visible = true;
                button1oyuncu.Enabled = false;
            }

        }


        private void button1oyuncu_Click(object sender, EventArgs e)
        {

            textBox1puan.Enabled = false;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            button1oyuncu.Enabled = false;
            button2oyuncu.Enabled = true;
            zarla();
            oyuncu1t = oyuncu1t + x + y;
            label3oyuncu1.Text = oyuncu1t.ToString();
            oyuncuskor();
            
            

        }

        private void başlat_Click(object sender, EventArgs e)
        {
            başlat.Enabled = false;
            tekrarbuton.Visible = true;
            button1oyuncu.Visible = true;
            button2oyuncu.Visible = true;
            button1oyuncu.Enabled = true;
            button2oyuncu.Enabled = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            label2.Visible = true;
            label5.Visible = true;
            label3oyuncu1.Visible = true;
            label4oyuncu2.Visible = true;
            textBox1puan.Enabled = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2oyuncu_Click(object sender, EventArgs e)
        {
            textBox1puan.Enabled = false;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            button1oyuncu.Enabled = true;
            button2oyuncu.Enabled = false;
            zarla();
            oyuncu2t = oyuncu2t + x + y;
            label4oyuncu2.Text = oyuncu2t.ToString();
            oyuncuskor();
            
        }

        private void tekrarbuton_Click(object sender, EventArgs e)
        {
            button1oyuncu.Enabled = false;
            button2oyuncu.Enabled = false;
            başlat.Enabled = true;
            textBox1puan.Enabled = true;
            textBox1puan.Text = "100";
            label3.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            oyuncu1t = 0;
            oyuncu2t = 0;
            label3oyuncu1.Text = "0";
            label4oyuncu2.Text = "0";
        }
    }
}
