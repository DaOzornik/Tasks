/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0 */

int size = 8; // создала массив задала размерность
int[] array = new int[size]; //  создала массив
Random rand = new Random(); 
for(int i =0; i<size; i++)
{
   array[i] = rand.Next(0 , 10);
   }
for(int i =0; i<size; i++)
{
   Console.Write(array[i] + " "); // напечатала массив в консоль
}
   Console.WriteLine();

   int sum =0;
for (int z = 1; z < array.Length; z+=2) // нечетность с шагом 2
    sum = sum + array[z];

    Console.WriteLine($"всего {array.Length} чисел, сумма элементов cтоящих на нечётных позициях = {sum}");

