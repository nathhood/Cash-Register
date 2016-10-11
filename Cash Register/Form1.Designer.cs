namespace Cash_Register
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.calculateTotalButton = new System.Windows.Forms.Button();
            this.numberDrinksLabel = new System.Windows.Forms.Label();
            this.numberBurgersLabel = new System.Windows.Forms.Label();
            this.numberFriesLabel = new System.Windows.Forms.Label();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalButton = new System.Windows.Forms.Label();
            this.subTotalOutput = new System.Windows.Forms.Label();
            this.taxOutput = new System.Windows.Forms.Label();
            this.totalOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(273, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(273, 75);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(273, 120);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 2;
            // 
            // calculateTotalButton
            // 
            this.calculateTotalButton.Location = new System.Drawing.Point(86, 181);
            this.calculateTotalButton.Name = "calculateTotalButton";
            this.calculateTotalButton.Size = new System.Drawing.Size(220, 40);
            this.calculateTotalButton.TabIndex = 3;
            this.calculateTotalButton.Text = "Calculate Total";
            this.calculateTotalButton.UseVisualStyleBackColor = true;
            this.calculateTotalButton.Click += new System.EventHandler(this.calculateTotalButton_Click);
            // 
            // numberDrinksLabel
            // 
            this.numberDrinksLabel.AutoSize = true;
            this.numberDrinksLabel.Location = new System.Drawing.Point(12, 123);
            this.numberDrinksLabel.Name = "numberDrinksLabel";
            this.numberDrinksLabel.Size = new System.Drawing.Size(118, 17);
            this.numberDrinksLabel.TabIndex = 4;
            this.numberDrinksLabel.Text = "Number of Drinks";
            // 
            // numberBurgersLabel
            // 
            this.numberBurgersLabel.AutoSize = true;
            this.numberBurgersLabel.Location = new System.Drawing.Point(12, 35);
            this.numberBurgersLabel.Name = "numberBurgersLabel";
            this.numberBurgersLabel.Size = new System.Drawing.Size(128, 17);
            this.numberBurgersLabel.TabIndex = 5;
            this.numberBurgersLabel.Text = "Number of Burgers";
            // 
            // numberFriesLabel
            // 
            this.numberFriesLabel.AutoSize = true;
            this.numberFriesLabel.Location = new System.Drawing.Point(12, 78);
            this.numberFriesLabel.Name = "numberFriesLabel";
            this.numberFriesLabel.Size = new System.Drawing.Size(109, 17);
            this.numberFriesLabel.TabIndex = 6;
            this.numberFriesLabel.Text = "Number of Fries";
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.Location = new System.Drawing.Point(12, 255);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(60, 17);
            this.subtotalLabel.TabIndex = 7;
            this.subtotalLabel.Text = "Subtotal";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Location = new System.Drawing.Point(12, 293);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(31, 17);
            this.taxLabel.TabIndex = 8;
            this.taxLabel.Text = "Tax";
            // 
            // totalButton
            // 
            this.totalButton.AutoSize = true;
            this.totalButton.Location = new System.Drawing.Point(12, 332);
            this.totalButton.Name = "totalButton";
            this.totalButton.Size = new System.Drawing.Size(40, 17);
            this.totalButton.TabIndex = 9;
            this.totalButton.Text = "Total";
            // 
            // subTotalOutput
            // 
            this.subTotalOutput.Location = new System.Drawing.Point(270, 255);
            this.subTotalOutput.Name = "subTotalOutput";
            this.subTotalOutput.Size = new System.Drawing.Size(100, 23);
            this.subTotalOutput.TabIndex = 10;
            this.subTotalOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // taxOutput
            // 
            this.taxOutput.Location = new System.Drawing.Point(270, 293);
            this.taxOutput.Name = "taxOutput";
            this.taxOutput.Size = new System.Drawing.Size(100, 23);
            this.taxOutput.TabIndex = 11;
            // 
            // totalOutput
            // 
            this.totalOutput.Location = new System.Drawing.Point(270, 332);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(100, 23);
            this.totalOutput.TabIndex = 12;
            this.totalOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 536);
            this.Controls.Add(this.totalOutput);
            this.Controls.Add(this.taxOutput);
            this.Controls.Add(this.subTotalOutput);
            this.Controls.Add(this.totalButton);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.numberFriesLabel);
            this.Controls.Add(this.numberBurgersLabel);
            this.Controls.Add(this.numberDrinksLabel);
            this.Controls.Add(this.calculateTotalButton);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "BLob\'s Burger Bananza";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button calculateTotalButton;
        private System.Windows.Forms.Label numberDrinksLabel;
        private System.Windows.Forms.Label numberBurgersLabel;
        private System.Windows.Forms.Label numberFriesLabel;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalButton;
        private System.Windows.Forms.Label subTotalOutput;
        private System.Windows.Forms.Label taxOutput;
        private System.Windows.Forms.Label totalOutput;
    }
}

