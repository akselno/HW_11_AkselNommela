using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX_03_FlyingLabel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool movementTopLeftToBottomLeftAndToBottomRight = true;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (movementTopLeftToBottomLeftAndToBottomRight)
            {
                if (label_flying.Top < ClientSize.Height - 100)
                {
                    label_flying.Top += 60;
                }
                else if (label_flying.Left < ClientSize.Width - 100)
                {
                    label_flying.Left += 60;
                }
                else
                {
                    movementTopLeftToBottomLeftAndToBottomRight = false;
                }
            }
            else
            {
                if (label_flying.Top > 100)
                {
                    label_flying.Top -= 60;
                }
                else if (label_flying.Left > 100)
                {
                    label_flying.Left -= 60;
                }
                else
                {
                    movementTopLeftToBottomLeftAndToBottomRight = true;
                }
            }
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
