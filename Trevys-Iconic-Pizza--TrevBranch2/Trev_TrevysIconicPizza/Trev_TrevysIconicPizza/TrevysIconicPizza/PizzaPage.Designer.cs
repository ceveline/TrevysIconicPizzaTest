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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(73, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 67);
            this.button1.TabIndex = 0;
            this.button1.Text = "PIZZA";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(309, 121);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 67);
            this.button2.TabIndex = 1;
            this.button2.Text = "DRINKS";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // MenuPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(568, 309);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "MenuPage";
            this.Text = "PizzaPage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}