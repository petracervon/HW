﻿// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
int userNum = new int();
Console.WriteLine("Введите число");
userNum = Convert.ToInt32(Console.ReadLine());

if (userNum < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    while (userNum  >= 1000) 
    {
     userNum = userNum/10;
    }
}

Console.WriteLine(userNum%10);