using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace test180214验证日期
{
    class Program
    {
        static void Main(string[] args)
        {
            string date = "";
            while (date != "exit")
            {
                Console.WriteLine("请输入日期");
                date = Console.ReadLine();
                string regDate = @"^\d{4}\-\d{1,2}\-\d{1,2}$";
               // string regDate = @"^\d{4}\-\d{1,2}\-\d{1,2}$";
               // 不考虑超过12月，超31日没关系。
                Console.WriteLine(Regex.IsMatch(date, regDate));
            }
        }
    }
}
