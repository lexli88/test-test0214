using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace test18021405验证合法的url地址
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "";
            while (url != "exit")
            {
                Console.WriteLine("请输入一个url地址：");
                url = Console.ReadLine();
                string regUrl = "^[a-zA-Z]+://.+$";
               // string regUrl = "^[a-zA-Z]+://.+$";
                Console.WriteLine(Regex.IsMatch(url,regUrl));
            }
        }
    }
}
