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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIdentification));
            this.Authentification = new System.Windows.Forms.GroupBox();
            this.Password = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.Button();
            this.Authentification.SuspendLayout();
            this.SuspendLayout();
            // 
            // Authentification
            // 
            this.Authentification.BackColor = System.Drawing.Color.Transparent;
            this.Authentification.Controls.Add(this.Password);
            this.Authentification.Controls.Add(this.userName);
            this.Authentification.Controls.Add(this.textBox2);
            this.Authentification.Controls.Add(this.textBox1);
            this.Authentification.Controls.Add(this.Login);
            this.Authentification.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Authentification.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Authentification.Location = new System.Drawing.Point(595, 303);
            this.Authentification.Margin = new System.Windows.Forms.Padding(4);
            this.Authentification.Name = "Authentification";
            this.Authentification.Padding = new System.Windows.Forms.Padding(4);
            this.Authentification.Size = new System.Drawing.Size(661, 263);
            this.Authentification.TabIndex = 0;
            this.Authentification.TabStop = false;
            this.Authentification.Text = "Authentification";
            this.Authentification.UseCompatibleTextRendering = true;
            this.Authentification.Enter += new System.EventHandler(this.Authentification_Enter);
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Password.Location = new System.Drawing.Point(145, 119);
            this.Password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(89, 22);
            this.Password.TabIndex = 5;
            this.Password.Text = "Password";
            this.Password.Click += new System.EventHandler(this.label2_Click);
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userName.Location = new System.Drawing.Point(136, 70);
            this.userName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(100, 22);
            this.userName.TabIndex = 4;
            this.userName.Text = "User Name";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(320, 119);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(236, 27);
            this.textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(320, 66);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(236, 27);
            this.textBox1.TabIndex = 2;
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(75)))), ((int)(((byte)(83)))));
            this.Login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Login.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Login.Location = new System.Drawing.Point(445, 187);
            this.Login.Margin = new System.Windows.Forms.Padding(4);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(111, 54);
            this.Login.TabIndex = 1;
            this.Login.Text = "Log In";
            this.Login.UseVisualStyleBackColor = false;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // frmIdentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MyBlindMusic.Properties.Resources.parallax_1;
            this.ClientSize = new System.Drawing.Size(1914, 1045);
            this.Controls.Add(this.Authentification);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmIdentification";
            this.Text = "Authentification";
            this.Load += new System.EventHandler(this.frmIdentification_Load);
            this.Authentification.ResumeLayout(false);
            this.Authentification.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Authentification;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label userName;
    }
}