// 1. Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, 
// а первый - на последнем и т.д.)
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size]; 
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1); 

    return array;
}

void WriteArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

void ReverseArray(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
}

void ReverseArray(int[] array)
{
    for (int i = 0; j = array.Length - 1 - i; i < j; i++; j--)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}

Console.Write("Input a length of an array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length, min, max);
WriteArray(myArray);
ReverseArray(myArray);
WriteArray(myArray);
*/

// 2. Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
/*
bool Proverka(int a, int b, int c)
{
    if(a < b + c && b < a + c && c < a + b) return true;
    else return false;
}

Console.Write("Input a: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input b: ");
int numB = Convert.ToInt32(Console.ReadLine());
Console.Write("Input c: ");
int numC = Convert.ToInt32(Console.ReadLine());

if (Proverka(numA, numB, numC)) Console.WriteLine("Треугольник существует");
else Console.WriteLine("Треугольник не существует");
*/

// 3. Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.
/*
int[] Fibonachi(int length)
{
    int[] array = new int[length];
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < length; i++)
    {
        array[i] = array[i - 2] + array[i - 1];
    }
    return array;
}

void WriteArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

Console.Write("Input length: ");
int len = Convert.ToInt32(Console.ReadLine());

int[] myArray = Fibonachi(len);
WriteArray(myArray);
*/

// 4. Напишите программу, которая будет создавать копию заданного 
// массива с помощью поэлементного копирования.

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] firstArray = new int[size]; 
    for(int i = 0; i < size; i++)
        firstArray[i] = new Random().Next(minValue, maxValue + 1); 

    return firstArray;
}

void WriteArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int[] Copy(int[] firstArray)
{
    int[] secondArray = new int[firstArray.Length];

    for (int i = 0; i < secondArray.Length; i++)
    {
        secondArray[i] = firstArray[i];
    }
    return secondArray;
}

Console.Write("Input a length of an array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length, min, max);
WriteArray(myArray);
int[] copiedArray = Copy(myArray);
WriteArray(copiedArray);


// Написать программу, преобразующую число из десятеричной системы 
// счисления в двоичную.