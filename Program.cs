// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
/*
int numRows = SetNumber("Rows");
int numColumns = SetNumber("Columns");
double numMaxValue = SetNumber("MaxValue");
double numMinValue = SetNumber("MinValue");

var matrix= GetMatrix(numRows,numColumns,numMinValue,numMaxValue);
Print(matrix);

int SetNumber(string numberName)
{
    Console.Write($"Enter number {numberName}: ");
    var num = Convert.ToInt32(Console.ReadLine());
    return num;
}

double[,] GetMatrix (int rows, int columns, double min, double max)
{
    
    
    double[,] matrix = new double [rows,columns];
    var rand = new Random();
    for (int i = 0; i < rows; i++)
    {
       for (int l = 0; l <  columns; l++)
       {
            matrix[i,l] = Convert.ToDouble(rand.Next(-100, 100)/10.0);
       }   
    }
    return matrix;
}

void Print(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++)
        {
            System.Console.Write(matrix[i, l] + " ");
        }
        System.Console.WriteLine();
    }
}
*/
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

/*
int numbersRows = SetNumber("Rows");
int numbersColumns = SetNumber("Columns");
int numbersMaxValue = SetNumber("MaxValue");
int numbersMinValue = SetNumber("MinValue");

var matr= GetMatrix(numbersRows,numbersColumns,numbersMaxValue,numbersMinValue);
Print(matr);

int SetNumber(string numberName)
{
    Console.Write($"Enter number {numberName}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int[,] GetMatrix (int rows, int columns, int max, int min)
{
    int[,] matrix = new int[rows,columns];
    for (int i = 0; i < rows; i++)
    {
       for (int l = 0; l <  columns; l++)
       {
            matrix[i,l] = new Random().Next(min, max +1);
       }   
    }
    return matrix;
}

void Print(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int l = 0; l < matr.GetLength(1); l++)
        {
            System.Console.Write(matr[i, l] + " ");
        }
        System.Console.WriteLine();
    }
}

int rowsPosition = SetNumber("position rows");
int columnsPosition = SetNumber("position columns");

int GetElements(int[,] array, int rows, int  columns)
{
    int resultElements = 0;
    if(rows<array.GetLength(0))
    {
        resultElements= array[rows-1,columns-1];
        return resultElements;
    }
    else
    {
        System.Console.WriteLine("такого числа в массиве нет");
    }
    return resultElements;
}
System.Console.WriteLine(GetElements(matr,rowsPosition,columnsPosition));
*/

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int numbersRows = SetNumber("Rows");
int numbersColumns = SetNumber("Columns");
int numbersMaxValue = SetNumber("MaxValue");
int numbersMinValue = SetNumber("MinValue");

var matr= GetMatrix(numbersRows,numbersColumns,numbersMaxValue,numbersMinValue);
Print(matr);

int SetNumber(string numberName)
{
    Console.Write($"Enter number {numberName}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int[,] GetMatrix (int rows, int columns, int max, int min)
{
    int[,] matrix = new int[rows,columns];
    for (int i = 0; i < rows; i++)
    {
       for (int l = 0; l <  columns; l++)
       {
            matrix[i,l] = new Random().Next(min, max +1);
       }   
    }
    return matrix;
}

void Print(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int l = 0; l < matr.GetLength(1); l++)
        {
            System.Console.Write(matr[i, l] + " ");
        }
        System.Console.WriteLine();
    }
}



void GetArithmeticalMean(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int l = 0; l < array.GetLength(1); l++)
        {
            int sum=0;
            sum=array[i,l]+sum;
            double result=sum/array.GetLength(1)+1;
            System.Console.Write(result +" ");
        }
       
        
    }
}

System.Console.WriteLine(GetArithmeticalMean);
   

