// Решение в группах задач:
// Задача 49: Задайте двумерный массив. Найдите элементы, 
// у которых оба индекса нечётные, и замените эти элементы на их квадраты.


Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

SquarOddIndexes(array);
Console.WriteLine();
PrintArray(array);



int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void SquarOddIndexes(int[,] arr)
{
    for (int i = 1; i < arr.GetLength(0); i+=2)
    {
        for (int j = 1; j < arr.GetLength(1); j+=2)
        {
            arr[i, j] = arr[i, j] * arr[i, j];
        }
    }
}
