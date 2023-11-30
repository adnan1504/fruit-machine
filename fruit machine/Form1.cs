using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fruit_machine
{
    public partial class Form1 : Form
    {
        static Image apple = fruit_machine.Resource1.fruit1;
        static Image pear = fruit_machine.Resource1.fruit2;
        static Image mango = fruit_machine.Resource1.fruit3;
        static Image orange = fruit_machine.Resource1.fruit4;
        static Image cherry = fruit_machine.Resource1.fruit5;
        static Image lemon = fruit_machine.Resource1.fruit6;
        static Image berry = fruit_machine.Resource1.fruit7;
        Image[] images = { apple,pear,mango,orange,cherry,lemon,berry };
    

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
           for (int i = 0;i<images.Length;i++)
            {
                  
                e.Graphics.DrawImage(images[i],0,0);
                
            }
           

        }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(pear, 0, 0);
        }

        private void pictureBox3_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(mango , 0, 0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(mango, 0, 0);
        }
    }
}
