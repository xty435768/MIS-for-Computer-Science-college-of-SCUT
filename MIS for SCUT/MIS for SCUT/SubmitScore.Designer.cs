namespace MIS_for_SCUT
{
    partial class SubmitScore
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
            this.show_teacher_id_label = new System.Windows.Forms.Label();
            this.show_teacher_name_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.course_comboBox = new SergeUtils.EasyCompletionComboBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.year_comboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // show_teacher_id_label
            // 
            this.show_teacher_id_label.AutoSize = true;
            this.show_teacher_id_label.Location = new System.Drawing.Point(42, 25);
            this.show_teacher_id_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.show_teacher_id_label.Name = "show_teacher_id_label";
            this.show_teacher_id_label.Size = new System.Drawing.Size(227, 25);
            this.show_teacher_id_label.TabIndex = 0;
            this.show_teacher_id_label.Text = "Current teacher ID: null";
            // 
            // show_teacher_name_label
            // 
            this.show_teacher_name_label.AutoSize = true;
            this.show_teacher_name_label.Location = new System.Drawing.Point(670, 25);
            this.show_teacher_name_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.show_teacher_name_label.Name = "show_teacher_name_label";
            this.show_teacher_name_label.Size = new System.Drawing.Size(259, 25);
            this.show_teacher_name_label.TabIndex = 1;
            this.show_teacher_name_label.Text = "Current teacher name: null";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose course: ";
            // 
            // course_comboBox
            // 
            this.course_comboBox.FormattingEnabled = true;
            this.course_comboBox.Location = new System.Drawing.Point(231, 68);
            this.course_comboBox.Name = "course_comboBox";
            this.course_comboBox.Size = new System.Drawing.Size(395, 32);
            this.course_comboBox.TabIndex = 4;
            this.course_comboBox.TextChanged += new System.EventHandler(this.course_comboBox_TextChanged);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(47, 115);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowTemplate.Height = 27;
            this.dgv.Size = new System.Drawing.Size(901, 430);
            this.dgv.TabIndex = 5;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // year_comboBox
            // 
            this.year_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.year_comboBox.FormattingEnabled = true;
            this.year_comboBox.Location = new System.Drawing.Point(840, 68);
            this.year_comboBox.Name = "year_comboBox";
            this.year_comboBox.Size = new System.Drawing.Size(108, 32);
            this.year_comboBox.TabIndex = 6;
            this.year_comboBox.TextChanged += new System.EventHandler(this.year_comboBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(670, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Chosen year:";
            // 
            // SubmitScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 557);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.year_comboBox);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.course_comboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.show_teacher_name_label);
            this.Controls.Add(this.show_teacher_id_label);
            this.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SubmitScore";
            this.Text = "Submit Score";
            this.Load += new System.EventHandler(this.SubmitScore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label show_teacher_id_label;
        private System.Windows.Forms.Label show_teacher_name_label;
        private System.Windows.Forms.Label label1;
        private SergeUtils.EasyCompletionComboBox course_comboBox;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.ComboBox year_comboBox;
        private System.Windows.Forms.Label label2;
    }
}