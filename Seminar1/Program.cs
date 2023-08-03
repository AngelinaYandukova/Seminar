// Seminar 1
// Theory
/*
int intNumber = 25; 
double doubleNumber = 12.12; 
string text = "some text";
bool logicVar = true;

int num = 5;
Console.WriteLine(num);
Console.WriteLine("My number is " + num);

int num1 = 15;
int num2 = 54;
Console.WriteLine("My numbers are " + num1 + " and " + num2 + " and it is good!");
Console.WriteLine($"My numbers are {num1} and {num2} and it is good!");

Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Your number is " + num);
*/

// Task 1. Напишите программу, которая на вход принимает два числа и проверяет, 
// является ли первое число квадратом второго.
/*
Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int quad2 = num2 *num2;

if(num1 == quad2)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}

Фигурные скобки группируют набор команд. Если в скобках одна завершенная команда, можно обойтись без них.
if(num1 == quad2) Console.WriteLine("Yes");
else Console.WriteLine("No");
*/

// Task 2. Напишите программу, которая на вход принимает положительное число (N),
// а на выходе показывает все целые числа в промежутке от -N до N.
/*
Console.WriteLine("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

int current = -num;

while(current <= num)
{
    Console.Write(current + " ");
    current++;
}
*/
