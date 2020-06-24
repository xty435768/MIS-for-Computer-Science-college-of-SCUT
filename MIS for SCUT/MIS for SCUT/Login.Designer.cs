namespace MIS_for_SCUT
{
    partial class Login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.log_in = new System.Windows.Forms.Button();
            this.loading_text = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(113, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(113, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password: ";
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.username.Location = new System.Drawing.Point(238, 226);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(382, 34);
            this.username.TabIndex = 2;
            this.username.Text = "admin";
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.password.Location = new System.Drawing.Point(238, 284);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(382, 34);
            this.password.TabIndex = 3;
            this.password.Text = "12345678";
            this.password.UseSystemPasswordChar = true;
            // 
            // log_in
            // 
            this.log_in.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.log_in.Location = new System.Drawing.Point(319, 359);
            this.log_in.Name = "log_in";
            this.log_in.Size = new System.Drawing.Size(155, 47);
            this.log_in.TabIndex = 4;
            this.log_in.Text = "Log in";
            this.log_in.UseVisualStyleBackColor = true;
            this.log_in.Click += new System.EventHandler(this.log_in_Click);
            // 
            // loading_text
            // 
            this.loading_text.AutoSize = true;
            this.loading_text.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.loading_text.Location = new System.Drawing.Point(573, 369);
            this.loading_text.Name = "loading_text";
            this.loading_text.Size = new System.Drawing.Size(104, 27);
            this.loading_text.TabIndex = 5;
            this.loading_text.Text = "Loading...";
            this.loading_text.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loading_text);
            this.Controls.Add(this.log_in);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Text = "Manage Information System of Computer Science College in SCUT v0.1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button log_in;
        private System.Windows.Forms.Label loading_text;
    }
}

