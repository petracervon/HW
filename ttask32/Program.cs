//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N. 
int userNum = new int();
Console.WriteLine("Введите число");
userNum = Convert.ToInt32(Console.ReadLine());
double kub = 0;
double i = 1;
for (i = 0; i < userNum; i = i+1)
{
kub = Math.Pow(i,3);
Console.Write(kub + " ");
}
