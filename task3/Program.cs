// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и
// минимальным элементов массива.
// [3 7 22 2 78] -> 76




double[] array = new double[10];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 11);
    System.Console.WriteLine($"Индекс {i} = {array[i]}; ");
}
System.Console.WriteLine();

double max = array[0];
double min = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
}
for (int i = 0; i < array.Length; i++)
{
    if (array[i] < min)
    {
        min = array[i];
    }
}

double result = GetResult();
double GetResult()
{
    double sum = 0;
    sum = max - min;
    return sum;
}

System.Console.WriteLine($"Разница между максимальным и минимальным значениями: {result}");
