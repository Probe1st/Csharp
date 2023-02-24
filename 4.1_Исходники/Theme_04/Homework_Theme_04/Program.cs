using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Theme_04
{
    class Program
    {
        static void Main(string[] args)
        {
            #region +/- ex. 1
            // Задание 1.
            // Заказчик просит вас написать приложение по учёту финансов
            // и продемонстрировать его работу.
            // Суть задачи в следующем: 
            // Руководство фирмы по 12 месяцам ведет учет расходов и поступлений средств. 
            // + За год получены два массива – расходов и поступлений.
            // + Определить прибыли по месяцам
            // + Количество месяцев с положительной прибылью.
            // - Добавить возможность вывода трех худших показателей по месяцам, с худшей прибылью, 
            // - если есть несколько месяцев, в некоторых худшая прибыль совпала - вывести их все.
            // + Организовать дружелюбный интерфейс взаимодействия и вывода данных на экран

            // Пример
            //       
            // Месяц      Доход, тыс. руб.  Расход, тыс. руб.     Прибыль, тыс. руб.
            //     1              100 000             80 000                 20 000
            //     2              120 000             90 000                 30 000
            //     3               80 000             70 000                 10 000
            //     4               70 000             70 000                      0
            //     5              100 000             80 000                 20 000
            //     6              200 000            120 000                 80 000
            //     7              130 000            140 000                -10 000
            //     8              150 000             65 000                 85 000
            //     9              190 000             90 000                100 000
            //    10              110 000             70 000                 40 000
            //    11              150 000            120 000                 30 000
            //    12              100 000             80 000                 20 000
            // 
            // Худшая прибыль в месяцах: 7, 4, 1, 5, 12
            // Месяцев с положительной прибылью: 10
            //
            #endregion

            #region - ex. 2
            // * Задание 2
            // Заказчику требуется приложение, строящее первые N строк треугольника паскаля. N < 25
            // 
            // При N = 9. Треугольник выглядит следующим образом:
            //                                 1
            //                             1       1
            //                         1       2       1
            //                     1       3       3       1
            //                 1       4       6       4       1
            //             1       5      10      10       5       1
            //         1       6      15      20      15       6       1
            //     1       7      21      35      35       21      7       1
            //                                                              
            //                                                              
            // Простое решение:                                                             
            // 1
            // 1       1
            // 1       2       1
            // 1       3       3       1
            // 1       4       6       4       1
            // 1       5      10      10       5       1
            // 1       6      15      20      15       6       1
            // 1       7      21      35      35       21      7       1
            // 
            // Справка: https://ru.wikipedia.org/wiki/Треугольник_Паскаля
            #endregion

            #region +/- ex. 3

            #region + ex. 3.1
            // + * Задание 3.1
            // Заказчику требуется приложение позволяющщее умножать математическую матрицу на число
            // Добавить возможность ввода количество строк и столцов матрицы и число,
            // на которое будет производиться умножение.
            // Матрицы заполняются автоматически. 
            // Если по введённым пользователем данным действие произвести невозможно - сообщить об этом
            //
            // Пример
            //
            //      |  1  3  5  |   |  5  15  25  |
            //  5 х |  4  5  7  | = | 20  25  35  |
            //      |  5  3  1  |   | 25  15   5  |
            #endregion

            #region + ex. 3.2
            // ** Задание 3.2
            // Заказчику требуется приложение позволяющщее складывать и вычитать математические матрицы
            // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)
            // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)#Сложение_матриц
            // Добавить возможность ввода количество строк и столцов матрицы.
            // Матрицы заполняются автоматически
            // Если по введённым пользователем данным действие произвести невозможно - сообщить об этом
            //
            // Пример
            //  |  1  3  5  |   |  1  3  4  |   |  2   6   9  |
            //  |  4  5  7  | + |  2  5  6  | = |  6  10  13  |
            //  |  5  3  1  |   |  3  6  7  |   |  8   9   8  |
            //  
            //  
            //  |  1  3  5  |   |  1  3  4  |   |  0   0   1  |
            //  |  4  5  7  | - |  2  5  6  | = |  2   0   1  |
            //  |  5  3  1  |   |  3  6  7  |   |  2  -3  -6  |
            #endregion

            #region ex. 3.3
            // *** Задание 3.3
            // Заказчику требуется приложение позволяющщее перемножать математические матрицы
            // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)
            // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)#Умножение_матриц
            // Добавить возможность ввода количество строк и столбцов матрицы.
            // Матрицы заполняются автоматически
            // Если по введённым пользователем данным действие произвести нельзя - сообщить об этом
            //  
            //  |  1  3  5  |   |  1  3  4  |   | 22  48  57  |
            //  |  4  5  7  | х |  2  5  6  | = | 35  79  95  |
            //  |  5  3  1  |   |  3  6  7  |   | 14  36  45  |
            //
            //  
            //                  | 4 |   
            //  |  1  2  3  | х | 5 | = | 32 |
            //                  | 6 |  
            //
            #endregion

            #endregion

            // ---------------------------------------------------------------------- \\
            #region ex. 1 dicision
/*
            #region arrays
            //Console.WriteLine("Enter number of months");
            int Months = 12;
            int[] expenses = new int[Months];
            int[] receipts = new int[Months];
            int[,] profit = new int[2, Months];
            #endregion

<<<<<<< HEAD
            #region Filling of arrays
            Random random = new Random();

            for (int i = 0; i < expenses.Length; i++)       //filling the expenses
            {
                expenses[i] = random.Next(50_000, 100_000);
            }

            for (int i = 0; i < receipts.Length; i++)       //filling the reciepts
            {
                receipts[i] = random.Next(50_000, 200_001);
            }

            for (int i = 0; i < Months; i++)         //filling the profit
            {
                profit[1, i] = receipts[i] - expenses[i];
            }
            for (int i = 0; i < Months; i++)
            {
                profit[0, i] = i + 1;
            }

            #endregion

            #region The number of months with a positive profit
            int NumMonths = 0;

            for (int i = 0; i < Months; i++)
            {
                if (profit[1, i] > 0)
                {
                    NumMonths++;
                }
            }
            #endregion

            #region output

=======
            #region ex. 1 decision
/*
            #region arrays
            //Console.WriteLine("Enter number of months");
            int Months = 12;
            int[] expenses = new int[Months];
            int[] receipts = new int[Months];
            int[,] profit = new int[2, Months];
            #endregion

            #region Filling of arrays
            Random random = new Random();

            for (int i = 0; i < expenses.Length; i++)       //filling the expenses
            {
                expenses[i] = random.Next(50_000, 100_000);
            }

            for (int i = 0; i < receipts.Length; i++)       //filling the reciepts
            {
                receipts[i] = random.Next(50_000, 200_001);
            }

            for (int i = 0; i < Months; i++)         //filling the profit
            {
                profit[1, i] = receipts[i] - expenses[i];
            }
            for (int i = 0; i < Months; i++)
            {
                profit[0, i] = i + 1;
            }

            #endregion

            #region The number of months with a positive profit
            int NumMonths = 0;

            for (int i = 0; i < Months; i++)
            {
                if (profit[1, i] > 0)
                {
                    NumMonths++;
                }
            }
            #endregion

            #region output

>>>>>>> 2b780889d42be5b0d93e27ec86fad91cfad97e8b
            #region table
            Console.WriteLine($"{"Month",5}    {"Receipts, thous. RUB",20}    {"Expenses, thous. RUB",20}    {"Profit, thous. RUB",18}");


            for (int i = 0; i < Months; i++)
            {
                string patternOutput = $"{i + 1,5}    {receipts[i],20}    {expenses[i],20}    {profit[1, i],18}";
                Console.WriteLine(patternOutput);
            }
            #endregion

            Console.WriteLine($"The number of months with a positive profit: {NumMonths}");

            #region Worst months
            Console.Write("Worst profit in moths: ");
<<<<<<< HEAD
            #endregion

=======


            #endregion

>>>>>>> 2b780889d42be5b0d93e27ec86fad91cfad97e8b
            #endregion
*/
            #endregion

            #region ex. 3.1-3.2 decision
            /*
                        #region Data entry
                        Console.WriteLine("Enter a number of columns");
                        int columns = Convert.ToInt32(Console.ReadLine());

                        #region checking numbers of columns
                        bool check = false;
                        while (check == false)
                        {
                            if (columns < 1)
                            {
                                Console.WriteLine("You entered inccorect number. " +
                                    "Number must be natural. ") +
                                    "\nEntering new the number of columns";
                                columns = Convert.ToInt32(Console.ReadLine());
                            }
                            else
                            {
                                check = true;
                            }
                        }
                        #endregion

                        Console.WriteLine("Enter a number of lines");
                        int lines = Convert.ToInt32(Console.ReadLine());

                        #region checking numbers of lines
                        check = false;
                        while (check == false)
                        {
                            if (lines < 1)
                            {
                                Console.WriteLine("You entered inccorect number. " +
                                    "Number must be natural. ") +
                                    "\nEntering new the number of columns";
                                lines = Convert.ToInt32(Console.ReadLine());
                            }
                            else
                            {
                                check = true;
                            }
                        }
                        #endregion

                        Console.WriteLine("Enter sign");
                        string sign = Convert.ToString(Console.ReadLine());

                        #region Arrays and their filling
                        int[,] matrix = new int[lines, columns];
                        int[,] matrixOut = new int[lines, columns];
                        int[,] matrix2 = new int[lines, columns];

                        #region entering arrays
                        Random r = new Random();
                        for (int i = 0; i < matrix.GetLength(0); i++)
                        {
                            for (int j = 0; j < matrix.GetLength(1); j++)
                            {
                                matrix[i, j] = r.Next(1, 10);
                            }
                        }
                        for (int i = 0; i < matrix2.GetLength(0); i++)
                        {
                            for (int j = 0; j < matrix2.GetLength(1); j++)
                            {
                                matrix2[i, j] = r.Next(1, 10);
                            }
                        }
                        #endregion

                        #endregion

                        #endregion

                        #region peqrfoming action
                        //performing multiplication
                        int multiplier = 0;
                        if (sign == "*")
                        {
                            Console.WriteLine("Enter a multiplier");
                            multiplier = Convert.ToInt32(Console.ReadLine());

                            #region checking multiplier
                            check = false;
                            while (check == false)
                            {
                                if ((multiplier > 99) || (multiplier < -99))
                                {
                                    Console.WriteLine("You entered number too long. " +
                                        "Entering new multiplier");
                                    multiplier = Convert.ToInt32(Console.ReadLine());
                                }
                                else
                                {
                                    check = true;
                                }
                            }
                            #endregion

                            #region  multiplying an array by a number
                            for (int i = 0; i < matrixOut.GetLength(0); i++)
                            {
                                for (int j = 0; j < matrixOut.GetLength(1); j++)
                                {
                                    matrixOut[i, j] = matrix[i, j] * multiplier;
                                }
                            }
                            #endregion

                        }
                        //performing addition
                        else if (sign == "+")
                        {
                            for (int i = 0; i < matrix.GetLength(0); i++)
                            {
                                for (int j = 0; j < matrix.GetLength(1); j++)
                                {
                                    matrixOut[i, j] = matrix[i, j] + matrix2[i, j];
                                }
                            }
                        }
                        //performing subtraction
                        else if (sign == "-")
                        {
                            for (int i = 0; i < matrix.GetLength(0); i++)
                            {
                                for (int j = 0; j < matrix.GetLength(1); j++)
                                {
                                    matrixOut[i, j] = matrix[i, j] - matrix2[i, j];
                                }
                            }
                        }
                        //check sign
                        else
                        {
                            check = false;
                            while (check == false)
                            {
                                if ((sign == "+") || (sign == "-") || (sign == "*"))
                                {
                                    check = true;
                                }
                                else
                                {
                                    Console.WriteLine("You entered incorrect. " +
                                        "Entering new action sign");
                                    sign = Convert.ToString(Console.ReadLine());
                                }
                            }
                        }
                        #endregion

                        #region output

                        for (int i = 0; i < matrixOut.GetLength(0); i++)
                        {
                            #region tabulation "multiplier * "

                            if (sign == "*")
                            {
                                if ((i % 2 == 0) && (i == (lines / 2)))
                                {
                                    Console.Write(multiplier + " x ");
                                    if ((multiplier < 10) && (multiplier > -1)) Console.Write("  ");   //для чисел длинной в один знак
                                    if (multiplier > 9) Console.Write(" ");                            //для положительных чисел длинной в два знака
                                    if ((multiplier > -10) && (multiplier < 0)) Console.Write(" ");    //для отрицательных чисел длинной в два знака
                                }
                                else if ((i % 2 == 1) && (i == (lines / 2)))
                                {
                                    Console.Write(multiplier + " x ");
                                    if ((multiplier < 10) && (multiplier > -1)) Console.Write("  ");   //для чисел длинной в один знак
                                    if (multiplier > 9) Console.Write(" ");                            //для положительных чисел длинной в два знака
                                    if ((multiplier > -10) && (multiplier < 0)) Console.Write(" ");    //для отрицательных чисел длинной в два знака
                                }
                                else
                                {
                                    Console.Write("      ");
                                }
                            }

                            #endregion

                            Console.Write("| ");
                            for (int j = 0; j < matrix.GetLength(1); j++)
                            {
                                Console.Write($"{matrix[i, j],3} ");
                            }
                            Console.Write("  |");

                            #region tabulation "+/-"

                            if (sign == "+")
                            {
                                if ((i % 2 == 0) && (i == (lines / 2)))
                                {
                                    Console.Write(" + ");
                                }
                                else if ((i % 2 == 1) && (i == (lines / 2)))
                                {
                                    Console.Write(" + ");
                                }
                                else
                                {
                                    Console.Write("   ");
                                }
                            }
                            else if (sign == "-")
                            {
                                if ((i % 2 == 0) && (i == (lines / 2)))
                                {
                                    Console.Write(" - ");
                                }
                                else if ((i % 2 == 1) && (i == (lines / 2)))
                                {
                                    Console.Write(" - ");
                                }
                                else
                                {
                                    Console.Write("   ");
                                }
                            }
                            #endregion

                            if ((sign == "+") || (sign == "-"))
                            {
                                Console.Write("| ");
                                for (int j = 0; j < matrix2.GetLength(1); j++)
                                {
                                    Console.Write($"{matrix2[i, j],3} ");
                                }
                                Console.Write("  |");
                            }

                            #region tabulation "="
                            if ((i % 2 == 0) && (i == (lines / 2)))
                            {
                                Console.Write(" = ");
                            }
                            else if ((i % 2 == 1) && (i == (lines / 2)))
                            {
                                Console.Write(" = ");
                            }
                            else
                            {
                                Console.Write("   ");
                            }
                            #endregion

                            Console.Write("| ");
                            for (int j = 0; j < matrixOut.GetLength(1); j++)
                            {
                                Console.Write($"{matrixOut[i, j],3} ");
                            }
                            Console.Write("  |");

                            Console.WriteLine("");
                        }

                        #endregion
            */
            #endregion



            #region ex. 3.3 decision
            /*
                        #region Data entry

                        int columns1 = 0;
                        int lines1 = 0;
                        int columns2 = 0;
                        int lines2 = 0;

<<<<<<< HEAD
            #region initialization
            int columns1 = 0;
            int lines1 = 0;
            int columns2 = 0;
            int lines2 = 0;

            int FirstSummand = 0;

            int[,] matrix1 = new int[lines1, columns1];
            int[,] matrix2 = new int[lines2, columns2];
            int[,] matrixOut = new int[lines1, columns2];

            bool check = false;

            Random rand = new Random();
            #endregion

            check = false;
            while (check == false)
            {
                Console.WriteLine("Enter the number of columns in the first matrix");
                columns1 = Convert.ToInt32(Console.ReadLine());

                #region checking numbers of columns
                check = false;
                while (check == false)
                {
                    if (columns1 < 1)
                    {
                        Console.WriteLine("You entered inccorect numbers. " +
                            "Entering new the number of columns");
                        columns1 = Convert.ToInt32(Console.ReadLine());
                    }
                    else
                    {
                        check = true;
                    }
                }
                #endregion
=======
                        int[,] matrix1 = new int[lines1, columns1];
                        int[,] matrix2 = new int[lines2, columns2];

                        Random rand = new Random();

                        bool check = false;
                        while (check == false)
                        {
                            Console.WriteLine("Enter the number of columns in the first matrix");
                            columns1 = Convert.ToInt32(Console.ReadLine());

                            #region checking numbers of columns
                            check = false;
                            while (check == false)
                            {
                                if (columns1 < 1)
                                {
                                    Console.WriteLine("You entered inccorect numbers. " +
                                        "Entering new the number of columns");
                                    columns1 = Convert.ToInt32(Console.ReadLine());
                                }
                                else
                                {
                                    check = true;
                                }
                            }
                            #endregion

                            Console.WriteLine("Enter the number of lines in the first matrix");
                            lines1 = Convert.ToInt32(Console.ReadLine());
>>>>>>> 2b780889d42be5b0d93e27ec86fad91cfad97e8b

                            #region checking numbers of lines
                            check = false;
                            while (check == false)
                            {
                                if (lines1 < 1)
                                {
                                    Console.WriteLine("You entered inccorect numbers. " +
                                        "Entering new the number of columns");
                                    lines1 = Convert.ToInt32(Console.ReadLine());
                                }
                                else
                                {
                                    check = true;
                                }
                            }
                            #endregion

                            Console.WriteLine("Enter the number of columns in the first matrix");
                            columns2 = Convert.ToInt32(Console.ReadLine());

                            #region checking numbers of columns
                            check = false;
                            while (check == false)
                            {
                                if (columns2 < 1)
                                {
                                    Console.WriteLine("You entered inccorect numbers. " +
                                        "Entering new the number of columns");
                                    columns2 = Convert.ToInt32(Console.ReadLine());
                                }
                                else
                                {
                                    check = true;
                                }
                            }
                            #endregion

<<<<<<< HEAD
                #region checking numbers of columns
                check = false;
                while (check == false)
                {
                    if (columns2 < 1)
                    {
                        Console.WriteLine("You entered inccorect numbers. " +
                            "Entering new the number of columns");
                        columns2 = Convert.ToInt32(Console.ReadLine());
                    }
                    else
                    {
                        check = true;
                    }
                }
                #endregion
=======
                            Console.WriteLine("Enter the number of lines in the first matrix");
                            lines2 = Convert.ToInt32(Console.ReadLine());
>>>>>>> 2b780889d42be5b0d93e27ec86fad91cfad97e8b

                            #region checking numbers of lines
                            check = false;
                            while (check == false)
                            {
                                if (lines2 < 1)
                                {
                                    Console.WriteLine("You entered inccorect numbers. " +
                                        "Entering new the number of columns");
                                    lines2 = Convert.ToInt32(Console.ReadLine());
                                }
                                else
                                {
                                    check = true;
                                }
                            }
                            #endregion

                            if (columns1 == lines2)
                            {
                                check = true;
                            }
                            else
                            {
                                Console.WriteLine("You have entered the wrong number of columns" +
                                    "and rows of matrices. Enter new matrix sizes");
                            }
                        }

<<<<<<< HEAD
                if (columns1 == lines2)
                {
                    check = true;
                }
                else
                {
                    Console.WriteLine("You have entered the wrong number of columns" +
                        "and rows of matrices. Enter new matrix sizes");
                }
            }

            #region filling arrays
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    matrix1[i, j] = rand.Next(1, 11);
                }
            }
=======
                        int[,] matrixOut = new int[lines1, columns2];

                        for (int i = 0; i < matrix1.GetLength(0); i++)
                        {
                            for (int j = 0; j < matrix1.GetLength(1); j++)
                            {
                                matrix1[i, j] = rand.Next(1, 11);
                            }
                        }

                        for (int i = 0; i < matrix2.GetLength(0); i++)
                        {
                            for (int j = 0; j < matrix2.GetLength(1); j++)
                            {
                                matrix2[i, j] = rand.Next(1, 11);
                            }
                        }
>>>>>>> 2b780889d42be5b0d93e27ec86fad91cfad97e8b

                        for (int i = 0; i < matrixOut.GetLength(0); i++) ;
                        {
                            for (int j = 0; j < matrixOut.GetLength(1); j++) ;
                            {
                                matrixOut[i, j] = 

<<<<<<< HEAD
            #endregion

            #endregion

            #region program
            for (int i = 0; i < matrixOut.GetLength(0); i++)                                //строки
            {
                for (int j = 0; j < matrixOut.GetLength(1); j++)                            //столбцы
                {
                    for (int x = 0; x < matrix1.GetLength(0); x++)                          //строки
                    {
                        for (int y = 0; y < matrix2.GetLength(1); y++)                      //столбцы
                        {
                             = matrix1[i, y] * matrix2[x, j];
                        }
                    }
                }
            }



            for (int i = 0; i < matrixOut.GetLength(0); i++)
            {
                for (int j = 0; j < matrixOut.GetLength(1); j++)
                {
                    matrixOut[i, j] = (matrix1[i, j] * matrix2[i, j]); 
                }
            }
            #endregion            

=======
                        }

                        #endregion
            */
>>>>>>> 2b780889d42be5b0d93e27ec86fad91cfad97e8b
            #endregion

            Console.ReadKey();
        }
    }
}
