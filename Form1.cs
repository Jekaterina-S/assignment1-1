using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment1_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button3.Hide();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        // try again button
        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Show();
            pictureBox2.Show();
            label1.Text = "Guess HEADS or TAILS";
            button3.Hide();
        }

        // heads button
        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            pictureBox2.Hide();

            Random rand = new Random();
            int value = rand.Next(0, 2);

            if (value == 0)
            {
                pictureBox1.Show();
                label1.Text = "YOU WIN";
            }
            else
            {
                pictureBox2.Show();
                label1.Text = "YOU LOSE";
            }

            button3.Show();
        }

        // tails button
        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            pictureBox2.Hide();

            Random rand = new Random();
            int value = rand.Next(0, 2);

            if (value == 0)
            {
                pictureBox1.Show();
                label1.Text = "YOU LOSE";
            }
            else
            {
                pictureBox2.Show();
                label1.Text = "YOU WIN";
            }

            button3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
