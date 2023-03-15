//Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
//45 -> 101101
//3  -> 11
//2  -> 10
Console.Clear();
int userNumber = GetNumberFromUser("Введите целое положительное число: ", "Ошибка ввода!");
int res = DiffResult1(userNumber);
string result = DiffResult2(userNumber);
int[] array = DiffResult3(userNumber);
Console.WriteLine($"Число {userNumber} в двоичной системе = {result}");
Console.WriteLine($"Число {userNumber} в двоичной системе = {res}");
Console.WriteLine($"Число {userNumber} в двоичной системе = {String.Join("", array)}");

int[] DiffResult3(int num)
{
    int size = 0;
    int number = num;
    while (number > 0)
    {
        number /= 2;
        size++;
    }
    int[] arr = new int[size];
    int i = size - 1;
    while (num > 0)
    {
        arr[i] = num % 2;
        i--;
        num /= 2;
    }
    return arr;
}
string DiffResult2(int num)
{
    string result = "";
    while (num > 0)
    {
        result = (num % 2) + result;
        num /= 2;
    }
    return result;
}
int DiffResult1(int num)
{
    int result = 0;
    int pow = 1;
    while (num > 0)
    {
        result += (num % 2) * pow;
        num /= 2;
        pow *= 10;
    }
    return result;
}
int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect && userNumber > 0)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}



