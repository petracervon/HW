// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*int GetSumDigit(int number);
{
int SumDigit = 0;
while (number > 0)
{
    
 SumDigit =  number%10 + SumDigit;
 number = number/10;
}
return SumDigit;
}

int Num = new int();
Console.WriteLine("Введите число");
Num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(GetSumDigit(Num));*/
int Num = new int();
Console.WriteLine("Введите число");
Num = Convert.ToInt32(Console.ReadLine());

int SumDigit = 0;
while (Num > 0)
{
    
 SumDigit =  Num%10 + SumDigit;
 Num = Num/10;
}
Console.WriteLine(SumDigit);

