// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

Random rand = new Random();
int randNumber = rand.Next(100,1000);

System.Console.WriteLine(randNumber);

int leftNumber = randNumber / 100;
int rightNumber = randNumber % 10;

System.Console.WriteLine(leftNumber + "" + rightNumber);
