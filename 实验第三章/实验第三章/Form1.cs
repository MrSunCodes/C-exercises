using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 实验第三章.NewFolder1;

namespace 实验第三章
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CourseInfo course1 = new CourseInfo();
            CourseInfo course2 = new CourseInfo("数据结构", Time.春季, "《数据结构》", 40);
            CourseInfo course3 = new CourseInfo("操作系统", Time.秋季, "《操作系统》", 45);
            CourseInfo course4 = new CourseInfo("软件工程", Time.春季, "《软件工程》", 38);
            this.listBox1.Items.Add(" 课程名\t\t开课时间\t课程书\t\t价格");
            this.listBox1.Items.Add(course2.print());
            this.listBox1.Items.Add(course3.print());
            this.listBox1.Items.Add(course4.print());
           
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            


        }



    }
}
