Console.Write("Введите 1е число: ");
int userNumber1 = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите 2е число: ");
int userNumber2 = int.Parse(Console.ReadLine() ?? "");
int result = (int)Math.Pow(userNumber1, 2);
if (result == userNumber2)
{
    Console.Write("ДА");
}
else
{
    Console.Write("НЕТ");
}
