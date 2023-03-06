// Напишите программу, которая выводит случайное число из отрезка (10-99) и показывает наибольшую цифру числа
// 78->8
// 12->2
// 85->8

Random rand = new Random();
int randNumber = rand.Next(10,100);  // 1,2,3....99  [10,100) от 10 до 99 включительно, 100 не включается

System.Console.WriteLine(randNumber);

int leftNumber = randNumber / 10;
int rightNumber = randNumber % 10;

if(leftNumber>rightNumber)
{
    System.Console.WriteLine($"{leftNumber} > {rightNumber}");
}
else if(rightNumber>leftNumber)
{
    System.Console.WriteLine($"{rightNumber} > {leftNumber}");
}
else
{
    System.Console.WriteLine("Числа равны");
}
