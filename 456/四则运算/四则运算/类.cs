using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 四则运算
{
    public class MathEz
    {
        int x, y;
        double[] Result;
        Random rdm = new Random();
        public MathEz(int x, int y)
        {
            this.x = x;
            this.y = y;
            Result = new double[x];
        }
        public void Operator()
        {
            for (int i = 0; i < x; i++)
            {
                int a = rdm.Next(y) + 1;
                int b = rdm.Next(y) + 1;
                char f = op();
                if (f == '+')
                {
                    Console.WriteLine("{0}、{1} {2} {3} = ", i + 1, a, f, b);
                    Result[i] = a + b;
                }
                else if (f == '-')
                {
                    if (a < b) { a = a + b; b = a - b; a = a - b; } 
                    Console.WriteLine("{0}、{1} {2} {3} = ", i + 1, a, f, b);
                    Result[i] = a - b;
                }
                else if (f == '*')
                {
                    Console.WriteLine("{0}、{1} {2} {3} = ", i + 1, a, f, b);
                    Result[i] = a * b;
                }
                else
                {
                    Console.WriteLine("{0}、{1} {2} {3} = ", i + 1, a, f, b);
                    Result[i] = Math.Round(Convert.ToDouble(a) / b, 3);
                }

            }
        }
        char op()
        {
            int k = rdm.Next(4);
            char r = '+';
            switch (k)
            {
                case 0: r = '+'; break;
                case 1: r = '-'; break;
                case 2: r = '*'; break;
                case 3: r = '/'; break;
            }
            return r;
        }
        public void SeeResult()
        {
            foreach (double i in Result)
            {
                Console.WriteLine(i.ToString());
            }
        }
    }
}
