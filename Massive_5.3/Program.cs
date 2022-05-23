// 3. Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.

double MaxArray(double[] array)
{
    int length = array.Length;
    double max = array[0];
    for (int i = 0; i < length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}
double MinArray(double[] array)
{
    int count = array.Length;
    double min = array[0];
    for (int j = 0; j < count; j++)
    {
        if (array[j] < min) min = array[j];

    }
    return min;
}

double[] massive = { 50, 2, -8.3, 17, -2 };
double result = MaxArray(massive) - MinArray(massive);

Console.WriteLine(MaxArray(massive));
Console.WriteLine(MinArray(massive));
Console.WriteLine();
Console.WriteLine(result);