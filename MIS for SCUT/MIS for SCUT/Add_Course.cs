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
    public partial class Add_Course : Form
    {
        public Add_Course()
        {
            InitializeComponent();
            grade_limit.Add("Freshman", 1);
            grade_limit.Add("Sophomore", 2);
            grade_limit.Add("Junior", 3);
            grade_limit.Add("Senior", 4);
        }
        public MySqlConnection connection { set; get; }
        public Dictionary<string, int> grade_limit = new Dictionary<string, int>();
        public List<string> teacher_list = new List<string>();
        private void Add_Course_Load(object sender, EventArgs e)
        {
            DataTable teacher_dt = SQL_Help.ExecuteDataTable("select id,name from teacher_info;", connection);
            for (int i = 0; i < teacher_dt.Rows.Count; i++)
            {
                string comboBox_item = teacher_dt.Rows[i][0] + "(" + teacher_dt.Rows[i][1] + ")";
                teacher_id_ComboBox.Items.Add(comboBox_item);
                
                teacher_list.Add(comboBox_item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(course_id_textBox.Text.Length == 0 || course_name_textBox.Text.Length == 0 ||
                teacher_id_ComboBox.Text.Length == 0||credit_textBox.Text.Length == 0||
                grade_comboBox.Text.Length == 0)
            {
                Common.ShowError("Null Value Error", "Please ensure that the first five fields are not null!");
                return;
            }
            if(!Regex.IsMatch(course_id_textBox.Text, @"^\d{7}$"))
            {
                Common.ShowError("Format error!", "ID format error! \nThe length of course ID should be 7!");
                return;
            }
            if(!teacher_list.Contains(teacher_id_ComboBox.Text))
            {
                Common.ShowError("Format error!", "Teacher ID format error! \nPlease select the correct item from the teacher combo list!");
                return;
            }
            if(!Regex.IsMatch(credit_textBox.Text, @"^(([1-9]{1}\d*)|([0]{1}))(\.(\d)?)?$"))
            {
                Common.ShowError("Format error!", "Credit format error! \nThe credit should be integer or one place decimal!");
                return;
            }
            if(cancel_year_textBox.Text.Length!=0&& !Regex.IsMatch(cancel_year_textBox.Text, @"^\d{4}$"))
            {
                Common.ShowError("Format error!", "Canceled year format error! \nPlease chech again!");
                return;
            }
            string teacher_current_courses;
            string current_teacher_id = teacher_id_ComboBox.Text.Substring(0, 5);
            DataTable dt_tcc = SQL_Help.ExecuteDataTable("select courses from teacher_info where id=@tid;", connection, new MySqlParameter[] { new MySqlParameter("@tid", current_teacher_id) });
            teacher_current_courses = dt_tcc.Rows[0][0].ToString();
            MySqlParameter year_parameter = new MySqlParameter("@year", MySqlDbType.Int32);
            if(cancel_year_textBox.Text.Length == 0)
            {
                year_parameter.Value = DBNull.Value;
            }
            else
            {
                year_parameter.Value = cancel_year_textBox.Text;
            }
            if (SQL_Help.ExecuteNonQuery
                ("insert into course_info values (@id,@name,@teacher,@credit,@grade,@year); " +
                 "update teacher_info set courses = @new_course where id = @teacher;",connection,new MySqlParameter[]
                 { new MySqlParameter("@id",MySqlDbType.VarChar){ Value = course_id_textBox.Text},
                   new MySqlParameter("@name",MySqlDbType.VarChar){ Value = course_name_textBox.Text},
                   new MySqlParameter("@teacher",MySqlDbType.VarChar){ Value = current_teacher_id},
                   new MySqlParameter("@credit",MySqlDbType.Double){ Value = credit_textBox.Text},
                   new MySqlParameter("@grade",MySqlDbType.Int32){ Value = grade_limit[grade_comboBox.Text]},
                   year_parameter,
                   new MySqlParameter("@new_course",MySqlDbType.VarChar){ Value = teacher_current_courses+(teacher_current_courses.Length == 0?"":",")+course_name_textBox.Text }
                 }) > 0)
            {
                Common.ShowInfo("Done", "Add successful!");
            }
        }
    }
}
