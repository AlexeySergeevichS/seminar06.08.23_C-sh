/*
 Напишите программу, которая будет принимать на вход два числа и 
выводить, является ли второе число кратным первому. 
Если число 2 не кратно числу 1, то программа выводит остаток от деления.

34, 5 -> не кратно, остаток 4
16, 4 -> кратно
 */
/* int Kratno(int num1,int num2)
{
    return num1%num2;
}
Console.Write("Введи число 1 : ");
int number1 = int.Parse(Console.ReadLine()!);
Console.Write("Введи число 2 : ");
int number2 = int.Parse(Console.ReadLine()!);
int rem=Kratno(number1,number2);
if (rem>0)
{
    Console.WriteLine($"Число {number1} не кратно числу {number2}, остаток {rem}");    
}
else
{
    Console.WriteLine($"Число {number1} кратно числу {number2}");    
} */

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
bool Multipiity(int num1, int num2)
{
    // if (num1 % num2 == 0)
    // {
    //     return true;
    // }
    // return false;
    return num1 % num2 == 0
}
void CheckResult(bool mult,int num1,int num2)
{
    if (mult)
    {
        Console.WriteLine($"Число {num1} кратно числу {num2}");
    }
    else
    {
        Console.WriteLine($"Число {num1} не кратно числу {num2}, остаток {num1 % num2}");
    }

}
int num1 = InputNum("Введи число 1: ");
int num2 = InputNum("Введи число 2: ");
bool result = Multipiity(num1, num2);
CheckResult(result,num1,num2);
