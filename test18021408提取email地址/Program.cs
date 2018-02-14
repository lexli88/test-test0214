using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace test18021408提取email地址
{
    class Program
    {
        static void Main(string[] args)
        {
            string html = File.ReadAllText("1.htm");
            string regEmail = @"([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9]+)(\.[a-zA-Z0-9]+)+";
            MatchCollection mc = Regex.Matches(html, regEmail);
            //  163,sohu,gmail,qq  计算变量
            int count_163 = 0;
            int count_gmail = 0;
            int count_qq = 0;
            int count_hotmail = 0;
            foreach (Match match in mc)//从提取的组中循环遍历出所有组
            {
                Console.WriteLine(match.Groups[0].Value);
                switch (match.Groups[2].Value.ToLower())
                {
                    case "163":
                        count_163++;
                        break;
                    case "gmail":
                        count_gmail++;
                        break;
                    case "qq":
                        count_qq++;
                        break;
                    case "hotmail":
                        count_hotmail++;
                        break;
                }
            }
            Console.WriteLine(mc.Count);
            Console.WriteLine("网易邮箱用户数：{0}",count_163);
            Console.WriteLine("Gmail邮箱用户数：{0}",count_gmail);
            Console.WriteLine("QQ邮箱用户数：{0}",count_qq);
            Console.WriteLine("HotMail邮箱用户数：{0}",count_hotmail);
            Console.ReadLine();
        }
    }
}
