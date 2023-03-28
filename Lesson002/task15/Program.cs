// Задача 15: Напишите программу, которая 
// принимает на вход цифру, обозначающую день 
// недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.WriteLine("Введите номер дня недели: ");
int numDay = int.Parse(Console.ReadLine()); // Считываем число

if (numDay > 0 && numDay < 8)
{
    switch (numDay)
    {
        case 1:
            Console.WriteLine("Понедельник - рабочий день");
            break;

        case 2:
            Console.WriteLine("Вторник - рабочий день");
            break;

        case 3:
            Console.WriteLine("Среда - рабочий день");
            break;

        case 4:
            Console.WriteLine("Четверг - рабочий день");
            break;

        case 5:
            Console.WriteLine("Пятница - рабочий день");
            break;

        case 6:
            Console.WriteLine("Суббота - выходной!");
            break;

        case 7:
            Console.WriteLine("Воскресенье - выходной!");
            break;
    }
}
else 
{
    Console.WriteLine("Такого дня недели нет!!!");
    
}