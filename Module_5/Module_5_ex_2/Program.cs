using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_5_ex_2
{
    internal class Program
    {
        static string[] Word(string String)
        {

        }

        static void LengthWord(string Word)
        {

        }

        static string MinWord(string input)
        {

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

            string Output = MinWord(input);

            Console.WriteLine(Output);
            Console.ReadKey();
        }
    }
}
