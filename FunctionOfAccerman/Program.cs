// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int AckermanFunc(int m, int n)
{
    if (m == 0)
        return n + 1;
    else
    {
        if (n == 0)
            return AckermanFunc(m - 1, 1);
        else
            return AckermanFunc(m - 1, AckermanFunc(m, n - 1));
    }
}

int InputNumber(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

Console.Clear();

int mNumber = InputNumber("Введите число m: ");
int nNumber = InputNumber("Введите число n: ");

Console.WriteLine($"Функция Аккермана для {mNumber} и {nNumber} равна {AckermanFunc(mNumber, nNumber)}");