using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace SimonSays
{
    public partial class GameScreenHard : UserControl
    {
        int guess2;
        int pattPatt2;

        public GameScreenHard()
        {
            InitializeComponent();
        }
        private void GameScreenHard_Load(object sender, EventArgs e)
        {

            Form1.pattHard.Clear();
            Refresh();
            Thread.Sleep(700);
            ComputerTurn();
        }

        private void ComputerTurn()
        {
            Random randPatt = new Random();
            pattPatt2 = randPatt.Next(0, 4);
            Form1.pattHard.Add(pattPatt2);


            for (int i = 0; i < Form1.pattern.Count; i++)
            {
                if (Form1.pattHard[i] == 0)
                {
                    Refresh();
                    Thread.Sleep(200);
                    greenButton2.BackColor = Color.White;
                    Refresh();
                    Thread.Sleep(200);
                    greenButton2.BackColor = Color.ForestGreen;
                }
                else if (Form1.pattern[i] == 1)
                {
                    Refresh();
                    Thread.Sleep(200);
                    redButton2.BackColor = Color.White;
                    Refresh();
                    Thread.Sleep(200);
                    redButton2.BackColor = Color.DarkRed;
                }
                else if (Form1.pattern[i] == 2)
                {
                    Refresh();
                    Thread.Sleep(200);
                    yellowButton2.BackColor = Color.White;
                    Refresh();
                    Thread.Sleep(200);
                    yellowButton2.BackColor = Color.Goldenrod;
                }
                else if (Form1.pattern[i] == 3)
                {
                    Refresh();
                    Thread.Sleep(200);
                    blueButton2.BackColor = Color.White;
                    Refresh();
                    Thread.Sleep(200);
                    blueButton2.BackColor = Color.DarkBlue;
                }
            }
            guess2 = 0;

        }
        private void greenButton2_Click(object sender, EventArgs e)
        {

            if (Form1.pattern[guess2] == 0)
            {
                greenButton2.BackColor = Color.White;
                Form1.green.Play();
                Refresh();
                Thread.Sleep(200);
                greenButton2.BackColor = Color.ForestGreen;
                guess2 += 1;
            }
            else
            {
                GameOver();
            }
            if (Form1.pattern.Count == guess2)
            {
                ComputerTurn();
            }
        }
        public void GameOver()
        {
            Form1.mistake.Play();
            Form1.ChangeScreen(this, new GameOverScreen());
        }
        private void redButton2_Click(object sender, EventArgs e)
        {
            if (Form1.pattern[guess2] == 1)
            {
                redButton2.BackColor = Color.White;
                Form1.red.Play();
                Refresh();
                Thread.Sleep(200);
                redButton2.BackColor = Color.DarkRed;
                guess2 += 1;
            }
            else
            {
                GameOver();
            }
            if (Form1.pattern.Count == guess2)
            {
                ComputerTurn();
            }
        }
        private void yellowButton2_Click(object sender, EventArgs e)
        {
            if (Form1.pattern[guess2] == 2)
            {
                yellowButton2.BackColor = Color.White;
                Form1.green.Play();
                Refresh();
                Thread.Sleep(200);
                yellowButton2.BackColor = Color.Goldenrod;
                guess2 += 1;
            }
            else
            {
                GameOver();
            }
            if (Form1.pattern.Count == guess2)
            {
                ComputerTurn();
            }
        }
        private void blueButton2_Click(object sender, EventArgs e)
        {
            if (Form1.pattern[guess2] == 3)
            {
                blueButton2.BackColor = Color.White;
                Form1.green.Play();
                Refresh();
                Thread.Sleep(200);
                blueButton2.BackColor = Color.DarkBlue;
                guess2 += 1;
            }
            else
            {
                GameOver();
            }

            if (Form1.pattern.Count == guess2)
            {
                ComputerTurn();
            }
        }
    }
}
