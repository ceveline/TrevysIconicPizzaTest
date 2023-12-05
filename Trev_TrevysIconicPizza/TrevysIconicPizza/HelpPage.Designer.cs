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
            this.helpTabControl = new System.Windows.Forms.TabControl();
            this.accountTabPage = new System.Windows.Forms.TabPage();
            this.accountManagementHelpLabel = new System.Windows.Forms.Label();
            this.accountCreationHelpLabel = new System.Windows.Forms.Label();
            this.accountCreationLabel = new System.Windows.Forms.Label();
            this.accountManagementLabel = new System.Windows.Forms.Label();
            this.orderTabPage = new System.Windows.Forms.TabPage();
            this.orderingDrinkHelpLabel = new System.Windows.Forms.Label();
            this.orderingDrinkLabel = new System.Windows.Forms.Label();
            this.orderingPizzaHelpLabel = new System.Windows.Forms.Label();
            this.orderingPizzaLabel = new System.Windows.Forms.Label();
            this.cartTabPage = new System.Windows.Forms.TabPage();
            this.checkoutTabPage = new System.Windows.Forms.TabPage();
            this.helpLabel = new System.Windows.Forms.Label();
            this.helpTabControl.SuspendLayout();
            this.accountTabPage.SuspendLayout();
            this.orderTabPage.SuspendLayout();
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
            this.accountTabPage.Controls.Add(this.accountManagementHelpLabel);
            this.accountTabPage.Controls.Add(this.accountCreationHelpLabel);
            this.accountTabPage.Controls.Add(this.accountCreationLabel);
            this.accountTabPage.Controls.Add(this.accountManagementLabel);
            this.accountTabPage.Location = new System.Drawing.Point(4, 22);
            this.accountTabPage.Name = "accountTabPage";
            this.accountTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.accountTabPage.Size = new System.Drawing.Size(768, 343);
            this.accountTabPage.TabIndex = 0;
            this.accountTabPage.Text = "Account";
            // 
            // accountManagementHelpLabel
            // 
            this.accountManagementHelpLabel.Font = new System.Drawing.Font("Arial", 11F);
            this.accountManagementHelpLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(65)))), ((int)(((byte)(11)))));
            this.accountManagementHelpLabel.Location = new System.Drawing.Point(25, 154);
            this.accountManagementHelpLabel.Name = "accountManagementHelpLabel";
            this.accountManagementHelpLabel.Size = new System.Drawing.Size(740, 98);
            this.accountManagementHelpLabel.TabIndex = 3;
            this.accountManagementHelpLabel.Text = resources.GetString("accountManagementHelpLabel.Text");
            // 
            // accountCreationHelpLabel
            // 
            this.accountCreationHelpLabel.Font = new System.Drawing.Font("Arial", 11F);
            this.accountCreationHelpLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(65)))), ((int)(((byte)(11)))));
            this.accountCreationHelpLabel.Location = new System.Drawing.Point(24, 60);
            this.accountCreationHelpLabel.Name = "accountCreationHelpLabel";
            this.accountCreationHelpLabel.Size = new System.Drawing.Size(724, 41);
            this.accountCreationHelpLabel.TabIndex = 2;
            this.accountCreationHelpLabel.Text = "Creating an account is easy, all you have to do is click on the \"Create Account\" " +
    "button in the landing page and fill in the required information in the textboxes" +
    ".\r\n\r\n";
            // 
            // accountCreationLabel
            // 
            this.accountCreationLabel.AutoSize = true;
            this.accountCreationLabel.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold);
            this.accountCreationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(65)))), ((int)(((byte)(11)))));
            this.accountCreationLabel.Location = new System.Drawing.Point(22, 25);
            this.accountCreationLabel.Name = "accountCreationLabel";
            this.accountCreationLabel.Size = new System.Drawing.Size(196, 26);
            this.accountCreationLabel.TabIndex = 1;
            this.accountCreationLabel.Text = "Account Creation:";
            // 
            // accountManagementLabel
            // 
            this.accountManagementLabel.AutoSize = true;
            this.accountManagementLabel.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold);
            this.accountManagementLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(65)))), ((int)(((byte)(11)))));
            this.accountManagementLabel.Location = new System.Drawing.Point(22, 128);
            this.accountManagementLabel.Name = "accountManagementLabel";
            this.accountManagementLabel.Size = new System.Drawing.Size(240, 26);
            this.accountManagementLabel.TabIndex = 0;
            this.accountManagementLabel.Text = "Account Management:";
            // 
            // orderTabPage
            // 
            this.orderTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(202)))), ((int)(((byte)(68)))));
            this.orderTabPage.Controls.Add(this.orderingDrinkHelpLabel);
            this.orderTabPage.Controls.Add(this.orderingDrinkLabel);
            this.orderTabPage.Controls.Add(this.orderingPizzaHelpLabel);
            this.orderTabPage.Controls.Add(this.orderingPizzaLabel);
            this.orderTabPage.Location = new System.Drawing.Point(4, 22);
            this.orderTabPage.Name = "orderTabPage";
            this.orderTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.orderTabPage.Size = new System.Drawing.Size(768, 343);
            this.orderTabPage.TabIndex = 1;
            this.orderTabPage.Text = "Ordering";
            // 
            // orderingDrinkHelpLabel
            // 
            this.orderingDrinkHelpLabel.Font = new System.Drawing.Font("Arial", 11F);
            this.orderingDrinkHelpLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(65)))), ((int)(((byte)(11)))));
            this.orderingDrinkHelpLabel.Location = new System.Drawing.Point(25, 206);
            this.orderingDrinkHelpLabel.Name = "orderingDrinkHelpLabel";
            this.orderingDrinkHelpLabel.Size = new System.Drawing.Size(729, 100);
            this.orderingDrinkHelpLabel.TabIndex = 3;
            this.orderingDrinkHelpLabel.Text = resources.GetString("orderingDrinkHelpLabel.Text");
            // 
            // orderingDrinkLabel
            // 
            this.orderingDrinkLabel.AutoSize = true;
            this.orderingDrinkLabel.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold);
            this.orderingDrinkLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(65)))), ((int)(((byte)(11)))));
            this.orderingDrinkLabel.Location = new System.Drawing.Point(23, 165);
            this.orderingDrinkLabel.Name = "orderingDrinkLabel";
            this.orderingDrinkLabel.Size = new System.Drawing.Size(173, 26);
            this.orderingDrinkLabel.TabIndex = 2;
            this.orderingDrinkLabel.Text = "Ordering Drinks";
            // 
            // orderingPizzaHelpLabel
            // 
            this.orderingPizzaHelpLabel.Font = new System.Drawing.Font("Arial", 11F);
            this.orderingPizzaHelpLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(65)))), ((int)(((byte)(11)))));
            this.orderingPizzaHelpLabel.Location = new System.Drawing.Point(25, 62);
            this.orderingPizzaHelpLabel.Name = "orderingPizzaHelpLabel";
            this.orderingPizzaHelpLabel.Size = new System.Drawing.Size(733, 103);
            this.orderingPizzaHelpLabel.TabIndex = 1;
            this.orderingPizzaHelpLabel.Text = resources.GetString("orderingPizzaHelpLabel.Text");
            // 
            // orderingPizzaLabel
            // 
            this.orderingPizzaLabel.AutoSize = true;
            this.orderingPizzaLabel.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold);
            this.orderingPizzaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(65)))), ((int)(((byte)(11)))));
            this.orderingPizzaLabel.Location = new System.Drawing.Point(23, 23);
            this.orderingPizzaLabel.Name = "orderingPizzaLabel";
            this.orderingPizzaLabel.Size = new System.Drawing.Size(179, 26);
            this.orderingPizzaLabel.TabIndex = 0;
            this.orderingPizzaLabel.Text = "Ordering  Pizzas";
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
            this.accountTabPage.ResumeLayout(false);
            this.accountTabPage.PerformLayout();
            this.orderTabPage.ResumeLayout(false);
            this.orderTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl helpTabControl;
        private System.Windows.Forms.TabPage accountTabPage;
        private System.Windows.Forms.TabPage orderTabPage;
        private System.Windows.Forms.Label helpLabel;
        private System.Windows.Forms.TabPage cartTabPage;
        private System.Windows.Forms.TabPage checkoutTabPage;
        private System.Windows.Forms.Label accountManagementLabel;
        private System.Windows.Forms.Label accountCreationLabel;
        private System.Windows.Forms.Label accountCreationHelpLabel;
        private System.Windows.Forms.Label accountManagementHelpLabel;
        private System.Windows.Forms.Label orderingDrinkHelpLabel;
        private System.Windows.Forms.Label orderingDrinkLabel;
        private System.Windows.Forms.Label orderingPizzaHelpLabel;
        private System.Windows.Forms.Label orderingPizzaLabel;
    }
}