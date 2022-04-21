using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX_04_CountdownTimer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int seconds;
        private int minutes;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (seconds == 0 && minutes == 0)
            {
                timer1.Stop();

                textBox_timer.Text = "00:00";
                textBox_timer.ForeColor = Color.Red;
            }
            else if (seconds <= 60 && seconds >= 0)
            {
                if (minutes > 0 && seconds == 0)
                {
                    textBox_timer.Text = TimerText();
                    minutes--;
                    seconds = 60;
                }
                seconds--;
                textBox_timer.Text = TimerText();
            }
        }

        public string TimerText()
        {
            if (seconds < 10 && minutes < 10)
            {
                return $"0{minutes}:0{seconds}";
            }
            else if (seconds >= 10 && minutes < 10)
            {
                return $"0{minutes}:{seconds}";
            }
            else if (seconds < 10 && minutes >= 10)
            {
                return $"{minutes}:0{seconds}";
            }
            else
            {
                return $"{minutes}:{seconds}";
            }
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            try
            {
                string timerText = textBox_timer.Text;
                char colon = timerText[timerText.Length - 3];
                string colonAsString = colon.ToString();
                string secondsAsString = timerText.Substring(timerText.Length - 2, 2);
                string minutesAsString = timerText.Substring(0, timerText.Length - 3);
                seconds = int.Parse(secondsAsString);
                minutes = int.Parse(minutesAsString);
                if (timerText.Length >= 5 && colonAsString == ":" && seconds <= 60)
                {
                    timer1.Start();
                    textBox_timer.ForeColor = Color.Black;
                    label_checkErrors.Visible = false;
                }
                else
                {
                    label_checkErrors.Visible = true;
                    label_checkErrors.ForeColor = Color.Red;
                    label_checkErrors.Text = "Incorrect format!";
                }
            }
            catch
            {
                label_checkErrors.Visible = true;
                label_checkErrors.ForeColor = Color.Red;
                label_checkErrors.Text = "Incorrect format!";
            } //ma saan aru, et siin koodiduplikatsioon, aga ma ei suutnud välja mõelda, kuidas neid korrektselt kokku panna.
        }

        private void textBox_timer_TextChanged(object sender, EventArgs e)
        {
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            textBox_timer.Text = "00:00";
            seconds = 00;
            minutes = 00;
            textBox_timer.ForeColor= Color.Black;
            label_checkErrors.Visible = false;
        }
    }
}
