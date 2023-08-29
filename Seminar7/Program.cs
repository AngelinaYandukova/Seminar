// Двумерные массивы

// Задайте двумерный массив размером m×n, 
// заполненный случайными целыми числами.
/*
int[,] CreateRandom2dArray()
{
    Console.Write("input a quantity of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("input a quantity of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("input a min possible value: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("input a max possible value: ");
    int max = Convert.ToInt32(Console.ReadLine());
        
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++) // если нужно пройтись по каждой 
    // третьей строке -- i + 3 и тд (изменяем рабочую переменную как нужно)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(min, max + 1);
    
    return array;
}
// 1. Определили массив (инициализация)
// 2. Опр. логику прохождения по массиву
// 3. Задаем значение элементов (рандом)

// Метод для вывода массива

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        
        Console.WriteLine();
    }
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);

// Метод должен решать одну конкретную задачу, но тут решает две
// (запрос и создание массива). 
// Тут много аргументов и запрашивается много данных, которые больше нигде
// не будут использованы, кроме как при генерации этого массива.
// Если они понадобятся, можно будет узнать их, запросив элементы массива.
// Этот метод можно использовать, если точно знаем, что данные будет
// вводить пользователь.
// Можно сделать метод, который занимается запросом данных и принимает msg.
*/

// 1. Задайте двумерный массив размера m на n, каждый элемент в массиве 
// находится по формуле: Aij = i+j. Выведите полученный массив на экран.
/*
int[,] Array()
{
    Console.Write("input a quantity of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("input a quantity of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i,j] = i + j;

    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
}

int[,] myArray = Array();
Show2dArray(myArray);
*/

// 2. Задайте двумерный массив. Найдите элементы, у которых оба индекса 
// чётные, и замените эти элементы на их квадраты.
/*
int[,] CreateRandom2dArray()
{
    Console.Write("input a quantity of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("input a quantity of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("input a min possible value: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("input a max possible value: ");
    int max = Convert.ToInt32(Console.ReadLine());
        
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++) 
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(min, max + 1);
    
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        
        Console.WriteLine();
    }
}

void Quadrant(int[,] array)
{
    for (int i = 2; i < array.GetLength(0); i += 2)
    {
        for (int j = 2; j < array.GetLength(1); j += 2)
            array[i,j] = array[i,j] * array[i,j];
    }
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
Console.WriteLine();
Quadrant(myArray);
Show2dArray(myArray);
*/

// 3. Задайте двумерный массив. Найдите сумму элементов, находящихся 
// на главной диагонали (с индексами (0,0); (1;1) и т.д.
/*
int[,] CreateRandom2dArray()
{
    Console.Write("input a quantity of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("input a quantity of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("input a min possible value: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("input a max possible value: ");
    int max = Convert.ToInt32(Console.ReadLine());
        
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++) 
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(min, max + 1);
    
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        
        Console.WriteLine();
    }
}

int SumOfMain(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0) && i < array.GetLength(1); i++)
    {   
        sum = sum + array[i,i];

        // Для вывода решения (1 + 2 = 3)
        if (i == array.GetLength(0) - 1 || i == array.GetLength(1) - 1) 
            System.Console.Write($"{array[i,i]} = ");

        else System.Console.Write($"{array[i,i]} + ");
    }

    return sum;
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);

Console.WriteLine();

int sum = SumOfMain(myArray);
Console.WriteLine(sum);
*/

// 4. Взять двумерный массив и все строки отсортировать по убыванию.

int[,] CreateRandom2dArray()
{
    Console.Write("input a quantity of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("input a quantity of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("input a min possible value: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("input a max possible value: ");
    int max = Convert.ToInt32(Console.ReadLine());
        
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++) 
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(min, max + 1);
    
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        
        Console.WriteLine();
    }
}

void Sort(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++) 
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i,k] < array[i, k + 1])
                {
                    int temp = array[i,k];
                    array[i,k] = array[i,k + 1];
                    array[i,k + 1] = temp;
                }
            }
        }
    }
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);

Console.WriteLine();

Sort(myArray);
Show2dArray(myArray);

