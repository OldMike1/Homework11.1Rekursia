using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework11._1Rekursia
{
    class Program
    {
        static void GetKvadrat(int x1, int y1, int x2, int y2, int p, int m)
        {

            if (x1 != x2)
            {
                GetKvadrat(x1 = x1 + 1, y1, x2, y2, p, m);
                Console.SetCursorPosition(x1, y1);
                Console.Write("*");
            }
            else if (y1 != y2)
            {
                GetKvadrat(x1, y1 = y1 + 1, x2, y2, p, m);
                Console.SetCursorPosition(x1, y1);
                Console.Write("*");
            }
            else if (m != y2)
            {
                GetKvadrat(x1, y1, x2, y2, p, m += 1);
                Console.SetCursorPosition(p, m);
                Console.Write("*");
            }
            else if (p != x2)
            {
                GetKvadrat(x1, y1, x2, y2, p += 1, m);
                Console.SetCursorPosition(p, m);
                Console.Write("*");
            }
            else
                return;
        }



        static void Main(string[] args)
        {

            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            int p = x1 + 1;
            int m = y1;

            if (x1 < x2 && y1 < y2)
            {
                GetKvadrat(x1, y1, x2, y2, p, m);
            }
            else if (x1 > x2 && y1 < y2)
            {
                p = x2 + 1;
                GetKvadrat(x2, y1, x1, y2, p, m);
            }
            else if (x1 < x2 && y1 > y2)
            {
                m = y2;
                GetKvadrat(x1, y2, x2, y1, p, m);
            }
            else if (x1 > x2 && y1 > y2)
            {
                p = x2 + 1;
                m = y2;
                GetKvadrat(x2, y2, x1, y1, p, m);
            }
            Console.SetCursorPosition(0, 0);
        }

        //static void Main(string[] args)
        //{
        //    int x1 = int.Parse(Console.ReadLine());
        //    int y1 = int.Parse(Console.ReadLine());
        //    int x2 = int.Parse(Console.ReadLine());
        //    int y2 = int.Parse(Console.ReadLine());

        //    for (int i = y1; i <= y2; i++)
        //    {
        //        for (int j = x1; j <= x2; j++)
        //        {
        //            if (i == y1)
        //            {
        //                Console.SetCursorPosition(j, y1);
        //                Console.Write("*");
        //            }
        //            if(i == y2)
        //            {
        //                Console.SetCursorPosition(j, y2);
        //                Console.Write("*");
        //            }
        //        }
        //    }

        //    for (int i = x1; i <= x2; i++)
        //    {
        //        for (int j = y1; j <= y2; j++)
        //        {
        //            if (i==x1)
        //            {
        //                Console.SetCursorPosition(x1, j);
        //                Console.Write("*");
        //            }
        //            if (i==x2)
        //            {
        //                Console.SetCursorPosition(x2, j);
        //                Console.Write("*");
        //            }
        //        }
        //    }
        //}
    }
}
