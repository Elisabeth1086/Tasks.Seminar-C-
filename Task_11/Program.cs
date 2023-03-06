// Задача 17. Напишите программу, которая принимает на вход координаты точки (X и Y), причем X не равен 0 и Y не равен 0 
// и выдает номер четверти плоскости, в которой находится эта точка

// если X и Y > 0 - это первая четверть
// если X > 0, Y > 0 - это вторая четверть
// если X < 0, Y < 0 - это третья четверть
// если X > 0, Y < 0 - это четвертая четверть

System.Console.WriteLine("Введите X: ");
int x = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите Y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0)
{
    System.Console.WriteLine("Мы находимся в первой четверти");
}
else if (x < 0 && y > 0)
{
    System.Console.WriteLine("Мы находимся во второй четверти");
}
else if (x < 0 && y < 0)
{
    System.Console.WriteLine("Мы находимся в третьей четверти");
}
else if (x > 0 && y < 0)
{
    System.Console.WriteLine("Мы находимся в четвертой четверти");
}
else
{
    System.Console.WriteLine("Координата лежит на осях");
}

// ЧЕРЕЗ МАССИВ
// int[] coords = new int[2];

// System.Console.Write("Введите X: ");
// coords[0] = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Введите Y: ");
// coords[1] = Convert.ToInt32(Console.ReadLine());

// if (coords[0] > 0 && coords[1] > 0)
// {
//     System.Console.WriteLine("Мы находимся в первой четверти");
// }

// и тд.