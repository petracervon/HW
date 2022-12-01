// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


double[,] generatearray(int lengthRow, int lengthCol, int deviation)
{
    double[,] array = new double[lengthRow, lengthCol];
    for (int i = 0; i < lengthRow; i++)
    {
        for (int j = 0; j < lengthCol; j++)
        {
            array[i, j] = new Random().Next(-deviation / 101, deviation + 1);
        }
    }
    return array;
}
void print2dArray(double[,] array)
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



void ArifCol(double[,] array)

{
     Console.WriteLine ("среднее арифметическое столбцов");
    double ret = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            ret = ret + array[i, j];
        }
        
        Console.Write(ret / array.GetLength(0) + "\t");
        ret = 0;
    }
}
double[,] array = generatearray(3, 4, 5);
print2dArray(array);
ArifCol(array);
