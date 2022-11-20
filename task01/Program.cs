/*Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.*/
int userNum1 = new int();
Console.WriteLine("Введите число");
userNum1 = Convert.ToInt32(Console.ReadLine());
int userNum2 = new int();
Console.WriteLine("Введите число");
userNum2 = Convert.ToInt32(Console.ReadLine());
if (userNum1 < userNum2)
{
 Console.WriteLine("max " + userNum2);
Console.WriteLine("min " + userNum1);
}
else 
{
 Console.WriteLine("max " + userNum1);
Console.WriteLine("min " + userNum2);
}