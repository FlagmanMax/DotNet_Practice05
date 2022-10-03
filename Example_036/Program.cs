// Задача 36: Задайте одномерный массив, заполненный
// случайными числами. Найдите сумму элементов с
// нечётными индексами.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void FillArray(int[] arr)
{
    Random random = new Random();

    for (int i=0;i<arr.Length;i++)
    {
        arr[i] = random.Next(-100,101);
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

int SummElementsWitOddIndexes(int[] arr)
{
    int sum = 0;
    for (int i=0;i<arr.Length;i++)
    {
        if (i%2 > 0)
        {
            sum+= arr[i];
        }
    }
    return sum;
}

Random random = new Random();
int length = random.Next(3,11);

int[] array = new int[length];

FillArray(array);
PrintArray(array);

int sum = SummElementsWitOddIndexes(array);
Console.WriteLine("Сумма элементов с нечетными индексами = "+sum);
