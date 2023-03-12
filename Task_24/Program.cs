﻿// Задача 39. Напишите программу, которая перевернет одномерный массив(последний элемент будет на первом месте, а первый на последнем)
// [1 2 3 4 5 ] - [5 4 3 2 1]
// [6 7 3 6] - [6 3 7 6]

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

void Reverse(int[] arr)
{
    int temp = 0;
    for (int i = 0; i < arr.Length / 2; i++)
    {
        temp = arr[0];
        arr[i] = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = temp;
    }
}

var myArray = GenerateArray(10, -10, 10);
PrintArray(myArray);

Array.Reverse(myArray);  // встроенная фунцкия разворота массива
PrintArray(myArray);
