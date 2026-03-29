using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using OracleAdminApp.Data;
using OracleAdminApp.Services;

namespace OracleAdminApp
{
    public partial class OracleAdminApp : Form
    {
        private UserService userService;
        private RoleService roleService;
        
        private DataTable allRoles;
        private DataTable allUsers;

        private bool isFilteringRoles = false;
        private bool isFilteringUsers = false;
        private string _connectionString;

        public OracleAdminApp(string connectionString)
        {
            InitializeComponent();
            _connectionString = connectionString;
            this.Load += OracleAdminApp_Load;
        }

        private void OracleAdminApp_Load(object sender, EventArgs e)
        {
            userService = new UserService(_connectionString);
            roleService = new RoleService(_connectionString);

            InitUI();

            LoadUsers();
            LoadRoles(); // ✅ THÊM DÒNG NÀY

            LoadUsersToCombo();
            LoadRolesToCombo();
        }

        // =========================
        // INIT UI
        // =========================
        private void InitUI()
        {
            txtPassword.UseSystemPasswordChar = true;
            txtNewPassword.UseSystemPasswordChar = true;

            txtSearchRole.Text = "Search role...";
            txtSearchRole.ForeColor = Color.Gray;

            txtSearch.Text = "Search user...";
            txtSearch.ForeColor = Color.Gray;

            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            btnCreate.Enabled = false;

            cboRoles.DropDownStyle = ComboBoxStyle.DropDown;
            cboUsers.DropDownStyle = ComboBoxStyle.DropDown;
        }

        // =========================
        // LOAD USERS & ROLES
        // =========================
        private void LoadUsers()
        {
            dgvUsers.DataSource = userService.GetUsers();
        }

        private void LoadRoles()
        {
            dgvRoles.DataSource = roleService.GetRoles();
        }

        private void LoadUsersToCombo()
        {
            allUsers = userService.GetUsers();

            cboUsers.DataSource = allUsers;
            cboUsers.DisplayMember = "USERNAME";
        }

        private void LoadRolesToCombo()
        {
            allRoles = roleService.GetRoles();

            cboRoles.DataSource = allRoles;
            cboRoles.DisplayMember = "ROLE";
        }

        // =========================
        // CREATE USER
        // =========================
        private void btnCreate_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter username and password");
                return;
            }

            try
            {
                using (var conn = new DbHelper(_connectionString).GetConnection())
                {
                    conn.Open();

                    var cmd = new OracleCommand("SP_CREATE_USER", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("P_USERNAME", username);
                    cmd.Parameters.Add("P_PASSWORD", password);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("User created!");

                txtUsername.Clear();
                txtPassword.Clear();

                LoadUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // =========================
        // DELETE USER
        // =========================
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow == null) return;

            string username = dgvUsers.CurrentRow.Cells[0].Value.ToString();

            if (username == "ATBM_ADMIN")
            {
                MessageBox.Show("Cannot delete current user!");
                return;
            }

            var confirm = MessageBox.Show(
                $"Delete user {username}?",
                "Confirm",
                MessageBoxButtons.YesNo
            );

            if (confirm != DialogResult.Yes) return;

            try
            {
                using (var conn = new DbHelper(_connectionString).GetConnection())
                {
                    conn.Open();

                    var cmd = new OracleCommand("SP_DROP_USER", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("P_USERNAME", username);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Deleted!");
                LoadUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // =========================
        // UPDATE PASSWORD
        // =========================
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow == null) return;

            string username = dgvUsers.CurrentRow.Cells[0].Value.ToString();
            string newPassword = txtNewPassword.Text.Trim();

            if (string.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("Enter new password");
                return;
            }

            try
            {
                using (var conn = new DbHelper(_connectionString).GetConnection())
                {
                    conn.Open();

                    string sql = $"ALTER USER {username} IDENTIFIED BY {newPassword}";
                    var cmd = new OracleCommand(sql, conn);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Password updated!");
                txtNewPassword.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // =========================
        // SEARCH
        // =========================
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search user...") return;

            string keyword = txtSearch.Text.ToUpper();

            DataTable dt = userService.GetUsers();

            if (!string.IsNullOrEmpty(keyword))
            {
                dt.DefaultView.RowFilter = $"USERNAME LIKE '%{keyword}%'";
            }

            dgvUsers.DataSource = dt;
        }

        // =========================
        // PLACEHOLDER
        // =========================
        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search user...")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = "Search user...";
                txtSearch.ForeColor = Color.Gray;
            }
        }

        private void txtSearchRole_Enter(object sender, EventArgs e)
        {
            if (txtSearchRole.Text == "Search role...")
            {
                txtSearchRole.Text = "";
                txtSearchRole.ForeColor = Color.Black;
            }
        }

        private void txtSearchRole_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchRole.Text))
            {
                txtSearchRole.Text = "Search role...";
                txtSearchRole.ForeColor = Color.Gray;
            }
        }

        //==========================
        // COMBO BOX SELECTION CHANGED 
        //==========================
        private void cboRoles_TextChanged(object sender, EventArgs e)
        {
            if (isFilteringRoles) return;
            if (allRoles == null) return;

            try
            {
                isFilteringRoles = true;

                string text = cboRoles.Text;
                string keyword = text.ToUpper();

                DataView dv = allRoles.DefaultView;

                if (!string.IsNullOrEmpty(keyword))
                {
                    dv.RowFilter = $"ROLE LIKE '%{keyword}%'";
                }
                else
                {
                    dv.RowFilter = "";
                }

                cboRoles.DataSource = dv.ToTable();
                cboRoles.DisplayMember = "ROLE";

                cboRoles.Text = text;
                cboRoles.SelectionStart = text.Length;
            }
            finally
            {
                isFilteringRoles = false;
            }
        }

        private void cboUsers_TextChanged(object sender, EventArgs e)
        {
            if (isFilteringUsers) return;
            if (allUsers == null) return;

            try
            {
                isFilteringUsers = true;

                string text = cboUsers.Text;
                string keyword = text.ToUpper();

                DataView dv = allUsers.DefaultView;

                if (!string.IsNullOrEmpty(keyword))
                {
                    dv.RowFilter = $"USERNAME LIKE '%{keyword}%'";
                }
                else
                {
                    dv.RowFilter = "";
                }

                cboUsers.DataSource = dv.ToTable();
                cboUsers.DisplayMember = "USERNAME";

                cboUsers.Text = text;
                cboUsers.SelectionStart = text.Length;
            }
            finally
            {
                isFilteringUsers = false;
            }
        }
        // =========================
        // VALIDATION
        // =========================
        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            ValidateInput();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            ValidateInput();
        }

        private void ValidateInput()
        {
            btnCreate.Enabled =
                txtUsername.Text.Length > 0 &&
                txtPassword.Text.Length > 0;
        }

        private void txtSearchRole_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearchRole.Text.ToUpper();

            DataTable dt = roleService.GetRoles();

            if (!string.IsNullOrEmpty(keyword))
            {
                dt.DefaultView.RowFilter = $"ROLE LIKE '%{keyword}%'";
            }

            dgvRoles.DataSource = dt;
        }

        private void btnCreateRole_Click(object sender, EventArgs e)
        {
            string roleName = txtRoleName.Text.Trim();
            string password = txtRolePassword.Text.Trim();

            if (string.IsNullOrEmpty(roleName))
            {
                MessageBox.Show("Enter role name");
                return;
            }

            try
            {
                using (var conn = new DbHelper(_connectionString).GetConnection())
                {
                    conn.Open();

                    string sql;

                    if (string.IsNullOrEmpty(password))
                    {
                        sql = $"CREATE ROLE {roleName}";
                    }
                    else
                    {
                        sql = $"CREATE ROLE {roleName} IDENTIFIED BY {password}";
                    }

                    var cmd = new OracleCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Role created!");
                LoadRoles();
                LoadRolesToCombo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRevokeRole_Click(object sender, EventArgs e)
        {
            if (cboUsers.SelectedValue == null || cboRoles.SelectedValue == null)
                return;

            string user = cboUsers.Text;
            string role = cboRoles.Text;

            var confirm = MessageBox.Show(
                $"Revoke role {role} from {user}?",
                "Confirm",
                MessageBoxButtons.YesNo
            );

            if (confirm != DialogResult.Yes) return;

            try
            {
                using (var conn = new DbHelper(_connectionString).GetConnection())
                {
                    conn.Open();

                    string sql = $"REVOKE {role} FROM {user}";
                    var cmd = new OracleCommand(sql, conn);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Role revoked!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteRole_Click(object sender, EventArgs e)
        {
            if (dgvRoles.CurrentRow == null) return;

            string role = dgvRoles.CurrentRow.Cells[0].Value.ToString();

            if (role == "CONNECT" || role == "RESOURCE")
            {
                MessageBox.Show("Cannot delete system role!");
                return;
            }

            var confirm = MessageBox.Show(
                $"Delete role {role}?",
                "Confirm",
                MessageBoxButtons.YesNo
            );

            if (confirm != DialogResult.Yes) return;

            try
            {
                using (var conn = new DbHelper(_connectionString).GetConnection())
                {
                    conn.Open();

                    string sql = $"DROP ROLE {role}";
                    var cmd = new OracleCommand(sql, conn);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Role deleted!");

                LoadRoles();
                LoadRolesToCombo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdateRolePassword_Click(object sender, EventArgs e)
        {
            if (dgvRoles.CurrentRow == null) return;

            string role = dgvRoles.CurrentRow.Cells[0].Value.ToString();
            string newPassword = txtRolePassword.Text.Trim();

            if (string.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("Enter new password");
                return;
            }

            try
            {
                using (var conn = new DbHelper(_connectionString).GetConnection())
                {
                    conn.Open();

                    string sql = $"ALTER ROLE {role} IDENTIFIED BY {newPassword}";
                    var cmd = new OracleCommand(sql, conn);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Role password updated!");
                txtRolePassword.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGrantRole_Click(object sender, EventArgs e)
        {
            if (cboUsers.SelectedValue == null || cboRoles.SelectedValue == null)
                return;

            string user = cboUsers.Text;
            string role = cboRoles.Text;

            try
            {
                using (var conn = new DbHelper(_connectionString).GetConnection())
                {
                    conn.Open();

                    var cmd = new OracleCommand("SP_GRANT_ROLE", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("P_ROLE", role);
                    cmd.Parameters.Add("P_USER", user);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Role granted!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}