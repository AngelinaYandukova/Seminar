// Задачи
// 1. Напишите программу, которая принимает на вход число (А) 
// и выдаёт сумму чисел от 1 до А.
/*
int Sum(int a)
{
    int current = 1;
    int sum = 0;
    while (current <= a)
    {
        sum = sum + current;
        current++;
    }
    return sum;
}

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = Sum(number);
Console.WriteLine($"Sum is {result}.");
*/

// Решение через цикл for:
/*
int Sum(int a)
{
    int sum = 0;
    for (int i = 1; i <= a; i++)
        sum += i;
    return sum;
}

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = Sum(number);
Console.WriteLine($"Sum is {result}.");
*/

// 2. Напишите программу, которая принимает на вход число и 
// выдаёт количество цифр в числе.
/*
int Digit(int num)
{
    int count = 0;
    while (num >= 1)
    {
        num = num / 10;
        count++;
    }
    return count;
}

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = Digit(number);
Console.WriteLine($"There are {result} digits in the number {number}.");
*/

// Через for
/*
int Digit(int num)
{
    int count = 0; 
    for (; num >= 1; count++)
        num = num / 10;

    return count;
}
// В for (count = 0; num >= 1; count++) count - локальная переменная,
// return про count не знает и будет ошибка:
// Имя "count" не существует в текущем контексте.

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = Digit(number);
Console.WriteLine($"There are {result} digits in the number {number}.");
*/

// 3. Напишите программу, которая принимает на вход число N и 
// выдаёт произведение нечетных чисел от 1 до N.
/*
int Product(int n)
{
    int current = 1;
    int prod = 1;
    while (current <= n)
    {
        prod = prod * current;
        current = current + 2;
    }
    return prod;
}

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = Product(number);
Console.WriteLine($"Product is {result}.");
*/

// Через for
/*
int Product(int n)
{
    int prod = 1;
    for (int current = 1; current <= n; current = current + 2)
        prod *= current;
    
    return prod;
}

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = Product(number);
Console.WriteLine($"Product is {result}.");
*/

// Theory -- Массивы

// Метод для генерации массива

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size]; // инициализация памяти под массив
    // (объявление массива).
    // Важно! Обычно в [] указывается индекс, но тут размер массива

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1); 
        // так как [рандом) --> добавляем единицу, чтобы мог сгенерировать
        // верхний предел

    return array;
}

// Генерация массива, когда пользователь вводит числа
int[] EnterNewArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите элемент массива под индексом {i}");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

// Метод для вывода массива на экран
// void так как взаимодействует непосредственно с экраном

void WriteArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

Console.Write("Input a length of an array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length, min, max);
WriteArray(myArray);