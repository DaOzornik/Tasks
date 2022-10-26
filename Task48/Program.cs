/* Задайте двумерный массив размера m на n
каждый элемент в массиве находится по формуле A = i+j
Выведите полученный массив на экран
m=3 n4 */
Random random = new Random();
int rows = random.Next (3, 4); // rows и columns  переменные для размерности
int columns = random.Next (3, 4);
int[,] array = new int[rows, columns]; // ввели переменную массива (создали массив)
FillArray(array);
PrintArray(array);

void FillArray(int[,] array, int startnumber = 0, int finishnumber = 10)
{
    finishnumber++;
    Random random = new Random();    
    int rows = array.GetLength(0); // задали размерность строки
    int columns = array.GetLength(1);  // задали размерность колонки
    for(int i = 0; i<rows; i++)
    {
        for(int j = 0; j<columns; j++)
        {
            array[i,j] = i+j;
        }
    }
}
void PrintArray(int[,] array )
{
    int row = array.GetLength(0); // задали размерность строки
    int column = array.GetLength(1);  // задали размерность колонки
    for(int i = 0; i<row; i++)
    {
        for(int j = 0; j<column; j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}