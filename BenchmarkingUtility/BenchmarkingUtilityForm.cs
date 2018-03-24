using System;
using System.IO;
using System.Reflection;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NvAPIWrapper;
using NvAPIWrapper.GPU;
using NvAPIWrapper.Display;
using NvAPIWrapper.Mosaic;
using NvAPIWrapper.Native;
using System.Runtime.InteropServices;

namespace BenchmarkingUtility
{
    public partial class BenchmarkingUtilityForm : MetroFramework.Forms.MetroForm
    {
        string codetorun;
        string[] labels = new string[2];
        List<string> comboOptions = new List<string>() { };
        List<string> matches = new List<string>();

        public BenchmarkingUtilityForm()
        {
            NVIDIA.Initialize();
            InitializeComponent();
            //Window has a fixed size and the maximise button is disabled
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Text = "Benchmarking Utility1";
            //scriptviewer_ComboBox.SelectedIndex = 0;
            CreateRadioButtons();
            cpuoutput_Label.Text = "";
            gpuoutput_Label.Text = "";
            populate_info();
            //Populating the ComboBox for viewing the benchmark scripts
            foreach (string x in matches)
            {
                scriptviewer_ComboBox.Items.Add(x);
            }
            scriptviewer_ComboBox.SelectedIndex = 0;
        }

        public void CreateRadioButtons()
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
            foreach (string x in matches) { Console.WriteLine(x); } //Printing all file matches across

            Point newLoc = new Point(15, 15);
            List<RadioButton> buttons = new List<RadioButton>();

            for (int i = 0; i < matches.Count; i++)
            {
                RadioButton newButton = new RadioButton();
                newButton.Name = "BTN_" + i.ToString();
                newButton.Text = matches[i].ToString();
                newButton.AutoSize = true;
                newButton.Font = new Font(newButton.Font.FontFamily, 10);
                newButton.CheckedChanged += RadioButton_CheckedChanged;
                newButton.Location = newLoc;
                newLoc.Offset(0, newButton.Height + 8);
                buttons.Add(newButton);
                algorithmmatches_Panel.Controls.Add(newButton);
            }
        }

        private void populate_info()
        {
            string cpuName = HardwareInfo.GetCPUName();
            string cpuName_Short = cpuName.Substring(0, cpuName.Length - 10);
            cpuName_Label.Text = "CPU  -  " + cpuName_Short;

            cpuFrequency_Label.Text = HardwareInfo.GetCPUFrequency().ToString() + "MHz";
            cpuCores_Label.Text = HardwareInfo.GetCPUCores().ToString();
            cpuThreads_Label.Text = HardwareInfo.GetCPUThreads().ToString();
            gpuName_Label.Text = "GPU  -  " + HardwareInfo.GetGPUName();
            gpuFrequency_Label.Text = (HardwareInfo.GetGPUFrequency() / 1000).ToString() + "MHz";
            gpuCores_Label.Text = HardwareInfo.GetGPUCUDACores().ToString();
            gpuTMU_Label.Text = HardwareInfo.GetGPUTextureUnits().ToString();
            os_Label.Text = "OS Build  -  " + Environment.OSVersion.ToString();

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


        private void info_Button_Click(object sender, EventArgs e)
        {
            populate_info();
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
            Console.WriteLine(cpu_percentage1.Text);

            PhysicalGPU[] devices_temp = PhysicalGPU.GetPhysicalGPUs();
            PhysicalGPU[] devices;

            if (devices_temp.Length > 1)
            {
                devices = new PhysicalGPU[1] { devices_temp[0] };  
            }
            else
            {
                devices = devices_temp;
            }

            var gpuinfo = devices.ToDictionary(gpu => (object)gpu.ToString(), gpu => gpu.DynamicPerformanceStatesInfo);
            Console.WriteLine(gpuinfo[HardwareInfo.GetGPUName()].ToString());
            string gpu_find = gpuinfo[HardwareInfo.GetGPUName()].ToString();
            string[] gpu_temp = { };
            gpu_temp = gpu_find.Split(new char[] { '%', '=' });
            string gpu_f = gpu_temp[1].Substring(1);
            gpu_progressbar.Value = Convert.ToInt32(gpu_f);
            gpu_percentage1.Text = string.Format("{0:0.00}%", gpu_f);
        }

        private void gui_BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            string[] results = (e.Result.ToString()).Split('*');
            cpuoutput_Label.Text = results[0];
            if (gpu_Checkbox.Checked) { gpuoutput_Label.Text = results[1]; }
            run_button.Enabled = true;
        }
        
        private void gui_BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {

            string cpu_Name = HardwareInfo.GetCPUName();
            double cpu_Frequency = HardwareInfo.GetCPUFrequency();
            string gpu_Name = HardwareInfo.GetGPUName();
            double gpu_Frequency = HardwareInfo.GetGPUFrequency() / 1000;
            int gpu_Cores = HardwareInfo.GetGPUCUDACores();

            string filename = @"results.csv";
            if (!File.Exists(filename))
            {
                string header = "Test #" + "," + "Algorithm" + "," + "CPU/GPU" + "," + "Time" + "," + "CPU Name" + "," + "CPU Frequency" + "," + "GPU Name" + "," + "GPU Frequency" + "," + "GPU Cores" + Environment.NewLine;
                File.WriteAllText(filename, header);
            }

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
                Stopwatch timer = new Stopwatch();
                timer.Start();
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
                timer.Stop();
                //BackgroundWorker result set to the total elapsed time of the CPU stopwatch
                e.Result = timer.Elapsed;

                string[] rows = File.ReadAllLines(filename);

                string details = rows.Length + "," + codetorun + ",CPU," + timer.Elapsed.ToString() + "," + cpu_Name + "," + cpu_Frequency + "," + gpu_Name + "," + gpu_Frequency + "," + gpu_Cores + Environment.NewLine;

                File.AppendAllText(filename, details);

            }
           
            //If "Run GPU Algorithms" checkbox is true, run GPU algorithm corresponding to the radio button choice
            if (gpu)
            {
                Stopwatch timer = new Stopwatch();
                timer.Start();
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
                //Total elapsed time of the GPU stopwatch appened to the BackgroundWorker result
                e.Result += "*" + timer.Elapsed;

                string[] rows = File.ReadAllLines(filename);

                string details = rows.Length + "," + codetorun + ",GPU," + timer.Elapsed.ToString() + "," + cpu_Name + "," + cpu_Frequency + "," + gpu_Name + "," + gpu_Frequency + "," + gpu_Cores + Environment.NewLine;

                File.AppendAllText(filename, details);
            }
        }

        private void scriptviewer_ComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            cpuscript_TextBox.Text = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"CPUAlgorithms\" + scriptviewer_ComboBox.Text);
            gpuscript_TextBox.Text = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"GPUAlgorithms\" + scriptviewer_ComboBox.Text);
        }
        //rename to resultstable_Click
        private void resultstable_Button_Click(object sender, EventArgs e)
        {
            DataTable resultstable = new DataTable();
            DataRow row = resultstable.NewRow();
            FileDialog loadresults = new OpenFileDialog();
            //loadresults.InitialDirectory = @"C:\Users\mooret-aw\Documents\BenchmarkingUtility";
            loadresults.DefaultExt = ".txt";
            string pathtotable;

            if (loadresults.ShowDialog() == DialogResult.OK)
            {
                pathtotable = loadresults.FileName;
                Console.WriteLine(pathtotable);
                resultstable_TextBox.Text = loadresults.FileName;
                string[] rows = File.ReadAllLines(pathtotable);
                string[] headers = rows[0].Split(',');

                for (int i = 0; i < headers.Length; i++)
                {
                    resultstable.Columns.Add(headers[i]);
                }

                string[] fields;
                for (int i = 1; i < rows.Length; i++)
                {
                    fields = rows[i].Split(',');
                    row = resultstable.NewRow();

                    for (int j = 0; j < fields.Length; j++)
                    {
                        row[j] = fields[j];
                    }
                    resultstable.Rows.Add(row);
                }
                results_dataGridView.DataSource = resultstable;
            }           
        }
    }
}