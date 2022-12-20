// Задайте массив вещественных чисел. Найдите разницу между максимальным 
// и минимальным элементов массива.
// [3 7 22 2 78] -> 76

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

int FindRes (int[] array)
{
    int max = array[0];
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (max < array[i])
        {
            max = array[i];
        }
        if (min > array[i])
        {
            min = array[i];
        }  
    }
    int res = max - min;
    return res;
}

int[] array = CreateMassive(5, 0, 99);
int res = FindRes(array);
Console.WriteLine($" -> {res}");