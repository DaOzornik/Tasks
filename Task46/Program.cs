// Задайте двумерный массив размером mxn заполненный случайными целыми числами

Random random = new Random();
int rows = random.Next (4, 8); // rows и columns  переменные для размерности
int columns = random.Next (4, 8);
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
            array[i,j] = random.Next(startnumber,finishnumber);
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