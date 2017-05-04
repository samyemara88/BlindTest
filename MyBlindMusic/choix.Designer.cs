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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(choix));
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
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(738, 206);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Que voulez -vous ?";
            // 
            // NewGame
            // 
            this.NewGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(75)))), ((int)(((byte)(83)))));
            this.NewGame.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.NewGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NewGame.Location = new System.Drawing.Point(562, 347);
            this.NewGame.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NewGame.Name = "NewGame";
            this.NewGame.Size = new System.Drawing.Size(133, 50);
            this.NewGame.TabIndex = 3;
            this.NewGame.Text = "New Game";
            this.NewGame.UseVisualStyleBackColor = false;
            this.NewGame.Click += new System.EventHandler(this.NewGame_Click);
            // 
            // BestScore
            // 
            this.BestScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(75)))), ((int)(((byte)(83)))));
            this.BestScore.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BestScore.Location = new System.Drawing.Point(773, 347);
            this.BestScore.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BestScore.Name = "BestScore";
            this.BestScore.Size = new System.Drawing.Size(133, 50);
            this.BestScore.TabIndex = 4;
            this.BestScore.Text = "Best Score";
            this.BestScore.UseVisualStyleBackColor = false;
            this.BestScore.Click += new System.EventHandler(this.button4_Click);
            // 
            // GameRules
            // 
            this.GameRules.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(75)))), ((int)(((byte)(83)))));
            this.GameRules.FlatAppearance.BorderSize = 0;
            this.GameRules.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GameRules.Location = new System.Drawing.Point(985, 347);
            this.GameRules.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GameRules.Name = "GameRules";
            this.GameRules.Size = new System.Drawing.Size(133, 50);
            this.GameRules.TabIndex = 5;
            this.GameRules.Text = "Game Rules";
            this.GameRules.UseVisualStyleBackColor = false;
            this.GameRules.Click += new System.EventHandler(this.GameRules_Click);
            // 
            // LogOut
            // 
            this.LogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(75)))), ((int)(((byte)(83)))));
            this.LogOut.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.LogOut.FlatAppearance.BorderSize = 4;
            this.LogOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LogOut.Location = new System.Drawing.Point(781, 495);
            this.LogOut.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(125, 66);
            this.LogOut.TabIndex = 6;
            this.LogOut.Text = "Log Out";
            this.LogOut.UseVisualStyleBackColor = false;
            // 
            // choix
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MyBlindMusic.Properties.Resources.parallax_1;
            this.ClientSize = new System.Drawing.Size(1480, 711);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.GameRules);
            this.Controls.Add(this.BestScore);
            this.Controls.Add(this.NewGame);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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