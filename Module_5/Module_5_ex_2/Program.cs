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
            string Output = "";
            string spec = "";
            int length = 2_147_483_647;

            for (int i = 0; i < input.Length; i++)
            {
                char space = Convert.ToChar("\u0020");
                if (space == input[i])
                {
                    kursor1 = i;
                    bool Bool = false;
                    while (Bool == false)
                    {
                        for (int j = i + 1; j < input.Length; j++)
                        {
                            if (space == input[i])
                            {
                                kursor2 = j;
                                Bool = true;
                                break;
                            }
                        }
                    }

                    if ((kursor2 - kursor1 - 1) < length)
                    {
                        length = kursor2 - kursor1 - 1;
                        spec = $"{kursor1}";
                    }
                }
                else
                {
                    kursor1 = i - 1;
                    bool Bool = false;
                    while (Bool == false)
                    {
                        for (int j = i + 1; j < input.Length; j++)
                        {
                            if (space == input[i])
                            {
                                kursor2 = j;
                                Bool = true;
                                break;
                            }
                        }
                    }

                    if ((kursor2 - kursor1 - 1) < length)
                    {
                        length = kursor2 - kursor1 - 1;
                        spec = $"{kursor1}";
                    }
                }
                Output = input.Substring(kursor1, length);
            }

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

            string input = "A ББ ВВВ ГГГГ ДДДД  ДД ЕЕ ЖЖ ЗЗЗ";

            Console.WriteLine(Word(input));
            Console.ReadKey();
        }
    }
}
