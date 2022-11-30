// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int [] UserNumArray (int length, int start, int end)
            {
                Console.Write("Введите число М: ");

                length = Convert.ToInt32(Console.ReadLine());
                int [] array = new int [length];
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write($"элемент массива {i}: ");
                    array[i] = Convert.ToInt32(Console.ReadLine());                   
                }
                return array;
                
            }
            /*void PrintArray(int [] array)
            {
                Console.Write("[");
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i]);
                    if (i < array.Length - 1)
                    {
                        Console.Write(", ");
                    }
                }
                Console.WriteLine("]");
            }*/

            int NumberOfPositiv (int [] array)
            {
                int count = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] > 0)
                    {
                        count++;
                    }
                }
                return count;
            }

            int [] newArray = UserNumArray (5,-10, 10);
            Console.WriteLine();
            //PrintArray(newArray);
            int countNumber = NumberOfPositiv(newArray);
            Console.WriteLine();
            Console.WriteLine ($"чисел больше нуля {countNumber}");
       