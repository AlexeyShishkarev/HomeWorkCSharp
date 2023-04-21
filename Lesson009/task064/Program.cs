// Задача 64: Задача 64: Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


int ReadConsole(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int m = ReadConsole("Введите число М: ");
int n = ReadConsole("Введите число N: ");

// Присвоение мин минимального значения из введенных 
// А макс - максимального
(int min, int max) GetMinMax(int m, int n)
{
    var result = (min: Math.Min(m, n), max: Math.Max(m, n));
    return result;
}

var minMax = GetMinMax(n, m);

//метод дл вычисления всех чисел в диапозоне от М до N включительно
string GetNumbers(int max, int min)
{
    string result = String.Empty;
    if (max < min) return result;
    result = max + ", " + GetNumbers(max - 1, min);
    return result;
}

string result = GetNumbers(minMax.max, minMax.min);
Console.WriteLine($"все натуральные числа в промежутке от " 
+ $"M до N:  \"{result.Trim(new char[] {' ', ','})}\"");

