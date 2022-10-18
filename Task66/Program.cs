/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
// ввод числа
int GetNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

// вызов метода печати суммы чисел от M до N
void SumFromMToN(int m, int n)
{
    Console.Write($"сумма числе в заданном диапазоне: {SumMN(m - 1, n)}");
}

// функция сумма чисел от M до N
int SumMN(int m, int n)
{
    int sum = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        sum = m + SumMN(m, n);
        return sum;
    }
}
Console.Clear();
Console.WriteLine("Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N");
int m = GetNumber("Введите число m");
int n = GetNumber("Введите число n");
SumFromMToN(m, n);