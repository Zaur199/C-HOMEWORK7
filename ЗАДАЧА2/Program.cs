// В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.
void FillArray(int[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,9);
        }
    }

}

void PrintArray(int[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i,j]}");
        }
        Console.WriteLine();
    }
}   

int[,] matr = new int[4, 4];
FillArray(matr);
PrintArray(matr);

int x = 0;
int y = 0;
int min = matr[0, 0];

for(int i = 0; i < matr.GetLength(0); i++)
{
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            if(matr[i, j] < min)
            {
                x = i;
                y = j;
            }
        }
    }
}
Console.WriteLine();

Console.WriteLine("Новая преобразованная матрица");
for(int i = 0; i < matr.GetLength(0); i++)
{
    for(int j = 0; j < matr.GetLength(1); j++)
    {
        if((i == x) || (j == y)) 
            {
                continue; // matr[i, j] = matr[matr.GetLength(0) - 1, matr.GetLength(1) - 1 ]
            }
        else
            Console.Write(matr[i, j] + " ");
        
    }
    Console.WriteLine();
}
