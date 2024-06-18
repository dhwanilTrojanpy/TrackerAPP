namespace TrackerUI
{
    partial class TournamentViewer
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
            this.label1 = new System.Windows.Forms.Label();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.TournamentNameLabel = new System.Windows.Forms.Label();
            this.RoundLabel = new System.Windows.Forms.Label();
            this.RoundComboBox = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.TournamentListBox = new System.Windows.Forms.ListBox();
            this.TeamOneLabel = new System.Windows.Forms.Label();
            this.TeamTwoLabel = new System.Windows.Forms.Label();
            this.TeamOneScoreLabel = new System.Windows.Forms.Label();
            this.TeamTwoScoreLabel = new System.Windows.Forms.Label();
            this.TeamOneScoreTextBox = new System.Windows.Forms.TextBox();
            this.TeamTwoScoreTextBox = new System.Windows.Forms.TextBox();
            this.VSLabel = new System.Windows.Forms.Label();
            this.ScoreButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(241, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HeaderLabel.Location = new System.Drawing.Point(24, 34);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(135, 24);
            this.HeaderLabel.TabIndex = 0;
            this.HeaderLabel.Text = "Tournament : ";
            // 
            // TournamentNameLabel
            // 
            this.TournamentNameLabel.AutoSize = true;
            this.TournamentNameLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TournamentNameLabel.Location = new System.Drawing.Point(157, 34);
            this.TournamentNameLabel.Name = "TournamentNameLabel";
            this.TournamentNameLabel.Size = new System.Drawing.Size(81, 24);
            this.TournamentNameLabel.TabIndex = 1;
            this.TournamentNameLabel.Text = "<None>";
            // 
            // RoundLabel
            // 
            this.RoundLabel.AutoSize = true;
            this.RoundLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RoundLabel.Location = new System.Drawing.Point(24, 101);
            this.RoundLabel.Name = "RoundLabel";
            this.RoundLabel.Size = new System.Drawing.Size(81, 24);
            this.RoundLabel.TabIndex = 2;
            this.RoundLabel.Text = "Round :";
            // 
            // RoundComboBox
            // 
            this.RoundComboBox.FormattingEnabled = true;
            this.RoundComboBox.Location = new System.Drawing.Point(111, 101);
            this.RoundComboBox.Name = "RoundComboBox";
            this.RoundComboBox.Size = new System.Drawing.Size(121, 31);
            this.RoundComboBox.TabIndex = 3;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.Location = new System.Drawing.Point(107, 141);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(160, 28);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Unplayed Only";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // TournamentListBox
            // 
            this.TournamentListBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TournamentListBox.FormattingEnabled = true;
            this.TournamentListBox.ItemHeight = 15;
            this.TournamentListBox.Location = new System.Drawing.Point(24, 175);
            this.TournamentListBox.Name = "TournamentListBox";
            this.TournamentListBox.Size = new System.Drawing.Size(233, 169);
            this.TournamentListBox.TabIndex = 5;
            // 
            // TeamOneLabel
            // 
            this.TeamOneLabel.AutoSize = true;
            this.TeamOneLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TeamOneLabel.Location = new System.Drawing.Point(359, 145);
            this.TeamOneLabel.Name = "TeamOneLabel";
            this.TeamOneLabel.Size = new System.Drawing.Size(106, 24);
            this.TeamOneLabel.TabIndex = 6;
            this.TeamOneLabel.Text = "Team One ";
            // 
            // TeamTwoLabel
            // 
            this.TeamTwoLabel.AutoSize = true;
            this.TeamTwoLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TeamTwoLabel.Location = new System.Drawing.Point(359, 320);
            this.TeamTwoLabel.Name = "TeamTwoLabel";
            this.TeamTwoLabel.Size = new System.Drawing.Size(106, 24);
            this.TeamTwoLabel.TabIndex = 7;
            this.TeamTwoLabel.Text = "Team Two ";
            // 
            // TeamOneScoreLabel
            // 
            this.TeamOneScoreLabel.AutoSize = true;
            this.TeamOneScoreLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TeamOneScoreLabel.Location = new System.Drawing.Point(313, 187);
            this.TeamOneScoreLabel.Name = "TeamOneScoreLabel";
            this.TeamOneScoreLabel.Size = new System.Drawing.Size(73, 24);
            this.TeamOneScoreLabel.TabIndex = 8;
            this.TeamOneScoreLabel.Text = "Score :";
            // 
            // TeamTwoScoreLabel
            // 
            this.TeamTwoScoreLabel.AutoSize = true;
            this.TeamTwoScoreLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TeamTwoScoreLabel.Location = new System.Drawing.Point(313, 281);
            this.TeamTwoScoreLabel.Name = "TeamTwoScoreLabel";
            this.TeamTwoScoreLabel.Size = new System.Drawing.Size(73, 24);
            this.TeamTwoScoreLabel.TabIndex = 9;
            this.TeamTwoScoreLabel.Text = "Score :";
            // 
            // TeamOneScoreTextBox
            // 
            this.TeamOneScoreTextBox.Location = new System.Drawing.Point(392, 185);
            this.TeamOneScoreTextBox.Name = "TeamOneScoreTextBox";
            this.TeamOneScoreTextBox.Size = new System.Drawing.Size(100, 32);
            this.TeamOneScoreTextBox.TabIndex = 10;
            // 
            // TeamTwoScoreTextBox
            // 
            this.TeamTwoScoreTextBox.Location = new System.Drawing.Point(392, 279);
            this.TeamTwoScoreTextBox.Name = "TeamTwoScoreTextBox";
            this.TeamTwoScoreTextBox.Size = new System.Drawing.Size(100, 32);
            this.TeamTwoScoreTextBox.TabIndex = 11;
            // 
            // VSLabel
            // 
            this.VSLabel.AutoSize = true;
            this.VSLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.VSLabel.Location = new System.Drawing.Point(359, 234);
            this.VSLabel.Name = "VSLabel";
            this.VSLabel.Size = new System.Drawing.Size(75, 24);
            this.VSLabel.TabIndex = 12;
            this.VSLabel.Text = "-- VS --";
            // 
            // ScoreButton
            // 
            this.ScoreButton.Location = new System.Drawing.Point(187, 380);
            this.ScoreButton.Name = "ScoreButton";
            this.ScoreButton.Size = new System.Drawing.Size(130, 32);
            this.ScoreButton.TabIndex = 13;
            this.ScoreButton.Text = "Score";
            this.ScoreButton.UseVisualStyleBackColor = true;
            // 
            // TournamentViewer
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(575, 447);
            this.Controls.Add(this.ScoreButton);
            this.Controls.Add(this.VSLabel);
            this.Controls.Add(this.TeamTwoScoreTextBox);
            this.Controls.Add(this.TeamOneScoreTextBox);
            this.Controls.Add(this.TeamTwoScoreLabel);
            this.Controls.Add(this.TeamOneScoreLabel);
            this.Controls.Add(this.TeamTwoLabel);
            this.Controls.Add(this.TeamOneLabel);
            this.Controls.Add(this.TournamentListBox);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.RoundComboBox);
            this.Controls.Add(this.RoundLabel);
            this.Controls.Add(this.TournamentNameLabel);
            this.Controls.Add(this.HeaderLabel);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "TournamentViewer";
            this.Text = "Tournament Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label HeaderLabel;
        private Label TournamentNameLabel;
        private Label RoundLabel;
        private ComboBox RoundComboBox;
        private CheckBox checkBox1;
        private ListBox TournamentListBox;
        private Label TeamOneLabel;
        private Label TeamTwoLabel;
        private Label TeamOneScoreLabel;
        private Label TeamTwoScoreLabel;
        private TextBox TeamOneScoreTextBox;
        private TextBox TeamTwoScoreTextBox;
        private Label VSLabel;
        private Button ScoreButton;
    }
}