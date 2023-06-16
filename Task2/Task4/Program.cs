//  Реализуйте метод, определяющий, является ли одна строка перестановкой другой. 
//  Под перестановкой понимаем любое изменение порядка символов. 
//  Регистр учитывается, пробелы являются существенными.
class Program
{
    static void Main(string[]args)
    {
        Console.Write("Enter the string to be checked: ");
        string original = Console.ReadLine();

        Console.Write("\nEnter a string to compare against: ");
        string modified = Console.ReadLine();

        Console.WriteLine();

        StringComparison(original, modified);
    }
    static void StringComparison(string str1, string str2)
    {
        if(str1.Length != str2.Length)
        {
            Console.WriteLine("The number of characters of the strings does not match");

            Console.WriteLine("\nEnter any value to continue");

            Console.ReadKey();

            return;
        }
        else if (str1 == str2)
        {
            Console.WriteLine("String are identical");

            Console.WriteLine("\nEnter any value to continue");

            Console.ReadKey();

            return;
        }
        for (int i = 0; i < str1.Length; i++)
        {
            for (int j = 0; j < str2.Length; j++)
            {
                if (str1[i] == str2[j])
                {
                    str2 = str2.Remove(j,1);
                    break;
                }
            }
        }
        if (str2 == "")
        {
            Console.WriteLine("The second line is a permutation of the first");
        }
        else
        {
            Console.WriteLine("The second line is NOT a permutation of the first");
        }
        Console.Write("\nEnter any value to continue: ");

        Console.ReadKey();

        // Console.Clear();
    }
}