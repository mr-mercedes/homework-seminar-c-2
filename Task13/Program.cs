Console.WriteLine("Задача №13:Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");
Console.WriteLine("Введите число :");
int number = Convert.ToInt32(Console.ReadLine());
int index = 99;
if (number > index)
{
    string stringNumber = Convert.ToString(number);
    Console.WriteLine(stringNumber[2]);
}
else 
{
    Console.WriteLine("Третьего числа нет");
}