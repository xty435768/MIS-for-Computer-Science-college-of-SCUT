namespace MIS_for_SCUT
{
    partial class CourseChoosingQueryInputDialog
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
            this.student_radioButton = new System.Windows.Forms.RadioButton();
            this.course_radioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.prompt_2_label = new System.Windows.Forms.Label();
            this.prompt_label = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cancel_button = new System.Windows.Forms.Button();
            this.ok_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // student_radioButton
            // 
            this.student_radioButton.AutoSize = true;
            this.student_radioButton.Checked = true;
            this.student_radioButton.Location = new System.Drawing.Point(36, 63);
            this.student_radioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.student_radioButton.Name = "student_radioButton";
            this.student_radioButton.Size = new System.Drawing.Size(323, 29);
            this.student_radioButton.TabIndex = 0;
            this.student_radioButton.TabStop = true;
            this.student_radioButton.Text = "Query with student information";
            this.student_radioButton.UseVisualStyleBackColor = true;
            this.student_radioButton.CheckedChanged += new System.EventHandler(this.student_radioButton_CheckedChanged);
            // 
            // course_radioButton
            // 
            this.course_radioButton.AutoSize = true;
            this.course_radioButton.Location = new System.Drawing.Point(36, 102);
            this.course_radioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.course_radioButton.Name = "course_radioButton";
            this.course_radioButton.Size = new System.Drawing.Size(314, 29);
            this.course_radioButton.TabIndex = 1;
            this.course_radioButton.TabStop = true;
            this.course_radioButton.Text = "Query with course information";
            this.course_radioButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(31, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please choose a query condition: ";
            // 
            // prompt_2_label
            // 
            this.prompt_2_label.AutoSize = true;
            this.prompt_2_label.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.prompt_2_label.Location = new System.Drawing.Point(32, 186);
            this.prompt_2_label.Name = "prompt_2_label";
            this.prompt_2_label.Size = new System.Drawing.Size(233, 20);
            this.prompt_2_label.TabIndex = 9;
            this.prompt_2_label.Text = "Empty for querying all student.";
            // 
            // prompt_label
            // 
            this.prompt_label.AutoSize = true;
            this.prompt_label.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.prompt_label.Location = new System.Drawing.Point(31, 147);
            this.prompt_label.Name = "prompt_label";
            this.prompt_label.Size = new System.Drawing.Size(327, 27);
            this.prompt_label.TabIndex = 8;
            this.prompt_label.Text = "Please enter student ID or name: ";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(36, 225);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(562, 38);
            this.textBox1.TabIndex = 7;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(379, 293);
            this.cancel_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(176, 58);
            this.cancel_button.TabIndex = 6;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // ok_button
            // 
            this.ok_button.Location = new System.Drawing.Point(68, 293);
            this.ok_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(176, 58);
            this.ok_button.TabIndex = 5;
            this.ok_button.Text = "OK";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // CourseChoosingQueryInputDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 383);
            this.ControlBox = false;
            this.Controls.Add(this.prompt_2_label);
            this.Controls.Add(this.prompt_label);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.course_radioButton);
            this.Controls.Add(this.student_radioButton);
            this.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CourseChoosingQueryInputDialog";
            this.Text = "Query for course choosing information";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CourseChoosingQueryInputDialog_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton student_radioButton;
        private System.Windows.Forms.RadioButton course_radioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label prompt_2_label;
        private System.Windows.Forms.Label prompt_label;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button ok_button;
    }
}