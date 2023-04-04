// Задача 25: Напишите цикл, который принимает на вход 
// два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4-> 16

Console.Clear();

int ConsoleRead() // считываем число с консоли
{
    Console.Write("Введите число: ");
    int num = int.Parse(Console.ReadLine());
    return num;
}

int numA = ConsoleRead();
int numB = ConsoleRead();
int result = numA; // переменная для хранения результата

void Print()
{
    Console.WriteLine($"Число {numA} в степени {numB} = {result}");
    
}

for (int i = 1; i < numB; ++i)
{
    result *= numA;
}

Print();