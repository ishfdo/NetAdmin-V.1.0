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
            lblMatch.Text = "";
            lblMismatch.Text = "";
            btnVerify.Enabled = false;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            // Configure UI elements
            btnOpenFile.Text = "Change File";
            txtFileName.Text = openFileDialog1.FileName;
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            
        }

        private void txtChecksum_TextChanged(object sender, EventArgs e)
        {
            // Configure UI elements
            if (txtChecksum.Text != "" && txtFileName.Text != "")
            {
                btnVerify.Enabled = true;
            }
            else
            {
                btnVerify.Enabled = false;
            }
        }
    }
}
