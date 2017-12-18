using System;
using System.Windows.Forms;
using System.Threading;

namespace GetGuidForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getGuidNotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string guid=GuidOperations.GuidGenerator();
            if (UpperCaseCheckBox.Checked)
            {
                guid = guid.ToUpper();
            }
            textBox1.AppendText(guid);
            textBox1.AppendText(Environment.NewLine);
        }

        private void GetGuidExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            string guid = GuidOperations.GuidGenerator();
            if (UpperCaseCheckBox.Checked)
            {
                guid = guid.ToUpper();
            }
            
            textBox1.AppendText(guid);
            textBox1.AppendText(Environment.NewLine);
            button1.Enabled = true;
        }
    }
}
