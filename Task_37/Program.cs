// Задача 63. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N=5 - 1,2,3,4,5
// N=6 - 1,2,3,4,5,6

int ReadInt(string prompt)
{
    System.Console.WriteLine(prompt);
    return Convert.ToInt32(Console.ReadLine());
}

void WriteNumbers(int num)
{
    if (num == 0) return;
    WriteNumbers(num - 1);
    System.Console.Write(num + " ");
}

WriteNumbers(ReadInt("Введите число: "));