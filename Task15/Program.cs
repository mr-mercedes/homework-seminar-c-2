Console.WriteLine("Задача №15:Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");
Console.WriteLine("Введите число :");
int day = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Week(day) + "-" + ChekHollyday(Week(day)));


string Week(int day)
{
    if (day == 1)
    {
        string stringDay = Convert.ToString(day);
        stringDay = "Понедельник";
        return stringDay;
    } 
     if (day == 2)
    {
        string stringDay = Convert.ToString(day);
        stringDay = "Вторник";
        return stringDay;
    }
     if (day == 3)
    {
        string stringDay = Convert.ToString(day);
        stringDay = "Среда";
        return stringDay;
    }
     if (day == 4)
    {
        string stringDay = Convert.ToString(day);
        stringDay = "Четверг";
        return stringDay;
    }
     if (day == 5)
    {
        string stringDay = Convert.ToString(day);
        stringDay = "Пятница";
        return stringDay;
    }
     if (day == 6)
    {
        string stringDay = Convert.ToString(day);
        stringDay = "Суббота";
        return stringDay;
    }
     if (day == 7)
    {
        string stringDay = Convert.ToString(day);
        stringDay = "Воскресенье";
        return stringDay;
    } 
    else
    {
        string stringDay = Convert.ToString(day);
        stringDay = "В неделе 7 дней, введите число от 1 до 7!";
        return stringDay;
    }
          
}

string ChekHollyday(string day)
{
    if ( day == "Суббота" || day == "Воскресенье")
    {
        day = "Выходной день";
        return day;
    }
    if( day == "В неделе 7 дней, введите число от 1 до 7!")
    {
        day = " Чтобы программа работала корректно.";
        return day;
    }
    else
    {
        day = "Рабочий день";
        return day;
    }
}