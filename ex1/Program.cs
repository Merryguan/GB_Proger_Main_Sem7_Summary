﻿// Задача 1: 
// Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа
// в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.
//
// Пример:
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"
void PrintNaturalDigits(int startDigit, int endDigit)
{
    if (startDigit == endDigit)
    {
        Console.Write(endDigit);
        return;
    }
    if (startDigit < endDigit)
    {
        Console.Write(startDigit + ", ");
        PrintNaturalDigits(startDigit + 1, endDigit);
    }
    if (startDigit > endDigit)
    {
        Console.Write(startDigit + ", ");
        PrintNaturalDigits(startDigit - 1, endDigit);
    }
    
}

int m = 0;
int n = 0;

Console.WriteLine("Введите натуральное число M: ");
m = Convert.ToInt32(Console.ReadLine());
if (m <= 0)
{
    Console.WriteLine("Неверный ввод.");
    return;
}
Console.WriteLine("Введите натуральное число N: ");
n = Convert.ToInt32(Console.ReadLine());
if (n <= 0)
{
    Console.WriteLine("Неверный ввод.");
    return;
}

Console.Write("\"");
PrintNaturalDigits(m, n);
Console.Write("\"");