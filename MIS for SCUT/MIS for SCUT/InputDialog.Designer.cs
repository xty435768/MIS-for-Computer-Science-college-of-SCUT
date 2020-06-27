namespace MIS_for_SCUT
{
    partial class InputDialog
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.prompt_label = new System.Windows.Forms.Label();
            this.prompt_2_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ok_button
            // 
            this.ok_button.Location = new System.Drawing.Point(85, 207);
            this.ok_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(176, 58);
            this.ok_button.TabIndex = 0;
            this.ok_button.Text = "OK";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(396, 207);
            this.cancel_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(176, 58);
            this.cancel_button.TabIndex = 1;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(50, 139);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(562, 38);
            this.textBox1.TabIndex = 2;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // prompt_label
            // 
            this.prompt_label.AutoSize = true;
            this.prompt_label.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.prompt_label.Location = new System.Drawing.Point(45, 59);
            this.prompt_label.Name = "prompt_label";
            this.prompt_label.Size = new System.Drawing.Size(183, 27);
            this.prompt_label.TabIndex = 3;
            this.prompt_label.Text = "(Set prompt here)";
            // 
            // prompt_2_label
            // 
            this.prompt_2_label.AutoSize = true;
            this.prompt_2_label.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.prompt_2_label.Location = new System.Drawing.Point(45, 99);
            this.prompt_2_label.Name = "prompt_2_label";
            this.prompt_2_label.Size = new System.Drawing.Size(197, 20);
            this.prompt_2_label.TabIndex = 4;
            this.prompt_2_label.Text = "(Set second prompt here)";
            // 
            // InputDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 288);
            this.ControlBox = false;
            this.Controls.Add(this.prompt_2_label);
            this.Controls.Add(this.prompt_label);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.ok_button);
            this.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InputDialog";
            this.Text = "InputDialog";
            this.Load += new System.EventHandler(this.InputDialog_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputDialog_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label prompt_label;
        private System.Windows.Forms.Label prompt_2_label;
    }
}