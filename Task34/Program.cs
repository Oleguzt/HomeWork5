// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] CreateMassive(int count, int begin, int end)
{
    int[]array = new int[count];
    for (int i=0; i < count; i++)
    {
        array[i] = new Random().Next(begin, end + 1);
    }   
    Console.Write($"[{String.Join(", ", array)}]");
    return array;
}

int FindEven(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

int[] array = CreateMassive(5, 100, 999);
int even = FindEven(array);
Console.WriteLine($" -> {even}");