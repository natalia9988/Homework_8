/*Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

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
 void RowMinSumElements(int[,] array)
{
    int index = 0, minsum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        Console.WriteLine($"Сумма {i + 1} строки = {sum}");
        if (i == 0)
        {
            minsum = sum;
        }
        else if (sum < minsum)
        {
            minsum = sum;
            index = i;
        }
    }
    string line = string.Empty;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        line += array[index, j] + " ";
    }
    Console.WriteLine($"Строка с минимальной суммой элементов равна {index + 1}. ");
}

int [,] arr = get2DArray(3,5,0,10);
print2DArray(arr);
RowMinSumElements(arr);
