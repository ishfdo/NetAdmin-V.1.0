using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace srinith
{
    public partial class UsageMonitor : Form
    {
        static List<float> AvailableCPU;
        static List<float> AvailableRAM;

        protected static PerformanceCounter cpuCounter;
        protected static PerformanceCounter ramCounter;
        static List<PerformanceCounter> cpuCounters;
        static int cores = 0;

        static float cpu;
        static float ram;

        public UsageMonitor()
        {
            InitializeComponent();
        }

        private void UsageMonitor_Load(object sender, EventArgs e)
        {
            ManagementClass mc;
            ManagementObjectCollection moc;
            mc = new ManagementClass("Win32_PhysicalMemory");
            moc = mc.GetInstances();

            //---------- RAM and CPU usage
            AvailableCPU = new List<float>();
            AvailableRAM = new List<float>();

            cpuCounter = new PerformanceCounter();
            cpuCounter.CategoryName = "Processor";
            cpuCounter.CounterName = "% Processor Time";
            cpuCounter.InstanceName = "_Total";
            cpuCounters = new List<PerformanceCounter>();

            foreach (var item in new System.Management.ManagementObjectSearcher("Select * from Win32_Processor").Get())
            {
                cores = cores + int.Parse(item["NumberOfCores"].ToString());
            }

            ramCounter = new PerformanceCounter("Memory", "Available MBytes");

            int procCount = System.Environment.ProcessorCount;
            for (int i = 0; i < procCount; i++)
            {
                System.Diagnostics.PerformanceCounter pc = new System.Diagnostics.PerformanceCounter("Processor", "% Processor Time", i.ToString());
                cpuCounters.Add(pc);
            }

            Thread c = new Thread(ConsumeCPU);
            c.IsBackground = true;
            c.Start();

            try
            {
                System.Timers.Timer t = new System.Timers.Timer(1200);
                t.Elapsed += new ElapsedEventHandler(TimerElapsed);
                t.Start();
                Thread.Sleep(10000);
            }
            catch (Exception ex)
            {
                //Console.WriteLine("catched exception");
            }
            //Console.ReadLine();

            //---------- Control progress bars
            // Total available RAM
            Int64 RAM = 0;
            foreach (ManagementObject mo in moc)
            {
                RAM = Convert.ToInt64(mo.Properties["Capacity"].Value) / 1024 / 1024;
            }
            txtRAM.Text = RAM + "MBytes";
            pbRAMUsage.Minimum = 0;
            pbRAMUsage.Maximum = Convert.ToInt32(RAM);
        }

        public static void ConsumeCPU()
        {
            int percentage = 60;
            if (percentage < 0 || percentage > 100)
                throw new ArgumentException("percentage");
            Stopwatch watch = new Stopwatch();
            watch.Start();
            while (true)
            {
                // Make the loop go on for "percentage" milliseconds then sleep the 
                // remaining percentage milliseconds. So 40% utilization means work 40ms and sleep 60ms
                if (watch.ElapsedMilliseconds > percentage)
                {
                    Thread.Sleep(100 - percentage);
                    watch.Reset();
                    watch.Start();
                }
            }
        }

        public static void TimerElapsed(object source, ElapsedEventArgs e)
        {
            cpu = cpuCounter.NextValue();
            float sum = 0;
            foreach (PerformanceCounter c in cpuCounters)
            {
                sum = sum + c.NextValue();
            }
            sum = sum / (cores);
            ram = ramCounter.NextValue();
            //Console.WriteLine(string.Format("CPU Value 1: {0}, cpu value 2: {1} ,ram value: {2}", sum, cpu, ram));
            AvailableCPU.Add(sum);
            AvailableRAM.Add(ram);
        }

        private void time_Tick(object sender, EventArgs e)
        {
            pbCPUUsage.Value = (int)Math.Ceiling(cpu);
            pbRAMUsage.Value = (int)Math.Ceiling(ram);
        }
    }
}
