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
using MySql.Data.MySqlClient;

namespace MIS_for_SCUT
{
    public partial class CourseAddProcess : Form
    {
        public CourseAddProcess(string course,string teacher,ListBox.ObjectCollection students,string year)
        {
            InitializeComponent();
            this.course = course;
            this.teacher = teacher;
            this.students = students;
            this.year = year;
            students_dt.Columns.Add("state");
            students_dt.Columns.Add("student");
            students_dt.Columns.Add("teacher");
            students_dt.Columns.Add("course");
            students_dt.Columns.Add("year");
        }
        public MySqlConnection connection { get; set; }
        public string course;
        public string teacher;
        public string year;
        public ListBox.ObjectCollection students;
        public DataTable students_dt = new DataTable();
        public string grade_limit;
        public string cancel_limit;
        private void CourseAddProcess_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < students.Count; i++)
            {
                DataRow dr = students_dt.NewRow();
                dr["state"] = "Ready";
                dr["student"] = students[i].ToString();
                dr["teacher"] = teacher;
                dr["course"] = course;
                dr["year"] = year;
                students_dt.Rows.Add(dr);
            }
            
            BindingSource bs = new BindingSource();
            bs.DataSource = students_dt;
            dgv.DataSource = bs;
            dgv.Font = new Font("微软雅黑", 10.8F);
            string[] head_texts = { "Student Info", "Teacher Info", "Course Info", "Chosen year"};
            string[] column_names = { "student", "teacher", "course", "year"};
            for (int i = 1; i < dgv.Columns.Count; i++)
            {
                dgv.Columns[i].HeaderText = head_texts[i - 1];
                dgv.Columns[i].Name = column_names[i - 1];
                dgv.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            //for (int i = 0; i < dgv.Rows.Count; i++)
            //{
            //    dgv.Rows[i].Cells["state"].Style.ForeColor = Color.Goldenrod;
            //    students_dt.Rows[i]["state"] = "Ready";
            //}
            DataTable course_limit = SQL_Help.ExecuteDataTable("select grade_limit,canceled_year from course_info where id=@id", connection, new MySqlParameter[] { new MySqlParameter("@id", MySqlDbType.VarChar) { Value = course.Substring(0, 7) } });
            grade_limit = course_limit.Rows[0][0].ToString();
            cancel_limit = course_limit.Rows[0][1].ToString();
            if (DateTime.Now.Month <= 8)
            {
                school_year_label.Text = "School year: " + (DateTime.Now.Year - 1) + "-" + DateTime.Now.Year;
                if (DateTime.Now.Month <= 2) semester_label.Text = "Semester: 1";
                else semester_label.Text = "Semester: 2";
            }
            else
            {
                school_year_label.Text = "School year: " + DateTime.Now.Year + "-" + (DateTime.Now.Year + 1);
                semester_label.Text = "Semester: 1";
            }
            
        }
        private void ResetColor()
        {
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                dgv.Rows[i].Cells["state"].Style.ForeColor = Common.GetColor(dgv.Rows[i].Cells["state"].Value.ToString());
            }
        }

        private void dgv_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ResetColor();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                dgv.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            progressBar1.Maximum = dgv.Columns.Count;
            progressBar1.Value = 0;
            add_button.Enabled = false;
            new Thread(add_process) { IsBackground = true }.Start();
        }

        private void add_process()
        {
            int add_result;
            int year_lower_bound = Convert.ToInt32(grade_limit) - 1;
            int year_upper_bound = (cancel_limit == "") ? int.MaxValue : Convert.ToInt32(cancel_limit);
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                DataTable entry_year_dt = SQL_Help.ExecuteDataTable("select entrance_year from student_info where id=@id;", connection, new MySqlParameter[] { new MySqlParameter("@id", MySqlDbType.VarChar) { Value = students[i].ToString().Substring(0, 10) } });
                int entry_year = Convert.ToInt32(entry_year_dt.Rows[0][0]);
                bool lower_bound_satisfied = Convert.ToInt32(school_year_label.Text.Substring(school_year_label.Text.Length - 9, 4)) - entry_year >= year_lower_bound;
                bool upper_bound_satisfied = Convert.ToInt32(year) <= year_upper_bound;
                if (!lower_bound_satisfied || !upper_bound_satisfied)
                {
                    string error_msg = "Students: " + students[i] + ":";
                    error_msg += (lower_bound_satisfied ? "" : "\nThis course is only available for students whose grade is larger than " + grade_limit + ".")
                        + (upper_bound_satisfied ? "" : "\nThis course is only available before " + cancel_limit + ".");
                    Common.ShowError("Time error!", error_msg);
                    add_result = -1;
                }
                else
                {
                    add_result = SQL_Help.ExecuteNonQuery("insert into course_choosing_info (student_id,teacher_id,course_id,chosen_year) values(@1,@2,@3,@4);", connection, new MySqlParameter[]
                             { new MySqlParameter("@1",MySqlDbType.VarChar){ Value = dgv.Rows[i].Cells["student"].Value.ToString().Substring(0,10) },
                               new MySqlParameter("@2",MySqlDbType.VarChar){ Value = dgv.Rows[i].Cells["teacher"].Value.ToString().Substring(0,5) },
                               new MySqlParameter("@3",MySqlDbType.VarChar){ Value = dgv.Rows[i].Cells["course"].Value.ToString().Substring(0,7) },
                               new MySqlParameter("@4",MySqlDbType.Int32){ Value = dgv.Rows[i].Cells["year"].Value.ToString() } });
                }
                SetAddProgress(i, add_result > 0 ? "Done" : "Failed");
            }
        }

        private delegate void SetAddProgressDelegate(int i, string v);

        private void SetAddProgress(int i, string v)
        {
            if (InvokeRequired) Invoke(new SetAddProgressDelegate(SetAddProgress), i, v);
            else
            {
                students_dt.Rows[i]["state"] = v;
                if (progressBar1.Value < progressBar1.Maximum) progressBar1.Value++;
                progress_label.Text = (progressBar1.Value * 100 / progressBar1.Maximum).ToString() + "%";
                if (progressBar1.Value == progressBar1.Maximum)
                {
                    progress_label.Text = "Done!";
                    add_button.Enabled = true;
                    for (int j = 0; j < dgv.Columns.Count; j++)
                    {
                        dgv.Columns[j].SortMode = DataGridViewColumnSortMode.Automatic;
                    }
                }
            }
        }

    }
}
