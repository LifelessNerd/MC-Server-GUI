using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MC_Server_GUI
{
    public partial class BanForm : Form
    {
        RunEnvironmentForm main;
        string player;
        bool permaBan = false;
        public BanForm(string player, RunEnvironmentForm main)
        {
            this.main = main;
            this.player = player;
            InitializeComponent();
        }

        private void buttonBan_Click(object sender, EventArgs e)
        {
            int days = int.Parse(textBoxDays.Text);
            int hours = int.Parse(textBoxHours.Text);
            int minutes = int.Parse(textBoxMinutes.Text);
            int seconds = int.Parse(textBoxSeconds.Text);
            TimeSpan timeSpan = new TimeSpan(days, hours, minutes, seconds);
            main.banProcessFromForm(player, timeSpan, reasonRTB.Text, permaBan, 't');
            this.Close();
        }

        private void permaBanCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            
            if (permaBanCheckBox.Checked)
            {
                textBoxDays.ReadOnly = true;
                textBoxDays.BackColor = SystemColors.GrayText;
                textBoxHours.ReadOnly = true;
                textBoxHours.BackColor = SystemColors.GrayText;
                textBoxMinutes.ReadOnly = true;
                textBoxMinutes.BackColor = SystemColors.GrayText;
                textBoxSeconds.ReadOnly = true;
                textBoxSeconds.BackColor = SystemColors.GrayText;
                permaBan = true;

            } else
            {
                textBoxDays.ReadOnly = false;
                textBoxDays.BackColor = Color.White;
                textBoxHours.ReadOnly = false;
                textBoxHours.BackColor = Color.White;
                textBoxMinutes.ReadOnly = false;
                textBoxMinutes.BackColor = Color.White;
                textBoxSeconds.ReadOnly = false;
                textBoxSeconds.BackColor = Color.White;
                permaBan = false;
            }
        }

        private void buttonBanVanilla_Click(object sender, EventArgs e)
        {
            main.banProcessFromForm(player, new TimeSpan(0,0,0), reasonRTBVanilla.Text, true, 'v');
            this.Close();
        }

    }

    public class BanInfo{
        string player;
        TimeSpan timespan;
        string reason;
        public BanInfo(string player, TimeSpan timespan, string reason)
        {
            this.player = player;
            this.timespan = timespan;
            this.reason = reason;
        }
        public override string ToString()
        {   
            string formattedTimespan = this.timespan.ToString("dd:mm:ss");
            return this.player + ", for " + formattedTimespan + ", with reason: " + reason;
        }
    }

}
