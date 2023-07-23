//Напишите программу, которая 
//заполнит спирально массив 4*4



void PrintArray(int[,] matr, int a, int b) 
{
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            if (matr[i,j] < 10)
            {
                Console.Write($"  0{matr[i, j]} ");
            }
                else Console.Write($"  {matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] arr, int n) 
{
    int k = 1;
    int startX = 0;
    int startY = 0;
    int endX = n-1;
    int endY = n-1;
    while (startX<=endX && startY<=endY)
    {
        for (int i = startY; i <= endY; i++)
        {
            arr[startX,i] = k++;
        }
        startX++;

        for (int i = startX; i <= endX; i++)
        {
            arr[i,endY] = k++;
        }
        endY--;

        for (int i = endY; i >= startY; i--)
        {
            arr[endX,i] = k++;
        }
        endX--;

        for (int i = endX; i >= startX; i--)
        {
            arr[i,startY] = k++;
        }
        startY++;
    }
}


int[,] matrix = new int[4, 4];

FillArray(matrix,4);
Console.WriteLine();
PrintArray(matrix,4,4);
