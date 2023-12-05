namespace TrevysIconicPizza
{
    partial class CheckoutPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckoutPage));
            this.paymentGroupBox = new System.Windows.Forms.GroupBox();
            this.delivTimeLabel = new System.Windows.Forms.Label();
            this.cardNumberLabel = new System.Windows.Forms.Label();
            this.cardNumberTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.serviceLabel = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.pickupRadioButton = new System.Windows.Forms.RadioButton();
            this.CVVTextBox = new System.Windows.Forms.TextBox();
            this.deliveryRadioButton = new System.Windows.Forms.RadioButton();
            this.CVVLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.estimatedPrepTime = new System.Windows.Forms.Label();
            this.pickUpTimeLabel = new System.Windows.Forms.Label();
            this.deliveryDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.orderGroupBox = new System.Windows.Forms.GroupBox();
            this.cartLogo = new System.Windows.Forms.PictureBox();
            this.checkoutButton = new System.Windows.Forms.Button();
            this.totalLabel = new System.Windows.Forms.Label();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.orderListBox = new System.Windows.Forms.ListBox();
            this.pickUpTimer = new System.Windows.Forms.Timer(this.components);
            this.paymentGroupBox.SuspendLayout();
            this.orderGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // paymentGroupBox
            // 
            this.paymentGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(180)))), ((int)(((byte)(100)))));
            this.paymentGroupBox.Controls.Add(this.delivTimeLabel);
            this.paymentGroupBox.Controls.Add(this.cardNumberLabel);
            this.paymentGroupBox.Controls.Add(this.cardNumberTextBox);
            this.paymentGroupBox.Controls.Add(this.phoneTextBox);
            this.paymentGroupBox.Controls.Add(this.phoneLabel);
            this.paymentGroupBox.Controls.Add(this.serviceLabel);
            this.paymentGroupBox.Controls.Add(this.addressTextBox);
            this.paymentGroupBox.Controls.Add(this.pickupRadioButton);
            this.paymentGroupBox.Controls.Add(this.CVVTextBox);
            this.paymentGroupBox.Controls.Add(this.deliveryRadioButton);
            this.paymentGroupBox.Controls.Add(this.CVVLabel);
            this.paymentGroupBox.Controls.Add(this.addressLabel);
            this.paymentGroupBox.Controls.Add(this.estimatedPrepTime);
            this.paymentGroupBox.Controls.Add(this.pickUpTimeLabel);
            this.paymentGroupBox.Controls.Add(this.deliveryDateTimePicker);
            this.paymentGroupBox.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(90)))), ((int)(((byte)(37)))));
            this.paymentGroupBox.Location = new System.Drawing.Point(46, 28);
            this.paymentGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.paymentGroupBox.Name = "paymentGroupBox";
            this.paymentGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.paymentGroupBox.Size = new System.Drawing.Size(343, 433);
            this.paymentGroupBox.TabIndex = 5;
            this.paymentGroupBox.TabStop = false;
            this.paymentGroupBox.Text = "Payment";
            // 
            // delivTimeLabel
            // 
            this.delivTimeLabel.AutoSize = true;
            this.delivTimeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(202)))), ((int)(((byte)(68)))));
            this.delivTimeLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delivTimeLabel.Location = new System.Drawing.Point(11, 343);
            this.delivTimeLabel.Name = "delivTimeLabel";
            this.delivTimeLabel.Size = new System.Drawing.Size(193, 19);
            this.delivTimeLabel.TabIndex = 13;
            this.delivTimeLabel.Text = "Preferred Delivery Time:";
            // 
            // cardNumberLabel
            // 
            this.cardNumberLabel.AutoSize = true;
            this.cardNumberLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(202)))), ((int)(((byte)(68)))));
            this.cardNumberLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardNumberLabel.Location = new System.Drawing.Point(11, 56);
            this.cardNumberLabel.Name = "cardNumberLabel";
            this.cardNumberLabel.Size = new System.Drawing.Size(111, 19);
            this.cardNumberLabel.TabIndex = 12;
            this.cardNumberLabel.Text = "Card Number";
            // 
            // cardNumberTextBox
            // 
            this.cardNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardNumberTextBox.Location = new System.Drawing.Point(14, 75);
            this.cardNumberTextBox.Name = "cardNumberTextBox";
            this.cardNumberTextBox.Size = new System.Drawing.Size(238, 20);
            this.cardNumberTextBox.TabIndex = 11;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTextBox.Location = new System.Drawing.Point(14, 259);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(238, 20);
            this.phoneTextBox.TabIndex = 10;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(202)))), ((int)(((byte)(68)))));
            this.phoneLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.Location = new System.Drawing.Point(12, 241);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(124, 19);
            this.phoneLabel.TabIndex = 9;
            this.phoneLabel.Text = "Phone Number";
            // 
            // serviceLabel
            // 
            this.serviceLabel.AutoSize = true;
            this.serviceLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(202)))), ((int)(((byte)(68)))));
            this.serviceLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(90)))), ((int)(((byte)(37)))));
            this.serviceLabel.Location = new System.Drawing.Point(11, 291);
            this.serviceLabel.Name = "serviceLabel";
            this.serviceLabel.Size = new System.Drawing.Size(121, 19);
            this.serviceLabel.TabIndex = 8;
            this.serviceLabel.Text = "Service Option";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTextBox.Location = new System.Drawing.Point(14, 197);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(238, 20);
            this.addressTextBox.TabIndex = 7;
            // 
            // pickupRadioButton
            // 
            this.pickupRadioButton.AutoSize = true;
            this.pickupRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickupRadioButton.ForeColor = System.Drawing.Color.Black;
            this.pickupRadioButton.Location = new System.Drawing.Point(103, 316);
            this.pickupRadioButton.Name = "pickupRadioButton";
            this.pickupRadioButton.Size = new System.Drawing.Size(74, 24);
            this.pickupRadioButton.TabIndex = 6;
            this.pickupRadioButton.TabStop = true;
            this.pickupRadioButton.Text = "Pickup";
            this.pickupRadioButton.UseVisualStyleBackColor = true;
            this.pickupRadioButton.CheckedChanged += new System.EventHandler(this.pickupRadioButton_CheckedChanged);
            // 
            // CVVTextBox
            // 
            this.CVVTextBox.BackColor = System.Drawing.Color.White;
            this.CVVTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CVVTextBox.ForeColor = System.Drawing.Color.White;
            this.CVVTextBox.Location = new System.Drawing.Point(14, 136);
            this.CVVTextBox.Name = "CVVTextBox";
            this.CVVTextBox.Size = new System.Drawing.Size(74, 20);
            this.CVVTextBox.TabIndex = 5;
            // 
            // deliveryRadioButton
            // 
            this.deliveryRadioButton.AutoSize = true;
            this.deliveryRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deliveryRadioButton.ForeColor = System.Drawing.Color.Black;
            this.deliveryRadioButton.Location = new System.Drawing.Point(15, 316);
            this.deliveryRadioButton.Name = "deliveryRadioButton";
            this.deliveryRadioButton.Size = new System.Drawing.Size(82, 24);
            this.deliveryRadioButton.TabIndex = 4;
            this.deliveryRadioButton.TabStop = true;
            this.deliveryRadioButton.Text = "Delivery";
            this.deliveryRadioButton.UseVisualStyleBackColor = true;
            // 
            // CVVLabel
            // 
            this.CVVLabel.AutoSize = true;
            this.CVVLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(202)))), ((int)(((byte)(68)))));
            this.CVVLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CVVLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(90)))), ((int)(((byte)(37)))));
            this.CVVLabel.Location = new System.Drawing.Point(11, 117);
            this.CVVLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CVVLabel.Name = "CVVLabel";
            this.CVVLabel.Size = new System.Drawing.Size(43, 19);
            this.CVVLabel.TabIndex = 3;
            this.CVVLabel.Text = "CVV";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(202)))), ((int)(((byte)(68)))));
            this.addressLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(90)))), ((int)(((byte)(37)))));
            this.addressLabel.Location = new System.Drawing.Point(11, 178);
            this.addressLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(73, 19);
            this.addressLabel.TabIndex = 1;
            this.addressLabel.Text = "Address";
            // 
            // estimatedPrepTime
            // 
            this.estimatedPrepTime.AutoSize = true;
            this.estimatedPrepTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(202)))), ((int)(((byte)(68)))));
            this.estimatedPrepTime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estimatedPrepTime.Location = new System.Drawing.Point(11, 343);
            this.estimatedPrepTime.Name = "estimatedPrepTime";
            this.estimatedPrepTime.Size = new System.Drawing.Size(189, 19);
            this.estimatedPrepTime.TabIndex = 14;
            this.estimatedPrepTime.Text = "Estimated Pickup Time:";
            this.estimatedPrepTime.Visible = false;
            // 
            // pickUpTimeLabel
            // 
            this.pickUpTimeLabel.AutoSize = true;
            this.pickUpTimeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(202)))), ((int)(((byte)(68)))));
            this.pickUpTimeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pickUpTimeLabel.Location = new System.Drawing.Point(14, 368);
            this.pickUpTimeLabel.Name = "pickUpTimeLabel";
            this.pickUpTimeLabel.Size = new System.Drawing.Size(54, 26);
            this.pickUpTimeLabel.TabIndex = 15;
            this.pickUpTimeLabel.Text = "Test";
            this.pickUpTimeLabel.Visible = false;
            // 
            // deliveryDateTimePicker
            // 
            this.deliveryDateTimePicker.CalendarFont = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deliveryDateTimePicker.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deliveryDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.deliveryDateTimePicker.Location = new System.Drawing.Point(14, 368);
            this.deliveryDateTimePicker.Name = "deliveryDateTimePicker";
            this.deliveryDateTimePicker.Size = new System.Drawing.Size(238, 26);
            this.deliveryDateTimePicker.TabIndex = 7;
            this.deliveryDateTimePicker.Value = new System.DateTime(2023, 11, 21, 12, 17, 29, 0);
            // 
            // orderGroupBox
            // 
            this.orderGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(180)))), ((int)(((byte)(100)))));
            this.orderGroupBox.Controls.Add(this.cartLogo);
            this.orderGroupBox.Controls.Add(this.checkoutButton);
            this.orderGroupBox.Controls.Add(this.totalLabel);
            this.orderGroupBox.Controls.Add(this.totalTextBox);
            this.orderGroupBox.Controls.Add(this.orderListBox);
            this.orderGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderGroupBox.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(90)))), ((int)(((byte)(37)))));
            this.orderGroupBox.Location = new System.Drawing.Point(446, 28);
            this.orderGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.orderGroupBox.Name = "orderGroupBox";
            this.orderGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.orderGroupBox.Size = new System.Drawing.Size(343, 433);
            this.orderGroupBox.TabIndex = 6;
            this.orderGroupBox.TabStop = false;
            this.orderGroupBox.Text = "Your Order";
            // 
            // cartLogo
            // 
            this.cartLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cartLogo.Image = ((System.Drawing.Image)(resources.GetObject("cartLogo.Image")));
            this.cartLogo.Location = new System.Drawing.Point(302, 26);
            this.cartLogo.Name = "cartLogo";
            this.cartLogo.Size = new System.Drawing.Size(24, 24);
            this.cartLogo.TabIndex = 7;
            this.cartLogo.TabStop = false;
            // 
            // checkoutButton
            // 
            this.checkoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(90)))), ((int)(((byte)(37)))));
            this.checkoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutButton.ForeColor = System.Drawing.Color.Cornsilk;
            this.checkoutButton.Location = new System.Drawing.Point(182, 362);
            this.checkoutButton.Name = "checkoutButton";
            this.checkoutButton.Size = new System.Drawing.Size(144, 39);
            this.checkoutButton.TabIndex = 3;
            this.checkoutButton.Text = "Checkout";
            this.checkoutButton.UseVisualStyleBackColor = false;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(202)))), ((int)(((byte)(68)))));
            this.totalLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(90)))), ((int)(((byte)(37)))));
            this.totalLabel.Location = new System.Drawing.Point(10, 371);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(56, 22);
            this.totalLabel.TabIndex = 2;
            this.totalLabel.Text = "Total";
            // 
            // totalTextBox
            // 
            this.totalTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalTextBox.Location = new System.Drawing.Point(76, 363);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.ReadOnly = true;
            this.totalTextBox.Size = new System.Drawing.Size(100, 32);
            this.totalTextBox.TabIndex = 1;
            // 
            // orderListBox
            // 
            this.orderListBox.BackColor = System.Drawing.Color.White;
            this.orderListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderListBox.FormattingEnabled = true;
            this.orderListBox.ItemHeight = 15;
            this.orderListBox.Location = new System.Drawing.Point(16, 56);
            this.orderListBox.Name = "orderListBox";
            this.orderListBox.ScrollAlwaysVisible = true;
            this.orderListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.orderListBox.Size = new System.Drawing.Size(310, 274);
            this.orderListBox.TabIndex = 0;
            // 
            // pickUpTimer
            // 
            this.pickUpTimer.Tick += new System.EventHandler(this.pickUpTimer_Tick);
            // 
            // CheckoutPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(180)))), ((int)(((byte)(100)))));
            this.BackgroundImage = global::TrevysIconicPizza.Properties.Resources.Pizza;
            this.ClientSize = new System.Drawing.Size(855, 507);
            this.Controls.Add(this.orderGroupBox);
            this.Controls.Add(this.paymentGroupBox);
            this.MaximumSize = new System.Drawing.Size(871, 546);
            this.Name = "CheckoutPage";
            this.Text = "Checkout Page";
            this.Load += new System.EventHandler(this.CheckoutPage_Load);
            this.paymentGroupBox.ResumeLayout(false);
            this.paymentGroupBox.PerformLayout();
            this.orderGroupBox.ResumeLayout(false);
            this.orderGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox paymentGroupBox;
        private System.Windows.Forms.Label delivTimeLabel;
        private System.Windows.Forms.DateTimePicker deliveryDateTimePicker;
        private System.Windows.Forms.Label cardNumberLabel;
        private System.Windows.Forms.TextBox cardNumberTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label serviceLabel;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.RadioButton pickupRadioButton;
        private System.Windows.Forms.TextBox CVVTextBox;
        private System.Windows.Forms.RadioButton deliveryRadioButton;
        private System.Windows.Forms.Label CVVLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.GroupBox orderGroupBox;
        private System.Windows.Forms.PictureBox cartLogo;
        private System.Windows.Forms.Button checkoutButton;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.ListBox orderListBox;
        private System.Windows.Forms.Label pickUpTimeLabel;
        private System.Windows.Forms.Label estimatedPrepTime;
        private System.Windows.Forms.Timer pickUpTimer;
    }
}