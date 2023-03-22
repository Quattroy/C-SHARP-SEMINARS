// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, 
// сколько раз встречается элемент входных данных.

Console.Clear();

int rows = InputValue("Введите количество строк массива: ");
int columns = InputValue("Введите количество столбцов массива: ");
int minimum = InputValue("Введите минимальное значение: ");
int maximum = InputValue("Введите максимальное значение: ");
int[,] array = GetArray(rows, columns, minimum, maximum);
int[] count = GetCountElements(array, minimum, maximum);
PrintArray(array);
Console.WriteLine();
PrintResult(minimum, count);
//////////////////////////////////////////////////////////////////////////////////////////////// 

static int InputValue(string message)
{
    try
    {
        Console.Write(message);
        return (int.Parse(Console.ReadLine() ?? ""));
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
        return 0;
    }
}

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

int[] GetCountElements(int[,] arr, int minValue, int maxValue)
{
    int[] result = new int[maxValue + 1 - minValue];
    for (int k = 0; k < result.Length; k++)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (arr[i, j] == minValue)
                    result[k] += 1;
            }
        }
        minValue += 1;
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void PrintResult(int minimum, int[] count)
{
    for (int i = 0; i < count.Length; i++)
    {
        if (count[i] != 0) Console.WriteLine($"{minimum} встречается {count[i]} раз(а)!");
        minimum += 1;
    }
}