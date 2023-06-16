//  Найти первый наиболее часто повторяющийся в строке символ.

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("To findd the first most repeated character in a string, enter your text");

        Console.Write("\nInput: ");

        string userInput = Console.ReadLine();

        if (userInput != "")
        {
            StringCompression(userInput);
        }
        else
            Console.WriteLine("\nString contains no characters");
    }
    static void StringCompression(string userStr)
    {
        Dictionary <char, int> countChar = new Dictionary <char, int>();

        foreach (var userChar in userStr)
        {
            if (countChar.ContainsKey(userChar))
            {
                countChar[userChar] += 1;
            }
            else
            {
                countChar.Add(userChar,1);
            }
        }
        int maxValue = 0;
        char maxChar = ' ';

        foreach (var index in countChar)
        {
            if (index.Value > maxValue)
            {
                maxValue = index.Value;

                maxChar = index.Key;
            }
        }
        Console.WriteLine($"\nThe most frequently repeated character is \"{maxChar}\".");
        Console.WriteLine($"\nIt is found {maxValue} times in the text.");
    }
}

