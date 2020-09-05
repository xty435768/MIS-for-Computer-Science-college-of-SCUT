using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MIS_for_SCUT
{
    public partial class ModifyInfo : Form
    {
        public ModifyInfo()
        {
            InitializeComponent();
        }
        public MySqlConnection connection { get; set; }
        public Common.UserType role { get; set; }
        public Dictionary<string, string> course_teacher_mapping = new Dictionary<string, string>();
        public bool canceled_year_textbox_has_real_text = false;
        DataTable student_choosing_dt = new DataTable();
        private void student_query_button_Click(object sender, EventArgs e)
        {
            if(student_current_id_textBox.Text.Length == 0)
            {
                Common.ShowError("Null value error!", "ID can not be empty!");
                return;
            }
            student_current_id_textBox.ReadOnly = true;
            DataTable current_info_dt = SQL_Help.ExecuteDataTable("select * from student_info where id=@id;", connection, new MySqlParameter[] { new MySqlParameter("@id", MySqlDbType.VarChar) { Value = student_current_id_textBox.Text } });
            if(current_info_dt.Rows.Count == 0)
            {
                Common.ShowError("Empty query result!", "No corresponding student found with id = " + student_current_id_textBox.Text + ".\nPlease check again.");
                student_current_id_textBox.ReadOnly = false;
            }
            else
            {
                student_new_name_textBox.Text = student_current_name_textBox.Text = current_info_dt.Rows[0][1].ToString();
                student_new_sex_comboBox.Text = student_current_sex_textBox.Text = current_info_dt.Rows[0][2].ToString();
                student_new_age_textBox.Text = student_current_age_textBox.Text = current_info_dt.Rows[0][3].ToString();
                student_new_year_textBox.Text = student_current_year_textBox.Text = current_info_dt.Rows[0][4].ToString();
                student_new_class_comboBox.Text = student_current_class_textBox.Text = current_info_dt.Rows[0][5].ToString();
                student_new_id_textBox.Text = student_current_id_textBox.Text;
                student_new_info_groupBox.Enabled = true;
                student_apply_button.Enabled = true;
                student_delete_button.Enabled = true;
            }
            DataTable class_dt = SQL_Help.ExecuteDataTable("select distinct class from student_info;", connection, null);
            for (int i = 0; i < class_dt.Rows.Count; i++)
            {
                student_new_class_comboBox.Items.Add(class_dt.Rows[i][0].ToString());
            }
        }

        private void student_clear_button_Click(object sender, EventArgs e)
        {
            student_current_name_textBox.Clear();
            student_current_sex_textBox.Clear();
            student_current_age_textBox.Clear();
            student_current_year_textBox.Clear();
            student_current_class_textBox.Clear();
            student_current_id_textBox.Clear();
            student_current_id_textBox.ReadOnly = false;
            student_new_info_groupBox.Enabled = false;
            student_new_name_textBox.Clear();
            student_new_sex_comboBox.Text = "";
            student_new_age_textBox.Clear();
            student_new_year_textBox.Clear();
            student_new_class_comboBox.Text = "";
            student_new_class_comboBox.Items.Clear();
            student_new_id_textBox.Clear();
            student_apply_button.Enabled = false;
            student_delete_button.Enabled = false;
        }

        private void student_apply_button_Click(object sender, EventArgs e)
        {
            if (student_new_id_textBox.Text.Length == 0 || student_new_name_textBox.Text.Length == 0 ||
                student_new_age_textBox.Text.Length == 0 ||
                student_new_year_textBox.Text.Length == 0 || student_new_class_comboBox.Text.Length == 0)
            {
                Common.ShowError("Format error!", "All the field should not be null! Please check again!");
                return;
            }
            if (!Regex.IsMatch(student_new_id_textBox.Text, @"^\d{10}$"))
            {
                Common.ShowError("Format checking error!", "ID format error! The length of student ID should be 10!");
                return;
            }
            if (!Regex.IsMatch(student_new_age_textBox.Text, @"^\d{2}$") && int.Parse(student_new_age_textBox.Text) >= 10 && int.Parse(student_new_age_textBox.Text) <= 50)
            {
                Common.ShowError("Format checking error!", "Entrance age format error! It should between 10 and 50!");
                return;
            }
            if (!Regex.IsMatch(student_new_year_textBox.Text, @"^\d{4}$"))
            {
                Common.ShowError("Format error!", "Entrance year format error! \nPlease chech again!");
                return;
            }
            int update_result = SQL_Help.ExecuteNonQuery("update student_info set id=@new_id,name=@new_name,sex=@new_sex,entrance_age=@new_age,entrance_year=@new_year,class=@new_class where id=@old_id;update user_data set username=@new_id where username=@old_id", connection, new MySqlParameter[]
            {
                new MySqlParameter("@new_id",MySqlDbType.VarChar){Value = student_new_id_textBox.Text},
                new MySqlParameter("@new_name",MySqlDbType.VarChar){Value = student_new_name_textBox.Text},
                new MySqlParameter("@new_age",MySqlDbType.Int32){Value = student_new_age_textBox.Text},
                new MySqlParameter("@new_sex",MySqlDbType.VarChar){Value = student_new_sex_comboBox.Text},
                new MySqlParameter("@new_year",MySqlDbType.Int32){Value = student_new_year_textBox.Text},
                new MySqlParameter("@new_class",MySqlDbType.VarChar){Value = student_new_class_comboBox.Text},
                new MySqlParameter("@old_id",MySqlDbType.VarChar){Value = student_current_id_textBox.Text}
            });
            if (update_result > 0)
            {
                Common.ShowInfo("Done!", "Modify successfully!");
                student_current_id_textBox.Text = student_new_id_textBox.Text;
                student_query_button.PerformClick();
            }
            

        }

        private void student_delete_button_Click(object sender, EventArgs e)
        {
            if(Common.ShowChoice("Delete Confirm", string.Format("Are you sure to delete the student ({0},{1})",student_current_id_textBox.Text, student_current_name_textBox.Text) +"?\nAll information about the student in the database will be deleted",MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int delete_result = SQL_Help.ExecuteNonQuery("delete from student_info where id=@id;delete from user_data where username=@id;", connection, new MySqlParameter[]
                    {new MySqlParameter("@id",MySqlDbType.VarChar){ Value = student_current_id_textBox.Text } });
                if (delete_result > 0)
                {
                    Common.ShowInfo("Done", "Delete successfully!");
                    student_clear_button.PerformClick();
                }
            }
        }

        private void ModifyInfo_Load(object sender, EventArgs e)
        {
            switch (role)
            {
                case Common.UserType.STUDENT:
                    Enabled = false;
                    break;
                case Common.UserType.TEACHER:
                    student_info_tabPage.Parent = null;
                    course_info_tabPage.Parent = null;
                    course_choosing_info_tabPage.Parent = null;
                    break;
                case Common.UserType.ADMIN:
                    break;
                default:
                    break;
            }
            DataTable teacher_dt = SQL_Help.ExecuteDataTable("select id,name from teacher_info;", connection);
            for (int i = 0; i < teacher_dt.Rows.Count; i++)
            {
                course_teacher_mapping.Add(teacher_dt.Rows[i][0].ToString(), teacher_dt.Rows[i][1].ToString());
                course_new_teacher_comboBox.Items.Add(string.Format("{0}({1})", teacher_dt.Rows[i][0].ToString(), teacher_dt.Rows[i][1].ToString()));
            }
            course_new_year_textBox.Text = "Optional";
            course_new_year_textBox.ForeColor = Color.Gray;
            
            
        }

        private void course_query_button_Click(object sender, EventArgs e)
        {
            if (course_current_id_textBox.Text.Length == 0)
            {
                Common.ShowError("Null value error!", "ID can not be empty!");
                return;
            }
            course_current_id_textBox.ReadOnly = true;
            DataTable current_info_dt = SQL_Help.ExecuteDataTable("select * from course_info where id=@id;", connection, new MySqlParameter[] { new MySqlParameter("@id", MySqlDbType.VarChar) { Value = course_current_id_textBox.Text } });
            if (current_info_dt.Rows.Count == 0)
            {
                Common.ShowError("Empty query result!", "No corresponding course found with id = " + course_current_id_textBox.Text + ".\nPlease check again.");
                course_current_id_textBox.ReadOnly = false;
            }
            else
            {
                course_new_name_textBox.Text = course_current_name_textBox.Text = current_info_dt.Rows[0][1].ToString();
                //course_new_teacher_comboBox.Text = course_current_teacher_comboBox.Text = current_info_dt.Rows[0][2].ToString() + string.Format("({0})", course_teacher_mapping[current_info_dt.Rows[0][2].ToString()]);
                for (int i = 0; i < current_info_dt.Rows.Count; i++)
                {
                    course_current_teacher_comboBox.Items.Add(current_info_dt.Rows[i][2].ToString() + string.Format("({0})", course_teacher_mapping[current_info_dt.Rows[i][2].ToString()]));
                }
                course_new_teacher_comboBox.Text = course_current_teacher_comboBox.Text = course_current_teacher_comboBox.Items[0].ToString();
                course_current_teacher_comboBox.Enabled = true;
                course_new_credit_textBox.Text = course_current_credit_textBox.Text = current_info_dt.Rows[0][3].ToString();
                course_new_year_textBox.Text = course_current_year_textBox.Text = current_info_dt.Rows[0][5].ToString();
                canceled_year_textbox_has_real_text = course_current_year_textBox.Text.Length != 0;
                if (canceled_year_textbox_has_real_text) course_new_year_textBox.ForeColor = Color.Black;
                course_new_grade_comboBox.Text = course_current_grade_textBox.Text = current_info_dt.Rows[0][4].ToString();
                course_new_id_textBox.Text = course_current_id_textBox.Text;
                course_new_info_groupBox.Enabled = true;
                course_apply_button.Enabled = true;
                course_delete_button.Enabled = true;
                course_delete_record_button.Enabled = true;
            }

        }

        private void course_clear_button_Click(object sender, EventArgs e)
        {
            course_current_name_textBox.Clear();
            course_current_teacher_comboBox.Enabled = false;
            course_current_teacher_comboBox.Items.Clear();
            course_current_credit_textBox.Clear();
            course_current_year_textBox.Clear();
            course_current_grade_textBox.Clear();
            course_current_id_textBox.Clear();
            course_current_id_textBox.ReadOnly = false;
            course_new_info_groupBox.Enabled = false;
            course_new_name_textBox.Clear();
            course_new_teacher_comboBox.Text = "";
            course_new_credit_textBox.Clear();
            course_new_year_textBox.Clear();
            course_new_grade_comboBox.Text = "";
            course_new_id_textBox.Clear();
            course_apply_button.Enabled = false;
            course_delete_button.Enabled = false;
            course_delete_record_button.Enabled = false;
        }

        private void course_new_year_textBox_Enter(object sender, EventArgs e)
        {
            if (!canceled_year_textbox_has_real_text) course_new_year_textBox.Clear();
            course_new_year_textBox.ForeColor = Color.Black;
        }

        private void course_new_year_textBox_Leave(object sender, EventArgs e)
        {
            if (!course_new_info_groupBox.Enabled) return;
            if (course_new_year_textBox.Text.Length == 0)
            {
                ((TextBox)sender).Text = "Optional.";
                ((TextBox)sender).ForeColor = Color.Gray;
                canceled_year_textbox_has_real_text = false;
            }
            else canceled_year_textbox_has_real_text = true;
        }

        private void course_apply_button_Click(object sender, EventArgs e)
        {
            course_delete_record_button.Enabled = false;
            course_delete_button.Enabled = false;
            if (course_new_id_textBox.Text.Length == 0 || course_new_name_textBox.Text.Length == 0 ||
                course_new_teacher_comboBox.Text.Length == 0 || course_new_credit_textBox.Text.Length == 0 ||
                course_new_grade_comboBox.Text.Length == 0)
            {
                Common.ShowError("Null Value Error", "Please ensure that all new fields except cancelled-year are not null!");
                return;
            }
            if (!Regex.IsMatch(course_new_id_textBox.Text, @"^\d{7}$"))
            {
                Common.ShowError("Format error!", "ID format error! \nThe length of course ID should be 7!");
                return;
            }
            if (!course_new_teacher_comboBox.Items.Contains(course_new_teacher_comboBox.Text))
            {
                Common.ShowError("Format error!", "Teacher ID format error! \nPlease select the correct item from the teacher combo list!");
                return;
            }
            if (!Regex.IsMatch(course_new_credit_textBox.Text, @"^(([1-9]{1}\d*)|([0]{1}))(\.(\d)?)?$"))
            {
                Common.ShowError("Format error!", "Credit format error! \nThe credit should be integer or one place decimal!");
                return;
            }
            if (course_new_year_textBox.Text.Length != 0 && !Regex.IsMatch(course_new_year_textBox.Text, @"^\d{4}$"))
            {
                Common.ShowError("Format error!", "Canceled year format error! \nPlease chech again!");
                return;
            }
            if(SQL_Help.ExecuteDataTable("select id from course_info where (not id=@old and id=@new);",connection,new MySqlParameter[] 
            {
                new MySqlParameter("@old",MySqlDbType.VarChar){ Value = course_current_id_textBox.Text},
                new MySqlParameter("@new",MySqlDbType.VarChar){ Value = course_new_id_textBox.Text}
            }).Rows.Count!=0)
            {
                Common.ShowError("ID update error!", string.Format("Duplicate course ID for {0}! Please change to another one.", course_new_id_textBox.Text));
                return;
            }

            MySqlParameter year_parameter = new MySqlParameter("@year", MySqlDbType.Int32);
            MySqlParameter new_id_parameter = new MySqlParameter("@id", MySqlDbType.VarChar) { Value = course_new_id_textBox.Text };
            if (!canceled_year_textbox_has_real_text)
            {
                year_parameter.Value = DBNull.Value;
            }
            else
            {
                year_parameter.Value = course_new_year_textBox.Text;
            }
            int apply_result_basic_info = SQL_Help.ExecuteNonQuery("update course_info set id=@id,name=@name,credit=@credit,grade_limit=@grade,canceled_year=@year where id=@old_id;", connection, new MySqlParameter[]
            {
                new_id_parameter,
                new MySqlParameter("@name",MySqlDbType.VarChar){ Value = course_new_name_textBox.Text},
                new MySqlParameter("@credit",MySqlDbType.Double){ Value = course_new_credit_textBox.Text},
                new MySqlParameter("@grade",MySqlDbType.Int32){ Value = course_new_grade_comboBox.Text},
                year_parameter,
                new MySqlParameter("@old_id",MySqlDbType.VarChar){ Value = course_current_id_textBox.Text},
                
            });
            if (apply_result_basic_info <= 0) return;
            int apply_result_teacher_info = SQL_Help.ExecuteNonQuery("update course_info set teacher_id=@teacher_id where (id=@id and teacher_id=@old_teacher_id);", connection, new MySqlParameter[]
            {
                new MySqlParameter("@teacher_id",MySqlDbType.VarChar){ Value = course_new_teacher_comboBox.Text.Substring(0,5)},
                new_id_parameter,
                new MySqlParameter("@old_teacher_id",MySqlDbType.VarChar){ Value = course_current_teacher_comboBox.Text.Substring(0, 5)}});
            int delete_from_old_result = int.MaxValue, add_to_new_result = int.MaxValue;
            delete_from_old_result = DeleteCourseFromOldTeacher(course_current_teacher_comboBox.Text.Substring(0, 5), course_current_id_textBox.Text);
            add_to_new_result = AddCourseToNewTeacher(course_new_teacher_comboBox.Text.Substring(0, 5), course_new_id_textBox.Text);
            foreach (DataRow item in SQL_Help.ExecuteDataTable("select teacher_id from course_info where id=@id;",connection,new MySqlParameter[] { new_id_parameter}).Rows)
            {
                if (item[0].ToString() == course_new_teacher_comboBox.Text.Substring(0, 5)) continue;
                DeleteCourseFromOldTeacher(item[0].ToString(), course_current_id_textBox.Text);
                AddCourseToNewTeacher(item[0].ToString(), course_new_id_textBox.Text);
            }
            if (apply_result_basic_info > 0 && apply_result_teacher_info > 0 && delete_from_old_result > 0 && add_to_new_result > 0)
            {
                Common.ShowInfo("Done!", "Modify successfully!");
                course_current_id_textBox.Text = course_new_id_textBox.Text;
                course_query_button.PerformClick();
            }
            
        }

        private int DeleteCourseFromOldTeacher(string teacher_id,string course_id)
        {
            DataTable old_courses = SQL_Help.ExecuteDataTable("select courses from teacher_info where id=@id;", connection, new MySqlParameter[] { new MySqlParameter("@id", MySqlDbType.VarChar) { Value = teacher_id } });
            List<string> old_courses_list = new List<string>(old_courses.Rows[0][0].ToString().Split(','));
            old_courses_list.Remove(course_id);
            string new_courses = string.Join(",", old_courses_list.ToArray());
            return SQL_Help.ExecuteNonQuery("update teacher_info set courses=@courses where id=@id;",connection, new MySqlParameter[]
            {
                new MySqlParameter("@id",MySqlDbType.VarChar){ Value = teacher_id },
                new MySqlParameter("@courses",MySqlDbType.Text){Value = new_courses }
            });
        }

        private int AddCourseToNewTeacher(string teacher_id, string course_id)
        {
            DataTable old_courses = SQL_Help.ExecuteDataTable("select courses from teacher_info where id=@id;", connection, new MySqlParameter[] { new MySqlParameter("@id", MySqlDbType.VarChar) { Value = teacher_id } });
            List<string> old_courses_list = new List<string>(old_courses.Rows[0][0].ToString().Split(','));
            if (old_courses_list[0].Length == 0) old_courses_list.Clear();
            old_courses_list.Add(course_id);
            string new_courses = string.Join(",", old_courses_list.ToArray());
            return SQL_Help.ExecuteNonQuery("update teacher_info set courses=@courses where id=@id;", connection, new MySqlParameter[]
            {
                new MySqlParameter("@id",MySqlDbType.VarChar){ Value = teacher_id },
                new MySqlParameter("@courses",MySqlDbType.Text){Value = new_courses }
            });
        }

        private void course_delete_button_Click(object sender, EventArgs e)
        {
            if (Common.ShowChoice("Delete Confirm", string.Format("Are you sure to delete the course ({0},{1})", course_current_id_textBox.Text, course_current_name_textBox.Text) + "?\nAll records about the course in the database will be deleted.", MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                foreach (DataRow item in SQL_Help.ExecuteDataTable("select teacher_id from course_info where id=@id;", connection, new MySqlParameter[] { new MySqlParameter("@id", MySqlDbType.VarChar) { Value = course_current_id_textBox.Text} }).Rows)
                {
                    DeleteCourseFromOldTeacher(item[0].ToString(), course_current_id_textBox.Text);
                }
                int delete_result = SQL_Help.ExecuteNonQuery("delete from course_info where id=@id;", connection, new MySqlParameter[]
                    {new MySqlParameter("@id",MySqlDbType.VarChar){ Value = course_current_id_textBox.Text } });
                if (delete_result > 0)
                {
                    Common.ShowInfo("Done", "Delete successfully!");
                    course_clear_button.PerformClick();
                }
            }
        }

        private void course_delete_record_button_Click(object sender, EventArgs e)
        {
            if (Common.ShowChoice("Delete Confirm", string.Format("Are you sure to delete the course record ({0},{1},{2})", course_current_id_textBox.Text, course_current_name_textBox.Text, course_current_teacher_comboBox.Text) + "?", MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DeleteCourseFromOldTeacher(course_current_teacher_comboBox.Text.Substring(0,5), course_current_id_textBox.Text);
                int delete_result = SQL_Help.ExecuteNonQuery("delete from course_info where (id=@id and teacher_id=@teacher_id);", connection, new MySqlParameter[] {
                    new MySqlParameter("@id",MySqlDbType.VarChar){ Value = course_current_id_textBox.Text },
                    new MySqlParameter("@teacher_id",MySqlDbType.VarChar){ Value = course_current_teacher_comboBox.Text.Substring(0,5) },
                 });
                if (delete_result > 0)
                {
                    Common.ShowInfo("Done", "Delete successfully!");
                    course_clear_button.PerformClick();
                }
            }

        }

        //public static Dictionary<string, string> choosing_data_table_columns_name_mapping = new Dictionary<string, string>()
        //{
        //    ["chosen_year"] = "Chosen Year",
        //    ["score"] = "Score",
        //    ["student_id"] = "Student",
        //    ["teacher_id"] = "Teacher",
        //    ["course_id"] = "Course",
        //    ["name"] = "Name",
        //    ["name2"] = "Course Name",
        //    ["name1"] = "Teacher Name",
        //    ["credit"] = "Credit"
        //};

        private void choosing_query_button_Click(object sender, EventArgs e)
        {
            choosing_query_button.Enabled = false;
            if(choosing_student_id_textbox.Text.Length == 0)
            {
                Common.ShowError("Null value error", "Student ID can not be null!");
                return;
            }
            student_choosing_dt = SQL_Help.ExecuteDataTable(
                "select distinct course_choosing_info.course_id as 'Course ID',course_info.name as 'Course Name',course_choosing_info.student_id as 'Student ID',student_info.name as 'Student Name',course_choosing_info.teacher_id as 'Teacher ID',teacher_info.name as 'Teacher Name',course_choosing_info.chosen_year as 'Chosen Year',course_choosing_info.score as 'Score',course_info.credit as 'Credit' " +
                "from course_choosing_info join course_info join student_info join teacher_info " +
                "on (course_choosing_info.course_id=course_info.id and course_choosing_info.teacher_id=teacher_info.id and course_choosing_info.student_id=student_info.id) " +
                "where course_choosing_info.student_id = @sid;", connection, new MySqlParameter[] { new MySqlParameter("@sid", MySqlDbType.VarChar) { Value = choosing_student_id_textbox.Text } });
            //student_choosing_dt.Columns["chosen_year"].SetOrdinal(4);
            //student_choosing_dt.Columns["score"].SetOrdinal(3);
            if(student_choosing_dt.Rows.Count == 0)
            {
                Common.ShowError("Empty query result error", "No records found with student_id = "+choosing_student_id_textbox.Text+"!");
                choosing_clear_button.PerformClick();
                return;
            }
            dgv.DataSource = new BindingSource() { DataSource = student_choosing_dt };
            //for (int i = 0; i < student_choosing_dt.Columns.Count; i++)
            //{
            //    dgv.Columns[i].HeaderText = choosing_data_table_columns_name_mapping[student_choosing_dt.Columns[i].Caption];
            //}
            
            //dgv.Columns["score"].DisplayIndex = dgv.Columns.Count - 1;
            //dgv.Columns["chosen_year"].DisplayIndex = dgv.Columns.Count - 1;
            DataGridViewButtonColumn modify_btn = new DataGridViewButtonColumn();
            modify_btn.HeaderText = "Modify";
            modify_btn.Name = "modify";
            modify_btn.DefaultCellStyle.NullValue = "Modify";
            dgv.Columns.Add(modify_btn);
            dgv.Columns["modify"].DisplayIndex = 0;
            DataGridViewButtonColumn delete_btn = new DataGridViewButtonColumn();
            delete_btn.HeaderText = "Delete";
            delete_btn.Name = "delete";
            delete_btn.DefaultCellStyle.NullValue = "Delete";
            dgv.Columns.Add(delete_btn);
            dgv.Columns["delete"].DisplayIndex = 1;
        }

        private void choosing_clear_button_Click(object sender, EventArgs e)
        {
            choosing_query_button.Enabled = true;
            student_choosing_dt = new DataTable();
            dgv.DataSource = null;
            dgv.Columns.Clear();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgv.Rows[e.RowIndex].Cells[e.ColumnIndex] is DataGridViewButtonCell)
            {
                if(dgv.Columns[e.ColumnIndex].DefaultCellStyle.NullValue.ToString() == "Modify")
                {
                    using (ChoosingInfoModify cim = new ChoosingInfoModify()
                    {
                        connection = connection,
                        year = dgv.Rows[e.RowIndex].Cells["Chosen Year"].Value.ToString(),
                        score = dgv.Rows[e.RowIndex].Cells["Score"].Value.ToString(),
                        student = string.Format("{0}({1})", dgv.Rows[e.RowIndex].Cells["Student ID"].Value, dgv.Rows[e.RowIndex].Cells["Student Name"].Value),
                        teacher = string.Format("{0}({1})", dgv.Rows[e.RowIndex].Cells["Teacher ID"].Value, dgv.Rows[e.RowIndex].Cells["Teacher Name"].Value),
                        course = string.Format("{0}({1})", dgv.Rows[e.RowIndex].Cells["Course ID"].Value, dgv.Rows[e.RowIndex].Cells["Course Name"].Value),
                        credit = dgv.Rows[e.RowIndex].Cells["Credit"].Value.ToString(),
                        role = Common.UserType.ADMIN
                    })
                    {
                        cim.ShowDialog();
                        choosing_clear_button.PerformClick();
                        choosing_query_button.PerformClick();
                    }
                }
                else if(dgv.Columns[e.ColumnIndex].DefaultCellStyle.NullValue.ToString() == "Delete")
                {
                    if (Common.ShowChoice("Delete Confirm", string.Format("Are you sure to delete the record ({0},{1},{2},{3})", dgv.Rows[e.RowIndex].Cells["Student Name"].Value, dgv.Rows[e.RowIndex].Cells["Course Name"].Value, dgv.Rows[e.RowIndex].Cells["Teacher Name"].Value, dgv.Rows[e.RowIndex].Cells["Chosen Year"].Value) + "?", MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        int delete_result = SQL_Help.ExecuteNonQuery("delete from course_choosing_info where (course_id=@course_id and teacher_id=@teacher_id and student_id=@student_id and chosen_year=@year);", connection, new MySqlParameter[]
                            {
                                new MySqlParameter("@course_id",MySqlDbType.VarChar){ Value = dgv.Rows[e.RowIndex].Cells["Course ID"].Value },
                                new MySqlParameter("@teacher_id",MySqlDbType.VarChar){ Value = dgv.Rows[e.RowIndex].Cells["Teacher ID"].Value },
                                new MySqlParameter("@student_id",MySqlDbType.VarChar){ Value = dgv.Rows[e.RowIndex].Cells["Student ID"].Value },
                                new MySqlParameter("@year",MySqlDbType.Int32){ Value = dgv.Rows[e.RowIndex].Cells["Chosen Year"].Value },
                            });
                        if (delete_result > 0)
                        {
                            Common.ShowInfo("Done", "Delete successfully!");
                            choosing_clear_button.PerformClick();
                            choosing_query_button.PerformClick();
                        }
                    }
                }
            }
        }

        private void modify_course_info_link_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(course_info_tabPage);
        }

        private void teacher_query_button_Click(object sender, EventArgs e)
        {
            if (teacher_current_id_textBox.Text.Length == 0)
            {
                Common.ShowError("Null value error!", "ID can not be empty!");
                return;
            }
            teacher_current_id_textBox.ReadOnly = true;
            MySqlParameter teacher_id_parameter = new MySqlParameter("@id", MySqlDbType.VarChar) { Value = teacher_current_id_textBox.Text };
            DataTable current_info_dt = SQL_Help.ExecuteDataTable("select name from teacher_info where id=@id;", connection, new MySqlParameter[] { teacher_id_parameter });
            if (current_info_dt.Rows.Count == 0)
            {
                Common.ShowError("Empty query result!", "No corresponding teacher found with id = " + teacher_current_id_textBox.Text + ".\nPlease check again.");
                teacher_current_id_textBox.ReadOnly = false;
            }
            else
            {
                teacher_new_name_textBox.Text = teacher_current_name_textBox.Text = current_info_dt.Rows[0][0].ToString();
                teacher_new_id_textBox.Text = teacher_current_id_textBox.Text;
                teacher_new_info_groupBox.Enabled = true;
                teacher_apply_button.Enabled = true;
                teacher_delete_button.Enabled = true;
            }
            DataTable teach_course_dt = SQL_Help.ExecuteDataTable("select id,name from course_info where teacher_id=@id;", connection, new MySqlParameter[] { teacher_id_parameter });
            teacher_courses_textBox.Clear();
            for (int i = 0; i < teach_course_dt.Rows.Count; i++)
            {
                teacher_courses_textBox.Text += string.Format("{0},{1}"+Environment.NewLine, teach_course_dt.Rows[i][0].ToString(), teach_course_dt.Rows[i][1].ToString());
            }
        }

        private void teacher_clear_button_Click(object sender, EventArgs e)
        {
            teacher_current_name_textBox.Clear();
            teacher_current_id_textBox.Clear();
            teacher_courses_textBox.Clear();
            teacher_current_id_textBox.ReadOnly = false;
            teacher_new_info_groupBox.Enabled = false;
            teacher_new_name_textBox.Clear();
            teacher_new_id_textBox.Clear();
            teacher_apply_button.Enabled = false;
            teacher_delete_button.Enabled = false;

        }

        private void teacher_delete_button_Click(object sender, EventArgs e)
        {
            string delete_notice = ((teacher_courses_textBox.TextLength == 0) ? ""
                : "This teacher still have some course! \nIf continue, all the information about the courses that this teacher teach will be deleted!") + 
                string.Format("Are you sure to delete teacher ({0},{1})?", teacher_current_id_textBox.Text, teacher_current_name_textBox.Text);
            if (Common.ShowChoice("Delete Confirm", delete_notice, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MySqlParameter teacher_id_parameter = new MySqlParameter("@id", MySqlDbType.VarChar) { Value = teacher_current_id_textBox.Text };
                if (SQL_Help.ExecuteNonQuery("delete from teacher_info where id=@id;delete from course_info where teacher_id=@id;delete from user_data where username=@id;",
                    connection,new MySqlParameter[] { teacher_id_parameter }) > 0)
                {
                    Common.ShowInfo("Done", "Delete successfully!");
                    teacher_clear_button.PerformClick();
                }
            }
        }

        private void teacher_apply_button_Click(object sender, EventArgs e)
        {
            if (teacher_new_id_textBox.Text.Length == 0 || teacher_new_name_textBox.Text.Length == 0)
            {
                Common.ShowError("Format error!", "All the field should not be null! Please check again!");
                return;
            }
            if (!Regex.IsMatch(teacher_new_id_textBox.Text, @"^\d{5}$"))
            {
                Common.ShowError("Format checking error!", "ID format error! The length of teacher ID should be 5!");
                return;
            }
            if (teacher_new_name_textBox.TextLength == 0)
            {
                Common.ShowError("Format checking error!", "Name format error! Teacher name cannot be empty!");
                return;
            }
            MySqlParameter teacher_id_parameter = new MySqlParameter("@id", MySqlDbType.VarChar) { Value = teacher_current_id_textBox.Text };
            MySqlParameter teacher_new_id_parameter = new MySqlParameter("@new_id", MySqlDbType.VarChar) { Value = teacher_new_id_textBox.Text };
            int id_modify_result = SQL_Help.ExecuteNonQuery("update teacher_info set id=@new_id,name=@new_name where id=@id;", connection, new MySqlParameter[] 
            {
                teacher_id_parameter,
                teacher_new_id_parameter,
                new MySqlParameter("@new_name",MySqlDbType.VarChar) { Value = teacher_new_name_textBox.Text }
            });
            if (id_modify_result < 0) return;
            if (teacher_new_id_textBox.Text == teacher_current_id_textBox.Text)
            {
                Common.ShowInfo("Done!", "Modify successfully!");
                teacher_query_button.PerformClick();
                return;
            }
            int other_modify_result = SQL_Help.ExecuteNonQuery("update user_data set username=@new_id where username=@id;update course_info set teacher_id=@new_id where teacher_id=@id;", connection,
                new MySqlParameter[] { teacher_new_id_parameter,teacher_id_parameter });
            if (other_modify_result >= 0)
            {
                Common.ShowInfo("Done!", "Modify successfully!");
                teacher_current_id_textBox.Text = teacher_new_id_textBox.Text;
                teacher_query_button.PerformClick();
            }
        }

        private void choosing_student_id_textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                choosing_query_button.PerformClick();
        }
    }
}
