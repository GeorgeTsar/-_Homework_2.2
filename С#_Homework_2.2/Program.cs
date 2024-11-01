using System;
using System.Linq.Expressions;
using System.Text;

namespace CSharpApplication.one_dimensional_array
{
    class MainClass
    {
        static void Main()
        {
            #region ЗАДАНИЕ 1
            // Объявить одномерный (5 элементов) массив с именем A и двумерный массив (3 строки, 4 столбца) дробных чисел с именем B...

            double[] A = new double[5];
            double[,] B = new double[3, 4];
            double compose_AB = 1;
            double sum_A = 0;
            double sum_B = 0;
            Random rand = new Random();
            try
            {
                Console.WriteLine("Заполнение массива А");

                for (int i = 0; i < A.Length; i++)
                {
                    Console.WriteLine($"Введите {i} элемент массива А");
                    A[i] = Convert.ToDouble(Console.ReadLine());
                    compose_AB = compose_AB * A[i];
                    if (i % 2 == 0)
                    {
                        sum_A += A[i];
                    }
                    Console.Clear();
                }

                Console.WriteLine("Заполнение двумерного массива В");
                for (int i = 0; i < B.GetLength(0); i++)
                {
                    for (int j = 0; j < B.GetLength(1); j++)
                    {
                        B[i, j] = Math.Round(rand.NextDouble(), 2);
                        compose_AB = compose_AB * B[i, j];
                        if (j % 2 != 0)
                        {
                            sum_B += B[i, j];
                        }
                    }
                }

                Console.WriteLine("Массив А: ");
                for (int i = 0; i < A.Length; i++)
                {
                    Console.Write($"{A[i]}" + "\t");
                }
                Console.WriteLine();
                Console.WriteLine("Массив B: ");
                for (int i = 0; i < B.GetLength(0); i++)
                {
                    for (int j = 0; j < B.GetLength(1); j++)
                    {
                        Console.Write($"{B[i, j]}" + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();

                Console.WriteLine("Максимальный элемент массива А = " + A.Max());
                Console.WriteLine("Максимальный элемент массива B = " + B.Cast<double>().Max());

                if (B.Cast<double>().Contains(A.Max()))
                {
                    Console.WriteLine("Максимальный общий элемент в массивах = " + A.Max());
                }
                else
                {
                    Console.WriteLine("Общего максимального элемента в массивах нет ");
                }

                Console.WriteLine("Минимальный элемент массива А = " + A.Min());
                Console.WriteLine("Минимальный элемент массива B = " + B.Cast<double>().Min());

                if (A.Min() == B.Cast<double>().Min())
                {
                    Console.WriteLine("Минимальный общий элемент в массивах = " + A.Min());
                }
                else
                {
                    Console.WriteLine("Общего минимального элемента в массивах нет ");
                }

                Console.WriteLine("Сумма элементов массивов = " + (A.Sum() + B.Cast<double>().Sum()));

                Console.WriteLine("Общее произведение элементов массивов = " + compose_AB);

                Console.WriteLine("Cуммa четных элементов массива А = " + sum_A);

                Console.WriteLine("Cуммa нечетных столбцов массива В = " + sum_B);

            }
            catch (Exception)
            {
                Console.WriteLine("Завершение программы");
            }

            #endregion

            Console.WriteLine();

            #region ЗАДАНИЕ 2
            //Дан двумерный массив размерностью 5×5, заполненный случайными числами из диапазона от –100 до 100...

            int[,] arr3 = new int[5, 5];
            int sum_arr3 = 0;
            int max = arr3[0, 0];
            int min = arr3[0, 0];
            Random rand2 = new Random();
            try
            {
                Console.WriteLine("Заполнение двумерного массива arr3");
                for (int i = 0; i < arr3.GetLength(0); i++)
                {
                    for (int j = 0; j < arr3.GetLength(1); j++)
                    {
                        arr3[i, j] = rand2.Next(-100, 100);
                        if (max < arr3[i, j])
                        {
                            max = arr3[i, j];
                        }
                        if (min > arr3[i, j])
                        {
                            min = arr3[i, j];
                        }
                    }
                    Console.WriteLine();
                }

                Console.WriteLine();

                Console.WriteLine("Массив arr3: ");
                for (int i = 0; i < arr3.GetLength(0); i++)
                {
                    for (int j = 0; j < arr3.GetLength(1); j++)
                    {
                        Console.Write($"{arr3[i, j]}" + "\t");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine();

                Console.WriteLine("Максимальный элемент массива arr3 = " + max);
                Console.WriteLine("Минимальный элемент массива arr3 = " + min);

                for (int i = 0; i < arr3.GetLength(0); i++)
                {
                    for (int j = 0; j < arr3.GetLength(1); j++)
                    {
                        if (arr3[i, j] > min && arr3[i, j] < max)
                        {
                            sum_arr3 = sum_arr3 + arr3[i, j];
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("Сумма элементов между максимальным и минимальным: " + sum_arr3);
            }
            catch (Exception)
            {
                Console.WriteLine("Завершение программы");
            }

            #endregion

            Console.WriteLine();

            #region ЗАДАНИЕ 3
            // Пользователь вводит строку с клавиатуры. Необходимо зашифровать данную строку используя шифр Цезаря.

            Console.WriteLine("Введите строку: ");
            string string1 = Console.ReadLine();
            Console.WriteLine("Введите ключ шифра: ");
            int key = int.Parse(Console.ReadLine());
            int d = 0;
            int number = 0;
            string res;
            int j;

            char[] letters = string1.ToCharArray();
            char[] alfavit = { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };

            for (int i = 0; i < letters.Length; i++)
            {
                for (j = 0; j < alfavit.Length; j++)
                {
                    if (letters[i] == alfavit[j])
                    {
                        break;
                    }
                }

                if (j != 33)
                {
                    number = j;
                    d = number + key;

                    if (d > 32)
                    {
                        d = d - 33;
                    }

                    letters[i] = alfavit[d];
                }
            }

            res = new string(letters);
            Console.WriteLine(res);

            #endregion

            Console.WriteLine();

            #region ЗАДАНИЕ 4
            // Создайте приложение, которое производит операции над матрицами.

            int[,] arr4 = new int[5, 5];
            int[,] arr5 = new int[5, 5];
            Console.WriteLine("Введите число, на которое следует умножить матрицу: ");
            int a = int.Parse(Console.ReadLine());
            Random rand3 = new Random();
            try
            {
                Console.WriteLine("Заполнение двумерного массива arr4");
                for (int i = 0; i < arr4.GetLength(0); i++)
                {
                    for (int j = 0; j < arr4.GetLength(1); j++)
                    {
                        arr4[i, j] = rand3.Next(-20, 20);
                    }
                }

                Console.WriteLine();

                Console.WriteLine("Массив arr4: ");
                for (int i = 0; i < arr4.GetLength(0); i++)
                {
                    for (int j = 0; j < arr4.GetLength(1); j++)
                    {
                        Console.Write($"{arr4[i, j]}" + "\t");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine();

                Console.WriteLine("Заполнение двумерного массива arr5");
                for (int i = 0; i < arr5.GetLength(0); i++)
                {
                    for (int j = 0; j < arr5.GetLength(1); j++)
                    {
                        arr5[i, j] = rand3.Next(-20, 20);
                    }
                }

                Console.WriteLine();

                Console.WriteLine("Массив arr5: ");
                for (int i = 0; i < arr5.GetLength(0); i++)
                {
                    for (int j = 0; j < arr5.GetLength(1); j++)
                    {
                        Console.Write($"{arr5[i, j]}" + "\t");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine();

                Console.WriteLine("Умножение массива arr4 на полученное число");
                for (int i = 0; i < arr4.GetLength(0); i++)
                {
                    for (int j = 0; j < arr4.GetLength(1); j++)
                    {
                        arr4[i, j] = arr4[i, j] * a;
                    }
                }

                Console.WriteLine();

                Console.WriteLine("Массив arr4 после умножения: ");
                for (int i = 0; i < arr4.GetLength(0); i++)
                {
                    for (int j = 0; j < arr4.GetLength(1); j++)
                    {
                        Console.Write($"{arr4[i, j]}" + "\t");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine();

                int[,] arr6 = new int[5, 5];

                Console.WriteLine("Сложение матриц (массивов arr4 и arr5): ");
                for (int i = 0; i < arr4.GetLength(0); i++)
                {
                    for (int j = 0; j < arr4.GetLength(1); j++)
                    {
                        arr6[i, j] = arr4[i, j] + arr5[i, j];
                    }
                }

                Console.WriteLine();

                Console.WriteLine("Массив arr6: ");
                for (int i = 0; i < arr6.GetLength(0); i++)
                {
                    for (int j = 0; j < arr6.GetLength(1); j++)
                    {
                        Console.Write($"{arr6[i, j]}" + "\t");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine();

                int[,] arr7 = new int[5, 5];

                Console.WriteLine("Умножение матриц (массивов arr4 и arr5): ");
                for (int i = 0; i < arr4.GetLength(0); i++)
                {
                    for (int j = 0; j < arr4.GetLength(1); j++)
                    {
                        arr7[i, j] = arr4[i, j] * arr5[i, j];
                    }
                }

                Console.WriteLine();

                Console.WriteLine("Массив arr7: ");
                for (int i = 0; i < arr7.GetLength(0); i++)
                {
                    for (int j = 0; j < arr7.GetLength(1); j++)
                    {
                        Console.Write($"{arr7[i, j]}" + "\t");
                    }
                    Console.WriteLine();
                }
            }

            catch (Exception)
            {
                Console.WriteLine("Завершение программы");
            }

            #endregion

            Console.WriteLine();

            #region ЗАДАНИЕ 5
            // Пользователь с клавиатуры вводит в строку арифметическое выражение. Приложение должно посчитать его результат.

            Console.WriteLine("Введите математическое выражение в виде строки: ");
            string string2 = Console.ReadLine();
            string[] temp = string2.Split();
            int res = 0;

            if (temp[1] == "+")
            {
                res = int.Parse(temp[0]) + int.Parse(temp[2]);
            }
            else
            {
                res = int.Parse(temp[0]) - int.Parse(temp[2]);
            }

            Console.WriteLine(res);

            #endregion

            Console.WriteLine();

            #region ЗАДАНИЕ 6
            // Пользователь с клавиатуры вводит некоторый текст. Приложение должно изменять регистр первой буквы каждого предложения на букву в верхнем регистре

            Console.WriteLine("Введите несколько предложений: ");
            string string3 = Console.ReadLine();
            StringBuilder bldr = new StringBuilder();
            bldr.Append(string3[0].ToString().ToUpper());
            for (int i = 1; i < string3.Length; i++)
            {
                if (char.IsLetter(string3[i]) && char.IsWhiteSpace(string3[i - 1]) && ".!?".IndexOf(string3[i - 2]) != -1)
                {
                    bldr.Append(string3[i].ToString().ToUpper());
                }
                else
                {
                    bldr.Append(string3[i]);
                }
            }
            Console.WriteLine(bldr.ToString());

            #endregion

            Console.WriteLine();

            #region ЗАДАНИЕ 7
            // Создайте приложение, проверяющее текст на недопустимые слова. Если недопустимое слово найдено, оно должно быть заменено на набор символов *.
            // ДОРАБОТАТЬ

            //Console.WriteLine("Введите текст: ");
            //string s4 = Console.ReadLine();
            //Console.WriteLine("Недопустимое слово: ");
            //string s5 = Console.ReadLine();
            //foreach (string a in s4)
            //{
            //    if (a == s5)
            //    {
            //        a = '****';
            //    }
            //}

            #endregion

            Console.WriteLine();
        }
    }
}
