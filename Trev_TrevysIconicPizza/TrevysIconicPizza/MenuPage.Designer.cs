namespace TrevysIconicPizza
{
    partial class MenuPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPage));
            this.pizzaButton = new System.Windows.Forms.Button();
            this.drinkButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.accountLogo = new System.Windows.Forms.PictureBox();
            this.questionLogo = new System.Windows.Forms.PictureBox();
            this.cartLogo = new System.Windows.Forms.PictureBox();
            this.menuPageTimerLabel = new System.Windows.Forms.Label();
            this.menuPageTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pizzaButton
            // 
            this.pizzaButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(90)))), ((int)(((byte)(37)))));
            this.pizzaButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pizzaButton.ForeColor = System.Drawing.Color.Cornsilk;
            this.pizzaButton.Location = new System.Drawing.Point(94, 261);
            this.pizzaButton.Name = "pizzaButton";
            this.pizzaButton.Size = new System.Drawing.Size(203, 77);
            this.pizzaButton.TabIndex = 0;
            this.pizzaButton.Text = "PIZZA";
            this.pizzaButton.UseVisualStyleBackColor = false;
            this.pizzaButton.Click += new System.EventHandler(this.pizzaButton_Click);
            // 
            // drinkButton
            // 
            this.drinkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(90)))), ((int)(((byte)(37)))));
            this.drinkButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinkButton.ForeColor = System.Drawing.Color.Cornsilk;
            this.drinkButton.Location = new System.Drawing.Point(330, 261);
            this.drinkButton.Name = "drinkButton";
            this.drinkButton.Size = new System.Drawing.Size(203, 77);
            this.drinkButton.TabIndex = 1;
            this.drinkButton.Text = "DRINKS";
            this.drinkButton.UseVisualStyleBackColor = false;
            this.drinkButton.Click += new System.EventHandler(this.drinkButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(193, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(241, 224);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // accountLogo
            // 
            this.accountLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.accountLogo.Image = ((System.Drawing.Image)(resources.GetObject("accountLogo.Image")));
            this.accountLogo.Location = new System.Drawing.Point(12, 12);
            this.accountLogo.Name = "accountLogo";
            this.accountLogo.Size = new System.Drawing.Size(24, 24);
            this.accountLogo.TabIndex = 3;
            this.accountLogo.TabStop = false;
            this.accountLogo.Click += new System.EventHandler(this.accountLogo_Click);
            // 
            // questionLogo
            // 
            this.questionLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.questionLogo.Image = ((System.Drawing.Image)(resources.GetObject("questionLogo.Image")));
            this.questionLogo.Location = new System.Drawing.Point(549, 12);
            this.questionLogo.Name = "questionLogo";
            this.questionLogo.Size = new System.Drawing.Size(24, 24);
            this.questionLogo.TabIndex = 4;
            this.questionLogo.TabStop = false;
            this.questionLogo.Click += new System.EventHandler(this.questionLogo_Click);
            // 
            // cartLogo
            // 
            this.cartLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cartLogo.Image = ((System.Drawing.Image)(resources.GetObject("cartLogo.Image")));
            this.cartLogo.Location = new System.Drawing.Point(590, 12);
            this.cartLogo.Name = "cartLogo";
            this.cartLogo.Size = new System.Drawing.Size(24, 24);
            this.cartLogo.TabIndex = 5;
            this.cartLogo.TabStop = false;
            this.cartLogo.Click += new System.EventHandler(this.cartLogo_Click);
            // 
            // menuPageTimerLabel
            // 
            this.menuPageTimerLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(90)))), ((int)(((byte)(37)))));
            this.menuPageTimerLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuPageTimerLabel.ForeColor = System.Drawing.Color.Cornsilk;
            this.menuPageTimerLabel.Location = new System.Drawing.Point(421, 13);
            this.menuPageTimerLabel.Name = "menuPageTimerLabel";
            this.menuPageTimerLabel.Size = new System.Drawing.Size(112, 23);
            this.menuPageTimerLabel.TabIndex = 6;
            this.menuPageTimerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuPageTimer
            // 
            this.menuPageTimer.Interval = 1000;
            this.menuPageTimer.Tick += new System.EventHandler(this.menuPageTimer_Tick);
            // 
            // MenuPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(180)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(626, 365);
            this.Controls.Add(this.menuPageTimerLabel);
            this.Controls.Add(this.cartLogo);
            this.Controls.Add(this.questionLogo);
            this.Controls.Add(this.accountLogo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.drinkButton);
            this.Controls.Add(this.pizzaButton);
            this.Name = "MenuPage";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button pizzaButton;
        private System.Windows.Forms.Button drinkButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox accountLogo;
        private System.Windows.Forms.PictureBox questionLogo;
        private System.Windows.Forms.PictureBox cartLogo;
        private System.Windows.Forms.Label menuPageTimerLabel;
        private System.Windows.Forms.Timer menuPageTimer;
    }
}