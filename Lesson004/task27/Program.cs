// Задача 27: Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();

int ConsoleRead() // считываем число с консоли
{
    Console.Write("Введите число: ");
    int num = int.Parse(Console.ReadLine());
    return num;
}

int number = ConsoleRead();
int result = 0;

int SumNumbers(int numb)
{
    for (; numb != 0; numb /= 10)
    {
        result += numb % 10;
    }
    return result;
}

SumNumbers(number);

Console.WriteLine($"Сумма цифр числа {number} = {result}");


