/* Напишите программу, которая принимает на вход два числа и
 проверяет, является ли одно число квадратом другого.

5, 25 -> да
-4, 16 -> да
25, 5 -> да
8,9 -> нет */

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
bool IfSquare(int num1, int num2)
{
    return num1 * num1 == num2 || num2 * num2 == num1;
}
int num1 = InputNum("Введи число 1: ");
int num2 = InputNum("Введи число 2: ");
string strRes = IfSquare(num1, num2) ? "является" : "не является";
System.Console.WriteLine($"Одно из чисел {strRes} квадратом другого");