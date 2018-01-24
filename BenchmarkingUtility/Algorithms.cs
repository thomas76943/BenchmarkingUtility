using System;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.CodeDom.Compiler;

namespace BenchmarkingUtility
{
    class Algorithms
    {
        //File Paths for Algorithms
        public static string[] cpupaths = Directory.GetFiles(Path.Combine(Application.StartupPath, @"CPUAlgorithms\"));
        public static string[] gpupaths = Directory.GetFiles(Path.Combine(Application.StartupPath, @"GPUAlgorithms\"));
        ///
        /// ///
        /// <summary>
        /// Runs and Retreives output of Python scripts
        /// </summary>
        /// <param name="pythondirectory">Location of Python Interpreter</param>
        /// <param name="pythonfile">The Chosen Benchmark Algorithm Script</param>
        /// <returns></returns>
        public static string RunPython(string pythondirectory, string pythonfile)
        {

            try
            {
                //Initialise Path to be Used by The Process [Combines Python Script with Python Directory]
                string path = Path.Combine(pythondirectory, "python.exe");

                //Relevant Startup Options are Defined [No Shell, No Window, Output Redirected etc]
                ProcessStartInfo psi = new ProcessStartInfo();
                psi.UseShellExecute = false;
                psi.RedirectStandardOutput = true;
                psi.FileName = path;
                psi.Arguments = pythonfile;
                psi.RedirectStandardError = true;
                psi.CreateNoWindow = true;

                //Python Process Starts - Reads and Returns Script's Output [in addition to Standard Error]
                using (Process p = Process.Start(psi))
                {
                    string stderr = p.StandardError.ReadToEnd();
                    string finaloutput = p.StandardOutput.ReadToEnd();
                    Debug.WriteLine("stderr: " + stderr + "\nTime: ");
                    return finaloutput;
                }
            }
            //User Notified if Process Failed
            catch (Exception)
            {
                Console.WriteLine("Failed");
            }
            return "Failed";
        }

        public static void RunCS()
        {

        }

    }
}
