using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MIS_for_SCUT
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }
        public Common.UserType role { get; set; }
        public string current_user_name { get; set; }
        public bool password_changed = false;
        public MySqlConnection connection;
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (password_changed)
            {
                e.Cancel = false;
                return;
            }
            e.Cancel = Common.ShowChoice("Exit?","Are you sure to exit?") == DialogResult.No;
        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
            if (connection.State == ConnectionState.Open)
                connection.Close();
            DialogResult = DialogResult.OK;
        }

        private void editPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ChangePassword cp = new ChangePassword(current_user_name, role) { connection = connection })
            {
                if(cp.ShowDialog() == DialogResult.OK)
                {
                    Common.ShowInfo("Password Changed!", "Your password has changed, so you should re-login!");
                    password_changed = true;
                    Close();
                }
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            user_text_menuitem.Text = "User: " + current_user_name;
            connection = SQL_Help.getConnection(role);
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            switch (role)
            {
                case Common.UserType.STUDENT:
                    role_text_menuitem.Text = "Role: Student";
                    break;
                case Common.UserType.TEACHER:
                    role_text_menuitem.Text = "Role: Teacher";
                    break;
                case Common.UserType.ADMIN:
                    role_text_menuitem.Text = "Role: Administrator";
                    addAccountToolStripMenuItem.Visible = true;
                    resetUserPasswordToolStripMenuItem.Visible = true;
                    addCourseToolStripMenuItem.Visible = true;
                    addCourseChoosingInfoToolStripMenuItem.Visible = true;
                    break;
                default:
                    role_text_menuitem.Text = "Role: Null";
                    break;
            }
        }

        private void addAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Add_Account a = new Add_Account() { role = role,connection = connection })
            {
                a.ShowDialog();
            }
        }

        private void resetUserPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (PasswordReset pr = new PasswordReset() { connection = connection })
            {
                pr.ShowDialog();
            }
        }

        private void addCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Add_Course ac = new Add_Course() { connection = connection })
            {
                ac.ShowDialog();
            }
        }

        private void addCourseChoosingInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AddCourseChoosingInfo acci = new AddCourseChoosingInfo() { connection = connection })
            {
                acci.ShowDialog();
            }
        }
    }
}
