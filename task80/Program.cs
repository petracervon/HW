
/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив
*/
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

int[,]  NumberOfIdenticalElements(int[,] array)
{
   for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        { 
         	for (int count = 0; count < array.GetLength(1) - 1; count++)
            {
					if (array[i,count] < array[i,count + 1])
					{
						int buf = array[i, count + 1];
						array[i, count + 1] = array[i, count];
						array[i, count] = buf;
					}
            }
		}
    }
    return array;
}



int[,] array = Generate2DArray(3, 4, 10);

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
 print2dArray(array);
  Console.WriteLine ("массив с убывающими элементами в строках ");
 print2dArray(NumberOfIdenticalElements(array));

