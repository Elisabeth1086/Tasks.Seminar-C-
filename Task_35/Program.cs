// Задача 57. Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз
// встречается элемент входных данных
// {1,9,9,0,2,8,0,9}
// 0 встречается 2 раза
// 1 встречается 1 раз
// 2 встречается 1 раз
// 8 встречается 1 раз
// 9 встречается 3 раза

int[,] CreatingMatrix(int numberRows, int numberColums)
{
    int[,] matrix = new int[numberRows, numberColums];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int[] CountElems(int[,] array)
{
    int[] countDictionary = new int[9];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            countDictionary[array[i, j]]++;
        }
    }
    return countDictionary;
}

void WriteCountDictionary(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] != 0);
        {
            System.Console.WriteLine($"{i + 1} встречается {array[i]} раза");
        }
    }
}

int[,] matrix = CreatingMatrix(4, 4);
PrintMatrix(matrix);
System.Console.WriteLine(string.Join(", ", CountElems(matrix)));
//WriteCountDictionary(CountElems(matrix));