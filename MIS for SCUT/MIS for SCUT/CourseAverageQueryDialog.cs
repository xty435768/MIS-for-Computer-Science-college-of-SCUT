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
    public partial class CourseAverageQueryDialog : Form
    {
        public CourseAverageQueryDialog()
        {
            InitializeComponent();
        }
        public string course { get; set; }
        public string teacher { get; set; }
        public string year { get; set; }
        public MySqlConnection connection { get; set; }
        private void CourseAverageQueryDialog_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) ok_button.PerformClick();
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            if (course_comboBox.Text.Length == 0 || teacher_comboBox.Text.Length == 0 || year_comboBox.Text.Length == 0)
            {
                Common.ShowError("Null value Error", "You should ensure all these three attributes have valid value.\nIf the combo box of some attributes is empty, it means that there is no course information that meets the current conditions.\nPlease check and try again");
                return;
            }
            course = course_comboBox.Text;
            teacher = teacher_comboBox.Text;
            year = year_comboBox.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void course_comboBox_TextChanged(object sender, EventArgs e)
        {
            if (course_comboBox.Items.Contains(course_comboBox.Text))
            {
                teacher_comboBox.Items.Clear();
                year_comboBox.Items.Clear();
                DataTable teacher_dt = SQL_Help.ExecuteDataTable("select distinct course_info.teacher_id,teacher_info.name " +
                    "from course_info join teacher_info on (teacher_info.id=course_info.teacher_id) " +
                    "where course_info.id = @course_id;", connection, new MySqlParameter[]
                    {
                        new MySqlParameter("@course_id",MySqlDbType.VarChar){ Value = course_comboBox.Text.Substring(0,7) }
                    });
                for (int i = 0; i < teacher_dt.Rows.Count; i++)
                {
                    teacher_comboBox.Items.Add(string.Format("{0}({1})", teacher_dt.Rows[i][0], teacher_dt.Rows[i][1]));
                }
                if (teacher_dt.Rows.Count != 0) teacher_comboBox.Text = teacher_comboBox.Items[0].ToString();
            }
            else
            {
                teacher_comboBox.Items.Clear();
                year_comboBox.Items.Clear();
            }
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void CourseAverageQueryDialog_Load(object sender, EventArgs e)
        {
            DataTable course_dt = SQL_Help.ExecuteDataTable("select distinct id,name from course_info;", connection);
            for (int i = 0; i < course_dt.Rows.Count; i++)
            {
                course_comboBox.Items.Add(string.Format("{0}({1})", course_dt.Rows[i][0], course_dt.Rows[i][1]));
            }
            course_comboBox.Text = course_comboBox.Items[0].ToString();
        }

        private void teacher_comboBox_TextChanged(object sender, EventArgs e)
        {
            
            DataTable year_dt = SQL_Help.ExecuteDataTable("select distinct chosen_year " +
                "from course_choosing_info " +
                "where course_id = @cid and teacher_id = @tid;", connection, new MySqlParameter[]
                {
                        new MySqlParameter("@cid",MySqlDbType.VarChar){ Value = course_comboBox.Text.Substring(0,7) },
                        new MySqlParameter("@tid",MySqlDbType.VarChar){ Value = (year_comboBox.Items.Count == 0?teacher_comboBox.Items[0].ToString():teacher_comboBox.Text).Substring(0,5) }
                });
            year_comboBox.Items.Clear();
            for (int i = 0; i < year_dt.Rows.Count; i++)
            {
                year_comboBox.Items.Add(string.Format("{0}", year_dt.Rows[i][0]));
            }
            if(year_dt.Rows.Count!=0) year_comboBox.Text = year_comboBox.Items[0].ToString();
        }
    }
}
