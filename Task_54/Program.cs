/*Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/



int [,] get2DArray (int colLength, int rowLength, int start, int end)
{
    int [,]array = new int [colLength,rowLength];
    for (int i = 0; i < colLength; i++)
    {
        for (int j = 0; j < rowLength; j++)
        {
            array[i,j] = new Random().Next(start, end+1) ;
        }
    }
    return array;

}

void PrintInColor(string data)
{
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.Write(data);
    Console.ResetColor();
}

void print2DArray( int [,] array)
{
    Console.Write(" \t");
    for (int j =0; j < array.GetLength(1); j++)
    {
        PrintInColor( j+ "\t");
    }
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
       PrintInColor(i +"\t");
       for (int j =0; j < array.GetLength(1); j++)
       {
        Console.Write(array[i,j]+ "\t");
       }
       Console.WriteLine();
    }
}

void GenerateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int a = 0; a < array.GetLength(1) - 1; a++)
            {
                if (array[i, a] < array[i, a + 1])
                {
                    int temp = array[i, a + 1];
                    array[i, a + 1] = array[i, a];
                    array[i, a] = temp;
                }
            }
        }
    }
}
int [,] arr = get2DArray(3,5,0,10);
Console.WriteLine("Исходный массив");
print2DArray(arr);

Console.WriteLine("---------------------------");

GenerateArray(arr);
Console.WriteLine("Упорядоченный массив");
print2DArray(arr);
