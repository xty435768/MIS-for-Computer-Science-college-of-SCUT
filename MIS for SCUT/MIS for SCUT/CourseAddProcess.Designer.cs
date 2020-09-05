namespace MIS_for_SCUT
{
    partial class CourseAddProcess
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progress_label = new System.Windows.Forms.Label();
            this.add_button = new System.Windows.Forms.Button();
            this.school_year_label = new System.Windows.Forms.Label();
            this.semester_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 118);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowTemplate.Height = 27;
            this.dgv.Size = new System.Drawing.Size(737, 338);
            this.dgv.TabIndex = 0;
            this.dgv.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_DataBindingComplete);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "The following course info will be added:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 491);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(610, 34);
            this.progressBar1.TabIndex = 2;
            // 
            // progress_label
            // 
            this.progress_label.AutoSize = true;
            this.progress_label.Location = new System.Drawing.Point(658, 509);
            this.progress_label.Name = "progress_label";
            this.progress_label.Size = new System.Drawing.Size(0, 25);
            this.progress_label.TabIndex = 3;
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(284, 553);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(207, 47);
            this.add_button.TabIndex = 4;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // school_year_label
            // 
            this.school_year_label.AutoSize = true;
            this.school_year_label.Location = new System.Drawing.Point(12, 35);
            this.school_year_label.Name = "school_year_label";
            this.school_year_label.Size = new System.Drawing.Size(67, 25);
            this.school_year_label.TabIndex = 5;
            this.school_year_label.Text = "label2";
            // 
            // semester_label
            // 
            this.semester_label.AutoSize = true;
            this.semester_label.Location = new System.Drawing.Point(290, 35);
            this.semester_label.Name = "semester_label";
            this.semester_label.Size = new System.Drawing.Size(67, 25);
            this.semester_label.TabIndex = 6;
            this.semester_label.Text = "label2";
            // 
            // CourseAddProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 633);
            this.Controls.Add(this.semester_label);
            this.Controls.Add(this.school_year_label);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.progress_label);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv);
            this.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CourseAddProcess";
            this.Text = "CourseAddProcess";
            this.Load += new System.EventHandler(this.CourseAddProcess_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label progress_label;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Label school_year_label;
        private System.Windows.Forms.Label semester_label;
    }
}