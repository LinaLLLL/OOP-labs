class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Выберите: \n 1)Ввод чисел в массив с помощью ДСЧ \n 2)Ввод чисел в массив вручную");
            int inputSelection = Convert.ToInt32(Console.ReadLine());
            if (inputSelection > 0 && inputSelection < 3)
            {
                Console.WriteLine("Введите количество строк в рваном массиве:");
                int linesInSteppedArray = Convert.ToInt32(Console.ReadLine());
                if (linesInSteppedArray > 0)
                {
                    int[][] arr3 = new int[linesInSteppedArray][];
                    if (inputSelection == 1)
                    {
                        CreateSteppedArray(linesInSteppedArray, arr3);
                    }
                    else if (inputSelection == 2)
                    {
                        CreateSteppedArrayManually(linesInSteppedArray, arr3);
                    }
                    ShowSteppedArray(arr3);
                    Console.WriteLine("Введите номер строки, после которой остальные строки удалятся:");
                    int lineNumber = Convert.ToInt32(Console.ReadLine());
                    if (lineNumber > 0)
                    {
                        int[][] res = DeleteLinesInSteppedArray(lineNumber, arr3);
                        if (res != null)
                        {
                            ShowSteppedArray(res);
                        }

                        else
                        {
                            Console.WriteLine("Строки с таким номером нет в массиве");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Введено неверное число");
                    }
                }
                else
                {
                    Console.WriteLine("Введено неправильное число");
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

        static int[][] CreateSteppedArray(int lines, int[][] arr) // создание рваного массива
        {
            Random rnd = new Random();

            for (int i = 0; i < lines; i++)
            {

                arr[i] = new int[rnd.Next(2, 6)];
            }
            for (int i = 0; i < lines; i++)
            {

                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = rnd.Next(1, 15);
                }
            }
            return arr;
        }

        static int[][] CreateSteppedArrayManually(int lines, int[][] arr) // создание рваного массива вручную
        {

            Console.WriteLine("Введите количество чисел в строке:");
            for (int i = 0; i < lines; i++)
            {
                arr[i] = new int[Convert.ToInt32(Console.ReadLine())];
            }
            Console.WriteLine("Введите числа массива:");
            for (int i = 0; i < lines; i++)
            {

                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            return arr;
        }
        static void ShowSteppedArray(int[][] arr) // вывод рваного массива
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static int[][] DeleteLinesInSteppedArray(int line, int[][] arr) // удаление строк в рваном массиве после заданной строки
        {
            if (line < arr.GetLength(0))
            {
                int[][] arr2 = new int[line][];
                for (int i = 0; i < line; i++)
                {
                    arr2[i] = new int[arr[i].Length];
                }
                for (int i = 0; i < line; i++)
                {
                    for (int j = 0; j < arr[i].Length; j++)
                    {
                        arr2[i][j] = arr[i][j];
                    }
                }
                return arr2;
            }
            else
            {
                return null;
            }
        }
    }
}