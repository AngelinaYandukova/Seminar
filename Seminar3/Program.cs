// Theory
/*
// Команды из блока Math возвращают тип double

Console.WriteLine(Math.Pow(5, 2)); // 5^2 = 25
Console.WriteLine(Math.Sqrt(24)); // корень из 25 = 5, кор. из 24 = 4,8989
// Можно Math.Pow(25, 0,5) - тоже корень, но sqrt оптимизированнее и быстрее.
Console.WriteLine(Math.Round(Math.Sqrt(24), 2));
Console.WriteLine(Math.Round(4.7529, 2)); // округляет. второй аргумент - 
// степень точности округления (до двух знаков после запятой)
*/

// 1. Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).
/*
void WriteRange(int quadrant)
{
    if(quadrant <1 || quadrant > 4) Console.WriteLine("Uncorrect data!");
    else if(quadrant == 1) Console.WriteLine("x > 0, y > 0");
    else if(quadrant == 2) Console.WriteLine("x < 0, y > 0");
    else if(quadrant == 3) Console.WriteLine("x < 0, y < 0");
    else Console.WriteLine("x > 0, y < 0");
}

Console.Write("Input a number of quadrant: ");
int quad = Convert.ToInt32(Console.ReadLine());

WriteRange(quad); 
// Не пишем a = WriteRange(quad);, в переменные не записывают результат
// войдовских методов, т.к. нет результата (нет величины которую мы могли
// бы в какую-то переменную записать)
*/

// 2. Напишите программу, которая принимает на вход координаты точки 
// (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, 
// в которой находится эта точка.
/*
int Quadrant(int x, int y)
{
    if(x > 0 && y > 0) return 1;
    else if(x < 0 && y > 0) return 2;
    else if(x < 0 && y < 0) return 3;
    else if(x > 0 && y < 0) return 4;
    return 0; // если точка находится на оси, четверть определить невозможно
}

Console.Write("Input x: ");
int xnum = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y: ");
int ynum = Convert.ToInt32(Console.ReadLine());

int quad = Quadrant(xnum, ynum);
if (quad == 0) Console.WriteLine($"The point with coordinates ({xnum}, {ynum}) is on the axis, it is impossible to determine the quarter.");
else Console.WriteLine($"The point with coordinates ({xnum}, {ynum}) is in the quadrant {quad}.");
*/

// 3. Напишите программу, которая принимает на вход число (N) и 
// выдаёт квадраты чисел от 1 до N.
/*
void Quad(int n)
{
    if (n < 1) Console.WriteLine("Uncorrect number!");
    int current = 1;
    while (current <= n) 
    {
        Console.WriteLine($"{current} - {current * current}"); // Когда квадрат можно просто n*n - будет быстрее, чем
        // Console.WriteLine(Math.Pow(current, 2)); 
        // Math.Pow целесообразнее использовать, когда n^8 (большая степень).
        current++;
    }
}

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

Quad(number);
*/

// 4. Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 2D пространстве.
/*
double Distance(double x1, double y1, double x2, double y2)
{
    double x = x2 - x1;
    double y = y1 - y2;
    double dist = Math.Sqrt(x*x + y*y);
    return dist;
}

Console.Write("Input x1: ");
double x1num = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y1: ");
double y1num = Convert.ToDouble(Console.ReadLine());
Console.Write("Input x2: ");
double x2num = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y2: ");
double y2num = Convert.ToDouble(Console.ReadLine());

double distance = (Math.Round(Distance(x1num, y1num, x2num, y2num), 2));
Console.WriteLine($"The distance between two points with coordinates ({x1num}, {y1num}) and ({x2num}, {y2num}) is {distance}.");
*/