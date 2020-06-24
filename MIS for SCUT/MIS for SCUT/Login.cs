using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIS_for_SCUT
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void log_in_Click(object sender, EventArgs e)
        {
            if(username.TextLength == 0)
            {
                Common.ShowError("Error", "Username cannot be empty!");
                return;
            }
            if (password.TextLength == 0)
            {
                Common.ShowError("Error", "Password cannot be empty!");
                return;
            }
            password.Enabled = false;
            log_in.Enabled = false;
            username.Enabled = false;
            loading_text.Visible = true;
            new Thread(QueryForLogin) { IsBackground = true }.Start();
            
        }

        public void QueryForLogin()
        {
            using (MySqlConnection connection = SQL_Help.getConnection(Common.UserType.STUDENT))
            {
                connection.Open();
                LoginResult(SQL_Help.ExecuteDataTable("select authority from user_data where username = @name and password = SHA1(@pwd)",
                connection, new MySqlParameter[] { new MySqlParameter("@name", username.Text), new MySqlParameter("@pwd", password.Text) }));
                connection.Close();
            }
        }

        public delegate void LoginResultDelegate(DataTable dt);

        public void LoginResult(DataTable dt)
        {
            if (InvokeRequired) Invoke(new LoginResultDelegate(LoginResult), dt);
            else
            {
                if (dt.Rows.Count == 0)
                {
                    Common.ShowError("Login Error", "Incorrect username or password!");
                    password.Enabled = true;
                    log_in.Enabled = true;
                    username.Enabled = true;
                    loading_text.Visible = false;
                }
                else
                {
                    using (MainWindow m = new MainWindow() { role = (Common.UserType)dt.Rows[0][0], current_user_name = username.Text})
                    {
                        Hide();
                        if (m.ShowDialog() == DialogResult.OK)
                        {
                            password.Enabled = true;
                            log_in.Enabled = true;
                            username.Enabled = true;
                            loading_text.Visible = false;
                            password.Clear();
                            Show();
                        }
                    }
                }
            }
        }
    }
}
