namespace MyBlindMusic
{
    partial class choix
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
            this.NewGame = new System.Windows.Forms.Button();
            this.BestScore = new System.Windows.Forms.Button();
            this.GameRules = new System.Windows.Forms.Button();
            this.LogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(307, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Que voulez -vous ?";
            // 
            // NewGame
            // 
            this.NewGame.Location = new System.Drawing.Point(120, 170);
            this.NewGame.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NewGame.Name = "NewGame";
            this.NewGame.Size = new System.Drawing.Size(133, 50);
            this.NewGame.TabIndex = 3;
            this.NewGame.Text = "New Game";
            this.NewGame.UseVisualStyleBackColor = true;
            this.NewGame.Click += new System.EventHandler(this.NewGame_Click);
            // 
            // BestScore
            // 
            this.BestScore.Location = new System.Drawing.Point(331, 170);
            this.BestScore.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BestScore.Name = "BestScore";
            this.BestScore.Size = new System.Drawing.Size(133, 50);
            this.BestScore.TabIndex = 4;
            this.BestScore.Text = "Best Score";
            this.BestScore.UseVisualStyleBackColor = true;
            this.BestScore.Click += new System.EventHandler(this.button4_Click);
            // 
            // GameRules
            // 
            this.GameRules.Location = new System.Drawing.Point(543, 170);
            this.GameRules.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GameRules.Name = "GameRules";
            this.GameRules.Size = new System.Drawing.Size(133, 50);
            this.GameRules.TabIndex = 5;
            this.GameRules.Text = "Game Rules";
            this.GameRules.UseVisualStyleBackColor = true;
            this.GameRules.Click += new System.EventHandler(this.GameRules_Click);
            // 
            // LogOut
            // 
            this.LogOut.Location = new System.Drawing.Point(663, 324);
            this.LogOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(133, 28);
            this.LogOut.TabIndex = 6;
            this.LogOut.Text = "Log Out";
            this.LogOut.UseVisualStyleBackColor = true;
            // 
            // choix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 367);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.GameRules);
            this.Controls.Add(this.BestScore);
            this.Controls.Add(this.NewGame);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "choix";
            this.Text = "choix";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button NewGame;
        private System.Windows.Forms.Button BestScore;
        private System.Windows.Forms.Button GameRules;
        private System.Windows.Forms.Button LogOut;
    }
}