using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIS_for_SCUT
{
    public partial class PasswordReset : Form
    {
        public PasswordReset()
        {
            InitializeComponent();
        }
        public MySqlConnection connection;
        public string default_password = "123456";

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                Common.ShowError("Error!", "Username can not be empty!");
                return;
            }
            if (SQL_Help.ExecuteDataTable("select authority from user_data where username = @name;", connection, new MySqlParameter[] { new MySqlParameter("@name", textBox1.Text) }).Rows[0][0].ToString() == ((int)Common.UserType.ADMIN).ToString())
            {
                Common.ShowError("Failed!", "Operation denied: Administrator password can not be reset!\nIf you want to reset it, please contact the database administrator.");
                return;
            }
            if (Common.ShowChoice("Password Reset Confirm", "Password for user:" + textBox1.Text + " will be set to " + default_password + "\nAre you sure to continue?") == DialogResult.Yes)
            {
                if (SQL_Help.ExecuteNonQuery("update user_data set password=SHA1(@1) where username=@2;",
                    connection, new MySqlParameter[] { new MySqlParameter("@1", default_password), new MySqlParameter("@2", textBox1.Text) }) > 0)
                {
                    Common.ShowInfo("Done", "Reset Successful!");
                }
            }
        }
    }
}
