// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int InputNumber(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

string RecursiveReverseStringOfNaturalNumbers(int num)
{
    if (num == 1) return num.ToString();
    return num + ", " + RecursiveReverseStringOfNaturalNumbers(--num);
}

Console.Clear();

int number = InputNumber("Введите натуральное число: ");

Console.WriteLine(RecursiveReverseStringOfNaturalNumbers(number));