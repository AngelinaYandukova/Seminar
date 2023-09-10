// Задайте двумерный массив. Напишите программу, которая поменяет 
// местами любые две строки массива.

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

void ChangeRows(int[,] array, int r1, int r2)
{
    // Проверка:
    // Строки должны существовать
    // Не менять одну строку с самой собой (3 с 3)
    if (r1 >= 0 && r1 < array.GetLength(0) &&
        r2 >= 0 && r2 < array.GetLength(0) &&
        r1 != r2)
        {
            for(int j = 0; j < array.GetLength(1); j++)
            {
                int temp = array[r1, j];
                array[r1, j] = array[r2, j];
                array[r2, j] = temp;
            }
        }
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);

Console.WriteLine("Input a number of the first row to change: ");
int row1 = Convert.ToInt32(Console.ReadLine()) - 1;
Console.WriteLine("Input a number of the second row to change: ");
int row2 = Convert.ToInt32(Console.ReadLine()) - 1;

ChangeRows(myArray, row1, row2);
Show2dArray(myArray);
*/

// Задайте двумерный массив. Напишите программу, которая заменяет 
// строки на столбцы.

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

int[,] ChangeRowsToColumns(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = i + 1; j < array.GetLength(1); j++)
        {
            int temp = array[i, j];
            array[i, j] = array[j, i];
            array[j, i] = temp;
        }
    return array;
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
Console.WriteLine();
int[,] reverseArray = ChangeRowsToColumns(myArray);
Show2dArray(reverseArray);
*/

// Из двумерного массива целых чисел удалить строку и столбец, 
// на пересечении которых расположен наименьший элемент.

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
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
}

int[,] DeleteRowAndColumnWithMinValue(int[,] array)
{
    int minI = 0;
    int minJ = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < array[minI, minJ])
            {
                minI = i;
                minJ = j;
            }
        }
    }
    int[,] result = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];

    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            if (i < minI && j < minJ) result[i, j] = array[i, j];
            if (i < minI && j >= minJ) result[i, j] = array[i, j + 1];
            if (i >= minI && j < minJ) result[i, j] = array[i + 1, j];
            if (i >= minI && j >= minJ) result[i, j] = array[i + 1, j + 1];
        }
    }
    return result;
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
Console.WriteLine();
int[,] newArray = DeleteRowAndColumnWithMinValue(myArray);
Show2dArray(newArray);