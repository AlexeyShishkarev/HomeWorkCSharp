// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int ReadConsole(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int m = ReadConsole("Введите число М: ");
int n = ReadConsole("Введите число N: ");

(int min, int max) GetMinMax(int m, int n)
{
    var result = (min: Math.Min(m, n), max: Math.Max(m, n));
    return result;
}

var minMax = GetMinMax(n, m);

int GetNumbers(int max, int min)
{
    int result = 0;
    if (max < min) return result;
    result = max + GetNumbers(max - 1, min);
    return result;
}

int result = GetNumbers(minMax.max, minMax.min);
Console.Write($"сумму натуральных элементов в промежутке "
+ $"от M до N -> {result}\n");





