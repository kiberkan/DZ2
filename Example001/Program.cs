// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

int GetRandomDigit (int minDigit = 100, int maxDigit = 999) // Функция. Генерация рандомного 3х значного числа
{
    int num = new Random().Next(minDigit,maxDigit);
    return num;
}

int ViewSecondDigit (int number) // Функция. Показывает вторую цифру числа
{
    int result = (number / 10) % 10;
    return result;
}
int number = GetRandomDigit();
System.Console.WriteLine(number);
System.Console.WriteLine(ViewSecondDigit(number));