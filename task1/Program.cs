// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] array = new int[5];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
    System.Console.Write($"{array[i]}; ");
}

void Task(int[] array)
{
    int summ = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            summ++;
            System.Console.WriteLine($"Четный индекс: {i}");
            
        }
    }
    System.Console.Write($"Количество четных чисел: {summ}");
    
}

System.Console.WriteLine();
System.Console.WriteLine(" ");
Task(array);

