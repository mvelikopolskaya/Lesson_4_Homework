﻿// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] array = new int[8];

void FillArray(int[] arr)
{
     for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 101);
    }
}

void PrintArray(int[] arr)
{
    int count = array.Length;
    for(int i = 0; i < count; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
}
FillArray(array);
PrintArray(array);
