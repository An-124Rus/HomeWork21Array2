internal class Program
{
    private static void Main(string[] args)
    {
        int minValue = 11;
        int maxValue = 50;
        int maxNumber = 0;

        Random random = new Random();

        Console.Write("Введите количество строк: ");
        int rowNumber = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите длину строки: ");
        int rowLenth = Convert.ToInt32(Console.ReadLine());

        int[,] array = new int[rowNumber, rowLenth];

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = random.Next(minValue, maxValue);
                Console.Write($"\b{array[i, j]}  ");
            }

            Console.WriteLine();
        }

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (maxNumber < array[i, j])
                    maxNumber = array[i, j];
            }    
        }

        Console.WriteLine($"\nМаксимальное значение в матрице - {maxNumber}.\n");

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (maxNumber == array[i, j])
                    array[i, j] = 0;

                Console.Write($"\b{array[i, j]}  ");
            }

            Console.WriteLine();
        }
    }
}