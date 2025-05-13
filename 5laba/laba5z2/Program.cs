class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Выберите: \n 1)Ввод чисел в массив с помощью ДСЧ \n 2)Ввод чисел в массив вручную");
            int inputSelection = Convert.ToInt32(Console.ReadLine());
            if (inputSelection >0 && inputSelection < 3)
            {
                Console.WriteLine("Введите количество столбцов в двумерном массиве:");
                int columns = Convert.ToInt32(Console.ReadLine());
                if (columns > 0)
                {
                    Console.WriteLine("Введите количество строк в двумерном массиве:");
                    int lines = Convert.ToInt32(Console.ReadLine());
                    if (lines > 0)
                    {
                        int[,] arr2 = new int[lines, columns];
                        if (inputSelection == 1)
                        {
                            CreateTwoDimensionalArray(columns, lines, arr2);
                        }
                        else if (inputSelection == 2)
                        {
                            CreateTwoDimensionalArrayManually(columns, lines, arr2);
                        }
                        Console.WriteLine("Выберите: \n 1)Добавление строки в массив с помощью ДСЧ \n 2)Добавление строки в массив вручную");
                        int inputSelection2 = Convert.ToInt32(Console.ReadLine());
                        if (inputSelection2 > 0 && inputSelection2 < 3)
                        {
                            if (inputSelection2 == 1)
                            {
                                ShowTwoDimensionalArray(arr2);
                                ShowTwoDimensionalArray(AddLinesInTwoDimensionaArray(columns, lines, arr2));
                            }
                            else if(inputSelection2 == 2) 
                            {
                                ShowTwoDimensionalArray(arr2);
                                ShowTwoDimensionalArray(AddLinesInTwoDimensionaArrayManually(columns, lines, arr2));
                            }
                        }
                        else
                        {
                            Console.WriteLine("Введено неправильное число");
                        }
                        
                    }
                    else
                    {
                        Console.WriteLine("Введено отрицательное число или 0, массив не создан");
                    }
                }
                else
                {
                    Console.WriteLine("Введено отрицательное число или 0, массив не создан");
                }
            }
            else
            {
                Console.WriteLine("Введено неправильное число");
            }
        }
        
        catch (FormatException)
        {
            Console.WriteLine("Вы ввели буквы, будьте впредь аккуратны");

        }
        static int[,] CreateTwoDimensionalArray(int columns, int lines, int[,] arr) // создание двумерного массива
        {

            Random rnd = new Random();
            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    arr[i, j] = rnd.Next(0, 21);
                }
            }
            return arr;
        }
        static int[,] CreateTwoDimensionalArrayManually(int columns, int lines, int[,] arr) // создание двумерного массива вручную
        {
            Console.WriteLine("Введите числа массива:");
            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            return arr;
        }


        static void ShowTwoDimensionalArray(int[,] arr) // вывод двумерного массива
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static int[,] AddLinesInTwoDimensionaArray(int columns, int lines, int[,] arr) // добавление строки в начало матрицы
        {
            Random rnd = new Random();
            int[,] arr2 = new int[lines + 1, columns];
            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    arr2[i, j] = rnd.Next(0, 21);
                }
            }
            for (int i = 1; i <= lines; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    arr2[i, j] = arr[i - 1, j];
                }
            }
            return arr2;
        }

        static int[,] AddLinesInTwoDimensionaArrayManually(int columns, int lines, int[,] arr) // добавление строки в начало матрицы вручную
        {
            int[,] arr2 = new int[lines + 1, columns];
            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.WriteLine("Введите число");
                    arr2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 1; i <= lines; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    arr2[i, j] = arr[i - 1, j];
                }
            }
            return arr2;
        }
    }
}