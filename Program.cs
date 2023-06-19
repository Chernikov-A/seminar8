/* Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */
/*
Console.WriteLine("Введите кол.строк ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол.колонок ");
int colums = Convert.ToInt32(Console.ReadLine());

int[,] array = new int [rows,colums];

void GetArray(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(0,10);
        }
    }
}

void PrintArray(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

void Sorting (int[,] array) {
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i,k] < array[i, k+1])
                {
                    int temp = array[i, k+1 ];
                    array[i, k+1] = array[i,k];
                    array[i,k] = temp;
                }
            }
        }
    }
}

GetArray(array);
PrintArray(array);
Console.WriteLine("Сортировка по убиванию");
Sorting(array);
PrintArray(array); */

/*: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */
/*    Пытался сделать, но чет не получилось....
Console.WriteLine("Введите кол.строк ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол.колонок ");
int colums = Convert.ToInt32(Console.ReadLine());

int[,] array = new int [rows,colums];

void GetArray(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(0,10);
        }
    }
}

void PrintArray(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

int SumElements(int[,] array, int i){
    int sum = array[i,0];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum += array[i,j];
    }
    return sum;
}

void Sort(int[,] array){
    int minSum = 0;
    int sumLine = SumElements(array,0);

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int temp = SumElements(array,i);
        if (sumLine > temp)
        {
            sumLine = temp;
            minSum = 1;
        }
    }
    Console.WriteLine($"\n {minSum+1} - Строка с наименьшей суммой ({sumLine}) элементов ");
}
GetArray(array);
PrintArray(array);
Console.WriteLine();
Sort(array);
PrintArray(array);
*/

/* Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */
/*
Console.WriteLine("Введите кол.строк ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол.колонок ");
int colums = Convert.ToInt32(Console.ReadLine());

int[,] array = new int [rows,colums];
int[,] resultArray = new int[rows,colums];
int[,] array2 = new int[rows,colums];

void GetArray(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(0,10);
        }
    }
}

void PrintArray(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

void SumMatrix(int[,] array, int[,] array2, int[,] resultArray){
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < array.GetLength(1); k++)
            {
                sum += array[i,k] * array2[k,j]; 
            }
            resultArray[i,j] = sum;
        }
    }
}

GetArray(array);
PrintArray(array);

Console.WriteLine();

GetArray(array2);
PrintArray(array2);

Console.WriteLine();

SumMatrix(array,array2,resultArray);
PrintArray(resultArray);
 */

 /*Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) 
*/

/*
int[,,] array = new int [2,2,2];

void PrintArray(int[,,] arr)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
        }
    }
}

void GetArray(int[,,] arr)
{
    int count = 10;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[k, i, j] += count;
                count += 3;
            }
        }
    }
}

GetArray(array);
PrintArray(array); */

/*Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */
/*
Console.WriteLine("Введите кол.строк ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол.колонок ");
int colums = Convert.ToInt32(Console.ReadLine());

int[,] array = new int [rows,colums];


void GetArray(int[,] array){
    int num = 1;
    int i = 0;
    int j = 0;

    while (num <= array.GetLength(0) * array.GetLength(1))
    {
        array[i,j] = num;
        num++;
        if (i <= j+1 && i + j < array.GetLength(1) - 1)
        j++;
        else if(i < j && i + j >= array.GetLength(0) - 1)
        i++;
        else if(i >= j && i + j > array.GetLength(1) -1)
        j--;
        else
        i--;
    }
}

void PrintArray(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < array.GetLength(1); j++)
        {
           Console.Write($"{array[i,j]}"+" ");
        }
        Console.Write("]");
        Console.WriteLine();
    }
}

GetArray(array);
PrintArray(array); */