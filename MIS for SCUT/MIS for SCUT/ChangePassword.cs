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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }
        public ChangePassword(string u,Common.UserType ut)
        {
            InitializeComponent();
            username = u;
            role = ut;
        }
        private string username;
        private Common.UserType role;
        public MySqlConnection connection { get; set; }
        private void cancle_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            apply.Enabled = check_password();
        }

        private bool check_password()
        {
            return old_pwd.Text.Length > 0 && new_pwd.Text.Length >= 8 && new_pwd.Text == con_new_pwd.Text;
        }

        private void con_new_pwd_TextChanged(object sender, EventArgs e)
        {
            apply.Enabled = check_password();
        }

        private void apply_Click(object sender, EventArgs e)
        {
            DataTable dt = SQL_Help.ExecuteDataTable("select authority from user_data where username = @name and password = SHA1(@pwd)",
                connection, new MySqlParameter[] { new MySqlParameter("@name", username), new MySqlParameter("@pwd", old_pwd.Text) });
            if(dt.Rows.Count == 0)
            {
                Common.ShowError("Password Changing Error", "Old Password is not correct!");
            }
            else
            {
                SQL_Help.ExecuteNonQuery("update user_data set password = SHA1(@pwd) where username = @name",
                                connection, new MySqlParameter[] { new MySqlParameter("@name", username), new MySqlParameter("@pwd", new_pwd.Text) });
                Common.ShowInfo("Done!", "Password changing successful!");
                DialogResult = DialogResult.OK;
                Close();
            }
        }

    }
}
