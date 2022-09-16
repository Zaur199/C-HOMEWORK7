// Найти произведение двух матриц
void FillArray(int[,] matr1, int[,] matr2)
{
    for(int i = 0; i < matr1.GetLength(0); i++)
    {
        for(int j = 0; j < matr1.GetLength(1); j++)
        {
            matr1[i,j] = new Random().Next(1,9);
        }
    }

    for(int i = 0; i < matr2.GetLength(0); i++)
    {
        for(int j = 0; j < matr2.GetLength(1); j++)
        {
            matr2[i,j] = new Random().Next(1,8);
        }

    }
}
 
void PrintArray(int[,] matr1, int[,] matr2)
{
    for(int i = 0; i < matr1.GetLength(0); i++)
    {
        for(int j = 0; j < matr1.GetLength(1); j++)
        {
            Console.Write($"{matr1[i,j]}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();

    for(int i = 0; i < matr2.GetLength(0); i++)
    {
        for(int j = 0; j < matr2.GetLength(1); j++)
        {
            Console.Write($"{matr2[i,j]}");
        }
        Console.WriteLine();
        
    }
}

void Multiplication(int[,] matr1, int[,] matr2, int[,] result)
{
    for(int i = 0; i < matr1.GetLength(0); i++)
    {
        for(int j = 0; j < matr1.GetLength(1); j++)
        {
            result[i, j] = matr1[i, j] * matr2[i, j];
        }
    }
}

void PrintMultiMatrix(int[,] result)
{
    for(int i = 0; i < result.GetLength(0); i++)
    {
        for(int j = 0; j < result.GetLength(1); j++)
        {
            Console.Write($"{result[i, j]}");
        }
        Console.WriteLine();
    }
}

int[,] matr1 = new int[3, 3];
int[,] matr2 = new int[3, 3];
int[,] result = new int[3, 3];
FillArray(matr1, matr2);
PrintArray(matr1, matr2);
Console.WriteLine();
Multiplication(matr1, matr2, result);
PrintMultiMatrix(result);
