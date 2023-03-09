// Задача 32: Напишите программу замены элементов массива: 
//положительные элементы замените на соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2] 


Console.Clear();
int length = Write("Длина массива ");
int min = Write("Начальное значение для диапазона случайных чисел ");
int max = Write("Конечное значение для диапазона случайных чисел ");
int[] array = GetArray(length, min, max);
Console.WriteLine(String.Join(" ", array));

GetRevers(array);

Console.WriteLine(String.Join(" ", array));
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

void GetRevers(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = arr [i]*-1;
    }
}
