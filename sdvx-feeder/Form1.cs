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

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            string path = Path.Combine(Path.GetTempPath(), "pythonE.exe");
            File.WriteAllBytes(path, MyNamespace.Properties.Resources.MyExecutable);
            Process.Start(path);
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

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void stopStartScriptToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mIDIModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mIDIModeToolStripMenuItem.Checked == true)
            {
                mIDIModeToolStripMenuItem.Checked = false;
            }
            else if (mIDIModeToolStripMenuItem.Checked == false)
            {
                mIDIModeToolStripMenuItem.Checked = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (mIDIModeToolStripMenuItem.Checked == false)
            {
                mIDIModeToolStripMenuItem.Checked = true;
            }
            else if (mIDIModeToolStripMenuItem.Checked == true)
            {
                mIDIModeToolStripMenuItem.Checked = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
