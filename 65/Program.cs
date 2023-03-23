// Задача 65: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

Console.Clear();
int M = GetNum("Введите натуральное значение M ", "Ошибка ввода!");
int N = GetNum("Введите натуральное значение N ", "Ошибка ввода!");
string result = GetResult(M, N);
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

string GetResult(int M, int N)
{
    if(M == N) return N.ToString();
    {
    return (M + " " + GetResult(M+1, N));
    }

}
