// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int ReadConsole(string message) // Создаем метод для считывания числа с консоли
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int lenght = ReadConsole("Введите размер массива трехзначных чисел: "); // Считываем размер массива

int[] GetArray(int lenght) // Метод для заполнения массива трехзначными положительными числами
{
    int[] array = new int[lenght];
    Random rand = new();
    for (int i = 0; i < lenght; ++i)
    {
        array[i] = rand.Next(100, 1000);
    }
    return array;
}

int GetSum(int[] array) // метод для подсчета четных элементов в массиве
{
    int count = 0; // Инициализируем счетчик
    for (int i = 0; i < lenght; ++i)
    {
        if(array[i] % 2 == 0)
        {
            count++;
        }
    }
        return count;
}

int[] array = GetArray(lenght); // Создаем массив при помощи метода

int count = GetSum(array); // подсчитываем количество четных элементов 

Console.Write(string.Join(", ", array)); // Выводим наш массив на экран
Console.WriteLine(); // разделяем вывод пустой строкой

Console.WriteLine($"Количество четных элементов в массиве: {count}"); // Выводим резудьтат на экран

