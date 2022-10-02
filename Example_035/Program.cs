// Задача 35: Задайте одномерный массив, состоящий из случайных
// чисел. Найдите количество элементов массива, значения которых
// лежат в отрезке [10,99].
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

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

int FindNumberOfElementsInRange(int[] arr, int min, int max)
{
    int count = 0;
    for (int i=0;i<arr.Length;i++)
    {
        if ((arr[i]<=max)&&(arr[i]>= min))
        {
            count++;
        }
    }
    return count;
}


int size = 15;
int[] numbers = new int[size];

FillArray(numbers,-100,101);
PrintArray(numbers);

int count = FindNumberOfElementsInRange(numbers,10,99);
Console.WriteLine(count);
