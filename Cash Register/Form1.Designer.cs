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
            this.burgersInput = new System.Windows.Forms.TextBox();
            this.friesInput = new System.Windows.Forms.TextBox();
            this.drinksInput = new System.Windows.Forms.TextBox();
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
            this.tenderedInput = new System.Windows.Forms.TextBox();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.changeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.changeOutput = new System.Windows.Forms.Label();
            this.printReceiptButton = new System.Windows.Forms.Button();
            this.invalidOrderLabel = new System.Windows.Forms.Label();
            this.newOrderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // burgersInput
            // 
            this.burgersInput.Location = new System.Drawing.Point(273, 30);
            this.burgersInput.Name = "burgersInput";
            this.burgersInput.Size = new System.Drawing.Size(100, 22);
            this.burgersInput.TabIndex = 0;
            this.burgersInput.Text = "0";
            // 
            // friesInput
            // 
            this.friesInput.Location = new System.Drawing.Point(273, 75);
            this.friesInput.Name = "friesInput";
            this.friesInput.Size = new System.Drawing.Size(100, 22);
            this.friesInput.TabIndex = 1;
            this.friesInput.Text = "0";
            // 
            // drinksInput
            // 
            this.drinksInput.Location = new System.Drawing.Point(273, 120);
            this.drinksInput.Name = "drinksInput";
            this.drinksInput.Size = new System.Drawing.Size(100, 22);
            this.drinksInput.TabIndex = 2;
            this.drinksInput.Text = "0";
            // 
            // calculateTotalButton
            // 
            this.calculateTotalButton.Location = new System.Drawing.Point(84, 161);
            this.calculateTotalButton.Name = "calculateTotalButton";
            this.calculateTotalButton.Size = new System.Drawing.Size(220, 26);
            this.calculateTotalButton.TabIndex = 3;
            this.calculateTotalButton.Text = "Calculate Totals";
            this.calculateTotalButton.UseVisualStyleBackColor = true;
            this.calculateTotalButton.Click += new System.EventHandler(this.calculateTotalButton_Click);
            // 
            // numberDrinksLabel
            // 
            this.numberDrinksLabel.AutoSize = true;
            this.numberDrinksLabel.ForeColor = System.Drawing.Color.White;
            this.numberDrinksLabel.Location = new System.Drawing.Point(12, 123);
            this.numberDrinksLabel.Name = "numberDrinksLabel";
            this.numberDrinksLabel.Size = new System.Drawing.Size(118, 17);
            this.numberDrinksLabel.TabIndex = 4;
            this.numberDrinksLabel.Text = "Number of Drinks";
            // 
            // numberBurgersLabel
            // 
            this.numberBurgersLabel.AutoSize = true;
            this.numberBurgersLabel.ForeColor = System.Drawing.Color.White;
            this.numberBurgersLabel.Location = new System.Drawing.Point(12, 35);
            this.numberBurgersLabel.Name = "numberBurgersLabel";
            this.numberBurgersLabel.Size = new System.Drawing.Size(128, 17);
            this.numberBurgersLabel.TabIndex = 5;
            this.numberBurgersLabel.Text = "Number of Burgers";
            // 
            // numberFriesLabel
            // 
            this.numberFriesLabel.AutoSize = true;
            this.numberFriesLabel.ForeColor = System.Drawing.Color.White;
            this.numberFriesLabel.Location = new System.Drawing.Point(12, 78);
            this.numberFriesLabel.Name = "numberFriesLabel";
            this.numberFriesLabel.Size = new System.Drawing.Size(109, 17);
            this.numberFriesLabel.TabIndex = 6;
            this.numberFriesLabel.Text = "Number of Fries";
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.ForeColor = System.Drawing.Color.White;
            this.subtotalLabel.Location = new System.Drawing.Point(12, 208);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(60, 17);
            this.subtotalLabel.TabIndex = 7;
            this.subtotalLabel.Text = "Subtotal";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.ForeColor = System.Drawing.Color.White;
            this.taxLabel.Location = new System.Drawing.Point(12, 246);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(31, 17);
            this.taxLabel.TabIndex = 8;
            this.taxLabel.Text = "Tax";
            // 
            // totalButton
            // 
            this.totalButton.AutoSize = true;
            this.totalButton.ForeColor = System.Drawing.Color.White;
            this.totalButton.Location = new System.Drawing.Point(12, 288);
            this.totalButton.Name = "totalButton";
            this.totalButton.Size = new System.Drawing.Size(40, 17);
            this.totalButton.TabIndex = 9;
            this.totalButton.Text = "Total";
            // 
            // subTotalOutput
            // 
            this.subTotalOutput.AutoSize = true;
            this.subTotalOutput.BackColor = System.Drawing.Color.Transparent;
            this.subTotalOutput.ForeColor = System.Drawing.Color.White;
            this.subTotalOutput.Location = new System.Drawing.Point(270, 208);
            this.subTotalOutput.Name = "subTotalOutput";
            this.subTotalOutput.Size = new System.Drawing.Size(0, 17);
            this.subTotalOutput.TabIndex = 10;
            this.subTotalOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // taxOutput
            // 
            this.taxOutput.AutoSize = true;
            this.taxOutput.BackColor = System.Drawing.Color.Transparent;
            this.taxOutput.ForeColor = System.Drawing.Color.White;
            this.taxOutput.Location = new System.Drawing.Point(270, 246);
            this.taxOutput.Name = "taxOutput";
            this.taxOutput.Size = new System.Drawing.Size(0, 17);
            this.taxOutput.TabIndex = 11;
            this.taxOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // totalOutput
            // 
            this.totalOutput.AutoSize = true;
            this.totalOutput.BackColor = System.Drawing.Color.Transparent;
            this.totalOutput.ForeColor = System.Drawing.Color.White;
            this.totalOutput.Location = new System.Drawing.Point(270, 285);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(0, 17);
            this.totalOutput.TabIndex = 12;
            this.totalOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tenderedInput
            // 
            this.tenderedInput.Location = new System.Drawing.Point(273, 342);
            this.tenderedInput.Name = "tenderedInput";
            this.tenderedInput.Size = new System.Drawing.Size(100, 22);
            this.tenderedInput.TabIndex = 13;
            this.tenderedInput.Text = "0";
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.AutoSize = true;
            this.tenderedLabel.ForeColor = System.Drawing.Color.White;
            this.tenderedLabel.Location = new System.Drawing.Point(12, 345);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(70, 17);
            this.tenderedLabel.TabIndex = 14;
            this.tenderedLabel.Text = "Tendered";
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(84, 378);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(220, 26);
            this.changeButton.TabIndex = 15;
            this.changeButton.Text = "Calculate Change";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 426);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Change";
            // 
            // changeOutput
            // 
            this.changeOutput.AutoSize = true;
            this.changeOutput.ForeColor = System.Drawing.Color.White;
            this.changeOutput.Location = new System.Drawing.Point(270, 426);
            this.changeOutput.Name = "changeOutput";
            this.changeOutput.Size = new System.Drawing.Size(0, 17);
            this.changeOutput.TabIndex = 17;
            // 
            // printReceiptButton
            // 
            this.printReceiptButton.AutoSize = true;
            this.printReceiptButton.Location = new System.Drawing.Point(84, 466);
            this.printReceiptButton.Name = "printReceiptButton";
            this.printReceiptButton.Size = new System.Drawing.Size(220, 27);
            this.printReceiptButton.TabIndex = 18;
            this.printReceiptButton.Text = "Print Receipt";
            this.printReceiptButton.UseVisualStyleBackColor = true;
            this.printReceiptButton.Click += new System.EventHandler(this.printReceiptButton_Click);
            // 
            // invalidOrderLabel
            // 
            this.invalidOrderLabel.ForeColor = System.Drawing.Color.White;
            this.invalidOrderLabel.Location = new System.Drawing.Point(84, 496);
            this.invalidOrderLabel.Name = "invalidOrderLabel";
            this.invalidOrderLabel.Size = new System.Drawing.Size(220, 23);
            this.invalidOrderLabel.TabIndex = 19;
            // 
            // newOrderButton
            // 
            this.newOrderButton.Location = new System.Drawing.Point(397, 468);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(252, 23);
            this.newOrderButton.TabIndex = 20;
            this.newOrderButton.Text = "New Order";
            this.newOrderButton.UseVisualStyleBackColor = true;
            this.newOrderButton.Click += new System.EventHandler(this.newOrderButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(661, 536);
            this.Controls.Add(this.newOrderButton);
            this.Controls.Add(this.invalidOrderLabel);
            this.Controls.Add(this.printReceiptButton);
            this.Controls.Add(this.changeOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.tenderedInput);
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
            this.Controls.Add(this.drinksInput);
            this.Controls.Add(this.friesInput);
            this.Controls.Add(this.burgersInput);
            this.Name = "Form1";
            this.Text = "BLob\'s Burger Bananza";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox burgersInput;
        private System.Windows.Forms.TextBox friesInput;
        private System.Windows.Forms.TextBox drinksInput;
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
        private System.Windows.Forms.TextBox tenderedInput;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label changeOutput;
        private System.Windows.Forms.Button printReceiptButton;
        private System.Windows.Forms.Label invalidOrderLabel;
        private System.Windows.Forms.Button newOrderButton;
    }
}

