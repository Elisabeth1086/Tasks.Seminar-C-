// Задача 45. Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования(копия массива)

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

int[] CopyArray(int[] array)
{
    int[] copy = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        copy[i] = array[i];
    }
    return copy;
}

int[] array = GenerateArray(9, -9, 9);
PrintArray(array);

int[] newArray = CopyArray(array);
PrintArray(newArray);