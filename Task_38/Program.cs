// Задача 65. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N/
// M=1; N=5 - 1,2,3,4,5
// M=4; N=8 - 4,6,7,8

int ReadInt(string prompt)
{
    System.Console.WriteLine(prompt);
    return Convert.ToInt32(Console.ReadLine());
}

void WriteNumbers(int m, int n)
{
    if (n == m - 1) return;
    WriteNumbers(m, n - 1);
    System.Console.Write(n + " ");
}


int m = ReadInt("Введите число m: ");
int n = ReadInt("Введите число n: ");
if (m < n)
{
    WriteNumbers(m, n);
}
else
{
    WriteNumbers(n, m);
}