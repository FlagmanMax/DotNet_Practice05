// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 12 10

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

void GetProductionPair(int[] arr,int[] result)
{
    int centerIndex = arr.Length/2;
    for (int i=0;i<centerIndex;i++)
    {
        result[i] = arr[i] * arr[arr.Length-i-1];
    }
    
     if (arr.Length % 2 > 0)
     {
         result[centerIndex]= arr[centerIndex];
     }
}

int size = 11;
int[] numbers = new int[size];


int size1 = 0;
if (size%2 == 0)
{
    size1 = size / 2;
}
else
{
    size1 = size / 2 + 1;
}

int[] result = new int[size1];

FillArray(numbers,-9,9);
PrintArray(numbers);

GetProductionPair(numbers, result);
PrintArray(result);