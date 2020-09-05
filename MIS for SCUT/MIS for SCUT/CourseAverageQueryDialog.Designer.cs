namespace MIS_for_SCUT
{
    partial class CourseAverageQueryDialog
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
            this.ok_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.year_comboBox = new System.Windows.Forms.ComboBox();
            this.teacher_comboBox = new System.Windows.Forms.ComboBox();
            this.course_comboBox = new SergeUtils.EasyCompletionComboBox();
            this.SuspendLayout();
            // 
            // ok_button
            // 
            this.ok_button.Location = new System.Drawing.Point(84, 303);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(181, 64);
            this.ok_button.TabIndex = 0;
            this.ok_button.Text = "OK";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(470, 303);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(181, 64);
            this.cancel_button.TabIndex = 1;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(552, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please select the following information to filter the course:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Course:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Teacher: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Chosen year: ";
            // 
            // year_comboBox
            // 
            this.year_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.year_comboBox.FormattingEnabled = true;
            this.year_comboBox.Location = new System.Drawing.Point(202, 197);
            this.year_comboBox.Name = "year_comboBox";
            this.year_comboBox.Size = new System.Drawing.Size(469, 32);
            this.year_comboBox.TabIndex = 6;
            // 
            // teacher_comboBox
            // 
            this.teacher_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.teacher_comboBox.FormattingEnabled = true;
            this.teacher_comboBox.Location = new System.Drawing.Point(202, 146);
            this.teacher_comboBox.Name = "teacher_comboBox";
            this.teacher_comboBox.Size = new System.Drawing.Size(469, 32);
            this.teacher_comboBox.TabIndex = 7;
            this.teacher_comboBox.TextChanged += new System.EventHandler(this.teacher_comboBox_TextChanged);
            // 
            // course_comboBox
            // 
            this.course_comboBox.FormattingEnabled = true;
            this.course_comboBox.Location = new System.Drawing.Point(202, 96);
            this.course_comboBox.Name = "course_comboBox";
            this.course_comboBox.Size = new System.Drawing.Size(469, 32);
            this.course_comboBox.TabIndex = 8;
            this.course_comboBox.TextChanged += new System.EventHandler(this.course_comboBox_TextChanged);
            // 
            // CourseAverageQueryDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 403);
            this.ControlBox = false;
            this.Controls.Add(this.course_comboBox);
            this.Controls.Add(this.teacher_comboBox);
            this.Controls.Add(this.year_comboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.ok_button);
            this.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CourseAverageQueryDialog";
            this.Text = "CourseAverageQueryDialog";
            this.Load += new System.EventHandler(this.CourseAverageQueryDialog_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CourseAverageQueryDialog_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox year_comboBox;
        private System.Windows.Forms.ComboBox teacher_comboBox;
        private SergeUtils.EasyCompletionComboBox course_comboBox;
    }
}