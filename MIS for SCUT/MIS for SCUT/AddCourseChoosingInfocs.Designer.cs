namespace MIS_for_SCUT
{
    partial class AddCourseChoosingInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.course_id_ComboBox = new SergeUtils.EasyCompletionComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.year_textBox = new System.Windows.Forms.TextBox();
            this.teacher_id_textBox = new System.Windows.Forms.TextBox();
            this.alternative_listBox = new System.Windows.Forms.ListBox();
            this.class_ComboBox = new SergeUtils.EasyCompletionComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chosen_listBox = new System.Windows.Forms.ListBox();
            this.add_to_chosen_button = new System.Windows.Forms.Button();
            this.remove_button = new System.Windows.Forms.Button();
            this.delete_all_button = new System.Windows.Forms.Button();
            this.add_all_button = new System.Windows.Forms.Button();
            this.student_id_ComboBox = new SergeUtils.EasyCompletionComboBox();
            this.add_single_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(36, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course ID: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(36, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Teacher ID: ";
            // 
            // course_id_ComboBox
            // 
            this.course_id_ComboBox.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.course_id_ComboBox.FormattingEnabled = true;
            this.course_id_ComboBox.Location = new System.Drawing.Point(197, 47);
            this.course_id_ComboBox.Name = "course_id_ComboBox";
            this.course_id_ComboBox.Size = new System.Drawing.Size(705, 32);
            this.course_id_ComboBox.TabIndex = 2;
            this.course_id_ComboBox.TextChanged += new System.EventHandler(this.course_id_ComboBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(36, 577);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Chosen Year: ";
            // 
            // year_textBox
            // 
            this.year_textBox.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.year_textBox.Location = new System.Drawing.Point(197, 574);
            this.year_textBox.Name = "year_textBox";
            this.year_textBox.Size = new System.Drawing.Size(705, 31);
            this.year_textBox.TabIndex = 5;
            this.year_textBox.Enter += new System.EventHandler(this.year_textBox_Enter);
            this.year_textBox.Leave += new System.EventHandler(this.year_textBox_Leave);
            // 
            // teacher_id_textBox
            // 
            this.teacher_id_textBox.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.teacher_id_textBox.Location = new System.Drawing.Point(197, 95);
            this.teacher_id_textBox.Name = "teacher_id_textBox";
            this.teacher_id_textBox.ReadOnly = true;
            this.teacher_id_textBox.Size = new System.Drawing.Size(705, 31);
            this.teacher_id_textBox.TabIndex = 6;
            // 
            // alternative_listBox
            // 
            this.alternative_listBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.alternative_listBox.FormattingEnabled = true;
            this.alternative_listBox.ItemHeight = 20;
            this.alternative_listBox.Location = new System.Drawing.Point(41, 243);
            this.alternative_listBox.Name = "alternative_listBox";
            this.alternative_listBox.Size = new System.Drawing.Size(323, 244);
            this.alternative_listBox.TabIndex = 7;
            this.alternative_listBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.alternative_listBox_MouseClick);
            // 
            // class_ComboBox
            // 
            this.class_ComboBox.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.class_ComboBox.FormattingEnabled = true;
            this.class_ComboBox.Location = new System.Drawing.Point(197, 143);
            this.class_ComboBox.Name = "class_ComboBox";
            this.class_ComboBox.Size = new System.Drawing.Size(705, 32);
            this.class_ComboBox.TabIndex = 8;
            this.class_ComboBox.SelectedIndexChanged += new System.EventHandler(this.class_ComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(36, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Class filter: ";
            // 
            // chosen_listBox
            // 
            this.chosen_listBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chosen_listBox.FormattingEnabled = true;
            this.chosen_listBox.ItemHeight = 20;
            this.chosen_listBox.Location = new System.Drawing.Point(579, 243);
            this.chosen_listBox.Name = "chosen_listBox";
            this.chosen_listBox.Size = new System.Drawing.Size(323, 244);
            this.chosen_listBox.TabIndex = 11;
            this.chosen_listBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chosen_listBox_MouseClick);
            // 
            // add_to_chosen_button
            // 
            this.add_to_chosen_button.Enabled = false;
            this.add_to_chosen_button.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.add_to_chosen_button.Location = new System.Drawing.Point(388, 259);
            this.add_to_chosen_button.Name = "add_to_chosen_button";
            this.add_to_chosen_button.Size = new System.Drawing.Size(169, 44);
            this.add_to_chosen_button.TabIndex = 12;
            this.add_to_chosen_button.Text = "Add->";
            this.add_to_chosen_button.UseVisualStyleBackColor = true;
            this.add_to_chosen_button.Click += new System.EventHandler(this.add_to_chosen_button_Click);
            // 
            // remove_button
            // 
            this.remove_button.Enabled = false;
            this.remove_button.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.remove_button.Location = new System.Drawing.Point(388, 309);
            this.remove_button.Name = "remove_button";
            this.remove_button.Size = new System.Drawing.Size(169, 44);
            this.remove_button.TabIndex = 13;
            this.remove_button.Text = "<-Delete";
            this.remove_button.UseVisualStyleBackColor = true;
            this.remove_button.Click += new System.EventHandler(this.remove_button_Click);
            // 
            // delete_all_button
            // 
            this.delete_all_button.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.delete_all_button.Location = new System.Drawing.Point(388, 409);
            this.delete_all_button.Name = "delete_all_button";
            this.delete_all_button.Size = new System.Drawing.Size(169, 44);
            this.delete_all_button.TabIndex = 15;
            this.delete_all_button.Text = "<-Delete All";
            this.delete_all_button.UseVisualStyleBackColor = true;
            this.delete_all_button.Click += new System.EventHandler(this.delete_all_button_Click);
            // 
            // add_all_button
            // 
            this.add_all_button.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.add_all_button.Location = new System.Drawing.Point(388, 359);
            this.add_all_button.Name = "add_all_button";
            this.add_all_button.Size = new System.Drawing.Size(169, 44);
            this.add_all_button.TabIndex = 14;
            this.add_all_button.Text = "Add All->";
            this.add_all_button.UseVisualStyleBackColor = true;
            this.add_all_button.Click += new System.EventHandler(this.add_all_button_Click);
            // 
            // student_id_ComboBox
            // 
            this.student_id_ComboBox.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.student_id_ComboBox.FormattingEnabled = true;
            this.student_id_ComboBox.Location = new System.Drawing.Point(197, 194);
            this.student_id_ComboBox.Name = "student_id_ComboBox";
            this.student_id_ComboBox.Size = new System.Drawing.Size(426, 32);
            this.student_id_ComboBox.TabIndex = 16;
            this.student_id_ComboBox.Enter += new System.EventHandler(this.student_id_ComboBox_Enter);
            this.student_id_ComboBox.Leave += new System.EventHandler(this.student_id_ComboBox_Leave);
            // 
            // add_single_button
            // 
            this.add_single_button.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.add_single_button.Location = new System.Drawing.Point(641, 187);
            this.add_single_button.Name = "add_single_button";
            this.add_single_button.Size = new System.Drawing.Size(261, 44);
            this.add_single_button.TabIndex = 17;
            this.add_single_button.Text = "Add single student";
            this.add_single_button.UseVisualStyleBackColor = true;
            this.add_single_button.Click += new System.EventHandler(this.add_single_button_Click);
            // 
            // add_button
            // 
            this.add_button.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.add_button.Location = new System.Drawing.Point(264, 647);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(429, 57);
            this.add_button.TabIndex = 18;
            this.add_button.Text = "Submit";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(101, 503);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 27);
            this.label5.TabIndex = 19;
            this.label5.Text = "Candidates students";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(668, 503);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 27);
            this.label6.TabIndex = 20;
            this.label6.Text = "Chosen students";
            // 
            // AddCourseChoosingInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 736);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.add_single_button);
            this.Controls.Add(this.student_id_ComboBox);
            this.Controls.Add(this.delete_all_button);
            this.Controls.Add(this.add_all_button);
            this.Controls.Add(this.remove_button);
            this.Controls.Add(this.add_to_chosen_button);
            this.Controls.Add(this.chosen_listBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.class_ComboBox);
            this.Controls.Add(this.alternative_listBox);
            this.Controls.Add(this.teacher_id_textBox);
            this.Controls.Add(this.year_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.course_id_ComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddCourseChoosingInfo";
            this.Text = "AddCourseChoosingInfo";
            this.Load += new System.EventHandler(this.AddCourseChoosingInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private SergeUtils.EasyCompletionComboBox course_id_ComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox year_textBox;
        private System.Windows.Forms.TextBox teacher_id_textBox;
        private System.Windows.Forms.ListBox alternative_listBox;
        private SergeUtils.EasyCompletionComboBox class_ComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox chosen_listBox;
        private System.Windows.Forms.Button add_to_chosen_button;
        private System.Windows.Forms.Button remove_button;
        private System.Windows.Forms.Button delete_all_button;
        private System.Windows.Forms.Button add_all_button;
        private SergeUtils.EasyCompletionComboBox student_id_ComboBox;
        private System.Windows.Forms.Button add_single_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}