﻿// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();

Console.WriteLine("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine()); // Считываем число с консоли

int num1 = num / 10000; // присваиваем переменной num1 первую цифру
int num2 = (num / 1000) % 10; // присваиваем переменной num2 вторую цифру
int num4 = (num % 100) / 10; // присваиваем переменной num4 четвертую цифру
int num5 = num % 10; // присваиваем переменной num5 пятую цифру

if (num1 == num5 && num2 == num4) // проверяем является ли число полиндромом
{
    Console.WriteLine($"Число {num} палиндром!");
}
else Console.WriteLine($"Число {num} не палиндром");




