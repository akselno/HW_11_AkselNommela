using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX_01_Timer
{
    public partial class Form1 : Form
    {
        private DateTime currentTime;
        private DateTime endTime = new DateTime(2022, 01, 13, 18, 30, 00, 00);
        private TimeSpan timer;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            currentTime = System.DateTime.Now;
            timer = endTime - currentTime;
            label_timer.Text = timer.ToString();
            if (endTime < currentTime)
            {
                timer1.Enabled = false;
            }
        }

        private void label_timer_Click(object sender, EventArgs e)
        {

        }
    }
}
