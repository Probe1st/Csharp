using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Module_5_ex_5
{
    internal class Program
    {
        static int A(int n, int m)
        {
            //Console.Write("|");
            if (n == 0) return m + 1;
            else if ((n > 0) && (m == 0)) return A(n - 1, 1);
            else if ((n > 0) && (m > 0)) return A(n - 1, A(n, m - 1));
            else return 0;            
        }
        static void Main(string[] args)
        {
            // Домашнее задание
            // Требуется написать несколько методов
            //
            // *Задание 5
            // Вычислить, используя рекурсию, функцию Аккермана:
            // A(2, 5), A(1, 2)
            // A(n, m) = m + 1, если n = 0,
            //         = A(n - 1, 1), если n > 0, m = 0,
            //         = A(n - 1, A(n, m - 1)), если n > 0, m > 0.
            //
            
            Console.WriteLine(A(3, 5));
            Console.WriteLine(A(1, 2));

            Console.ReadKey();
        }
    }
}
