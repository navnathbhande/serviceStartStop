using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show();
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            button2.UseVisualStyleBackColor = ResizeRedraw;
        }
        Form2 f = new Form2();
        private void button2_Click(object sender, EventArgs e)
        {
            //if (textBox1.Text == "yoga")
            //{ errorProvider1.SetError(textBox1, "enter value textbox"); }
           
            f.Show();
        }
    }
}
