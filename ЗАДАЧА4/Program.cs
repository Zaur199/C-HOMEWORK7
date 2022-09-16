//Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника
Console.Write("Введите количество строк : ");
int n = int.Parse(Console.ReadLine());
// Для решения задачи используем ступенчатый массив
int[][] PascalTriangle = new int[n][];
PascalTriangle[0] = new int[] { 1 };  // первая строка
 
for (int i = 1; i < PascalTriangle.Length; i++)
{
    PascalTriangle[i] = new int[i + 1];  
    for (int j = 0; j <= i; j++)
    {
        if (j == 0 || j == i)
            PascalTriangle[i][j] = 1;
        else
            {
                PascalTriangle[i][j] = PascalTriangle[i - 1][j - 1] + PascalTriangle[i - 1][j];
            }
    }
}
 
for (int i = 0; i < PascalTriangle.Length; i++)
{
    for (int j = 0; j < PascalTriangle[i].Length; j++)
        {
            Console.Write(PascalTriangle[i][j]);
        }
        Console.WriteLine();
} 
 
Console.WriteLine();
        
         
                
        