using System;
using System.IO;
using System.Reflection;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BenchmarkingUtility
{
    public partial class BenchmarkingUtilityForm : Form
    {
        int radiochoice = 1;
        List<string> comboOptions = new List<string>() { "Python + PyCUDA", "C#", "3", "4" };

        public BenchmarkingUtilityForm()
        {
            InitializeComponent();
            //Window has a fixed size and the maximise button is disabled
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Text = "Benchmarking Utility1";

            for (int i = 0; i < 4; i++)
            {
                scriptviewer_ComboBox.Items.Add(comboOptions[i]);
            }

            scriptviewer_ComboBox.SelectedIndex = 0;
        }

        private void run_button_Click(object sender, EventArgs e)
        {
            cpuoutput_Label.Text = "";
            gpuoutput_Label.Text = "";
            //Variables 'CPU' and 'GPu' assigned to state of corresponding checkboxes in options tab
            bool cpu = cpu_Checkbox.Checked;
            bool gpu = gpu_Checkbox.Checked;
            string algorithmpath = Algorithms.cpupaths[radiochoice - 1];
            string extension = "";
            int charcount = algorithmpath.Length - 1;

            //Retrieves all characters after the '.' to find file extension
            while (algorithmpath[charcount] != '.')
            {
                extension = algorithmpath[charcount] + extension;
                --charcount;
            }

            //Temprtary Strings - Accessing Variables Quicker Than Directly Accessing Controls
            string cpuoutput = "";
            string gpuoutput = "";
            //If "Run CPU Algorithms" checkbox is true, run CPU algorithm corresponding to the radio button choice
            if (cpu)
            {
                //Cases represent types of file extension for algorithm scripts
                switch (extension)
                {
                    case "py":
                        Console.WriteLine("Python - CPU Running");
                        cpuoutput = Algorithms.RunPython(pythondir_textbox.Text, Algorithms.cpupaths[radiochoice - 1]);
                        break;
                    case "cs":
                        Console.WriteLine("C# - CPU Running");
                        cpuoutput = Algorithms.RunCS(Algorithms.cpupaths[radiochoice - 1]);
                        break;
                    case "java":
                        Console.WriteLine("Java - CPU Running");
                        break;
                    default:
                        Console.WriteLine("Unrecognised");
                        break;
                }
            }
            //Label in Form set to the retrieved output from the script
            cpuoutput_Label.Text = cpuoutput;

            //If "Run GPU Algorithms" checkbox is true, run GPU algorithm corresponding to the radio button choice
            if (gpu)
            {
                //Cases represent types of file extension for algorithm scripts
                switch (extension)
                {
                    case "py":
                        Console.WriteLine("PyCUDA - GPU Running");
                        gpuoutput = Algorithms.RunPython(pythondir_textbox.Text, Algorithms.gpupaths[radiochoice - 1]);
                        break;
                    case "cs":
                        gpuoutput = Algorithms.RunCS(Algorithms.gpupaths[radiochoice - 1]);
                        break;
                    case "java":
                        break;
                    default:
                        Console.WriteLine("Unrecognised");
                        break;
                }
            }
            //Label in Form set to the retrieved output from the script
            gpuoutput_Label.Text = gpuoutput;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cpuid_Label.Text = HardwareInfo.GetProcessorId();
            cpumake_Label.Text = HardwareInfo.GetCPUManufacturer();
            cpuclock_Label.Text = HardwareInfo.GetCPUCurrentClockSpeed().ToString();
            memory_Label.Text = HardwareInfo.GetPhysicalMemory();
        }

        private void algorithm1_Radio_Click(object sender, EventArgs e)
        {
            radiochoice = 1;
        }

        private void algorithm2_Radio_Click(object sender, EventArgs e)
        {
            radiochoice = 2;
        }

        private void algorithm3_Radio_Click(object sender, EventArgs e)
        {
            radiochoice = 3;
        }

        private void algorithm4_Radio_Click(object sender, EventArgs e)
        {
            radiochoice = 4;
        }

        private void scriptviewer_ComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            cpuscript_TextBox.Text = "";
            gpuscript_TextBox.Text = "";
            
            if (scriptviewer_ComboBox.Text == "Python + PyCUDA")
            {
                cpuscript_TextBox.Text = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\CPUAlgorithms\CPUAlgorithm1.py");
                gpuscript_TextBox.Text = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\GPUAlgorithms\GPUAlgorithm1.py");
            }

            if (scriptviewer_ComboBox.Text == "C#")
            {
                cpuscript_TextBox.Text = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\CPUAlgorithms\CPUAlgorithm2.cs");
                gpuscript_TextBox.Text = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\GPUAlgorithms\GPUAlgorithm2.cs");
            }

        }
    }
}