using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 实验第六章
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)//文件路径是box2
        {

        }

        private void button3_Click(object sender, EventArgs e)//浏览
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                string file = ofd.FileName;
                this.textBox2.Text = file;
            }
        }

        private void button1_Click(object sender, EventArgs e)//读取
        {
            string path = this.textBox2.Text;
            if (!File.Exists(path))
            {
                MessageBox.Show("文件不存在！");
                this.textBox1.Text = "";
                this.textBox2.Text = "";
            }
            else  this.textBox1.Text = File.ReadAllText(path, Encoding.Default);
        }

        private void button2_Click(object sender, EventArgs e)//保存
        {
            string path = this.textBox2.Text;
            //一定加Encoding.GetEncoding("gb2312")不然写入文件时会乱码
            StreamWriter sw = new StreamWriter(path, false, Encoding.GetEncoding("gb2312"));//创建StreamWriter对象sw
            sw.Write(this.textBox1.Text);//把this.textBox1.Text这字符串写入到 sw里
            sw.Dispose();//释放流。
            this.textBox1.Text = "";//最后需要清空
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
