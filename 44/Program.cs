//Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
//Если N = 5 -> 0 1 1 2 3
//Если N = 3 -> 0 1 1
//Если N = 7 -> 0 1 1 2 3 5 8

Console.Clear();
int UserNumber = GetNumber("Введите целое положительное число ", "Ошибка ввода!");
int[] array = Fibonacci(UserNumber);
Console.WriteLine($"{UserNumber} -> {String.Join(", ", array)}");


int GetNumber(string message, string error)
{
    while(true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if(isCorrect && userNumber>0)
            return userNumber;
        Console.WriteLine(error);

    }
}

int[] Fibonacci(int num)
{
    int[] arr = new int[num];
    if(num == 1)
    {
        arr[0] = 0;
    }
    else
    {
        arr[0] = 0;
        arr[1] = 1;
        for(int i = 2; i < num; i++)
        {
            arr[i] = arr[i-1] + arr[i-2];
        }
    }
    return arr;
}
