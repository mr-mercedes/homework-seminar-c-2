Console.WriteLine("Задача дополнительная: Игра угадайка.");
Console.WriteLine("Инструкция: Программа загадывает случайное число. Пользователь его угадывает. Если пользователь дает неправильный ответ, то программа сообщает, больше загаданное число или меньше ");
int secretNumber = RandomNumber(1, 1000);
int turn = 0;
while(turn <= 2)
{
    Console.Write("Введите число: ");
    int userNumber = Convert.ToInt32(Console.ReadLine());
    if (userNumber == secretNumber)
    {
        Console.WriteLine($"Ура! Вы побидили Загаданное число {secretNumber}");
        break;
    }
    if (userNumber > secretNumber)
    {
        Console.WriteLine($"Число {userNumber} больше загадонного числа");
        turn++;
        if(turn == 3)
        {
           Console.WriteLine($"Вы проиграли, загаданное число {secretNumber}"); 
        }
    }
    else
    {
        Console.WriteLine($"Число {userNumber} меньше загадонного числа");
        turn++;
         if(turn == 3)
        {
           Console.WriteLine($"Вы проиграли, загаданное число {secretNumber}"); 
        }
    }
}


int RandomNumber(int number1, int number2)
{
    return new Random().Next(number1, number2);
}