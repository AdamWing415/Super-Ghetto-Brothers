﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Super_Ghetto_Brothers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Global Variables
        public static int players;

        private void Form1_Load(object sender, EventArgs e)
        {
            Form Form1 = this.FindForm();
            Form1.Controls.Remove(this);
            MainScreen ms = new MainScreen();
            Form1.Controls.Add(ms);
        }
    }
}
