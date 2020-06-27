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
        public DataTable info_dt;
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
                    submitScoreToolStripMenuItem.Visible = true;
                    break;
                case Common.UserType.ADMIN:
                    role_text_menuitem.Text = "Role: Administrator";
                    addAccountToolStripMenuItem.Visible = true;
                    resetUserPasswordToolStripMenuItem.Visible = true;
                    addCourseToolStripMenuItem.Visible = true;
                    addCourseChoosingInfoToolStripMenuItem.Visible = true;
                    modifyInformationToolStripMenuItem.Visible = true;
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

        private void modifyInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ModifyInfo mi = new ModifyInfo() { connection = connection,role=role })
            {
                mi.ShowDialog();
            }
        }

        private void submitScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable teacher_dt = SQL_Help.ExecuteDataTable("select id,name from teacher_info where id=@id;", connection, new MySqlParameter[]
            {
                new MySqlParameter("@id",MySqlDbType.VarChar){ Value = user_text_menuitem.Text.Substring(user_text_menuitem.Text.Length-5,5) }
            });
            using (SubmitScore ss = new SubmitScore(teacher_dt.Rows[0][0].ToString(), teacher_dt.Rows[0][1].ToString()) { connection = connection })
            {
                ss.ShowDialog();
            }
        }

        private void ClearDGV()
        {
            info_dt = new DataTable();
            dgv.DataSource = null;
            dgv.Columns.Clear();
        }

        private void queryStudentInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearDGV();
            string condition = "";
            if (role == Common.UserType.STUDENT)
            {
                info_dt = SQL_Help.ExecuteDataTable("select * from student_info where id=@id;", connection, new MySqlParameter[]
                {
                    new MySqlParameter("@id",MySqlDbType.VarChar){ Value = current_user_name }
                });
            }
            else
            {
                condition = Common.ShowInput("Please enter student ID or name: ", "Query for student info", "Empty for querying all student.");
                if (condition == null) return;
                if (condition.Length == 0)
                {
                    info_dt = SQL_Help.ExecuteDataTable("select * from student_info;", connection);
                }
                else
                {
                    
                    info_dt = SQL_Help.ExecuteDataTable("select* from student_info where(id=@condition or name=@condition);", connection,new MySqlParameter[] 
                    {
                        new MySqlParameter("@condition",MySqlDbType.VarChar){ Value = condition } 
                    });
                }
            }
            if(info_dt.Rows.Count == 0)
            {
                Common.ShowError("Empty query result", "No such student found with ID or name is " + condition + "!");
                return;
            }
            dgv.DataSource = new BindingSource() { DataSource = info_dt };
            DataColumn show_role_column = new DataColumn("role") { Caption = "Role", DefaultValue = "Student" };
            info_dt.Columns.Add(show_role_column);
        }

        private void queryCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearDGV();
            string condition = "";
            string standard_query_command = "select distinct course_choosing_info.student_id,student_info.name,course_choosing_info.teacher_id,teacher_info.name,course_choosing_info.course_id,course_info.name,course_info.credit,course_choosing_info.chosen_year " +
                    "from course_choosing_info join course_info join student_info join teacher_info " +
                    "on (course_choosing_info.course_id=course_info.id and course_choosing_info.teacher_id=teacher_info.id and course_choosing_info.student_id=student_info.id) ";
            if (role == Common.UserType.STUDENT)
            {
                info_dt = SQL_Help.ExecuteDataTable(
                    standard_query_command + "where course_choosing_info.student_id = @sid;", connection, new MySqlParameter[] 
                    { new MySqlParameter("@sid", MySqlDbType.VarChar) { Value = current_user_name } });
            }
            else
            {
                condition = Common.ShowInput("Please enter student ID or name: ", "Query for student course information", "Empty for querying all student.");
                if (condition == null) return;
                if (condition.Length == 0)
                {
                    info_dt = SQL_Help.ExecuteDataTable(standard_query_command + ";", connection);
                }
                else
                {

                    info_dt = SQL_Help.ExecuteDataTable(standard_query_command+" where (student_info.id=@condition or student_info.name=@condition);", connection, new MySqlParameter[]
                    {
                        new MySqlParameter("@condition",MySqlDbType.VarChar){ Value = condition }
                    });
                }
            }
            if (info_dt.Rows.Count == 0)
            {
                Common.ShowError("Empty query result", "No such student found with ID or name is " + condition + "!");
                return;
            }
            dgv.DataSource = new BindingSource() { DataSource = info_dt };
            for (int i = 0; i < info_dt.Columns.Count; i++)
            {
                dgv.Columns[i].HeaderText = ModifyInfo.choosing_data_table_columns_name_mapping[info_dt.Columns[i].Caption];
            }
            
        }

        private static Dictionary<string, string> student_score_table_columns_name_mapping = new Dictionary<string, string>()
        {
            ["chosen_year"] = "Chosen Year",
            ["score"] = "Score",
            ["student_id"] = "Student",
            ["teacher_id"] = "Teacher",
            ["course_id"] = "Course",
            ["name"] = "Course Name",
            ["name2"] = "Student Name",
            ["name1"] = "Teacher Name",
            ["credit"] = "Credit"
        };

        private void queryStudentScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearDGV();
            string standard_query_command = "select distinct course_choosing_info.course_id,course_info.name,course_choosing_info.score,course_info.credit,course_choosing_info.chosen_year,course_choosing_info.teacher_id,teacher_info.name,course_choosing_info.student_id,student_info.name " +
                "from course_choosing_info join course_info join student_info join teacher_info " +
                "on (course_choosing_info.course_id=course_info.id and course_choosing_info.teacher_id=teacher_info.id and course_choosing_info.student_id=student_info.id) ";
            string student_condition = "";
            string course_condition = "";
            if (role == Common.UserType.STUDENT)
            {
                info_dt = SQL_Help.ExecuteDataTable(
                    standard_query_command + "where course_choosing_info.student_id = @sid;", connection, new MySqlParameter[]
                    { new MySqlParameter("@sid", MySqlDbType.VarChar) { Value = current_user_name } });
            }
            else
            {
                using (ScoreQueryInputDialog sqid = new ScoreQueryInputDialog())
                {
                    if (sqid.ShowDialog() == DialogResult.OK)
                    {
                        student_condition = sqid.student_id;
                        course_condition = sqid.course_id;
                    }
                    else return;
                }
                List<MySqlParameter> query_parameter_array = new List<MySqlParameter>();
                standard_query_command += "where true ";
                if (student_condition.Length != 0)
                {
                    standard_query_command += " and (student_info.id=@student or student_info.name=@student)";
                    query_parameter_array.Add(new MySqlParameter("@student", MySqlDbType.VarChar) { Value = student_condition });
                }
                if (course_condition.Length != 0)
                {
                    standard_query_command += " and (course_info.id=@course or course_info.name like @course_name)";
                    query_parameter_array.Add(new MySqlParameter("@course", MySqlDbType.VarChar) { Value = course_condition });
                    query_parameter_array.Add(new MySqlParameter("@course_name", MySqlDbType.VarChar) { Value = "%" + course_condition + "%" });
                }
                info_dt = SQL_Help.ExecuteDataTable(standard_query_command + ";", connection, query_parameter_array.Count == 0 ? null : query_parameter_array.ToArray());

            }
            dgv.DataSource = new BindingSource() { DataSource = info_dt };
            for (int i = 0; i < info_dt.Columns.Count; i++)
            {
                dgv.Columns[i].HeaderText = student_score_table_columns_name_mapping[info_dt.Columns[i].Caption];
            }
        }
    }
}
