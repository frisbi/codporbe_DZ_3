﻿// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N

Console.Clear();
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int i = 1;
while (i <= N)
{
    Console.WriteLine($"Кубы чисел от 1 до {N} равняются {i*i*i}");
    i+=1;
}
