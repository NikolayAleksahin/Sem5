﻿// Задача 35: Задайте одномерный массив из 123 случайных чисел.
//Найдите количество элементов массива, значения которых лежат в
//отрезке [10,99].
//Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
//123
//[5, 18, 123, 6, 2] -> 1
//[1, 2, 3, 6, 2] -> 0
//[10, 11, 12, 13, 14] -> 5

void FillArray(int[]array, int a, int b)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(a, b);
    }
}
void Print(int[]array)
{Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}
Console.Write("]");}
int [] array = new int[123];
FillArray(array, -100, 100);
Print(array);
int c = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] >= 10 & array[i] <= 99)
    {
        c+= 1;
    }
}
Console.WriteLine();
Console.Write($"В заданном массиве {c} чисел принадежат промежутку [10;99]");
