// Методы
// Найти максимальное из 9 чисел.
/*
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

int a1 = 43;
int b1 = 62;
int c1 = 84;
int a2 = 562;
int b2 = 542643;
int c2 = 854;
int a3 = 2;
int b3 = 652;
int c3 = 8436;

// int max1 = Max(a1, b1, c1);
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);
// int max = Max(max1, max2, max3);
int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));

Console.WriteLine(max);
*/

// Массивы
// Найти максимальное из 9 чисел.
/*
//             0   1   2   3   4   5    6   7   8
int[] array = {11, 21, 31, 41, 15, 156, 85, 73, 683};
//Обращемся к элементу массива:
// array[0] = 12;
// Console.WriteLine(array[0]);

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}
int max = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
);
Console.WriteLine(max);
*/

// Имеется одномерный массив array из n элементов. найти элемент массива, равный find.

int[] array = {1, 4, 35, 732, 74, 6, 93};

int n = array.Length;
int find = 4;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        index++;
    }
}