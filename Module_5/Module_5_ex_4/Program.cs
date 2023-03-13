using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_5_ex_4
{
    internal class Program
    {

        static void Progression(int[] ints)
        {
            if ( ints[2] == ints[0] + (3 - 1) * (ints[2] - ints[1]) ) 
            {
                Console.WriteLine("arithmetic progression");
            }
            else if ((ints[1] / ints[0]) == (ints[2] / ints[1]))
            {
                Console.WriteLine("geometric progression");
            }
        }

        static void Main(string[] args)
        {
            // Домашнее задание
            // Требуется написать несколько методов
            //
            // Задание 4. Написать метод принимающий некоторое количество чисел, выяснить
            // является заданная последовательность элементами арифметической или геометрической прогрессии
            // 
            // Примечание
            //             http://ru.wikipedia.org/wiki/Арифметическая_прогрессия
            //             http://ru.wikipedia.org/wiki/Геометрическая_прогрессия
            //

            #region Filling arrays
            Random random = new Random();

            int[] intsArith = new int[random.Next(3, 10)];
            intsArith[0] = random.Next(1, 100);
            int stepProgA = random.Next(2, 10);

            for (int i = 1; i < intsArith.Length; i++)
            {
                intsArith[i] = intsArith[i - 1] + stepProgA;
            }


            int[] intsGeom = new int[random.Next(3, 10)];
            intsGeom[0] = random.Next(1, 100);
            int stepProgG = random.Next(2, 10);

            for (int i = 1; i < intsGeom.Length; i++)
            {
                intsGeom[i] = intsGeom[i - 1] * stepProgG;
            }
            #endregion

            Progression(intsArith);
            Console.WriteLine();

            Progression(intsGeom);
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
