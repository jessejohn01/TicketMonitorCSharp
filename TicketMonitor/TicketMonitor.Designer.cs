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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.commandsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualRefreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monitorOutputTextBox = new System.Windows.Forms.RichTextBox();
            this.progressbarLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(418, 415);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(348, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.commandsToolStripMenuItem});
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
            this.manualRefreshToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.manualRefreshToolStripMenuItem.Text = "Manual Refresh";
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
            // ticketMonitorFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progressbarLabel);
            this.Controls.Add(this.monitorOutputTextBox);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ticketMonitorFrame";
            this.Text = "Ticket Monitor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ticketMonitorFrame_FormClosed);
            this.Load += new System.EventHandler(this.TicketMonitorFrame_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem commandsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualRefreshToolStripMenuItem;
        private System.Windows.Forms.RichTextBox monitorOutputTextBox;
        private System.Windows.Forms.Label progressbarLabel;
    }
}