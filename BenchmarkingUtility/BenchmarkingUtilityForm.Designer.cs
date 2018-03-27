namespace BenchmarkingUtility
{
    partial class BenchmarkingUtilityForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.algorithmmatches_Panel = new System.Windows.Forms.Panel();
            this.gpu_percentage1 = new System.Windows.Forms.Label();
            this.cpu_percentage1 = new System.Windows.Forms.Label();
            this.gpu_progressbar = new System.Windows.Forms.ProgressBar();
            this.cpu_progressbar = new System.Windows.Forms.ProgressBar();
            this.gpuoutput_Label = new System.Windows.Forms.Label();
            this.cpuoutput_Label = new System.Windows.Forms.Label();
            this.run_button = new System.Windows.Forms.Button();
            this.gpu_Label = new System.Windows.Forms.Label();
            this.cpu_Label = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.staticgpuTMU_Label = new System.Windows.Forms.Label();
            this.gpuTMU_Label = new System.Windows.Forms.Label();
            this.os_Label = new System.Windows.Forms.Label();
            this.staticgpuCores_Frequency = new System.Windows.Forms.Label();
            this.staticgpuFrequency_Label = new System.Windows.Forms.Label();
            this.gpuCores_Label = new System.Windows.Forms.Label();
            this.gpuFrequency_Label = new System.Windows.Forms.Label();
            this.staticcpuThreads_Label = new System.Windows.Forms.Label();
            this.staticcpuCores_Label = new System.Windows.Forms.Label();
            this.staticcpuFrequency_Label = new System.Windows.Forms.Label();
            this.gpuName_Label = new System.Windows.Forms.Label();
            this.cpuName_Label = new System.Windows.Forms.Label();
            this.info_Button = new System.Windows.Forms.Button();
            this.cpuThreads_Label = new System.Windows.Forms.Label();
            this.cpuCores_Label = new System.Windows.Forms.Label();
            this.cpuFrequency_Label = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.gpuscript_TextBox = new System.Windows.Forms.RichTextBox();
            this.cpuscript_TextBox = new System.Windows.Forms.RichTextBox();
            this.scriptviewer_ComboBox = new System.Windows.Forms.ComboBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.results_dataGridView = new System.Windows.Forms.DataGridView();
            this.resultstable_TextBox = new System.Windows.Forms.TextBox();
            this.resultstable_Button = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.pythondir_textboxlabel = new System.Windows.Forms.Label();
            this.pythondir_textbox = new System.Windows.Forms.TextBox();
            this.gpu_Checkbox = new System.Windows.Forms.CheckBox();
            this.cpu_Checkbox = new System.Windows.Forms.CheckBox();
            this.PC_CPU = new System.Diagnostics.PerformanceCounter();
            this.graphtimer = new System.Windows.Forms.Timer(this.components);
            this.gui_BackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cpudirectory_TextBox = new System.Windows.Forms.TextBox();
            this.gpudirectory_TextBox = new System.Windows.Forms.TextBox();
            this.cpudirectory_Label = new System.Windows.Forms.Label();
            this.gpudirectory_Label = new System.Windows.Forms.Label();
            this.cpualgorithms_Button = new System.Windows.Forms.Button();
            this.gpualgorithms_Button = new System.Windows.Forms.Button();
            this.pythondirectory_Button = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.results_dataGridView)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PC_CPU)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(116, 35);
            this.tabControl1.Location = new System.Drawing.Point(-1, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(634, 430);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.algorithmmatches_Panel);
            this.tabPage1.Controls.Add(this.gpu_percentage1);
            this.tabPage1.Controls.Add(this.cpu_percentage1);
            this.tabPage1.Controls.Add(this.gpu_progressbar);
            this.tabPage1.Controls.Add(this.cpu_progressbar);
            this.tabPage1.Controls.Add(this.gpuoutput_Label);
            this.tabPage1.Controls.Add(this.cpuoutput_Label);
            this.tabPage1.Controls.Add(this.run_button);
            this.tabPage1.Controls.Add(this.gpu_Label);
            this.tabPage1.Controls.Add(this.cpu_Label);
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(626, 387);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "home";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "Algorithm Matches Found";
            // 
            // algorithmmatches_Panel
            // 
            this.algorithmmatches_Panel.AutoScroll = true;
            this.algorithmmatches_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.algorithmmatches_Panel.Location = new System.Drawing.Point(6, 48);
            this.algorithmmatches_Panel.Name = "algorithmmatches_Panel";
            this.algorithmmatches_Panel.Size = new System.Drawing.Size(302, 298);
            this.algorithmmatches_Panel.TabIndex = 0;
            // 
            // gpu_percentage1
            // 
            this.gpu_percentage1.AutoSize = true;
            this.gpu_percentage1.Location = new System.Drawing.Point(492, 302);
            this.gpu_percentage1.Name = "gpu_percentage1";
            this.gpu_percentage1.Size = new System.Drawing.Size(26, 17);
            this.gpu_percentage1.TabIndex = 16;
            this.gpu_percentage1.Text = "0%";
            // 
            // cpu_percentage1
            // 
            this.cpu_percentage1.AutoSize = true;
            this.cpu_percentage1.Location = new System.Drawing.Point(492, 134);
            this.cpu_percentage1.Name = "cpu_percentage1";
            this.cpu_percentage1.Size = new System.Drawing.Size(26, 17);
            this.cpu_percentage1.TabIndex = 15;
            this.cpu_percentage1.Text = "0%";
            // 
            // gpu_progressbar
            // 
            this.gpu_progressbar.Location = new System.Drawing.Point(349, 302);
            this.gpu_progressbar.Name = "gpu_progressbar";
            this.gpu_progressbar.Size = new System.Drawing.Size(137, 16);
            this.gpu_progressbar.TabIndex = 13;
            // 
            // cpu_progressbar
            // 
            this.cpu_progressbar.Location = new System.Drawing.Point(349, 134);
            this.cpu_progressbar.Name = "cpu_progressbar";
            this.cpu_progressbar.Size = new System.Drawing.Size(137, 16);
            this.cpu_progressbar.TabIndex = 11;
            // 
            // gpuoutput_Label
            // 
            this.gpuoutput_Label.AutoSize = true;
            this.gpuoutput_Label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpuoutput_Label.Location = new System.Drawing.Point(346, 239);
            this.gpuoutput_Label.Name = "gpuoutput_Label";
            this.gpuoutput_Label.Size = new System.Drawing.Size(0, 17);
            this.gpuoutput_Label.TabIndex = 10;
            // 
            // cpuoutput_Label
            // 
            this.cpuoutput_Label.AutoSize = true;
            this.cpuoutput_Label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuoutput_Label.Location = new System.Drawing.Point(346, 66);
            this.cpuoutput_Label.Name = "cpuoutput_Label";
            this.cpuoutput_Label.Size = new System.Drawing.Size(0, 17);
            this.cpuoutput_Label.TabIndex = 9;
            // 
            // run_button
            // 
            this.run_button.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.run_button.Location = new System.Drawing.Point(4, 352);
            this.run_button.Name = "run_button";
            this.run_button.Size = new System.Drawing.Size(304, 28);
            this.run_button.TabIndex = 8;
            this.run_button.Text = "Run Selected Algorithm";
            this.run_button.UseVisualStyleBackColor = true;
            this.run_button.Click += new System.EventHandler(this.run_button_Click);
            // 
            // gpu_Label
            // 
            this.gpu_Label.AutoSize = true;
            this.gpu_Label.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpu_Label.Location = new System.Drawing.Point(346, 221);
            this.gpu_Label.Name = "gpu_Label";
            this.gpu_Label.Size = new System.Drawing.Size(42, 18);
            this.gpu_Label.TabIndex = 7;
            this.gpu_Label.Text = "GPU";
            // 
            // cpu_Label
            // 
            this.cpu_Label.AutoSize = true;
            this.cpu_Label.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpu_Label.Location = new System.Drawing.Point(347, 48);
            this.cpu_Label.Name = "cpu_Label";
            this.cpu_Label.Size = new System.Drawing.Size(41, 18);
            this.cpu_Label.TabIndex = 6;
            this.cpu_Label.Text = "CPU";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.staticgpuTMU_Label);
            this.tabPage2.Controls.Add(this.gpuTMU_Label);
            this.tabPage2.Controls.Add(this.os_Label);
            this.tabPage2.Controls.Add(this.staticgpuCores_Frequency);
            this.tabPage2.Controls.Add(this.staticgpuFrequency_Label);
            this.tabPage2.Controls.Add(this.gpuCores_Label);
            this.tabPage2.Controls.Add(this.gpuFrequency_Label);
            this.tabPage2.Controls.Add(this.staticcpuThreads_Label);
            this.tabPage2.Controls.Add(this.staticcpuCores_Label);
            this.tabPage2.Controls.Add(this.staticcpuFrequency_Label);
            this.tabPage2.Controls.Add(this.gpuName_Label);
            this.tabPage2.Controls.Add(this.cpuName_Label);
            this.tabPage2.Controls.Add(this.info_Button);
            this.tabPage2.Controls.Add(this.cpuThreads_Label);
            this.tabPage2.Controls.Add(this.cpuCores_Label);
            this.tabPage2.Controls.Add(this.cpuFrequency_Label);
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(626, 387);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "info";
            // 
            // staticgpuTMU_Label
            // 
            this.staticgpuTMU_Label.AutoSize = true;
            this.staticgpuTMU_Label.Location = new System.Drawing.Point(330, 154);
            this.staticgpuTMU_Label.Name = "staticgpuTMU_Label";
            this.staticgpuTMU_Label.Size = new System.Drawing.Size(143, 17);
            this.staticgpuTMU_Label.TabIndex = 29;
            this.staticgpuTMU_Label.Text = "Texture Mapping Units:";
            // 
            // gpuTMU_Label
            // 
            this.gpuTMU_Label.AutoSize = true;
            this.gpuTMU_Label.Location = new System.Drawing.Point(488, 154);
            this.gpuTMU_Label.Name = "gpuTMU_Label";
            this.gpuTMU_Label.Size = new System.Drawing.Size(74, 17);
            this.gpuTMU_Label.TabIndex = 28;
            this.gpuTMU_Label.Text = "(tmu count)";
            // 
            // os_Label
            // 
            this.os_Label.AutoSize = true;
            this.os_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.os_Label.Location = new System.Drawing.Point(6, 230);
            this.os_Label.Name = "os_Label";
            this.os_Label.Size = new System.Drawing.Size(73, 21);
            this.os_Label.TabIndex = 27;
            this.os_Label.Text = "OS Build:";
            // 
            // staticgpuCores_Frequency
            // 
            this.staticgpuCores_Frequency.AutoSize = true;
            this.staticgpuCores_Frequency.Location = new System.Drawing.Point(330, 122);
            this.staticgpuCores_Frequency.Name = "staticgpuCores_Frequency";
            this.staticgpuCores_Frequency.Size = new System.Drawing.Size(120, 17);
            this.staticgpuCores_Frequency.TabIndex = 26;
            this.staticgpuCores_Frequency.Text = "Stream Processors:";
            // 
            // staticgpuFrequency_Label
            // 
            this.staticgpuFrequency_Label.AutoSize = true;
            this.staticgpuFrequency_Label.Location = new System.Drawing.Point(330, 91);
            this.staticgpuFrequency_Label.Name = "staticgpuFrequency_Label";
            this.staticgpuFrequency_Label.Size = new System.Drawing.Size(83, 17);
            this.staticgpuFrequency_Label.TabIndex = 25;
            this.staticgpuFrequency_Label.Text = "Clock Speed:";
            // 
            // gpuCores_Label
            // 
            this.gpuCores_Label.AutoSize = true;
            this.gpuCores_Label.Location = new System.Drawing.Point(488, 122);
            this.gpuCores_Label.Name = "gpuCores_Label";
            this.gpuCores_Label.Size = new System.Drawing.Size(78, 17);
            this.gpuCores_Label.TabIndex = 24;
            this.gpuCores_Label.Text = "(core count)";
            // 
            // gpuFrequency_Label
            // 
            this.gpuFrequency_Label.AutoSize = true;
            this.gpuFrequency_Label.Location = new System.Drawing.Point(488, 91);
            this.gpuFrequency_Label.Name = "gpuFrequency_Label";
            this.gpuFrequency_Label.Size = new System.Drawing.Size(73, 17);
            this.gpuFrequency_Label.TabIndex = 23;
            this.gpuFrequency_Label.Text = "(frequency)";
            // 
            // staticcpuThreads_Label
            // 
            this.staticcpuThreads_Label.AutoSize = true;
            this.staticcpuThreads_Label.Location = new System.Drawing.Point(7, 154);
            this.staticcpuThreads_Label.Name = "staticcpuThreads_Label";
            this.staticcpuThreads_Label.Size = new System.Drawing.Size(58, 17);
            this.staticcpuThreads_Label.TabIndex = 22;
            this.staticcpuThreads_Label.Text = "Threads:";
            // 
            // staticcpuCores_Label
            // 
            this.staticcpuCores_Label.AutoSize = true;
            this.staticcpuCores_Label.Location = new System.Drawing.Point(7, 122);
            this.staticcpuCores_Label.Name = "staticcpuCores_Label";
            this.staticcpuCores_Label.Size = new System.Drawing.Size(45, 17);
            this.staticcpuCores_Label.TabIndex = 21;
            this.staticcpuCores_Label.Text = "Cores:";
            // 
            // staticcpuFrequency_Label
            // 
            this.staticcpuFrequency_Label.AutoSize = true;
            this.staticcpuFrequency_Label.Location = new System.Drawing.Point(7, 91);
            this.staticcpuFrequency_Label.Name = "staticcpuFrequency_Label";
            this.staticcpuFrequency_Label.Size = new System.Drawing.Size(83, 17);
            this.staticcpuFrequency_Label.TabIndex = 20;
            this.staticcpuFrequency_Label.Text = "Clock Speed:";
            // 
            // gpuName_Label
            // 
            this.gpuName_Label.AutoSize = true;
            this.gpuName_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpuName_Label.Location = new System.Drawing.Point(329, 38);
            this.gpuName_Label.Name = "gpuName_Label";
            this.gpuName_Label.Size = new System.Drawing.Size(44, 21);
            this.gpuName_Label.TabIndex = 19;
            this.gpuName_Label.Text = "GPU:";
            // 
            // cpuName_Label
            // 
            this.cpuName_Label.AutoSize = true;
            this.cpuName_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuName_Label.Location = new System.Drawing.Point(6, 38);
            this.cpuName_Label.Name = "cpuName_Label";
            this.cpuName_Label.Size = new System.Drawing.Size(43, 21);
            this.cpuName_Label.TabIndex = 18;
            this.cpuName_Label.Text = "CPU:";
            // 
            // info_Button
            // 
            this.info_Button.Location = new System.Drawing.Point(454, 356);
            this.info_Button.Name = "info_Button";
            this.info_Button.Size = new System.Drawing.Size(150, 24);
            this.info_Button.TabIndex = 4;
            this.info_Button.Text = "Reload System Details";
            this.info_Button.UseVisualStyleBackColor = true;
            this.info_Button.Click += new System.EventHandler(this.info_Button_Click);
            // 
            // cpuThreads_Label
            // 
            this.cpuThreads_Label.AutoSize = true;
            this.cpuThreads_Label.Location = new System.Drawing.Point(145, 154);
            this.cpuThreads_Label.Name = "cpuThreads_Label";
            this.cpuThreads_Label.Size = new System.Drawing.Size(90, 17);
            this.cpuThreads_Label.TabIndex = 3;
            this.cpuThreads_Label.Text = "(thread count)";
            // 
            // cpuCores_Label
            // 
            this.cpuCores_Label.AutoSize = true;
            this.cpuCores_Label.Location = new System.Drawing.Point(145, 122);
            this.cpuCores_Label.Name = "cpuCores_Label";
            this.cpuCores_Label.Size = new System.Drawing.Size(78, 17);
            this.cpuCores_Label.TabIndex = 2;
            this.cpuCores_Label.Text = "(core count)";
            // 
            // cpuFrequency_Label
            // 
            this.cpuFrequency_Label.AutoSize = true;
            this.cpuFrequency_Label.Location = new System.Drawing.Point(145, 91);
            this.cpuFrequency_Label.Name = "cpuFrequency_Label";
            this.cpuFrequency_Label.Size = new System.Drawing.Size(73, 17);
            this.cpuFrequency_Label.TabIndex = 1;
            this.cpuFrequency_Label.Text = "(frequency)";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.gpuscript_TextBox);
            this.tabPage3.Controls.Add(this.cpuscript_TextBox);
            this.tabPage3.Controls.Add(this.scriptviewer_ComboBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(626, 387);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "viewer";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // gpuscript_TextBox
            // 
            this.gpuscript_TextBox.Location = new System.Drawing.Point(314, 33);
            this.gpuscript_TextBox.Name = "gpuscript_TextBox";
            this.gpuscript_TextBox.ReadOnly = true;
            this.gpuscript_TextBox.Size = new System.Drawing.Size(305, 358);
            this.gpuscript_TextBox.TabIndex = 2;
            this.gpuscript_TextBox.Text = "";
            // 
            // cpuscript_TextBox
            // 
            this.cpuscript_TextBox.Location = new System.Drawing.Point(3, 33);
            this.cpuscript_TextBox.Name = "cpuscript_TextBox";
            this.cpuscript_TextBox.ReadOnly = true;
            this.cpuscript_TextBox.Size = new System.Drawing.Size(305, 358);
            this.cpuscript_TextBox.TabIndex = 1;
            this.cpuscript_TextBox.Text = "";
            // 
            // scriptviewer_ComboBox
            // 
            this.scriptviewer_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.scriptviewer_ComboBox.FormattingEnabled = true;
            this.scriptviewer_ComboBox.Location = new System.Drawing.Point(3, 6);
            this.scriptviewer_ComboBox.Name = "scriptviewer_ComboBox";
            this.scriptviewer_ComboBox.Size = new System.Drawing.Size(168, 25);
            this.scriptviewer_ComboBox.TabIndex = 0;
            this.scriptviewer_ComboBox.SelectedValueChanged += new System.EventHandler(this.scriptviewer_ComboBox_SelectedValueChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.results_dataGridView);
            this.tabPage4.Controls.Add(this.resultstable_TextBox);
            this.tabPage4.Controls.Add(this.resultstable_Button);
            this.tabPage4.Location = new System.Drawing.Point(4, 39);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(626, 387);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "results";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // results_dataGridView
            // 
            this.results_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.results_dataGridView.Location = new System.Drawing.Point(6, 34);
            this.results_dataGridView.Name = "results_dataGridView";
            this.results_dataGridView.RowHeadersVisible = false;
            this.results_dataGridView.Size = new System.Drawing.Size(608, 350);
            this.results_dataGridView.TabIndex = 3;
            // 
            // resultstable_TextBox
            // 
            this.resultstable_TextBox.Location = new System.Drawing.Point(126, 3);
            this.resultstable_TextBox.Name = "resultstable_TextBox";
            this.resultstable_TextBox.Size = new System.Drawing.Size(488, 25);
            this.resultstable_TextBox.TabIndex = 1;
            // 
            // resultstable_Button
            // 
            this.resultstable_Button.Location = new System.Drawing.Point(6, 3);
            this.resultstable_Button.Name = "resultstable_Button";
            this.resultstable_Button.Size = new System.Drawing.Size(114, 25);
            this.resultstable_Button.TabIndex = 0;
            this.resultstable_Button.Text = "Load Results";
            this.resultstable_Button.UseVisualStyleBackColor = true;
            this.resultstable_Button.Click += new System.EventHandler(this.resultstable_Button_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.White;
            this.tabPage5.Controls.Add(this.pythondirectory_Button);
            this.tabPage5.Controls.Add(this.gpualgorithms_Button);
            this.tabPage5.Controls.Add(this.cpualgorithms_Button);
            this.tabPage5.Controls.Add(this.gpudirectory_Label);
            this.tabPage5.Controls.Add(this.cpudirectory_Label);
            this.tabPage5.Controls.Add(this.gpudirectory_TextBox);
            this.tabPage5.Controls.Add(this.cpudirectory_TextBox);
            this.tabPage5.Controls.Add(this.pythondir_textboxlabel);
            this.tabPage5.Controls.Add(this.pythondir_textbox);
            this.tabPage5.Controls.Add(this.gpu_Checkbox);
            this.tabPage5.Controls.Add(this.cpu_Checkbox);
            this.tabPage5.Location = new System.Drawing.Point(4, 39);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(626, 387);
            this.tabPage5.TabIndex = 3;
            this.tabPage5.Text = "options";
            // 
            // pythondir_textboxlabel
            // 
            this.pythondir_textboxlabel.AutoSize = true;
            this.pythondir_textboxlabel.Location = new System.Drawing.Point(6, 55);
            this.pythondir_textboxlabel.Name = "pythondir_textboxlabel";
            this.pythondir_textboxlabel.Size = new System.Drawing.Size(210, 17);
            this.pythondir_textboxlabel.TabIndex = 4;
            this.pythondir_textboxlabel.Text = "Python Directory (numba required)";
            // 
            // pythondir_textbox
            // 
            this.pythondir_textbox.Location = new System.Drawing.Point(9, 73);
            this.pythondir_textbox.Name = "pythondir_textbox";
            this.pythondir_textbox.Size = new System.Drawing.Size(245, 25);
            this.pythondir_textbox.TabIndex = 3;
            this.pythondir_textbox.Text = "C:\\Users\\mooret\\Anaconda2";
            // 
            // gpu_Checkbox
            // 
            this.gpu_Checkbox.AutoSize = true;
            this.gpu_Checkbox.Checked = true;
            this.gpu_Checkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.gpu_Checkbox.Location = new System.Drawing.Point(9, 31);
            this.gpu_Checkbox.Name = "gpu_Checkbox";
            this.gpu_Checkbox.Size = new System.Drawing.Size(151, 21);
            this.gpu_Checkbox.TabIndex = 1;
            this.gpu_Checkbox.Text = "Run GPU Benchmarks";
            this.gpu_Checkbox.UseVisualStyleBackColor = true;
            // 
            // cpu_Checkbox
            // 
            this.cpu_Checkbox.AutoSize = true;
            this.cpu_Checkbox.Checked = true;
            this.cpu_Checkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cpu_Checkbox.Location = new System.Drawing.Point(9, 8);
            this.cpu_Checkbox.Name = "cpu_Checkbox";
            this.cpu_Checkbox.Size = new System.Drawing.Size(150, 21);
            this.cpu_Checkbox.TabIndex = 0;
            this.cpu_Checkbox.Text = "Run CPU Benchmarks";
            this.cpu_Checkbox.UseVisualStyleBackColor = true;
            // 
            // PC_CPU
            // 
            this.PC_CPU.CategoryName = "Processor";
            this.PC_CPU.CounterName = "% Processor Time";
            this.PC_CPU.InstanceName = "_Total";
            // 
            // graphtimer
            // 
            this.graphtimer.Interval = 1000;
            this.graphtimer.Tick += new System.EventHandler(this.graphtimer_Tick);
            // 
            // gui_BackgroundWorker
            // 
            this.gui_BackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.gui_BackgroundWorker_DoWork);
            this.gui_BackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.gui_BackgroundWorker_RunWorkerCompleted);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // cpudirectory_TextBox
            // 
            this.cpudirectory_TextBox.Location = new System.Drawing.Point(9, 137);
            this.cpudirectory_TextBox.Name = "cpudirectory_TextBox";
            this.cpudirectory_TextBox.Size = new System.Drawing.Size(245, 25);
            this.cpudirectory_TextBox.TabIndex = 5;
            // 
            // gpudirectory_TextBox
            // 
            this.gpudirectory_TextBox.Location = new System.Drawing.Point(9, 209);
            this.gpudirectory_TextBox.Name = "gpudirectory_TextBox";
            this.gpudirectory_TextBox.Size = new System.Drawing.Size(245, 25);
            this.gpudirectory_TextBox.TabIndex = 6;
            // 
            // cpudirectory_Label
            // 
            this.cpudirectory_Label.AutoSize = true;
            this.cpudirectory_Label.Location = new System.Drawing.Point(6, 117);
            this.cpudirectory_Label.Name = "cpudirectory_Label";
            this.cpudirectory_Label.Size = new System.Drawing.Size(204, 17);
            this.cpudirectory_Label.TabIndex = 7;
            this.cpudirectory_Label.Text = "Custom CPU Algorithms Directory";
            // 
            // gpudirectory_Label
            // 
            this.gpudirectory_Label.AutoSize = true;
            this.gpudirectory_Label.Location = new System.Drawing.Point(6, 189);
            this.gpudirectory_Label.Name = "gpudirectory_Label";
            this.gpudirectory_Label.Size = new System.Drawing.Size(205, 17);
            this.gpudirectory_Label.TabIndex = 8;
            this.gpudirectory_Label.Text = "Custom GPU Algorithms Directory";
            // 
            // cpualgorithms_Button
            // 
            this.cpualgorithms_Button.Location = new System.Drawing.Point(271, 137);
            this.cpualgorithms_Button.Name = "cpualgorithms_Button";
            this.cpualgorithms_Button.Size = new System.Drawing.Size(75, 25);
            this.cpualgorithms_Button.TabIndex = 9;
            this.cpualgorithms_Button.Text = "Browse";
            this.cpualgorithms_Button.UseVisualStyleBackColor = true;
            this.cpualgorithms_Button.Click += new System.EventHandler(this.cpualgorithms_Button_Click);
            // 
            // gpualgorithms_Button
            // 
            this.gpualgorithms_Button.Location = new System.Drawing.Point(271, 209);
            this.gpualgorithms_Button.Name = "gpualgorithms_Button";
            this.gpualgorithms_Button.Size = new System.Drawing.Size(75, 25);
            this.gpualgorithms_Button.TabIndex = 10;
            this.gpualgorithms_Button.Text = "Browse";
            this.gpualgorithms_Button.UseVisualStyleBackColor = true;
            this.gpualgorithms_Button.Click += new System.EventHandler(this.gpualgorithms_Button_Click);
            // 
            // pythondirectory_Button
            // 
            this.pythondirectory_Button.Location = new System.Drawing.Point(271, 72);
            this.pythondirectory_Button.Name = "pythondirectory_Button";
            this.pythondirectory_Button.Size = new System.Drawing.Size(75, 25);
            this.pythondirectory_Button.TabIndex = 11;
            this.pythondirectory_Button.Text = "Browse";
            this.pythondirectory_Button.UseVisualStyleBackColor = true;
            this.pythondirectory_Button.Click += new System.EventHandler(this.pythondirectory_Button_Click);
            // 
            // BenchmarkingUtilityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.tabControl1);
            this.Name = "BenchmarkingUtilityForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.BenchmarkingUtilityForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.results_dataGridView)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PC_CPU)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label gpu_Label;
        private System.Windows.Forms.Label cpu_Label;
        private System.Windows.Forms.Button run_button;
        private System.Windows.Forms.CheckBox gpu_Checkbox;
        private System.Windows.Forms.CheckBox cpu_Checkbox;
        private System.Windows.Forms.Label pythondir_textboxlabel;
        private System.Windows.Forms.TextBox pythondir_textbox;
        private System.Windows.Forms.Label cpuoutput_Label;
        private System.Windows.Forms.Label gpuoutput_Label;
        private System.Windows.Forms.RichTextBox cpuscript_TextBox;
        private System.Windows.Forms.ComboBox scriptviewer_ComboBox;
        private System.Windows.Forms.RichTextBox gpuscript_TextBox;
        private System.Windows.Forms.Label cpuThreads_Label;
        private System.Windows.Forms.Label cpuCores_Label;
        private System.Windows.Forms.Label cpuFrequency_Label;
        private System.Windows.Forms.Button info_Button;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Diagnostics.PerformanceCounter PC_CPU;
        private System.Windows.Forms.ProgressBar cpu_progressbar;
        private System.Windows.Forms.Timer graphtimer;
        private System.Windows.Forms.ProgressBar gpu_progressbar;
        private System.Windows.Forms.Label gpu_percentage1;
        private System.Windows.Forms.Label cpu_percentage1;
        private System.ComponentModel.BackgroundWorker gui_BackgroundWorker;
        private System.Windows.Forms.Panel algorithmmatches_Panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button resultstable_Button;
        private System.Windows.Forms.TextBox resultstable_TextBox;
        private System.Windows.Forms.DataGridView results_dataGridView;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label staticgpuCores_Frequency;
        private System.Windows.Forms.Label staticgpuFrequency_Label;
        private System.Windows.Forms.Label gpuCores_Label;
        private System.Windows.Forms.Label gpuFrequency_Label;
        private System.Windows.Forms.Label staticcpuThreads_Label;
        private System.Windows.Forms.Label staticcpuCores_Label;
        private System.Windows.Forms.Label staticcpuFrequency_Label;
        private System.Windows.Forms.Label gpuName_Label;
        private System.Windows.Forms.Label cpuName_Label;
        private System.Windows.Forms.Label os_Label;
        private System.Windows.Forms.Label staticgpuTMU_Label;
        private System.Windows.Forms.Label gpuTMU_Label;
        private System.Windows.Forms.Label gpudirectory_Label;
        private System.Windows.Forms.Label cpudirectory_Label;
        private System.Windows.Forms.TextBox gpudirectory_TextBox;
        private System.Windows.Forms.TextBox cpudirectory_TextBox;
        private System.Windows.Forms.Button gpualgorithms_Button;
        private System.Windows.Forms.Button cpualgorithms_Button;
        private System.Windows.Forms.Button pythondirectory_Button;
    }
}

