// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
int NumberDigit (int number) // Функция. Проверка сколько знаков в числе
{
    int count = 0;
    while (number > 0)
    {
        number = number / 10;
        count++;
    }
    return count;
}

System.Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int numLen = NumberDigit(number);
if (numLen <= 2)
{
    System.Console.WriteLine("Третья цифра отсутствует");
}
else 
{
    if (numLen >= 3)
    {
        number = number / Convert.ToInt32(Math.Pow(10,numLen - 3)); // Этой срочкой отбрасывем правые числа пока оно не будет 3х значным
    }
    number = number % 10; // Показываем последний знак 3х значного числа
    System.Console.WriteLine($"Третья цифра {number}");
}