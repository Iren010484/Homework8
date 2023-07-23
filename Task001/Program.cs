/* Задайте двумерный массив размером m×n, 
Напишите программу,которая упорядочит по убыванию элементы
каждой строки двумерного массива*/

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
            matr[i,j] = new Random().Next(1,10);//[1; 10)
        }
    }  
}

void ArrangeArray (int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            int maxelem = matr[i,j];
            for (int k = j+1; k < matr.GetLength(1); k++)
            {
                if (maxelem < matr[i,k])  
                { 
                    maxelem = matr[i,k];
                    matr [i,k] = matr [i,j];
                    matr[i,j] = maxelem;
                } 
            }
        }
    }
}


int n = ReadInt("Введите количество строк массива");
int m = ReadInt("Введите количество столбцов массива");
int[,] matrix = new int[n, m];

FillArray(matrix);
Console.WriteLine();
PrintArray(matrix,n,m);
Console.WriteLine("Отсортированный массив");
ArrangeArray(matrix);
PrintArray(matrix,n,m);