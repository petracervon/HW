// See https://aka.ms/new-console-template for more information
/*Console.Write("Введите элементы(через пробел): ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0;
 
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        count++;
    }
}
 
Console.WriteLine($"Кол-во элементов > 0: {count}");*/

Console.Write("Введите колличество чисел: ");
int n = Convert.ToInt32(Console.ReadLine());
int count = 0;
for (int i = 0; i < n; i++)
{
    Console.Write($"Введите число {i + 1}: ");
    int num = Convert.ToInt32(Console.ReadLine());;
    if (num > 0)
        count++;
}
Console.WriteLine($"чисел > 0: {count}");

