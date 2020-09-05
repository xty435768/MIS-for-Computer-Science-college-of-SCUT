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
        public bool logout_or_exit { get; set; }
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
                logout_or_exit = false;
                return;
            }
            switch (Common.ShowChoice("Exit or logout?", "If you want to exit, please click \"Yes\"\nIf you want to logout, please click \"No\"",MessageBoxIcon.Question,MessageBoxButtons.YesNoCancel))
            {
                case DialogResult.Yes:
                    e.Cancel = false;
                    logout_or_exit = true;
                    break;
                case DialogResult.No:
                    e.Cancel = false;
                    logout_or_exit = false;
                    break;
                default:
                    e.Cancel = true;
                    break;
            }
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
                    queryTeacherInformationToolStripMenuItem.Visible = false;
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
            string basic_query_command = "select id as 'Student ID',name as 'Student Name',sex as 'Sex',entrance_age as 'Entrance Age',entrance_year as 'Entrance Year',class as 'Class' from student_info";
            if (role == Common.UserType.STUDENT)
            {
                info_dt = SQL_Help.ExecuteDataTable(basic_query_command+" where id=@id;", connection, new MySqlParameter[]
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
                    info_dt = SQL_Help.ExecuteDataTable(basic_query_command+";", connection);
                }
                else
                {
                    
                    info_dt = SQL_Help.ExecuteDataTable(basic_query_command+" where(id=@condition or name=@condition);", connection,new MySqlParameter[] 
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
            DataColumn show_role_column = new DataColumn("Role") { Caption = "Role", DefaultValue = "Student" };
            info_dt.Columns.Add(show_role_column);
        }

        private void queryCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearDGV();
            string basic_query_command = "select distinct course_choosing_info.student_id as 'Student ID',student_info.name as 'Student Name',student_info.class as 'Class',course_choosing_info.teacher_id as 'Teacher ID',teacher_info.name as 'Teacher name',course_choosing_info.course_id as 'Course ID',course_info.name as 'Course Name',course_info.credit as 'Credit',course_choosing_info.chosen_year as 'Chosen Year' " +
                    "from course_choosing_info join course_info join student_info join teacher_info " +
                    "on (course_choosing_info.course_id=course_info.id and course_choosing_info.teacher_id=teacher_info.id and course_choosing_info.student_id=student_info.id) ";
            if (role == Common.UserType.STUDENT)
            {
                info_dt = SQL_Help.ExecuteDataTable(
                    basic_query_command + " where course_choosing_info.student_id = @sid;", connection, new MySqlParameter[] 
                    { new MySqlParameter("@sid", MySqlDbType.VarChar) { Value = current_user_name } });
            }
            else
            {
                using (CourseChoosingQueryInputDialog ccqi = new CourseChoosingQueryInputDialog())
                {
                    if (ccqi.ShowDialog() == DialogResult.OK)
                    {
                        if (ccqi.result.Length == 0)
                        {
                            info_dt = SQL_Help.ExecuteDataTable(basic_query_command + ";", connection);
                        }
                        else
                        {
                            if (ccqi.GetStudentCheckedState())
                            {
                                info_dt = SQL_Help.ExecuteDataTable(basic_query_command + " where (student_info.id=@condition or student_info.name=@condition);", connection, new MySqlParameter[]
                                {
                                    new MySqlParameter("@condition",MySqlDbType.VarChar){ Value = ccqi.result }
                                });
                            }
                            else
                            {
                                info_dt = SQL_Help.ExecuteDataTable(basic_query_command + " where (course_info.id=@condition or course_info.name like @name_condition);", connection, new MySqlParameter[]
                                {
                                    new MySqlParameter("@condition",MySqlDbType.VarChar){ Value = ccqi.result },
                                    new MySqlParameter("@name_condition",MySqlDbType.VarChar){ Value = "%"+ccqi.result+"%" }
                                });
                            }
                        }
                    }
                    else return;
                }
            }
            if (info_dt.Rows.Count == 0)
            {
                Common.ShowError("Empty query result", "No such record found!");
                return;
            }
            dgv.DataSource = new BindingSource() { DataSource = info_dt };            
        }

        private void queryStudentScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearDGV();
            string basic_query_command = "select distinct course_choosing_info.course_id as 'Course ID',course_info.name as 'Course Name',course_choosing_info.score as 'Score',course_info.credit as 'Credit',course_choosing_info.chosen_year as 'Chosen Year',course_choosing_info.teacher_id as 'Teacher ID',teacher_info.name as 'Teacher Name',course_choosing_info.student_id as 'Student ID',student_info.name as 'Student Name' " +
                "from course_choosing_info join course_info join student_info join teacher_info " +
                "on (course_choosing_info.course_id=course_info.id and course_choosing_info.teacher_id=teacher_info.id and course_choosing_info.student_id=student_info.id) ";
            string student_condition = "";
            string course_condition = "";
            if (role == Common.UserType.STUDENT)
            {
                info_dt = SQL_Help.ExecuteDataTable(
                    basic_query_command + "where course_choosing_info.student_id = @sid;", connection, new MySqlParameter[]
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
                basic_query_command += "where true ";
                if (student_condition.Length != 0)
                {
                    basic_query_command += " and (student_info.id=@student or student_info.name=@student)";
                    query_parameter_array.Add(new MySqlParameter("@student", MySqlDbType.VarChar) { Value = student_condition });
                }
                if (course_condition.Length != 0)
                {
                    basic_query_command += " and (course_info.id=@course or course_info.name like @course_name)";
                    query_parameter_array.Add(new MySqlParameter("@course", MySqlDbType.VarChar) { Value = course_condition });
                    query_parameter_array.Add(new MySqlParameter("@course_name", MySqlDbType.VarChar) { Value = "%" + course_condition + "%" });
                }
                info_dt = SQL_Help.ExecuteDataTable(basic_query_command + ";", connection, query_parameter_array.Count == 0 ? null : query_parameter_array.ToArray());

            }
            dgv.DataSource = new BindingSource() { DataSource = info_dt };
            //for (int i = 0; i < info_dt.Columns.Count; i++)
            //{
            //    dgv.Columns[i].HeaderText = student_score_table_columns_name_mapping[info_dt.Columns[i].Caption];
            //}
        }

        private void queryCourseInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearDGV();
            string condition = "";
            string basic_query_command = "select course_info.id as 'Course ID',course_info.name as 'Course Name',course_info.teacher_id as 'Teacher ID',teacher_info.name as 'Teacher Name',course_info.credit as 'Credit',course_info.grade_limit as 'Grade Limit',course_info.canceled_year as 'Canceled Year' " +
                "from course_info join teacher_info " +
                "on (course_info.teacher_id=teacher_info.id)";
            if (role == Common.UserType.STUDENT)
            {
                info_dt = SQL_Help.ExecuteDataTable(basic_query_command+" where course_info.id in (select course_id from course_choosing_info where student_id=@id);", connection, new MySqlParameter[]
                {
                    new MySqlParameter("@id",MySqlDbType.VarChar){ Value = current_user_name }
                });
            }
            else
            {
                using (CourseQueryInputDialog cqid = new CourseQueryInputDialog())
                {
                    if (cqid.ShowDialog() == DialogResult.OK)
                    {
                        if (cqid.result.Length == 0)
                        {
                            info_dt = SQL_Help.ExecuteDataTable(basic_query_command + ";", connection);
                        }
                        else
                        {
                            if (cqid.GetTeacherRadioButtonChecked())
                            {
                                info_dt = SQL_Help.ExecuteDataTable(basic_query_command + " where (teacher_info.id=@condition or teacher_info.name=@condition);", connection, new MySqlParameter[]
                                {
                                    new MySqlParameter("@condition",MySqlDbType.VarChar){ Value = cqid.result }
                                });
                            }
                            else
                            {
                                info_dt = SQL_Help.ExecuteDataTable(basic_query_command + " where(course_info.id=@condition or course_info.name like @name_condition);", connection, new MySqlParameter[]
                                {
                                    new MySqlParameter("@condition",MySqlDbType.VarChar){ Value = cqid.result },
                                    new MySqlParameter("@name_condition",MySqlDbType.VarChar){ Value = "%"+cqid.result+"%" }
                                });
                            }
                        }
                    }
                    else return;
                }
            }
            if (info_dt.Rows.Count == 0)
            {
                Common.ShowError("Empty query result", "No such course found with ID or name is/like " + condition + "!");
                return;
            }
            dgv.DataSource = new BindingSource() { DataSource = info_dt };
            //info_dt.Columns["id"].Caption = "course_id";
        }

        private void queryTeacherInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearDGV();
            string condition = "";
            string basic_query_command = "select id as 'Teacher ID',name as 'Teacher Name' from teacher_info";
            condition = Common.ShowInput("Please enter teacher ID or name: ", "Query for teacher info", "Empty for querying all teacher.");
            if (condition == null) return;
            if (condition.Length == 0)
            {
                info_dt = SQL_Help.ExecuteDataTable(basic_query_command+";", connection);
            }
            else
            {
                info_dt = SQL_Help.ExecuteDataTable(basic_query_command+" where(id=@condition or name=@condition);", connection, new MySqlParameter[]
                {
                        new MySqlParameter("@condition",MySqlDbType.VarChar){ Value = condition }
                });
            }
            if (info_dt.Rows.Count == 0)
            {
                Common.ShowError("Empty query result", "No such teacher found with ID or name is " + condition + "!");
                return;
            }
            dgv.DataSource = new BindingSource() { DataSource = info_dt };
            //for (int i = 0; i < info_dt.Columns.Count; i++)
            //{
            //    dgv.Columns[i].HeaderText = student_score_table_columns_name_mapping[info_dt.Columns[i].Caption];
            //}
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AboutHelpDialog ahd = new AboutHelpDialog("http://siriusxiang.xyz/MIS_for_scut/about.html"))
            {
                ahd.Text = "About";
                ahd.SetWebBroser();
                ahd.ShowDialog();
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AboutHelpDialog ahd = new AboutHelpDialog("http://siriusxiang.xyz/MIS_for_scut/about.html"))
            {
                ahd.Text = "Help";
                ahd.ShowDialog();
            }
        }

        private void singleStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearDGV();
            string condition = "";
            string basic_query_command = "select student_id as 'Student ID',name as 'Student Name',round(sum(cs)/sum(credit),2) as 'Weighted average score' from " +
                "(select distinct student_id,credit*score as cs,credit,course_id,chosen_year,course_choosing_info.teacher_id " +
                "from course_choosing_info join course_info on (course_choosing_info.course_id=course_info.id) " +
                "where course_choosing_info.score is not null) as a join student_info on (a.student_id=student_info.id) ";
            string basic_query_command_end = " group by student_id;";
            if (role == Common.UserType.STUDENT)
            {
                info_dt = SQL_Help.ExecuteDataTable(basic_query_command + " where student_id=@id"+basic_query_command_end, connection, new MySqlParameter[]
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
                    info_dt = SQL_Help.ExecuteDataTable(basic_query_command + basic_query_command_end, connection);
                }
                else
                {

                    info_dt = SQL_Help.ExecuteDataTable(basic_query_command + " where(student_id=@condition or name=@condition)" + basic_query_command_end, connection, new MySqlParameter[]
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
        }

        private void allStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearDGV();
            
            string basic_query_command = "select round(avg(was),2) as \"Weighted Average Score for All Students\"  " +
                "from (select student_id as 'Student ID',name as 'Student Name',round(sum(cs)/sum(credit),2) as was " +
                "from (select distinct student_id,credit*score as cs,credit,course_id,chosen_year,course_choosing_info.teacher_id " +
                "from course_choosing_info join course_info on (course_choosing_info.course_id=course_info.id) where course_choosing_info.score is not null) as a join student_info on (a.student_id=student_info.id) " +
                "group by student_id) as b; ";
            info_dt = SQL_Help.ExecuteDataTable(basic_query_command, connection);
            if (info_dt.Rows.Count == 0)
            {
                Common.ShowError("Empty query result", "No such record found!");
                return;
            }
            dgv.DataSource = new BindingSource() { DataSource = info_dt };

        }

        private void studentsInSameClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearDGV();
            string basic_query_command = "select class as 'Class',round(avg(was),2) as \"Class Weighted Average Score\" " +
                "from (select student_id as 'Student ID',name as 'Student Name',round(sum(cs)/sum(credit),2) as was,class " +
                "from (select distinct student_id,credit*score as cs,credit,course_id,chosen_year,course_choosing_info.teacher_id " +
                "from course_choosing_info join course_info on (course_choosing_info.course_id=course_info.id) " +
                "where course_choosing_info.score is not null) as a join student_info on (a.student_id=student_info.id) " +
                "where student_id in (select student_info.id from student_info ";
            string basic_query_command_end = " ) group by student_id) as b group by class;";
            using (ChooseClassDialog ccd = new ChooseClassDialog() { connection = connection })
            {
                if (ccd.ShowDialog() == DialogResult.OK)
                {
                    if (ccd.result != "All Class")
                    {
                        info_dt = SQL_Help.ExecuteDataTable(basic_query_command + "where class=@class" + basic_query_command_end, connection, new MySqlParameter[]
                        {
                            new MySqlParameter("@class",MySqlDbType.VarChar){ Value = ccd.result }
                        });
                    }
                    else info_dt = SQL_Help.ExecuteDataTable(basic_query_command + basic_query_command_end, connection);
                }
                else return;
            }
            if (info_dt.Rows.Count == 0)
            {
                Common.ShowError("Empty query result", "Class not found or this class has no score information can be queried!");
                return;
            }
            dgv.DataSource = new BindingSource() { DataSource = info_dt };
        }

        private void singleCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (CourseAverageQueryDialog caqd = new CourseAverageQueryDialog() { connection = connection })
            {
                if (caqd.ShowDialog() == DialogResult.OK)
                {
                    info_dt = SQL_Help.ExecuteDataTable("select course_id as 'Course ID',course_info.name as 'Course Name',course_choosing_info.teacher_id as 'Teacher ID',teacher_info.name as 'Teacher Name',chosen_year as 'Chosen year',round(avg(score),2) as 'Course Average Score' " +
                        "from course_choosing_info join teacher_info join course_info on (course_choosing_info.course_id=course_info.id and course_choosing_info.teacher_id=teacher_info.id) " +
                        "where course_id=@cid and course_choosing_info.teacher_id=@tid and chosen_year=@year and score is not null;", connection, new MySqlParameter[]
                    {
                        new MySqlParameter("@cid",MySqlDbType.VarChar){ Value = caqd.course.Substring(0,7) },
                        new MySqlParameter("@tid",MySqlDbType.VarChar){ Value = caqd.teacher.Substring(0,5) },
                        new MySqlParameter("@year",MySqlDbType.Int32){ Value = caqd.year }
                    });
                }
                else return;
            }
            if (info_dt.Rows.Count == 0)
            {
                Common.ShowError("Empty query result", "Course not found or this course has no score information can be queried!");
                return;
            }
            dgv.DataSource = new BindingSource() { DataSource = info_dt };
        }
    }
}
