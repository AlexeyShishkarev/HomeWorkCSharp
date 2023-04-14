


Start();

void Start()
{
    Console.Clear();
    Console.WriteLine("Задача 47. Задайте двумерный массив размером m×n, "
    + "заполненный случайными вещественными числами.");
    Console.WriteLine("Для выхода введите 0");
    Console.WriteLine();

    while (true)
    {

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
                    Random rand = new Random();

                    for (var i = 0; i < rowsQuantity; i++)
                    {
                        for (var j = 0; j < columnsQuantity; j++)
                        {
                            array[i, j] = rand.NextDouble() + rand.Next(minValue, maxValue + 1);
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

                break;

                #endregion task47

            #region 

            default:
                Console.WriteLine("Неверный номер");
                break;
        }


    }
}

