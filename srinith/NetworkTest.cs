using System;
using System.ComponentModel;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace srinith
{
    public partial class NetworkTest : Form
    {
        public NetworkTest()
        {
            InitializeComponent();
        }

        private void NetworkTest_Load(object sender, EventArgs e)
        {
            // Set UI elements
            btnPing.Enabled = false;
        }

        private void txtHost_TextChanged(object sender, EventArgs e)
        {
            if (txtHost.Text.Equals(""))
            {
                btnPing.Enabled = false;
            }
            else
            {
                btnPing.Enabled = true;
            }
        }

        private void btnPing_Click(object sender, EventArgs e)
        {
            if (txtHost.Text.Equals(""))
            {
                MessageBox.Show("Ping needs a host or IP Address.");
                return;
            }

            string who = txtHost.Text;
            AutoResetEvent waiter = new AutoResetEvent(false);

            Ping pingSender = new Ping();

            // When the PingCompleted event is raised,
            // the PingCompletedCallback method is called.
            pingSender.PingCompleted += new PingCompletedEventHandler(PingCompletedCallback);

            // Create a buffer of 32 bytes of data to be transmitted.
            string data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            byte[] buffer = Encoding.ASCII.GetBytes(data);

            // Wait 12 seconds for a reply.
            int timeout = 12000;

            // Set options for transmission:
            // The data can go through 64 gateways or routers
            // before it is destroyed, and the data packet
            // cannot be fragmented.
            PingOptions options = new PingOptions(64, true);

            rtbConsole.AppendText("Time to live: " + options.Ttl);
            rtbConsole.AppendText("\nDon't fragment: " + options.DontFragment);

            // Send the ping asynchronously.
            // Use the waiter as the user token.
            // When the callback completes, it can wake up this thread.
            pingSender.SendAsync(who, timeout, buffer, options, waiter);
            MessageBox.Show("Ping packet sent successfully. Waiting for reply...");

            // Prevent this example application from ending.
            // A real application should do something useful
            // when possible.
            waiter.WaitOne();
        }

        //---------- Additional functions ----------//

        private void PingCompletedCallback(object sender, PingCompletedEventArgs e)
        {
            // If the operation was canceled, display a message to the user.
            if (e.Cancelled)
            {
                rtbConsole.AppendText("\nPing canceled.");

                // Let the main thread resume. 
                // UserToken is the AutoResetEvent object that the main thread 
                // is waiting for.
                ((AutoResetEvent)e.UserState).Set();
            }

            // If an error occurred, display the exception to the user.
            if (e.Error != null)
            {
                rtbConsole.AppendText("\nPing failed:");
                rtbConsole.AppendText(e.Error.ToString());

                // Let the main thread resume. 
                ((AutoResetEvent)e.UserState).Set();
            }

            PingReply reply = e.Reply;

            DisplayReply(reply);

            // Let the main thread resume.
            ((AutoResetEvent)e.UserState).Set();
        }

        public void DisplayReply(PingReply reply)
        {
            if (reply == null)
                return;

            rtbConsole.AppendText("\n\nPing Results..");
            rtbConsole.AppendText("\n===========");
            rtbConsole.AppendText("\nping status: " + reply.Status);
            if (reply.Status == IPStatus.Success)
            {
                rtbConsole.AppendText("\nAddress: " + reply.Address.ToString());
                rtbConsole.AppendText("\nRoundTrip time: " + reply.RoundtripTime);
                rtbConsole.AppendText("\nTime to live: " + reply.Options.Ttl);
                rtbConsole.AppendText("\nDon't fragment: " + reply.Options.DontFragment);
                rtbConsole.AppendText("\nBuffer size: " + reply.Buffer.Length);
            }
        }
    }
}
