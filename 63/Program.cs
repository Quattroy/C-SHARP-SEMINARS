// Задача 63: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

Console.Clear();
int N = GetNum("Введите натуральное значение N", "Ошибка ввода!");
string result = GetResult(1, N);
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

string GetResult(int start, int N)
{
    if(start == N) return N.ToString();
    {
    return (start + " " + GetResult(start+1, N));
    }

}
