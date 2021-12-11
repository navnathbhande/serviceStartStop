namespace WindowsFormsApplication2
{
    partial class Form2
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
            this.status_label = new System.Windows.Forms.Label();
            this.count_label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.show_button = new System.Windows.Forms.Button();
            this.rfresh_button = new System.Windows.Forms.Button();
            this.stop_button = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.SuspendLayout();
            // 
            // status_label
            // 
            this.status_label.AutoSize = true;
            this.status_label.ForeColor = System.Drawing.Color.Blue;
            this.status_label.Location = new System.Drawing.Point(75, 108);
            this.status_label.Name = "status_label";
            this.status_label.Size = new System.Drawing.Size(46, 17);
            this.status_label.TabIndex = 16;
            this.status_label.Text = "status";
            // 
            // count_label
            // 
            this.count_label.AutoSize = true;
            this.count_label.Location = new System.Drawing.Point(426, 63);
            this.count_label.Name = "count_label";
            this.count_label.Size = new System.Drawing.Size(43, 17);
            this.count_label.TabIndex = 15;
            this.count_label.Text = "count";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(622, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 42);
            this.button1.TabIndex = 14;
            this.button1.Text = "clear all";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(31, 154);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 22);
            this.textBox1.TabIndex = 13;
            // 
            // show_button
            // 
            this.show_button.Location = new System.Drawing.Point(269, 21);
            this.show_button.Name = "show_button";
            this.show_button.Size = new System.Drawing.Size(75, 42);
            this.show_button.TabIndex = 12;
            this.show_button.Text = "show all";
            this.show_button.UseVisualStyleBackColor = true;
            this.show_button.Click += new System.EventHandler(this.show_button_Click);
            // 
            // rfresh_button
            // 
            this.rfresh_button.Location = new System.Drawing.Point(69, 238);
            this.rfresh_button.Name = "rfresh_button";
            this.rfresh_button.Size = new System.Drawing.Size(113, 38);
            this.rfresh_button.TabIndex = 11;
            this.rfresh_button.Text = "Refresh";
            this.rfresh_button.UseVisualStyleBackColor = true;
            this.rfresh_button.Click += new System.EventHandler(this.rfresh_button_Click);
            // 
            // stop_button
            // 
            this.stop_button.Location = new System.Drawing.Point(69, 194);
            this.stop_button.Name = "stop_button";
            this.stop_button.Size = new System.Drawing.Size(113, 38);
            this.stop_button.TabIndex = 10;
            this.stop_button.Text = "stop";
            this.stop_button.UseVisualStyleBackColor = true;
            this.stop_button.Click += new System.EventHandler(this.stop_button_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(243, 86);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(487, 292);
            this.listBox1.TabIndex = 9;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 512);
            this.Controls.Add(this.status_label);
            this.Controls.Add(this.count_label);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.show_button);
            this.Controls.Add(this.rfresh_button);
            this.Controls.Add(this.stop_button);
            this.Controls.Add(this.listBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label status_label;
        private System.Windows.Forms.Label count_label;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button show_button;
        private System.Windows.Forms.Button rfresh_button;
        private System.Windows.Forms.Button stop_button;
        private System.Windows.Forms.ListBox listBox1;
        private System.ServiceProcess.ServiceController serviceController1;
    }
}