// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.");
int rows = SetNumber("Rows");
int columns = SetNumber("Columns");
double maxValue = SetNumber("MaxValue");
double minValue = SetNumber("MinValue");

var matrix= GetMatrix(rows,columns,maxValue,minValue);
PrintDoubleMatrix(matrix);

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

void PrintDoubleMatrix(double[,] matrix)
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

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

Console.WriteLine("Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.");
int numbersRows = SetNumber("Rows");
int numbersColumns = SetNumber("Columns");
int numbersMaxValue = SetNumber("MaxValue");
int numbersMinValue = SetNumber("MinValue");

var matr= GetMasiv(numbersRows,numbersColumns,numbersMaxValue,numbersMinValue);
Print(matr);



int[,] GetMasiv (int rows, int columns, int max, int min)
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


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.");
int numRows = SetNumber("Rows");
int numColumns = SetNumber("Columns");
int numMaxValue = SetNumber("MaxValue");
int numMinValue = SetNumber("MinValue");

var matrix2= GetMasiv(numRows,numColumns,numMaxValue,numMinValue);
Print(matrix2);
Mean(matrix2);


void Mean(int [,] matrix)
    {
        
        for (int l = 0; l < matrix.GetLength(1); l++)
        {
            double mean=0;
            double sum=0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sum = sum + matrix[i,l];
            }
            mean = sum/(matrix.GetLength(0));
            Console.WriteLine($"{Math.Round(mean, 2)}");
            
        }
    }


// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


Console.WriteLine("Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. Например, на выходе получается вот такой массив:");
int row = SetNumber("Rows");
int col = SetNumber("Columns");

Print(GetYlitka(row,col));



 int[,] GetYlitka (int rows, int columns)
{
    int[,] ylitka = new int[row,col];
    
    int count = 1;
    int startCol = 0;
    int endCol = col-1;
    int startRow = 0;
    int endRow = row-1;
    
    while (startCol <= endCol && startRow <= endRow)
    {
        for (int i = startCol; i <= endCol; i++)
        {
            ylitka [startRow,i]=count;
            count++;
        }
        startRow++;

        for (int l = startRow; l <= endRow; l++)
        {
            ylitka [l,endCol]=count;
            count++;
        }
        endCol--;

        for (int i = endCol; i >= startCol; i--)
        {
            ylitka [endRow,i]=count;
            count++;
        }
        endRow--;

        for (int l = endRow; l >= startRow; l--)
        {
            ylitka [l,startCol]=count;
            count++;
        }
        startCol++;


    }
    return ylitka;
}



