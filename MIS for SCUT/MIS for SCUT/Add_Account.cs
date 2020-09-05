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
using System.IO;
using System.Threading;

namespace MIS_for_SCUT
{
    public partial class Add_Account : Form
    {
        public Add_Account()
        {
            InitializeComponent();
        }
        public Common.UserType role { get; set; }
        public MySqlConnection connection { get; set; }
        public DataTable dt;
        private void student_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(!student_radioButton.Checked)
            {
                sex_label.Visible = false;
                age_label.Visible = false;
                year_label.Visible = false;
                class_label.Visible = false;
                sex_comboBox.Visible = false;
                age_textbox.Visible = false;
                year_textbox.Visible = false;
                class_textBox.Visible = false;
            }
            else
            {
                sex_label.Visible = true;
                age_label.Visible = true;
                year_label.Visible = true;
                class_label.Visible = true;
                sex_comboBox.Visible = true;
                age_textbox.Visible = true;
                year_textbox.Visible = true;
                class_textBox.Visible = true;

            }
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            if (student_radioButton.Checked)
            {
                if(id_textbox.Text.Length == 0 || name_textbox.Text.Length == 0 ||
                   sex_comboBox.Text.Length == 0 || age_textbox.Text.Length == 0||
                   year_textbox.Text.Length == 0||class_textBox.Text.Length == 0)
                {
                    Common.ShowError("Format error!","All the field should not be null! Please check again!");
                    return;
                }
                if(!Regex.IsMatch(id_textbox.Text,@"^\d{10}$"))
                {
                    Common.ShowError("Format checking error!", "ID format error! The length of student ID should be 10!");
                    return;
                }
                if (!Regex.IsMatch(age_textbox.Text, @"^\d{2}$") && int.Parse(age_textbox.Text) >= 10 && int.Parse(age_textbox.Text) <= 50)
                {
                    Common.ShowError("Format checking error!", "Entrance age format error! It should between 10 and 50!");
                    return;
                }
                if (!Regex.IsMatch(year_textbox.Text, @"^\d{4}$"))
                {
                    Common.ShowError("Format error!", "Entrance year format error! \nPlease chech again!");
                    return;
                }
                int add_result = SQL_Help.ExecuteNonQuery("insert into user_data (username,authority) values(@1,0);" +
                                         "insert into student_info values(@1,@2,@3,@4,@5,@6);",connection,new MySqlParameter[]
                                         { new MySqlParameter("@1",MySqlDbType.VarChar){ Value = id_textbox.Text }, new MySqlParameter("@2",MySqlDbType.VarChar){Value = name_textbox.Text },
                                           new MySqlParameter("@3",MySqlDbType.VarChar){ Value = sex_comboBox.Text },new MySqlParameter("@4",MySqlDbType.Int32){ Value = age_textbox.Text },
                                           new MySqlParameter("@5",MySqlDbType.Int32) { Value = year_textbox.Text } ,new MySqlParameter("@6",MySqlDbType.VarChar){ Value = class_textBox.Text } });
                if (add_result >= 0)
                {
                    Common.ShowInfo("Done", "Add successful!");
                }
            }
            else
            {
                if (id_textbox.Text.Length == 0 || name_textbox.Text.Length == 0)
                {
                    Common.ShowError("Add error!", "All the field should not be null! Please check again!");
                    return;
                }
                if (!Regex.IsMatch(id_textbox.Text, @"^\d{5}$"))
                {
                    Common.ShowError("Format checking error!", "ID format error! The length of teacher ID should be 5!");
                    return;
                }
                int add_result = SQL_Help.ExecuteNonQuery("insert into user_data (username,authority) values(@1,1);" +
                                         "insert into teacher_info (id,name) values(@1,@2);", connection, new MySqlParameter[]
                                         { new MySqlParameter("@1",MySqlDbType.VarChar){ Value = id_textbox.Text }, new MySqlParameter("@2",MySqlDbType.VarChar){Value = name_textbox.Text } });
                if (add_result >= 0)
                {
                    Common.ShowInfo("Done", "Add successful!");
                }
            }
        }

        private void save_template_Click(object sender, EventArgs e)
        {
            string path = Common.GetSaveFilePath("CSV File(*.csv)|*.csv");
            if (path == null) return;
            //System.Diagnostics.Debug.Write(path + "\n");
            File.WriteAllText(path, "Student id,Student Name,Sex(Male or Female),Entrance age,Entrance year,Class", Encoding.Default);
            Common.ShowInfo("Template Saved!", "The template was saved successfully. \nPlease add information to the file according to the template format. ");
        }

        private void open_csv_Click(object sender, EventArgs e)
        {
            string path = Common.GetOpenFilePath("CSV File(*.csv)|*.csv");
            if (path == null) return;
            dt = Common.ReadCSV(path);
            if (dt == null) return;
            dt.Rows.RemoveAt(0);
            dt.Columns.Add("State").SetOrdinal(0);
            BindingSource bs = new BindingSource();
            bs.DataSource = dt;
            dgv.DataSource = bs;
            string[] head_texts = { "ID", "Name", "Sex", "Entrance age", "Entrance year", "Class" };
            string[] column_names = { "id", "name", "sex", "age", "year", "classname" };
            for (int i = 1; i < dgv.Columns.Count; i++)
            {
                dgv.Columns[i].HeaderText = head_texts[i-1];
                dgv.Columns[i].Name = column_names[i-1];
            }
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                dgv.Rows[i].Cells["state"].Style.ForeColor = Color.Goldenrod;
                dt.Rows[i]["state"] = "Ready";
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

        private void batch_add_button_Click(object sender, EventArgs e)
        {
            if (dt == null)
            {
                Common.ShowError("Null Table Error", "You should import non-empty CSV file first!");
                return;
            }
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                dgv.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            progressBar1.Maximum = dgv.Columns.Count;
            progressBar1.Value = 0;
            save_template.Enabled = false;
            open_csv.Enabled = false;
            add_button.Enabled = false;
            batch_add_button.Enabled = false;
            progressBar1.Maximum = dgv.Rows.Count;
            new Thread(batch_add_process) { IsBackground = true }.Start();
        }

        private void batch_add_process()
        {
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                bool format_check = true;
                int add_result;
                if (!Regex.IsMatch(dgv.Rows[i].Cells["id"].Value.ToString(), @"^\d{10}$"))
                {
                    Common.ShowError("Format checking error!", "ID format error! The length of student ID should be 10!\nID: " + dgv.Rows[i].Cells["id"].Value);
                    format_check = false;
                }
                if (!Regex.IsMatch(dgv.Rows[i].Cells["age"].Value.ToString(), @"^\d{2}$") && int.Parse(dgv.Rows[i].Cells["age"].Value.ToString()) >= 10 && int.Parse(dgv.Rows[i].Cells["age"].Value.ToString()) <= 50)
                {
                    Common.ShowError("Format checking error!", "Entrance age format error! It should between 10 and 50!\nID: "+ dgv.Rows[i].Cells["id"].Value);
                    format_check = false;
                }
                if (dgv.Rows[i].Cells["sex"].Value.ToString() != "Male" && dgv.Rows[i].Cells["sex"].Value.ToString() != "Female")
                {
                    Common.ShowError("Format checking error!", "Sex format error! It should be either \"Male\" or \"Female\"!\nID: " + dgv.Rows[i].Cells["id"].Value);
                    format_check = false;
                }
                if (!Regex.IsMatch(dgv.Rows[i].Cells["year"].Value.ToString(), @"^\d{4}$"))
                {
                    Common.ShowError("Format error!", "Entrance year format error! \nPlease chech again!");
                    format_check = false;
                }
                if (format_check)
                    add_result = SQL_Help.ExecuteNonQuery("insert into user_data (username,authority) values(@1,0);" +
                             "insert into student_info values(@1,@2,@3,@4,@5,@6);", connection, new MySqlParameter[]
                             { new MySqlParameter("@1",MySqlDbType.VarChar){ Value = dgv.Rows[i].Cells["id"].Value },
                               new MySqlParameter("@2",MySqlDbType.VarChar){ Value = dgv.Rows[i].Cells["name"].Value },
                               new MySqlParameter("@3",MySqlDbType.VarChar){ Value = dgv.Rows[i].Cells["sex"].Value },
                               new MySqlParameter("@4",MySqlDbType.Int32){ Value = dgv.Rows[i].Cells["age"].Value },
                               new MySqlParameter("@5",MySqlDbType.Int32) { Value = dgv.Rows[i].Cells["year"].Value } ,
                               new MySqlParameter("@6",MySqlDbType.VarChar){ Value = dgv.Rows[i].Cells["classname"].Value } });
                else add_result = -1;
                if(add_result > 0)
                {
                    SetAddProgress(i, "Done");
                }
                else
                {
                    SetAddProgress(i, "Failed");
                }
            }
        }

        private delegate void SetAddProgressDelegate(int i, string v);

        private void SetAddProgress(int i, string v)
        {
            if (InvokeRequired) Invoke(new SetAddProgressDelegate(SetAddProgress), i, v);
            else
            {
                dt.Rows[i]["state"] = v;
                if (progressBar1.Value < progressBar1.Maximum) progressBar1.Value++;
                progress_label.Text = (progressBar1.Value * 100 / progressBar1.Maximum).ToString() + "%";
                if (progressBar1.Value == progressBar1.Maximum)
                {
                    progress_label.Text = "Done!";
                    save_template.Enabled = true;
                    open_csv.Enabled = true;
                    add_button.Enabled = true;
                    batch_add_button.Enabled = true;
                    for (int j = 0; j < dgv.Columns.Count; j++)
                    {
                        dgv.Columns[j].SortMode = DataGridViewColumnSortMode.Automatic;
                    }
                }
            }
        }
    }
}
