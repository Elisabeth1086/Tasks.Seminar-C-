// Задача 31. Задайте массив из 12 элементов, заполенный случайными числами из промежутка [-9,9]. Найдите сумму отрицательных и положительных
// элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, отрицательных -20
//СПОСОБ РЕШЕНИЯ С ПОМОЩЬЮ ФУНКЦИЙ

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

void sumPositiveAndNegative(int[] array, out int sumPositive, out int sumNegative)
{
    sumPositive = 0;
    sumNegative = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sumPositive += array[i];
        }
        else
        {
            sumNegative += array[i];
        }
    }
}

var myArray = GenerateArray(12, -9, 9);
PrintArray(myArray);
sumPositiveAndNegative(myArray, out int sumP, out int sumN);
System.Console.WriteLine($"Сумма положительных чисел: {sumP}");
System.Console.WriteLine($"Сумма отрицательных чисел: {sumN}");
