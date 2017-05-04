namespace MyBlindMusic
{
    partial class Score
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbBestScore = new System.Windows.Forms.TextBox();
            this.tbScore = new System.Windows.Forms.TextBox();
            this.txtInfo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Meilleur Score :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Votre Score : ";
            // 
            // tbBestScore
            // 
            this.tbBestScore.Location = new System.Drawing.Point(298, 107);
            this.tbBestScore.Name = "tbBestScore";
            this.tbBestScore.Size = new System.Drawing.Size(100, 27);
            this.tbBestScore.TabIndex = 3;
            this.tbBestScore.TextChanged += new System.EventHandler(this.tbBestScore_TextChanged);
            // 
            // tbScore
            // 
            this.tbScore.Location = new System.Drawing.Point(298, 157);
            this.tbScore.Name = "tbScore";
            this.tbScore.Size = new System.Drawing.Size(100, 27);
            this.tbScore.TabIndex = 4;
            this.tbScore.TextChanged += new System.EventHandler(this.tbScore_TextChanged);
            // 
            // txtInfo
            // 
            this.txtInfo.AutoSize = true;
            this.txtInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.55F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtInfo.Location = new System.Drawing.Point(251, 49);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(141, 25);
            this.txtInfo.TabIndex = 5;
            this.txtInfo.Text = "Informations";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(298, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 38);
            this.button1.TabIndex = 6;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Score
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 303);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.tbScore);
            this.Controls.Add(this.tbBestScore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Score";
            this.Text = "Score";
            this.Load += new System.EventHandler(this.Score_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbBestScore;
        private System.Windows.Forms.TextBox tbScore;
        private System.Windows.Forms.Label txtInfo;
        private System.Windows.Forms.Button button1;
    }
}