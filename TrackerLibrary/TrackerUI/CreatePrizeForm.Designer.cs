namespace TrackerUI
{
    partial class CreatePrizeForm
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
            this.PrizePercentageTextBox = new System.Windows.Forms.TextBox();
            this.PrizePercentageLabel = new System.Windows.Forms.Label();
            this.PriceAmountTextBox = new System.Windows.Forms.TextBox();
            this.PrizeAmountLabel = new System.Windows.Forms.Label();
            this.PlaceNameTextBox = new System.Windows.Forms.TextBox();
            this.PlaceNameLabel = new System.Windows.Forms.Label();
            this.PlaceNumberTextBox = new System.Windows.Forms.TextBox();
            this.PlaceNumberLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CreatePrizeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PrizePercentageTextBox
            // 
            this.PrizePercentageTextBox.Location = new System.Drawing.Point(229, 218);
            this.PrizePercentageTextBox.Name = "PrizePercentageTextBox";
            this.PrizePercentageTextBox.Size = new System.Drawing.Size(183, 23);
            this.PrizePercentageTextBox.TabIndex = 39;
            // 
            // PrizePercentageLabel
            // 
            this.PrizePercentageLabel.AutoSize = true;
            this.PrizePercentageLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PrizePercentageLabel.Location = new System.Drawing.Point(44, 217);
            this.PrizePercentageLabel.Name = "PrizePercentageLabel";
            this.PrizePercentageLabel.Size = new System.Drawing.Size(180, 24);
            this.PrizePercentageLabel.TabIndex = 41;
            this.PrizePercentageLabel.Text = "Prize Percentage  :";
            // 
            // PriceAmountTextBox
            // 
            this.PriceAmountTextBox.Location = new System.Drawing.Point(229, 156);
            this.PriceAmountTextBox.Name = "PriceAmountTextBox";
            this.PriceAmountTextBox.Size = new System.Drawing.Size(183, 23);
            this.PriceAmountTextBox.TabIndex = 40;
            // 
            // PrizeAmountLabel
            // 
            this.PrizeAmountLabel.AutoSize = true;
            this.PrizeAmountLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PrizeAmountLabel.Location = new System.Drawing.Point(74, 155);
            this.PrizeAmountLabel.Name = "PrizeAmountLabel";
            this.PrizeAmountLabel.Size = new System.Drawing.Size(149, 24);
            this.PrizeAmountLabel.TabIndex = 42;
            this.PrizeAmountLabel.Text = "Prize Amount : ";
            // 
            // PlaceNameTextBox
            // 
            this.PlaceNameTextBox.Location = new System.Drawing.Point(229, 127);
            this.PlaceNameTextBox.Name = "PlaceNameTextBox";
            this.PlaceNameTextBox.Size = new System.Drawing.Size(183, 23);
            this.PlaceNameTextBox.TabIndex = 37;
            // 
            // PlaceNameLabel
            // 
            this.PlaceNameLabel.AutoSize = true;
            this.PlaceNameLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PlaceNameLabel.Location = new System.Drawing.Point(75, 126);
            this.PlaceNameLabel.Name = "PlaceNameLabel";
            this.PlaceNameLabel.Size = new System.Drawing.Size(130, 24);
            this.PlaceNameLabel.TabIndex = 38;
            this.PlaceNameLabel.Text = "Place Name :";
            // 
            // PlaceNumberTextBox
            // 
            this.PlaceNumberTextBox.Location = new System.Drawing.Point(229, 98);
            this.PlaceNumberTextBox.Name = "PlaceNumberTextBox";
            this.PlaceNumberTextBox.Size = new System.Drawing.Size(183, 23);
            this.PlaceNumberTextBox.TabIndex = 35;
            // 
            // PlaceNumberLabel
            // 
            this.PlaceNumberLabel.AutoSize = true;
            this.PlaceNumberLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PlaceNumberLabel.Location = new System.Drawing.Point(75, 94);
            this.PlaceNumberLabel.Name = "PlaceNumberLabel";
            this.PlaceNumberLabel.Size = new System.Drawing.Size(149, 24);
            this.PlaceNumberLabel.TabIndex = 36;
            this.PlaceNumberLabel.Text = "Place Number :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(158, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 24);
            this.label1.TabIndex = 43;
            this.label1.Text = "-- OR --  ";
            // 
            // CreatePrizeButton
            // 
            this.CreatePrizeButton.Location = new System.Drawing.Point(171, 275);
            this.CreatePrizeButton.Name = "CreatePrizeButton";
            this.CreatePrizeButton.Size = new System.Drawing.Size(130, 32);
            this.CreatePrizeButton.TabIndex = 44;
            this.CreatePrizeButton.Text = "Create Prize";
            this.CreatePrizeButton.UseVisualStyleBackColor = true;
            // 
            // CreatePrizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 450);
            this.Controls.Add(this.CreatePrizeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PrizePercentageTextBox);
            this.Controls.Add(this.PrizePercentageLabel);
            this.Controls.Add(this.PriceAmountTextBox);
            this.Controls.Add(this.PrizeAmountLabel);
            this.Controls.Add(this.PlaceNameTextBox);
            this.Controls.Add(this.PlaceNameLabel);
            this.Controls.Add(this.PlaceNumberTextBox);
            this.Controls.Add(this.PlaceNumberLabel);
            this.Name = "CreatePrizeForm";
            this.Text = "CreatePrizeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox PrizePercentageTextBox;
        private Label PrizePercentageLabel;
        private TextBox PriceAmountTextBox;
        private Label PrizeAmountLabel;
        private TextBox PlaceNameTextBox;
        private Label PlaceNameLabel;
        private TextBox PlaceNumberTextBox;
        private Label PlaceNumberLabel;
        private Label label1;
        private Button CreatePrizeButton;
    }
}