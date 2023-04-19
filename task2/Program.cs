// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = new int[10];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-50, 100);
    System.Console.WriteLine($"Индекс {i} = {array[i]}; ");
}
System.Console.WriteLine();

OddIndesex();
void OddIndesex()
{
    
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 != 0)
        {
            System.Console.WriteLine($"Нечетные индексы: {i}");
            
        }
    }
    System.Console.WriteLine();
}

int summ = OddSum();
int OddSum()
{
    int summ = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2!=0)
        {
            summ +=array[i];
        }
    }
    return summ;
}


System.Console.WriteLine($"Сумма нечетных чисел: {summ}");
System.Console.WriteLine();