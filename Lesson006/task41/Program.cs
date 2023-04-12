// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int GetMinMax()
{
    int count = 0;
    Console.Write("Введите числа(для выхода введите -1 000): \n");
    int input = 0;

    while(input != -1_000)
    {
        input = int.Parse(Console.ReadLine());
        count = input > 0 ? ++count : count;
    }
    return count;
}

int count = GetMinMax();

Console.WriteLine($"Чисел больше 0: {count}");


