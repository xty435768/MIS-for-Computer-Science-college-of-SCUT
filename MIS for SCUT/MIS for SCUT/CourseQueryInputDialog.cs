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
    public partial class CourseQueryInputDialog : Form
    {
        public CourseQueryInputDialog()
        {
            InitializeComponent();
        }
        public string result {get;set;}
        private void ok_button_Click(object sender, EventArgs e)
        {
            result = textBox1.Text;
            DialogResult = DialogResult.OK;
            Close();
        }
        public bool GetTeacherRadioButtonChecked()
        {
            return teacher_radioButton.Checked;
        }
        private void cancel_button_Click(object sender, EventArgs e)
        {
            result = "";
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void CourseQueryInputDialog_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) ok_button.PerformClick();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) ok_button.PerformClick();
        }

        private void teacher_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (teacher_radioButton.Checked)
            {
                prompt_label.Text = "Please enter teacher ID or name: ";
                prompt_2_label.Text = "Empty for querying all teacher.";
            }
            else
            {
                prompt_label.Text = "Please enter course ID or name: ";
                prompt_2_label.Text = "Empty for querying all course.";
            }

        }
    }
}
