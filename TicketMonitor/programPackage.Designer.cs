using System;

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
            this.userNameField = new System.Windows.Forms.TextBox();
            this.apiKeyField = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
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
            // userNameField
            // 
            this.userNameField.Location = new System.Drawing.Point(72, 245);
            this.userNameField.Name = "userNameField";
            this.userNameField.Size = new System.Drawing.Size(225, 20);
            this.userNameField.TabIndex = 1;
            // 
            // apiKeyField
            // 
            this.apiKeyField.Location = new System.Drawing.Point(72, 293);
            this.apiKeyField.Name = "apiKeyField";
            this.apiKeyField.PasswordChar = '*';
            this.apiKeyField.Size = new System.Drawing.Size(225, 20);
            this.apiKeyField.TabIndex = 2;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(69, 225);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(73, 17);
            this.usernameLabel.TabIndex = 3;
            this.usernameLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(72, 274);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(57, 17);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "API Key";
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.Gold;
            this.loginButton.Location = new System.Drawing.Point(95, 372);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(175, 34);
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
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.apiKeyField);
            this.Controls.Add(this.userNameField);
            this.Controls.Add(this.msuLogo);
            this.MaximizeBox = false;
            this.Name = "programPackage";
            this.Text = "Ticket Monitor Login";
            ((System.ComponentModel.ISupportInitialize)(this.msuLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void msuLogo_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.PictureBox msuLogo;
        private System.Windows.Forms.TextBox userNameField;
        private System.Windows.Forms.TextBox apiKeyField;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button loginButton;
    }
}

