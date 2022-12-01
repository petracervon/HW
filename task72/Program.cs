/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.*/

double[,] generatearray(int lengthRow, int lengthCol, int deviation)
{
    double[,] array = new double[lengthRow, lengthCol];
    for (int i = 0; i < lengthRow; i++)
    {
        for (int j = 0; j < lengthCol; j++)
        {
            array[i, j] = new Random().Next(-deviation, deviation + 1);
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



void PositionEl(double[,] array, int userNum)

{
    int ColNum = 0;
    int indexN = 0;
    if (userNum == 0)
    {
         Console.WriteLine (array[0,0]);
    }
    if (userNum != 0)
    {
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            indexN = j + ColNum;
            if (userNum == indexN)
            {
               Console.WriteLine (array[i,j]);
               break;
            }
                 
                       
        }
       ColNum = ColNum + array.GetLength(1);
    }
    }
}

double[,] array = generatearray(3, 4, 10);
print2dArray(array);
int userNum = new int();
Console.WriteLine("Введите число");
userNum = Convert.ToInt32(Console.ReadLine());
PositionEl(array, userNum);
