using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace test18021407字符串提取
{
    class Program
    {
        static void Main(string[] args)
        {
            string msg = "大家好，hello,2010年10月10日是个好日子，恩，98383，模压sdf988as0dfkjp";
            //从上面的字符串中提取出所有的数字
            string regNumber = @"\d+";
            MatchCollection matches = Regex.Matches(msg, regNumber);
            foreach (Match mt in matches)
            {
                Console.WriteLine(mt.Value);
           }
            Console.ReadLine();
        }
    }
}
