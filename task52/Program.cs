// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] GenerateRandomArray(int num)
{
double[] numbers = new double[num];
Random rnd = new Random();
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = rnd.NextDouble() + new Random().Next(0, 10);
}
return numbers;
}



double DiffMaxMin(double[] array)

{
    double Max = array[0];
    double Min = array[0];
    for (int i = 1; i <= array.Length - 1; i = i+1 )
    {
           if (array[i] > Max)
           {
            Max = array[i];
           }
           if(array[i] < Min)
           {
            Min = array[i];
           }
              
    }
    return(Max - Min);
}   
int num = 5;
double Diff = DiffMaxMin(GenerateRandomArray(num));
Console.WriteLine(string.Join(" ", GenerateRandomArray(num).Select(n => $"{n:F2}")));
Console.WriteLine($"разница между максимальным эл-ом и минимальным {Diff}");