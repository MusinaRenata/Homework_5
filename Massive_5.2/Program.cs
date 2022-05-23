// 2. Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

int[] array = new int[5];
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 15);
    Console.Write(array[i] + " ");

    if (i % 2 > 0)
    {
        sum = sum + array[i];
    }
}

Console.WriteLine(" ");
Console.WriteLine(sum);