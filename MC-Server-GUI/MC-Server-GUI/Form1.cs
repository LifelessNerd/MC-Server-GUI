using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MC_Server_GUI
{
    public partial class RunEnvironmentForm : Form
    {
        Process cmdProcess = null;
        StreamWriter stdin = null;
        public RunEnvironmentForm()
        {
            InitializeComponent();
            serverOutput.ReadOnly = true;

        }

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartCmdProcess();
        }

        private void StartCmdProcess()
        {
            var pStartInfo = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                // Batch File Arguments = "/C START /b /WAIT somebatch.bat",
                // Test: Arguments = "START /WAIT /K ipconfig /all",
                Arguments = "START /WAIT",
                WorkingDirectory = Environment.SystemDirectory,
                // WorkingDirectory = Application.StartupPath,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                RedirectStandardInput = true,
                UseShellExecute = false,
                CreateNoWindow = true,
                WindowStyle = ProcessWindowStyle.Hidden,
            };

            cmdProcess = new Process
            {
                StartInfo = pStartInfo,
                EnableRaisingEvents = true,
                // Test without and with this
                // When SynchronizingObject is set, no need to BeginInvoke()
                //SynchronizingObject = this
            };

            cmdProcess.Start();
            cmdProcess.BeginErrorReadLine();
            cmdProcess.BeginOutputReadLine();
            stdin = cmdProcess.StandardInput;
            // stdin.AutoFlush = true;  <- already true
            stdin.Write("cd C:\\Users\\Menee\\Desktop\\JavaSample\\out\\artifacts\\JavaSample_jar" + Environment.NewLine);
            stdin.Write("java -jar JavaSample.jar" + Environment.NewLine);

            rtbInput.Multiline = true;
            

            cmdProcess.OutputDataReceived += (s, evt) => {
                if (evt.Data != null)
                {
                    
                    BeginInvoke(new MethodInvoker(() => {

                        if (!(evt.Data.Contains(">"))) //TODO: might cause problems later
                        {
                            serverOutput.AppendText(evt.Data + Environment.NewLine);
                            serverOutput.ScrollToCaret();
                        }
                    }));
                }
            };

            cmdProcess.ErrorDataReceived += (s, evt) => {
                if (evt.Data != null)
                {
                    BeginInvoke(new Action(() => {
                        serverOutput.SelectionColor = Color.Red;
                        serverOutput.AppendText(evt.Data + Environment.NewLine);
                        serverOutput.ScrollToCaret();
                        
                    }));
                }
            };

            cmdProcess.Exited += (s, evt) => {
                stdin?.Dispose();
                cmdProcess?.Dispose();
            };


        }

        private void EnterPressed(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (stdin == null)
                {
                    serverOutput.AppendText("Process not started" + Environment.NewLine);
                    return;
                }

                e.Handled = true;
                if (stdin.BaseStream.CanWrite)
                {
                    stdin.Write(rtbInput.Text + Environment.NewLine);
                    serverOutput.AppendText("> " + rtbInput.Text + Environment.NewLine);
                    // To write to a Console app, just 
                    // stdin.WriteLine(rtbStdIn.Text); 
                }
                rtbInput.Clear();
            }
        }
    }
}
