// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int ReadConsole(string message) // Создаем метод для считывания числа с консоли
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int lenght = ReadConsole("Введите размер массива чисел: "); // Считываем размер массива
int minArray = ReadConsole("Введите минимальное значение элемента: ");
int maxArray = ReadConsole("Введите максимальное значение элемента(включительно): ") + 1; // +1 для включения максимального числа

int[] GetArray(int lenght, int minArray, int maxArray) // Метод для заполнения массива трехзначными положительными числами
{
    int[] array = new int[lenght];
    Random rand = new();
    for (int i = 0; i < lenght; ++i)
    {
        array[i] = rand.Next(minArray, maxArray);
    }
    return array;
}

void MinMax(int[] array, out int min, out int max) // Метод для нахождения мин и макс
{
    min = array[0];
    max = array[0];

   foreach(int number in array)
    {
        if (number < min) min = number;
        if (number > max) max = number;
    }

}

int[] array = GetArray(lenght, minArray, maxArray); // создаем массив при помощи метода

MinMax(array, out int min, out int max); // Находим мин и макс

Console.Write(string.Join(", ", array));
Console.WriteLine();

Console.WriteLine($"Разница между максимальным {max} значением и минимальным {min}: {max - min}");



