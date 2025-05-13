class Programm
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Выберите: \n 1)Ввод чисел в массив с помощью ДСЧ \n 2)Ввод чисел в массив вручную");
            int inputSelection = Convert.ToInt32(Console.ReadLine());
            if (inputSelection >0 && inputSelection <3)
            {
                Console.WriteLine("Введите количество столбцов в двумерном массиве:");
                int columns = Convert.ToInt32(Console.ReadLine());
                if (columns > 0)
                {
                    Console.WriteLine("Введите количество строк в двумерном массиве:");
                    int lines = Convert.ToInt32(Console.ReadLine());
                    if (lines > 0)
                    {
                        int[,] arr = new int[lines, columns];
                        if (inputSelection == 1)
                        {
                            CreateTwoDimensionalArray(columns, lines, arr);
                        }
                        else if (inputSelection == 2)
                        {
                            CreateTwoDimensionalArrayManually(columns, lines, arr);
                        }

                        ShowTwoDimensionalArray(arr);

                        int minValueInArray = FindMinimumValue(arr);
                        Console.WriteLine($"Минимальный элемент массива: {minValueInArray}");
                        int columnWhereMinValue = FindCollumnsWhereMinValue(arr, minValueInArray);
                        Console.WriteLine($"столбик: {columnWhereMinValue}");
                        int[,] result = new int[arr.GetLength(0), arr.GetLength(1) - 1];
                        result = DeleteColumnsWhereMinValue(arr, minValueInArray, columnWhereMinValue, result);
                        ShowTwoDimensionalArray(result);
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
                Console.WriteLine("Введено неверное число");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Вы ввели буквы, будьте впредь аккуратны");

        }
    }
    static int[,] CreateTwoDimensionalArray(int columns, int lines, int[,] arr) // создание двумерного массива с помощью ДСЧ
    {

        Random rnd = new Random();
        for (int i = 0; i < lines; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                arr[i, j] = rnd.Next(1, 6);
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
        Console.WriteLine("Массив:");
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

    static int FindMinimumValue(int[,] arr) //нахождение минимального занчения в массиве
    {
        int one = arr[0,0];
        
        for (int i = 0; i < arr.GetLength(1); i++)
        {
            for (int j = 0; j < arr.GetLength(0); j++)
            {
                if (one >= arr[j, i])
                {
                    one = arr[j, i];
                }
            }
        }
        return one;
    }

    static int FindCollumnsWhereMinValue(int[,] arr, int min) //нахождение столбца в котором первый раз встречается минимальный элемент
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (min == arr[j, i])
                {
                    return i;
                } 
            }            
        }
        return 0;       
    }

    static int[,] DeleteColumnsWhereMinValue(int[,] arr, int min, int column, int[,] result) // удаление столбца с минимальным элементом
    {
        if (column == 0)
        {
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    result[i, j] = arr[i, j + 1];
                }
            }
        }
        else
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < column; j++)
                {
                    result[i, j] = arr[i, j];
                }
            }
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = column ; j < result.GetLength(1); j++)
                {
                    result[i, j] = arr[i, j];
                }
            }
        }
        return result;
    }
}