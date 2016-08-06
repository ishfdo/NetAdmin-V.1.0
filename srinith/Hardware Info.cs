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
            ManagementClass mc;
            ManagementObjectCollection moc;
            IPGlobalProperties computerProperties = IPGlobalProperties.GetIPGlobalProperties();

            //------------------ display CPU information ------------------//
            mc = new ManagementClass("win32_processor");
            moc = mc.GetInstances();

            txtCPU.AppendText("CPU information for " + computerProperties.HostName + " " + computerProperties.DomainName + Environment.NewLine + Environment.NewLine);

            foreach (ManagementObject mo in moc)
            {
                txtCPU.AppendText("  Name .................... : " + mo.Properties["Name"].Value + Environment.NewLine);
                txtCPU.AppendText("  Current Clock Speed .................... : " + (Convert.ToInt32(mo.Properties["CurrentClockSpeed"].Value.ToString()) / 1000.0).ToString() + " GHz" + Environment.NewLine);
                txtCPU.AppendText("  Maximum Clock Speed .................... : " + (Convert.ToInt32(mo.Properties["MaxClockSpeed"].Value.ToString()) / 1000.0).ToString() + " GHz" + Environment.NewLine);
                txtCPU.AppendText("  No. of Logical Processors .................... : " + mo.Properties["NumberOfLogicalProcessors"].Value.ToString() + Environment.NewLine);
                txtCPU.AppendText("  Thread Count .................... : " + mo.Properties["ThreadCount"].Value + Environment.NewLine);
                txtCPU.AppendText("  Revision .................... : " + mo.Properties["Revision"].Value + Environment.NewLine);
                txtCPU.AppendText("  L2 cache size .................... : " + mo.Properties["L2CacheSize"].Value + " KBytes" + Environment.NewLine);
                txtCPU.AppendText("  L3 cache size .................... : " + mo.Properties["L3CacheSize"].Value + " KBytes" + Environment.NewLine);
                txtCPU.AppendText("  is Virtualization Firmware enabled .................... : " + mo.Properties["VirtualizationFirmwareEnabled"].Value + Environment.NewLine);
                break;
            }

            //------------------ display Memory information  ------------------//
            mc = new ManagementClass("Win32_PhysicalMemory");
            moc = mc.GetInstances();

            txtMemory.AppendText("Memory information for " + computerProperties.HostName + " " + computerProperties.DomainName + Environment.NewLine + Environment.NewLine);

            foreach (ManagementObject mo in moc)
            {
                txtMemory.AppendText("  Capacity .................... : " + Convert.ToInt64(mo.Properties["Capacity"].Value) / 1024 / 1024 + " GBytes" + Environment.NewLine);
                txtMemory.AppendText("  Configured Clock Speed .................... : " + mo.Properties["ConfiguredClockSpeed"].Value + " MHz" + Environment.NewLine);
                txtMemory.AppendText("  Data width .................... : " + mo.Properties["DataWidth"].Value + " bits" + Environment.NewLine);

                Int16 formFactor = Convert.ToInt16(mo.Properties["formFactor"].Value);
                switch (formFactor)
                {
                    case 7:
                        {
                            txtMemory.AppendText("  Form Factor .................... :  SIMM" + Environment.NewLine);
                            break;
                        }
                    case 8:
                        {
                            txtMemory.AppendText("  Form Factor .................... :  DIMM" + Environment.NewLine);
                            break;
                        }
                    case 10:
                        {
                            txtMemory.AppendText("  Form Factor .................... :  PGA" + Environment.NewLine);
                            break;
                        }
                    case 11:
                        {
                            txtMemory.AppendText("  Form Factor .................... :  RIMM" + Environment.NewLine);
                            break;
                        }
                    case 12:
                        {
                            txtMemory.AppendText("  Form Factor .................... :  SODIMM" + Environment.NewLine);
                            break;
                        }
                    case 19:
                        {
                            txtMemory.AppendText("  Form Factor .................... :  LCC" + Environment.NewLine);
                            break;
                        }
                    case 21:
                        {
                            txtMemory.AppendText("  Form Factor .................... :  BGA" + Environment.NewLine);
                            break;
                        }
                    case 23:
                        {
                            txtMemory.AppendText("  Form Factor .................... :  LGA" + Environment.NewLine);
                            break;
                        }
                    default:
                        txtMemory.AppendText("  Form Factor .................... :  Unknown" + Environment.NewLine);
                        break;
                }

                txtMemory.AppendText("  Device Location .................... : " + mo.Properties["DeviceLocator"].Value + Environment.NewLine);
                txtMemory.AppendText("  Manufacturer .................... : " + mo.Properties["Manufacturer"].Value + Environment.NewLine);
                txtMemory.AppendText("  Memory Type .................... : " + mo.Properties["MemoryType"].Value + Environment.NewLine);
                txtMemory.AppendText("  Model .................... : " + mo.Properties["Model"].Value + Environment.NewLine);
                txtMemory.AppendText("  Speed .................... : " + mo.Properties["Speed"].Value + Environment.NewLine);
                break;
            }

            //------------------ display HDD information  ------------------//
            mc = new ManagementClass("Win32_DiskDrive");
            moc = mc.GetInstances();

            txtHDD.AppendText("HDD information for " + computerProperties.HostName + " " + computerProperties.DomainName + Environment.NewLine + Environment.NewLine);

            foreach (ManagementObject mo in moc)
            {
                txtHDD.AppendText("  Model .................... : " + mo.Properties["Model"].Value + Environment.NewLine);
                txtHDD.AppendText("  Interface Type .................... : " + mo.Properties["InterfaceType"].Value + Environment.NewLine);
                txtHDD.AppendText("  Manufacturer .................... : " + mo.Properties["Manufacturer"].Value + Environment.NewLine);
                txtHDD.AppendText("  No. of Partitions .................... : " + mo.Properties["Partitions"].Value + Environment.NewLine);
                txtHDD.AppendText("  Serial Number .................... : " + mo.Properties["SerialNumber"].Value + Environment.NewLine);
                txtHDD.AppendText("  Size .................... : " + (Convert.ToInt64(mo.Properties["Size"].Value) / 1000000000) + "GBytes" + Environment.NewLine);
                break;
            }

            //------------------ display Network Information  ------------------//
            // Source: https://msdn.microsoft.com/en-us/library/system.net.networkinformation.physicaladdress(v=vs.110).aspx

            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            //Console.WriteLine("Interface information for {0}.{1}     ",
            //        computerProperties.HostName, computerProperties.DomainName);
            txtNetwork.AppendText("Interface information for " + computerProperties.HostName + " " + computerProperties.DomainName + Environment.NewLine + Environment.NewLine);

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
                    txtNetwork.AppendText(bytes[i].ToString("X2"));
                    // Insert a hyphen after each byte, unless we are at the end of the 
                    // address.
                    if (i != bytes.Length - 1)
                    {
                        txtNetwork.AppendText(" ");
                    }
                }
                txtNetwork.AppendText(Environment.NewLine);
            }

            //------------------ display OS information  ------------------//
            txtOS.AppendText("Operating System information for " + computerProperties.HostName + " " + computerProperties.DomainName + Environment.NewLine + Environment.NewLine);
            String subKey = @"SOFTWARE\Wow6432Node\Microsoft\Windows NT\CurrentVersion";
            RegistryKey key = Registry.LocalMachine;
            RegistryKey skey = key.OpenSubKey(subKey);
            txtOS.AppendText("  OS Name .......................... : " + skey.GetValue("ProductName") + Environment.NewLine + Environment.NewLine);

            var os = Environment.OSVersion;
            txtOS.AppendText("  Platform .......................... : " + os.Platform + Environment.NewLine);
            txtOS.AppendText("  Version String .......................... : " + os.VersionString + Environment.NewLine);
            txtOS.AppendText("  Major Versoin .......................... : " + os.Version.Major + Environment.NewLine);
            txtOS.AppendText("  Minor Versoin .......................... : " + os.Version.Minor + Environment.NewLine);
            txtOS.AppendText("  Service Pack .......................... : " + os.ServicePack + Environment.NewLine);
            if (Environment.Is64BitOperatingSystem)
            {
                txtOS.AppendText("  Architecture .......................... : 64-bit" + Environment.NewLine);
            }
            else
            {
                txtOS.AppendText("  Architecture .......................... : 32-bit" + Environment.NewLine);
            }
        }
    }
}
