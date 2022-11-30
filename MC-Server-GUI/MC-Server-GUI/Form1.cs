using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MC_Server_GUI
{
    public partial class RunEnvironmentForm : Form
    {
        Process cmdProcess = null;
        StreamWriter input = null;

        String ip;
        bool ipHidden = true;

        List<String> onlinePlayers = new List<String>();

        List<String> inputHistory = new List<String>();
        int historyIndex = 0;

        public RunEnvironmentForm()
        {
            InitializeComponent();
            serverOutput.ReadOnly = true;

            inputHistory.Add("dab");
            inputHistory.Add("dab2");
            int historyIndex = inputHistory.Count;

        }
            MyUserSettings mus;

        //https://learn.microsoft.com/en-us/dotnet/desktop/winforms/advanced/how-to-create-application-settings?view=netframeworkdesktop-4.8
        // Saving settings and sjit
        private void RunEnvironmentForm_Load(object sender, EventArgs e)
        {
            mus = new MyUserSettings();
            //mus.BackgroundColor = Color.Black; // This is how you set settings, these are persistent
            this.DataBindings.Add(new Binding("BackColor", mus, "BackgroundColor"));
            Console.WriteLine("Loaded settings");
        }
        void RunEnvironmentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Console.WriteLine("test");
            mus.Save();
        }

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartCmdProcess();
        }
        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stopServer();
        }
        private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (input == null)
            {
                serverOutput.AppendText("Process not started" + Environment.NewLine);
                return;
            }
            else
            {
                input.WriteLine("reload confirm" + Environment.NewLine);
            }
        }

        private void StartCmdProcess()
        {
            serverOutput.SelectionColor = Color.Green;
            serverOutput.AppendText("STARTING SERVER..." + Environment.NewLine);
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

            //Update IP field
            try
            {
                string thingy = new WebClient().DownloadString("http://checkip.dyndns.org");
                string[] ipSplit = thingy.Split(' ');
                ip = ipSplit[ipSplit.Length - 1];
                ipSplit = ip.Split('<');
                ip = ipSplit[0];
                rtbIP.Text = ip + ":25565"; //TODO: change based on properties.txt
            } catch (Exception e)
            {
                rtbIP.Text = e.Message;
            }

            cmdProcess = new Process
            {
                StartInfo = pStartInfo,
                EnableRaisingEvents = true,

            };

            cmdProcess.Start();
            cmdProcess.BeginErrorReadLine();
            cmdProcess.BeginOutputReadLine();
            input = cmdProcess.StandardInput;
            // stdin.AutoFlush = true;  <- already true
            input.Write("cd C:\\Users\\Menee\\Desktop\\Minecraft Server Plugin Tester 1.19" + Environment.NewLine);
            //stdin.Write("java -Xmx2048M -Xms2048M -jar paper-1.19.2-263.jar -nogui" + Environment.NewLine);
            input.Write("java -jar JavaSample.jar" + Environment.NewLine);

            rtbInput.Multiline = true;

            cmdProcess.OutputDataReceived += this.InputReceived;

            cmdProcess.Exited += (s, evt) => {
                input?.Dispose();
                cmdProcess?.Dispose();
            };

        }

        private void InputReceived(object o, DataReceivedEventArgs evt){
            if (evt.Data != null)
            {

                BeginInvoke(new MethodInvoker(() => {

                    if (!(evt.Data.Contains(">"))) //TODO: might cause problems later
                    {
                        serverOutput.AppendText(evt.Data + Environment.NewLine);
                        serverOutput.ScrollToCaret();
                    }

                    if (evt.Data.Contains("joined the game"))
                    {
                        String[] dataSplit = evt.Data.Split(' ');
                        onlinePlayers.Add(dataSplit[dataSplit.Length - 4]);
                        updatePlayerList();
                    }
                    else if (evt.Data.Contains("left the game"))
                    {
                        String[] dataSplit = evt.Data.Split(' ');
                        onlinePlayers.Remove(dataSplit[dataSplit.Length - 4]);
                        updatePlayerList();
                    }

                }));
            }
        }

        private void updatePlayerList()
        {
            onlinePlayersListBox.Items.Clear();
            foreach (String player in onlinePlayers)
            {
                onlinePlayersListBox.Items.Add(player);
            }

        }


        private void EnterPressed(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {
                if (input == null)
                {
                    serverOutput.AppendText("Process not started" + Environment.NewLine);
                    return;
                }
                historyIndex = inputHistory.Count;
                e.Handled = true;
                if (input.BaseStream.CanWrite)
                {
                    string rtbInputText = rtbInput.Text;
                    rtbInputText = rtbInputText.Replace("\n", "");
                    input.Write(rtbInputText + Environment.NewLine);
                    inputHistory.Add(rtbInputText);
                    historyIndex = inputHistory.Count;
                    serverOutput.AppendText("> " + rtbInputText + Environment.NewLine);
                    // To write to a Console app, just 
                    // stdin.WriteLine(rtbStdIn.Text); 
                    checkCustomKeywords();
                    
                }
                rtbInput.Clear();
            }
            

        }
        private void CheckUpDown(object sender, KeyEventArgs e)
        {
           
            if (e.KeyCode == Keys.Up)
            {
                if (historyIndex - 1 >= 0) {
                    rtbInput.Multiline = false;
                    if (historyIndex == inputHistory.Count)
                    {
                        inputHistory.Add(rtbInput.Text);

                    }
                    historyIndex--;
                    rtbInput.Text = inputHistory[historyIndex];

                    rtbInput.Multiline = true;
                }
            }
            if (e.KeyCode == Keys.Down)
            {
                if (historyIndex + 1 < inputHistory.Count) {
                    rtbInput.Multiline = false;
                    historyIndex++;
                    rtbInput.Text = inputHistory[historyIndex];

                    rtbInput.Multiline = true;
                }
            }
            
        }

        private void checkCustomKeywords()
        {
            Console.WriteLine(rtbInput.Text);
            if (rtbInput.Text.Contains("stop"))
            {
                stopServer();
            }
            
        }
        private void stopServer()
        {
            input = null;
            rtbInput.Multiline = false;
            onlinePlayers.Clear();
            updatePlayerList();
            serverOutput.SelectionColor = Color.Red;
            serverOutput.AppendText("SERVER STOPPING" + Environment.NewLine);
        }


        private void runPic_Click(object sender, EventArgs e)
        {
            StartCmdProcess();
        }

        private void stopPic_Click(object sender, EventArgs e)
        {
            stopServer();
        }

        private void reloadPic_Click(object sender, EventArgs e)
        {
            
            if (input == null)
            {
                serverOutput.AppendText("Process not started" + Environment.NewLine);
                return;
            }
            else
            {
                input.WriteLine("reload confirm" + Environment.NewLine);
            }
        }

        private void showHidePic_Click(object sender, EventArgs e)
        {
            if (ipHidden)
            {
                ipHidden = false;
                rtbIP.Show();
            } else
            {
                rtbIP.Hide();
                ipHidden = true;
            }
        }

        private void kickButton_Click(object sender, EventArgs e)
        {
            if (input == null)
            {
                serverOutput.AppendText("Process not started" + Environment.NewLine);
                return;
            }
            else
            {
                if (onlinePlayersListBox.Text == "") { return; }
                string player = onlinePlayersListBox.Text;
                input.WriteLine("kick " + player + Environment.NewLine);
            }
        }

        private void banButton_Click(object sender, EventArgs e)
        {
            if (input == null)
            {
                serverOutput.AppendText("Process not started" + Environment.NewLine);
                return;
            }
            else
            {
                if (onlinePlayersListBox.Text == "") { return; }
                string player = onlinePlayersListBox.Text;
                BanForm banForm = new BanForm(player, this);
                banForm.Show();
            }
        }
        public void banProcessFromForm(string player, TimeSpan timespan, string reason, bool permaBan, char mode)
        {
            if (mode == 't')
            {
                if (permaBan)
                {
                    input.WriteLine($"ban {player} {reason}" + Environment.NewLine);
                    Console.WriteLine($"ban {player} {reason}");
                }
                else
                {
                    double totalSeconds = timespan.TotalSeconds;
                    input.WriteLine($"ban {player} {totalSeconds}s {reason}" + Environment.NewLine);
                    Console.WriteLine($"ban {player} {totalSeconds}s {reason}");
                }
            } else
            {
                input.WriteLine($"ban {player} {reason}" + Environment.NewLine);
                Console.WriteLine($"ban {player} {reason}");
            }
                
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Show self made (?) settings menu
        }

    }
}
