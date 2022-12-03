//  Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] Generate2DArray(int lengthRow, int lengthCol, int deviation)
{
    int[,] array = new int[lengthRow, lengthCol];
    for (int i = 0; i < lengthRow; i++)
    {
        for (int j = 0; j < lengthCol; j++)
        {
            array[i, j] = new Random().Next(-deviation, deviation + 1);
        }
    }
    return array;
}

int sumFirstRow1(int[,] array)
{
    int sum = 0;
    
    {
        for (int j = 0; j < array.GetLength(1); j++)
            sum += array[0, j];
    }

    return sum;
}

int RowOfMinSumm(int[,] array) 
{
    int sum = 0;
    int min = 0;
    int minsum = sumFirstRow1(array);
    for (int i = 1; i < array.GetLength(0); i++)
      {
        sum = 0;
          for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
          
        }
        if (minsum > sum)
          {
           min = i;
           minsum = sum;
          }
        
     }
    return min;
}
        

int[,] array1 = Generate2DArray(3, 4, 12);

void print2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
print2dArray(array1);
Console.WriteLine($"минимальная сумма элементов в строке номер: {RowOfMinSumm(array1)}");

