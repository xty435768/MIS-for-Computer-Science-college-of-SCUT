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
    public partial class ScoreQueryInputDialog : Form
    {
        public ScoreQueryInputDialog()
        {
            InitializeComponent();
        }
        public string student_id { get; set; }
        public string course_id { get; set; }
        private void ScoreQueryInputDialog_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) ok_button.PerformClick();
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            student_id = student_id_textBox.Text;
            course_id = course_id_textBox.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
