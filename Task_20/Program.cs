// Задача 32. Напишите программу замены элементов массива: положительные заменить на соответствующие отрицательные и наоборот
// [-4,-8,8,2] - [4,8,-,8-2]

int[] GenerateArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    Random rand = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

void FlipNegative(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = -array[i];
    }
}

int[] array = GenerateArray(10, -9, 9);
PrintArray(array);
FlipNegative(array);
PrintArray(array);
