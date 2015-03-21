using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PJControl
{
    public partial class PJOverlay : Form
    {

        private System.Timers.Timer fadeTimer;

        public PJOverlay(Projector pj)
        {
            InitializeComponent();

            // Show projector controls
            PJControl controlBox = new PJControl(pj);
            controlBox.TopMost = true;
            controlBox.Show();

            this.Click += exit;

        }

        private void exit(object sender, EventArgs e) { Application.Exit(); }

    }
}
