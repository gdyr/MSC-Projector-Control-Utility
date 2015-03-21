using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Net;

namespace PJConfigure
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            IPAddress ip;
            if (!IPAddress.TryParse(addressField.Text,out ip))
            {
                MessageBox.Show("Invalid IP address.");
            }
            else
            {
                Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\MSC\PJControl", "IPAddress", addressField.Text);
                Application.Exit();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            addressField.Text = (string) Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\MSC\PJControl", "IPAddress", null);
        }
    }
}
