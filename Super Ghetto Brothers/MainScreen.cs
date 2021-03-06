﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Super_Ghetto_Brothers
{
    public partial class MainScreen : UserControl
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void plr1Button_Click(object sender, EventArgs e)
        {
            Form1.players = 1;
            startGame();
        }

        private void plr2Button_Click(object sender, EventArgs e)
        {
            Form1.players = 2;
            startGame();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void startGame()
        {
            // f is the form that this control is on - ("this" is the current User Control) 
            Form Form1 = this.FindForm();
            Form1.Controls.Remove(this);
            GameScreen gs = new GameScreen();
            Form1.Controls.Add(gs);
        }
    }
}
