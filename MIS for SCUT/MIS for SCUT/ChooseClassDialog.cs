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
    public partial class ChooseClassDialog : Form
    {
        public ChooseClassDialog()
        {
            InitializeComponent();
        }
        public string result {get;set;}
        public MySqlConnection connection { get; set; } 
        private void ChooseClassDialog_Load(object sender, EventArgs e)
        {
            DataTable class_dt = SQL_Help.ExecuteDataTable("select distinct class from student_info;", connection);
            for (int i = 0; i < class_dt.Rows.Count; i++)
            {
                comboBox1.Items.Add(class_dt.Rows[i][0]);
            }
            comboBox1.Items.Add("All Class");
            comboBox1.Text = comboBox1.Items[0].ToString();
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            result = comboBox1.Text;
            Close();
        }

        private void ChooseClassDialog_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) ok_button.PerformClick();
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            result = "";
            Close();
        }
    }
}
