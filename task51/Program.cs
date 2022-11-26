//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
int[] GenerateRandomArray(int length,int startPoint, int endPoint)
{
    int[] resultArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        resultArray[i] = new Random().Next(startPoint, endPoint+1);
    }
    return resultArray;
}
int SumEvenPositionInArray(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i = i+2)
    {
        sum = sum + array[i];
        
    }
    return sum;
}

void printArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.WriteLine("]");
}
int[] array = GenerateRandomArray(5,10,20);
printArray(array);
int sumEven = SumEvenPositionInArray((array));
Console.WriteLine($"сумма элементов на чётных позициях {sumEven}");
