Console.Write ("Введите номер дня недели от 1 до 7: "); 
int userNumber1 = int.Parse(Console.ReadLine() ?? ""); 
if (userNumber1 == 1)
    Console.Write ("Понедельник");
else if (userNumber1 == 2)
    Console.Write ("Вторник");
else if (userNumber1 == 3)
    Console.Write ("Среда");
else if (userNumber1 == 4)
    Console.Write ("Четверг");
else if (userNumber1 == 5)
    Console.Write ("Пятница");
else if (userNumber1 == 6)
    Console.Write ("Суббота");
else if (userNumber1 == 7)
    Console.Write ("Воскресенье");
else    
    Console.Write ("Вы ввели некорректное число!"); 
    