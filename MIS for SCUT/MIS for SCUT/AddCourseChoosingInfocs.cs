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
    public partial class AddCourseChoosingInfo : Form
    {
        public AddCourseChoosingInfo()
        {
            InitializeComponent();
        }
        public MySqlConnection connection { set; get; }
        bool year_textbox_has_real_text = false;
        bool id_textbox_has_real_text = false;
        List<string> course_combobox_items = new List<string>();
        List<string> class_combobox_items = new List<string>();
        List<string> all_student_items = new List<string>();
        DataTable course_dt = new DataTable();
        DataTable class_dt = new DataTable();
        private void year_textBox_Enter(object sender, EventArgs e)
        {
            if (!year_textbox_has_real_text) year_textBox.Clear();
            year_textBox.ForeColor = Color.Black;
        }

        private void year_textBox_Leave(object sender, EventArgs e)
        {
            if (year_textBox.Text.Length == 0)
            {
                ((TextBox)sender).Text = "Input chosen year here...";
                ((TextBox)sender).ForeColor = Color.Gray;
                year_textbox_has_real_text = false;
            }
            else year_textbox_has_real_text = true;
        }


        private void AddCourseChoosingInfo_Load(object sender, EventArgs e)
        {
            year_textBox.Text = "Input chosen year here...";
            year_textBox.ForeColor = Color.Gray;
            student_id_ComboBox.Text = "Input student id here to add single student...";
            student_id_ComboBox.ForeColor = Color.Gray;
            course_dt = SQL_Help.ExecuteDataTable("select id,name,teacher_id from course_info;", connection);
            for (int i = 0; i < course_dt.Rows.Count; i++)
            {
                string comboBox_item = course_dt.Rows[i][0] + "(" + course_dt.Rows[i][1] + ")";
                course_id_ComboBox.Items.Add(comboBox_item);
                course_combobox_items.Add(comboBox_item);
            }
            class_dt = SQL_Help.ExecuteDataTable("select distinct class from student_info;", connection);
            for (int i = 0; i < class_dt.Rows.Count; i++)
            {
                string comboBox_item = class_dt.Rows[i][0].ToString();
                class_ComboBox.Items.Add(comboBox_item);
                class_combobox_items.Add(comboBox_item);
            }
            class_ComboBox.Items.Add("All class...");
            DataTable student_dt = SQL_Help.ExecuteDataTable("select id,name,class from student_info;", connection);
            for (int i = 0; i < student_dt.Rows.Count; i++)
            {
                string comboBox_item = student_dt.Rows[i][0] + "(" + student_dt.Rows[i][1] + "," + student_dt.Rows[i][2] + ")";
                all_student_items.Add(comboBox_item);
                student_id_ComboBox.Items.Add(comboBox_item);
            }
        }

        private void course_id_ComboBox_TextChanged(object sender, EventArgs e)
        {
            int index = course_combobox_items.IndexOf(course_id_ComboBox.Text);
            if (index != -1)
            {
                DataTable teacher_dt = SQL_Help.ExecuteDataTable("select name from teacher_info where id = @id;", connection,new MySqlParameter[] { new MySqlParameter("@id", MySqlDbType.VarChar) { Value = course_dt.Rows[index][2]} });
                teacher_id_textBox.Text = course_dt.Rows[index][2] + "("+ teacher_dt.Rows[0][0].ToString()+")";
            }
            else
            {
                teacher_id_textBox.Text = "No corresponding teacher found.";
            }
        }

        private void class_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            alternative_listBox.Items.Clear();
            if(class_ComboBox.Text == "All class...")
            {
                for (int i = 0; i < all_student_items.Count; i++)
                {
                    alternative_listBox.Items.Add(all_student_items[i]);
                }
                return;
            }
            int index = class_combobox_items.IndexOf(class_ComboBox.Text);
            if (index != -1)
            {
                DataTable student_dt = SQL_Help.ExecuteDataTable("select id,name,class from student_info where class = @classname",connection,new MySqlParameter[] { new MySqlParameter("@classname", MySqlDbType.VarChar) { Value = class_ComboBox.Text } });
                for (int i = 0; i < student_dt.Rows.Count; i++)
                {
                    alternative_listBox.Items.Add(student_dt.Rows[i][0] + "(" + student_dt.Rows[i][1] + "," + student_dt.Rows[i][2] + ")");
                }
            }
            else
            {
                alternative_listBox.Items.Clear();
            }
        }

        private void alternative_listBox_MouseClick(object sender, MouseEventArgs e)
        {
            add_to_chosen_button.Enabled = alternative_listBox.SelectedItems.Count > 0;
        }

        private void chosen_listBox_MouseClick(object sender, MouseEventArgs e)
        {
            remove_button.Enabled = chosen_listBox.SelectedItems.Count > 0;
        }

        private void add_to_chosen_button_Click(object sender, EventArgs e)
        {
            if (chosen_listBox.Items.Contains(alternative_listBox.SelectedItem))
            {
                Common.ShowError("Operation error!", "Item "+ alternative_listBox.SelectedItem + " has already existed in chosen set!");
                return;
            }
            chosen_listBox.Items.Add(alternative_listBox.SelectedItem);
            if(alternative_listBox.SelectedIndex != alternative_listBox.Items.Count - 1)
            {
                alternative_listBox.SelectedIndex++;
            }
            else
            {
                alternative_listBox.SelectedIndex = alternative_listBox.Items.Count - 1;
            }
            add_to_chosen_button.Enabled = alternative_listBox.Items.Count != 0;
        }

        private void remove_button_Click(object sender, EventArgs e)
        {
            int current_selected = chosen_listBox.SelectedIndex;
            chosen_listBox.Items.RemoveAt(chosen_listBox.SelectedIndex);
            if(current_selected == chosen_listBox.Items.Count)
            {
                chosen_listBox.SelectedIndex = chosen_listBox.Items.Count - 1;
            }
            else
            {
                chosen_listBox.SelectedIndex = current_selected;
            }
            remove_button.Enabled = chosen_listBox.Items.Count != 0;
        }

        private void add_all_button_Click(object sender, EventArgs e)
        {
            if(alternative_listBox.Items.Count == 0)
            {
                Common.ShowError("Operation error!", "No items in alternative list!");
                return;
            }
            for (int i = 0; i < alternative_listBox.Items.Count; i++)
            {
                if (chosen_listBox.Items.Contains(alternative_listBox.Items[i])) continue;
                chosen_listBox.Items.Add(alternative_listBox.Items[i]);
            }
        }

        private void delete_all_button_Click(object sender, EventArgs e)
        {
            chosen_listBox.Items.Clear();
        }

        private void student_id_ComboBox_Enter(object sender, EventArgs e)
        {
            if (!id_textbox_has_real_text) student_id_ComboBox.Text = "";
            student_id_ComboBox.ForeColor = Color.Black;
        }

        private void student_id_ComboBox_Leave(object sender, EventArgs e)
        {
            if (student_id_ComboBox.Text.Length == 0)
            {
                student_id_ComboBox.Text = "Input student id here to add single student...";
                student_id_ComboBox.ForeColor = Color.Gray;
                id_textbox_has_real_text = false;
            }
            else id_textbox_has_real_text = true;
        }

        private void add_single_button_Click(object sender, EventArgs e)
        {
            if(!student_id_ComboBox.Items.Contains(student_id_ComboBox.Text))
            {
                Common.ShowError("Format error!", "You should choose correct student info!");
                return;
            }
            if(chosen_listBox.Items.Contains(student_id_ComboBox.Text))
            {
                Common.ShowError("Operation error!", "Item " + student_id_ComboBox.Text + " has already existed in chosen set!");
                return;
            }
            chosen_listBox.Items.Add(student_id_ComboBox.Text);
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            if(!course_id_ComboBox.Items.Contains(course_id_ComboBox.Text))
            {
                Common.ShowError("Format error!", "Course format error! \nPlease choose correct course from list!");
                return;
            }
            if(chosen_listBox.Items.Count == 0)
            {
                Common.ShowError("Format error!", "No student has been chosen to take this course! \nPlease add students from candidates list!");
                return;
            }
            if(!year_textbox_has_real_text||!Regex.IsMatch(year_textBox.Text, @"^\d{4}$"))
            {
                Common.ShowError("Format error!", "Chosen year format error! \nPlease chech again!");
                return;
            }
            using (CourseAddProcess cap = new CourseAddProcess(course_id_ComboBox.Text, teacher_id_textBox.Text, chosen_listBox.Items, year_textBox.Text) { connection = connection })
            {
                cap.ShowDialog();
            }
        }
    }
}
