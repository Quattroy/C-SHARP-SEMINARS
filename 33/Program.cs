// Задача 33: Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве.

Console.Clear();
int length = Write("Длина массива: ");
int min = Write("Начальное значение для диапазона случайных чисел: ");
int max = Write("Конечное значение для диапазона случайных чисел: ");
int num = Write("Число для поиска: ");
int[] array = GetArray(length, min, max);


bool result = GetRevers(array, num);
Console.WriteLine(String.Join(" ", array));
PrintResult();

//Console.WriteLine($"Замена элементов массива {array} будет равна {GetRevers}");
//////////////////////////////////////////////////////////////////////////////////

int Write(string message)
{
    Console.Write(message);
    string ReadInput = Console.ReadLine();
    int result = int.Parse(ReadInput);
    return result;
}

int[] GetArray(int length, int min, int max)
{
    int[] res = new int[length];
    for (int i = 0; i < length; i++)
    {
        res[i] = new Random().Next(min, max + 1);
    }
    return res;
}

bool GetRevers(int[] arr, int N)
{
    bool positiveSum = false;
    foreach (int el in arr)
    {
        if (el == N)
            positiveSum = true;
    }
    return positiveSum;
}
void PrintResult()
{
    if (result == true) Console.WriteLine($"заданное число {num} -> есть в массиве");
    else Console.WriteLine($"заданное число {num} -> нет в массиве");
}