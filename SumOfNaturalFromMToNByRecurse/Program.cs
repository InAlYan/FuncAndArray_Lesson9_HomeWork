// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int InputNumber(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int SumOfNaturalByRecurse (int m, int n)
{
    if (m == n) return n;
    return m + SumOfNaturalByRecurse (m + 1, n);
}

Console.Clear();

int m = InputNumber("Введите первое натуральное число: ");
int n = InputNumber("Введите второе натуральное число: ");

Console.WriteLine($"Сумма чисел из данного диапазона натуральных чисел от {m} до {n} равна: {SumOfNaturalByRecurse (m, n)}");