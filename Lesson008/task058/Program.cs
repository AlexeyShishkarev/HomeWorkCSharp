// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


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
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}


int[,] matrixA = FillArray(rows, columns, min, max);

GetParamArray(out rows, out columns,
out min, out max);
int[,] matrixB = FillArray(rows, columns, min, max);


PrintArray(matrixA);
Console.WriteLine();
PrintArray(matrixB);
Console.WriteLine();

int[,] ProductMatrix(int[,] matrixA, int[,] matrixB)
{
    int[,] matrixResult = new int[matrixA.GetLength(0), matrixB.GetLength(1)];

    for (var i = 0; i < matrixA.GetLength(0); i++)
    {
        for (var j = 0; j < matrixB.GetLength(1); j++)
        {
            for (var k = 0; k < matrixB.GetLength(0); k++)
            {
                matrixResult[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }
    return matrixResult;
}

if (matrixA.GetLength(0) == matrixB.GetLength(1))
{
    int[,] matrixResult = ProductMatrix(matrixA, matrixB);
    Console.WriteLine("Результат умножения матриц: ");
    PrintArray(matrixResult);
}
else
{
    Console.WriteLine("Эти матрицы перемножать нельзя!");
}











