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
    public partial class ChoosingInfoModify : Form
    {
        public ChoosingInfoModify()
        {
            InitializeComponent();
        }
        public MySqlConnection connection { get; set; }
        public string student { get; set; }
        public string teacher { get; set; }
        public string course { get; set; }
        public string credit { get; set; }
        public string year { get; set; }
        public string score { get; set; }
        public Common.UserType role { get; set; }
        public List<string> course_items = new List<string>();
        
        private void ChoosingInfoModify_Load(object sender, EventArgs e)
        {
            DataTable course_dt = SQL_Help.ExecuteDataTable("select distinct id,name from course_info;", connection);
            for (int i = 0; i < course_dt.Rows.Count; i++)
            {
                string course_item = string.Format("{0}({1})", course_dt.Rows[i][0], course_dt.Rows[i][1]);
                choosing_new_course_ComboBox.Items.Add(course_item);
                course_items.Add(course_item);
            }
            choosing_new_id_textBox.Text = choosing_current_id_textBox.Text = student;
            choosing_current_teacher_textBox.Text = teacher;
            choosing_new_course_ComboBox.Text = choosing_current_course_textBox.Text = course;
            choosing_new_credit_textBox.Text = choosing_current_credit_textBox.Text = credit;
            choosing_new_score_textBox.Text = choosing_current_score_textBox.Text = score;
            choosing_new_year_textBox.Text = choosing_current_year_textBox.Text = year;
            switch (role)
            {
                case Common.UserType.STUDENT:
                    Enabled = false;
                    break;
                case Common.UserType.TEACHER:
                    choosing_new_score_textBox.ReadOnly = false;
                    choosing_new_course_ComboBox.Enabled = false;
                    choosing_new_teacher_comboBox.Enabled = false;
                    choosing_new_year_textBox.ReadOnly = true;
                    break;
                case Common.UserType.ADMIN:
                    break;
                default:
                    break;
            }
        }

        private void choosing_new_course_ComboBox_TextChanged(object sender, EventArgs e)
        {
            choosing_new_teacher_comboBox.Items.Clear();
            bool index = course_items.Contains(choosing_new_course_ComboBox.Text);
            if (index)
            {
                DataTable teacher_dt = SQL_Help.ExecuteDataTable("select teacher_info.id,teacher_info.name,course_info.credit from teacher_info join course_info on (teacher_info.id=course_info.teacher_id) where course_info.id=@id;",
                    connection, new MySqlParameter[] { new MySqlParameter("@id", MySqlDbType.VarChar) { Value = choosing_new_course_ComboBox.Text.Substring(0,7) } });
                for (int i = 0; i < teacher_dt.Rows.Count; i++)
                {
                    choosing_new_teacher_comboBox.Items.Add(string.Format("{0}({1})", teacher_dt.Rows[i][0], teacher_dt.Rows[i][1]));
                }
                choosing_new_teacher_comboBox.Text = choosing_new_teacher_comboBox.Items[0].ToString();
                choosing_new_credit_textBox.Text = teacher_dt.Rows[0][2].ToString();
            }
            else
            {
                choosing_new_teacher_comboBox.Items.Clear();
            }
        }

        private void apply_button_Click(object sender, EventArgs e)
        {
            if (choosing_new_year_textBox.Text.Length != 0 && !Regex.IsMatch(choosing_new_year_textBox.Text, @"^\d{4}$"))
            {
                Common.ShowError("Format error!", "Chosen year format error! \nPlease chech again!");
                return;
            }
            bool confirm = true;
            if (choosing_current_credit_textBox.Text != choosing_new_credit_textBox.Text)
                confirm = Common.ShowChoice("Modify confirm","The credits of the two courses are inconsistent! Continue?",MessageBoxIcon.Warning) == DialogResult.Yes;
            if(confirm)
            {
                MySqlParameter score_parameter = new MySqlParameter("@score", MySqlDbType.Int32) { Value = DBNull.Value };
                if (choosing_new_score_textBox.Text.Length != 0)
                {
                    if (!Regex.IsMatch(choosing_new_score_textBox.Text, @"^\d*$") && int.Parse(choosing_new_score_textBox.Text) >= 0 && int.Parse(choosing_new_score_textBox.Text) <= 100)
                    {
                        Common.ShowError("Score format error!", "Course score should be integer between 0 and 100! Please check again!");
                        return;
                    }
                    else
                    {
                        score_parameter.Value = choosing_new_score_textBox.Text;
                    }
                }
                int update_result = SQL_Help.ExecuteNonQuery("update course_choosing_info set teacher_id=@new_teacher_id,course_id=@new_course_id,chosen_year=@new_year,score=@score " +
                    "where (student_id=@student_id and teacher_id=@old_teacher_id and course_id=@old_course_id and chosen_year=@old_year);", connection, new MySqlParameter[]
                {
                    new MySqlParameter("@new_teacher_id",MySqlDbType.VarChar){ Value = choosing_new_teacher_comboBox.Text.Substring(0,5) },
                    new MySqlParameter("@new_course_id",MySqlDbType.VarChar){ Value = choosing_new_course_ComboBox.Text.Substring(0,7) },
                    new MySqlParameter("@new_year",MySqlDbType.Int32){ Value = choosing_new_year_textBox.Text },
                    new MySqlParameter("@student_id",MySqlDbType.VarChar){ Value = choosing_new_id_textBox.Text.Substring(0,10) },
                    new MySqlParameter("@old_teacher_id",MySqlDbType.VarChar){ Value = choosing_current_teacher_textBox.Text.Substring(0,5) },
                    new MySqlParameter("@old_course_id",MySqlDbType.VarChar){ Value = choosing_current_course_textBox.Text.Substring(0,7) },
                    new MySqlParameter("@old_year",MySqlDbType.Int32){ Value = choosing_current_year_textBox.Text },
                    score_parameter,
                });
                if (update_result > 0)
                {
                    Common.ShowInfo("Done!", "Modify successfully!");
                    Close();
                }
            }
        }
    }
}
