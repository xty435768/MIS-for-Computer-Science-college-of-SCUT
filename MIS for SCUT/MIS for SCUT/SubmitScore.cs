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
    public partial class SubmitScore : Form
    {
        public SubmitScore(string id,string name)
        {
            InitializeComponent();
            current_teacher_id = id;
            current_teacher_name = name;
            show_teacher_id_label.Text = "Current teacher ID: " + id;
            show_teacher_name_label.Text = "Current teacher name: " + name;
        }
        public MySqlConnection connection { get; set; }
        string current_teacher_id;
        string current_teacher_name;
        List<string> course_list_items = new List<string>();
        DataTable course_score_dt;
        private void SubmitScore_Load(object sender, EventArgs e)
        {
            DataTable course_dt = SQL_Help.ExecuteDataTable("select id,name from course_info where teacher_id=@teacher_id;", connection, new MySqlParameter[]
            {
                new MySqlParameter("@teacher_id",MySqlDbType.VarChar){ Value = current_teacher_id }
            });
            for (int i = 0; i < course_dt.Rows.Count; i++)
            {
                string course_item = string.Format("{0}({1})", course_dt.Rows[i][0], course_dt.Rows[i][1]);
                course_list_items.Add(course_item);
                course_comboBox.Items.Add(course_item);
            }
        }

        private Dictionary<string, string> choosing_data_table_columns_name_mapping = new Dictionary<string, string>()
        {
            ["chosen_year"] = "Chosen Year",
            ["score"] = "Score",
            ["student_id"] = "Student ID",
            ["course_id"] = "Course ID",
            ["name"] = "Name",
            ["name1"] = "Course Name",
            ["credit"] = "Credit"
        };


        private void course_comboBox_TextChanged(object sender, EventArgs e)
        {
            
            bool index = course_list_items.Contains(course_comboBox.Text);
            if (index)
            {
                ClearDGV();
                RefreshYearData();
                RefreshDGV();
            }
            else
            {
                ClearDGV();
            }
        }
        private void ClearDGV(bool clear_year = true)
        {
            course_score_dt = new DataTable();
            dgv.DataSource = null;
            dgv.Columns.Clear();
            if(clear_year) year_comboBox.Items.Clear();
        }

        private void RefreshDGV()
        {
            course_score_dt = SQL_Help.ExecuteDataTable(
                "select distinct course_choosing_info.student_id,student_info.name,course_choosing_info.score,course_choosing_info.chosen_year,course_choosing_info.course_id,course_info.name,course_info.credit " +
                "from course_choosing_info join student_info join course_info " +
                "on (course_choosing_info.student_id=student_info.id and course_info.id=course_choosing_info.course_id) " +
                "where (course_choosing_info.course_id=@course_id and course_choosing_info.teacher_id=@teacher_id and course_choosing_info.chosen_year=@year);", connection, new MySqlParameter[]
                {
                        new MySqlParameter("@teacher_id",MySqlDbType.VarChar){ Value = current_teacher_id },
                        new MySqlParameter("@course_id",MySqlDbType.VarChar){ Value = course_comboBox.Text.Substring(0,7) },
                        new MySqlParameter("@year",MySqlDbType.Int32){ Value = year_comboBox.Text }
                });
            dgv.DataSource = new BindingSource() { DataSource = course_score_dt };
            for (int i = 0; i < course_score_dt.Columns.Count; i++)
            {
                dgv.Columns[i].HeaderText = choosing_data_table_columns_name_mapping[course_score_dt.Columns[i].Caption];
            }
            DataGridViewButtonColumn modify_btn = new DataGridViewButtonColumn();
            modify_btn.HeaderText = "Modify";
            modify_btn.Name = "modify";
            modify_btn.DefaultCellStyle.NullValue = "Modify";
            dgv.Columns.Add(modify_btn);
            dgv.Columns["modify"].DisplayIndex = 0;

        }

        private void RefreshYearData()
        {
            DataTable year_dt = SQL_Help.ExecuteDataTable("select distinct chosen_year from course_choosing_info where (teacher_id=@teacher_id and course_id=@course_id);", connection, new MySqlParameter[]
            {
                new MySqlParameter("@teacher_id",MySqlDbType.VarChar){ Value = current_teacher_id },
                new MySqlParameter("@course_id",MySqlDbType.VarChar){ Value = course_comboBox.Text.Substring(0,7) }
            });
            if (year_dt.Rows.Count == 0)
            {
                Common.ShowInfo("Empty query result!", "Currently there is no student in course " + course_comboBox.Text + "!");
                ClearDGV();
                return;
            }
            for (int i = 0; i < year_dt.Rows.Count; i++)
            {
                year_comboBox.Items.Add(year_dt.Rows[i][0]);
            }
            year_comboBox.Text = year_comboBox.Items[0].ToString();

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgv.Rows[e.RowIndex].Cells[e.ColumnIndex] is DataGridViewButtonCell)
            {
                if (dgv.Columns[e.ColumnIndex].DefaultCellStyle.NullValue.ToString() == "Modify")
                {
                    if (dgv.Columns[e.ColumnIndex].DefaultCellStyle.NullValue.ToString() == "Modify")
                    {
                        using (ChoosingInfoModify cim = new ChoosingInfoModify()
                        {
                            connection = connection,
                            year = dgv.Rows[e.RowIndex].Cells["chosen_year"].Value.ToString(),
                            score = dgv.Rows[e.RowIndex].Cells["score"].Value.ToString(),
                            student = string.Format("{0}({1})", dgv.Rows[e.RowIndex].Cells["student_id"].Value, dgv.Rows[e.RowIndex].Cells["name"].Value),
                            teacher = string.Format("{0}({1})", current_teacher_id, current_teacher_name),
                            course = string.Format("{0}({1})", dgv.Rows[e.RowIndex].Cells["course_id"].Value, dgv.Rows[e.RowIndex].Cells["name1"].Value),
                            credit = dgv.Rows[e.RowIndex].Cells["credit"].Value.ToString(),
                            role = Common.UserType.TEACHER
                        })
                        {
                            cim.ShowDialog();
                            ClearDGV();
                            RefreshYearData();
                            RefreshDGV();
                        }
                    }

                }
            }
        }

        private void year_comboBox_TextChanged(object sender, EventArgs e)
        {
            if (dgv.DataSource == null) return;
            ClearDGV(false);
            RefreshDGV();
        }
    }
}
