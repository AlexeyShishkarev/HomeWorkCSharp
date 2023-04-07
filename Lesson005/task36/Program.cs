// Задача 36: Задайте одномерный массив, заполненный 
// случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int ReadConsole(string message) // Создаем метод для считывания числа с консоли
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int lenght = ReadConsole("Введите размер массива чисел: "); // Считываем размер массива
int min = ReadConsole("Введите минимальное значение элемента: ");
int max = ReadConsole("Введите максимальное значение элемента: ");

int[] GetArray(int lenght, int min, int max) // Метод для заполнения массива трехзначными положительными числами
{
    int[] array = new int[lenght];
    Random rand = new();
    for (int i = 0; i < lenght; ++i)
    {
        array[i] = rand.Next(min, max);
    }
    return array;
}

int GetSum(int[] array) // метода для подсчеты суммы элементов на нечетных позициях
{
    int sum = 0; // инициализируем переменную аккумулятор
    for (int i = 0; i < lenght; ++i) // если позиция нечетная - суммируем ее с sum
    {
        if(i % 2 != 0) // условие для нахождения нечетной позиции
        {
            sum += array[i];
        }
    }
    return sum;
}

int[] array = GetArray(lenght, min, max); // создаем массив

int sum = GetSum(array); // высчитываем сумму элементов массива стоящих на нечетных позициях

Console.Write(string.Join(", ", array)); // Выводим массив на экран (для проверки корректности решения)
Console.WriteLine(); // разделяем массив и ответ пустой строкой

Console.WriteLine($"Сумма элементов на нечетных позициях: {sum}");

