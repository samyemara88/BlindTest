﻿namespace MyBlindMusic
{
    partial class frmPlay
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.Play = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.flowLayout4Btn = new System.Windows.Forms.FlowLayoutPanel();
            this.txt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Play
            // 
            this.Play.Location = new System.Drawing.Point(13, -5);
            this.Play.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(88, 26);
            this.Play.TabIndex = 0;
            this.Play.Text = "Play";
            this.Play.UseCompatibleTextRendering = true;
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Click += new System.EventHandler(this.button1_Click);
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(13, 20);
            this.Stop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(88, 26);
            this.Stop.TabIndex = 1;
            this.Stop.Text = "Stop";
            this.Stop.UseCompatibleTextRendering = true;
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.progressBar1.Location = new System.Drawing.Point(108, 141);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(325, 19);
            this.progressBar1.Step = 5;
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Value = 50;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // flowLayout4Btn
            // 
            this.flowLayout4Btn.Location = new System.Drawing.Point(108, 183);
            this.flowLayout4Btn.Name = "flowLayout4Btn";
            this.flowLayout4Btn.Size = new System.Drawing.Size(394, 156);
            this.flowLayout4Btn.TabIndex = 4;
            this.flowLayout4Btn.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt.Location = new System.Drawing.Point(105, 102);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(228, 22);
            this.txt.TabIndex = 6;
            this.txt.Text = "Qui chante cette musique ?";
            // 
            // frmPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 441);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.flowLayout4Btn);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Play);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPlay";
            this.Text = "New Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.FlowLayoutPanel flowLayout4Btn;
        private System.Windows.Forms.Label txt;
    }
}
