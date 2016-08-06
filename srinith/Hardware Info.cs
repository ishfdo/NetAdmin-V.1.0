using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace srinith
{
    public partial class Hardware_Info : Form
    {
        public Hardware_Info()
        {
            InitializeComponent();
        }

        private void Hardware_Info_Load(object sender, EventArgs e)
        {
            //------------------ display CPU information ------------------//


            //------------------ display Memory information  ------------------//


            //------------------ display HDD information  ------------------//


            //------------------ display Network Information  ------------------//
            // Source: https://msdn.microsoft.com/en-us/library/system.net.networkinformation.physicaladdress(v=vs.110).aspx

            IPGlobalProperties computerProperties = IPGlobalProperties.GetIPGlobalProperties();
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            //Console.WriteLine("Interface information for {0}.{1}     ",
            //        computerProperties.HostName, computerProperties.DomainName);
            txtNetwork.AppendText("Interface information for " + computerProperties.HostName + " " + computerProperties.DomainName + Environment.NewLine);

            if (nics == null || nics.Length < 1)
            {
                //Console.WriteLine("  No network interfaces found.");
                txtNetwork.AppendText("  No network interfaces found." + Environment.NewLine);
                return;
            }

            //Console.WriteLine("  Number of interfaces .................... : {0}", nics.Length);
            txtNetwork.AppendText("  Number of interfaces .................... : " + nics.Length + Environment.NewLine);
            foreach (NetworkInterface adapter in nics)
            {
                IPInterfaceProperties properties = adapter.GetIPProperties(); //  .GetIPInterfaceProperties();
                //Console.WriteLine();
                //Console.WriteLine(adapter.Description);
                //Console.WriteLine(String.Empty.PadLeft(adapter.Description.Length, '='));
                //Console.WriteLine("  Interface type .......................... : {0}", adapter.NetworkInterfaceType);
                //Console.Write("  Physical address ........................ : ");
                txtNetwork.AppendText(Environment.NewLine);
                txtNetwork.AppendText(adapter.Description + Environment.NewLine);
                txtNetwork.AppendText(String.Empty.PadLeft(adapter.Description.Length, '=') + Environment.NewLine);
                txtNetwork.AppendText("  Interface type .......................... : " + adapter.NetworkInterfaceType + Environment.NewLine);
                txtNetwork.AppendText("  Physical address ........................ : " + Environment.NewLine);
                PhysicalAddress address = adapter.GetPhysicalAddress();
                byte[] bytes = address.GetAddressBytes();
                for (int i = 0; i < bytes.Length; i++)
                {
                    // Display the physical address in hexadecimal.
                    //Console.Write("{0}", bytes[i].ToString("X2"));
                    txtNetwork.AppendText(bytes[i].ToString("X2"));
                    // Insert a hyphen after each byte, unless we are at the end of the 
                    // address.
                    if (i != bytes.Length - 1)
                    {
                        //Console.Write("-");
                        txtNetwork.AppendText(" ");
                    }
                }
                //Console.WriteLine();
                txtNetwork.AppendText(Environment.NewLine);
            }

            //------------------ display OS information  ------------------//
            txtOS.AppendText("Operating System information for " + computerProperties.HostName + " " + computerProperties.DomainName + Environment.NewLine);
            String subKey = @"SOFTWARE\Wow6432Node\Microsoft\Windows NT\CurrentVersion";
            RegistryKey key = Registry.LocalMachine;
            RegistryKey skey = key.OpenSubKey(subKey);
            //Console.WriteLine("OS Name: {0}", skey.GetValue("ProductName"));
            txtOS.AppendText("  OS Name .......................... : " + skey.GetValue("ProductName") + Environment.NewLine);

            var os = Environment.OSVersion;
            //Console.WriteLine("Platform: {0:G}", os.Platform);
            //Console.WriteLine("Version String: {0}", os.VersionString);
            //Console.WriteLine("Version Information:");
            //Console.WriteLine("   Major: {0}", os.Version.Major);
            //Console.WriteLine("   Minor: {0}", os.Version.Minor);
            //Console.WriteLine("Service Pack: '{0}'", os.ServicePack);
            txtOS.AppendText("  Platform .......................... : " + os.Platform + Environment.NewLine);
            txtOS.AppendText("  Version String .......................... : " + os.VersionString + Environment.NewLine);
            txtOS.AppendText("  Major Versoin .......................... : " + os.Version.Major + Environment.NewLine);
            txtOS.AppendText("  Minor Versoin .......................... : " + os.Version.Minor + Environment.NewLine);
            txtOS.AppendText("  Service Pack .......................... : " + os.ServicePack + Environment.NewLine);
            if (Environment.Is64BitOperatingSystem)
            {
                //Console.WriteLine("64-bit Operating System");
                txtOS.AppendText("  Architecture .......................... : 64-bit" + Environment.NewLine);
            }
            else
            {
                //Console.WriteLine("32-bit Operating System");
                txtOS.AppendText("  Architecture .......................... : 32-bit" + Environment.NewLine);
            }
        }
    }
}
