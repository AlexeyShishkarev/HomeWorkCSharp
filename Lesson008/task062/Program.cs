// Задача 62. Напишите программу, которая заполнит спирально массив . Размер вводит юзер
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

/* До того как решил - увидел решение в чате.
Захотел сделать другое решение, отличное от увиденного */


Console.Clear();

int[,] ArraySpiral(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    int borderColumns = 0; //Начальная граница колонок
    int borderRows = 0; //Начальная граница строк
    int borderRowsOut = array.GetLength(1); //конечная граница строк
    int borderColumnsOut = array.GetLength(0); //конечная граница колонок
    int value = 1; //Значение с которого начинается заполнение массива
    int i = 0;
    int j = 0;
    while (value <= rows * columns)
    {
        //заполняем массив вправо
        for (j = borderRows; j < borderRowsOut; j++)
        {
            array[i, j] = value++;
        }
        borderColumns++;
        j--;
        if(value > rows * columns) break;

        //заполняем массив вниз
        for (i = borderColumns; i < borderColumnsOut; i++)
        {
            array[i, j] = value++;
        }
        borderRowsOut--;
        i--;
        if(value > rows * columns) break;

        //заполняем массив слево
        for (j = borderRowsOut - 1; j >= borderRows; j--)
        {
            array[i, j] = value++;
        }
        borderColumnsOut--;
        j++;
        if(value > rows * columns) break;

        //заполняем массив вверх
        for (i = borderColumnsOut - 1; i >= borderColumns; i--)
        {
            array[i, j] = value++;
        }
        borderRows++;
        i++;
    }
    return array;
}

void GetParamArray(out int rows, out int columns)
{
    rows = ReadConsole("Введите количество строк массива: ");
    columns = ReadConsole("Введите количество колонок: ");
}

int ReadConsole(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

GetParamArray(out int rows, out int columns);

void PrintArray(int[,] array)
{
    for (var i = 0; i < rows; i++)
    {
        for (var j = 0; j < columns; j++)
        {
            Console.Write($"{array[i, j]:D2} ");
        }
        Console.WriteLine();
    }
}

int[,] matrix = ArraySpiral(rows, columns);

PrintArray(matrix);





