// Задача 44. Не используя рекурсию, выведите первые N чисел Фибоначчи.
// Первые 2 числа Фибоначии 0 и 1.
// Числа Фибоначчи-каждое следующее число равняется сумме двух предыдущих.
// Если N=5 - 01123
// Если N=3 - 011
// Если N=7 - 0112358

int ReadInt(string promt)
{
    System.Console.WriteLine(promt);
    return Convert.ToInt32(Console.ReadLine());
}

void Fibo(int N)
{
    System.Console.Write("01");
    int result = 0;
    int a = 0, b = 1;
    for (int i = 2; i < N; i++)
    {
        result = a + b;
        a = b;
        b = result;
        System.Console.Write(result + "");
    }
}
int N = ReadInt("Введите число: ");
Fibo(N);
