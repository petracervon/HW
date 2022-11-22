/*Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает 
вторую цифру этого числа.*/
int userNum = new int();
Console.WriteLine("Введите число");
userNum = Convert.ToInt32(Console.ReadLine());
int Twonumers = userNum / 10;
int secondDigit = Twonumers % 10;

Console.WriteLine(secondDigit);
