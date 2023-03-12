// Задача 40. Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник со сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.


void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

void TriChek(int[] arr)
{
    if (arr[1] + arr[2] > arr[0] && arr[0] + arr[2] > arr[1] && arr[1] + arr[0] > arr[2])
    {
        System.Console.WriteLine("Да");
    }
    else
    {
        System.Console.WriteLine("Нет");
    }
}

int[] InputArray(string text)
{
    System.Console.WriteLine(text);
    return Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
}

int[] trangle = InputArray("Введите 3 числа: ");
PrintArray(trangle);
TriChek(trangle);
