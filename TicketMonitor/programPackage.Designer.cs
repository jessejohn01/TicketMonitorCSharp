using System;
using System.Windows.Forms;

namespace TicketMonitor
{
    partial class programPackage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(programPackage));
            this.msuLogo = new System.Windows.Forms.PictureBox();
            this.loginButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.msuLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // msuLogo
            // 
            this.msuLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("msuLogo.BackgroundImage")));
            this.msuLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.msuLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.msuLogo.Location = new System.Drawing.Point(95, 27);
            this.msuLogo.Name = "msuLogo";
            this.msuLogo.Size = new System.Drawing.Size(175, 140);
            this.msuLogo.TabIndex = 0;
            this.msuLogo.TabStop = false;
            this.msuLogo.Click += new System.EventHandler(this.msuLogo_Click);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.Gold;
            this.loginButton.Location = new System.Drawing.Point(95, 271);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(175, 44);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // programPackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(376, 486);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.msuLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "programPackage";
            this.Text = "Ticket Monitor Login";
            ((System.ComponentModel.ISupportInitialize)(this.msuLogo)).EndInit();
            this.ResumeLayout(false);

        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void msuLogo_Click(object sender, EventArgs e)
        {
           
        }

        #endregion

        private System.Windows.Forms.PictureBox msuLogo;
        private System.Windows.Forms.Button loginButton;
    }
}

