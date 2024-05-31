// Задача 2: 
// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
//
// Пример:
// m = 2, n = 3 -> A(m,n) = 29
int Ackermann(int firstDigit, int secondDigit)
{
    if (firstDigit == 0)
    {
        return secondDigit + 1;
    }
    else if (secondDigit == 0)
    {
        return Ackermann(firstDigit - 1, 1);
    }
    else
    {
    return Ackermann(firstDigit - 1, Ackermann(firstDigit, secondDigit - 1));
    }
}

int m = 0;
int n = 0;

Console.WriteLine("Введите натуральное число M: ");
m = Convert.ToInt32(Console.ReadLine());
if (m < 0)
{
    Console.WriteLine("Неверный ввод.");
    return;
}
Console.WriteLine("Введите натуральное число N: ");
n = Convert.ToInt32(Console.ReadLine());
if (n < 0)
{
    Console.WriteLine("Неверный ввод.");
    return;
}

int result = Ackermann(n, m);
Console.WriteLine("A(n, m) = " + result);