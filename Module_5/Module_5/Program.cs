using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_5
{
    internal class Program
    {
        #region methods
        static int[,] Multiplication(int multiplier, int[,] matrix1)
        {
            int[,] matrixOut = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    matrixOut[i, j] = matrix1[i, j] * multiplier;
                }
            }
            return matrixOut;
        }

        static int[,] Multiplication(int[,] matrix1, int[,] matrix2)
        {
            int[,] matrixOut = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

            for (int i = 0; i < matrixOut.GetLength(0); i++)                //строки фиксированные
            {
                for (int j = 0; j < matrixOut.GetLength(1); j++)            //столбцы фиксированные
                {
                    int sum = 0;
                    for (int k = 0; k < matrix1.GetLength(1); k++)          //строки или столбцы
                    {
                        //for (int l = 0; l < matrix1.GetLength(1); l++)      //столбцы
                        //{
                            sum += matrix1[i,k] * matrix2[k,j];
                        //}
                    }
                    matrixOut[i, j] = sum;
                }
            }
            return matrixOut;
            //
            // строки * столбцы
            // M * N
            //
            // N * K
            //
            // M * K

        }

        static int[,] Addition(int[,] matrix1, int[,] matrix2)
        {
            int[,] matrixOut = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    matrixOut[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
            return matrixOut;
        }

        static int[,] Subtraction(int[,] matrix1, int[,] matrix2)
        {
            int[,] matrixOut = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    matrixOut[i, j] = matrix1[i, j] - matrix2[i, j];
                }
            }
            return matrixOut;
        }

        static int CheckNumber(string Entering)
        {
            bool canConvert = int.TryParse(Entering, out int Output);
            if (canConvert == false)
            {
                while (canConvert == false)
                {
                    Console.Write("It wasn't a number. " +
                            "Enter new the NUMBER ");
                    Entering = Console.ReadLine();
                    canConvert = int.TryParse(Entering, out Output);
                }
            }
            return Output;
        }
        #endregion

        static void Main(string[] args)
        {
            // Домашнее задание
            // Требуется написать несколько методов
            //
            // Задание 1.
            // Воспользовавшись решением задания 3 четвертого модуля
            // + 1.1. Создать метод, принимающий число и матрицу, возвращающий матрицу умноженную на число
            // + 1.2. Создать метод, принимающий две матрицы, возвращающий их сумму
            // 1.3. Создать метод, принимающий две матрицы, возвращающий их произведение


            #region ex. 1.1-1.3 decision

            while (true)
            {

                #region Data entry

                #region Enterinng sign and check
                Console.Write("Enter sign ");
                string sign = Convert.ToString(Console.ReadLine());

                //check sign
                while (true)
                {
                    if ((sign == "+") || (sign == "-") || (sign == "*") || (sign == "**"))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("You entered incorrect sign. " +
                            "Entering new sign");
                        sign = Convert.ToString(Console.ReadLine());
                    }
                }
                #endregion

                #region entering the number of lines and columns of matrices
                //entering the number of lines and columns of matrices
                //checking the data
                int lines = 1;
                int columns = 1;
                int lines2 = 1;
                int columns2 = 1;
                while (true)
                {
                    if (sign == "**")
                    {
                        Console.Write("Enter a number of columns of the 1-st matrix ");
                        var EntColumns = Console.ReadLine();

                        columns = CheckNumber(EntColumns);

                        Console.Write("Enter a number of lines of the 1-st matrix ");
                        var EntLines = Console.ReadLine();

                        lines = CheckNumber(EntLines);

                        Console.Write("Enter a number of columns of the 2-nd matrix ");
                        EntColumns = Console.ReadLine();

                        columns2 = CheckNumber(EntColumns);

                        Console.Write("Enter a number of lines of the 2-nd matrix ");
                        EntLines = Console.ReadLine();

                        lines2 = CheckNumber(EntLines);

                        if (columns == lines2)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\nYou entered incorrect size of matrices. " +
                                "\n    Enter new size of matrices\n");
                        }

                    }
                    else
                    {
                        Console.Write("Enter a number of columns ");
                        var EntColumns = Console.ReadLine();

                        columns = CheckNumber(EntColumns);

                        Console.Write("Enter a number of lines ");
                        var EntLines = Console.ReadLine();

                        lines = CheckNumber(EntLines);

                        break;
                    }

                }
                #endregion

                #region Arrays and their filling

                #region arrays
                int[,] matrix = new int[lines, columns];
                int[,] matrix2 = new int[lines, columns];
                int[,] matrixOut = new int[lines, columns];

                int[,] matrixOut2 = new int[lines2, columns];
                int[,] matrix3 = new int[lines2, columns2];
                #endregion

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
                for (int i = 0; i < matrix3.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix3.GetLength(1); j++)
                    {
                        matrix3[i, j] = r.Next(1, 10);
                    }
                }
                #endregion

                #endregion

                #endregion

                #region perfoming action
                int multiplier = 0;
                while (true)
                {
                    //performing multiplication
                    if (sign == "*")
                    {
                        Console.Write("Enter a multiplier ");
                        var EntMultiplier = Console.ReadLine();

                        multiplier = CheckNumber(EntMultiplier);

                        bool check = false;
                        while (check == false)
                        {
                            if ((multiplier > 99) || (multiplier < -99))
                            {
                                Console.WriteLine("You entered number too big. " +
                                    "Entering new multiplier");
                                multiplier = Convert.ToInt32(Console.ReadLine());
                            }
                            else
                            {
                                check = true;
                            }

                        }

                        matrixOut = Multiplication(multiplier, matrix);

                        break;
                    }

                    //performing addition
                    else if (sign == "+")
                    {
                        matrixOut = Addition(matrix, matrix2);

                        break;
                    }

                    //performing subtraction
                    else if (sign == "-")
                    {
                        matrixOut = Subtraction(matrix, matrix2);

                        break;
                    }

                    //performing multiplication
                    else if (sign == "**")
                    {
                        matrixOut2 = Multiplication(matrix, matrix3);

                        break;
                    }

                }
                #endregion

                #region Output
                if (sign != "**")
                {
                    #region output 1 
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
                            Console.Write($"{matrixOut[i, j],5} ");
                        }
                        Console.Write("  |");

                        Console.WriteLine("");
                    }
                    #endregion
                }
                else if (sign == "**")
                {
                    #region Output 2
                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        Console.Write("| ");
                        for (int j = 0; j < matrix.GetLength(1); j++)
                        {
                            Console.Write($"{matrix[i, j]} ");
                        }
                        Console.WriteLine("|");
                    }
                    Console.WriteLine("");

                    #region tabulation "*"
                    Console.WriteLine("*");
                    Console.WriteLine("");
                    #endregion

                    for (int i = 0; i < matrix3.GetLength(0); i++)
                    {
                        Console.Write("| ");
                        for (int j = 0; j < matrix3.GetLength(1); j++)
                        {
                            Console.Write($"{matrix3[i, j]} ");
                        }
                        Console.WriteLine("|");
                    }
                    Console.WriteLine("");

                    #region tabulation "="
                    Console.WriteLine("=");
                    Console.WriteLine("");
                    #endregion

                    for (int i = 0; i < matrixOut2.GetLength(0); i++)
                    {
                        Console.Write("| ");
                        for (int j = 0; j < matrixOut2.GetLength(1); j++)
                        {
                            Console.Write($"{matrixOut2[i, j],4} ");
                        }
                        Console.WriteLine(" |");
                    }
                    Console.Write("");
                    #endregion
                }
                #endregion

                Console.WriteLine("");
                Console.ReadKey();
            }

            #endregion
        }
    }
}
