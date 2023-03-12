// Задача 49. Задайте двумерный масств.Найдите элементы, у которых оба индекса нечетные и замените эти элементы на их квадраты
// 1472            1472
// 5923    ----    5 81 2 9
// 8424            8424

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
            matrix[i, j] = rand.Next(-10, 11);
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

// void NewMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (i % 2 != 0 && j % 2 != 0)
//             {
//                 matrix[i, j] *= matrix[i, j];
//             }
//         }
//     }
// }

void NewMatrix(int[,] matrix)
{
    for (int i = 1; i < matrix.GetLength(0); i += 2)
    {
        for (int j = 1; j < matrix.GetLength(1); j += 2)
        {
            matrix[i, j] *= matrix[i, j];
        }
    }
}



int m = ReadInt("Введите количество строк матрицы: ");
int n = ReadInt("Введите количество столбцов матрицы: ");
var myMatrix = GenerateMatrix(m, n);
PrintMatrix(myMatrix);
System.Console.WriteLine();
NewMatrix(myMatrix);
PrintMatrix(myMatrix);
