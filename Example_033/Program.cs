// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

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

int FindValue(int[] arr,int value)
{
    int index = -1;
    for (int i=0;i<arr.Length;i++)
    {
        if (arr[i] == value)
        {
            index = i;
            break;
        }
    }
    return index;
}

int size = 12;
int[] numbers = new int[size];

Console.WriteLine("Введите число для поиска");
int searchValue = Convert.ToInt32(Console.ReadLine());

FillArray(numbers,-9,9);
PrintArray(numbers);

int isFound = FindValue(numbers,searchValue);
if (isFound<0)
{
    Console.WriteLine($"Числа {searchValue} нет в массиве");
}
else
{
    Console.WriteLine($"Число {searchValue} есть в массиве");
}