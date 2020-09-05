namespace MIS_for_SCUT
{
    partial class ChooseClassDialog
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
            this.prompt_label = new System.Windows.Forms.Label();
            this.cancel_button = new System.Windows.Forms.Button();
            this.ok_button = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // prompt_label
            // 
            this.prompt_label.AutoSize = true;
            this.prompt_label.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.prompt_label.Location = new System.Drawing.Point(54, 61);
            this.prompt_label.Name = "prompt_label";
            this.prompt_label.Size = new System.Drawing.Size(476, 27);
            this.prompt_label.TabIndex = 8;
            this.prompt_label.Text = "Please choose a class to query its average score: ";
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(405, 182);
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
            this.ok_button.Location = new System.Drawing.Point(94, 182);
            this.ok_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(176, 58);
            this.ok_button.TabIndex = 5;
            this.ok_button.Text = "OK";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("微软雅黑", 13.8F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(59, 114);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(568, 38);
            this.comboBox1.TabIndex = 10;
            // 
            // ChooseClassDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 277);
            this.ControlBox = false;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.prompt_label);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.ok_button);
            this.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChooseClassDialog";
            this.Text = "ChooseClassDialog";
            this.Load += new System.EventHandler(this.ChooseClassDialog_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ChooseClassDialog_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label prompt_label;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}