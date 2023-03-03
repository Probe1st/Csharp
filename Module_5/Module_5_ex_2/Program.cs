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
            //, '?', ',', '.', '!', ';'
            char[] DelimiterChars = new char[] {' '};
            string[] Words = String.Split(DelimiterChars, StringSplitOptions.RemoveEmptyEntries);

            /*for (int i = 0; i < Words.Length; i++)
            {
                Console.Write($"<{Words[i]}> ");
            }*/

            return Words;
        }

        static string MinWord(string input)
        {
            string[] Words = Word(input);

            string MinWord = string.Empty;

            for (int i = 0; i < Words.Length; i++)
            {
                if ((Words[i].Length < MinWord.Length) || (Words[i].Length == 1))
                {
                    MinWord = Words[i];
                }                    
            }
             
            return MinWord;

        }

        static string[] MinWords(string input)
        {
            string[] Words = Word(input);

            int Length = 0;

            for (int i = 0; i < Words.Length; i++)
            {
                if ((Words[i].Length > Length) || (Words[i].Length == Length))
                {
                    Length = Words[i].Length;
                }
            }

            int count = 0;
            for (int i = 0; i < Words.Length; i++)
            {
                if (Words[i].Length == Length)
                {
                    count++;
                }
            }

            string[] Output = new string[count];

            count = 0;
            for (int i = 0; i < Words.Length; i++)
            {                
                if (Words[i].Length == Length)
                {                    
                    Output[count] = Words[i];
                    count += 1;
                }
            }

            return Output;
        }

        static void Main(string[] args)
        {
            // Домашнее задание
            // Требуется написать несколько методов
            //
            // Задание 2.
            // + 1. Создать метод, принимающий  текст и возвращающий слово, содержащее минимальное количество букв
            // + 2.* Создать метод, принимающий  текст и возвращающий слово(слова) с максимальным количеством букв 
            // Примечание: слова в тексте могут быть разделены символами (пробелом, точкой, запятой) 
            // Пример: Текст: "A ББ ВВВ ГГГГ ДДДД  ДД ЕЕ ЖЖ ЗЗЗ"
            // 1. Ответ: А
            // 2. ГГГГ, ДДДД
            //

            string input = " ssds 4r 4334 sas   gjj   t w t  f s q";

            Console.WriteLine($"<{MinWord(input)}>");

            string[] Output = MinWords(input);
            for (int i = 0; i < Output.Length; i++)
            {
                Console.Write($"<{Output[i]}> ");
            }

            Console.ReadKey();


        }
    }
}
