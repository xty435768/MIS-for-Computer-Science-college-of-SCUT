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
    public partial class InputDialog : Form
    {
        public InputDialog(string head,string prompt,string second_prompt)
        {
            InitializeComponent();
            Text = head;
            prompt_label.Text = prompt;
            prompt_2_label.Text = second_prompt;
        }
        public string result {get;set;}
        private void cancel_button_Click(object sender, EventArgs e)
        {
            result = "";
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            result = textBox1.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void InputDialog_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) ok_button.PerformClick();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) ok_button.PerformClick();
        }

        private void InputDialog_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }
    }
}
