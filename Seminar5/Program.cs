// 1. Задайте массив из m элементов, заполненный случайными числами 
// из промежутка [a, b]. Найдите сумму отрицательных элементов массива.
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

int SumOfNegatives(int[] array)
{
    int sum = 0;
    
    for (int i = 0; i < array.Length;)
        if(array[i] < 0)
            sum += array[i];
    return sum;        
}

Console.Write("Input a length of an array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length, min, max);
WriteArray(myArray);
Console.WriteLine(SumOfNegatives(myArray));
*/

// 2. Напишите программу замена элементов массива: положительные элементы 
// замените на соответствующие отрицательные, и наоборот.
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

int[] ChangeArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        array[i] = array[i] * -1;
    return array;
}
Console.Write("Input a length of an array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length, min, max);
WriteArray(myArray);
WriteArray(ChangeArray(myArray));
*/

// 3. Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве.
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

bool Number(int[] array, int num)
{
    for(int i = 0; i < array.Length; i++)
        if (array[i] == num)
            return true;
    return false;

}
Console.Write("Input a length of an array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length, min, max);
WriteArray(myArray);
Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (Number(myArray, number)) Console.WriteLine($"Число {number} есть в массиве.");
else Console.WriteLine($"Число {number} в массиве отсутствует.");
*/

// 4. Задайте одномерный массив из m случайных чисел. Найдите 
// количество элементов массива, значения которых лежат в отрезке [a,b].
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

int Count(int[] array, int minSegment, int maxSegment)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] <= maxSegment & array[i] >= minSegment)
            count++;
    }
    return count;
}

Console.Write("Input a length of an array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length, min, max);
WriteArray(myArray);

Console.Write("Input a min value of segment: ");
int minSeg = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max value of segment: ");
int maxSeg = Convert.ToInt32(Console.ReadLine());

int result = Count(myArray, minSeg, maxSeg);
Console.WriteLine($"{result}");
// Console.WriteLine(Count(myArray, minSeg, maxSeg));
*/
