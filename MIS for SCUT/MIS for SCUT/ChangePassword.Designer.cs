namespace MIS_for_SCUT
{
    partial class ChangePassword
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
            this.apply = new System.Windows.Forms.Button();
            this.cancle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.old_pwd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.new_pwd = new System.Windows.Forms.TextBox();
            this.con_new_pwd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // apply
            // 
            this.apply.Enabled = false;
            this.apply.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.apply.Location = new System.Drawing.Point(75, 288);
            this.apply.Name = "apply";
            this.apply.Size = new System.Drawing.Size(184, 59);
            this.apply.TabIndex = 0;
            this.apply.Text = "Apply";
            this.apply.UseVisualStyleBackColor = true;
            this.apply.Click += new System.EventHandler(this.apply_Click);
            // 
            // cancle
            // 
            this.cancle.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cancle.Location = new System.Drawing.Point(503, 288);
            this.cancle.Name = "cancle";
            this.cancle.Size = new System.Drawing.Size(184, 59);
            this.cancle.TabIndex = 1;
            this.cancle.Text = "Cancle";
            this.cancle.UseVisualStyleBackColor = true;
            this.cancle.Click += new System.EventHandler(this.cancle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(34, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Old Password: ";
            // 
            // old_pwd
            // 
            this.old_pwd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.old_pwd.Location = new System.Drawing.Point(336, 47);
            this.old_pwd.Name = "old_pwd";
            this.old_pwd.Size = new System.Drawing.Size(379, 34);
            this.old_pwd.TabIndex = 3;
            this.old_pwd.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(34, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "New Password: ";
            // 
            // new_pwd
            // 
            this.new_pwd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.new_pwd.Location = new System.Drawing.Point(336, 110);
            this.new_pwd.Name = "new_pwd";
            this.new_pwd.Size = new System.Drawing.Size(379, 34);
            this.new_pwd.TabIndex = 5;
            this.new_pwd.UseSystemPasswordChar = true;
            this.new_pwd.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // con_new_pwd
            // 
            this.con_new_pwd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.con_new_pwd.Location = new System.Drawing.Point(336, 176);
            this.con_new_pwd.Name = "con_new_pwd";
            this.con_new_pwd.Size = new System.Drawing.Size(379, 34);
            this.con_new_pwd.TabIndex = 6;
            this.con_new_pwd.UseSystemPasswordChar = true;
            this.con_new_pwd.TextChanged += new System.EventHandler(this.con_new_pwd_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(34, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 27);
            this.label3.TabIndex = 7;
            this.label3.Text = "Confirm New Password: ";
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 379);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.con_new_pwd);
            this.Controls.Add(this.new_pwd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.old_pwd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancle);
            this.Controls.Add(this.apply);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangePassword";
            this.Text = "ChangePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button apply;
        private System.Windows.Forms.Button cancle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox old_pwd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox new_pwd;
        private System.Windows.Forms.TextBox con_new_pwd;
        private System.Windows.Forms.Label label3;
    }
}