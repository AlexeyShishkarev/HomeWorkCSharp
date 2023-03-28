using System.Net.WebSockets;
// Задача 13: Напишите программу, которая выводит 
// третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.WriteLine("Введите число: ");
int numA = int.Parse(Console.ReadLine()); // считываем число

if (numA / 1000 != 0)
{
    while (numA / 1000 != 0)
    {
        numA /= 10;
    }
    Console.WriteLine($"Третья цифра введенного числа: {numA % 10}");
}
else
{
    Console.WriteLine("Третьей цифры нет");

}