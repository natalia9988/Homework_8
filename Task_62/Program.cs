/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/

void get2DArray(int[,] array, int n)
{
    int i = 0, j = 0;
    int num = 1;
    for (int a = 0; a < n * n; a++)
    {
        int b = 0;
        do { array[i, j++] = num ++; } while (++b < n - 1);
        for (b = 0; b < n - 1; b++) array[i++, j] = num++;
        for (b = 0; b < n - 1; b++) array[i, j--] = num++;
        for (b = 0; b < n - 1; b++) array[i--, j] = num++;
        ++i; ++j;
        n = n < 2 ? 0 : n - 2;
    }
}



void print2DArray( int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write("0" + array[i, j]);
                Console.Write(" ");
            }
            else Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int size = 4;
int[,] arr = new int[size, size];
get2DArray(arr, size);
print2DArray(arr);