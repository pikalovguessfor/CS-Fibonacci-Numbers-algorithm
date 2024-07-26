using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_app_console
{
    internal class Program
    {
        static long FibonacciCount(long f_num, long s_num)
        {

            long final_num = f_num + s_num;

            return final_num;
        }


        static void Main(string[] args)
        {
            long f_num = 0;
            long s_num = 1;

            while (true)
            {
                f_num = FibonacciCount(f_num, s_num);
                s_num = FibonacciCount(f_num, s_num);


                Console.WriteLine(f_num);
                Console.WriteLine(s_num);
            }
        }
    }
}
