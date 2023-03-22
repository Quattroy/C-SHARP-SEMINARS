// Задача 53: Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.

Console.Clear();
int rows = GetUserNum("Введите количество строк массива: ", "Ошибка ввода!");
int columns = GetUserNum("Введите количество столбцов массива: ", "Ошибка ввода!");
int[,] array = GetArray(rows, columns);
int[,] arrayNew = ChangeArray(array);
Console.WriteLine();
PrintArray(arrayNew);

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
int[,] ChangeArray(int[,] array)
{
    int[,] changedArray = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == 0)
            {
                changedArray[0, j] = array[array.GetLength(0) - 1, j];
            }
            else if (i == array.GetLength(0) - 1)
            { changedArray[array.GetLength(0) - 1, j] = array[0, j]; }
            else changedArray[i, j] = array[i, j];
        }
    }
    return changedArray;
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