class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("This program will output the word with opening and closing brackets");

        Console.Write("\nInput: ");

        string userInput = Console.ReadLine();

        LineChange(userInput);

        Console.WriteLine();
    }
    static void LineChange(string userInput)
    {
        int count = userInput.Length;

        bool parity = false;

        if (count % 2 == 0)
        {
            count = count / 2;
            parity = true;
        } 
        else
            count = count / 2 + 1;

        int subtitution = 0;
        
        for (int i = 0; i < count; i++)
        {
            userInput = userInput.Insert(subtitution, "(");

            subtitution += 2;
        }
        if (parity)
            subtitution++;

        for (int i = 0; i < count; i++)
        {
            userInput = userInput.Insert(subtitution, ")");

            subtitution += 2;
        }
        System.Console.WriteLine("\n" + userInput);
    }
}