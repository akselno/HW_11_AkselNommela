using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX_2_UserNamePassword
{
    
    public partial class Form1 : Form
    {
        private string username = "axupaxu";
        private string password = "joukrae123";

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            if (textBox_password.Text == password && textBox_username.Text == username)
            {
                label3.ForeColor = Color.Green;
                label3.Text = "Correct!";
            }
            else
            {
                label3.ForeColor = Color.Red;
                label3.Text = "Wrong username or password.";
            }
        }

        private void textBox_password_TextChanged(object sender, EventArgs e)
        {
            textBox_password.UseSystemPasswordChar = true;
        }
    }
}
