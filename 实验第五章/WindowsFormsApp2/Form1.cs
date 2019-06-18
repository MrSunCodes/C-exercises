using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        class Person
        {
            public string name { get; set; }
            public int age { get; set; }
            public string telenum { get; set; }
            public string Print()
            {
                return this.name + "\t\t" + this.age + "\t\t" + this.telenum;
            }
        }
        List<Person> list = new List<Person>()
        {
            new Person{name="张三丰",age=21,telenum="13037853201" },
            new Person{name="李四明",age=18,telenum="13537812345" },
            new Person{name="赵六方",age=19,telenum="15228680218" },
            new Person{name="王五新",age=20,telenum="15222873156" },
            new Person{name="李一鸣",age=26,telenum="15923456798" }
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                this.listBox1.Items.Clear();
                this.listBox1.Items.Add("姓名\t\t年龄\t\t手机号码");
                var q = from s in list
                        select s;
                foreach (var v in q)
                {
                    this.listBox1.Items.Add(v.Print());
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                this.listBox1.Items.Clear();
                this.listBox1.Items.Add("姓名\t\t年龄\t\t手机号码");
                var q = from s in list
                        where s.age >= 18 && s.age <= 25
                        select s;
                foreach (var v in q)
                {
                    this.listBox1.Items.Add(v.Print());
                }
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                this.listBox1.Items.Clear();
                this.listBox1.Items.Add("姓名\t\t年龄\t\t手机号码");
                var q = from s in list
                        where s.name[0] == '李'
                        select s;
                foreach (var v in q)
                {
                    this.listBox1.Items.Add(v.Print());
                }
            }
        }
    }

    
}

