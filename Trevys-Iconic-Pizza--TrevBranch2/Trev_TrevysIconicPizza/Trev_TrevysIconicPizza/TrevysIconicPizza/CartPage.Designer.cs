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
            this.checkOutButton = new System.Windows.Forms.Button();
            this.emptyLabel = new System.Windows.Forms.Label();
            this.yourItemsLabel = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.cartListBox = new System.Windows.Forms.ListBox();
            this.copyrightLabel = new System.Windows.Forms.Label();
            this.closePictureBox = new System.Windows.Forms.PictureBox();
            this.cartPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cartPanel
            // 
            this.cartPanel.Controls.Add(this.checkOutButton);
            this.cartPanel.Controls.Add(this.emptyLabel);
            this.cartPanel.Controls.Add(this.yourItemsLabel);
            this.cartPanel.Controls.Add(this.editButton);
            this.cartPanel.Controls.Add(this.removeButton);
            this.cartPanel.Controls.Add(this.cartListBox);
            this.cartPanel.Location = new System.Drawing.Point(28, 23);
            this.cartPanel.Name = "cartPanel";
            this.cartPanel.Size = new System.Drawing.Size(503, 344);
            this.cartPanel.TabIndex = 0;
            // 
            // checkOutButton
            // 
            this.checkOutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(90)))), ((int)(((byte)(37)))));
            this.checkOutButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkOutButton.ForeColor = System.Drawing.Color.Cornsilk;
            this.checkOutButton.Location = new System.Drawing.Point(355, 171);
            this.checkOutButton.Name = "checkOutButton";
            this.checkOutButton.Size = new System.Drawing.Size(145, 50);
            this.checkOutButton.TabIndex = 5;
            this.checkOutButton.Text = "Checkout ";
            this.checkOutButton.UseVisualStyleBackColor = false;
            this.checkOutButton.Click += new System.EventHandler(this.checkOutButton_Click);
            // 
            // emptyLabel
            // 
            this.emptyLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emptyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(90)))), ((int)(((byte)(37)))));
            this.emptyLabel.Location = new System.Drawing.Point(367, 41);
            this.emptyLabel.Name = "emptyLabel";
            this.emptyLabel.Size = new System.Drawing.Size(114, 116);
            this.emptyLabel.TabIndex = 4;
            this.emptyLabel.Text = "It Seems That Your Cart Is Empty... \r\n";
            this.emptyLabel.Visible = false;
            // 
            // yourItemsLabel
            // 
            this.yourItemsLabel.AutoSize = true;
            this.yourItemsLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yourItemsLabel.ForeColor = System.Drawing.Color.Cornsilk;
            this.yourItemsLabel.Location = new System.Drawing.Point(350, 4);
            this.yourItemsLabel.Name = "yourItemsLabel";
            this.yourItemsLabel.Size = new System.Drawing.Size(134, 58);
            this.yourItemsLabel.TabIndex = 3;
            this.yourItemsLabel.Text = "Your Items\r\n\r\n";
            this.yourItemsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(90)))), ((int)(((byte)(37)))));
            this.editButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.ForeColor = System.Drawing.Color.Cornsilk;
            this.editButton.Location = new System.Drawing.Point(355, 227);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(145, 50);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = false;
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(90)))), ((int)(((byte)(37)))));
            this.removeButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton.ForeColor = System.Drawing.Color.Cornsilk;
            this.removeButton.Location = new System.Drawing.Point(355, 283);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(145, 50);
            this.removeButton.TabIndex = 1;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // cartListBox
            // 
            this.cartListBox.FormattingEnabled = true;
            this.cartListBox.Location = new System.Drawing.Point(4, 4);
            this.cartListBox.MaximumSize = new System.Drawing.Size(317, 394);
            this.cartListBox.Name = "cartListBox";
            this.cartListBox.ScrollAlwaysVisible = true;
            this.cartListBox.Size = new System.Drawing.Size(317, 329);
            this.cartListBox.TabIndex = 0;
            // 
            // copyrightLabel
            // 
            this.copyrightLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.copyrightLabel.Location = new System.Drawing.Point(188, 370);
            this.copyrightLabel.Name = "copyrightLabel";
            this.copyrightLabel.Size = new System.Drawing.Size(161, 23);
            this.copyrightLabel.TabIndex = 8;
            this.copyrightLabel.Text = "© 2023 Trevy\'s Iconic Pizza";
            this.copyrightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // closePictureBox
            // 
            this.closePictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closePictureBox.BackgroundImage")));
            this.closePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closePictureBox.Location = new System.Drawing.Point(535, 3);
            this.closePictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.closePictureBox.Name = "closePictureBox";
            this.closePictureBox.Size = new System.Drawing.Size(18, 20);
            this.closePictureBox.TabIndex = 9;
            this.closePictureBox.TabStop = false;
            this.closePictureBox.Click += new System.EventHandler(this.closePictureBox_Click);
            // 
            // CartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(180)))), ((int)(((byte)(100)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(561, 394);
            this.ControlBox = false;
            this.Controls.Add(this.closePictureBox);
            this.Controls.Add(this.copyrightLabel);
            this.Controls.Add(this.cartPanel);
            this.MaximumSize = new System.Drawing.Size(578, 440);
            this.Name = "CartPage";
            this.Text = "CartPage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CartPage_FormClosed);
            this.cartPanel.ResumeLayout(false);
            this.cartPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel cartPanel;
        private System.Windows.Forms.Label copyrightLabel;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.ListBox cartListBox;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Label yourItemsLabel;
        private System.Windows.Forms.Button checkOutButton;
        private System.Windows.Forms.Label emptyLabel;
        private System.Windows.Forms.PictureBox closePictureBox;
    }
}