// Задача 35: Задайте одномерный массив из 123 случайных чисел. 
//Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
//Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
//[5, 18, 123, 6, 2] -> 1
//[1, 2, 3, 6, 2] -> 0
//[10, 11, 12, 13, 14] -> 5

Console.Clear();
int length = Write("Длина массива: ");
int min = Write("Начальное значение для диапазона случайных чисел: ");
int max = Write("Конечное значение для диапазона случайных чисел: ");

int[] array = GetArray(length, min, max);
int result = GetResult(array);

Console.WriteLine(result);

//GetRevers(array, num);

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
int GetResult(int[] arr)
{
    int count = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i]>=10 && arr[i]<=99) 
        count ++;
    }
    return count;
}