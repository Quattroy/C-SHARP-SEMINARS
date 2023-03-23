// Задача 69: Напишите программу, которая на 
// вход принимает два числа A и B, и возводит число А в 
// целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.Clear();
int A = GetNum("Введите натуральное значение A ", "Ошибка ввода!");
int B = GetNum("Введите натуральное значение B ", "Ошибка ввода!");
int result = GetResult(A, B);
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

int GetResult(int A, int B)
{
    if(B == 1) return A;
    return (A * GetResult(A, B-1));
    

}
