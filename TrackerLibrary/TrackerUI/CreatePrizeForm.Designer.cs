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
            PrizePercentageTextBox = new TextBox();
            PrizePercentageLabel = new Label();
            PriceAmountTextBox = new TextBox();
            PrizeAmountLabel = new Label();
            PlaceNameTextBox = new TextBox();
            PlaceNameLabel = new Label();
            PlaceNumberTextBox = new TextBox();
            PlaceNumberLabel = new Label();
            label1 = new Label();
            CreatePrizeButton = new Button();
            SuspendLayout();
            // 
            // PrizePercentageTextBox
            // 
            PrizePercentageTextBox.Location = new Point(262, 291);
            PrizePercentageTextBox.Margin = new Padding(3, 4, 3, 4);
            PrizePercentageTextBox.Name = "PrizePercentageTextBox";
            PrizePercentageTextBox.Size = new Size(209, 27);
            PrizePercentageTextBox.TabIndex = 39;
            // 
            // PrizePercentageLabel
            // 
            PrizePercentageLabel.AutoSize = true;
            PrizePercentageLabel.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            PrizePercentageLabel.Location = new Point(50, 289);
            PrizePercentageLabel.Name = "PrizePercentageLabel";
            PrizePercentageLabel.Size = new Size(232, 31);
            PrizePercentageLabel.TabIndex = 41;
            PrizePercentageLabel.Text = "Prize Percentage  :";
            // 
            // PriceAmountTextBox
            // 
            PriceAmountTextBox.Location = new Point(262, 208);
            PriceAmountTextBox.Margin = new Padding(3, 4, 3, 4);
            PriceAmountTextBox.Name = "PriceAmountTextBox";
            PriceAmountTextBox.Size = new Size(209, 27);
            PriceAmountTextBox.TabIndex = 40;
            // 
            // PrizeAmountLabel
            // 
            PrizeAmountLabel.AutoSize = true;
            PrizeAmountLabel.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            PrizeAmountLabel.Location = new Point(85, 207);
            PrizeAmountLabel.Name = "PrizeAmountLabel";
            PrizeAmountLabel.Size = new Size(197, 31);
            PrizeAmountLabel.TabIndex = 42;
            PrizeAmountLabel.Text = "Prize Amount : ";
            // 
            // PlaceNameTextBox
            // 
            PlaceNameTextBox.Location = new Point(262, 169);
            PlaceNameTextBox.Margin = new Padding(3, 4, 3, 4);
            PlaceNameTextBox.Name = "PlaceNameTextBox";
            PlaceNameTextBox.Size = new Size(209, 27);
            PlaceNameTextBox.TabIndex = 37;
            // 
            // PlaceNameLabel
            // 
            PlaceNameLabel.AutoSize = true;
            PlaceNameLabel.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            PlaceNameLabel.Location = new Point(86, 168);
            PlaceNameLabel.Name = "PlaceNameLabel";
            PlaceNameLabel.Size = new Size(168, 31);
            PlaceNameLabel.TabIndex = 38;
            PlaceNameLabel.Text = "Place Name :";
            // 
            // PlaceNumberTextBox
            // 
            PlaceNumberTextBox.Location = new Point(262, 131);
            PlaceNumberTextBox.Margin = new Padding(3, 4, 3, 4);
            PlaceNumberTextBox.Name = "PlaceNumberTextBox";
            PlaceNumberTextBox.Size = new Size(209, 27);
            PlaceNumberTextBox.TabIndex = 35;
            // 
            // PlaceNumberLabel
            // 
            PlaceNumberLabel.AutoSize = true;
            PlaceNumberLabel.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            PlaceNumberLabel.Location = new Point(86, 125);
            PlaceNumberLabel.Name = "PlaceNumberLabel";
            PlaceNumberLabel.Size = new Size(196, 31);
            PlaceNumberLabel.TabIndex = 36;
            PlaceNumberLabel.Text = "Place Number :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(181, 255);
            label1.Name = "label1";
            label1.Size = new Size(119, 31);
            label1.TabIndex = 43;
            label1.Text = "-- OR --  ";
            // 
            // CreatePrizeButton
            // 
            CreatePrizeButton.Location = new Point(195, 367);
            CreatePrizeButton.Margin = new Padding(3, 4, 3, 4);
            CreatePrizeButton.Name = "CreatePrizeButton";
            CreatePrizeButton.Size = new Size(149, 43);
            CreatePrizeButton.TabIndex = 44;
            CreatePrizeButton.Text = "Create Prize";
            CreatePrizeButton.UseVisualStyleBackColor = true;
            CreatePrizeButton.Click += CreatePrizeButton_Click;
            // 
            // CreatePrizeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 600);
            Controls.Add(CreatePrizeButton);
            Controls.Add(label1);
            Controls.Add(PrizePercentageTextBox);
            Controls.Add(PrizePercentageLabel);
            Controls.Add(PriceAmountTextBox);
            Controls.Add(PrizeAmountLabel);
            Controls.Add(PlaceNameTextBox);
            Controls.Add(PlaceNameLabel);
            Controls.Add(PlaceNumberTextBox);
            Controls.Add(PlaceNumberLabel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CreatePrizeForm";
            Text = "CreatePrizeForm";
            ResumeLayout(false);
            PerformLayout();
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