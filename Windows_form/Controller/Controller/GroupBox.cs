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
    public partial class GroupBox : Form
    {
        public GroupBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String age = "니 나이 : ";

            if (radioButton1.Checked)
                age += radioButton1.Text + "\n";
            if (radioButton2.Checked)
                age += radioButton2.Text + "\n";
            if (radioButton3.Checked)
                age += radioButton3.Text + "\n";
            if (radioButton4.Checked)
                age += radioButton4.Text + "\n";
            if (radioButton5.Checked)
                age += radioButton5.Text + "\n";
            if (radioButton6.Checked)
                age += radioButton6.Text + "\n";

            String str = "";
            if (checkBox1.Checked)
                str += checkBox1.Text + " ";
            if (checkBox2.Checked)
                str += checkBox2.Text + " ";
            if (checkBox3.Checked)
                str += checkBox3.Text + " ";
            if (checkBox4.Checked)
                str += checkBox4.Text + " ";
            if (checkBox5.Checked)
                str += checkBox5.Text + " ";
            if (checkBox6.Checked)
                str += checkBox6.Text + " ";
            if (str == "")
                str += "좋아하는 색이 없니?? \n";
            else
                str += "색 좋아하는 구나??\n";

            label2.Text = age + str;
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }
    }
}
