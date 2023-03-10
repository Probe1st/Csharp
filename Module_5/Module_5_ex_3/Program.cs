using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_5_ex_3
{
    internal class Program
    {
        static string Short(string s)
        {
            string Str = String.Empty;
            s = s.ToLower();
            string FirstChar = Convert.ToString(s[0]);
            for (int i = 1; i < s.Length; i++)
            {


                if (s[i] == s[i - 1])
                {
                    s.Remove(i, 1);
                }
                else
                {
                    Str += s[i];
                }
            }
            Str = FirstChar + Str;
            return Str;
        }
        static void Main(string[] args)
        {
            // Домашнее задание
            // Требуется написать несколько методов
            //
            // Задание 3. Создать метод, принимающий текст. 
            // Результатом работы метода должен быть новый текст, в котором
            // удалены все кратные рядом стоящие символы, оставив по одному 
            // Пример: ПППОООГГГООООДДДААА >>> ПОГОДА
            // Пример: Ххххоооорррооошшшиий деееннннь >>> хороший день
            // 
            string testStr = "ххХхХхХооОоОорРРрооошШшШШий деееннннь";

            Console.WriteLine(Short(testStr));

            Console.ReadKey();

        }
    }
}
