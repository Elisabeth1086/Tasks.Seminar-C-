// Задача 67. Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 - 12
// 45 - 9

int InputData(string text)
{
    System.Console.WriteLine(text);
    int x = Convert.ToInt32(Console.ReadLine());
    return x;
}

int OutData(int x)
{
    if (x == 0) return 0;
    return x % 10 + OutData(x / 10);
}
System.Console.WriteLine(OutData(InputData("Введите число: ")));