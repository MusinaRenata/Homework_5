// 1. Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

void FillArray(int[] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}
void PrintArray(int[] arr)
{
    int count = arr.Length;
    for (int j = 0; j < count; j++)
    {
        Console.WriteLine(arr[j]);
    }
}

int[] array = new int[10];
FillArray(array);
PrintArray(array);

int x = array.Length;
int a = 0;
for (int k = 0; k < x; k++)
{
    if (array[k] % 2 == 0) a++;    
}
Console.WriteLine($"a: {a} ");
