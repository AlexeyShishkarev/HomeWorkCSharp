

Start();

void Start()
{

    while (true)
    {
        Console.Clear();
        Console.WriteLine("Задача 47. Задайте двумерный массив размером m×n, "
        + "заполненный случайными вещественными числами.");
        Console.WriteLine("Задача 50. Напишите программу, которая на вход принимает "
        + "элемент в двумерном массиве, и возвращает его индексы первого найденого "
        + "числа или же указание, что такого элемента нет.");
        Console.WriteLine();
        Console.WriteLine("Для выхода введите 0");
        Console.WriteLine();

        int numberTask = ReadConsole("Введите номер задачи: ");
        int ReadConsole(string message) // Считываем с консоли, если ошибка просим повторить ввод
        {
            Console.Write(message);
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int number)) // если преобразование в число успешно
                {                                                      // возвращаем число, если нет - выводим ошибку
                    return number;
                }
                else
                {
                    Console.WriteLine("Неверный ввод! Введите целое число!");
                }
            }
        }

        Random rand = new Random();

        switch (numberTask)
        {
            case 0: return; break;
            #region task47
            case 47:




                void GetParametersArray(out int rows, out int columns, // Метод для считывания параметров массива
                out int min, out int max)
                {
                    rows = ReadConsole("Введите количество строк массива: ");
                    columns = ReadConsole("Введите количество колонок массива: ");
                    min = ReadConsole("Введите минимальное значение элемента массива: ");
                    max = ReadConsole("Введите максимальное значение элементов массива: ");
                }

                double[,] FillArray(int rowsQuantity, int columnsQuantity, // Метод для заполнения массива
                int minValue, int maxValue)
                {
                    double[,] array = new double[rowsQuantity, columnsQuantity];


                    for (var i = 0; i < rowsQuantity; i++)
                    {
                        for (var j = 0; j < columnsQuantity; j++)
                        {
                            array[i, j] = rand.NextDouble() + rand.Next(minValue, maxValue);
                        }
                    }
                    return array;
                }

                void PrintArray(double[,] array) // Метод для печати двухмерного массива
                {
                    for (var i = 0; i < array.GetLength(0); i++)
                    {
                        for (var j = 0; j < array.GetLength(1); j++)
                        {
                            Console.Write($"{array[i, j]:f2} ");
                        }
                        Console.WriteLine();
                    }
                }



                GetParametersArray(out int rows, out int columns,
                out int min, out int max);
                double[,] matrix = FillArray(rows, columns, min, max);
                PrintArray(matrix);

                Console.WriteLine();
                Console.WriteLine("Нажмите Enter для продолжения");
                Console.ReadLine();

                break;

            #endregion task47

            case 50:
                #region task50

                int[,] GetArrayInt(int rows, int columns, int min, int max)
                {
                    int[,] array = new int[rows, columns];

                    for (var i = 0; i < rows; i++)
                    {
                        for (var j = 0; j < columns; j++)
                        {
                            array[i, j] = rand.Next(min, max + 1);
                        }
                    }
                    return array;
                }

                GetParametersArray(out rows, out columns, out min, out max);

                void PrintArrayInt(int[,] array)
                {
                    Console.WriteLine("Наш массив: ");
                    for (var i = 0; i < array.GetLength(0); i++)
                    {
                        for (var j = 0; j < array.GetLength(1); j++)
                        {
                            Console.Write($"{array[i, j]} ");
                        }
                        Console.WriteLine();
                    }
                }

                int[,] matrixInt = GetArrayInt(rows, columns, min, max);

                PrintArrayInt(matrixInt);

                int numberInArray = ReadConsole("Введите искомое число: ");

                void SearchIntNumber(int[,] array, out int indexRow, out int indexColumns)
                {
                    indexRow = -1;
                    indexColumns = -1;

                    for (int i = 0; i < array.GetLength(0); i++)
                    {
                        for (int j = 0; j < array.GetLength(1); j++)
                        {
                            if (array[i, j] == numberInArray)
                            {
                                indexRow = i;
                                indexColumns = j;

                                Console.WriteLine($"Индексы числа {numberInArray}: индекс строки:"
                                + $"{indexRow} индекс колонки: {indexColumns}");


                                return;
                            }
                        }
                    }
                    if (indexRow == -1 && indexColumns == -1)
                    {
                        Console.WriteLine("Такого числа нет!");


                    }


                }

                SearchIntNumber(matrixInt, out int indexRow, out int indexColumns);

                Console.WriteLine();
                Console.WriteLine("Нажмите Enter для продолжения");
                Console.ReadLine();

                break;

            #endregion task50

            default:
                Console.WriteLine("Неверный номер");
                Console.WriteLine();
                Console.WriteLine("Нажмите Enter для продолжения");
                Console.ReadLine();
                break;
        }


    }
}

