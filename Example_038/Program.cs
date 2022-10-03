// Задача 38: Задайте массив вещественных чисел. Найдите
// разницу между максимальным и минимальным элементов
// массива.
// [3,21 7,04 22,93 -2,71
// 78,24] -> 75,53

void FillArray(double[] arr, int min=-100, int max=100)
{
    Random random = new Random();
    
    max++;

    for (int i=0;i<arr.Length;i++)
    {
        arr[i] = random.Next(-1000,1001)/100d;
    }
}

void PrintArray(double[] arr)
{
    for (int i=0;i<arr.Length;i++)
    {
        Console.Write(arr[i]+"\t");
    }
     Console.WriteLine();
}

double FindDiffMaxMin(double[] arr)
{
    double diff = 0;
    double min = arr[0];
    double max = arr[0];

    for (int i=0;i<arr.Length;i++)
    {
        if (arr[i]<min)
        {
            min = arr[i];
        }
        if (arr[i]>max)
        {
            max = arr[i];
        }
    }
    diff = max - min;

    return diff;
}

Random random = new Random();
int size = random.Next(5,11);

double[] numbers = new double[size];

FillArray(numbers,-100,101);
PrintArray(numbers);

double diff = FindDiffMaxMin(numbers);
Console.WriteLine("Разница между максимальным и минимальным элементами массива = " + Math.Round(diff,2));

