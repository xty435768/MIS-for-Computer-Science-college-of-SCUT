namespace MIS_for_SCUT
{
    partial class Add_Account
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
            this.batch_add_page = new System.Windows.Forms.TabControl();
            this.single_add_page = new System.Windows.Forms.TabPage();
            this.sex_comboBox = new System.Windows.Forms.ComboBox();
            this.add_button = new System.Windows.Forms.Button();
            this.class_textBox = new System.Windows.Forms.TextBox();
            this.class_label = new System.Windows.Forms.Label();
            this.age_textbox = new System.Windows.Forms.TextBox();
            this.year_label = new System.Windows.Forms.Label();
            this.year_textbox = new System.Windows.Forms.TextBox();
            this.age_label = new System.Windows.Forms.Label();
            this.sex_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.id_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.teacher_radioButton = new System.Windows.Forms.RadioButton();
            this.student_radioButton = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.progress_label = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.batch_add_button = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.open_csv = new System.Windows.Forms.Button();
            this.save_template = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.batch_add_page.SuspendLayout();
            this.single_add_page.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // batch_add_page
            // 
            this.batch_add_page.Controls.Add(this.single_add_page);
            this.batch_add_page.Controls.Add(this.tabPage2);
            this.batch_add_page.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.batch_add_page.Location = new System.Drawing.Point(0, 0);
            this.batch_add_page.Name = "batch_add_page";
            this.batch_add_page.SelectedIndex = 0;
            this.batch_add_page.Size = new System.Drawing.Size(746, 705);
            this.batch_add_page.TabIndex = 0;
            // 
            // single_add_page
            // 
            this.single_add_page.Controls.Add(this.sex_comboBox);
            this.single_add_page.Controls.Add(this.add_button);
            this.single_add_page.Controls.Add(this.class_textBox);
            this.single_add_page.Controls.Add(this.class_label);
            this.single_add_page.Controls.Add(this.age_textbox);
            this.single_add_page.Controls.Add(this.year_label);
            this.single_add_page.Controls.Add(this.year_textbox);
            this.single_add_page.Controls.Add(this.age_label);
            this.single_add_page.Controls.Add(this.sex_label);
            this.single_add_page.Controls.Add(this.label3);
            this.single_add_page.Controls.Add(this.name_textbox);
            this.single_add_page.Controls.Add(this.label2);
            this.single_add_page.Controls.Add(this.id_textbox);
            this.single_add_page.Controls.Add(this.label1);
            this.single_add_page.Controls.Add(this.teacher_radioButton);
            this.single_add_page.Controls.Add(this.student_radioButton);
            this.single_add_page.Location = new System.Drawing.Point(4, 33);
            this.single_add_page.Name = "single_add_page";
            this.single_add_page.Padding = new System.Windows.Forms.Padding(3);
            this.single_add_page.Size = new System.Drawing.Size(738, 668);
            this.single_add_page.TabIndex = 0;
            this.single_add_page.Text = "Single Add";
            this.single_add_page.UseVisualStyleBackColor = true;
            // 
            // sex_comboBox
            // 
            this.sex_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sex_comboBox.FormattingEnabled = true;
            this.sex_comboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.sex_comboBox.Location = new System.Drawing.Point(219, 236);
            this.sex_comboBox.Name = "sex_comboBox";
            this.sex_comboBox.Size = new System.Drawing.Size(218, 32);
            this.sex_comboBox.TabIndex = 4;
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(133, 579);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(439, 52);
            this.add_button.TabIndex = 15;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // class_textBox
            // 
            this.class_textBox.Location = new System.Drawing.Point(219, 494);
            this.class_textBox.Name = "class_textBox";
            this.class_textBox.Size = new System.Drawing.Size(466, 31);
            this.class_textBox.TabIndex = 7;
            // 
            // class_label
            // 
            this.class_label.AutoSize = true;
            this.class_label.Location = new System.Drawing.Point(23, 497);
            this.class_label.Name = "class_label";
            this.class_label.Size = new System.Drawing.Size(70, 25);
            this.class_label.TabIndex = 14;
            this.class_label.Text = "Class: ";
            // 
            // age_textbox
            // 
            this.age_textbox.Location = new System.Drawing.Point(219, 316);
            this.age_textbox.Name = "age_textbox";
            this.age_textbox.Size = new System.Drawing.Size(466, 31);
            this.age_textbox.TabIndex = 5;
            // 
            // year_label
            // 
            this.year_label.AutoSize = true;
            this.year_label.Location = new System.Drawing.Point(23, 397);
            this.year_label.Name = "year_label";
            this.year_label.Size = new System.Drawing.Size(149, 25);
            this.year_label.TabIndex = 13;
            this.year_label.Text = "Entrance Year: ";
            // 
            // year_textbox
            // 
            this.year_textbox.Location = new System.Drawing.Point(219, 394);
            this.year_textbox.Name = "year_textbox";
            this.year_textbox.Size = new System.Drawing.Size(466, 31);
            this.year_textbox.TabIndex = 6;
            // 
            // age_label
            // 
            this.age_label.AutoSize = true;
            this.age_label.Location = new System.Drawing.Point(23, 319);
            this.age_label.Name = "age_label";
            this.age_label.Size = new System.Drawing.Size(145, 25);
            this.age_label.TabIndex = 12;
            this.age_label.Text = "Entrance Age: ";
            // 
            // sex_label
            // 
            this.sex_label.AutoSize = true;
            this.sex_label.Location = new System.Drawing.Point(23, 239);
            this.sex_label.Name = "sex_label";
            this.sex_label.Size = new System.Drawing.Size(55, 25);
            this.sex_label.TabIndex = 11;
            this.sex_label.Text = "Sex: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Name: ";
            // 
            // name_textbox
            // 
            this.name_textbox.Location = new System.Drawing.Point(219, 153);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(466, 31);
            this.name_textbox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "ID: ";
            // 
            // id_textbox
            // 
            this.id_textbox.Location = new System.Drawing.Point(219, 81);
            this.id_textbox.Name = "id_textbox";
            this.id_textbox.Size = new System.Drawing.Size(466, 31);
            this.id_textbox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Role: ";
            // 
            // teacher_radioButton
            // 
            this.teacher_radioButton.AutoSize = true;
            this.teacher_radioButton.Location = new System.Drawing.Point(528, 28);
            this.teacher_radioButton.Name = "teacher_radioButton";
            this.teacher_radioButton.Size = new System.Drawing.Size(106, 29);
            this.teacher_radioButton.TabIndex = 1;
            this.teacher_radioButton.Text = "Teacher";
            this.teacher_radioButton.UseVisualStyleBackColor = true;
            // 
            // student_radioButton
            // 
            this.student_radioButton.AutoSize = true;
            this.student_radioButton.Checked = true;
            this.student_radioButton.Location = new System.Drawing.Point(270, 28);
            this.student_radioButton.Name = "student_radioButton";
            this.student_radioButton.Size = new System.Drawing.Size(105, 29);
            this.student_radioButton.TabIndex = 0;
            this.student_radioButton.TabStop = true;
            this.student_radioButton.Text = "Student";
            this.student_radioButton.UseVisualStyleBackColor = true;
            this.student_radioButton.CheckedChanged += new System.EventHandler(this.student_radioButton_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.progress_label);
            this.tabPage2.Controls.Add(this.progressBar1);
            this.tabPage2.Controls.Add(this.batch_add_button);
            this.tabPage2.Controls.Add(this.dgv);
            this.tabPage2.Controls.Add(this.open_csv);
            this.tabPage2.Controls.Add(this.save_template);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(738, 668);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Batch Add";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // progress_label
            // 
            this.progress_label.AutoSize = true;
            this.progress_label.Location = new System.Drawing.Point(636, 500);
            this.progress_label.Name = "progress_label";
            this.progress_label.Size = new System.Drawing.Size(0, 25);
            this.progress_label.TabIndex = 6;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(23, 490);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(590, 46);
            this.progressBar1.TabIndex = 5;
            // 
            // batch_add_button
            // 
            this.batch_add_button.Location = new System.Drawing.Point(135, 584);
            this.batch_add_button.Name = "batch_add_button";
            this.batch_add_button.Size = new System.Drawing.Size(439, 52);
            this.batch_add_button.TabIndex = 4;
            this.batch_add_button.Text = "Add";
            this.batch_add_button.UseVisualStyleBackColor = true;
            this.batch_add_button.Click += new System.EventHandler(this.batch_add_button_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(23, 141);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowTemplate.Height = 27;
            this.dgv.Size = new System.Drawing.Size(689, 314);
            this.dgv.TabIndex = 3;
            this.dgv.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_DataBindingComplete);
            // 
            // open_csv
            // 
            this.open_csv.Location = new System.Drawing.Point(451, 72);
            this.open_csv.Name = "open_csv";
            this.open_csv.Size = new System.Drawing.Size(241, 47);
            this.open_csv.TabIndex = 2;
            this.open_csv.Text = "Open CSV...";
            this.open_csv.UseVisualStyleBackColor = true;
            this.open_csv.Click += new System.EventHandler(this.open_csv_Click);
            // 
            // save_template
            // 
            this.save_template.Location = new System.Drawing.Point(29, 72);
            this.save_template.Name = "save_template";
            this.save_template.Size = new System.Drawing.Size(241, 47);
            this.save_template.TabIndex = 1;
            this.save_template.Text = "Save Template...";
            this.save_template.UseVisualStyleBackColor = true;
            this.save_template.Click += new System.EventHandler(this.save_template_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(550, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Currently only supports batch adding student information.";
            // 
            // Add_Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 698);
            this.Controls.Add(this.batch_add_page);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Add_Account";
            this.Text = "Add_Account";
            this.batch_add_page.ResumeLayout(false);
            this.single_add_page.ResumeLayout(false);
            this.single_add_page.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl batch_add_page;
        private System.Windows.Forms.TabPage single_add_page;
        private System.Windows.Forms.ComboBox sex_comboBox;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.TextBox class_textBox;
        private System.Windows.Forms.Label class_label;
        private System.Windows.Forms.TextBox age_textbox;
        private System.Windows.Forms.Label year_label;
        private System.Windows.Forms.TextBox year_textbox;
        private System.Windows.Forms.Label age_label;
        private System.Windows.Forms.Label sex_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox id_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton teacher_radioButton;
        private System.Windows.Forms.RadioButton student_radioButton;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button save_template;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button open_csv;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button batch_add_button;
        private System.Windows.Forms.Label progress_label;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}