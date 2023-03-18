// Задача 59. Задайте массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший
// элемент массива.
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4 
// 5 2 6 7
// Наименьший элемент 1, на выходе получим следующий массив
// 9 2 3 
// 4 2 4
// 2 6 7

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
int[,] GenerateMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rand = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = rand.Next(1, 11);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write(matr[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

void FindMin(int[,] matr, out int mini, out int minj)
{
    mini = 0;
    minj = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[mini, minj] > matr[i, j])
            {
                mini = i;
                minj = j;
            }
        }
    }
}

int[,] Delete(int[,] matr, int mini, int minj)
{
    int[,] newMatr = new int[matr.GetLength(0) - 1, matr.GetLength(1) - 1];
    int row = 0;
    int col = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        if (i == mini) continue;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (j == minj) continue;
            newMatr[row, col] = matr[i, j];
            col++;
        }
        row++;
        col = 0;
    }
    return newMatr;
}

int m = ReadInt("Введите количество строк матрицы: ");
int n = ReadInt("Введите количество столбцов матрицы: ");
var myMatrix = GenerateMatrix(m, n);
PrintMatrix(myMatrix);
FindMin(myMatrix, out int mini, out int minj);
System.Console.WriteLine();
PrintMatrix(Delete(myMatrix,mini,minj));