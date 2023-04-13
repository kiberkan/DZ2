// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.WriteLine("Введите число от 1 до 7");
int day = Convert.ToSByte(Console.ReadLine());
if (day >= 1 && day <= 7)
{
    if (day == 6 | day == 7)
    {
        System.Console.WriteLine($"{day} день недали выходной!");
    }
    else
    {
        System.Console.WriteLine($"{day} день недали не является выходным");
    }
}
else
{
System.Console.WriteLine($"{day} дня недели не существует");
}
