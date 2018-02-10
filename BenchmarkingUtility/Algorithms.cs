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
                //Initialise Path to be Used by The Process [Combines Python Script with Python Directory to Launch Benchmark]
                string path = Path.Combine(pythondirectory+"\\python.exe");
                
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
        
        public static string RunCS(string csfile)
        {
            try
            {
                BuildCS(csfile);
                ProcessStartInfo psi = new ProcessStartInfo();
                psi.UseShellExecute = false;
                psi.RedirectStandardOutput = true;
                psi.FileName = "CSharpCompiledCode.exe";
                psi.RedirectStandardError = true;
                psi.CreateNoWindow = true;
                using (Process p = Process.Start(psi))
                {
                    string finaloutput = p.StandardOutput.ReadToEnd();
                    Debug.WriteLine(finaloutput);
                    return finaloutput;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("C# Run Failed");
            }
            return "C# Run Failed";
        }

        private static void BuildCS(string csfile)
        {
            try
            {
                CodeDomProvider codeProvider = CodeDomProvider.CreateProvider("CSharp");
                CompilerParameters parameters = new CompilerParameters
                {
                    GenerateExecutable = true,
                    OutputAssembly = "CSharpCompiledCode.exe"
                };
                CompilerResults results = codeProvider.CompileAssemblyFromSource(parameters, File.ReadAllText(csfile));

                if (results.Errors.Count > 0)
                {
                    foreach (CompilerError CompErr in results.Errors)
                    {
                        Console.WriteLine("Line number " + CompErr.Line + ", Error Number: " + CompErr.ErrorNumber + ", '" + CompErr.ErrorText + ";" + Environment.NewLine + Environment.NewLine);
                    }
                }
            }

            catch (Exception)
            {
                Console.WriteLine("C# Build Failed");
            }
        }
    }
}
