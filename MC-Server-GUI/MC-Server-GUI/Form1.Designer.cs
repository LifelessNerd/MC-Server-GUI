namespace MC_Server_GUI
{
    partial class RunEnvironmentForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rtbInput = new System.Windows.Forms.RichTextBox();
            this.serverOutput = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.serverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onlinePlayersListBox = new System.Windows.Forms.ListBox();
            this.kickButton = new System.Windows.Forms.Button();
            this.toggleOPButton = new System.Windows.Forms.Button();
            this.banButton = new System.Windows.Forms.Button();
            this.rtbIP = new System.Windows.Forms.RichTextBox();
            this.reloadPic = new System.Windows.Forms.PictureBox();
            this.stopPic = new System.Windows.Forms.PictureBox();
            this.runPic = new System.Windows.Forms.PictureBox();
            this.showHidePic = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reloadPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.runPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showHidePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rtbInput);
            this.panel1.Controls.Add(this.serverOutput);
            this.panel1.Location = new System.Drawing.Point(339, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1211, 972);
            this.panel1.TabIndex = 0;
            // 
            // rtbInput
            // 
            this.rtbInput.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.rtbInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbInput.Location = new System.Drawing.Point(3, 934);
            this.rtbInput.Multiline = false;
            this.rtbInput.Name = "rtbInput";
            this.rtbInput.Size = new System.Drawing.Size(1204, 35);
            this.rtbInput.TabIndex = 1;
            this.rtbInput.Text = "";
            this.rtbInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CheckUpDown);
            this.rtbInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterPressed);
            // 
            // serverOutput
            // 
            this.serverOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.serverOutput.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverOutput.ForeColor = System.Drawing.SystemColors.Info;
            this.serverOutput.Location = new System.Drawing.Point(4, 4);
            this.serverOutput.Name = "serverOutput";
            this.serverOutput.ReadOnly = true;
            this.serverOutput.Size = new System.Drawing.Size(1204, 924);
            this.serverOutput.TabIndex = 0;
            this.serverOutput.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serverToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1904, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // serverToolStripMenuItem
            // 
            this.serverToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.reloadToolStripMenuItem});
            this.serverToolStripMenuItem.Name = "serverToolStripMenuItem";
            this.serverToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.serverToolStripMenuItem.Text = "Server";
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.Image = global::MC_Server_GUI.Properties.Resources.run;
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.runToolStripMenuItem.Text = "Run";
            this.runToolStripMenuItem.Click += new System.EventHandler(this.runToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Image = global::MC_Server_GUI.Properties.Resources.Untitled;
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            // 
            // reloadToolStripMenuItem
            // 
            this.reloadToolStripMenuItem.Image = global::MC_Server_GUI.Properties.Resources.reload;
            this.reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
            this.reloadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reloadToolStripMenuItem.Text = "Reload";
            // 
            // onlinePlayersListBox
            // 
            this.onlinePlayersListBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.onlinePlayersListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onlinePlayersListBox.FormattingEnabled = true;
            this.onlinePlayersListBox.ItemHeight = 25;
            this.onlinePlayersListBox.Items.AddRange(new object[] {
            "Lorem",
            "ipsum",
            "dolor",
            "sit",
            "amet"});
            this.onlinePlayersListBox.Location = new System.Drawing.Point(1567, 31);
            this.onlinePlayersListBox.Name = "onlinePlayersListBox";
            this.onlinePlayersListBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.onlinePlayersListBox.Size = new System.Drawing.Size(325, 154);
            this.onlinePlayersListBox.TabIndex = 3;
            // 
            // kickButton
            // 
            this.kickButton.Font = new System.Drawing.Font("Space Grotesk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kickButton.Location = new System.Drawing.Point(1567, 191);
            this.kickButton.Name = "kickButton";
            this.kickButton.Size = new System.Drawing.Size(103, 39);
            this.kickButton.TabIndex = 4;
            this.kickButton.Text = "KICK";
            this.kickButton.UseVisualStyleBackColor = true;
            // 
            // toggleOPButton
            // 
            this.toggleOPButton.Font = new System.Drawing.Font("Space Grotesk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleOPButton.Location = new System.Drawing.Point(1679, 191);
            this.toggleOPButton.Name = "toggleOPButton";
            this.toggleOPButton.Size = new System.Drawing.Size(103, 39);
            this.toggleOPButton.TabIndex = 5;
            this.toggleOPButton.Text = "TOGGLE OP";
            this.toggleOPButton.UseVisualStyleBackColor = true;
            // 
            // banButton
            // 
            this.banButton.Font = new System.Drawing.Font("Space Grotesk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.banButton.Location = new System.Drawing.Point(1789, 191);
            this.banButton.Name = "banButton";
            this.banButton.Size = new System.Drawing.Size(103, 39);
            this.banButton.TabIndex = 6;
            this.banButton.Text = "BAN";
            this.banButton.UseVisualStyleBackColor = true;
            // 
            // rtbIP
            // 
            this.rtbIP.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rtbIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbIP.Location = new System.Drawing.Point(12, 37);
            this.rtbIP.Multiline = false;
            this.rtbIP.Name = "rtbIP";
            this.rtbIP.ReadOnly = true;
            this.rtbIP.Size = new System.Drawing.Size(279, 34);
            this.rtbIP.TabIndex = 7;
            this.rtbIP.Text = "";
            this.rtbIP.Visible = false;
            // 
            // reloadPic
            // 
            this.reloadPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.reloadPic.Image = global::MC_Server_GUI.Properties.Resources.reload;
            this.reloadPic.Location = new System.Drawing.Point(230, 78);
            this.reloadPic.Name = "reloadPic";
            this.reloadPic.Size = new System.Drawing.Size(96, 77);
            this.reloadPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.reloadPic.TabIndex = 10;
            this.reloadPic.TabStop = false;
            this.reloadPic.Click += new System.EventHandler(this.reloadPic_Click);
            // 
            // stopPic
            // 
            this.stopPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.stopPic.Image = global::MC_Server_GUI.Properties.Resources.Untitled;
            this.stopPic.Location = new System.Drawing.Point(121, 78);
            this.stopPic.Name = "stopPic";
            this.stopPic.Size = new System.Drawing.Size(96, 77);
            this.stopPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.stopPic.TabIndex = 9;
            this.stopPic.TabStop = false;
            this.stopPic.Click += new System.EventHandler(this.stopPic_Click);
            // 
            // runPic
            // 
            this.runPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.runPic.Image = global::MC_Server_GUI.Properties.Resources.run;
            this.runPic.Location = new System.Drawing.Point(12, 78);
            this.runPic.Name = "runPic";
            this.runPic.Size = new System.Drawing.Size(96, 77);
            this.runPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.runPic.TabIndex = 8;
            this.runPic.TabStop = false;
            this.runPic.Click += new System.EventHandler(this.runPic_Click);
            // 
            // showHidePic
            // 
            this.showHidePic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.showHidePic.Image = global::MC_Server_GUI.Properties.Resources.showhide;
            this.showHidePic.Location = new System.Drawing.Point(297, 37);
            this.showHidePic.Name = "showHidePic";
            this.showHidePic.Size = new System.Drawing.Size(36, 34);
            this.showHidePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.showHidePic.TabIndex = 11;
            this.showHidePic.TabStop = false;
            this.toolTip1.SetToolTip(this.showHidePic, "Show/hide IP adress");
            this.showHidePic.Click += new System.EventHandler(this.showHidePic_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(14, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 30);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // RunEnvironmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(48)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(1904, 1011);
            this.Controls.Add(this.showHidePic);
            this.Controls.Add(this.reloadPic);
            this.Controls.Add(this.stopPic);
            this.Controls.Add(this.runPic);
            this.Controls.Add(this.rtbIP);
            this.Controls.Add(this.banButton);
            this.Controls.Add(this.toggleOPButton);
            this.Controls.Add(this.kickButton);
            this.Controls.Add(this.onlinePlayersListBox);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RunEnvironmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reloadPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.runPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showHidePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem serverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadToolStripMenuItem;
        private System.Windows.Forms.RichTextBox serverOutput;
        private System.Windows.Forms.RichTextBox rtbInput;
        private System.Windows.Forms.ListBox onlinePlayersListBox;
        private System.Windows.Forms.Button kickButton;
        private System.Windows.Forms.Button toggleOPButton;
        private System.Windows.Forms.Button banButton;
        private System.Windows.Forms.RichTextBox rtbIP;
        private System.Windows.Forms.PictureBox runPic;
        private System.Windows.Forms.PictureBox stopPic;
        private System.Windows.Forms.PictureBox reloadPic;
        private System.Windows.Forms.PictureBox showHidePic;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

