/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9 */

Random random = new Random();
int rows = random.Next (3, 4); // rows и columns  переменные для размерности
int columns = random.Next (3, 4);
double[,] array = new double[rows, columns]; // ввели переменную массива (создали массив)
FillArray(array);
PrintArray(array);

void FillArray(double[,] array, int startnumber = 0, int finishnumber = 10)
{
    finishnumber++;
    Random random = new Random();    
    int rows = array.GetLength(0); // задали размерность строки
    int columns = array.GetLength(1);  // задали размерность колонки
    for(int i = 0; i<rows; i++)
    {
        for(int j = 0; j<columns; j++)
        {
            array[i,j] = Math.Round(random.NextDouble()*100-50,2);
        }
    }
}
void PrintArray(double[,] array )
{
    int row = array.GetLength(0); // задали размерность строки
    int column = array.GetLength(1);  // задали размерность колонки
    for(int i = 0; i<row; i++)
    {
        for(int j = 0; j<column; j++)
        {
            Console.Write(array[i,j] + ";" + " ");
        }
        Console.WriteLine();
    }
}