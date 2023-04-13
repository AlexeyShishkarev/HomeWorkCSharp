// Задача 43: Напишите программу, которая 
// найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int CheckInput() // Является ли введенное значение целым числом?
{
    while(true) 
    {
        if(int.TryParse(Console.ReadLine(), out int number))
            return number;
        else
        {
            Console.WriteLine("Ошибка ввода! Введите еще раз!");
        } 
    }

}

// Метод считывает целые числа с консоли и предлагет повторить 
// ввод в случае если пользователь ввел не число
void ReadConsole(out double numB1, out double numK1,
out double numB2, out double numK2)
{
    Console.Write("Введите целое число b1: "); 
     numB1 = CheckInput();
    Console.Write("Введите целое число k1: ");
     numK1 = CheckInput();
    Console.Write("Введите целое число b2: ");
     numB2 = CheckInput();
    Console.Write("Введите целое число k2: ");
     numK2 = CheckInput();
}

ReadConsole(out double numB1, out double numK1, 
out double numB2, out double numK2);

if (numK1 == numK2) // проверяем не параллельны прямые
{
    Console.WriteLine("Прямы параллельны!");
}
else
{
    double coordinateX = (numB2 - numB1) / (numK1 - numK2);
    double coordinateY = numK1 * ((numB2 - numB1) / (numK1 - numK2)) + numB1;
    Console.WriteLine($"({coordinateX}; {coordinateY})");
}

 
 
 

