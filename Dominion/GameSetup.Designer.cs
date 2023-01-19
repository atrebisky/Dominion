namespace Dominion
{
    partial class GameSetup
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
            this.GameSettings = new System.Windows.Forms.GroupBox();
            this.NumberOfPlayersSelected = new System.Windows.Forms.NumericUpDown();
            this.NumberOfPlayersLabel = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.StartGameButton = new System.Windows.Forms.Button();
            this.GameSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfPlayersSelected)).BeginInit();
            this.SuspendLayout();
            // 
            // GameSettings
            // 
            this.GameSettings.Controls.Add(this.NumberOfPlayersSelected);
            this.GameSettings.Controls.Add(this.NumberOfPlayersLabel);
            this.GameSettings.Location = new System.Drawing.Point(23, 12);
            this.GameSettings.Name = "GameSettings";
            this.GameSettings.Size = new System.Drawing.Size(306, 216);
            this.GameSettings.TabIndex = 0;
            this.GameSettings.TabStop = false;
            this.GameSettings.Text = "Game Settings";
            // 
            // NumberOfPlayersSelected
            // 
            this.NumberOfPlayersSelected.Location = new System.Drawing.Point(122, 24);
            this.NumberOfPlayersSelected.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.NumberOfPlayersSelected.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NumberOfPlayersSelected.Name = "NumberOfPlayersSelected";
            this.NumberOfPlayersSelected.Size = new System.Drawing.Size(120, 20);
            this.NumberOfPlayersSelected.TabIndex = 3;
            this.NumberOfPlayersSelected.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // NumberOfPlayersLabel
            // 
            this.NumberOfPlayersLabel.AutoSize = true;
            this.NumberOfPlayersLabel.Location = new System.Drawing.Point(23, 26);
            this.NumberOfPlayersLabel.Name = "NumberOfPlayersLabel";
            this.NumberOfPlayersLabel.Size = new System.Drawing.Size(93, 13);
            this.NumberOfPlayersLabel.TabIndex = 2;
            this.NumberOfPlayersLabel.Text = "Number of Players";
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(145, 348);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.Close_Click);
            // 
            // StartGameButton
            // 
            this.StartGameButton.Location = new System.Drawing.Point(145, 250);
            this.StartGameButton.Name = "StartGameButton";
            this.StartGameButton.Size = new System.Drawing.Size(75, 23);
            this.StartGameButton.TabIndex = 2;
            this.StartGameButton.Text = "Start Game";
            this.StartGameButton.UseVisualStyleBackColor = true;
            this.StartGameButton.Click += new System.EventHandler(this.StartGame_Click);
            // 
            // GameSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 392);
            this.Controls.Add(this.StartGameButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.GameSettings);
            this.Name = "GameSetup";
            this.Text = "Dominion Game Setup";
            this.GameSettings.ResumeLayout(false);
            this.GameSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfPlayersSelected)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GameSettings;
        private System.Windows.Forms.NumericUpDown NumberOfPlayersSelected;
        private System.Windows.Forms.Label NumberOfPlayersLabel;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button StartGameButton;
    }
}

