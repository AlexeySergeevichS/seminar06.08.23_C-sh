/* 
Напишите программу, которая выводит случайное трехзначное число и 
удаляет вторую цифру этого числа.

456 -> 46
782 -> 72
918 -> 98 
*/

int DelDigit(int num)
{
    int dig1 = num / 100;
    //int dig2= num/10%10;
    int dig3 = num % 10;
    return dig1 * 10 + dig3;
}
int number = new Random().Next(100, 1000);
int newNumber = DelDigit(number);
Console.WriteLine($"Из числа {number} получим {newNumber}");