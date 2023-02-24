// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int Sum(int m, int n)
{
    if (n >= m && n > 0) return n + Sum(m, n - 1);
    else return 0;
}

input:
int m = ReadInt("Введите число M: ");
int n = ReadInt("Введите число N: ");
if (m > n)
{
    Console.WriteLine("Неверный ввод чисел!");
    goto input;
}

Console.WriteLine($"Сумма натуральных элементов от {m} до {n}: {Sum(m, n)}");