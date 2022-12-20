// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int FindSum (int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 0)
        {
           sum = sum + 0;
        }
        else
        {
            sum = sum + array[i];
        }
    }
    return sum;
}

int[] array = CreateMassive(5, -9, 9);
int sum = FindSum(array);
Console.WriteLine($" -> {sum}");