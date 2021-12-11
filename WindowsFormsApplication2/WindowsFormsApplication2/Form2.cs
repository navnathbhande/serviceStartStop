using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.ServiceProcess;

namespace WindowsFormsApplication2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void show_button_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            ServiceController[] sc;
            sc = ServiceController.GetServices();

            foreach (ServiceController n in sc)
            {
                listBox1.Items.Add(n.ServiceName);
            }
            count_label.Text = Convert.ToString(listBox1.Items.Count) + " services";

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = listBox1.SelectedItem.ToString();
            ServiceController[] sc;
            sc = ServiceController.GetServices();
            foreach (ServiceController n in sc)
            {
                if (n.ServiceName == textBox1.Text)
                {
                    status_label.Text = n.Status.ToString();
                    if (status_label.Text == "Stopped")
                    {
                        stop_button.Text = "start";
                    }
                    else
                    {
                        stop_button.Text = "stop";
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            count_label.Text = "count=0";
        }

        private void stop_button_Click(object sender, EventArgs e)
        {
            ServiceController[] sc;
            sc = ServiceController.GetServices();
            foreach (ServiceController n in sc)
            {
                if (n.ServiceName == textBox1.Text && stop_button.Text == "start")
                {
                    if ((n.Status.Equals(ServiceControllerStatus.Stopped)) || (n.Status.Equals(ServiceControllerStatus.StopPending)) || n.Status.Equals(ServiceControllerStatus.Paused))
                    {
                        n.Start();
                        status_label.Text = "Running";
                        stop_button.Text = "stop";
                    }
                }
                if (n.ServiceName == textBox1.Text && stop_button.Text == "stop")
                {
                    if ((n.Status.Equals(ServiceControllerStatus.Stopped)) || (n.Status.Equals(ServiceControllerStatus.StopPending)))
                    {

                    }
                    else
                    {
                        n.Stop();
                        status_label.Text = "Stopped";
                        stop_button.Text = "start";
                    }
                }
            }
        }

        private void rfresh_button_Click(object sender, EventArgs e)
        {
            ServiceController[] sc;
            sc = ServiceController.GetServices();
            foreach (ServiceController n in sc)
            {
                if (n.Status.Equals(ServiceControllerStatus.Running))
                {
                    n.Refresh();
                }
            }
        }
    }
}
