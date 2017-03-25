using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace sdvx_feeder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //haha python stuff will load here when i get around to it 
        }

        private void Form1_FormClosing(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            WindowState = FormWindowState.Minimized;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
            {
                WindowState = FormWindowState.Normal;
                ShowInTaskbar = true;
            }

            else if (FormWindowState.Normal == WindowState)
            {
                WindowState = FormWindowState.Minimized;
                ShowInTaskbar = false;
            }
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
