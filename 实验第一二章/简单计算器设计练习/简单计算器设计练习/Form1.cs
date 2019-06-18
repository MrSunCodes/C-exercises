using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 简单计算器设计练习
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

        private void Jia_CheckedChanged(object sender, EventArgs e)
        {
            if(plus.Checked==true)
            {
                Method.Text = "加法";
                symbol.Text = "+";
                input1.Clear();
                input2.Clear();
                sum.Clear();
            }
        }

        private void Jian_CheckedChanged(object sender, EventArgs e)
        {
            if (substraction.Checked == true)
            {
                Method.Text = "减法";
                symbol.Text = "-";
                input1.Clear();
                input2.Clear();
                sum.Clear();

            }
        }

        private void Cheng_CheckedChanged(object sender, EventArgs e)
        {
            if (mutplait.Checked == true)
            {
                Method.Text = "乘法";
                symbol.Text = "*";
                input1.Clear();
                input2.Clear();
                sum.Clear();
            }
        }

        private void Chu_CheckedChanged(object sender, EventArgs e)
        {
            if (divide.Checked == true)
            {
                Method.Text = "除法";
                symbol.Text = "/";
                input1.Clear();
                input2.Clear();
                sum.Clear();
            }
        }

        private void Yu_CheckedChanged(object sender, EventArgs e)
        {
            if (qumo.Checked == true)
            {
                Method.Text = "取模";
                symbol.Text = "%";
                input1.Clear();
                input2.Clear();
                sum.Clear();
            }
        }

        private void diyi_TextChanged(object sender, EventArgs e)
        {

        }

        private void dier_TextChanged(object sender, EventArgs e)
        {

        }

        private void jieguo_TextChanged(object sender, EventArgs e)
        {

        }

        private void jisuan_Click(object sender, EventArgs e)
        {
            if(symbol.Text=="+")
            {
                float a = float.Parse(input1.Text);
                float b = float.Parse(input2.Text);
                string s = (a + b).ToString();
                sum.Text = s;

            }
            if (symbol.Text == "-")
            {
                float a = float.Parse(input1.Text);
                float b = float.Parse(input2.Text);
                string s = (a - b).ToString();
                sum.Text = s;
            }
            if (symbol.Text == "*")
            {
                float a = float.Parse(input1.Text);
                float b = float.Parse(input2.Text);
                string s = (a * b).ToString();
                sum.Text = s;
            }
            if (symbol.Text == "/")
            {
                float a = float.Parse(input1.Text);
                float b = float.Parse(input2.Text);
                string s = (a / b).ToString();
                sum.Text = s;
            }
            if (symbol.Text == "%")
            {
                float a = float.Parse(input1.Text);
                float b = float.Parse(input2.Text);
                string s = (a % b).ToString();
                sum.Text = s;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Method_Enter(object sender, EventArgs e)
        {

        }
    }
}
