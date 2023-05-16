namespace inventory_management
{
    partial class LogIn
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
            this.logInGB = new System.Windows.Forms.GroupBox();
            this.warning = new System.Windows.Forms.Label();
            this.procede = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.logInGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // logInGB
            // 
            this.logInGB.Controls.Add(this.warning);
            this.logInGB.Controls.Add(this.procede);
            this.logInGB.Controls.Add(this.back);
            this.logInGB.Controls.Add(this.password);
            this.logInGB.Controls.Add(this.username);
            this.logInGB.Controls.Add(this.label2);
            this.logInGB.Controls.Add(this.label1);
            this.logInGB.Controls.Add(this.loginLabel);
            this.logInGB.Location = new System.Drawing.Point(13, 13);
            this.logInGB.Name = "logInGB";
            this.logInGB.Size = new System.Drawing.Size(356, 302);
            this.logInGB.TabIndex = 0;
            this.logInGB.TabStop = false;
            // 
            // warning
            // 
            this.warning.AutoSize = true;
            this.warning.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warning.Location = new System.Drawing.Point(77, 199);
            this.warning.Name = "warning";
            this.warning.Size = new System.Drawing.Size(220, 23);
            this.warning.TabIndex = 7;
            this.warning.Text = "Requirements not satisfied!";
            this.warning.Visible = false;
            // 
            // procede
            // 
            this.procede.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.procede.Location = new System.Drawing.Point(268, 264);
            this.procede.Name = "procede";
            this.procede.Size = new System.Drawing.Size(82, 32);
            this.procede.TabIndex = 6;
            this.procede.Text = "continue";
            this.procede.UseVisualStyleBackColor = true;
            this.procede.Click += new System.EventHandler(this.procede_Click);
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(7, 264);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(82, 32);
            this.back.TabIndex = 5;
            this.back.Text = "back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // password
            // 
            this.password.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.password.Location = new System.Drawing.Point(147, 149);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(100, 20);
            this.password.TabIndex = 4;
            this.password.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(147, 100);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(100, 20);
            this.username.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.Location = new System.Drawing.Point(160, 20);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(55, 23);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "Log in";
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 327);
            this.Controls.Add(this.logInGB);
            this.Name = "LogIn";
            this.Text = "LogIn";
            this.Load += new System.EventHandler(this.LogIn_Load);
            this.logInGB.ResumeLayout(false);
            this.logInGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox logInGB;
        private System.Windows.Forms.Button procede;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label warning;
    }
}