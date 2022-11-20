/*Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.*/
int userNum1 = new int();
Console.WriteLine("Введите число");
userNum1 = Convert.ToInt32(Console.ReadLine());
int userNum2 = new int();
Console.WriteLine("Введите число");
userNum2 = Convert.ToInt32(Console.ReadLine());
int userNum3 = new int();
Console.WriteLine("Введите число");
userNum3 = Convert.ToInt32(Console.ReadLine());

if (userNum1 > userNum2 & userNum1 > userNum3)
{
 Console.WriteLine("max " + userNum1);
}
else if (userNum2 > userNum1 & userNum2 > userNum3)
{
 Console.WriteLine("max " + userNum2);
}
else if (userNum3 > userNum1 & userNum3 > userNum2)
{
 Console.WriteLine("max " + userNum3);
}