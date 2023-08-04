// Theory

/*
Целочисленное деление:
13254 / 10 = 1325
13254 / 100 = 132 
13254 / 1000 = 13
13254 / 10000 = 1
Когда делим нацело на 10 в степени - избавляемся от младших разрядов 
(какая степень десятки - столько разрядов смещается)

13254 % 10 = 4
13254 % 100 = 54
13254 % 1000 = 254
13254 % 10000 = 3254

Задача: 24365 -> 43
1) num = 24365 / 100 = 243
2) findNum = num % 100 = 43
*/

// 1. Напишите программу, которая выводит случайное трёхзначное число и 
// удаляет вторую цифру этого числа.
// 351 -> 3 1 -> 31
/*
int CutNumber(int num)
{
    int hundreds = num / 100;
    int units = num % 10;

    int res = hundreds * 10 + units;
    return res;
}
// В коротких методах можно так:
// return hundreds * 10 + units;

int randNum = new Random().Next(100, 1000);

int newNum = CutNumber(randNum);
Console.WriteLine($"New version of {randNum} is {newNum}");
*/

// 2. Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно a и b.
/*
bool IsDivisible(int num, int div1, int div2)
{
    // if (num % div1 == 0 && num% div2 == 0)
    //    return true;
    // else
    //    rerurn false;

    return num % div1 == 0 && num% div2 == 0;
}

Console.Write("Input a number for checking: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a first divider: ");
int divider1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second divider: ");
int divider2 = Convert.ToInt32(Console.ReadLine());

bool res = IsDivisible(number, divider1, divider2);

// Console.WriteLine(res); Выведет true/false. Но можно так ->:
if(res) Console.Write("Да, число кратно введенным числам.");
else Console.Write("Нет, число не кратно.");
*/

// 3. Напишите программу, которая выводит случайное число из отрезка
// [10, 99] и показывает наибольшую цифру числа.
/*
int MaxFigure(int num)
{
    int tens = num / 10;
    int units = num % 10;

    if (tens > units) return tens;
    else return units;
}
int newNum = new Random().Next(10, 100);
int res = MaxFigure(newNum);
Console.Write($"В числе {newNum} наибольшая цифра равна {res}.");
*/

// 4. Напишите программу, которая принимает на вход два числа и проверяет,
// является ли одно число квадратом другого.

bool IsSquare(int num1, int num2)
{
    return num1 == num2 * num2 || num2 == num1 * num1;
}
Console.Write("Input a first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());

bool res = IsSquare(number1, number2);
if(res) Console.WriteLine($"Да, одно число явлется квадратом другого.");
else Console.WriteLine($"Нет, одно число не явлется квадратом другого.");
