namespace TicketMonitor
{
    partial class ticketMonitorFrame
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
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.commandsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualRefreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monitorOutputTextBox = new System.Windows.Forms.RichTextBox();
            this.progressbarLabel = new System.Windows.Forms.Label();
            this.debugGet = new System.Windows.Forms.Button();
            this.optionPanel = new System.Windows.Forms.Panel();
            this.optionSaveButton = new System.Windows.Forms.Button();
            this.refreshTimeLabel = new System.Windows.Forms.Label();
            this.refreshTime = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.optionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(418, 415);
            this.progressBar.Maximum = 30000;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(348, 23);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.commandsToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // commandsToolStripMenuItem
            // 
            this.commandsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualRefreshToolStripMenuItem});
            this.commandsToolStripMenuItem.Name = "commandsToolStripMenuItem";
            this.commandsToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.commandsToolStripMenuItem.Text = "Commands";
            // 
            // manualRefreshToolStripMenuItem
            // 
            this.manualRefreshToolStripMenuItem.Name = "manualRefreshToolStripMenuItem";
            this.manualRefreshToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.manualRefreshToolStripMenuItem.Text = "Manual Refresh";
            this.manualRefreshToolStripMenuItem.Click += new System.EventHandler(this.ManualRefreshToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.OptionsToolStripMenuItem_Click);
            // 
            // monitorOutputTextBox
            // 
            this.monitorOutputTextBox.BackColor = System.Drawing.Color.LightSkyBlue;
            this.monitorOutputTextBox.Location = new System.Drawing.Point(33, 44);
            this.monitorOutputTextBox.Name = "monitorOutputTextBox";
            this.monitorOutputTextBox.ReadOnly = true;
            this.monitorOutputTextBox.Size = new System.Drawing.Size(733, 352);
            this.monitorOutputTextBox.TabIndex = 2;
            this.monitorOutputTextBox.Text = "";
            // 
            // progressbarLabel
            // 
            this.progressbarLabel.AutoSize = true;
            this.progressbarLabel.BackColor = System.Drawing.Color.SteelBlue;
            this.progressbarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressbarLabel.Location = new System.Drawing.Point(328, 418);
            this.progressbarLabel.Name = "progressbarLabel";
            this.progressbarLabel.Size = new System.Drawing.Size(84, 17);
            this.progressbarLabel.TabIndex = 3;
            this.progressbarLabel.Text = "Refresh Bar";
            // 
            // debugGet
            // 
            this.debugGet.Location = new System.Drawing.Point(33, 412);
            this.debugGet.Name = "debugGet";
            this.debugGet.Size = new System.Drawing.Size(75, 23);
            this.debugGet.TabIndex = 4;
            this.debugGet.Text = "Get Ticket 1";
            this.debugGet.UseVisualStyleBackColor = true;
            this.debugGet.Click += new System.EventHandler(this.DebugGet_Click);
            // 
            // optionPanel
            // 
            this.optionPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.optionPanel.Controls.Add(this.optionSaveButton);
            this.optionPanel.Controls.Add(this.refreshTimeLabel);
            this.optionPanel.Controls.Add(this.refreshTime);
            this.optionPanel.Location = new System.Drawing.Point(0, 0);
            this.optionPanel.Name = "optionPanel";
            this.optionPanel.Size = new System.Drawing.Size(800, 452);
            this.optionPanel.TabIndex = 5;
            this.optionPanel.Visible = false;
            // 
            // optionSaveButton
            // 
            this.optionSaveButton.Location = new System.Drawing.Point(281, 365);
            this.optionSaveButton.Name = "optionSaveButton";
            this.optionSaveButton.Size = new System.Drawing.Size(221, 31);
            this.optionSaveButton.TabIndex = 2;
            this.optionSaveButton.Text = "Save";
            this.optionSaveButton.UseVisualStyleBackColor = true;
            this.optionSaveButton.Click += new System.EventHandler(this.OptionSaveButton_Click);
            // 
            // refreshTimeLabel
            // 
            this.refreshTimeLabel.AutoSize = true;
            this.refreshTimeLabel.BackColor = System.Drawing.Color.SteelBlue;
            this.refreshTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshTimeLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.refreshTimeLabel.Location = new System.Drawing.Point(30, 24);
            this.refreshTimeLabel.Name = "refreshTimeLabel";
            this.refreshTimeLabel.Size = new System.Drawing.Size(89, 16);
            this.refreshTimeLabel.TabIndex = 1;
            this.refreshTimeLabel.Text = "Refresh Time";
            // 
            // refreshTime
            // 
            this.refreshTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.refreshTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.refreshTime.FormattingEnabled = true;
            this.refreshTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.refreshTime.Items.AddRange(new object[] {
            "One Minute",
            "Five Minutes",
            "Ten Minutes"});
            this.refreshTime.Location = new System.Drawing.Point(136, 21);
            this.refreshTime.Name = "refreshTime";
            this.refreshTime.Size = new System.Drawing.Size(115, 23);
            this.refreshTime.TabIndex = 0;
            // 
            // ticketMonitorFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.debugGet);
            this.Controls.Add(this.progressbarLabel);
            this.Controls.Add(this.monitorOutputTextBox);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.optionPanel);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "ticketMonitorFrame";
            this.Text = "Ticket Monitor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ticketMonitorFrame_FormClosed);
            this.Load += new System.EventHandler(this.TicketMonitorFrame_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.optionPanel.ResumeLayout(false);
            this.optionPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        //Anything above here will be generated over.


        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem commandsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualRefreshToolStripMenuItem;
        private System.Windows.Forms.RichTextBox monitorOutputTextBox;
        private System.Windows.Forms.Label progressbarLabel;
        private System.Windows.Forms.Button debugGet;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.Panel optionPanel;
        private System.Windows.Forms.ComboBox refreshTime;
        private System.Windows.Forms.Button optionSaveButton;
        private System.Windows.Forms.Label refreshTimeLabel;
    }
}