/* Напишите программу, которая выводит случайное число из отрезка [10, 99] и 
показывает наибольшую цифру числа. */
//int num = new Random().Next(10, 100);
//Console.WriteLine(num);
/* int dig1 = num / 10;
int dig2 = num % 10;
int max = dig2;
if (dig1 > dig2)
{
    max = dig1;
} */
//Console.WriteLine($"В числе {num} максимальная цифра {max}");
//Console.WriteLine(dig1);
//Console.WriteLine(dig2);
// dotnet new gitignore
int MaxDigit(int num)
{
    int dig1 = num / 10;
    int dig2 = num % 10;
    int max = dig2;
    if (dig1 > dig2)
    {
        max = dig1;
    }
    return max;
}
int number = new Random().Next(10, 100);
int maxDigit=MaxDigit(number);
Console.WriteLine($"В числе {number} максимальная цифра {maxDigit}");