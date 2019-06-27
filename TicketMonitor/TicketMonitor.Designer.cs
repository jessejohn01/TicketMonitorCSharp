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
            this.pages = new PageControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.progressbarLabel = new System.Windows.Forms.Label();
            this.monitorOutputTextBox = new System.Windows.Forms.RichTextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.commandsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualRefreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.refreshTime = new System.Windows.Forms.ComboBox();
            this.optionSaveButton = new System.Windows.Forms.Button();
            this.refreshTimeLabel = new System.Windows.Forms.Label();
            this.clearTextButton = new System.Windows.Forms.Button();
            this.pages.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pages
            // 
            this.pages.Controls.Add(this.tabPage1);
            this.pages.Controls.Add(this.tabPage2);
            this.pages.Location = new System.Drawing.Point(-5, -3);
            this.pages.Name = "pages";
            this.pages.SelectedIndex = 0;
            this.pages.Size = new System.Drawing.Size(816, 484);
            this.pages.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.SteelBlue;
            this.tabPage1.Controls.Add(this.clearTextButton);
            this.tabPage1.Controls.Add(this.progressbarLabel);
            this.tabPage1.Controls.Add(this.monitorOutputTextBox);
            this.tabPage1.Controls.Add(this.progressBar);
            this.tabPage1.Controls.Add(this.menuStrip1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(808, 458);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // progressbarLabel
            // 
            this.progressbarLabel.AutoSize = true;
            this.progressbarLabel.BackColor = System.Drawing.Color.SteelBlue;
            this.progressbarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressbarLabel.Location = new System.Drawing.Point(326, 418);
            this.progressbarLabel.Name = "progressbarLabel";
            this.progressbarLabel.Size = new System.Drawing.Size(84, 17);
            this.progressbarLabel.TabIndex = 14;
            this.progressbarLabel.Text = "Refresh Bar";
            // 
            // monitorOutputTextBox
            // 
            this.monitorOutputTextBox.BackColor = System.Drawing.Color.LightSkyBlue;
            this.monitorOutputTextBox.Location = new System.Drawing.Point(31, 54);
            this.monitorOutputTextBox.Name = "monitorOutputTextBox";
            this.monitorOutputTextBox.ReadOnly = true;
            this.monitorOutputTextBox.Size = new System.Drawing.Size(733, 352);
            this.monitorOutputTextBox.TabIndex = 13;
            this.monitorOutputTextBox.Text = "";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(416, 417);
            this.progressBar.Maximum = 30000;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(348, 23);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 11;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2);
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.commandsToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(802, 29);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // commandsToolStripMenuItem
            // 
            this.commandsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualRefreshToolStripMenuItem});
            this.commandsToolStripMenuItem.Name = "commandsToolStripMenuItem";
            this.commandsToolStripMenuItem.Size = new System.Drawing.Size(81, 25);
            this.commandsToolStripMenuItem.Text = "Commands";
            // 
            // manualRefreshToolStripMenuItem
            // 
            this.manualRefreshToolStripMenuItem.Name = "manualRefreshToolStripMenuItem";
            this.manualRefreshToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.manualRefreshToolStripMenuItem.Text = "Manual Refresh";
            this.manualRefreshToolStripMenuItem.Click += new System.EventHandler(this.ManualRefreshToolStripMenuItem_Click_1);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 25);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.OptionsToolStripMenuItem_Click_1);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.SteelBlue;
            this.tabPage2.Controls.Add(this.refreshTime);
            this.tabPage2.Controls.Add(this.optionSaveButton);
            this.tabPage2.Controls.Add(this.refreshTimeLabel);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(808, 458);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
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
            this.refreshTime.Location = new System.Drawing.Point(172, 21);
            this.refreshTime.Name = "refreshTime";
            this.refreshTime.Size = new System.Drawing.Size(115, 23);
            this.refreshTime.TabIndex = 10;
            // 
            // optionSaveButton
            // 
            this.optionSaveButton.Location = new System.Drawing.Point(266, 329);
            this.optionSaveButton.Name = "optionSaveButton";
            this.optionSaveButton.Size = new System.Drawing.Size(221, 31);
            this.optionSaveButton.TabIndex = 12;
            this.optionSaveButton.Text = "Save";
            this.optionSaveButton.UseVisualStyleBackColor = true;
            this.optionSaveButton.Click += new System.EventHandler(this.OptionSaveButton_Click_1);
            // 
            // refreshTimeLabel
            // 
            this.refreshTimeLabel.AutoSize = true;
            this.refreshTimeLabel.BackColor = System.Drawing.Color.SteelBlue;
            this.refreshTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshTimeLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.refreshTimeLabel.Location = new System.Drawing.Point(38, 24);
            this.refreshTimeLabel.Name = "refreshTimeLabel";
            this.refreshTimeLabel.Size = new System.Drawing.Size(89, 16);
            this.refreshTimeLabel.TabIndex = 11;
            this.refreshTimeLabel.Text = "Refresh Time";
            // 
            // clearTextButton
            // 
            this.clearTextButton.Location = new System.Drawing.Point(31, 415);
            this.clearTextButton.Name = "clearTextButton";
            this.clearTextButton.Size = new System.Drawing.Size(75, 23);
            this.clearTextButton.TabIndex = 15;
            this.clearTextButton.Text = "Clear Text";
            this.clearTextButton.UseVisualStyleBackColor = true;
            this.clearTextButton.Click += new System.EventHandler(this.ClearTextButton_Click);
            // 
            // ticketMonitorFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 465);
            this.Controls.Add(this.pages);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ticketMonitorFrame";
            this.Text = "Ticket Monitor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ticketMonitorFrame_FormClosed);
            this.Load += new System.EventHandler(this.TicketMonitorFrame_Load);
            this.pages.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PageControl pages;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox refreshTime;
        private System.Windows.Forms.Button optionSaveButton;
        private System.Windows.Forms.Label refreshTimeLabel;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label progressbarLabel;
        private System.Windows.Forms.RichTextBox monitorOutputTextBox;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem commandsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualRefreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.Button clearTextButton;
    }
}