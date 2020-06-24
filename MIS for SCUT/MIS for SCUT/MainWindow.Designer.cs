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
            this.About = new System.Windows.Forms.ToolStripMenuItem();
            this.addCourseChoosingInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Account,
            this.Course,
            this.About});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1201, 33);
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
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // Course
            // 
            this.Course.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCourseToolStripMenuItem,
            this.queryCourseToolStripMenuItem,
            this.addCourseChoosingInfoToolStripMenuItem});
            this.Course.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Course.Name = "Course";
            this.Course.Size = new System.Drawing.Size(88, 29);
            this.Course.Text = "Course";
            // 
            // addCourseToolStripMenuItem
            // 
            this.addCourseToolStripMenuItem.Name = "addCourseToolStripMenuItem";
            this.addCourseToolStripMenuItem.Size = new System.Drawing.Size(216, 30);
            this.addCourseToolStripMenuItem.Text = "Add Course";
            this.addCourseToolStripMenuItem.Visible = false;
            this.addCourseToolStripMenuItem.Click += new System.EventHandler(this.addCourseToolStripMenuItem_Click);
            // 
            // queryCourseToolStripMenuItem
            // 
            this.queryCourseToolStripMenuItem.Name = "queryCourseToolStripMenuItem";
            this.queryCourseToolStripMenuItem.Size = new System.Drawing.Size(216, 30);
            this.queryCourseToolStripMenuItem.Text = "Query Course";
            // 
            // About
            // 
            this.About.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(80, 29);
            this.About.Text = "About";
            // 
            // addCourseChoosingInfoToolStripMenuItem
            // 
            this.addCourseChoosingInfoToolStripMenuItem.Name = "addCourseChoosingInfoToolStripMenuItem";
            this.addCourseChoosingInfoToolStripMenuItem.Size = new System.Drawing.Size(333, 30);
            this.addCourseChoosingInfoToolStripMenuItem.Text = "Add Course Choosing Info";
            this.addCourseChoosingInfoToolStripMenuItem.Visible = false;
            this.addCourseChoosingInfoToolStripMenuItem.Click += new System.EventHandler(this.addCourseChoosingInfoToolStripMenuItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 683);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
    }
}