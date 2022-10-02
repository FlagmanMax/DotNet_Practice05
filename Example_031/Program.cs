﻿// Задача 31: Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.

void FillArray(int[] arr, int min=0, int max=100)
{
    Random random = new Random();
    max++;
    for (int i=0;i<arr.Length;i++)
    {
        arr[i] = random.Next(min,max);
    }
}

void PrintArray(int[] arr)
{
    for (int i=0;i<arr.Length;i++)
    {
        Console.Write(arr[i]+"\t");
    }
     Console.WriteLine();
}

int GetSumPositive(int[] arr)
{
    int sum = 0;
    for (int i=0;i<arr.Length;i++)
    {
        if (arr[i]>0)
        {
            sum += arr[i];
        }
    }
    return sum;
}

int GetSumNegative(int[] arr)
{
    int sum = 0;
    for (int i=0;i<arr.Length;i++)
    {
        if (arr[i]<0)
        {
            sum += arr[i];
        }
    }
    return sum;
}

int size = 12;
int[] numbers = new int[size];

FillArray(numbers,-9,9);
PrintArray(numbers);

Console.WriteLine("Summ positive = "+GetSumPositive(numbers));
Console.WriteLine("Summ negative = "+GetSumNegative(numbers));