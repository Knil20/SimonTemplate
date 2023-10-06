﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Media;
using System.Drawing.Drawing2D;

namespace SimonSays
{
    public partial class Form1 : Form
    {
        
        public static List<int> pattern = new List<int>();
        public static List<int> pattHard = new List<int>();

        public static SoundPlayer green = new SoundPlayer(Properties.Resources.green);
        public static SoundPlayer red = new SoundPlayer(Properties.Resources.red);
        public static SoundPlayer yellow = new SoundPlayer(Properties.Resources.yellow);
        public static SoundPlayer blue = new SoundPlayer(Properties.Resources.blue);
        public static SoundPlayer mistake = new SoundPlayer(Properties.Resources.mistake);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new MenuScreen());
        }
        public static void ChangeScreen(object sender, UserControl next)
        {
            Form f;
            if (sender is Form)
            {
                f = (Form)sender;
            }
            else
            {
                UserControl current = (UserControl)sender;

                f = current.FindForm();

                f.Controls.Remove(current);
            }

            f.Controls.Add(next);
            next.Focus();

        }
    }
}
