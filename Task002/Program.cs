/* Задайте прямоугольный двумерный массив.
Напишите программу, которая будет находить строку
с наименьшей суммой элементов*/

int ReadInt(string message)
{
    System.Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine()); 
    return number;
}

void PrintArray(int[,] matr, int a, int b) 
{
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            Console.Write($"  {matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr) 
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(0,100);//[1; 10)
        }
    }  
}

int MinSum (int[,] matr)
{
    int index = 0;
    int s = 0;
        for (int k = 0; k < matr.GetLength(1); k++)
        {
            s = s + matr [0,k];  
        }
    for (int i = 1; i < matr.GetLength(0); i++)
    {
        int summa = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            summa = summa + matr[i,j];   
        }
        if (summa < s) 
            {
            index = i;
            s = summa;
            }
    }
return index+1;
}


int n = ReadInt("Введите количество строк массива");
int m = ReadInt("Введите количество столбцов массива");
int[,] matrix = new int[n, m];

FillArray(matrix);
Console.WriteLine();
PrintArray(matrix,n,m);
int index = MinSum(matrix);
Console.WriteLine($"Строка {index} имеет наименьшую сумму элементов");

