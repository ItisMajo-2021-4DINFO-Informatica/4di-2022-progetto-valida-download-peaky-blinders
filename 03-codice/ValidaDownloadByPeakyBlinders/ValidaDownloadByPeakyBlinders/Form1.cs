﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValidaDownloadByPeakyBlinders;

namespace fusione
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 3;
            if(panel2.Width >= 700)
            {
                timer1.Stop();
                MainWindow main = new MainWindow(true);
                main.ShowDialog();
                Close();
                this.Hide();
                main.Show();
                this.Hide();
            }
        }
    }
}
