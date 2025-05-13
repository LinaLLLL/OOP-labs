using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    static void Main(string[] args)
    {


        try
        {
            //1 задание

            Console.WriteLine("Выберите: \n 1)Ввод чисел в массив с помощью ДСЧ \n 2)Ввод чисел в массив вручную");
            int inputSelection = Convert.ToInt32(Console.ReadLine());
            if (inputSelection < 0 || inputSelection > 2)
            {
                Console.WriteLine("Введено неправильное число");
            }
            else
            {
                Console.WriteLine("Введите количество чисел в одномерном массиве:");
                int n = Convert.ToInt32(Console.ReadLine());
                if (n > 0)
                {
                    int[] arr = new int[n];
                    if (inputSelection == 1)
                    {
                        CreateOneDimensionalArray(n, arr);
                    }
                    else if (inputSelection == 2)
                    {
                        CreateOneDimensionalArrayManually(n, arr);
                    }

                    ShowOneDimensionalArray(arr);

                    Console.WriteLine("Введите номер элемента, который нужно удалить:");
                    int numberToDelete = Convert.ToInt32(Console.ReadLine());
                    int[] res = DeleteElementInOneDimensionalArray(numberToDelete, arr);
                    if (res != null)
                    {
                        ShowOneDimensionalArray(res);
                    }
                    else
                    {
                        Console.WriteLine("Элемента с таким номером нет в массиве");
                    }
                }
                else
                {
                    Console.WriteLine("Введено отрицательное число или 0, массив не создан");
                }
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Вы ввели буквы или десятичное число, будьте впредь аккуратны");

        }
    
        static int[] CreateOneDimensionalArray(int n, int[] arr) // создание массива с помощью ДСЧ
        {

            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                arr[i] = rnd.Next(0, 21);
            }
            return arr;
        }

        static int[] CreateOneDimensionalArrayManually(int n, int[] arr) // создание массива вручную
        {
            Console.WriteLine("Введите числа массива:");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            return arr;
        }
        static void ShowOneDimensionalArray(int[] array) // вывод массива
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        static int[] DeleteElementInOneDimensionalArray(int n, int[] arr) // удаление элемента в массиве
        {
            if (n > -1 && n < arr.Length)
            {
                int[] arr2 = new int[arr.Length - 1];
                for (int i = 0; i < n; i++)
                {
                    arr2[i] = arr[i];
                }
                for (int i = n; i < arr.Length - 1; i++)
                {
                    arr2[i] = arr[i + 1];
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