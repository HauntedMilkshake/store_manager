namespace inventory_management
{
    partial class SignUp
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
            this.signUpUIGB = new System.Windows.Forms.GroupBox();
            this.privileges = new System.Windows.Forms.GroupBox();
            this.infoForAdmin = new System.Windows.Forms.Label();
            this.infoForUser = new System.Windows.Forms.Label();
            this.adminMode = new System.Windows.Forms.RadioButton();
            this.userMode = new System.Windows.Forms.RadioButton();
            this.warning = new System.Windows.Forms.Label();
            this.nameGB = new System.Windows.Forms.GroupBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.TextBox();
            this.accountInfoLabel = new System.Windows.Forms.Label();
            this.procede = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.fieldGB = new System.Windows.Forms.GroupBox();
            this.password = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.signUpUIGB.SuspendLayout();
            this.privileges.SuspendLayout();
            this.nameGB.SuspendLayout();
            this.fieldGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // signUpUIGB
            // 
            this.signUpUIGB.Controls.Add(this.privileges);
            this.signUpUIGB.Controls.Add(this.warning);
            this.signUpUIGB.Controls.Add(this.nameGB);
            this.signUpUIGB.Controls.Add(this.accountInfoLabel);
            this.signUpUIGB.Controls.Add(this.procede);
            this.signUpUIGB.Controls.Add(this.back);
            this.signUpUIGB.Controls.Add(this.fieldGB);
            this.signUpUIGB.Location = new System.Drawing.Point(9, 12);
            this.signUpUIGB.Name = "signUpUIGB";
            this.signUpUIGB.Size = new System.Drawing.Size(357, 634);
            this.signUpUIGB.TabIndex = 0;
            this.signUpUIGB.TabStop = false;
            // 
            // privileges
            // 
            this.privileges.Controls.Add(this.infoForAdmin);
            this.privileges.Controls.Add(this.infoForUser);
            this.privileges.Controls.Add(this.adminMode);
            this.privileges.Controls.Add(this.userMode);
            this.privileges.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.privileges.Location = new System.Drawing.Point(6, 403);
            this.privileges.Margin = new System.Windows.Forms.Padding(2);
            this.privileges.Name = "privileges";
            this.privileges.Padding = new System.Windows.Forms.Padding(2);
            this.privileges.Size = new System.Drawing.Size(200, 83);
            this.privileges.TabIndex = 10;
            this.privileges.TabStop = false;
            this.privileges.Text = "Select access:";
            // 
            // infoForAdmin
            // 
            this.infoForAdmin.AutoSize = true;
            this.infoForAdmin.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoForAdmin.Location = new System.Drawing.Point(89, 55);
            this.infoForAdmin.Name = "infoForAdmin";
            this.infoForAdmin.Size = new System.Drawing.Size(87, 15);
            this.infoForAdmin.TabIndex = 9;
            this.infoForAdmin.Text = "read and write";
            // 
            // infoForUser
            // 
            this.infoForUser.AutoSize = true;
            this.infoForUser.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoForUser.Location = new System.Drawing.Point(78, 30);
            this.infoForUser.Name = "infoForUser";
            this.infoForUser.Size = new System.Drawing.Size(60, 15);
            this.infoForUser.TabIndex = 8;
            this.infoForUser.Text = "read-only";
            // 
            // adminMode
            // 
            this.adminMode.AutoSize = true;
            this.adminMode.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminMode.Location = new System.Drawing.Point(24, 51);
            this.adminMode.Margin = new System.Windows.Forms.Padding(2);
            this.adminMode.Name = "adminMode";
            this.adminMode.Size = new System.Drawing.Size(60, 19);
            this.adminMode.TabIndex = 7;
            this.adminMode.TabStop = true;
            this.adminMode.Text = "admin";
            this.adminMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.adminMode.UseVisualStyleBackColor = true;
            // 
            // userMode
            // 
            this.userMode.AutoSize = true;
            this.userMode.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userMode.Location = new System.Drawing.Point(24, 28);
            this.userMode.Margin = new System.Windows.Forms.Padding(2);
            this.userMode.Name = "userMode";
            this.userMode.Size = new System.Drawing.Size(49, 19);
            this.userMode.TabIndex = 6;
            this.userMode.TabStop = true;
            this.userMode.Text = "user";
            this.userMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.userMode.UseVisualStyleBackColor = true;
            // 
            // warning
            // 
            this.warning.AutoSize = true;
            this.warning.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warning.Location = new System.Drawing.Point(69, 553);
            this.warning.Name = "warning";
            this.warning.Size = new System.Drawing.Size(235, 26);
            this.warning.TabIndex = 6;
            this.warning.Text = "All fields must have input!";
            this.warning.UseWaitCursor = true;
            this.warning.Visible = false;
            this.warning.Click += new System.EventHandler(this.nameWarning_Click);
            // 
            // nameGB
            // 
            this.nameGB.Controls.Add(this.lastName);
            this.nameGB.Controls.Add(this.lastNameLabel);
            this.nameGB.Controls.Add(this.firstNameLabel);
            this.nameGB.Controls.Add(this.firstName);
            this.nameGB.Location = new System.Drawing.Point(6, 233);
            this.nameGB.Margin = new System.Windows.Forms.Padding(2);
            this.nameGB.Name = "nameGB";
            this.nameGB.Padding = new System.Windows.Forms.Padding(2);
            this.nameGB.Size = new System.Drawing.Size(345, 156);
            this.nameGB.TabIndex = 9;
            this.nameGB.TabStop = false;
            this.nameGB.Enter += new System.EventHandler(this.nameGB_Enter);
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(111, 71);
            this.lastName.Margin = new System.Windows.Forms.Padding(2);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(176, 20);
            this.lastName.TabIndex = 5;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.Location = new System.Drawing.Point(27, 70);
            this.lastNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lastNameLabel.Size = new System.Drawing.Size(80, 19);
            this.lastNameLabel.TabIndex = 3;
            this.lastNameLabel.Text = ":Last name";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.firstNameLabel.Location = new System.Drawing.Point(25, 32);
            this.firstNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(81, 19);
            this.firstNameLabel.TabIndex = 2;
            this.firstNameLabel.Text = "First name:";
            this.firstNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(111, 32);
            this.firstName.Margin = new System.Windows.Forms.Padding(2);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(176, 20);
            this.firstName.TabIndex = 4;
            // 
            // accountInfoLabel
            // 
            this.accountInfoLabel.AutoSize = true;
            this.accountInfoLabel.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountInfoLabel.Location = new System.Drawing.Point(30, 16);
            this.accountInfoLabel.Name = "accountInfoLabel";
            this.accountInfoLabel.Size = new System.Drawing.Size(256, 36);
            this.accountInfoLabel.TabIndex = 3;
            this.accountInfoLabel.Text = "Account information";
            // 
            // procede
            // 
            this.procede.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.procede.Location = new System.Drawing.Point(243, 596);
            this.procede.Name = "procede";
            this.procede.Size = new System.Drawing.Size(108, 32);
            this.procede.TabIndex = 2;
            this.procede.Text = "continue";
            this.procede.UseVisualStyleBackColor = true;
            this.procede.Click += new System.EventHandler(this.procede_Click);
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(6, 595);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(108, 33);
            this.back.TabIndex = 1;
            this.back.Text = "back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // fieldGB
            // 
            this.fieldGB.Controls.Add(this.password);
            this.fieldGB.Controls.Add(this.username);
            this.fieldGB.Controls.Add(this.passwordLabel);
            this.fieldGB.Controls.Add(this.usernameLabel);
            this.fieldGB.Location = new System.Drawing.Point(6, 68);
            this.fieldGB.Name = "fieldGB";
            this.fieldGB.Size = new System.Drawing.Size(345, 160);
            this.fieldGB.TabIndex = 0;
            this.fieldGB.TabStop = false;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(111, 83);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(176, 20);
            this.password.TabIndex = 3;
            this.password.UseSystemPasswordChar = true;
            this.password.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(111, 45);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(176, 20);
            this.username.TabIndex = 2;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(30, 82);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(75, 19);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Password:";
            this.passwordLabel.Click += new System.EventHandler(this.passwordLabel_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(26, 45);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(79, 19);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Username:";
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 658);
            this.Controls.Add(this.signUpUIGB);
            this.Name = "SignUp";
            this.Text = "SignUpUI";
            this.Load += new System.EventHandler(this.SignUpUI_Load);
            this.signUpUIGB.ResumeLayout(false);
            this.signUpUIGB.PerformLayout();
            this.privileges.ResumeLayout(false);
            this.privileges.PerformLayout();
            this.nameGB.ResumeLayout(false);
            this.nameGB.PerformLayout();
            this.fieldGB.ResumeLayout(false);
            this.fieldGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox signUpUIGB;
        private System.Windows.Forms.Button procede;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.GroupBox fieldGB;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label accountInfoLabel;
        private System.Windows.Forms.Label warning;
        private System.Windows.Forms.GroupBox nameGB;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.GroupBox privileges;
        private System.Windows.Forms.Label infoForAdmin;
        private System.Windows.Forms.Label infoForUser;
        private System.Windows.Forms.RadioButton adminMode;
        private System.Windows.Forms.RadioButton userMode;
    }
}