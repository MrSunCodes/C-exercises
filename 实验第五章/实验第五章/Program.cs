using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 实验第五章
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, string> student = new SortedList<int, string>();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("请输入第" + (i + 1) + "个元素的key以及value，中间以回车相隔。");
                int key = Console.Read();
                string value = Console.ReadLine();
                student.Add(key, value);
            }
            for (int i = student.Keys.Count - 1; i >= 0; i--)//从student的最大个数-1开始到0遍历
            {
                Console.WriteLine(student[student.Keys[i]]);//student.Key[i]表示i索引上的key值
            }
        }
    }
}
