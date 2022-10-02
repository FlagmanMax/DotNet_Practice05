// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

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

void ChangeValues(int[] arr)
{
    int sum = 0;
    for (int i=0;i<arr.Length;i++)
    {
        arr[i] = -arr[i];
    }
}

int size = 12;
int[] numbers = new int[size];

FillArray(numbers,-9,9);
PrintArray(numbers);

ChangeValues(numbers);
PrintArray(numbers);
