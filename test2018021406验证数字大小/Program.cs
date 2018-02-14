using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace test2018021406验证数字大小
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = "";
            while (number != "exit")
            {
                Console.WriteLine("请输入一个数字，大于10并且小于30：");
                number = Console.ReadLine();
                string regNumber = "^[1-2][1-9]$";
                Console.WriteLine(Regex.IsMatch(number,regNumber));
            }
        }
    }
}
