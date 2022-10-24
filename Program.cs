/*
// Кол-во строк 
int rows = 10;
// Кол-во столбцов
int columns = 5;

int [,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

int [,] GetArray (int m, int n, int minValue, int maxValue){
    int [,] result = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i,j] = i + j;
        }
    }
    return result;
}

void PrintArray(int [,] array){
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}*/

// Дан двумерный массив. 
// Найти: среднее арифметическое элементов, расположенных в четырех углах



//Задача 49: Задайте двумерный массив. 
//Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.


/*
// Кол-во строк 
int rows = 3;
// Кол-во столбцов
int columns = 4;

int [,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

Console.WriteLine();
PrintArray(Change (array));

int [,] GetArray (int m, int n, int minValue, int maxValue){
    int [,] result = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(minValue, maxValue +1);
        }
    }
    return result;
}

void PrintArray(int [,] array){
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}


int[,] Change(int [,] array){
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(i%2==0 && j%2==0){
            array[i,j] = array[i,j] * array[i,j];
        }
        }
    }
    return array;
}
*/



// Задача 51: Задайте двумерный массив. 
//Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.


/*
// Кол-во строк 
int rows = 4;
// Кол-во столбцов
int columns = 4;

int [,] array = GetArray(rows, columns, 0, 9);
PrintArray(array);


int [,] GetArray (int m, int n, int minValue, int maxValue){
    int [,] result = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(minValue, maxValue +1);
        }
    }
    return result;
}

void PrintArray(int [,] array){
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

int SUM(int [,] array){
    int result = array[0,0] + array[1,1] + array[2,2] + array[3,3];
    return result;
}
Console.WriteLine ($"Сумма элементов, находящихся на главной диагонали = {SUM (array)}");
*/


// HOME WORK

/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.

0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

/*
Console.WriteLine("введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());
double[,] numbers = new double[rows, columns];
GetArray(numbers);
PrintArray(numbers);


void GetArray (double[,] array){
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = Convert.ToDouble(new Random().Next(-10, 10));
        }
    }
}

void PrintArray(double[,] array){
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}
*/

/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

i = 4, j = 2 -> такого числа в массиве нет
i = 1, j = 2 -> 2
*/

/*
int rows = 4;
int columns = 4;

int [,] array = GetArray(rows, columns, 0, 9);
PrintArray(array);


int [,] GetArray (int m, int n, int minValue, int maxValue){
    int [,] result = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(minValue, maxValue +1);
        }
    }
    return result;
}

void PrintArray(int [,] array){
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите индекс строки элемента: ");
int i = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите индекс столбца элемента: ");
int j = Convert.ToInt32 (Console.ReadLine());

int m = rows;
int n = columns;
if (i > m && j > n){
    Console.WriteLine("такого числа нет в массиве");
}
else{
    object result = array.GetValue(i,j);
    Console.WriteLine(result);
}
*/

/*
Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

/*
int rows = 4;
int columns = 4;

int [,] array = GetArray(rows, columns, 0, 9);
PrintArray(array);


int [,] GetArray (int m, int n, int minValue, int maxValue){
    int [,] result = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(minValue, maxValue +1);
        }
    }
    return result;
}

void PrintArray(int [,] array){
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

int SUM1(int [,] array){
    int result = (array[0,0] + array[1,0] + array[2,0] + array[3,0]) / 4;
    return result;
}
Console.WriteLine ($"Среднее арифметическое столбца 1 = {SUM1 (array)}");

int SUM2(int [,] array){
    int result = (array[0,1] + array[1,1] + array[2,1] + array[3,1]) / 4;
    return result;
}
Console.WriteLine ($"Среднее арифметическое столбца 2 = {SUM2 (array)}");

int SUM3(int [,] array){
    int result = (array[0,2] + array[1,2] + array[2,2] + array[3,2]) / 4;
    return result;
}
Console.WriteLine ($"Среднее арифметическое столбца 3 = {SUM3 (array)}");

int SUM4(int [,] array){
    int result = (array[0,3] + array[1,3] + array[2,3] + array[3,3]) / 4;
    return result;
}
Console.WriteLine ($"Среднее арифметическое столбца 4 = {SUM4 (array)}");
*/