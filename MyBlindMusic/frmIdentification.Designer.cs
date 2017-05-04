namespace MyBlindMusic
{
    partial class frmIdentification
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
            this.Authentification = new System.Windows.Forms.GroupBox();
            this.Login = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.userName = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.txt = new System.Windows.Forms.Label();
            this.Authentification.SuspendLayout();
            this.SuspendLayout();
            // 
            // Authentification
            // 
            this.Authentification.Controls.Add(this.Password);
            this.Authentification.Controls.Add(this.userName);
            this.Authentification.Controls.Add(this.textBox2);
            this.Authentification.Controls.Add(this.textBox1);
            this.Authentification.Controls.Add(this.Login);
            this.Authentification.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Authentification.Location = new System.Drawing.Point(110, 107);
            this.Authentification.Name = "Authentification";
            this.Authentification.Size = new System.Drawing.Size(496, 214);
            this.Authentification.TabIndex = 0;
            this.Authentification.TabStop = false;
            this.Authentification.Text = "Authentification";
            this.Authentification.UseCompatibleTextRendering = true;
            this.Authentification.Enter += new System.EventHandler(this.Authentification_Enter);
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(343, 163);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(75, 32);
            this.Login.TabIndex = 1;
            this.Login.Text = "Log In";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(240, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(178, 23);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(240, 97);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(178, 23);
            this.textBox2.TabIndex = 3;
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Location = new System.Drawing.Point(102, 57);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(79, 17);
            this.userName.TabIndex = 4;
            this.userName.Text = "User Name";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(109, 97);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(69, 17);
            this.Password.TabIndex = 5;
            this.Password.Text = "Password";
            this.Password.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.55F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txt.Location = new System.Drawing.Point(107, 44);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(345, 20);
            this.txt.TabIndex = 1;
            this.txt.Text = "Veuillez s\'authentifier pour commencer le jeu";
            // 
            // frmIdentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 377);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.Authentification);
            this.Name = "frmIdentification";
            this.Text = "Authentification";
            this.Load += new System.EventHandler(this.frmIdentification_Load);
            this.Authentification.ResumeLayout(false);
            this.Authentification.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Authentification;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Label txt;
    }
}