/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся 
двузначных чисел. Напишите программу, которая будет построчно выводить массив, 
добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2

66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */

int arrayValue = 10;

//Метод для создания массива
int[,,] FillArray (int list, int rows, int columns) 
{
    int[,,] array = new int[list, rows, columns];
    for (var k = 0; k < list; k++)
    {
        for (var i = 0; i < rows; i++)
        {
            for (var j = 0; j < columns; j++)
            {
                array[i, j, k] = arrayValue++;
            }
        }
    }
    return array;
}

//Метод для считывания праметров массива с клавиатуры
(int list, int rows, int columns) GetParamArray() 

{
    int listArray = ReadConsole("Введите количество листов массива: ");
    int rowsArray = ReadConsole("Введите количество строк массива: ");
    int columnsArray = ReadConsole("Введите количество колонок массива: ");

    var result = (list: listArray, rows: rowsArray, columns: columnsArray);
    return result;
}

//Конвертирование из строки консоли в число
int ReadConsole(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

// печать 3-х мерного массива
void PrintArray3D(int[,,] array)
{
    for (var k = 0; k < array.GetLength(0); k++)
    {
        for (var i = 0; i < array.GetLength(1); i++)
        {
            for (var j = 0; j < array.GetLength(2); j++)
            {
                Console.Write($"{array[i, j, k]}({i}, {j}, {k}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

var param = GetParamArray();

int[,,] array3D = FillArray(param.list, param.rows, param.columns);

PrintArray3D(array3D);






