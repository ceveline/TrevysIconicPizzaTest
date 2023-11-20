namespace TrevysIconicPizza
{
    partial class CartPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CartPage));
            this.cartPanel = new System.Windows.Forms.Panel();
            this.addButton = new System.Windows.Forms.Button();
            this.emptyLabel = new System.Windows.Forms.Label();
            this.yourItemsLabel = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.cartListBox = new System.Windows.Forms.ListBox();
            this.copyrightLabel = new System.Windows.Forms.Label();
            this.cartPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // cartPanel
            // 
            this.cartPanel.Controls.Add(this.addButton);
            this.cartPanel.Controls.Add(this.emptyLabel);
            this.cartPanel.Controls.Add(this.yourItemsLabel);
            this.cartPanel.Controls.Add(this.editButton);
            this.cartPanel.Controls.Add(this.removeButton);
            this.cartPanel.Controls.Add(this.cartListBox);
            this.cartPanel.Location = new System.Drawing.Point(42, 35);
            this.cartPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cartPanel.Name = "cartPanel";
            this.cartPanel.Size = new System.Drawing.Size(754, 529);
            this.cartPanel.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(90)))), ((int)(((byte)(37)))));
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(532, 263);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(218, 77);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // emptyLabel
            // 
            this.emptyLabel.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emptyLabel.Location = new System.Drawing.Point(550, 63);
            this.emptyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emptyLabel.Name = "emptyLabel";
            this.emptyLabel.Size = new System.Drawing.Size(171, 178);
            this.emptyLabel.TabIndex = 4;
            this.emptyLabel.Text = "It Seems That Your Cart Is Empty... Click Add";
            this.emptyLabel.Visible = false;
            // 
            // yourItemsLabel
            // 
            this.yourItemsLabel.AutoSize = true;
            this.yourItemsLabel.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yourItemsLabel.ForeColor = System.Drawing.Color.White;
            this.yourItemsLabel.Location = new System.Drawing.Point(525, 6);
            this.yourItemsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.yourItemsLabel.Name = "yourItemsLabel";
            this.yourItemsLabel.Size = new System.Drawing.Size(216, 92);
            this.yourItemsLabel.TabIndex = 3;
            this.yourItemsLabel.Text = "Your Items\r\n\r\n";
            this.yourItemsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(90)))), ((int)(((byte)(37)))));
            this.editButton.ForeColor = System.Drawing.Color.White;
            this.editButton.Location = new System.Drawing.Point(532, 349);
            this.editButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(218, 77);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = false;
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(90)))), ((int)(((byte)(37)))));
            this.removeButton.ForeColor = System.Drawing.Color.White;
            this.removeButton.Location = new System.Drawing.Point(532, 435);
            this.removeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(218, 77);
            this.removeButton.TabIndex = 1;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // cartListBox
            // 
            this.cartListBox.FormattingEnabled = true;
            this.cartListBox.ItemHeight = 20;
            this.cartListBox.Location = new System.Drawing.Point(6, 6);
            this.cartListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cartListBox.MaximumSize = new System.Drawing.Size(474, 604);
            this.cartListBox.Name = "cartListBox";
            this.cartListBox.ScrollAlwaysVisible = true;
            this.cartListBox.Size = new System.Drawing.Size(474, 504);
            this.cartListBox.TabIndex = 0;
            // 
            // copyrightLabel
            // 
            this.copyrightLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.copyrightLabel.Location = new System.Drawing.Point(282, 569);
            this.copyrightLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.copyrightLabel.Name = "copyrightLabel";
            this.copyrightLabel.Size = new System.Drawing.Size(242, 35);
            this.copyrightLabel.TabIndex = 8;
            this.copyrightLabel.Text = "© 2023 Trevy\'s Iconic Pizza";
            this.copyrightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(180)))), ((int)(((byte)(100)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(844, 618);
            this.Controls.Add(this.copyrightLabel);
            this.Controls.Add(this.cartPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CartPage";
            this.Text = "CartPage";
            this.cartPanel.ResumeLayout(false);
            this.cartPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel cartPanel;
        private System.Windows.Forms.Label copyrightLabel;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.ListBox cartListBox;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Label yourItemsLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label emptyLabel;
    }
}