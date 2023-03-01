using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_5_ex_2
{
    internal class Program
    {
        static string Word(string input)
        {
            int kursor1 = 0;
            int kursor2 = 0;
            int length = 2_147_483_647;
            int count = 0;
            int beginning = 0;
            int end = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char space = Convert.ToChar(" ");
                if (space == input[i])
                {
                    kursor1 = i;
                }
                else
                {       
                    while (space != input[i])
                    {
                        kursor2 = i;
                        i++;
                    }
                }

                if ((kursor2 - kursor1) < length)
                {
                    length = kursor2 - kursor1;
                }
                Console.WriteLine($"{kursor1} and {kursor2}; length: {length}");
            }

            string Output = input.Substring(kursor1, 1);

            Console.WriteLine(count);

            return Output;

        }

        static void Main(string[] args)
        {
            // Домашнее задание
            // Требуется написать несколько методов
            //
            // Задание 2.
            // 1. Создать метод, принимающий  текст и возвращающий слово, содержащее минимальное количество букв
            // 2.* Создать метод, принимающий  текст и возвращающий слово(слова) с максимальным количеством букв 
            // Примечание: слова в тексте могут быть разделены символами (пробелом, точкой, запятой) 
            // Пример: Текст: "A ББ ВВВ ГГГГ ДДДД  ДД ЕЕ ЖЖ ЗЗЗ"
            // 1. Ответ: А
            // 2. ГГГГ, ДДДД
            //

            string input = "A ББ ВВВ ГГГГ ДДДД ДД ЕЕ ЖЖ ЗЗЗ";

            string Output = Word(input);

            Console.WriteLine(Output);
            Console.ReadKey();
        }
    }
}
