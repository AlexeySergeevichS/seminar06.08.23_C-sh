/* 
Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно
7 и 23.

14 -> нет
46 -> нет
161 -> да 
*/

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
bool Multipiity(int num)
{
       return num % 7 == 0 && num % 23 == 0;
}

int number = InputNum("Введи число : ");

bool result = Multipiity(number);
string strResult=result ? "Да": "Нет";

System.Console.WriteLine(strResult);
// if (result)
// {
//     System.Console.WriteLine("Да");
// }
// else
// {
//     System.Console.WriteLine("Нет");
// }