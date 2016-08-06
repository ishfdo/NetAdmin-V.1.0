using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace srinith
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hardwareInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hardware_Info form2 = new Hardware_Info();
            form2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hardware_Info form2 = new Hardware_Info();
            form2.Show();
        }
    }
}
