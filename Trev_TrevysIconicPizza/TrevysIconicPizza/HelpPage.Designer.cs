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
            this.helpTabControl = new System.Windows.Forms.TabControl();
            this.accountTabPage = new System.Windows.Forms.TabPage();
            this.orderTabPage = new System.Windows.Forms.TabPage();
            this.cartTabPage = new System.Windows.Forms.TabPage();
            this.checkoutTabPage = new System.Windows.Forms.TabPage();
            this.helpLabel = new System.Windows.Forms.Label();
            this.helpTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // helpTabControl
            // 
            this.helpTabControl.Controls.Add(this.accountTabPage);
            this.helpTabControl.Controls.Add(this.orderTabPage);
            this.helpTabControl.Controls.Add(this.cartTabPage);
            this.helpTabControl.Controls.Add(this.checkoutTabPage);
            this.helpTabControl.Location = new System.Drawing.Point(12, 69);
            this.helpTabControl.Name = "helpTabControl";
            this.helpTabControl.SelectedIndex = 0;
            this.helpTabControl.Size = new System.Drawing.Size(776, 369);
            this.helpTabControl.TabIndex = 0;
            // 
            // accountTabPage
            // 
            this.accountTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(202)))), ((int)(((byte)(68)))));
            this.accountTabPage.Location = new System.Drawing.Point(4, 22);
            this.accountTabPage.Name = "accountTabPage";
            this.accountTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.accountTabPage.Size = new System.Drawing.Size(768, 343);
            this.accountTabPage.TabIndex = 0;
            this.accountTabPage.Text = "Account";
            // 
            // orderTabPage
            // 
            this.orderTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(202)))), ((int)(((byte)(68)))));
            this.orderTabPage.Location = new System.Drawing.Point(4, 22);
            this.orderTabPage.Name = "orderTabPage";
            this.orderTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.orderTabPage.Size = new System.Drawing.Size(768, 343);
            this.orderTabPage.TabIndex = 1;
            this.orderTabPage.Text = "Ordering";
            // 
            // cartTabPage
            // 
            this.cartTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(202)))), ((int)(((byte)(68)))));
            this.cartTabPage.Location = new System.Drawing.Point(4, 22);
            this.cartTabPage.Name = "cartTabPage";
            this.cartTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.cartTabPage.Size = new System.Drawing.Size(768, 343);
            this.cartTabPage.TabIndex = 2;
            this.cartTabPage.Text = "Cart";
            // 
            // checkoutTabPage
            // 
            this.checkoutTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(202)))), ((int)(((byte)(68)))));
            this.checkoutTabPage.Location = new System.Drawing.Point(4, 22);
            this.checkoutTabPage.Name = "checkoutTabPage";
            this.checkoutTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.checkoutTabPage.Size = new System.Drawing.Size(768, 343);
            this.checkoutTabPage.TabIndex = 3;
            this.checkoutTabPage.Text = "Checkout";
            // 
            // helpLabel
            // 
            this.helpLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(90)))), ((int)(((byte)(37)))));
            this.helpLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.helpLabel.ForeColor = System.Drawing.Color.Cornsilk;
            this.helpLabel.Location = new System.Drawing.Point(237, 21);
            this.helpLabel.Name = "helpLabel";
            this.helpLabel.Size = new System.Drawing.Size(314, 45);
            this.helpLabel.TabIndex = 1;
            this.helpLabel.Text = "Trevy\'s Iconic Pizza Help";
            this.helpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HelpPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(180)))), ((int)(((byte)(100)))));
            this.BackgroundImage = global::TrevysIconicPizza.Properties.Resources.Pizza;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.helpLabel);
            this.Controls.Add(this.helpTabControl);
            this.Name = "HelpPage";
            this.Text = "HelpPage";
            this.helpTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl helpTabControl;
        private System.Windows.Forms.TabPage accountTabPage;
        private System.Windows.Forms.TabPage orderTabPage;
        private System.Windows.Forms.Label helpLabel;
        private System.Windows.Forms.TabPage cartTabPage;
        private System.Windows.Forms.TabPage checkoutTabPage;
    }
}