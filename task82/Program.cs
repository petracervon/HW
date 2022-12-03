// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] Generate2DArray(int lengthRow, int lengthCol, int deviation)
{
    int[,] array = new int[lengthRow, lengthCol];
    for (int i = 0; i < lengthRow; i++)
    {
        for (int j = 0; j < lengthCol; j++)
        {
            array[i, j] = new Random().Next(0, deviation + 1);
        }
    }
    return array;
}

int[,] ComposeMatrix(int[,] array1, int[,] array2)
{
    int[,] array3 = new int[array1.GetLength(0), array1.GetLength(0)];

    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        
        {
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                array3[i, j] += array1[i, k] * array2[k, j];
            }
        }

    }
    return array3;
}

int[,] array1 = Generate2DArray(2, 3, 5);
int[,] array2 = Generate2DArray(3, 2, 5);

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
Console.WriteLine("матрица   1 ");
print2dArray(array2);
Console.WriteLine("матрица   2 ");
Console.WriteLine("Произведение матриц 1 и 2 ");
print2dArray(ComposeMatrix(array1, array2));
