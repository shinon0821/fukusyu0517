﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fukusyu0517
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "-5";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "3";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = "-2";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Text = "1";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "-1";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += int.Parse(textBox1.Text);
            label1.Top += int.Parse(textBox2.Text);
        }
    }
}
