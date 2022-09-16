// Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы соответствующего элемента
void PrintArray(int[, ,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        Console.WriteLine("Side №" + (i + 1));
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            for(int k = 0; k < matr.GetLength(2); k++)
            {
                Console.Write($"{matr[i, j, k]}{{{i},{j},{k}}} ");// В консоли к номеру элемента будет выводиться соответствующий ему индекс
        
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

void FillArray(int[, ,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            for(int k = 0; k < matr.GetLength(2); k++)
            {
                 matr[i,j,k] = new Random().Next(10,99);
            }
            
        }
        
    }
}

int[, ,] matr = new int[4,4,4];
PrintArray(matr);
FillArray(matr);
Console.WriteLine();
PrintArray(matr);
