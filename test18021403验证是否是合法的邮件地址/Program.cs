using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace test18021403验证是否是合法的邮件地址
{
    class Program
    {
        static void Main(string[] args)
        {
            string email = "";
            while (email != "exit")
            {
                Console.WriteLine("请输入Email");
                email = Console.ReadLine();
                //string reg = @"^[a-zA-Z0-9_\.]+@[a-zA-Z0-9]+(\.[a-zA-Z]+)+$";
                string reg = @"^\w+@\w+\.\w+$";
                Console.WriteLine(Regex.IsMatch(email,reg));

            }
        }
    }
}
