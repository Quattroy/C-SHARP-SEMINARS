//Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
//может ли существовать треугольник с сторонами такой длины.
//Теорема о неравенстве треугольника: каждая сторона треугольника меньше 
//суммы двух других сторон
int num1 = GetNum("Введите положительное значение A ", "Ошибка ввода!");
int num2 = GetNum("Введите положительное значение B ", "Ошибка ввода!");
int num3 = GetNum("Введите положительное значение C ", "Ошибка ввода!");

bool result = GetResult(num1, num2, num3);
string strResult = result ? "Существует" : "Не существует";
Console.WriteLine($"Треугольник со сторонами {num1} {num2} {num3} -> {strResult}");



int GetNum(string message, string error)
{
    int num = 0;
    while (true)
    {
        try
        {
            Console.Write(message);
            num = int.Parse(Console.ReadLine() ?? "");
            if (num > 0) break;
            else Console.Write(error);
        }
        catch (Exception exc)
        {
            Console.Write($"{error} {exc.Message}");
        }
    }
    return num;
}

bool GetResult(int A, int B, int C)
{
    if(A<(B+C) && B<(A+C) && C<(A+B)) return true;
    else return false;
    
}

