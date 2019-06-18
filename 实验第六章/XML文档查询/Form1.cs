using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace XML文档查询
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //textBOx2是查询分数
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //textBOx1是显示
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //button1是查询
            //创建xml
            XElement xTree = new XElement("CScore",
                                new XElement("StuID",
                                  new XElement("name", "zhangsan"),
                                  new XElement("score", 86)
                                ),
                                new XElement("StuID",
                                  new XElement("name", "lisi"),
                                  new XElement("score", 87)
                                ),
                                new XElement("StuID",
                                  new XElement("name", "wangwu"),
                                  new XElement("score", 87)
                                ),
                                new XElement("StuID",
                                  new XElement("name", "liuqi"),
                                  new XElement("score", 88)
                                ),
                                new XElement("StuID",
                                  new XElement("name", "zhangba"),
                                  new XElement("score", 87)
                                )
                            );
            xTree.Save(@"\text.xml");
            string grade = textBox2.Text;//读出的分数
            XElement CScore = null;//新建的xml文档读取变量，将xml文档读入进去
            CScore = XElement.Load(@"\text.xml");//读入操作
            var query1 = from x in CScore.Elements("StuID")
                         select x;
            var query2 = from temp in query1
                         where (string)temp.Element("score") == grade
                         select temp.Element("name");
            foreach (var t in query2)
            {
                this.listBox1.Items.Add(t.Value.ToString());
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
