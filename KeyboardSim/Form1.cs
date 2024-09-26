using System;
using System.IO.Ports;
using System.Net.Http.Headers;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace KeyboardSim
{
    public partial class Form1 : Form
    {
        private bool isSending = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string textToSend = textBox1.Text.Trim();
            isSending = true;
            button1.Enabled = false;
            numericUpDown1.Enabled = false;
            textBox1.Enabled = false;
            numericUpDown2.Enabled = false;
            checkBox1.Enabled = false;

            Thread sendThread = new Thread(() =>
            {
                SendKeystrokes(textToSend, numericUpDown1, numericUpDown2);
                isSending = false;
                Invoke(new Action(() =>
                {
                    button1.Enabled = true;
                    numericUpDown1.Enabled = true;
                    textBox1.Enabled = true;
                    numericUpDown2.Enabled = true;
                    checkBox1.Enabled = true;
                }));
            });
            sendThread.Start();
        }

        private void SendKeystrokes(string text, NumericUpDown numericUpDown, NumericUpDown numericUpDownDelay)
        {
            int delayInSec = (int)numericUpDown.Value;
            for (int i = 0; i < delayInSec; i++)
            {
                UpdateDelayIndicator(delayInSec - (i + 1));
                Thread.Sleep(1000);
            }
            UpdateDelayIndicator(delayInSec);
            foreach (char c in text)
            {
                SendKeys.SendWait(c.ToString());
                Thread.Sleep((int)numericUpDownDelay.Value);
            }
        }

        private void UpdateDelayIndicator(int value)
        {
            if (numericUpDown1.InvokeRequired)
            {
                numericUpDown1.Invoke(new Action(() => numericUpDown1.Value = value));
            }
            else
            {
                numericUpDown1.Value = value;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (((System.Windows.Forms.CheckBox)sender).Checked)
            {
                textBox1.UseSystemPasswordChar = true;
            }
            else
            {
                textBox1.Text = null;
                textBox1.UseSystemPasswordChar = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (((System.Windows.Forms.CheckBox)sender).Checked)
            {
                this.TopMost = true;
            }
            else
            {
                this.TopMost = false;
            }
            
        }
    }
}
