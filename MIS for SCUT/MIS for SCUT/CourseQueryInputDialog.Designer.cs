namespace MIS_for_SCUT
{
    partial class CourseQueryInputDialog
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
            this.prompt_2_label = new System.Windows.Forms.Label();
            this.prompt_label = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cancel_button = new System.Windows.Forms.Button();
            this.ok_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.course_radioButton = new System.Windows.Forms.RadioButton();
            this.teacher_radioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // prompt_2_label
            // 
            this.prompt_2_label.AutoSize = true;
            this.prompt_2_label.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.prompt_2_label.Location = new System.Drawing.Point(40, 182);
            this.prompt_2_label.Name = "prompt_2_label";
            this.prompt_2_label.Size = new System.Drawing.Size(232, 20);
            this.prompt_2_label.TabIndex = 17;
            this.prompt_2_label.Text = "Empty for querying all teacher.";
            // 
            // prompt_label
            // 
            this.prompt_label.AutoSize = true;
            this.prompt_label.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.prompt_label.Location = new System.Drawing.Point(39, 143);
            this.prompt_label.Name = "prompt_label";
            this.prompt_label.Size = new System.Drawing.Size(326, 27);
            this.prompt_label.TabIndex = 16;
            this.prompt_label.Text = "Please enter teacher ID or name: ";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(44, 221);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(562, 38);
            this.textBox1.TabIndex = 15;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(387, 289);
            this.cancel_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(176, 58);
            this.cancel_button.TabIndex = 14;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // ok_button
            // 
            this.ok_button.Location = new System.Drawing.Point(76, 289);
            this.ok_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(176, 58);
            this.ok_button.TabIndex = 13;
            this.ok_button.Text = "OK";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(39, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 27);
            this.label1.TabIndex = 12;
            this.label1.Text = "Please choose a query condition: ";
            // 
            // course_radioButton
            // 
            this.course_radioButton.AutoSize = true;
            this.course_radioButton.Location = new System.Drawing.Point(44, 98);
            this.course_radioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.course_radioButton.Name = "course_radioButton";
            this.course_radioButton.Size = new System.Drawing.Size(314, 29);
            this.course_radioButton.TabIndex = 11;
            this.course_radioButton.Text = "Query with course information";
            this.course_radioButton.UseVisualStyleBackColor = true;
            // 
            // teacher_radioButton
            // 
            this.teacher_radioButton.AutoSize = true;
            this.teacher_radioButton.Checked = true;
            this.teacher_radioButton.Location = new System.Drawing.Point(44, 59);
            this.teacher_radioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.teacher_radioButton.Name = "teacher_radioButton";
            this.teacher_radioButton.Size = new System.Drawing.Size(322, 29);
            this.teacher_radioButton.TabIndex = 10;
            this.teacher_radioButton.TabStop = true;
            this.teacher_radioButton.Text = "Query with teacher information";
            this.teacher_radioButton.UseVisualStyleBackColor = true;
            this.teacher_radioButton.CheckedChanged += new System.EventHandler(this.teacher_radioButton_CheckedChanged);
            // 
            // CourseQueryInputDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 369);
            this.ControlBox = false;
            this.Controls.Add(this.prompt_2_label);
            this.Controls.Add(this.prompt_label);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.course_radioButton);
            this.Controls.Add(this.teacher_radioButton);
            this.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CourseQueryInputDialog";
            this.Text = "CourseQueryInputDialog";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CourseQueryInputDialog_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label prompt_2_label;
        private System.Windows.Forms.Label prompt_label;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton course_radioButton;
        private System.Windows.Forms.RadioButton teacher_radioButton;
    }
}