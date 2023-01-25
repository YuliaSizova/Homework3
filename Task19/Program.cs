/*Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

System.Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 9999 && num < 100000)
{
    if (num / 10000 == num % 10 && num / 1000 % 10 == num % 100 / 10)
    {
        System.Console.WriteLine($"{num} -> {"да,палиндром"}");
    }
    else
    {
        System.Console.WriteLine($"{num}->{"нет,это не полиндром"}");
    }
}

else

{
    System.Console.WriteLine("Введите пятизначное число");
}
