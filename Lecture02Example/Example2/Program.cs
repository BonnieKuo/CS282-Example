﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(1.0 / 2.0 * 3.0);
            Console.WriteLine(1 / 2 * 3.0);
            Console.WriteLine(1 / 2.0 * 3.0);
            //遇到加減乘除一定要補整數的.0
        }
    }
}