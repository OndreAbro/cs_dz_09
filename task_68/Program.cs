// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int Acc(int n, int m)
{
    if (n == 0) return m + 1;
    else if (m == 0) return Acc(n - 1, 1);
    else return Acc(n - 1, Acc(n, m - 1));
}

input:
int n = ReadInt("Введите число m: ");
int m = ReadInt("Введите число n: ");
if (m < 0 || n < 0)
{
    Console.WriteLine("Неверный ввод чисел!");
    goto input;
}

Console.WriteLine($"Функция Аккермана от ({n},{m}): {Acc(n, m)}");