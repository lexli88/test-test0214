using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace test18021404验证IP地址
{
    class Program
    {
        static void Main(string[] args)
        {
            string ip = "";
            while (ip != "exit")
            {
                Console.WriteLine("请输入一个ip地址");
                ip = Console.ReadLine();

                string regIp = @"^\d{1,3}(\.\d{1,3}){3}$";
                            \d{ 1,3} 表示前面的数字1-3位， (\.\d{ 1,3})表示括号组内以.开头1-3位数字， { 3}表示前面的组出现3次
                    Console.WriteLine(Regex.IsMatch(ip,regIp));

            }

        }
    }
}
