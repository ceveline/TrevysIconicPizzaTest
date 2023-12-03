namespace TrevysIconicPizza
{
    partial class HelpPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpPage));
            this.helpLabel = new System.Windows.Forms.Label();
            this.helpTabControl = new System.Windows.Forms.TabControl();
            this.accountTabPage = new System.Windows.Forms.TabPage();
            this.accountHelpLabel2 = new System.Windows.Forms.Label();
            this.accountHelpLabel1 = new System.Windows.Forms.Label();
            this.orderTabPage = new System.Windows.Forms.TabPage();
            this.cartTabPage = new System.Windows.Forms.TabPage();
            this.checkoutTabPage = new System.Windows.Forms.TabPage();
            this.helpTabControl.SuspendLayout();
            this.accountTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // helpLabel
            // 
            this.helpLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(90)))), ((int)(((byte)(37)))));
            this.helpLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.helpLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.helpLabel.ForeColor = System.Drawing.Color.Cornsilk;
            this.helpLabel.Location = new System.Drawing.Point(232, 9);
            this.helpLabel.Name = "helpLabel";
            this.helpLabel.Size = new System.Drawing.Size(296, 49);
            this.helpLabel.TabIndex = 0;
            this.helpLabel.Text = "Trevy\'s Iconic Pizza Help Page";
            this.helpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // helpTabControl
            // 
            this.helpTabControl.Controls.Add(this.accountTabPage);
            this.helpTabControl.Controls.Add(this.orderTabPage);
            this.helpTabControl.Controls.Add(this.cartTabPage);
            this.helpTabControl.Controls.Add(this.checkoutTabPage);
            this.helpTabControl.Location = new System.Drawing.Point(12, 71);
            this.helpTabControl.Name = "helpTabControl";
            this.helpTabControl.SelectedIndex = 0;
            this.helpTabControl.Size = new System.Drawing.Size(776, 367);
            this.helpTabControl.TabIndex = 1;
            // 
            // accountTabPage
            // 
            this.accountTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(180)))), ((int)(((byte)(100)))));
            this.accountTabPage.Controls.Add(this.accountHelpLabel2);
            this.accountTabPage.Controls.Add(this.accountHelpLabel1);
            this.accountTabPage.Location = new System.Drawing.Point(4, 22);
            this.accountTabPage.Name = "accountTabPage";
            this.accountTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.accountTabPage.Size = new System.Drawing.Size(768, 341);
            this.accountTabPage.TabIndex = 0;
            this.accountTabPage.Text = "Account";
            // 
            // accountHelpLabel2
            // 
            this.accountHelpLabel2.Font = new System.Drawing.Font("Arial", 11F);
            this.accountHelpLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(65)))), ((int)(((byte)(11)))));
            this.accountHelpLabel2.Location = new System.Drawing.Point(16, 36);
            this.accountHelpLabel2.Name = "accountHelpLabel2";
            this.accountHelpLabel2.Size = new System.Drawing.Size(718, 62);
            this.accountHelpLabel2.TabIndex = 1;
            this.accountHelpLabel2.Text = resources.GetString("accountHelpLabel2.Text");
            // 
            // accountHelpLabel1
            // 
            this.accountHelpLabel1.AutoSize = true;
            this.accountHelpLabel1.Font = new System.Drawing.Font("Arial", 11F);
            this.accountHelpLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(65)))), ((int)(((byte)(11)))));
            this.accountHelpLabel1.Location = new System.Drawing.Point(16, 19);
            this.accountHelpLabel1.Name = "accountHelpLabel1";
            this.accountHelpLabel1.Size = new System.Drawing.Size(162, 17);
            this.accountHelpLabel1.TabIndex = 0;
            this.accountHelpLabel1.Text = "Managing your account:";
            // 
            // orderTabPage
            // 
            this.orderTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(180)))), ((int)(((byte)(100)))));
            this.orderTabPage.Location = new System.Drawing.Point(4, 22);
            this.orderTabPage.Name = "orderTabPage";
            this.orderTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.orderTabPage.Size = new System.Drawing.Size(768, 341);
            this.orderTabPage.TabIndex = 1;
            this.orderTabPage.Text = "Ordering";
            // 
            // cartTabPage
            // 
            this.cartTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(180)))), ((int)(((byte)(100)))));
            this.cartTabPage.Location = new System.Drawing.Point(4, 22);
            this.cartTabPage.Name = "cartTabPage";
            this.cartTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.cartTabPage.Size = new System.Drawing.Size(768, 341);
            this.cartTabPage.TabIndex = 2;
            this.cartTabPage.Text = "Cart";
            // 
            // checkoutTabPage
            // 
            this.checkoutTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(180)))), ((int)(((byte)(100)))));
            this.checkoutTabPage.Location = new System.Drawing.Point(4, 22);
            this.checkoutTabPage.Name = "checkoutTabPage";
            this.checkoutTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.checkoutTabPage.Size = new System.Drawing.Size(768, 341);
            this.checkoutTabPage.TabIndex = 3;
            this.checkoutTabPage.Text = "Checkout";
            // 
            // HelpPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(180)))), ((int)(((byte)(100)))));
            this.BackgroundImage = global::TrevysIconicPizza.Properties.Resources.Pizza;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.helpTabControl);
            this.Controls.Add(this.helpLabel);
            this.Name = "HelpPage";
            this.Text = "HelpPage";
            this.helpTabControl.ResumeLayout(false);
            this.accountTabPage.ResumeLayout(false);
            this.accountTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label helpLabel;
        private System.Windows.Forms.TabControl helpTabControl;
        private System.Windows.Forms.TabPage accountTabPage;
        private System.Windows.Forms.TabPage orderTabPage;
        private System.Windows.Forms.TabPage cartTabPage;
        private System.Windows.Forms.TabPage checkoutTabPage;
        private System.Windows.Forms.Label accountHelpLabel1;
        private System.Windows.Forms.Label accountHelpLabel2;
    }
}