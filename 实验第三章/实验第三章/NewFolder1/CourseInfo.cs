using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 实验第三章.NewFolder1
{
    enum Time
    {
        春季,
        秋季,
    };
    class CourseInfo
    {
        public string CourseName;
        public Time CourseTime;
        public string BookName;
        public int price;
        public static int Counter = 0;
        public CourseInfo()
        {
            Counter++;
        }
        public CourseInfo(string CourseName, Time CourseTime, string BookName, int price)
        {
            Counter++;
            this.CourseName = CourseName;
            this.CourseTime = CourseTime;
            this.BookName = BookName;
            this.price = price;
        }
        public string print()
        {
            return this.CourseName + "\t  " + this.CourseTime + "\t     " + this.BookName + "\t " + this.price;
        }
    }
}
