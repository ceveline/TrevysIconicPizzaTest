﻿namespace TrevysIconicPizza
{
    partial class LandingPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LandingPage));
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.createAccountButton = new System.Windows.Forms.Button();
            this.continueAsGuestButton = new System.Windows.Forms.Button();
            this.copyrightLabel = new System.Windows.Forms.Label();
            this.landingPageTimer = new System.Windows.Forms.Timer(this.components);
            this.landingPageTimerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.Location = new System.Drawing.Point(153, 29);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(256, 234);
            this.logoPictureBox.TabIndex = 0;
            this.logoPictureBox.TabStop = false;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(90)))), ((int)(((byte)(37)))));
            this.loginButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.Cornsilk;
            this.loginButton.Location = new System.Drawing.Point(27, 304);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(145, 50);
            this.loginButton.TabIndex = 1;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // createAccountButton
            // 
            this.createAccountButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(90)))), ((int)(((byte)(37)))));
            this.createAccountButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAccountButton.ForeColor = System.Drawing.Color.Cornsilk;
            this.createAccountButton.Location = new System.Drawing.Point(206, 304);
            this.createAccountButton.Name = "createAccountButton";
            this.createAccountButton.Size = new System.Drawing.Size(145, 50);
            this.createAccountButton.TabIndex = 2;
            this.createAccountButton.Text = "Create Account";
            this.createAccountButton.UseVisualStyleBackColor = false;
            this.createAccountButton.Click += new System.EventHandler(this.createAccountButton_Click);
            // 
            // continueAsGuestButton
            // 
            this.continueAsGuestButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(90)))), ((int)(((byte)(37)))));
            this.continueAsGuestButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continueAsGuestButton.ForeColor = System.Drawing.Color.Cornsilk;
            this.continueAsGuestButton.Location = new System.Drawing.Point(385, 304);
            this.continueAsGuestButton.Name = "continueAsGuestButton";
            this.continueAsGuestButton.Size = new System.Drawing.Size(145, 50);
            this.continueAsGuestButton.TabIndex = 3;
            this.continueAsGuestButton.Text = "Continue As Guest";
            this.continueAsGuestButton.UseVisualStyleBackColor = false;
            this.continueAsGuestButton.Click += new System.EventHandler(this.continueAsGuestButton_Click);
            // 
            // copyrightLabel
            // 
            this.copyrightLabel.Location = new System.Drawing.Point(203, 376);
            this.copyrightLabel.Name = "copyrightLabel";
            this.copyrightLabel.Size = new System.Drawing.Size(161, 23);
            this.copyrightLabel.TabIndex = 4;
            this.copyrightLabel.Text = "© 2023 Trevy\'s Iconic Pizza";
            this.copyrightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // landingPageTimer
            // 
            this.landingPageTimer.Interval = 1000;
            this.landingPageTimer.Tick += new System.EventHandler(this.landingPageTimer_Tick);
            // 
            // landingPageTimerLabel
            // 
            this.landingPageTimerLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(90)))), ((int)(((byte)(37)))));
            this.landingPageTimerLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.landingPageTimerLabel.ForeColor = System.Drawing.Color.Cornsilk;
            this.landingPageTimerLabel.Location = new System.Drawing.Point(428, 9);
            this.landingPageTimerLabel.Name = "landingPageTimerLabel";
            this.landingPageTimerLabel.Size = new System.Drawing.Size(112, 23);
            this.landingPageTimerLabel.TabIndex = 5;
            this.landingPageTimerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LandingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(180)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(563, 402);
            this.Controls.Add(this.landingPageTimerLabel);
            this.Controls.Add(this.copyrightLabel);
            this.Controls.Add(this.continueAsGuestButton);
            this.Controls.Add(this.createAccountButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.logoPictureBox);
            this.Name = "LandingPage";
            this.Text = "Trevy\'s Iconic Pizza";
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button createAccountButton;
        private System.Windows.Forms.Button continueAsGuestButton;
        private System.Windows.Forms.Label copyrightLabel;
        private System.Windows.Forms.Timer landingPageTimer;
        private System.Windows.Forms.Label landingPageTimerLabel;
    }
}

