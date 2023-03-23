// Задача 67: Напишите программу, которая будет 
// принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.Clear();
int N = GetNum("Введите натуральное значение N", "Ошибка ввода!");
int result = GetResult(N);
Console.WriteLine(result);



///////////////////////////////////////////////

int GetNum(string message, string error)
{
    while (true)
    {
        Console.WriteLine(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int num);
        if (isCorrect && num > 0) return num;
        else Console.WriteLine(error);
    }
}

int GetResult(int N)
{
    if (N == 0) return 0;
    else
    {
        return N % 10 + GetResult(N / 10);
    }
}
