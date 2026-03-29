namespace OracleAdminApp
{
    partial class LoginForm
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
            this.Username = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.Host = new System.Windows.Forms.Label();
            this.Port = new System.Windows.Forms.Label();
            this.ServiceName = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtServiceName = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(284, 105);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(70, 16);
            this.Username.TabIndex = 0;
            this.Username.Text = "Username";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(284, 157);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(67, 16);
            this.Password.TabIndex = 1;
            this.Password.Text = "Password";
            // 
            // Host
            // 
            this.Host.AutoSize = true;
            this.Host.Location = new System.Drawing.Point(284, 213);
            this.Host.Name = "Host";
            this.Host.Size = new System.Drawing.Size(35, 16);
            this.Host.TabIndex = 2;
            this.Host.Text = "Host";
            // 
            // Port
            // 
            this.Port.AutoSize = true;
            this.Port.Location = new System.Drawing.Point(284, 264);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(31, 16);
            this.Port.TabIndex = 3;
            this.Port.Text = "Port";
            // 
            // ServiceName
            // 
            this.ServiceName.AutoSize = true;
            this.ServiceName.Location = new System.Drawing.Point(284, 317);
            this.ServiceName.Name = "ServiceName";
            this.ServiceName.Size = new System.Drawing.Size(93, 16);
            this.ServiceName.TabIndex = 4;
            this.ServiceName.Text = "Service Name";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(389, 99);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 22);
            this.txtUsername.TabIndex = 5;
            this.txtUsername.Click += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(389, 151);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 22);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.Click += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(389, 207);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(100, 22);
            this.txtHost.TabIndex = 7;
            this.txtHost.Text = "localhost";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(389, 258);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 22);
            this.txtPort.TabIndex = 8;
            this.txtPort.Text = "1521";
            // 
            // txtServiceName
            // 
            this.txtServiceName.Location = new System.Drawing.Point(389, 311);
            this.txtServiceName.Name = "txtServiceName";
            this.txtServiceName.Size = new System.Drawing.Size(100, 22);
            this.txtServiceName.TabIndex = 9;
            this.txtServiceName.Text = "xepdb1";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(345, 372);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 33);
            this.btnLogin.TabIndex = 10;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtServiceName);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.ServiceName);
            this.Controls.Add(this.Port);
            this.Controls.Add(this.Host);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label Host;
        private System.Windows.Forms.Label Port;
        private System.Windows.Forms.Label ServiceName;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtServiceName;
        private System.Windows.Forms.Button btnLogin;
    }
}