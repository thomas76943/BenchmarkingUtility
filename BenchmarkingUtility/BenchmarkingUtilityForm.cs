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
        //int radiochoice = 1;
        string[] labels = new string[2];
        //List<string> comboOptions = new List<string>() { "Python + PyCUDA", "C#", "3", "4" };
        List<string> comboOptions = new List<string>() {};
        
        string codetorun;
        
        public BenchmarkingUtilityForm()
        {
            InitializeComponent();
            //Window has a fixed size and the maximise button is disabled
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Text = "Benchmarking Utility1";
            //for (int i = 0; i < 4; i++)
            //{
            //    scriptviewer_ComboBox.Items.Add(comboOptions[i]);
            //}
            //scriptviewer_ComboBox.SelectedIndex = 0;
            CreateRadioButtons();
        }
        
        private void CreateRadioButtons()
        {
            DirectoryInfo cpufiles = new DirectoryInfo(@"CPUAlgorithms");
            FileInfo[] CFiles = cpufiles.GetFiles();
            List<string> cpufilesfound = new List<string>();
            foreach (FileInfo file in CFiles)
            {
                cpufilesfound.Add(file.ToString());
            }

            DirectoryInfo gpufiles = new DirectoryInfo(@"GPUAlgorithms");
            FileInfo[] GFiles = gpufiles.GetFiles();
            List<string> gpufilesfound = new List<string>();
            foreach (FileInfo file in GFiles)
            {
                gpufilesfound.Add(file.ToString());
            }

            List<string> matches = new List<string>();

            foreach (string x in cpufilesfound) { Console.WriteLine("CPU: " + x); } //Printing all files found in CPUAlgorithms

            foreach (string x in gpufilesfound) { Console.WriteLine("GPU: " + x); } //Printing all files found in GPUAlgorithms

            foreach (string x in cpufilesfound)
            {
                foreach (string y in gpufilesfound)
                {
                    if (x == y)
                    {
                        matches.Add(x);
                    }
                }
            }

            Console.WriteLine(matches.Count + " matches found");
            foreach(string x in matches) { Console.WriteLine(x); } //Printing all file matches across

            Point newLoc = new Point(250, 5);
            List<RadioButton> buttons = new List<RadioButton>();
            
            for (int i = 0; i < matches.Count; i++)
            {
                RadioButton newButton = new RadioButton();
                newButton.Name = "BTN_" + i.ToString();
                newButton.Text = matches[i].ToString();
                newButton.CheckedChanged += RadioButton_CheckedChanged;
                newButton.Location = newLoc;
                newLoc.Offset(0, newButton.Height + 5);
                buttons.Add(newButton);
                tabPage1.Controls.Add(newButton);
            }
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            var radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                codetorun = radioButton.Text;
                string buttonName = radioButton.Name;
                Console.WriteLine("Radiobutton checked was " + buttonName);
            }

        }

        private void run_button_Click(object sender, EventArgs e)
        {
            cpuoutput_Label.Text = "";
            gpuoutput_Label.Text = "";
            run_button.Enabled = false;
            gui_BackgroundWorker.RunWorkerAsync();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cpuid_Label.Text = HardwareInfo.GetProcessorId();
            cpumake_Label.Text = HardwareInfo.GetCPUManufacturer();
            cpuclock_Label.Text = HardwareInfo.GetCPUCurrentClockSpeed().ToString();
            memory_Label.Text = HardwareInfo.GetPhysicalMemory();
        }
        
        private void BenchmarkingUtilityForm_Load(object sender, EventArgs e)
        {
            graphtimer.Start();
        }

        private void graphtimer_Tick(object sender, EventArgs e)
        {
            float cpu_f = PC_CPU.NextValue();
            cpu_progressbar.Value = (int)cpu_f;
            cpu_percentage1.Text = string.Format("{0:0.00}%", cpu_f);

            //float gpu_f = PC_GPU.NextValue();
            //gpu_progressbar.Value = (int)gpu_f;
            //gpu_percentage1.Text = string.Format("{0:0.00}%", gpu_f);
        }

        private void gui_BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            string labels = e.Result.ToString();
            cpuoutput_Label.Text = e.Result.ToString();
            gpuoutput_Label.Text = e.Result.ToString();
            run_button.Enabled = true;
            
        }
        
        private void gui_BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            //Variables 'cpu' and 'gpu' assigned to state of corresponding checkboxes in options tab
            bool cpu = cpu_Checkbox.Checked;
            bool gpu = gpu_Checkbox.Checked;
            //string algorithmpath = Algorithms.cpupaths[radiochoice - 1];
            string algorithmpath = codetorun;
            string extension = "";
            int charcount = algorithmpath.Length - 1;

            //Retrieves all characters after the '.' to find file extension
            while (algorithmpath[charcount] != '.')
            {
                extension = algorithmpath[charcount] + extension;
                --charcount;
            }
            Console.WriteLine("algorithmpath is: " + algorithmpath);
            Console.WriteLine("extension is: " + extension);

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
                        cpuoutput = Algorithms.RunPython(pythondir_textbox.Text, AppDomain.CurrentDomain.BaseDirectory + @"CPUAlgorithms\"+codetorun);
                        break;
                    case "cs":
                        Console.WriteLine("C# - CPU Running");
                        cpuoutput = Algorithms.RunCS(codetorun);
                        break;
                    case "java":
                        Console.WriteLine("Java - CPU Running");
                        break;
                    default:
                        Console.WriteLine("Unrecognised");
                        break;
                }
                //ENumber set to the retrieved output from the script
                e.Result = "*CPU: " + cpuoutput;
            }
           
            //If "Run GPU Algorithms" checkbox is true, run GPU algorithm corresponding to the radio button choice
            if (gpu)
            {
                //Cases represent types of file extension for algorithm scripts
                switch (extension)
                {
                    case "py":
                        Console.WriteLine("PyCUDA - GPU Running");
                        gpuoutput = Algorithms.RunPython(pythondir_textbox.Text, AppDomain.CurrentDomain.BaseDirectory + @"GPUAlgorithms\" + codetorun);
                        break;
                    case "cs":
                        gpuoutput = Algorithms.RunCS(codetorun);
                        break;
                    case "java":
                        break;
                    default:
                        Console.WriteLine("Unrecognised");
                        break;
                }
                //Enumber set to the retrieved output from the script
                e.Result += "*GPU: " + gpuoutput;
            }
        }
    }
}
