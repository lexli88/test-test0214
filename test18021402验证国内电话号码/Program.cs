using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace test18021402验证国内电话号码
{
    class Program
    {
        static void Main(string[] args)
        {

            //正则表达式中的转义符也是\, 如果要出现一个字符，这个字符又是元字符，这时为了让元字符，系统不为为是元字符，就需要将元字符转义。
            //string reg = @"\\\b";  //   \也要为一个字符，
            //Console.WriteLine(Regex.IsMatch("ax\\\\\\b","ax\\b"));  //   a.b  true   a/b   false??

            //string reg = @"^( (\d{3,4}-?\d{3,8})|(\d{5}) )$";
            //3或4位数字+0或1位-  +  3-8位数字     或者   5位数字
            string reg = @"^((\d{5}|\d{3})|(\d{3,4}-?\d{3,8}))$";
            string phone = "";
            while (phone!="exit")  //当为exit就退出
            {
                Console.WriteLine("请输入一个电话号码:");
                phone = Console.ReadLine();
                Console.WriteLine(Regex.IsMatch(phone, reg));

            }

            Console.ReadLine();
        }
    }
}
