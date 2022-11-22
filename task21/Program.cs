 //Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
int userNum = new int();
Console.WriteLine("Введите число");
userNum = Convert.ToInt32(Console.ReadLine());

if (userNum == 6 | userNum == 7) 
{
    Console.WriteLine("Выходной");
}
else

Console.WriteLine("");
