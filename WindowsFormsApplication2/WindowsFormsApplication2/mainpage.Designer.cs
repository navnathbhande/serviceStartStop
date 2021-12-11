namespace WindowsFormsApplication2
{
    partial class mainpage
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
            this.status_label.Location = new System.Drawing.Point(119, 106);
            this.status_label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.status_label.Name = "status_label";
            this.status_label.Size = new System.Drawing.Size(73, 27);
            this.status_label.TabIndex = 16;
            this.status_label.Text = "status";
            // 
            // count_label
            // 
            this.count_label.AutoSize = true;
            this.count_label.Location = new System.Drawing.Point(501, 113);
            this.count_label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.count_label.Name = "count_label";
            this.count_label.Size = new System.Drawing.Size(69, 27);
            this.count_label.TabIndex = 15;
            this.count_label.Text = "count";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(560, 35);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 71);
            this.button1.TabIndex = 14;
            this.button1.Text = "clear all";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(32, 145);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(308, 34);
            this.textBox1.TabIndex = 13;
            // 
            // show_button
            // 
            this.show_button.Location = new System.Drawing.Point(437, 35);
            this.show_button.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.show_button.Name = "show_button";
            this.show_button.Size = new System.Drawing.Size(122, 71);
            this.show_button.TabIndex = 12;
            this.show_button.Text = "show all";
            this.show_button.UseVisualStyleBackColor = true;
            this.show_button.Click += new System.EventHandler(this.show_button_Click);
            // 
            // rfresh_button
            // 
            this.rfresh_button.Location = new System.Drawing.Point(93, 277);
            this.rfresh_button.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.rfresh_button.Name = "rfresh_button";
            this.rfresh_button.Size = new System.Drawing.Size(184, 64);
            this.rfresh_button.TabIndex = 11;
            this.rfresh_button.Text = "Refresh";
            this.rfresh_button.UseVisualStyleBackColor = true;
            this.rfresh_button.Click += new System.EventHandler(this.rfresh_button_Click);
            // 
            // stop_button
            // 
            this.stop_button.Location = new System.Drawing.Point(93, 203);
            this.stop_button.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.stop_button.Name = "stop_button";
            this.stop_button.Size = new System.Drawing.Size(184, 64);
            this.stop_button.TabIndex = 10;
            this.stop_button.Text = "stop";
            this.stop_button.UseVisualStyleBackColor = true;
            this.stop_button.Click += new System.EventHandler(this.stop_button_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 27;
            this.listBox1.Location = new System.Drawing.Point(395, 145);
            this.listBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(303, 301);
            this.listBox1.TabIndex = 9;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // mainpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(753, 451);
            this.Controls.Add(this.status_label);
            this.Controls.Add(this.count_label);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.show_button);
            this.Controls.Add(this.rfresh_button);
            this.Controls.Add(this.stop_button);
            this.Controls.Add(this.listBox1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "mainpage";
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