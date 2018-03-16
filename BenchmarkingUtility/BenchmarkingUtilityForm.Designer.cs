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
            this.info_Button = new System.Windows.Forms.Button();
            this.memory_Label = new System.Windows.Forms.Label();
            this.cpuclock_Label = new System.Windows.Forms.Label();
            this.cpumake_Label = new System.Windows.Forms.Label();
            this.cpuid_Label = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.gpuscript_TextBox = new System.Windows.Forms.RichTextBox();
            this.cpuscript_TextBox = new System.Windows.Forms.RichTextBox();
            this.scriptviewer_ComboBox = new System.Windows.Forms.ComboBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.pythondir_textboxlabel = new System.Windows.Forms.Label();
            this.pythondir_textbox = new System.Windows.Forms.TextBox();
            this.textfilewrite_Checkbox = new System.Windows.Forms.CheckBox();
            this.gpu_Checkbox = new System.Windows.Forms.CheckBox();
            this.cpu_Checkbox = new System.Windows.Forms.CheckBox();
            this.PC_CPU = new System.Diagnostics.PerformanceCounter();
            this.PC_GPU = new System.Diagnostics.PerformanceCounter();
            this.graphtimer = new System.Windows.Forms.Timer(this.components);
            this.gui_BackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.resultstable_Button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.resultstablepath_Input = new System.Windows.Forms.Label();
            this.results_dataGridView = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PC_CPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PC_GPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.results_dataGridView)).BeginInit();
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
            this.gpuoutput_Label.Size = new System.Drawing.Size(97, 17);
            this.gpuoutput_Label.TabIndex = 10;
            this.gpuoutput_Label.Text = "gpuoutputlabel";
            // 
            // cpuoutput_Label
            // 
            this.cpuoutput_Label.AutoSize = true;
            this.cpuoutput_Label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuoutput_Label.Location = new System.Drawing.Point(346, 66);
            this.cpuoutput_Label.Name = "cpuoutput_Label";
            this.cpuoutput_Label.Size = new System.Drawing.Size(95, 17);
            this.cpuoutput_Label.TabIndex = 9;
            this.cpuoutput_Label.Text = "cpuoutputlabel";
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
            this.tabPage2.Controls.Add(this.info_Button);
            this.tabPage2.Controls.Add(this.memory_Label);
            this.tabPage2.Controls.Add(this.cpuclock_Label);
            this.tabPage2.Controls.Add(this.cpumake_Label);
            this.tabPage2.Controls.Add(this.cpuid_Label);
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(626, 387);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "info";
            // 
            // info_Button
            // 
            this.info_Button.Location = new System.Drawing.Point(300, 200);
            this.info_Button.Name = "info_Button";
            this.info_Button.Size = new System.Drawing.Size(75, 23);
            this.info_Button.TabIndex = 4;
            this.info_Button.Text = "button1";
            this.info_Button.UseVisualStyleBackColor = true;
            this.info_Button.Click += new System.EventHandler(this.info_Button_Click);
            // 
            // memory_Label
            // 
            this.memory_Label.AutoSize = true;
            this.memory_Label.Location = new System.Drawing.Point(9, 107);
            this.memory_Label.Name = "memory_Label";
            this.memory_Label.Size = new System.Drawing.Size(43, 17);
            this.memory_Label.TabIndex = 3;
            this.memory_Label.Text = "label1";
            // 
            // cpuclock_Label
            // 
            this.cpuclock_Label.AutoSize = true;
            this.cpuclock_Label.Location = new System.Drawing.Point(9, 65);
            this.cpuclock_Label.Name = "cpuclock_Label";
            this.cpuclock_Label.Size = new System.Drawing.Size(43, 17);
            this.cpuclock_Label.TabIndex = 2;
            this.cpuclock_Label.Text = "label1";
            // 
            // cpumake_Label
            // 
            this.cpumake_Label.AutoSize = true;
            this.cpumake_Label.Location = new System.Drawing.Point(9, 30);
            this.cpumake_Label.Name = "cpumake_Label";
            this.cpumake_Label.Size = new System.Drawing.Size(43, 17);
            this.cpumake_Label.TabIndex = 1;
            this.cpumake_Label.Text = "label1";
            // 
            // cpuid_Label
            // 
            this.cpuid_Label.AutoSize = true;
            this.cpuid_Label.Location = new System.Drawing.Point(9, 3);
            this.cpuid_Label.Name = "cpuid_Label";
            this.cpuid_Label.Size = new System.Drawing.Size(43, 17);
            this.cpuid_Label.TabIndex = 0;
            this.cpuid_Label.Text = "label1";
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
            this.tabPage4.Controls.Add(this.resultstablepath_Input);
            this.tabPage4.Controls.Add(this.textBox1);
            this.tabPage4.Controls.Add(this.resultstable_Button);
            this.tabPage4.Location = new System.Drawing.Point(4, 39);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(626, 387);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "results";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.White;
            this.tabPage5.Controls.Add(this.pythondir_textboxlabel);
            this.tabPage5.Controls.Add(this.pythondir_textbox);
            this.tabPage5.Controls.Add(this.textfilewrite_Checkbox);
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
            this.pythondir_textboxlabel.Location = new System.Drawing.Point(6, 98);
            this.pythondir_textboxlabel.Name = "pythondir_textboxlabel";
            this.pythondir_textboxlabel.Size = new System.Drawing.Size(266, 17);
            this.pythondir_textboxlabel.TabIndex = 4;
            this.pythondir_textboxlabel.Text = "Python Directory (numpy + numba required)";
            // 
            // pythondir_textbox
            // 
            this.pythondir_textbox.Location = new System.Drawing.Point(9, 116);
            this.pythondir_textbox.Name = "pythondir_textbox";
            this.pythondir_textbox.Size = new System.Drawing.Size(245, 25);
            this.pythondir_textbox.TabIndex = 3;
            this.pythondir_textbox.Text = "C:\\Users\\mooret\\Anaconda2";
            // 
            // textfilewrite_Checkbox
            // 
            this.textfilewrite_Checkbox.AutoSize = true;
            this.textfilewrite_Checkbox.Location = new System.Drawing.Point(9, 54);
            this.textfilewrite_Checkbox.Name = "textfilewrite_Checkbox";
            this.textfilewrite_Checkbox.Size = new System.Drawing.Size(126, 21);
            this.textfilewrite_Checkbox.TabIndex = 2;
            this.textfilewrite_Checkbox.Text = "Write To Text File";
            this.textfilewrite_Checkbox.UseVisualStyleBackColor = true;
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
            // PC_GPU
            // 
            this.PC_GPU.CategoryName = "GPU Engine";
            this.PC_GPU.CounterName = "Utilization Percentage";
            this.PC_GPU.InstanceName = "_Total";
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
            // resultstable_Button
            // 
            this.resultstable_Button.Location = new System.Drawing.Point(380, 3);
            this.resultstable_Button.Name = "resultstable_Button";
            this.resultstable_Button.Size = new System.Drawing.Size(114, 25);
            this.resultstable_Button.TabIndex = 0;
            this.resultstable_Button.Text = "Load Results";
            this.resultstable_Button.UseVisualStyleBackColor = true;
            this.resultstable_Button.Click += new System.EventHandler(this.resultstable_Button_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(141, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(233, 25);
            this.textBox1.TabIndex = 1;
            // 
            // resultstablepath_Input
            // 
            this.resultstablepath_Input.AutoSize = true;
            this.resultstablepath_Input.Location = new System.Drawing.Point(3, 6);
            this.resultstablepath_Input.Name = "resultstablepath_Input";
            this.resultstablepath_Input.Size = new System.Drawing.Size(132, 17);
            this.resultstablepath_Input.TabIndex = 2;
            this.resultstablepath_Input.Text = "Path to Results Table:";
            // 
            // results_dataGridView
            // 
            this.results_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.results_dataGridView.Location = new System.Drawing.Point(6, 50);
            this.results_dataGridView.Name = "results_dataGridView";
            this.results_dataGridView.Size = new System.Drawing.Size(592, 317);
            this.results_dataGridView.TabIndex = 3;
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
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PC_CPU)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.PC_GPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.results_dataGridView)).EndInit();
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
        private System.Windows.Forms.CheckBox textfilewrite_Checkbox;
        private System.Windows.Forms.CheckBox gpu_Checkbox;
        private System.Windows.Forms.CheckBox cpu_Checkbox;
        private System.Windows.Forms.Label pythondir_textboxlabel;
        private System.Windows.Forms.TextBox pythondir_textbox;
        private System.Windows.Forms.Label cpuoutput_Label;
        private System.Windows.Forms.Label gpuoutput_Label;
        private System.Windows.Forms.RichTextBox cpuscript_TextBox;
        private System.Windows.Forms.ComboBox scriptviewer_ComboBox;
        private System.Windows.Forms.RichTextBox gpuscript_TextBox;
        private System.Windows.Forms.Label memory_Label;
        private System.Windows.Forms.Label cpuclock_Label;
        private System.Windows.Forms.Label cpumake_Label;
        private System.Windows.Forms.Label cpuid_Label;
        private System.Windows.Forms.Button info_Button;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Diagnostics.PerformanceCounter PC_CPU;
        private System.Windows.Forms.ProgressBar cpu_progressbar;
        private System.Diagnostics.PerformanceCounter PC_GPU;
        private System.Windows.Forms.Timer graphtimer;
        private System.Windows.Forms.ProgressBar gpu_progressbar;
        private System.Windows.Forms.Label gpu_percentage1;
        private System.Windows.Forms.Label cpu_percentage1;
        private System.ComponentModel.BackgroundWorker gui_BackgroundWorker;
        private System.Windows.Forms.Panel algorithmmatches_Panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button resultstable_Button;
        private System.Windows.Forms.Label resultstablepath_Input;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView results_dataGridView;
    }
}

