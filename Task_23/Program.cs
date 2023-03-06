// Задача 37. Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и тд.
// Результат запишите в новом массиве.
// [1 2 3 4 5] - 5, 8, 3
// [6 7 3 6] - 36, 21

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

int[] MultiplyArray(int[] array)
{
    int[] result = new int[array.Length / 2 + array.Length % 2]; // или array.Lenth +1/2

    for (int i = 0; i < array.Length / 2; i++)
    {
        result[i] = array[i] * array[array.Length - 1 - i];
    }
    if (array.Length % 2 != 0)
    {
        result[^1] = array[array.Length / 2];   //^1 обращение к последнему элементу массива
    }
    return result;
}

var myArray = GenerateArray(5, -10, 10);
PrintArray(myArray);

int[] result = MultiplyArray(myArray);
PrintArray(result);
