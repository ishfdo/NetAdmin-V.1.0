using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
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
            lblCorrectHash.Text = "<Upload a file>";
            lblEnteredHash.Text = "<Enter the hash to verifiy>";
            lblMatch.Text = "";
            lblMismatch.Text = "";


            btnVerify.Enabled = false;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            // Configure UI elements
            btnOpenFile.Text = "Change File";
            txtFileName.Text = openFileDialog1.FileName;

            // Clear UI elements
            lblCorrectHash.Text = "";
            lblEnteredHash.Text = "";
            lblMatch.Text = "";
            lblMismatch.Text = "";
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            String fileName = openFileDialog1.FileName;
            String actualHashValue;
            String givenHashValue = txtChecksum.Text;

            lblEnteredHash.Text = txtChecksum.Text;

            using (MD5 md5Hash = MD5.Create())
            {
                var stream = File.OpenRead(fileName);

                // Convert the input string to a byte array and compute the hash.
                byte[] data = md5Hash.ComputeHash(stream);

                // Create a new Stringbuilder to collect the bytes
                // and create a string.
                StringBuilder sBuilder = new StringBuilder();

                // Loop through each byte of the hashed data 
                // and format each one as a hexadecimal string.
                for (int i = 0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("x2"));
                }

                actualHashValue = sBuilder.ToString();
            }

            lblCorrectHash.Text = actualHashValue;

            if (actualHashValue.Equals(givenHashValue))
            {
                lblMatch.Text = "Verification sucessfull. Hash values match!";
            }
            else
            {
                lblMismatch.Text = "Verification failed. Hash values don't match!";
            }
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
