/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.WriteLine(" Введите пятизначное число ");
string number = Console.ReadLine(); // 15715
int Len = number.Length;
                                   // 01234  
if (Len == 5)
{
if (number [0] == number [4] && number [1] == number [3])
{
    Console.WriteLine($"{number} Это те дроиды что вы ищите");
}
else 
{
    Console.WriteLine($"{number} Это не те дроиды, что вы ищите");
}
}
else
{
    Console.WriteLine("Не корректный ввод");
}

