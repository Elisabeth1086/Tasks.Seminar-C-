// Задача 42. Напишите программу, которая будет преобразовывать десятичное число в двоичное
// 44 - 101100
// 3 - 11
// 2 - 10
// 2 способ (рекурсия)

int ReadInt(string promt)
{
    System.Console.WriteLine(promt);                      //Приняли число
    return Convert.ToInt32(Console.ReadLine());
}

void GetBinaryView(int num)                                //рекурсия
{
    if (num == 0) return;
    GetBinaryView(num / 2);
    System.Console.Write(num % 2);
}

int N = ReadInt("Введите число: ");
GetBinaryView(N);