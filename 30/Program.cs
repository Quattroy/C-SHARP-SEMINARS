// Решение в группах задач:
//Задача 30: Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.

int[] array = InputArray();
PrintArray(array);
//Console.WriteLine($"[{String.Join(",", array)}]");

static int[] InputArray()
{
    int[] arr = new int [8];
    for(int i = 0; i < 8; i++)
    {
        arr[i] = new Random().Next(0,2);
    }
    return arr;
}

static void PrintArray(int[] array)
{
    int lenght = array.Length;
    Console.Write("[");
    for(int i = 0; i < lenght-1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine($"{array[lenght-1]}]");
}
