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
    public partial class PJControl : Form
    {

        private Projector pj;

        public PJControl(Projector pj)
        {
            InitializeComponent();
            this.pj = pj;
            this.Click += cancelButton_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void powerOnButton_Click(object sender, EventArgs e)
        {
            pj.turnOn();
            Application.Exit();
        }

        private void powerOffButton_Click(object sender, EventArgs e)
        {
            pj.turnOff();
            Application.Exit();
        }

        private void sourceSelectButton_Click(object sender, EventArgs e)
        {
            pj.sourceSearch();
            Application.Exit();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
