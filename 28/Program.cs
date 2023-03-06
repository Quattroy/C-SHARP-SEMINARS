// Задача 28: Напишите программу, которая принимает на 
//вход число N и выдаёт произведение чисел от 1 до N.


Console.Clear();
int num = GetNumberFromUser("Введите целое число N: ", "Ошибка ввода!");
int result = GetMultiplication(num);
Console.WriteLine($"{num} -> {result}");


int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect && userNumber>0)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

int GetMultiplication (int number)
{
    int sum = 1;
    while (number > 0)
    {
        sum *= number;
        number--;
    }
    return sum;
}

