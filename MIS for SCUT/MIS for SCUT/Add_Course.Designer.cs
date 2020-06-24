namespace MIS_for_SCUT
{
    partial class Add_Course
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grade_comboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cancel_year_textBox = new System.Windows.Forms.TextBox();
            this.credit_textBox = new System.Windows.Forms.TextBox();
            this.course_name_textBox = new System.Windows.Forms.TextBox();
            this.course_id_textBox = new System.Windows.Forms.TextBox();
            this.teacher_id_ComboBox = new SergeUtils.EasyCompletionComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(40, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course ID: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(40, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Course Name: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(40, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Teacher\'s ID: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(40, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Credit: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(40, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Grade Limitation: ";
            // 
            // grade_comboBox
            // 
            this.grade_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.grade_comboBox.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grade_comboBox.FormattingEnabled = true;
            this.grade_comboBox.Items.AddRange(new object[] {
            "Freshman",
            "Sophomore",
            "Junior",
            "Senior"});
            this.grade_comboBox.Location = new System.Drawing.Point(320, 253);
            this.grade_comboBox.Name = "grade_comboBox";
            this.grade_comboBox.Size = new System.Drawing.Size(353, 32);
            this.grade_comboBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(40, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(251, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Canceled Year (Optional): ";
            // 
            // cancel_year_textBox
            // 
            this.cancel_year_textBox.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cancel_year_textBox.Location = new System.Drawing.Point(320, 312);
            this.cancel_year_textBox.Name = "cancel_year_textBox";
            this.cancel_year_textBox.Size = new System.Drawing.Size(353, 31);
            this.cancel_year_textBox.TabIndex = 12;
            // 
            // credit_textBox
            // 
            this.credit_textBox.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.credit_textBox.Location = new System.Drawing.Point(320, 197);
            this.credit_textBox.Name = "credit_textBox";
            this.credit_textBox.Size = new System.Drawing.Size(353, 31);
            this.credit_textBox.TabIndex = 10;
            // 
            // course_name_textBox
            // 
            this.course_name_textBox.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.course_name_textBox.Location = new System.Drawing.Point(320, 89);
            this.course_name_textBox.Name = "course_name_textBox";
            this.course_name_textBox.Size = new System.Drawing.Size(353, 31);
            this.course_name_textBox.TabIndex = 8;
            // 
            // course_id_textBox
            // 
            this.course_id_textBox.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.course_id_textBox.Location = new System.Drawing.Point(320, 37);
            this.course_id_textBox.Name = "course_id_textBox";
            this.course_id_textBox.Size = new System.Drawing.Size(353, 31);
            this.course_id_textBox.TabIndex = 7;
            // 
            // teacher_id_ComboBox
            // 
            this.teacher_id_ComboBox.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.teacher_id_ComboBox.FormattingEnabled = true;
            this.teacher_id_ComboBox.Location = new System.Drawing.Point(320, 143);
            this.teacher_id_ComboBox.Name = "teacher_id_ComboBox";
            this.teacher_id_ComboBox.Size = new System.Drawing.Size(353, 32);
            this.teacher_id_ComboBox.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(219, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(288, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Add_Course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.teacher_id_ComboBox);
            this.Controls.Add(this.course_id_textBox);
            this.Controls.Add(this.course_name_textBox);
            this.Controls.Add(this.credit_textBox);
            this.Controls.Add(this.cancel_year_textBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.grade_comboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Add_Course";
            this.Text = "Add_Course";
            this.Load += new System.EventHandler(this.Add_Course_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox grade_comboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cancel_year_textBox;
        private System.Windows.Forms.TextBox credit_textBox;
        private System.Windows.Forms.TextBox course_name_textBox;
        private System.Windows.Forms.TextBox course_id_textBox;
        private SergeUtils.EasyCompletionComboBox teacher_id_ComboBox;
        private System.Windows.Forms.Button button1;
    }
}