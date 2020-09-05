namespace MIS_for_SCUT
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Account = new System.Windows.Forms.ToolStripMenuItem();
            this.editPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetUserPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.user_text_menuitem = new System.Windows.Forms.ToolStripMenuItem();
            this.role_text_menuitem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Course = new System.Windows.Forms.ToolStripMenuItem();
            this.addCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queryCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCourseChoosingInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.submitScoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queryStudentInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queryStudentScoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queryCourseInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queryTeacherInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queryAverageScoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.singleStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsInSameClassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.singleCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.About = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Account,
            this.Course,
            this.informationToolStripMenuItem,
            this.About});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1110, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Account
            // 
            this.Account.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editPasswordToolStripMenuItem,
            this.addAccountToolStripMenuItem,
            this.resetUserPasswordToolStripMenuItem,
            this.user_text_menuitem,
            this.role_text_menuitem,
            this.logoutToolStripMenuItem});
            this.Account.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Account.Name = "Account";
            this.Account.Size = new System.Drawing.Size(100, 29);
            this.Account.Text = "Account";
            // 
            // editPasswordToolStripMenuItem
            // 
            this.editPasswordToolStripMenuItem.Name = "editPasswordToolStripMenuItem";
            this.editPasswordToolStripMenuItem.Size = new System.Drawing.Size(280, 30);
            this.editPasswordToolStripMenuItem.Text = "Edit Password";
            this.editPasswordToolStripMenuItem.Click += new System.EventHandler(this.editPasswordToolStripMenuItem_Click);
            // 
            // addAccountToolStripMenuItem
            // 
            this.addAccountToolStripMenuItem.Name = "addAccountToolStripMenuItem";
            this.addAccountToolStripMenuItem.Size = new System.Drawing.Size(280, 30);
            this.addAccountToolStripMenuItem.Text = "Add Account";
            this.addAccountToolStripMenuItem.Visible = false;
            this.addAccountToolStripMenuItem.Click += new System.EventHandler(this.addAccountToolStripMenuItem_Click);
            // 
            // resetUserPasswordToolStripMenuItem
            // 
            this.resetUserPasswordToolStripMenuItem.Name = "resetUserPasswordToolStripMenuItem";
            this.resetUserPasswordToolStripMenuItem.Size = new System.Drawing.Size(280, 30);
            this.resetUserPasswordToolStripMenuItem.Text = "Reset User Password";
            this.resetUserPasswordToolStripMenuItem.Visible = false;
            this.resetUserPasswordToolStripMenuItem.Click += new System.EventHandler(this.resetUserPasswordToolStripMenuItem_Click);
            // 
            // user_text_menuitem
            // 
            this.user_text_menuitem.Enabled = false;
            this.user_text_menuitem.Name = "user_text_menuitem";
            this.user_text_menuitem.Size = new System.Drawing.Size(280, 30);
            this.user_text_menuitem.Text = "User: Null";
            // 
            // role_text_menuitem
            // 
            this.role_text_menuitem.Enabled = false;
            this.role_text_menuitem.Name = "role_text_menuitem";
            this.role_text_menuitem.Size = new System.Drawing.Size(280, 30);
            this.role_text_menuitem.Text = "Role: Null";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(280, 30);
            this.logoutToolStripMenuItem.Text = "Logout/Exit";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // Course
            // 
            this.Course.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCourseToolStripMenuItem,
            this.queryCourseToolStripMenuItem,
            this.addCourseChoosingInfoToolStripMenuItem,
            this.submitScoreToolStripMenuItem});
            this.Course.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Course.Name = "Course";
            this.Course.Size = new System.Drawing.Size(88, 29);
            this.Course.Text = "Course";
            // 
            // addCourseToolStripMenuItem
            // 
            this.addCourseToolStripMenuItem.Name = "addCourseToolStripMenuItem";
            this.addCourseToolStripMenuItem.Size = new System.Drawing.Size(423, 30);
            this.addCourseToolStripMenuItem.Text = "Add Course";
            this.addCourseToolStripMenuItem.Visible = false;
            this.addCourseToolStripMenuItem.Click += new System.EventHandler(this.addCourseToolStripMenuItem_Click);
            // 
            // queryCourseToolStripMenuItem
            // 
            this.queryCourseToolStripMenuItem.Name = "queryCourseToolStripMenuItem";
            this.queryCourseToolStripMenuItem.Size = new System.Drawing.Size(423, 30);
            this.queryCourseToolStripMenuItem.Text = "Query Course Choosing Information";
            this.queryCourseToolStripMenuItem.Click += new System.EventHandler(this.queryCourseToolStripMenuItem_Click);
            // 
            // addCourseChoosingInfoToolStripMenuItem
            // 
            this.addCourseChoosingInfoToolStripMenuItem.Name = "addCourseChoosingInfoToolStripMenuItem";
            this.addCourseChoosingInfoToolStripMenuItem.Size = new System.Drawing.Size(423, 30);
            this.addCourseChoosingInfoToolStripMenuItem.Text = "Add Course Choosing Info";
            this.addCourseChoosingInfoToolStripMenuItem.Visible = false;
            this.addCourseChoosingInfoToolStripMenuItem.Click += new System.EventHandler(this.addCourseChoosingInfoToolStripMenuItem_Click);
            // 
            // submitScoreToolStripMenuItem
            // 
            this.submitScoreToolStripMenuItem.Name = "submitScoreToolStripMenuItem";
            this.submitScoreToolStripMenuItem.Size = new System.Drawing.Size(423, 30);
            this.submitScoreToolStripMenuItem.Text = "Submit Score";
            this.submitScoreToolStripMenuItem.Visible = false;
            this.submitScoreToolStripMenuItem.Click += new System.EventHandler(this.submitScoreToolStripMenuItem_Click);
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifyInformationToolStripMenuItem,
            this.queryStudentInformationToolStripMenuItem,
            this.queryStudentScoreToolStripMenuItem,
            this.queryCourseInformationToolStripMenuItem,
            this.queryTeacherInformationToolStripMenuItem,
            this.queryAverageScoreToolStripMenuItem});
            this.informationToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(133, 29);
            this.informationToolStripMenuItem.Text = "Information";
            // 
            // modifyInformationToolStripMenuItem
            // 
            this.modifyInformationToolStripMenuItem.Name = "modifyInformationToolStripMenuItem";
            this.modifyInformationToolStripMenuItem.Size = new System.Drawing.Size(445, 30);
            this.modifyInformationToolStripMenuItem.Text = "Modify Information";
            this.modifyInformationToolStripMenuItem.Visible = false;
            this.modifyInformationToolStripMenuItem.Click += new System.EventHandler(this.modifyInformationToolStripMenuItem_Click);
            // 
            // queryStudentInformationToolStripMenuItem
            // 
            this.queryStudentInformationToolStripMenuItem.Name = "queryStudentInformationToolStripMenuItem";
            this.queryStudentInformationToolStripMenuItem.Size = new System.Drawing.Size(445, 30);
            this.queryStudentInformationToolStripMenuItem.Text = "Query Student Information";
            this.queryStudentInformationToolStripMenuItem.Click += new System.EventHandler(this.queryStudentInformationToolStripMenuItem_Click);
            // 
            // queryStudentScoreToolStripMenuItem
            // 
            this.queryStudentScoreToolStripMenuItem.Name = "queryStudentScoreToolStripMenuItem";
            this.queryStudentScoreToolStripMenuItem.Size = new System.Drawing.Size(445, 30);
            this.queryStudentScoreToolStripMenuItem.Text = "Query Student Score/Course Choosing";
            this.queryStudentScoreToolStripMenuItem.Click += new System.EventHandler(this.queryStudentScoreToolStripMenuItem_Click);
            // 
            // queryCourseInformationToolStripMenuItem
            // 
            this.queryCourseInformationToolStripMenuItem.Name = "queryCourseInformationToolStripMenuItem";
            this.queryCourseInformationToolStripMenuItem.Size = new System.Drawing.Size(445, 30);
            this.queryCourseInformationToolStripMenuItem.Text = "Query Course Information";
            this.queryCourseInformationToolStripMenuItem.Click += new System.EventHandler(this.queryCourseInformationToolStripMenuItem_Click);
            // 
            // queryTeacherInformationToolStripMenuItem
            // 
            this.queryTeacherInformationToolStripMenuItem.Name = "queryTeacherInformationToolStripMenuItem";
            this.queryTeacherInformationToolStripMenuItem.Size = new System.Drawing.Size(445, 30);
            this.queryTeacherInformationToolStripMenuItem.Text = "Query Teacher Information";
            this.queryTeacherInformationToolStripMenuItem.Click += new System.EventHandler(this.queryTeacherInformationToolStripMenuItem_Click);
            // 
            // queryAverageScoreToolStripMenuItem
            // 
            this.queryAverageScoreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.singleStudentToolStripMenuItem,
            this.allStudentToolStripMenuItem,
            this.studentsInSameClassToolStripMenuItem,
            this.singleCourseToolStripMenuItem});
            this.queryAverageScoreToolStripMenuItem.Name = "queryAverageScoreToolStripMenuItem";
            this.queryAverageScoreToolStripMenuItem.Size = new System.Drawing.Size(445, 30);
            this.queryAverageScoreToolStripMenuItem.Text = "Query Average Score";
            // 
            // singleStudentToolStripMenuItem
            // 
            this.singleStudentToolStripMenuItem.Name = "singleStudentToolStripMenuItem";
            this.singleStudentToolStripMenuItem.Size = new System.Drawing.Size(299, 30);
            this.singleStudentToolStripMenuItem.Text = "Single Student";
            this.singleStudentToolStripMenuItem.Click += new System.EventHandler(this.singleStudentToolStripMenuItem_Click);
            // 
            // allStudentToolStripMenuItem
            // 
            this.allStudentToolStripMenuItem.Name = "allStudentToolStripMenuItem";
            this.allStudentToolStripMenuItem.Size = new System.Drawing.Size(299, 30);
            this.allStudentToolStripMenuItem.Text = "All Student";
            this.allStudentToolStripMenuItem.Click += new System.EventHandler(this.allStudentToolStripMenuItem_Click);
            // 
            // studentsInSameClassToolStripMenuItem
            // 
            this.studentsInSameClassToolStripMenuItem.Name = "studentsInSameClassToolStripMenuItem";
            this.studentsInSameClassToolStripMenuItem.Size = new System.Drawing.Size(299, 30);
            this.studentsInSameClassToolStripMenuItem.Text = "Students in same class";
            this.studentsInSameClassToolStripMenuItem.Click += new System.EventHandler(this.studentsInSameClassToolStripMenuItem_Click);
            // 
            // singleCourseToolStripMenuItem
            // 
            this.singleCourseToolStripMenuItem.Name = "singleCourseToolStripMenuItem";
            this.singleCourseToolStripMenuItem.Size = new System.Drawing.Size(299, 30);
            this.singleCourseToolStripMenuItem.Text = "Single Course";
            this.singleCourseToolStripMenuItem.Click += new System.EventHandler(this.singleCourseToolStripMenuItem_Click);
            // 
            // About
            // 
            this.About.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.About.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(80, 29);
            this.About.Text = "About";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(146, 30);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(146, 30);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(28, 53);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowTemplate.Height = 27;
            this.dgv.Size = new System.Drawing.Size(1061, 544);
            this.dgv.TabIndex = 1;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 626);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Manage Information System of Computer Science College for SCUT v1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Account;
        private System.Windows.Forms.ToolStripMenuItem editPasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Course;
        private System.Windows.Forms.ToolStripMenuItem About;
        private System.Windows.Forms.ToolStripMenuItem user_text_menuitem;
        private System.Windows.Forms.ToolStripMenuItem role_text_menuitem;
        private System.Windows.Forms.ToolStripMenuItem addAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetUserPasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queryCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCourseChoosingInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem submitScoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queryStudentInformationToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.ToolStripMenuItem queryStudentScoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queryCourseInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queryTeacherInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queryAverageScoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem singleStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsInSameClassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem singleCourseToolStripMenuItem;
    }
}