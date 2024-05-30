// Задача 1: 
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
    Console.Write(startDigit + ", ");
    PrintNaturalDigits(startDigit + 1, endDigit);
}

int m = 0;
int n = 0;
int firstDigit = 0;
int secondDigit = 0;

Console.WriteLine("Введите натуральное число M: ");
m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число N: ");
n = Convert.ToInt32(Console.ReadLine());

if (n > m)
{
    firstDigit = m;
    secondDigit = n;
}
else
{
    firstDigit = n;
    secondDigit = m;
}

Console.Write("\"");
PrintNaturalDigits(firstDigit, secondDigit);
Console.Write("\"");