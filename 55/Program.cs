// Задача 55: Задайте двумерный массив. Напишите программу,
//  которая заменяет строки на столбцы. В случае, если это невозможно
//  программа должна вывести сообщение для пользователя.

Console.Clear();
int rows = GetUserNum("Введите количество строк массива: ", "Ошибка ввода!");
int columns = GetUserNum("Введите количество столбцов массива: ", "Ошибка ввода!");
int[,] array = GetArray(rows, columns);
int[,] change = GetChangedArray(array);
Console.WriteLine();
PrintArray(change);

int GetUserNum(string message, string error)
{
    while (true)
    {
        Console.WriteLine(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int num);
        if (isCorrect && num > 0) return num;
        else Console.WriteLine(error);
    }
}


int[,] GetArray(int rows, int columns)
{
    int[,] arr = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            arr[i, j] = new Random().Next(-100, 100);
            Console.Write($"{arr[i, j]}\t");
        }
        Console.WriteLine();
    }
    return arr;
}

int[,] GetChangedArray(int[,] arr)
{
    int[,] result = new int[arr.GetLength(1), arr.GetLength(0)];//меняем местами столбцы со строками
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            result[j, i] = arr[i, j];
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
            Console.Write($"{inArray[i, j]}\t");
        }
        Console.WriteLine();
    }
}