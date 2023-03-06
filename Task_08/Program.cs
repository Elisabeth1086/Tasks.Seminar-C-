// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// // 34, 5 -> не кратно, остаток 4 
// // 16, 4 -> кратно

System.Console.Write("Введите первое число: ");
int number1=Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число: ");
int number2=Convert.ToInt32(Console.ReadLine());

if(number1%number2==0)
{
    System.Console.WriteLine("Кратно");
}
else
{
    System.Console.WriteLine("Не кратно, остаток " + number1%number2);
}
