using System.Data.SqlTypes;
using System.Security.Cryptography.X509Certificates;

class Programm
{
    // в другие перемменный ввести первое и последнее слово, из основной удалить их и потом сложить как надо
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Выберите: \n 1)Ввести строку вручную \n 2)Выбрать одну из готовых");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("Введите строку:");
                string string1 = Console.ReadLine();
                string1.TrimStart(); // удаляет пробелы в начале
                string1.TrimEnd(); // удаляет пробелы в конце
                string result = FindLastAndFirstWord(string1);
                Console.WriteLine(result);
            }
            else if(choice == 2)
            {
                Console.WriteLine("1)В город ворвалась зима. " +
                    "\n2)Отец помыл машину на автомобильной мойке." +
                    "\n3)Дети катаются на самокате.");
                int choiceString = Convert.ToInt32(Console.ReadLine());
                string string2 = " ";
                if (choiceString == 1)
                {
                     string2 = "В город ворвалась зима.";
                }
                else if( choiceString == 2)
                {
                     string2 = "Отец помыл машину на автомобильной мойке.";
                }
                else if (choiceString == 3)
                {
                     string2 = "Дети катаются на самокате.";
                }
                else
                {
                    Console.WriteLine("Вы ввели не то.");
                }
                string2.TrimStart(); // удаляет пробелы в начале
                string2.TrimEnd(); // удаляет пробелы в конце
                string result = FindLastAndFirstWord(string2);
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Вы ввели не то.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Вы ввели пустую строку");
        }
    }
    static string FindLastAndFirstWord(string string1)
    {
        int indexFirstSpace = 0;
        int indexLastSpace = 0;
        for (int i = 0; i < string1.Length; i++) //находит индекс первого пробела
        {
            if(string1[i] == ' ' || string1[i] == ',' || string1[i] == '.' || string1[i] == ':' || string1[i] == ';')
            {
                indexFirstSpace = i;
                break;
            }
        }
        for (int i = string1.Length-2; i > 0; i--) // находит индекс последнего пробела
        {
            if (string1[i] == ' ' || string1[i] == ',' || string1[i] == '.' || string1[i] == ':' || string1[i] == ';')
            {
                indexLastSpace = i;
                break;
            }
        }

        string firstWord = string1.Substring(0, indexFirstSpace);
        string lastWord = string1.Substring(indexLastSpace+1, string1.Length- indexLastSpace-2);
        string mainString = string1.Substring(indexFirstSpace, string1.Length- firstWord.Length - lastWord.Length-1);
        mainString = mainString.Insert(0, lastWord);
        mainString = mainString.Insert(mainString.Length, firstWord);
        string lastSign = string1.Substring(string1.Length - 1);
        mainString += lastSign;
        return mainString;
    }  
}