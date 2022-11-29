namespace MC_Server_GUI
{
    partial class BanForm
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
            this.timespanMode = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.permaBanCheckBox = new System.Windows.Forms.CheckBox();
            this.labelDHMS = new System.Windows.Forms.Label();
            this.textBoxSeconds = new System.Windows.Forms.TextBox();
            this.textBoxMinutes = new System.Windows.Forms.TextBox();
            this.textBoxHours = new System.Windows.Forms.TextBox();
            this.textBoxDays = new System.Windows.Forms.TextBox();
            this.reasonLabel = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonBan = new System.Windows.Forms.Button();
            this.reasonRTB = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.buttonBanVanilla = new System.Windows.Forms.Button();
            this.reasonRTBVanilla = new System.Windows.Forms.RichTextBox();
            this.timespanMode.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timespanMode
            // 
            this.timespanMode.Controls.Add(this.tabPage1);
            this.timespanMode.Controls.Add(this.tabPage2);
            this.timespanMode.Location = new System.Drawing.Point(3, 3);
            this.timespanMode.Name = "timespanMode";
            this.timespanMode.SelectedIndex = 0;
            this.timespanMode.Size = new System.Drawing.Size(307, 348);
            this.timespanMode.TabIndex = 24;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.permaBanCheckBox);
            this.tabPage1.Controls.Add(this.labelDHMS);
            this.tabPage1.Controls.Add(this.textBoxSeconds);
            this.tabPage1.Controls.Add(this.textBoxMinutes);
            this.tabPage1.Controls.Add(this.textBoxHours);
            this.tabPage1.Controls.Add(this.textBoxDays);
            this.tabPage1.Controls.Add(this.reasonLabel);
            this.tabPage1.Controls.Add(this.buttonCancel);
            this.tabPage1.Controls.Add(this.buttonBan);
            this.tabPage1.Controls.Add(this.reasonRTB);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(299, 322);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "TimeSpan mode";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // permaBanCheckBox
            // 
            this.permaBanCheckBox.AutoSize = true;
            this.permaBanCheckBox.Location = new System.Drawing.Point(8, 215);
            this.permaBanCheckBox.Name = "permaBanCheckBox";
            this.permaBanCheckBox.Size = new System.Drawing.Size(74, 17);
            this.permaBanCheckBox.TabIndex = 33;
            this.permaBanCheckBox.Text = "Permaban";
            this.permaBanCheckBox.UseVisualStyleBackColor = true;
            this.permaBanCheckBox.CheckedChanged += new System.EventHandler(this.permaBanCheckBox_CheckedChanged);
            // 
            // labelDHMS
            // 
            this.labelDHMS.AutoSize = true;
            this.labelDHMS.Location = new System.Drawing.Point(5, 161);
            this.labelDHMS.Name = "labelDHMS";
            this.labelDHMS.Size = new System.Drawing.Size(261, 13);
            this.labelDHMS.TabIndex = 32;
            this.labelDHMS.Text = "Days                 Hours              Minutes          Seconds";
            // 
            // textBoxSeconds
            // 
            this.textBoxSeconds.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxSeconds.Location = new System.Drawing.Point(216, 177);
            this.textBoxSeconds.Name = "textBoxSeconds";
            this.textBoxSeconds.Size = new System.Drawing.Size(77, 20);
            this.textBoxSeconds.TabIndex = 31;
            this.textBoxSeconds.Text = "0";
            // 
            // textBoxMinutes
            // 
            this.textBoxMinutes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxMinutes.Location = new System.Drawing.Point(151, 177);
            this.textBoxMinutes.Name = "textBoxMinutes";
            this.textBoxMinutes.Size = new System.Drawing.Size(63, 20);
            this.textBoxMinutes.TabIndex = 30;
            this.textBoxMinutes.Text = "0";
            // 
            // textBoxHours
            // 
            this.textBoxHours.Location = new System.Drawing.Point(83, 177);
            this.textBoxHours.Name = "textBoxHours";
            this.textBoxHours.Size = new System.Drawing.Size(66, 20);
            this.textBoxHours.TabIndex = 29;
            this.textBoxHours.Text = "0";
            // 
            // textBoxDays
            // 
            this.textBoxDays.Location = new System.Drawing.Point(6, 177);
            this.textBoxDays.Name = "textBoxDays";
            this.textBoxDays.Size = new System.Drawing.Size(75, 20);
            this.textBoxDays.TabIndex = 28;
            this.textBoxDays.Text = "0";
            // 
            // reasonLabel
            // 
            this.reasonLabel.AutoSize = true;
            this.reasonLabel.Location = new System.Drawing.Point(9, 8);
            this.reasonLabel.Name = "reasonLabel";
            this.reasonLabel.Size = new System.Drawing.Size(44, 13);
            this.reasonLabel.TabIndex = 27;
            this.reasonLabel.Text = "Reason";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(159, 248);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(134, 47);
            this.buttonCancel.TabIndex = 26;
            this.buttonCancel.Text = "button2";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonBan
            // 
            this.buttonBan.Location = new System.Drawing.Point(6, 248);
            this.buttonBan.Name = "buttonBan";
            this.buttonBan.Size = new System.Drawing.Size(134, 47);
            this.buttonBan.TabIndex = 25;
            this.buttonBan.Text = "Ban";
            this.buttonBan.UseVisualStyleBackColor = true;
            this.buttonBan.Click += new System.EventHandler(this.buttonBan_Click);
            // 
            // reasonRTB
            // 
            this.reasonRTB.Location = new System.Drawing.Point(8, 27);
            this.reasonRTB.Name = "reasonRTB";
            this.reasonRTB.Size = new System.Drawing.Size(285, 131);
            this.reasonRTB.TabIndex = 24;
            this.reasonRTB.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.cancel);
            this.tabPage2.Controls.Add(this.buttonBanVanilla);
            this.tabPage2.Controls.Add(this.reasonRTBVanilla);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(299, 322);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Vanilla mode";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Reason";
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(159, 248);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(134, 47);
            this.cancel.TabIndex = 36;
            this.cancel.Text = "button2";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // buttonBanVanilla
            // 
            this.buttonBanVanilla.Location = new System.Drawing.Point(6, 248);
            this.buttonBanVanilla.Name = "buttonBanVanilla";
            this.buttonBanVanilla.Size = new System.Drawing.Size(134, 47);
            this.buttonBanVanilla.TabIndex = 35;
            this.buttonBanVanilla.Text = "Ban";
            this.buttonBanVanilla.UseVisualStyleBackColor = true;
            this.buttonBanVanilla.Click += new System.EventHandler(this.buttonBanVanilla_Click);
            // 
            // reasonRTBVanilla
            // 
            this.reasonRTBVanilla.Location = new System.Drawing.Point(8, 27);
            this.reasonRTBVanilla.Name = "reasonRTBVanilla";
            this.reasonRTBVanilla.Size = new System.Drawing.Size(285, 215);
            this.reasonRTBVanilla.TabIndex = 34;
            this.reasonRTBVanilla.Text = "";
            // 
            // BanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 351);
            this.Controls.Add(this.timespanMode);
            this.Name = "BanForm";
            this.Text = "Ban Player";
            this.timespanMode.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl timespanMode;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox permaBanCheckBox;
        private System.Windows.Forms.Label labelDHMS;
        private System.Windows.Forms.TextBox textBoxSeconds;
        private System.Windows.Forms.TextBox textBoxMinutes;
        private System.Windows.Forms.TextBox textBoxHours;
        private System.Windows.Forms.TextBox textBoxDays;
        private System.Windows.Forms.Label reasonLabel;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonBan;
        private System.Windows.Forms.RichTextBox reasonRTB;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button buttonBanVanilla;
        private System.Windows.Forms.RichTextBox reasonRTBVanilla;
    }
}