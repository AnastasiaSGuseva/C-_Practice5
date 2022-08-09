﻿// Задача 34
// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.WriteLine("Задайте количество элементов массива: ");
int N = Convert.ToInt32(Console.ReadLine());

int [] array = new int [N];
int count = 0;

for (int i = 0; i < N; i++)
{
    array [i] = new Random().Next(100, 1000);
    if (array[i] % 2 == 0)
        count++;
}

Console.WriteLine("[" + string.Join(", ", array) + "]");
Console.WriteLine("Количество чётных чисел: " + count);