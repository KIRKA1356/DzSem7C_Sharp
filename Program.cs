/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

/*
Console.WriteLine("Введите значение строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение столбцов");                 //Задача 47
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение массива");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение массива");
int max = Convert.ToInt32(Console.ReadLine());

double[,] CreateRandom2dArray(int rows, int columns, int min, int max)
{
    Random rand = new Random();
    double[,] newArray = new double[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i, j] = Math.Round(rand.NextDouble() * (new Random().Next(min,max)), 1);
        }
    }
    return newArray;
}

void Show2dArray(double[,] array)
{
    Console.WriteLine("Задан массив: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[,] MyArray = CreateRandom2dArray(rows, columns, min, max);
Show2dArray(MyArray);
*/

/*
Console.WriteLine("Введите значение строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение столбцов");                     //Задача 50
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение массива");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение массива");
int max = Convert.ToInt32(Console.ReadLine());

int[,] CreateRandom2dArray(int rows, int columns, int min, int max)
{
    int[,] newArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i, j] = new Random().Next(min, max + 1);
        }
    }
    return newArray;
}

void Show2dArray(int[,] array)
{
    Console.WriteLine("Задан массив: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MyArray = CreateRandom2dArray(rows, columns, min, max);
Show2dArray(MyArray);

Console.WriteLine("Введите строку искомого элемента");
int rows2 = Convert.ToInt32(Console.ReadLine()) - 1;
Console.WriteLine("Введите столбец искомого элемента");
int columns2 = Convert.ToInt32(Console.ReadLine()) - 1;

int Poisk(int[,] array, int rows2, int columns2)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i == rows2)
        for (int j = 0; j < array.GetLength(1); j++)
        {
             if (j==columns2) return array[i,j];
        }
    }
    return -1;
}
if (Poisk(MyArray,rows2,columns2)== -1) Console.WriteLine("Искомый элемент с данными параметрами отсутствует");
else Console.WriteLine("Искомый элемент равен " + Poisk(MyArray,rows2,columns2));
*/

/*
Console.WriteLine("Введите значение строк");
int rows = Convert.ToInt32(Console.ReadLine());                     //Задача 52
Console.WriteLine("Введите значение столбцов");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение массива");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение массива");
int max = Convert.ToInt32(Console.ReadLine());

int[,] CreateRandom2dArray(int rows, int columns, int min, int max)
{
    int[,] newArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i, j] = new Random().Next(min, max + 1);
        }
    }
    return newArray;
}

void Show2dArray(int[,] array)
{
    Console.WriteLine("Задан массив: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MyArray = CreateRandom2dArray(rows, columns, min, max);
Show2dArray(MyArray);

void SrArefm(int[,] array, int rows)
{
    double sum = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum = array[j,i] + sum;
        }
        Console.WriteLine("Среднее арефмитическое " + i + " столбца равно " + Math.Round(sum/rows, 1));
        sum = 0;
    }
}

SrArefm(MyArray, rows);
*/