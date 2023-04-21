/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт
 номер строки с наименьшей суммой элементов: 1 строка */


Random rand = new();

void GetParamArray(out int rows, out int columns, 
out int min, out int max)
{
    rows = ReadConsole("Введите количество строк массива: ");
    columns = ReadConsole("Введите количество колонок: ");
    min = ReadConsole("Введите минимальное значение массива: ");
    max = ReadConsole("Введите максимальное значение массива: ");
}


int ReadConsole(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

GetParamArray(out int rows, out int columns,
out int min, out int max);

int[,] FillArray(int rows, int columns, int min, int max)
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


void PrintArray(int[,] array)
{
    for (var i = 0; i < rows; i++)
    {
        for (var j = 0; j < columns; j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}


int[,] matrix = FillArray(rows, columns, min, max);

PrintArray(matrix);

int GetMinRow(int[,] array)
{
    int sumRowValue = 0;
    int minRow = int.MaxValue;
    int numberminRow = 0;

    for (var i = 0; i < rows; i++)
    {
        sumRowValue = 0;
        for (var j = 0; j < columns; j++)
        {
            sumRowValue += array[i, j];
        }
        if (sumRowValue < minRow)
        {
            minRow = sumRowValue;
            numberminRow = i;
        }
    }
    return numberminRow + 1;
}

int minRow = GetMinRow(matrix);

Console.WriteLine($"Строка с наименьшей суммой элементов: {minRow} строка.\n");




