/*Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4 */

/*int[,] table = new int[3, 4];
FillArrayRandom(table);
PrintArray(table);
SortToLower(table);
Console.WriteLine();
PrintArray(table);


// Функция заполнения массива рандомно числами от 1 до 9
void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

// Функция сортировки элементов в строке двумерного массива, по убыванию
void SortToLower(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

// Функция вывода двумерного массива
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
*/


        {
            void Zadacha54()
            {
                int rows = 5;
                int columns = 6;
                int[,] array = new int[rows, columns];
                FillArray(array);
                PrintArray(array);
                for (int i = 0; i < rows; i++)
                {
                    for (int j = columns - 1; j > 0; j--)
                    {
                        for (int k = 0; k < j; k++)
                        {
                            if (array[i, k] < array[i, k + 1]) ;
                            {
                                int temp = array[i, k];
                                array[i, k] = array[i, k + 1];
                                array[i, k + 1] = temp;
                            }
                        }
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Filtred array");
                PrintArray(array);
            }

            Zadacha54();
        }
    


