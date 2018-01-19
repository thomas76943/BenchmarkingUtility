﻿namespace BenchmarkingUtility
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BenchmarkingUtilityForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gpuoutput_Label = new System.Windows.Forms.Label();
            this.cpuoutput_Label = new System.Windows.Forms.Label();
            this.run_button = new System.Windows.Forms.Button();
            this.gpu_Label = new System.Windows.Forms.Label();
            this.cpu_Label = new System.Windows.Forms.Label();
            this.algorithm4_Radio = new System.Windows.Forms.RadioButton();
            this.algorithm3_Radio = new System.Windows.Forms.RadioButton();
            this.algorithm2_Radio = new System.Windows.Forms.RadioButton();
            this.algorithm1_Radio = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.memory_Label = new System.Windows.Forms.Label();
            this.cpuclock_Label = new System.Windows.Forms.Label();
            this.cpumake_Label = new System.Windows.Forms.Label();
            this.cpuid_Label = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.scriptviewer_Button = new System.Windows.Forms.Button();
            this.gpuscript_TextBox = new System.Windows.Forms.RichTextBox();
            this.cpuscript_TextBox = new System.Windows.Forms.RichTextBox();
            this.scriptviewer_ComboBox = new System.Windows.Forms.ComboBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.pythondir_textboxlabel = new System.Windows.Forms.Label();
            this.pythondir_textbox = new System.Windows.Forms.TextBox();
            this.textfilewrite_Checkbox = new System.Windows.Forms.CheckBox();
            this.gpu_Checkbox = new System.Windows.Forms.CheckBox();
            this.cpu_Checkbox = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(148, 35);
            this.tabControl1.Location = new System.Drawing.Point(-1, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(634, 430);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.gpuoutput_Label);
            this.tabPage1.Controls.Add(this.cpuoutput_Label);
            this.tabPage1.Controls.Add(this.run_button);
            this.tabPage1.Controls.Add(this.gpu_Label);
            this.tabPage1.Controls.Add(this.cpu_Label);
            this.tabPage1.Controls.Add(this.algorithm4_Radio);
            this.tabPage1.Controls.Add(this.algorithm3_Radio);
            this.tabPage1.Controls.Add(this.algorithm2_Radio);
            this.tabPage1.Controls.Add(this.algorithm1_Radio);
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(626, 387);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "home";
            // 
            // gpuoutput_Label
            // 
            this.gpuoutput_Label.AutoSize = true;
            this.gpuoutput_Label.Location = new System.Drawing.Point(275, 227);
            this.gpuoutput_Label.Name = "gpuoutput_Label";
            this.gpuoutput_Label.Size = new System.Drawing.Size(0, 16);
            this.gpuoutput_Label.TabIndex = 10;
            // 
            // cpuoutput_Label
            // 
            this.cpuoutput_Label.AutoSize = true;
            this.cpuoutput_Label.Location = new System.Drawing.Point(7, 227);
            this.cpuoutput_Label.Name = "cpuoutput_Label";
            this.cpuoutput_Label.Size = new System.Drawing.Size(0, 16);
            this.cpuoutput_Label.TabIndex = 9;
            // 
            // run_button
            // 
            this.run_button.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.run_button.Location = new System.Drawing.Point(531, 69);
            this.run_button.Name = "run_button";
            this.run_button.Size = new System.Drawing.Size(75, 32);
            this.run_button.TabIndex = 8;
            this.run_button.Text = "Run";
            this.run_button.UseVisualStyleBackColor = true;
            this.run_button.Click += new System.EventHandler(this.run_button_Click);
            // 
            // gpu_Label
            // 
            this.gpu_Label.AutoSize = true;
            this.gpu_Label.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpu_Label.Location = new System.Drawing.Point(275, 153);
            this.gpu_Label.Name = "gpu_Label";
            this.gpu_Label.Size = new System.Drawing.Size(42, 18);
            this.gpu_Label.TabIndex = 7;
            this.gpu_Label.Text = "GPU";
            // 
            // cpu_Label
            // 
            this.cpu_Label.AutoSize = true;
            this.cpu_Label.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpu_Label.Location = new System.Drawing.Point(7, 153);
            this.cpu_Label.Name = "cpu_Label";
            this.cpu_Label.Size = new System.Drawing.Size(41, 18);
            this.cpu_Label.TabIndex = 6;
            this.cpu_Label.Text = "CPU";
            // 
            // algorithm4_Radio
            // 
            this.algorithm4_Radio.AutoSize = true;
            this.algorithm4_Radio.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.algorithm4_Radio.Location = new System.Drawing.Point(10, 79);
            this.algorithm4_Radio.Name = "algorithm4_Radio";
            this.algorithm4_Radio.Size = new System.Drawing.Size(121, 22);
            this.algorithm4_Radio.TabIndex = 3;
            this.algorithm4_Radio.Text = "Algorithm 4";
            this.algorithm4_Radio.UseVisualStyleBackColor = true;
            this.algorithm4_Radio.Click += new System.EventHandler(this.algorithm4_Radio_Click);
            // 
            // algorithm3_Radio
            // 
            this.algorithm3_Radio.AutoSize = true;
            this.algorithm3_Radio.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.algorithm3_Radio.Location = new System.Drawing.Point(10, 55);
            this.algorithm3_Radio.Name = "algorithm3_Radio";
            this.algorithm3_Radio.Size = new System.Drawing.Size(121, 22);
            this.algorithm3_Radio.TabIndex = 2;
            this.algorithm3_Radio.TabStop = true;
            this.algorithm3_Radio.Text = "Algorithm 3";
            this.algorithm3_Radio.UseVisualStyleBackColor = true;
            this.algorithm3_Radio.Click += new System.EventHandler(this.algorithm3_Radio_Click);
            // 
            // algorithm2_Radio
            // 
            this.algorithm2_Radio.AutoSize = true;
            this.algorithm2_Radio.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.algorithm2_Radio.Location = new System.Drawing.Point(10, 31);
            this.algorithm2_Radio.Name = "algorithm2_Radio";
            this.algorithm2_Radio.Size = new System.Drawing.Size(121, 22);
            this.algorithm2_Radio.TabIndex = 1;
            this.algorithm2_Radio.TabStop = true;
            this.algorithm2_Radio.Text = "Algorithm 2";
            this.algorithm2_Radio.UseVisualStyleBackColor = true;
            this.algorithm2_Radio.Click += new System.EventHandler(this.algorithm2_Radio_Click);
            // 
            // algorithm1_Radio
            // 
            this.algorithm1_Radio.AutoSize = true;
            this.algorithm1_Radio.Checked = true;
            this.algorithm1_Radio.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.algorithm1_Radio.Location = new System.Drawing.Point(10, 7);
            this.algorithm1_Radio.Name = "algorithm1_Radio";
            this.algorithm1_Radio.Size = new System.Drawing.Size(172, 22);
            this.algorithm1_Radio.TabIndex = 0;
            this.algorithm1_Radio.TabStop = true;
            this.algorithm1_Radio.Text = "Python + PyCUDA";
            this.algorithm1_Radio.UseVisualStyleBackColor = true;
            this.algorithm1_Radio.Click += new System.EventHandler(this.algorithm1_Radio_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.button1);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(300, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // memory_Label
            // 
            this.memory_Label.AutoSize = true;
            this.memory_Label.Location = new System.Drawing.Point(9, 107);
            this.memory_Label.Name = "memory_Label";
            this.memory_Label.Size = new System.Drawing.Size(45, 16);
            this.memory_Label.TabIndex = 3;
            this.memory_Label.Text = "label1";
            // 
            // cpuclock_Label
            // 
            this.cpuclock_Label.AutoSize = true;
            this.cpuclock_Label.Location = new System.Drawing.Point(9, 65);
            this.cpuclock_Label.Name = "cpuclock_Label";
            this.cpuclock_Label.Size = new System.Drawing.Size(45, 16);
            this.cpuclock_Label.TabIndex = 2;
            this.cpuclock_Label.Text = "label1";
            // 
            // cpumake_Label
            // 
            this.cpumake_Label.AutoSize = true;
            this.cpumake_Label.Location = new System.Drawing.Point(9, 30);
            this.cpumake_Label.Name = "cpumake_Label";
            this.cpumake_Label.Size = new System.Drawing.Size(45, 16);
            this.cpumake_Label.TabIndex = 1;
            this.cpumake_Label.Text = "label1";
            // 
            // cpuid_Label
            // 
            this.cpuid_Label.AutoSize = true;
            this.cpuid_Label.Location = new System.Drawing.Point(9, 3);
            this.cpuid_Label.Name = "cpuid_Label";
            this.cpuid_Label.Size = new System.Drawing.Size(45, 16);
            this.cpuid_Label.TabIndex = 0;
            this.cpuid_Label.Text = "label1";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.scriptviewer_Button);
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
            // scriptviewer_Button
            // 
            this.scriptviewer_Button.Location = new System.Drawing.Point(177, 7);
            this.scriptviewer_Button.Name = "scriptviewer_Button";
            this.scriptviewer_Button.Size = new System.Drawing.Size(75, 23);
            this.scriptviewer_Button.TabIndex = 3;
            this.scriptviewer_Button.Text = "button2";
            this.scriptviewer_Button.UseVisualStyleBackColor = true;
            // 
            // gpuscript_TextBox
            // 
            this.gpuscript_TextBox.Location = new System.Drawing.Point(314, 33);
            this.gpuscript_TextBox.Name = "gpuscript_TextBox";
            this.gpuscript_TextBox.ReadOnly = true;
            this.gpuscript_TextBox.Size = new System.Drawing.Size(305, 358);
            this.gpuscript_TextBox.TabIndex = 2;
            this.gpuscript_TextBox.Text = resources.GetString("gpuscript_TextBox.Text");
            // 
            // cpuscript_TextBox
            // 
            this.cpuscript_TextBox.Location = new System.Drawing.Point(3, 33);
            this.cpuscript_TextBox.Name = "cpuscript_TextBox";
            this.cpuscript_TextBox.ReadOnly = true;
            this.cpuscript_TextBox.Size = new System.Drawing.Size(305, 358);
            this.cpuscript_TextBox.TabIndex = 1;
            this.cpuscript_TextBox.Text = resources.GetString("cpuscript_TextBox.Text");
            // 
            // scriptviewer_ComboBox
            // 
            this.scriptviewer_ComboBox.FormattingEnabled = true;
            this.scriptviewer_ComboBox.Items.AddRange(new object[] {
            "Python + PyCUDA",
            "Algorithm 2",
            "Algorithm 3",
            "Algorithm 4"});
            this.scriptviewer_ComboBox.Location = new System.Drawing.Point(3, 6);
            this.scriptviewer_ComboBox.Name = "scriptviewer_ComboBox";
            this.scriptviewer_ComboBox.Size = new System.Drawing.Size(168, 24);
            this.scriptviewer_ComboBox.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.White;
            this.tabPage4.Controls.Add(this.pythondir_textboxlabel);
            this.tabPage4.Controls.Add(this.pythondir_textbox);
            this.tabPage4.Controls.Add(this.textfilewrite_Checkbox);
            this.tabPage4.Controls.Add(this.gpu_Checkbox);
            this.tabPage4.Controls.Add(this.cpu_Checkbox);
            this.tabPage4.Location = new System.Drawing.Point(4, 39);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(626, 387);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "options";
            // 
            // pythondir_textboxlabel
            // 
            this.pythondir_textboxlabel.AutoSize = true;
            this.pythondir_textboxlabel.Location = new System.Drawing.Point(6, 98);
            this.pythondir_textboxlabel.Name = "pythondir_textboxlabel";
            this.pythondir_textboxlabel.Size = new System.Drawing.Size(264, 16);
            this.pythondir_textboxlabel.TabIndex = 4;
            this.pythondir_textboxlabel.Text = "Python Directory (numpy + numba required)";
            // 
            // pythondir_textbox
            // 
            this.pythondir_textbox.Location = new System.Drawing.Point(9, 114);
            this.pythondir_textbox.Name = "pythondir_textbox";
            this.pythondir_textbox.Size = new System.Drawing.Size(245, 22);
            this.pythondir_textbox.TabIndex = 3;
            this.pythondir_textbox.Text = "C:\\Users\\mooret\\Anaconda2";
            // 
            // textfilewrite_Checkbox
            // 
            this.textfilewrite_Checkbox.AutoSize = true;
            this.textfilewrite_Checkbox.Location = new System.Drawing.Point(9, 54);
            this.textfilewrite_Checkbox.Name = "textfilewrite_Checkbox";
            this.textfilewrite_Checkbox.Size = new System.Drawing.Size(132, 20);
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
            this.gpu_Checkbox.Size = new System.Drawing.Size(161, 20);
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
            this.cpu_Checkbox.Size = new System.Drawing.Size(160, 20);
            this.cpu_Checkbox.TabIndex = 0;
            this.cpu_Checkbox.Text = "Run CPU Benchmarks";
            this.cpu_Checkbox.UseVisualStyleBackColor = true;
            // 
            // BenchmarkingUtilityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.tabControl1);
            this.Name = "BenchmarkingUtilityForm";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.RadioButton algorithm4_Radio;
        private System.Windows.Forms.RadioButton algorithm3_Radio;
        private System.Windows.Forms.RadioButton algorithm2_Radio;
        private System.Windows.Forms.RadioButton algorithm1_Radio;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button scriptviewer_Button;
    }
}
