/* Напишите программу, которая задаёт массив произвольной длины, 
   заполняет произвольными элементами и выводит их на экран.
   Длину массива и элементы массива можно задать рандомно или попросить пользователя ввести в консоли.
    6, 1, 33 -> [6, 1, 33] */

int size = 9;
int [] array = new int [size];
Random random = new Random();
for(int i =0; i < size; i++)
{
    array[i] = random.Next(-10, 10);
}
for(int i = 0; i < size; i++)
{
    Console.Write(array[i]+ " ");
}
    Console.WriteLine();