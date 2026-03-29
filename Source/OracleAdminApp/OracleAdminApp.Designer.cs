namespace OracleAdminApp
{
    partial class OracleAdminApp
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDashboard = new System.Windows.Forms.TabPage();
            this.tabUsers = new System.Windows.Forms.TabPage();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.NewPassword = new System.Windows.Forms.Label();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.tabRoles = new System.Windows.Forms.TabPage();
            this.btnRevokeRole = new System.Windows.Forms.Button();
            this.btnUpdateRolePassword = new System.Windows.Forms.Button();
            this.btnDeleteRole = new System.Windows.Forms.Button();
            this.dgvRoles = new System.Windows.Forms.DataGridView();
            this.btnGrantRole = new System.Windows.Forms.Button();
            this.cboRoles = new System.Windows.Forms.ComboBox();
            this.cboUsers = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRolePassword = new System.Windows.Forms.TextBox();
            this.RolePassword = new System.Windows.Forms.Label();
            this.btnCreateRole = new System.Windows.Forms.Button();
            this.txtRoleName = new System.Windows.Forms.TextBox();
            this.RoleName = new System.Windows.Forms.Label();
            this.tabPrivileges = new System.Windows.Forms.TabPage();
            this.tabViewPrivileges = new System.Windows.Forms.TabPage();
            this.txtSearchRole = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.tabRoles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabDashboard);
            this.tabControl1.Controls.Add(this.tabUsers);
            this.tabControl1.Controls.Add(this.tabRoles);
            this.tabControl1.Controls.Add(this.tabPrivileges);
            this.tabControl1.Controls.Add(this.tabViewPrivileges);
            this.tabControl1.Location = new System.Drawing.Point(22, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(766, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabDashboard
            // 
            this.tabDashboard.Location = new System.Drawing.Point(4, 25);
            this.tabDashboard.Name = "tabDashboard";
            this.tabDashboard.Padding = new System.Windows.Forms.Padding(3);
            this.tabDashboard.Size = new System.Drawing.Size(758, 397);
            this.tabDashboard.TabIndex = 1;
            this.tabDashboard.Text = "Dashboard";
            this.tabDashboard.UseVisualStyleBackColor = true;
            // 
            // tabUsers
            // 
            this.tabUsers.Controls.Add(this.btnUpdate);
            this.tabUsers.Controls.Add(this.txtNewPassword);
            this.tabUsers.Controls.Add(this.NewPassword);
            this.tabUsers.Controls.Add(this.dgvUsers);
            this.tabUsers.Controls.Add(this.btnDelete);
            this.tabUsers.Controls.Add(this.btnCreate);
            this.tabUsers.Controls.Add(this.txtSearch);
            this.tabUsers.Controls.Add(this.txtPassword);
            this.tabUsers.Controls.Add(this.txtUsername);
            this.tabUsers.Controls.Add(this.Password);
            this.tabUsers.Controls.Add(this.Username);
            this.tabUsers.Location = new System.Drawing.Point(4, 25);
            this.tabUsers.Name = "tabUsers";
            this.tabUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsers.Size = new System.Drawing.Size(758, 397);
            this.tabUsers.TabIndex = 0;
            this.tabUsers.Text = "Users";
            this.tabUsers.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(29, 349);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 30);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(16, 213);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(113, 22);
            this.txtNewPassword.TabIndex = 9;
            // 
            // NewPassword
            // 
            this.NewPassword.AutoSize = true;
            this.NewPassword.Location = new System.Drawing.Point(13, 194);
            this.NewPassword.Name = "NewPassword";
            this.NewPassword.Size = new System.Drawing.Size(100, 16);
            this.NewPassword.TabIndex = 8;
            this.NewPassword.Text = "New Password:";
            // 
            // dgvUsers
            // 
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(135, 46);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.RowTemplate.Height = 24;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(617, 345);
            this.dgvUsers.TabIndex = 7;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(29, 306);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(29, 261);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSearch.Location = new System.Drawing.Point(3, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(752, 22);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(16, 130);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(113, 22);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(16, 55);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(113, 22);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(13, 111);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(70, 16);
            this.Password.TabIndex = 1;
            this.Password.Text = "Password:";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(13, 36);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(73, 16);
            this.Username.TabIndex = 0;
            this.Username.Text = "Username:";
            // 
            // tabRoles
            // 
            this.tabRoles.Controls.Add(this.txtSearchRole);
            this.tabRoles.Controls.Add(this.btnRevokeRole);
            this.tabRoles.Controls.Add(this.btnUpdateRolePassword);
            this.tabRoles.Controls.Add(this.btnDeleteRole);
            this.tabRoles.Controls.Add(this.dgvRoles);
            this.tabRoles.Controls.Add(this.btnGrantRole);
            this.tabRoles.Controls.Add(this.cboRoles);
            this.tabRoles.Controls.Add(this.cboUsers);
            this.tabRoles.Controls.Add(this.label2);
            this.tabRoles.Controls.Add(this.label1);
            this.tabRoles.Controls.Add(this.txtRolePassword);
            this.tabRoles.Controls.Add(this.RolePassword);
            this.tabRoles.Controls.Add(this.btnCreateRole);
            this.tabRoles.Controls.Add(this.txtRoleName);
            this.tabRoles.Controls.Add(this.RoleName);
            this.tabRoles.Location = new System.Drawing.Point(4, 25);
            this.tabRoles.Name = "tabRoles";
            this.tabRoles.Size = new System.Drawing.Size(758, 397);
            this.tabRoles.TabIndex = 2;
            this.tabRoles.Text = "Roles";
            this.tabRoles.UseVisualStyleBackColor = true;
            // 
            // btnRevokeRole
            // 
            this.btnRevokeRole.Location = new System.Drawing.Point(139, 361);
            this.btnRevokeRole.Name = "btnRevokeRole";
            this.btnRevokeRole.Size = new System.Drawing.Size(75, 23);
            this.btnRevokeRole.TabIndex = 13;
            this.btnRevokeRole.Text = "Revoke";
            this.btnRevokeRole.UseVisualStyleBackColor = true;
            this.btnRevokeRole.Click += new System.EventHandler(this.btnRevokeRole_Click);
            // 
            // btnUpdateRolePassword
            // 
            this.btnUpdateRolePassword.Location = new System.Drawing.Point(185, 149);
            this.btnUpdateRolePassword.Name = "btnUpdateRolePassword";
            this.btnUpdateRolePassword.Size = new System.Drawing.Size(75, 44);
            this.btnUpdateRolePassword.TabIndex = 12;
            this.btnUpdateRolePassword.Text = "Update Password";
            this.btnUpdateRolePassword.UseVisualStyleBackColor = true;
            this.btnUpdateRolePassword.Click += new System.EventHandler(this.btnUpdateRolePassword_Click);
            // 
            // btnDeleteRole
            // 
            this.btnDeleteRole.Location = new System.Drawing.Point(104, 149);
            this.btnDeleteRole.Name = "btnDeleteRole";
            this.btnDeleteRole.Size = new System.Drawing.Size(75, 44);
            this.btnDeleteRole.TabIndex = 11;
            this.btnDeleteRole.Text = "Delete";
            this.btnDeleteRole.UseVisualStyleBackColor = true;
            this.btnDeleteRole.Click += new System.EventHandler(this.btnDeleteRole_Click);
            // 
            // dgvRoles
            // 
            this.dgvRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoles.Location = new System.Drawing.Point(271, 45);
            this.dgvRoles.Name = "dgvRoles";
            this.dgvRoles.RowHeadersWidth = 51;
            this.dgvRoles.RowTemplate.Height = 24;
            this.dgvRoles.Size = new System.Drawing.Size(484, 349);
            this.dgvRoles.TabIndex = 10;
            // 
            // btnGrantRole
            // 
            this.btnGrantRole.Location = new System.Drawing.Point(58, 361);
            this.btnGrantRole.Name = "btnGrantRole";
            this.btnGrantRole.Size = new System.Drawing.Size(75, 23);
            this.btnGrantRole.TabIndex = 9;
            this.btnGrantRole.Text = "Grant";
            this.btnGrantRole.UseVisualStyleBackColor = true;
            this.btnGrantRole.Click += new System.EventHandler(this.btnGrantRole_Click);
            // 
            // cboRoles
            // 
            this.cboRoles.FormattingEnabled = true;
            this.cboRoles.Location = new System.Drawing.Point(131, 298);
            this.cboRoles.Name = "cboRoles";
            this.cboRoles.Size = new System.Drawing.Size(121, 24);
            this.cboRoles.TabIndex = 8;
            this.cboRoles.TextChanged += new System.EventHandler(this.cboRoles_TextChanged);
            // 
            // cboUsers
            // 
            this.cboUsers.FormattingEnabled = true;
            this.cboUsers.Location = new System.Drawing.Point(131, 247);
            this.cboUsers.Name = "cboUsers";
            this.cboUsers.Size = new System.Drawing.Size(121, 24);
            this.cboUsers.TabIndex = 7;
            this.cboUsers.TextChanged += new System.EventHandler(this.cboUsers_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Assigned Role";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Username";
            // 
            // txtRolePassword
            // 
            this.txtRolePassword.Location = new System.Drawing.Point(98, 103);
            this.txtRolePassword.Name = "txtRolePassword";
            this.txtRolePassword.Size = new System.Drawing.Size(100, 22);
            this.txtRolePassword.TabIndex = 4;
            // 
            // RolePassword
            // 
            this.RolePassword.AutoSize = true;
            this.RolePassword.Location = new System.Drawing.Point(20, 103);
            this.RolePassword.Name = "RolePassword";
            this.RolePassword.Size = new System.Drawing.Size(67, 16);
            this.RolePassword.TabIndex = 3;
            this.RolePassword.Text = "Password";
            // 
            // btnCreateRole
            // 
            this.btnCreateRole.Location = new System.Drawing.Point(23, 149);
            this.btnCreateRole.Name = "btnCreateRole";
            this.btnCreateRole.Size = new System.Drawing.Size(75, 44);
            this.btnCreateRole.TabIndex = 2;
            this.btnCreateRole.Text = "Create";
            this.btnCreateRole.UseVisualStyleBackColor = true;
            this.btnCreateRole.Click += new System.EventHandler(this.btnCreateRole_Click);
            // 
            // txtRoleName
            // 
            this.txtRoleName.Location = new System.Drawing.Point(98, 58);
            this.txtRoleName.Name = "txtRoleName";
            this.txtRoleName.Size = new System.Drawing.Size(100, 22);
            this.txtRoleName.TabIndex = 1;
            // 
            // RoleName
            // 
            this.RoleName.AutoSize = true;
            this.RoleName.Location = new System.Drawing.Point(20, 58);
            this.RoleName.Name = "RoleName";
            this.RoleName.Size = new System.Drawing.Size(44, 16);
            this.RoleName.TabIndex = 0;
            this.RoleName.Text = "Name";
            // 
            // tabPrivileges
            // 
            this.tabPrivileges.Location = new System.Drawing.Point(4, 25);
            this.tabPrivileges.Name = "tabPrivileges";
            this.tabPrivileges.Size = new System.Drawing.Size(758, 397);
            this.tabPrivileges.TabIndex = 3;
            this.tabPrivileges.Text = "Privileges";
            this.tabPrivileges.UseVisualStyleBackColor = true;
            // 
            // tabViewPrivileges
            // 
            this.tabViewPrivileges.Location = new System.Drawing.Point(4, 25);
            this.tabViewPrivileges.Name = "tabViewPrivileges";
            this.tabViewPrivileges.Size = new System.Drawing.Size(758, 397);
            this.tabViewPrivileges.TabIndex = 4;
            this.tabViewPrivileges.Text = "ViewPrivileges";
            this.tabViewPrivileges.UseVisualStyleBackColor = true;
            // 
            // txtSearchRole
            // 
            this.txtSearchRole.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSearchRole.Location = new System.Drawing.Point(0, 0);
            this.txtSearchRole.Name = "txtSearchRole";
            this.txtSearchRole.Size = new System.Drawing.Size(758, 22);
            this.txtSearchRole.TabIndex = 14;
            this.txtSearchRole.TextChanged += new System.EventHandler(this.txtSearchRole_TextChanged);
            this.txtSearchRole.Enter += new System.EventHandler(this.txtSearchRole_Enter);
            this.txtSearchRole.Leave += new System.EventHandler(this.txtSearchRole_Leave);
            // 
            // OracleAdminApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "OracleAdminApp";
            this.Text = "OracleAdminApp";
            this.tabControl1.ResumeLayout(false);
            this.tabUsers.ResumeLayout(false);
            this.tabUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.tabRoles.ResumeLayout(false);
            this.tabRoles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabUsers;
        private System.Windows.Forms.TabPage tabDashboard;
        private System.Windows.Forms.TabPage tabRoles;
        private System.Windows.Forms.TabPage tabPrivileges;
        private System.Windows.Forms.TabPage tabViewPrivileges;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label NewPassword;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label RoleName;
        private System.Windows.Forms.TextBox txtRolePassword;
        private System.Windows.Forms.Label RolePassword;
        private System.Windows.Forms.Button btnCreateRole;
        private System.Windows.Forms.TextBox txtRoleName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvRoles;
        private System.Windows.Forms.Button btnGrantRole;
        private System.Windows.Forms.ComboBox cboRoles;
        private System.Windows.Forms.ComboBox cboUsers;
        private System.Windows.Forms.Button btnRevokeRole;
        private System.Windows.Forms.Button btnUpdateRolePassword;
        private System.Windows.Forms.Button btnDeleteRole;
        private System.Windows.Forms.TextBox txtSearchRole;
    }
}

