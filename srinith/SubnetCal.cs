using System;
using System.Net;
using System.Net.Sockets;
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
    public partial class SubnetCal : Form
    {
        public SubnetCal()
        {
            InitializeComponent();
        }

        private void SubnetCal_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            IPAddress address;
            IPAddress subnetID;

            /* ----- Validation of inputs ----- */
            if (txtIPAddress.Text == "")
            {
                MessageBox.Show("Please enter IP address.");
                return;
            }

            try
            {
                subnetID = IPAddress.Parse(cbSubnetMask.SelectedItem.ToString());
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Please enter subnet mask.");
                return;
            }

            try
            {
                address = IPAddress.Parse(txtIPAddress.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter a valid IP address.");
                txtIPAddress.Text = "";
                return;
            }

            /* ----- Display info -----*/
            
        }

        /* ---------- Required functions ---------- */

        // This method returns the broadcast IP address when an IP address and it's subnet mask is given
        public IPAddress GetBroadcastAddress(IPAddress address, IPAddress subnetMask)
        {
            byte[] ipAdressBytes = address.GetAddressBytes();
            byte[] subnetMaskBytes = subnetMask.GetAddressBytes();

            if (ipAdressBytes.Length != subnetMaskBytes.Length)
                MessageBox.Show("Lengths of IP address and subnet mask do not match.");

            byte[] broadcastAddress = new byte[ipAdressBytes.Length];
            for (int i = 0; i < broadcastAddress.Length; i++)
            {
                broadcastAddress[i] = (byte)(ipAdressBytes[i] | (subnetMaskBytes[i] ^ 255));
            }
            return new IPAddress(broadcastAddress);
        }

        // This function returns the subnet ID when an IP address and it's subnet mask is given
        public IPAddress GetSubnetID(IPAddress address, IPAddress subnetMask)
        {
            byte[] ipAdressBytes = address.GetAddressBytes();
            byte[] subnetMaskBytes = subnetMask.GetAddressBytes();

            if (ipAdressBytes.Length != subnetMaskBytes.Length)
                throw new ArgumentException("Lengths of IP address and subnet mask do not match.");

            byte[] broadcastAddress = new byte[ipAdressBytes.Length];
            for (int i = 0; i < broadcastAddress.Length; i++)
            {
                broadcastAddress[i] = (byte)(ipAdressBytes[i] & (subnetMaskBytes[i]));
            }
            return new IPAddress(broadcastAddress);
        }
    }
}
