using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example03
{
    class Program
    {
        static void Main(string[] args)
        {
            string html =
                @"<html>
                <body></body>
                </html>";
            Console.WriteLine(html);
            string path = "c:\\xampp\\file";
            //雙斜是跳脫字元 直接打@比較直覺
            Console.WriteLine(path);
        }
    }
}
