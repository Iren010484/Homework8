/* Сформируйте трехмерный массив из неповторяющихся двузначных чисел.
Напишите программу, которая будет построчно выводить массив,
добавляя индексы каждого элемента.*/

int ReadInt(string message)
{
    System.Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine()); 
    return number;
}

void PrintArray(int[, ,] matr, int a) 
{
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < a; j++)
        {
            for (int k = 0; k < a; k++)
           { Console.Write($"  {matr[i, j,k]}({i},{j},{k}) ");}
        Console.WriteLine();
        }
    }
}

void FillArray(int[,,] matr) 
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {   for (int k = 0; k < matr.GetLength(2); k++)
            {
                matr[i,j,k] = new Random().Next(10,100);//[1; 10)
            }
        }
    }  
}




int n = ReadInt("Введите размер массива");

int[,,] matrix = new int[n,n,n];

FillArray(matrix);
Console.WriteLine();
PrintArray(matrix,n);
