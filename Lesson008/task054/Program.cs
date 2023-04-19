/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
 */

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

int[,] SortRowsArray(int[,] array)
{
    int temp = 0;
    for (var i = 0; i < rows; i++)
    {
        for (var k = 0; k < columns - 1; k++)
        {

            for (var j = 0; j < columns - 1; j++)
            {
                if (array[i, j] > array[i, j + 1])
                {
                    temp = array[i, j];
                    array[i, j] = array[i, j + 1];
                    array[i, j + 1] = temp;
                }
            }
        }
    }
    return array;
}

matrix = SortRowsArray(matrix);
Console.WriteLine();
PrintArray(matrix);

