﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            int sayi;
            sayi = Convert.ToInt32(textBox1.Text);
            int cevre = 2 * sayi * 3;
            label5.Text = " " + cevre;
            int alan = 3 * (sayi * sayi);
            label4.Text = " " + alan;

        }

        private void sayi_Click(object sender, EventArgs e)
        {

        }
    }
}
