using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 实验第三章
{
    class RandomHelp
    {
        public static int GetIntRandomNumber(int min, int max)
        {
            Random r = new Random();
            int ran = r.Next(min, max + 1);

            return ran;
        }
        //很不错的算法
        public static double GetDoubleRandomNumber(int min, int max)
        {
            Random r = new Random();
            //很不错的算法      
            double m = r.NextDouble() * max;
            double n = r.NextDouble() * min;

            if (m - n > 2.0)
                return m;
            else
                return n + 3.0;
        }
    }
}
