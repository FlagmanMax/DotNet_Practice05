// Задача 34: Задайте массив заполненный случайными
// положительными трёхзначными числами. Напишите
// программу, которая покажет количество чётных чисел в
// массиве.
// [345, 897, 568, 234] -> 2
void FillArray(int[] arr)
{
    Random random = new Random();

    for (int i=0;i<arr.Length;i++)
    {
        arr[i] = random.Next(100,1000);
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

int CountOddNumbers(int[] arr)
{
    int count = 0;
    for (int i=0;i<arr.Length;i++)
    {
        if (arr[i]%2 == 0)
        {
            count++;
        }
    }
    return count;
}

Random random = new Random();
int length = random.Next(3,11);

int[] array = new int[length];

FillArray(array);
PrintArray(array);
int oddNumbers = CountOddNumbers(array);
Console.WriteLine("Число четных чисел в массиве = "+oddNumbers);