using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 实验第三章
{
    public partial class Form2 : Form
    {
        Timer timer = new Timer();
        int zhengshu, shishu;
        public Form2()
        {
            InitializeComponent();
            button1.Click += button1_Click;
            button2.Click += button2_Click;
            //int min, max, interval;
            //min = int.Parse(textBox1.Text);
            //max = int.Parse(textBox2.Text);
            //interval = int.Parse(textBox3.Text);
            //if (radioButton1.Checked = true)//如果选上随机生成整数
            //{

            //}
            //else if (radioButton2.Checked = true)//如果选上随机生成实数
            //{

            //}
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)//如果选上随机生成整数
        {
            RadioButton r = sender as RadioButton;
            if (r.Checked == true)
            {
                zhengshu = 1;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)//如果选上随机生成实数
        {
            RadioButton r = sender as RadioButton;
            if (r.Checked == true)
            {
                shishu = 2;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer.Interval = int.Parse(textBox3.Text);
            timer.Tick += timer1_Tick;
            timer.Start();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (zhengshu == 1)
            {
                int r = (实验第三章.RandomHelp.GetIntRandomNumber(int.Parse(textBox1.Text), int.Parse(textBox2.Text)));
                string s = r.ToString();
                label6.Text = s;
            }
            if (shishu == 2)
            {
                double r = (实验第三章.RandomHelp.GetDoubleRandomNumber(int.Parse(textBox1.Text), int.Parse(textBox2.Text)));
                string s = r.ToString();
                label6.Text = s;
            }
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //https://docs.microsoft.com/zh-tw/dotnet/api/system.drawing.font.size?view=netframework-4.8
            float currentSize = label6.Font.Size;
            currentSize += 6.0F;
            label6.Font = new Font(label6.Font.Name, currentSize,
                label6.Font.Style, label6.Font.Unit);
            timer.Stop();
        }
    }
}
