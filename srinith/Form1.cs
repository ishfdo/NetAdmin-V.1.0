using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace srinith
{
    public partial class Form1 : Form
    {
        Hardware_Info form2 = new Hardware_Info();

        public Form1()
        {
            InitializeComponent();
        }

        private void hardwareInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form2.Show();
            form2.Activate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            form2.Show();
            form2.Activate();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "/s /t 0");    // starts the shutdown application 
            // the argument /s is to shut down the computer
            // the argument /t 0 is to tell the process that 
            // the specified operation needs to be completed 
            // after 0 seconds
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "/r /t 0"); // the argument /r is to restart the computer
        }

        private void button10_Click(object sender, EventArgs e)
        {
            SetSuspendState(false, true, true);
        }

        // to log off
        [DllImport("user32")]
        public static extern bool ExitWindowsEx(uint uFlags, uint dwReason);

        // to sleep 
        [DllImport("PowrProf.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern bool SetSuspendState(bool hiberate, bool forceCritical, bool disableWakeEvent);
    }
}
