﻿using System;
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
        int pointer = 0;
        int pointer1 = -1;
        int pointer2 = 1;
        int pointer3 = 3;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            timer1.Stop();
            
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
           
           

        }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pictureBox3_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int num = rnd.Next(0,6);
            int num2 = rnd.Next(0, 6);
            int num3 = rnd.Next(0, 6);
            pointer++;
            if(pointer>=images.Length)
            {
                pointer= 0;
            }
            pictureBox1.Image = images[pointer];         
            pictureBox2.Image = images[num];
            pictureBox3.Image = images[num2];
            pictureBox6.Image = images[pointer1];
            pictureBox7.Image = images[pointer2];
            pictureBox8.Image = images[pointer2];
            pictureBox9.Image = images[pointer1];
        }

        private void pictureBox4_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pictureBox5_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
           
            pointer1++;
            if (pointer1 >= images.Length)
            {
                pointer1 = 0;
            }
            pictureBox4.Image = images[pointer];
            
            pointer2++;
            if (pointer2>=images.Length)
            {
                pointer2 = 0;
            }
            pictureBox5.Image = images[pointer2];
        }

        private void pictureBox6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled==false)
            {
                pointer--;
                pointer1--;
                pointer2--;
                if (pointer2 == 0)
                {
                    pointer2 = 6;
                }
                if (pointer1 == 0)
                {
                    pointer1 = 6;
                }
                if(pointer == 0)
                { 
                    pointer = 6;
                }
                pictureBox4.Image = images[pointer1];
                pictureBox1.Image = images[pointer];
                pictureBox5.Image = images[pointer2];
            }
            
        }
    }
}
