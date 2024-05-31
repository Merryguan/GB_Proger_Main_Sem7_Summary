// Задача 3: 
// Задайте произвольный массив. 
// Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.
//
// Пример:
// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1
void InputVector(int[] vector, int start)
{
    if (start == vector.GetLength(0))
    {
        return;
    }
    Console.WriteLine("Введите " + (start + 1) + " элемент массива");
    vector[start] = Convert.ToInt32(Console.ReadLine());
    InputVector(vector, start + 1);
}

void PrintVector(int[] vector, int start)
{
    if (start == vector.GetLength(0) - 1)
    {
        Console.Write(vector[start]);
        return;
    }
    Console.Write(vector[start] + ", ");
    PrintVector(vector, start + 1);
}

void InvertPrintVector(int[] vector, int end)
{
    if (end == 0)
    {
        Console.Write(vector[end]);
        return;
    }
    Console.Write(vector[end] + ", ");
    InvertPrintVector(vector, end - 1);
}

int n = 0;

Console.WriteLine("Введите длину массива: ");
n = Convert.ToInt32(Console.ReadLine());

int[] array = new int[n];

InputVector(array, 0);

Console.Write("[");
PrintVector(array, 0);
Console.Write("] => [");
InvertPrintVector(array, array.GetLength(0) - 1);
Console.WriteLine("]");