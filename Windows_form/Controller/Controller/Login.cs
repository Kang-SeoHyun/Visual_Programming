using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controller
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = "Welcome to kangsii world !!";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = textBox1.Text + " 님 Welcome :>";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = "Try again";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox1.Focus();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
