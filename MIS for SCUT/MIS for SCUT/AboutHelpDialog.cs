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
    public partial class AboutHelpDialog : Form
    {
        public AboutHelpDialog(string url)
        {
            InitializeComponent();
            this.url = url;
        }
        string url;
        public void SetWebBroser(bool b = false)
        {
            webBrowser1.Visible = b;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AboutHelpDialog_Load(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri(url);
            webBrowser1.Refresh();
        }

    }
}
