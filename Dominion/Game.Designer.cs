namespace Dominion
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.DeckImage = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SetupOptions = new System.Windows.Forms.GroupBox();
            this.EndGame = new System.Windows.Forms.Button();
            this.SeeHand = new System.Windows.Forms.Button();
            this.SeeDeck = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DeckImage)).BeginInit();
            this.SetupOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // DeckImage
            // 
            this.DeckImage.Image = ((System.Drawing.Image)(resources.GetObject("DeckImage.Image")));
            this.DeckImage.Location = new System.Drawing.Point(24, 351);
            this.DeckImage.Name = "DeckImage";
            this.DeckImage.Size = new System.Drawing.Size(178, 278);
            this.DeckImage.TabIndex = 0;
            this.DeckImage.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(352, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Start Buy Phase";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BuyPhase_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(609, 301);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "End Turn";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.EndTurn_Click);
            // 
            // SetupOptions
            // 
            this.SetupOptions.Controls.Add(this.EndGame);
            this.SetupOptions.Location = new System.Drawing.Point(1035, 12);
            this.SetupOptions.Name = "SetupOptions";
            this.SetupOptions.Size = new System.Drawing.Size(200, 119);
            this.SetupOptions.TabIndex = 3;
            this.SetupOptions.TabStop = false;
            this.SetupOptions.Text = "Setup Options";
            // 
            // EndGame
            // 
            this.EndGame.Location = new System.Drawing.Point(6, 19);
            this.EndGame.Name = "EndGame";
            this.EndGame.Size = new System.Drawing.Size(75, 23);
            this.EndGame.TabIndex = 0;
            this.EndGame.Text = "End Game";
            this.EndGame.UseVisualStyleBackColor = true;
            this.EndGame.Click += new System.EventHandler(this.EndGame_Click);
            // 
            // SeeHand
            // 
            this.SeeHand.Location = new System.Drawing.Point(249, 351);
            this.SeeHand.Name = "SeeHand";
            this.SeeHand.Size = new System.Drawing.Size(75, 23);
            this.SeeHand.TabIndex = 4;
            this.SeeHand.Text = "See Hand";
            this.SeeHand.UseVisualStyleBackColor = true;
            this.SeeHand.Click += new System.EventHandler(this.SeeHand_Click);
            // 
            // SeeDeck
            // 
            this.SeeDeck.Location = new System.Drawing.Point(37, 301);
            this.SeeDeck.Name = "SeeDeck";
            this.SeeDeck.Size = new System.Drawing.Size(75, 23);
            this.SeeDeck.TabIndex = 5;
            this.SeeDeck.Text = "See Deck";
            this.SeeDeck.UseVisualStyleBackColor = true;
            this.SeeDeck.Click += new System.EventHandler(this.SeeDeck_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(1247, 641);
            this.Controls.Add(this.SeeDeck);
            this.Controls.Add(this.SeeHand);
            this.Controls.Add(this.SetupOptions);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DeckImage);
            this.Name = "Game";
            this.Text = "Game";
            ((System.ComponentModel.ISupportInitialize)(this.DeckImage)).EndInit();
            this.SetupOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox DeckImage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox SetupOptions;
        private System.Windows.Forms.Button EndGame;
        private System.Windows.Forms.Button SeeHand;
        private System.Windows.Forms.Button SeeDeck;
    }
}