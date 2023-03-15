//Задача 45: Напишите программу, которая будет создавать 
//копию заданного массива с помощью поэлементного копирования.

int lenght = GetUserNumber("Введите длину массива ", "Некорректное значение!");
int minNum = GetUserNumber("Введите минимальное значение элемента массива ", "Некорректное значение!");
int maxNum = GetUserNumber("Введите максимальное значение элемента массива ", "Некорректное значение!");

int[] array = GetArray(lenght, minNum, maxNum);

int[] arrayCopy = GetCopy(array);

Console.WriteLine($"Копия массива {String.Join(", ", array)} равна {String.Join(", ", arrayCopy)}");


int GetUserNumber(string message, string error)
{
    while(true)
    {
        Console.WriteLine(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int num);
        if(isCorrect && num > 0)
            return num;
        Console.WriteLine(error);

    }
}

int[] GetArray(int leng, int min, int max)
{
    int[] arr = new int[leng];
    for(int i = 0; i < leng; i++)
    {
        arr[i] = new Random().Next(min, max);
    }
    return arr;
}

int[] GetCopy(int[] arr)
{
    int[] copy = new int[arr.Length];
    for(int i = 0; i < arr.Length; i++)
    {
        copy[i] = arr[i];
    }
    return copy;
}