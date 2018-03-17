using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using Alea;
using System.Globalization;

namespace BenchmarkingUtility
{
    class HardwareInfo
    {
        public static string GetCPUName()
        {
            string cpu_Name = "";
            ManagementClass cpumgmt = new ManagementClass("win32_processor");
            ManagementObjectCollection cpu = cpumgmt.GetInstances();

            foreach (ManagementObject obj in cpu)
            {
                cpu_Name = obj.Properties["Name"].Value.ToString();
            }
            return cpu_Name;
        }

        public static int GetCPUFrequency()
        {
            int cpu_Frequency = 0;
            ManagementClass cpumgmt = new ManagementClass("Win32_Processor");
            ManagementObjectCollection cpu = cpumgmt.GetInstances();

            foreach (ManagementObject obj in cpu)
            {
                cpu_Frequency = Convert.ToInt32(obj.Properties["CurrentClockSpeed"].Value.ToString());
            }
            return cpu_Frequency;
        }

        public static int GetCPUCores()
        {
            int cpu_Cores = 0;
            //int cpu_Threads = 0;
            ManagementClass cpumgmt = new ManagementClass("win32_processor");
            ManagementObjectCollection cpu = cpumgmt.GetInstances();

            foreach (ManagementObject obj in cpu)
            {
                cpu_Cores = Convert.ToInt32(obj.Properties["NumberOfCores"].Value.ToString());
                //cpu_Threads = Convert.ToInt32(obj.Properties["NumberOfLogicalProcessors"].Value.ToString());
            }
            return cpu_Cores;
        }

        public static int GetCPUThreads()
        {
            int cpu_Threads = 0;
            ManagementClass cpumgmt = new ManagementClass("win32_processor");
            ManagementObjectCollection cpu = cpumgmt.GetInstances();

            foreach (ManagementObject obj in cpu)
            {
                cpu_Threads = Convert.ToInt32(obj.Properties["NumberOfLogicalProcessors"].Value.ToString());
            }
            return cpu_Threads;
        }

        public static string GetGPUName()
        {
            var devices = Device.Devices;
            return devices[0].ToString();
        }

        public static int GetGPUFrequency()
        {
            var devices = Device.Devices;
            return devices[0].Properties.ClockRate;
        }

        public static int GetGPUCUDACores()
        {
            var devices = Device.Devices;
            return devices[0].Cores;
        }

        public static int GetGPUTextureUnits()
        {
            var devices = Device.Devices;
            return (devices[0].Cores / devices[0].Attributes.MultiprocessorCount);
        }
    }
}
