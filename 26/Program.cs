// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
int num = GetNum("Введите целое число: ", "Ошибка ввода");
int result = GetSumNumbers(num);
PrintResult(num, result);



int GetNum(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect) //&& userNumber>=0
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}
// Возвращает сумму чисел от 1 до number
int GetSumNumbers(int number)
{
    if(number < 0) number *= -1;
    int count = 0;
    if(number == 0) count = 1;
    while (number > 0)
    {
        count++;
        number /= 10; //number = number /10;
    }
    return count;
}

static void PrintResult(int num, int result)
{
Console.WriteLine($"количество цифр числа {num} равно {result}");
}