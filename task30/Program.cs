/* Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет,
является ли оно палиндромом. */
/*вариант(не доработанный)
int num = new int();
Console.WriteLine("Введите число");
num = Convert.ToInt32(Console.ReadLine());
int numLength = 5;
int[] digits = new int[numLength];
for (int i = numLength - 1; i >= 0; i--) 
{
    digits[i] = num % 10;
    num /= 10;
}
for (int i = 0; i < numLength/2; i++)
{
   if (digits[i] != digits[numLength - i - 1])
  {
    Console.WriteLine("Нет");
  }
   else     
   {
  Console.WriteLine("Является");
   }
}
*/
int Num = new int();
Console.WriteLine("Введите число");
Num = Convert.ToInt32(Console.ReadLine());
int a = Num;
int b = 0;
int i = 0;
while(i <= 4)
{
 b = b*10 + a%10;
 a = a/10;
 i = i + 1;
}

if(Num == b)
{
  Console.WriteLine("Является");
}
else
{
    Console.WriteLine("Нет");
  }