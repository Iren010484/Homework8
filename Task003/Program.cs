/* Сформируйте массив из неповторяющихся двузначных чисел.
Напишите программу, которая будет построчно выводить массив,
добавляя индексы каждого элемента.*/

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

int[,] Composition (int[,] matr, int [,] matrtu)
{ int [,] compMatr = new int[matr.GetLength(0), matr.GetLength(1)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matrtu.GetLength(0); j++)
        {
            for (int k = 0; k < matr.GetLength(0); k++)
            {
                compMatr[i,j] += matr[i,k] * matrtu[k,j];
            }
        }
    }
    return compMatr;
}


int n = ReadInt("Введите размер матриц");
int[,] matrix = new int[n, n];
int[,] matrixtu = new int[n,n];
FillArray(matrix);
FillArray(matrixtu);
Console.WriteLine();
PrintArray(matrix,n,n);
Console.WriteLine();
PrintArray(matrixtu,n,n);
Console.WriteLine("Произведение матриц равно");
PrintArray(Composition(matrix,matrixtu),n,n);
