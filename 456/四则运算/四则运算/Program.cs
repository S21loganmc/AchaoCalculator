using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 四则运算
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Num of question：");
            int x = int.Parse(Console.ReadLine());//确定题目个数

            Console.WriteLine("Range：");
            int y = int.Parse(Console.ReadLine());//运算范围

            MathEz Ca = new MathEz(x, y);
            Ca.Operator();

            Console.WriteLine("Check or not（YorN）：");
            char See = char.Parse(Console.ReadLine());
            if (See == 'Y' || See == 'y')
            {
                Console.WriteLine("Answer Time");
                Ca.SeeResult();
            }
            else
            {
                Console.WriteLine("THX:)");
            }
            string str = Console.ReadLine();
        }
    }
}
