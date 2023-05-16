namespace inventory_management
{
    partial class Welcome
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
            this.welcomeGB = new System.Windows.Forms.GroupBox();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Button();
            this.signup = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.welcomeGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // welcomeGB
            // 
            this.welcomeGB.Controls.Add(this.label2);
            this.welcomeGB.Controls.Add(this.signup);
            this.welcomeGB.Controls.Add(this.login);
            this.welcomeGB.Controls.Add(this.label1);
            this.welcomeGB.Controls.Add(this.welcomeLabel);
            this.welcomeGB.Location = new System.Drawing.Point(12, 12);
            this.welcomeGB.Name = "welcomeGB";
            this.welcomeGB.Size = new System.Drawing.Size(366, 401);
            this.welcomeGB.TabIndex = 0;
            this.welcomeGB.TabStop = false;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(6, 36);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(367, 33);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome to inventory manager!";
            this.welcomeLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Already have an account?";
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.Location = new System.Drawing.Point(133, 261);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(86, 38);
            this.login.TabIndex = 2;
            this.login.Text = "log in";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // signup
            // 
            this.signup.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup.Location = new System.Drawing.Point(133, 157);
            this.signup.Name = "signup";
            this.signup.Size = new System.Drawing.Size(86, 38);
            this.signup.TabIndex = 3;
            this.signup.Text = "sign up";
            this.signup.UseVisualStyleBackColor = true;
            this.signup.Click += new System.EventHandler(this.signup_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(113, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Unregistered?";
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 425);
            this.Controls.Add(this.welcomeGB);
            this.Name = "Welcome";
            this.Text = "Welcome";
            this.welcomeGB.ResumeLayout(false);
            this.welcomeGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox welcomeGB;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button signup;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Label label1;
    }
}