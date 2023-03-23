// Задача 69. Напишите программу, которая на вход принимает два числа А и В и возводит число А в целую степень В с помощью рекурсии.
// А=3 В=5 - 243
// А=2 В=3 - 8

int ReadInt(string prompt)
{
    System.Console.WriteLine(prompt);
    return Convert.ToInt32(Console.ReadLine());
}

int RecursionPower(int a, int b)
{
    if(b==0) return 1;
    return a*RecursionPower(a, b-1);
}
System.Console.WriteLine(RecursionPower(ReadInt("Введите число a: "), ReadInt("Введите число b: ")));