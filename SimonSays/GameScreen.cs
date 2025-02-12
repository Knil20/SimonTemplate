﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Drawing.Drawing2D;
using System.Threading;

namespace SimonSays
{
    public partial class GameScreen : UserControl
    {

        public static int guess;
        int pattPatt;
        public static int final;



        public GameScreen()
        {
            InitializeComponent();
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {

            Form1.pattern.Clear();
            Refresh();
            Thread.Sleep(700);
            ComputerTurn();
        }

        private void ComputerTurn()
        {
            Random randPatt = new Random();
            pattPatt = randPatt.Next(0, 4);
            Form1.pattern.Add(pattPatt);
            final++;


            for (int i = 0; i < Form1.pattern.Count; i++)
            {
                if (Form1.pattern[i] == 0)
                {
                    Refresh();
                    Thread.Sleep(200);
                    Form1.green.Play();
                    greenButton.BackColor = Color.White;
                    Refresh();
                    Thread.Sleep(200);
                    greenButton.BackColor = Color.ForestGreen;
                    
                }
                else if (Form1.pattern[i] == 1)
                {
                    Refresh();
                    Thread.Sleep(200);
                    Form1.red.Play();
                    redButton.BackColor = Color.White;
                    Refresh();
                    Thread.Sleep(200);
                    redButton.BackColor = Color.DarkRed;
                    
                }
                else if (Form1.pattern[i] == 2)
                {
                    Refresh();
                    Thread.Sleep(200);
                    Form1.yellow.Play();
                    yellowButton.BackColor = Color.White;
                    Refresh();
                    Thread.Sleep(200);
                    yellowButton.BackColor = Color.Goldenrod;
                    
                }
                else if (Form1.pattern[i] == 3)
                {
                    Refresh();
                    Thread.Sleep(200);
                    Form1.blue.Play();
                    blueButton.BackColor = Color.White;
                    Refresh();
                    Thread.Sleep(200);
                    blueButton.BackColor = Color.DarkBlue;
                    
                }
            }
            guess = 0;

        }
        private void greenButton_Click(object sender, EventArgs e)
        {

            if (Form1.pattern[guess] == 0)
            {
                greenButton.BackColor = Color.White;
                Form1.green.Play();
                Refresh();
                Thread.Sleep(200);
                greenButton.BackColor = Color.ForestGreen;
                guess += 1;
            }
            else
            {
                GameOver();
            }
            if (Form1.pattern.Count == guess)
            {
                ComputerTurn();
            }
        }
        public void GameOver()
        {
            Form1.mistake.Play();
            Form1.ChangeScreen(this, new GameOverScreen());
        }
        private void redButton_Click(object sender, EventArgs e)
        {
            if (Form1.pattern[guess] == 1)
            {
                redButton.BackColor = Color.White;
                Form1.red.Play();
                Refresh();
                Thread.Sleep(200);
                redButton.BackColor = Color.DarkRed;
                guess += 1;
                
            }
            else
            {
                GameOver();
            }
            if (Form1.pattern.Count == guess)
            {
                ComputerTurn();
            }
        }
        private void yellowButton_Click(object sender, EventArgs e)
        {
            if (Form1.pattern[guess] == 2)
            {
                yellowButton.BackColor = Color.White;
                Form1.yellow.Play();
                Refresh();
                Thread.Sleep(200);
                yellowButton.BackColor = Color.Goldenrod;
                guess += 1;
                
            }
            else
            {
                GameOver();
            }
            if (Form1.pattern.Count == guess)
            {
                ComputerTurn();
            }
        }
        private void blueButton_Click(object sender, EventArgs e)
        {
            if (Form1.pattern[guess] == 3)
            {
                blueButton.BackColor = Color.White;
                Form1.blue.Play();
                Refresh();
                Thread.Sleep(200);
                blueButton.BackColor = Color.DarkBlue;
                guess += 1;
            }
            else
            {
                GameOver();
            }

            if (Form1.pattern.Count == guess)
            {
                ComputerTurn();
            }
        }
    }
}
