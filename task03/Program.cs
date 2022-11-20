/* Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два 
без остатка)*/
int userNum = new int();
Console.WriteLine("Введите число");
userNum = Convert.ToInt32(Console.ReadLine());

if (userNum % 2 == 0)
{
Console.WriteLine("да");
}
else
{
Console.WriteLine("нет");
}