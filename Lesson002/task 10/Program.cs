﻿// Задача 10: Напишите программу, которая принимает 
// на вход трёхзначное число и на выходе показывает 
// вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.Clear();
Console.WriteLine("Введите трехзначное число: ");
int numA = int.Parse(Console.ReadLine());

int num2 = (numA % 100) / 10;

Console.WriteLine($"Вторая цифра числа {numA}: {num2}");
