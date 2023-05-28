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
    public partial class Address : Form
    {
        public Address()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String str = comboBox1.Text + textBox1.Text + "님은 " + comboBox2.Text + "에 사는 중 ~";
            MessageBox.Show(str);
        }
    }
}
