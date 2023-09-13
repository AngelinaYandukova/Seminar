// Задача 63: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"
/*
// string PrintNum(int num, string res)
// {
//     if ( num == 1)
//     {
//         res = res + "1";
//         return res;
//     }
//     else 
//     {
//         res = res + num;
//         return PrintNum(num - 1, res);
//     }
// результат будет 54321. Можно поменять местами res и num
// в строковом типе данных
// }

string PrintNum(int num, string res)
{
    if (num == 1)
    {
        res = "1" + " " + res;
        return res;
    }
    else 
    {
        res = num + " " + res;
        return PrintNum(num - 1, res);
    }
}
// Вывод: 1 2 3 4 5

// Еще вариант решения

// string PrintNumbers(int start, int end)
// {
// if (start == end) return start.ToString();
// return (start + " " + PrintNumbers(start + 1, end));
// }
// Console.WriteLine(PrintNumber(1, 8));

string result = "";
Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
result = PrintNum(number, result);
Console.WriteLine(result);
*/

// Задача 65: Задайте значения M и N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"
/*
string PrintNumbers(int start, int end)
{
if (start == end) return start.ToString();
return (start + " " + PrintNumbers(start + 1, end));
}
Console.WriteLine(PrintNumber(1, 8));
*/

// Задача 67: Напишите программу, которая будет принимать на вход число
// и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9
/*
int SumDigits(int number)
{
    if(number == 0)
        return 0;
    else
        return number % 10 + SumDigits(number/10);
}
// S(45) --> 5 + S(4) --> 5+4 + S(0) --> 5+4+0=9
Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumDigits(number));
*/

// Задача 69: Напишите программу, которая на вход принимает два числа A 
// и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8
/*
int PowerAB(int a, int b)
{
    if (b == 0)
        return 1;
    return a * PowerAB(a, b -1);
// 5*P(5, 3-1) --> 5*5 P(5, 1) --> 5*5*5 P(5, 0) --> 5*5*5*1 --> 125
}
Console.WriteLine(PowerAB(5, 3));
*/
