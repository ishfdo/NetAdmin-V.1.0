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
    public partial class CheckSum : Form
    {
        public CheckSum()
        {
            InitializeComponent();
        }

        private void CheckSum_Load(object sender, EventArgs e)
        {
            // Create an instance of the open file dialog box.
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // Configure UI elements
            btnOpenFile.Text = "Upload File";
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            // Configure UI elements
            btnOpenFile.Text = "Change File";
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
    }
}
