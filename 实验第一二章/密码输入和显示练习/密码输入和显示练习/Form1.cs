using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 密码输入和显示练习
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBoxPwdInfo.Text = textBoxPwd.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
            if (this.checkBox.Checked == true)
            {
                textBoxPwdInfo.PasswordChar = '\0';
            }
            else {
                textBoxPwdInfo.PasswordChar = '*';
            }
                
        }
    }
}
