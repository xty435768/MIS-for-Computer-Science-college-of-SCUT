namespace MIS_for_SCUT
{
    partial class ScoreQueryInputDialog
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
            this.prompt_2_label = new System.Windows.Forms.Label();
            this.prompt_label = new System.Windows.Forms.Label();
            this.student_id_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.course_id_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ok_button
            // 
            this.ok_button.Location = new System.Drawing.Point(112, 252);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(170, 55);
            this.ok_button.TabIndex = 0;
            this.ok_button.Text = "OK";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(453, 252);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(170, 55);
            this.cancel_button.TabIndex = 1;
            this.cancel_button.Text = "Cancle";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // prompt_2_label
            // 
            this.prompt_2_label.AutoSize = true;
            this.prompt_2_label.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.prompt_2_label.Location = new System.Drawing.Point(390, 43);
            this.prompt_2_label.Name = "prompt_2_label";
            this.prompt_2_label.Size = new System.Drawing.Size(233, 20);
            this.prompt_2_label.TabIndex = 7;
            this.prompt_2_label.Text = "Empty for querying all student.";
            // 
            // prompt_label
            // 
            this.prompt_label.AutoSize = true;
            this.prompt_label.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.prompt_label.Location = new System.Drawing.Point(40, 38);
            this.prompt_label.Name = "prompt_label";
            this.prompt_label.Size = new System.Drawing.Size(327, 27);
            this.prompt_label.TabIndex = 6;
            this.prompt_label.Text = "Please enter student ID or name: ";
            // 
            // student_id_textBox
            // 
            this.student_id_textBox.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.student_id_textBox.Location = new System.Drawing.Point(45, 86);
            this.student_id_textBox.Name = "student_id_textBox";
            this.student_id_textBox.Size = new System.Drawing.Size(635, 38);
            this.student_id_textBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(394, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Empty for querying all course.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(44, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(319, 27);
            this.label2.TabIndex = 9;
            this.label2.Text = "Please enter course ID or name: ";
            // 
            // course_id_textBox
            // 
            this.course_id_textBox.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.course_id_textBox.Location = new System.Drawing.Point(49, 191);
            this.course_id_textBox.Name = "course_id_textBox";
            this.course_id_textBox.Size = new System.Drawing.Size(635, 38);
            this.course_id_textBox.TabIndex = 8;
            // 
            // ScoreQueryInputDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 339);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.course_id_textBox);
            this.Controls.Add(this.prompt_2_label);
            this.Controls.Add(this.prompt_label);
            this.Controls.Add(this.student_id_textBox);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.ok_button);
            this.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ScoreQueryInputDialog";
            this.Text = "ScoreQueryInputDialog";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ScoreQueryInputDialog_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Label prompt_2_label;
        private System.Windows.Forms.Label prompt_label;
        private System.Windows.Forms.TextBox student_id_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox course_id_textBox;
    }
}